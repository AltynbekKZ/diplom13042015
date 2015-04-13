using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace WAknowledgebase.Controllers
{
    public abstract class DataAccess
    {
        private string _connectionString = null;
        protected string ConnectionString
        {
            get
            {
                if (_connectionString == null)
                {
                    _connectionString = @"Data Source=dellhome\sqlexpress;Initial Catalog=knowledgebase;Integrated Security=True";
                }
                return _connectionString;
            }
        }

        protected IDataReader ExecuteReader(DbCommand cmd)
        {
            return ExecuteReader(cmd, CommandBehavior.Default);
        }

        protected IDataReader ExecuteReader(DbCommand cmd, CommandBehavior behavior)
        {
            return cmd.ExecuteReader(behavior);
        }

    }

}