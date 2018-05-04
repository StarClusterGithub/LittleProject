using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace SmartShelves
{
    /// <summary>
    /// 无人超市数据操作类,主要负责对SQLite进行操作
    /// </summary>
    static class USDataAccess
    {
        //数据库文件所在路径
        private const string dbPath = @".\Database\usDB.sqlite";
        //数据库连接
        private readonly static SQLiteConnection connection = new SQLiteConnection($"Data Source = {dbPath}; Version = 3;");
        //线程锁
        private static object synObj = new object();
        private static bool isLock = false;

        /// <summary>
        /// 创建数据库,如果已创建则什么都不做
        /// </summary>
        static USDataAccess()
        {
            //如果不存在数据库则创建数据库及数据表
            //
            //商品表
            //id 商品id
            //name 商品名
            //price 价格
            //manufacturer 生产厂家
            //productiondate 生产日期
            //validuntil 有效期
            //shelflife 保质期
            //inventory 库存数
            //
            //终端表
            //tid 终端id
            //cardId 卡id
            //commodityId 商品id
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
                string queryStr = @"create table [commodity]
                                (
                                    [id] int not null primary key, 
                                    [name] nchar(50) not null, 
                                    [price] numeric(6,2) not null,
                                    [manufacturer] nchar(50) not null, 
                                    [productiondate] nchar(10) not null, 
                                    [validuntil] nchar(10) not null, 
                                    [shelflife] int not null, 
                                    [inventory] int not null
                                );
                                create table [terminal]
                                (
                                    [tid] int not null, 
                                    [cardId] nchar(4) not null, 
                                    [commodityId] int not null,
                                    primary key([tid],[cardId])
                                );";
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(queryStr, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            //测试代码
            //USDataAccess.Insert("insert into [terminal] values(1234,'0x01',1234);");
            //USDataAccess.Insert("insert into [terminal] values(2234,'0x02',2234);");
            //USDataAccess.Insert("insert into [terminal] values(4234,'0x03',3234);");
            //USDataAccess.Insert("insert into [commodity] values(3234,'测试',12.34,'china','2018-01-01','2018-03-01',2,40);");
            //dgvDisplay.DataSource = USDataAccess.Select("select * from [terminal] as t1 join [commodity] as t2 on t1.commodityId = t2.id");
            //USDataAccess.Delete("delete from [terminal] where tid = 1234;");
            //USDataAccess.Update("update [terminal] set [tid] = 3234 where [cardId] = '0x03';");
        }

        /// <summary>
        /// 商品表列名属性器
        /// </summary>
        static public string[] CommodityColumns
        {
            get
            {
                return new string[] { "[id]", "[name]", "[price]", "[manufacturer]", "[productiondate]", "[validuntil]", "[shelflife]", "[inventory]" };
            }
        }

        /// <summary>
        /// 终端表列名属性器
        /// </summary>
        static public string[] TerminalColumns
        {
            get
            {
                return new string[] { "[tid]", "[cardId]", "[commodityId]" };
            }
        }

        /// <summary>
        /// 以指定select语句对数据库进行查询,并返回数据表
        /// </summary>
        /// <param name="queryStr">查询语句</param>
        /// <returns>查询语句对应的查询结果</returns>
        static public DataTable Select(string queryStr)
        {
            for (; IsLock;)
                ;
            IsLock = true;
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(queryStr, connection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable table = new DataTable("table1");
            if(connection.State.Equals(ConnectionState.Closed))
                connection.Open();
            adapter.Fill(table);
            connection.Close();
            IsLock = false;
            return table;
        }

        /// <summary>
        /// 按照输入的查询语句对数据库进行更新
        /// </summary>
        /// <param name="queryStr">update语句</param>
        static public void Update(string queryStr)
        {
            for (; IsLock;)
                ;
            IsLock = true;
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(queryStr, connection);
            command.ExecuteNonQuery();
            connection.Close();
            IsLock = false;
        }

        /// <summary>
        /// 以指定的insert语句将新行添加到数据库
        /// </summary>
        /// <param name="queryStr">insert语句</param>
        static public void Insert(string queryStr)
        {
            for (; IsLock;)
                ;
            IsLock = true;
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(queryStr, connection);
            command.ExecuteNonQuery();
            connection.Close();
            IsLock = false;
        }

        /// <summary>
        /// 从数据库中删除指定的行
        /// </summary>
        /// <param name="queryStr">delete语句</param>
        static public void Delete(string queryStr)
        {
            for (; IsLock;)
                ;
            IsLock = true;
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(queryStr, connection);
            command.ExecuteNonQuery();
            connection.Close();
            IsLock = false;
        }

        /// <summary>
        /// 同步状态属性器,此类在被使用时为true,否则为false
        /// </summary>
        static bool IsLock
        {
            get
            {
                lock(synObj)
                {
                    return isLock;
                }
            }
            set
            {
                lock(synObj)
                {
                    isLock = value;
                }
            }
        }
    }
}
