namespace FinManageAPI.Database.Interfaces;

public interface IDatabaseSetting
{
    string ConnectionString { get; set; }
    string DatabaseName { get; set; }
}