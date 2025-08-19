using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentCFG.Models
{

    public class PaymentRootModel
    {
        public Paymentsapiconfig PaymentsApiConfig { get; set; }
        public Snappayclient SnapPayClient { get; set; }
        public Snappayapiendpoints SnapPayApiEndpoints { get; set; }
        public Account[] Accounts { get; set; }
        public Connectionstrings ConnectionStrings { get; set; }
        public Databaseconfig DatabaseConfig { get; set; }
        public Sqliteconfig SqliteConfig { get; set; }
        public Healthchecks HealthChecks { get; set; }
        public Swagger Swagger { get; set; }
        public Logconfig LogConfig { get; set; }
        public Logging Logging { get; set; }
        public string AllowedHosts { get; set; }
    }

    public class Paymentsapiconfig
    {
        public string Version { get; set; }
        public string Environment { get; set; }
        public string BaseUrl { get; set; }
    }

    public class Snappayclient
    {
        public bool useBodyContent { get; set; }
        public bool useMd5ForHmac { get; set; }
        public string agency { get; set; }
    }

    public class Snappayapiendpoints
    {
        public string baseUrl { get; set; }
        public string hostedPageURL_v1 { get; set; }
        public string hostedPageURL { get; set; }
        public string healthCheckURL { get; set; }
        public int healthCheckStatusCode { get; set; }
        public string uriExtensionRequestID { get; set; }
        public string uriExtensionPaymentDetail { get; set; }
        public string uriExtensionTransaction { get; set; }
    }

    public class Connectionstrings
    {
        public string ProductionConnection { get; set; }
        public string StagingConnection { get; set; }
        public string LocalConnection { get; set; }
        public string DefaultConnection { get; set; }
    }

    public class Databaseconfig
    {
        public string ConnectionString { get; set; }
        public string ConnectionStringName { get; set; }
        public int CommandTimeout { get; set; }
        public bool CheckConnection { get; set; }
        public bool Enabled { get; set; }
    }

    public class Sqliteconfig
    {
        public string DatabasePath { get; set; }
        public int ConnectionTimeout { get; set; }
        public bool CheckConnection { get; set; }
        public bool CreateDatabase { get; set; }
        public bool EnableBackups { get; set; }
        public bool Enabled { get; set; }
    }

    public class Healthchecks
    {
        public bool Enabled { get; set; }
        public bool HealthCheckUIEnabled { get; set; }
        public string HealthCheckEndPoint { get; set; }
        public bool EnableDatabaseHealthCheck { get; set; }
        public bool EnableServerHealthCheck { get; set; }
        public int EvaluationTimeInSeconds { get; set; }
    }

    public class Swagger
    {
        public bool Enabled { get; set; }
        public string SwaggerJsonEndpoint { get; set; }
        public string SwaggerUIEndpoint { get; set; }
        public string SwaggerApiName { get; set; }
    }

    public class Logconfig
    {
        public bool LogEnabled { get; set; }
        public string LogPath { get; set; }
    }

    public class Logging
    {
        public Loglevel LogLevel { get; set; }
    }

    public class Loglevel
    {
        public string Default { get; set; }
        public string MicrosoftAspNetCore { get; set; }
    }

    public class Account
    {
        public string accountName { get; set; }
        public string applicationId { get; set; }
        public string userName { get; set; }
        public string pwd { get; set; }
        public string accountId { get; set; }
        public string customerId { get; set; }
        public string userId { get; set; }
        public string companyCode { get; set; }
        public string mid { get; set; }
        public string duplicateredirecturl { get; set; }
        public string cancelredirecturl { get; set; }
        public string redirecturl { get; set; }
        public string redirectonerrorurl { get; set; }
        public string secretKey { get; set; }
        public bool enableLevel3 { get; set; }
    }


}
