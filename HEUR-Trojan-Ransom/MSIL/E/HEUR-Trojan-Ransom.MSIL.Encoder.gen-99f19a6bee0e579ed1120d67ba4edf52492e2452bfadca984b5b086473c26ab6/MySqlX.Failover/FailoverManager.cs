using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.Sessions;
using MySqlX.XDevAPI;

namespace MySqlX.Failover;

internal static class FailoverManager
{
	internal static FailoverGroup FailoverGroup { get; private set; }

	internal static void Reset()
	{
		if (FailoverGroup != null)
		{
			FailoverGroup = null;
		}
	}

	internal static void SetHostList(List<XServer> hostList, FailoverMethod failoverMethod)
	{
		switch (failoverMethod)
		{
		case FailoverMethod.Priority:
			FailoverGroup = new SequentialFailoverGroup(hostList.OrderByDescending((XServer o) => o.Priority).ToList());
			break;
		case FailoverMethod.Sequential:
			FailoverGroup = new SequentialFailoverGroup(hostList);
			break;
		}
	}

	internal static InternalSession AttemptConnection(string originalConnectionString, out string connectionString)
	{
		if (FailoverGroup != null && originalConnectionString != null)
		{
			XServer xServer = FailoverGroup.ActiveHost;
			string host = xServer.Host;
			MySqlXConnectionStringBuilder mySqlXConnectionStringBuilder = null;
			InternalSession internalSession = null;
			TimeoutException ex = null;
			do
			{
				connectionString = "server=" + xServer.Host + ";" + originalConnectionString.Substring(originalConnectionString.IndexOf(';') + 1);
				mySqlXConnectionStringBuilder = new MySqlXConnectionStringBuilder(connectionString);
				if (xServer != null && xServer.Port != -1)
				{
					mySqlXConnectionStringBuilder.Port = (uint)xServer.Port;
				}
				if (xServer.Host == host)
				{
					ex = new TimeoutException((mySqlXConnectionStringBuilder.ConnectTimeout == 0) ? ResourcesX.TimeOutMultipleHost0ms : string.Format(ResourcesX.TimeOutMultipleHost, mySqlXConnectionStringBuilder.ConnectTimeout));
				}
				try
				{
					internalSession = InternalSession.GetSession(mySqlXConnectionStringBuilder);
					ex = null;
				}
				catch (Exception ex2)
				{
					if (!(ex2 is TimeoutException))
					{
						ex = null;
					}
				}
				if (internalSession != null)
				{
					break;
				}
				xServer = FailoverGroup.GetNextHost();
			}
			while (xServer.Host != host);
			if (ex != null)
			{
				throw ex;
			}
			if (internalSession == null)
			{
				throw new MySqlException(Resources.UnableToConnectToHost);
			}
			return internalSession;
		}
		connectionString = null;
		return null;
	}
}
