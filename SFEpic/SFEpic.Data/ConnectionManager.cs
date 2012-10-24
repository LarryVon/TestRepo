using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace SFEpic.Data
{
    public class ConnectionManager : IDisposable
    {
        public ConnectionManager(string dbProvider, string connectionString)
        {
            ConnectionString = connectionString;
            DbProvider = dbProvider;
            factory = DbProviderFactories.GetFactory(dbProvider);
            InitConnection();
        }

        public ConnectionManager(string dbProvider, string connectionString, bool releaseConnectinoPoolOnDeRef)
            : this(dbProvider, connectionString)
        {
            ReleaseObjectPoolOnDeRef = releaseConnectinoPoolOnDeRef;
        }

        public string ConnectionString
        {
            get;
            protected set;
        }

        public DbConnection Connection
        {
            get
            {
                return connection;
            }
        }

        public string DbProvider
        {
            get;
            protected set;
        }

        protected DbProviderFactory factory;
        protected DbConnection connection;
        protected virtual void InitConnection()
        {
            connection = factory.CreateConnection();
            connection.ConnectionString = ConnectionString;
            connection.Open();
        }

        public bool IsDisposed
        {
            get;
            protected set;
        }

        public bool ReleaseObjectPoolOnDeRef
        {
            get;
            protected set;
        }

        protected int refCount = 0;
        protected internal void AddRef()
        {
            refCount++;
        }

        protected internal void DeRef()
        {
            if (--refCount == 0)
            {
                connection.Close();
                //if (ReleaseObjectPoolOnDeRef && DbProvider.Contains("Odbc"))
                //{
                //    System.Data.Odbc.OdbcConnection.ReleaseObjectPool();
                //}
                connection.Dispose();
                IsDisposed = true;
            }
        }

        protected internal void ReleaseImmediately()
        {
            refCount = 0;
            connection.Close();
            if (DbProvider.Contains("Odbc"))
            {
                System.Data.Odbc.OdbcConnection.ReleaseObjectPool();
            }
            connection.Dispose();
            IsDisposed = true;
        }

        void IDisposable.Dispose()
        {
            DeRef();
        }
    }
}
