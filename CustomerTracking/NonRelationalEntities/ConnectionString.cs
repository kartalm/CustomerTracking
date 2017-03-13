using CustomerTracking.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTracking.NonRelationalEntities
{
    public static class ConnectionString
    {
        private static string _hostName = string.Empty;

        private static string _sqlInstanceName = string.Empty;

        private static string _databaseName = string.Empty;

        private static string _sqlServerUserName = string.Empty;

        private static string _sqlServerUserPassword = string.Empty;

        private static string _sqlConnectionString = string.Empty;

        private static bool _integratedSecurity = false;

        public static string HostName
        {
            get
            {
                if (_hostName.IsNullOrEmpty())
                {
                    _hostName = System.Net.Dns.GetHostName();
                }

                return _hostName;
            }
            set
            {
                _hostName = value;
            }
        }

        public static string SqlInstanceName
        {
            get
            {
                if (_sqlInstanceName.IsNullOrEmpty())
                {
                    _sqlInstanceName = @"SQLEXPRESS";
                }

                return _sqlInstanceName;
            }
            set
            {
                _sqlInstanceName = value;
            }
        }

        public static string DatabaseName
        {
            get
            {
                if (_databaseName.IsNullOrEmpty())
                {
                    _databaseName = @"CustomerTracking";
                }

                return _databaseName;
            }
            set
            {
                _databaseName = value;
            }
        }

        public static bool IntegratedSecurity
        {
            get
            {
                return _integratedSecurity;
            }
            set
            {
                _integratedSecurity = value;
            }
        }

        public static string SqlServerUserName
        {
            get
            {
                if (_sqlServerUserName.IsNullOrEmpty())
                {
                    _sqlServerUserName = @"sa";
                }

                return _sqlServerUserName;
            }
            set
            {
                _sqlServerUserName = value;
            }
        }

        public static string SqlServerUserPassword
        {
            get
            {
                if (_sqlServerUserPassword.IsNullOrEmpty())
                {
                    _sqlServerUserPassword = @"eae2014*";
                }

                return _sqlServerUserPassword;
            }
            set
            {
                _sqlServerUserPassword = value;
            }
        }

        public static string ToString()
        {
            _sqlConnectionString = @"Data Source=" + HostName + @"\" + SqlInstanceName + @";MultipleActiveResultSets=true;Initial Catalog=" + DatabaseName + (IntegratedSecurity ? ";Integrated Security=true;" : @";user id=" + SqlServerUserName + @";password=" + SqlServerUserPassword + @";");

            return _sqlConnectionString;

        }

    }
}
