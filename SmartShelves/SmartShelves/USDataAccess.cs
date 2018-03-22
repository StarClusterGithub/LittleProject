using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace SmartShelves
{
    #region PUBLIC
    /// <summary>
    /// 无人超市数据操作类,主要负责对SQLite进行操作
    /// </summary>
    class USDataAccess
    {

        /// <summary>
        /// 获取唯一实例的引用,如果不存在则创建一个实例,此后所有请求都返回该实例
        /// </summary>
        public static USDataAccess Ref
        {
            get
            {
                lock (refLock)
                {
                    if (self == null)
                        self = new USDataAccess();
                    return self;
                }
            }
        }



        /// <summary>
        /// 析构函数,为了防止实例被意外干掉,因此在这里将self置为null
        /// </summary>
        ~USDataAccess()
        {
            self = null;
        }

        #endregion


        #region PRIVATE

        //用于防止多线程多次获取实例的锁
        private static object refLock = new object();
        //类内部存储的对自身的引用
        private static USDataAccess self = null;
        //数据库路径
        private const string dbPath = @"..\..\database\usDB.sqlite";
        //数据库连接
        private readonly SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source = {0}; Version = 3;",dbPath));

        /// <summary>
        /// 私有构造函数,仅用于属性器Ref创建唯一实例
        /// 在构造函数内对数据库进行初始化
        /// </summary>
        private USDataAccess()
        {
            //如果不存在数据库则创建数据库及数据表
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
                string queryStr = @"create table [commodity]
                                (
                                    [id] int not null primary key, 
                                    [name] nchar(10) not null, 
                                    [manufacturer] nchar(10) not null, 
                                    [productiondate] date not null, 
                                    [validuntil] date not null, 
                                    [shelflife] int not null, 
                                    [inventory] int not null
                                );
                                create table [terminal]
                                (
                                    [tid] int not null primary key, 
                                    [cardId] int not null, 
                                    [commodityId] int not null
                                );";
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(queryStr,connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        #endregion
    }
}
