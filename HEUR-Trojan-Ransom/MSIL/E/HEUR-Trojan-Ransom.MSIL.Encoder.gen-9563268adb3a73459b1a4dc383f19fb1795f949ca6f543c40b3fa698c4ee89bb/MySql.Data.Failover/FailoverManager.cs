using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using MySql.Data.MySqlClient;
using MySqlX.Sessions;
using MySqlX.XDevAPI;

namespace MySql.Data.Failover;

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

	internal static void SetHostList(List<FailoverServer> hostList, FailoverMethod failoverMethod)
	{
		if (FailoverGroup != null)
		{
			return;
		}
		switch (failoverMethod)
		{
		case FailoverMethod.Sequential:
			FailoverGroup = new SequentialFailoverGroup(hostList);
			break;
		case FailoverMethod.Priority:
			FailoverGroup = new SequentialFailoverGroup(hostList.OrderByDescending((FailoverServer o) => o.Priority).ToList());
			break;
		case FailoverMethod.Random:
			FailoverGroup = new RandomFailoverGroup(hostList);
			break;
		}
	}

	internal static InternalSession AttemptConnectionXProtocol(string originalConnectionString, out string connectionString, bool isDefaulPort, Client client = null)
	{
		if (FailoverGroup != null && originalConnectionString != null)
		{
			if (client != null)
			{
				if (client.Hosts == null)
				{
					client.Hosts = FailoverGroup.Hosts;
					client.DemotedHosts = new ConcurrentQueue<FailoverServer>();
				}
				else
				{
					FailoverGroup.Hosts = client.Hosts;
				}
			}
			FailoverServer failoverServer = FailoverGroup.ActiveHost;
			FailoverServer other = failoverServer;
			MySqlXConnectionStringBuilder mySqlXConnectionStringBuilder = null;
			InternalSession internalSession = null;
			do
			{
				connectionString = ((!originalConnectionString.Contains("server")) ? ("server=" + failoverServer.Host + ";" + originalConnectionString) : originalConnectionString.Replace(originalConnectionString.Split(new char[1] { ';' }).First((string p) => p.Contains("server")).Split(new char[1] { '=' })[1], failoverServer.Host));
				if (failoverServer != null && failoverServer.Port != -1)
				{
					connectionString = connectionString.Replace(connectionString.Split(new char[1] { ';' }).First((string p) => p.Contains("port")).Split(new char[1] { '=' })[1], failoverServer.Port.ToString());
				}
				mySqlXConnectionStringBuilder = new MySqlXConnectionStringBuilder(connectionString, isDefaulPort);
				try
				{
					internalSession = InternalSession.GetSession(mySqlXConnectionStringBuilder);
				}
				catch (Exception)
				{
				}
				if (internalSession != null)
				{
					break;
				}
				FailoverServer failoverServer2 = failoverServer;
				failoverServer = FailoverGroup.GetNextHost();
				if (client != null)
				{
					failoverServer2.DemotedTime = DateTime.Now;
					client.Hosts.Remove(failoverServer2);
					client.DemotedHosts.Enqueue(failoverServer2);
					if (client.DemotedServersTimer == null)
					{
						client.DemotedServersTimer = new Timer(client.ReleaseDemotedHosts, null, 120000, -1);
					}
				}
			}
			while (!failoverServer.Equals(other));
			if (internalSession == null)
			{
				throw new MySqlException(Resources.UnableToConnectToHost);
			}
			return internalSession;
		}
		connectionString = null;
		return null;
	}

	internal static void AttemptConnection(MySqlConnection connection, string originalConnectionString, out string connectionString, bool mySqlPoolManager = false)
	{
		if (mySqlPoolManager)
		{
			if (MySqlPoolManager.Hosts == null)
			{
				MySqlPoolManager.Hosts = FailoverGroup.Hosts;
				MySqlPoolManager.DemotedHosts = new ConcurrentQueue<FailoverServer>();
			}
			else
			{
				FailoverGroup.Hosts = MySqlPoolManager.Hosts;
			}
		}
		FailoverServer failoverServer = FailoverGroup.ActiveHost;
		FailoverServer other = failoverServer;
		Driver driver = null;
		do
		{
			connectionString = "server=" + failoverServer.Host + ";" + originalConnectionString.Substring(originalConnectionString.IndexOf(';') + 1);
			if (failoverServer != null && failoverServer.Port != -1)
			{
				connectionString = connectionString + ";port=" + failoverServer.Port;
			}
			MySqlConnectionStringBuilder settings = new MySqlConnectionStringBuilder(connectionString);
			if ((FailoverGroup.Hosts.Count == 1 && !mySqlPoolManager) || (mySqlPoolManager && MySqlPoolManager.Hosts.Count == 1 && MySqlPoolManager.DemotedHosts.IsEmpty))
			{
				return;
			}
			try
			{
				driver = Driver.Create(settings);
				if (!mySqlPoolManager)
				{
					connection.driver = driver;
				}
			}
			catch (Exception)
			{
				goto IL_00a1;
			}
			break;
			IL_00a1:
			FailoverServer failoverServer2 = failoverServer;
			failoverServer = FailoverGroup.GetNextHost();
			if (mySqlPoolManager)
			{
				failoverServer2.DemotedTime = DateTime.Now;
				MySqlPoolManager.Hosts.Remove(failoverServer2);
				MySqlPoolManager.DemotedHosts.Enqueue(failoverServer2);
				if (MySqlPoolManager.DemotedServersTimer == null)
				{
					MySqlPoolManager.DemotedServersTimer = new Timer(MySqlPoolManager.ReleaseDemotedHosts, null, 120000, -1);
				}
			}
		}
		while (!failoverServer.Equals(other));
		if (driver == null)
		{
			throw new MySqlException(Resources.UnableToConnectToHost);
		}
	}

	internal static int ParseHostList(string hierPart, bool isXProtocol, bool connectionDataIsUri = true)
	{
		if (string.IsNullOrWhiteSpace(hierPart))
		{
			return -1;
		}
		int num = -1;
		FailoverMethod failoverMethod = FailoverMethod.Random;
		string[] array = null;
		List<FailoverServer> list = new List<FailoverServer>();
		hierPart = hierPart.Replace(" ", "");
		if (!hierPart.StartsWith("(") && !hierPart.EndsWith(")"))
		{
			array = hierPart.Split(new char[1] { ',' });
			if (array.Length == 1)
			{
				return 1;
			}
			string[] array2 = array;
			foreach (string host in array2)
			{
				list.Add(ConvertToFailoverServer(host, -1, -1, connectionDataIsUri));
			}
			num = array.Length;
		}
		else
		{
			string[] array3 = hierPart.Split(new string[1] { "),(" }, StringSplitOptions.RemoveEmptyEntries);
			bool? flag = null;
			int priority = -1;
			string[] array2 = array3;
			foreach (string text in array2)
			{
				string text2 = text;
				if (text2.StartsWith("("))
				{
					text2 = text.Substring(1);
				}
				if (text2.EndsWith(")"))
				{
					text2 = text2.Substring(0, text2.Length - 1);
				}
				string[] array4 = text2.Split(new char[1] { ',' });
				string[] array5 = array4[0].Split(new char[1] { '=' });
				if (!(array5[0].ToLowerInvariant() != "address"))
				{
					string text3 = array5[1];
					if (!string.IsNullOrWhiteSpace(text3))
					{
						if (array4.Length == 2)
						{
							if (flag.HasValue && flag == false)
							{
								throw new ArgumentException(ResourcesX.PriorityForAllOrNoHosts);
							}
							flag = flag ?? true;
							string[] array6 = array4[1].Split(new char[1] { '=' });
							if (array6[0].ToLowerInvariant() != "priority")
							{
								throw new KeyNotFoundException(string.Format(ResourcesX.KeywordNotFound, "priority"));
							}
							if (string.IsNullOrWhiteSpace(array6[1]))
							{
								throw new ArgumentNullException("priority");
							}
							int result = -1;
							int.TryParse(array6[1], out result);
							if (result < 0 || result > 100)
							{
								throw new ArgumentException(ResourcesX.PriorityOutOfLimits);
							}
							if (isXProtocol)
							{
								list.Add(ConvertToFailoverServer(BaseSession.IsUnixSocket(text3) ? BaseSession.NormalizeUnixSocket(text3) : text3, result, -1, connectionDataIsUri));
							}
							else
							{
								list.Add(ConvertToFailoverServer(text3, result));
							}
						}
						else
						{
							if (flag.HasValue && flag == true)
							{
								throw new ArgumentException(ResourcesX.PriorityForAllOrNoHosts);
							}
							flag = flag.GetValueOrDefault();
							list.Add(ConvertToFailoverServer(text3, priority, -1, connectionDataIsUri));
						}
						continue;
					}
					throw new ArgumentNullException("server");
				}
				throw new KeyNotFoundException(string.Format(ResourcesX.KeywordNotFound, "address"));
			}
			num = array3.Length;
			failoverMethod = (((from h in list
				group h by h.Priority).ToList().Count > 1) ? FailoverMethod.Priority : FailoverMethod.Random);
		}
		SetHostList(list, failoverMethod);
		return num;
	}

	private static FailoverServer ConvertToFailoverServer(string host, int priority = -1, int port = -1, bool connectionDataIsUri = true)
	{
		host = host.Trim();
		int num = -1;
		if (IPAddress.TryParse(host, out var address))
		{
			if (address.AddressFamily == AddressFamily.InterNetworkV6)
			{
				if (host.StartsWith("[") && host.Contains("]") && !host.EndsWith("]"))
				{
					num = host.LastIndexOf(":");
				}
			}
			else
			{
				num = host.IndexOf(":");
			}
		}
		else
		{
			num = host.IndexOf(":");
		}
		if (num != -1)
		{
			if (!connectionDataIsUri)
			{
				throw new ArgumentException(ResourcesX.PortNotSupported);
			}
			int.TryParse(host.Substring(num + 1), out port);
			host = host.Substring(0, num);
		}
		return new FailoverServer(host, port, priority);
	}
}
