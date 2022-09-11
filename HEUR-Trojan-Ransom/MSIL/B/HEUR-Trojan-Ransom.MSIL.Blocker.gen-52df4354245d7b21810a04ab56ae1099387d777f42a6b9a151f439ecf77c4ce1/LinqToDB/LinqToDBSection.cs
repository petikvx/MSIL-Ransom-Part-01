using System.Collections.Generic;
using System.Linq;
using LinqToDB.Configuration;

namespace LinqToDB;

public class LinqToDBSection : ILinqToDBSettings
{
	private readonly IEnumerable<ConnectionStringSettings> connectionStringSettings;

	public IEnumerable<IDataProviderSettings> DataProviders => Enumerable.Empty<IDataProviderSettings>();

	public string DefaultConfiguration { get; private set; }

	public string DefaultDataProvider { get; private set; }

	public IEnumerable<IConnectionStringSettings> ConnectionStrings
	{
		get
		{
			foreach (ConnectionStringSettings connectionStringSetting in connectionStringSettings)
			{
				yield return (IConnectionStringSettings)(object)connectionStringSetting;
			}
		}
	}

	public LinqToDBSection(IEnumerable<ConnectionStringSettings> connectionStringSettings, string defaultConfiguration = null)
	{
		this.connectionStringSettings = connectionStringSettings;
		ConnectionStringSettings connectionStringSettings2 = connectionStringSettings?.FirstOrDefault();
		DefaultConfiguration = defaultConfiguration ?? connectionStringSettings2?.Name;
		DefaultDataProvider = connectionStringSettings2?.ProviderName;
	}
}
