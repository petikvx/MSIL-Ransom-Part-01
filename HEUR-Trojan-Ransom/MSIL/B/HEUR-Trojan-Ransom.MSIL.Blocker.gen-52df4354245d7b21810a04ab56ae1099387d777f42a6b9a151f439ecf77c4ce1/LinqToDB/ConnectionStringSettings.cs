using LinqToDB.Configuration;

namespace LinqToDB;

public class ConnectionStringSettings : IConnectionStringSettings
{
	public string ConnectionString { get; set; }

	public string Name { get; set; }

	public string ProviderName { get; set; }

	public bool IsGlobal => false;
}
