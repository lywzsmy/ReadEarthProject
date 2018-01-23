﻿/*******************************************************************************
 * Copyright © 2016 Readearth.Framework 版权所有
 * Author: Readearth
 * Description: Readearth快速开发平台
 * Website：http://www.readearth.com
*********************************************************************************/
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Readearth.Data.Extensions
{
    public class DbHelper
    {
        private static string connstring = ConfigurationManager.ConnectionStrings["ReadearthDbContext"].ConnectionString;
        public static int ExecuteSqlCommand(string cmdText)
        {
            using (DbConnection conn = new SqlConnection(connstring))
            {
                DbCommand cmd = new SqlCommand();
                PrepareCommand(cmd, conn, null, CommandType.Text, cmdText, null);
                return cmd.ExecuteNonQuery();
            }
        }
        private static void PrepareCommand(DbCommand cmd, DbConnection conn, DbTransaction isOpenTrans, CommandType cmdType, string cmdText, DbParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (isOpenTrans != null)
                cmd.Transaction = isOpenTrans;
            cmd.CommandType = cmdType;
            if (cmdParms != null)
            {
                cmd.Parameters.AddRange(cmdParms);
            }
        }
    }
}
