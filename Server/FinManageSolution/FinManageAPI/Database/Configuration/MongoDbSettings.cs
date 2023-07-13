using FinManageAPI.Database.Interfaces;

namespace FinManageAPI.Database.Configuration;

public class MongoDbSettings : IDatabaseSetting
{
    public string ConnectionString { get; set; } = String.Empty;
    public string DatabaseName { get; set; } = String.Empty;
}