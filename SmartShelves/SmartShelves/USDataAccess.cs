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
                                    [productiondate] date not null, 
                                    [validuntil] date not null, 
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
        }

        /// <summary>
        /// 以指定select语句对数据库进行查询,并返回数据表
        /// </summary>
        /// <param name="queryStr">查询语句</param>
        /// <returns>查询语句对应的查询结果</returns>
        static public DataTable Select(string queryStr)
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(queryStr, connection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable table = new DataTable("table1");
            adapter.Fill(table);
            connection.Close();
            return table;
        }

        /// <summary>
        /// 按照输入的查询语句对数据库进行更新
        /// </summary>
        /// <param name="queryStr">update语句</param>
        static public void Update(string queryStr)
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(queryStr, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// 以指定的insert语句将新行添加到数据库
        /// </summary>
        /// <param name="queryStr">insert语句</param>
        static public void Insert(string queryStr)
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(queryStr, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// 从数据库中删除指定的行
        /// </summary>
        /// <param name="queryStr">delete语句</param>
        static public void Delete(string queryStr)
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(queryStr, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
