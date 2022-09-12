using MySqlX.DataAccess;
using MySqlX.XDevAPI;

namespace MySqlX.RoutingServices;

internal abstract class RoutingServiceBase
{
	protected MySqlXConnectionStringBuilder settings;

	public RoutingServiceBase(MySqlXConnectionStringBuilder settings)
	{
		this.settings = settings;
	}

	public virtual MySqlXConnectionStringBuilder GetCurrentConnection()
	{
		return settings;
	}

	public abstract MySqlXConnectionStringBuilder GetCurrentConnection(ConnectionMode mode);
}
