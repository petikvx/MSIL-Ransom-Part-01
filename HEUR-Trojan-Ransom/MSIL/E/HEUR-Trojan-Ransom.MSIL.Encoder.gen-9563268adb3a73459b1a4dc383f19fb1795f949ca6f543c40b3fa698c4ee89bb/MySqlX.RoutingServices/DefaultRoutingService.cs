using MySqlX.DataAccess;
using MySqlX.XDevAPI;

namespace MySqlX.RoutingServices;

internal class DefaultRoutingService : RoutingServiceBase
{
	public DefaultRoutingService(MySqlXConnectionStringBuilder settings)
		: base(settings)
	{
	}

	public override MySqlXConnectionStringBuilder GetCurrentConnection(ConnectionMode mode)
	{
		return settings;
	}
}
