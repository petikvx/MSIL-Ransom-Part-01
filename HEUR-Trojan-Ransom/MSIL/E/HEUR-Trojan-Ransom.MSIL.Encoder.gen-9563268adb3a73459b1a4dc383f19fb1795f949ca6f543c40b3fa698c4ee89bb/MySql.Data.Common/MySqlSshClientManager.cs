using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using MySql.Data.MySqlClient;
using Renci.SshNet;

namespace MySql.Data.Common;

internal static class MySqlSshClientManager
{
	private static List<SshClient> _sshClientList;

	public static SshClient CurrentSshClient { get; private set; }

	static MySqlSshClientManager()
	{
		CurrentSshClient = null;
		_sshClientList = new List<SshClient>();
	}

	internal static void RemoveUnsupportedAlgorithms(SshClient client)
	{
		if (client == null || client.ConnectionInfo == null || client.ConnectionInfo.Encryptions == null)
		{
			return;
		}
		string[] array = new string[5] { "arcfour", "arcfour128", "arcfour256", "blowfish-cbc", "cast128-cbc" };
		foreach (string key in array)
		{
			if (client.ConnectionInfo.Encryptions.ContainsKey(key))
			{
				client.ConnectionInfo.Encryptions.Remove(key);
			}
		}
		if (client.ConnectionInfo.KeyExchangeAlgorithms == null)
		{
			return;
		}
		array = new string[1] { "diffie-hellman-group1-sha1" };
		foreach (string key2 in array)
		{
			if (client.ConnectionInfo.KeyExchangeAlgorithms.ContainsKey(key2))
			{
				client.ConnectionInfo.KeyExchangeAlgorithms.Remove(key2);
			}
		}
		if (client.ConnectionInfo.HmacAlgorithms == null)
		{
			return;
		}
		array = new string[2] { "hmac-md5", "hmac-md5-96" };
		foreach (string key3 in array)
		{
			if (client.ConnectionInfo.HmacAlgorithms.ContainsKey(key3))
			{
				client.ConnectionInfo.HmacAlgorithms.Remove(key3);
			}
		}
	}

	internal static SshClient SetupSshClient(string sshHostName, string sshUserName, string sshPassword, string sshKeyFile, string sshPassphrase, uint sshPort, string server, uint port, bool isXProtocol)
	{
		if (string.IsNullOrEmpty(sshHostName))
		{
			throw new ArgumentException(string.Format(Resources.ParameterCannotBeNullOrEmpty, "sshHostName"));
		}
		if (string.IsNullOrEmpty(sshUserName))
		{
			throw new ArgumentException(string.Format(Resources.ParameterCannotBeNullOrEmpty, "sshUserName"));
		}
		if (string.IsNullOrEmpty(sshKeyFile) && string.IsNullOrEmpty(sshPassword))
		{
			throw new ArgumentException(Resources.SshAuthenticationModeNotSet);
		}
		List<AuthenticationMethod> list = new List<AuthenticationMethod>();
		if (!string.IsNullOrEmpty(sshKeyFile))
		{
			try
			{
				PrivateKeyFile privateKeyFile = (string.IsNullOrEmpty(sshPassphrase) ? new PrivateKeyFile(sshKeyFile) : new PrivateKeyFile(sshKeyFile, sshPassphrase));
				list.Add(new PrivateKeyAuthenticationMethod(sshUserName, privateKeyFile));
			}
			catch (InvalidOperationException)
			{
				throw new ArgumentException(Resources.SshInvalidPassphrase);
			}
		}
		if (!string.IsNullOrEmpty(sshPassword))
		{
			list.Add(new PasswordAuthenticationMethod(sshUserName, sshPassword));
		}
		SshClient sshClient = new SshClient(new ConnectionInfo(sshHostName, (int)sshPort, sshUserName, list.ToArray()));
		RemoveUnsupportedAlgorithms(sshClient);
		ForwardedPortLocal forwardedPortLocal = new ForwardedPortLocal("127.0.0.1", isXProtocol ? port : 3306u, server, port);
		foreach (SshClient sshClient2 in _sshClientList)
		{
			if (!(sshClient.ConnectionInfo.Username == sshClient2.ConnectionInfo.Username) || !(sshClient.ConnectionInfo.Host == sshClient2.ConnectionInfo.Host) || sshClient.ConnectionInfo.Port != sshClient2.ConnectionInfo.Port || !(sshClient.ConnectionInfo.AuthenticationMethods[0].Username == sshClient2.ConnectionInfo.AuthenticationMethods[0].Username) || !(sshClient.ConnectionInfo.AuthenticationMethods[0].Name == sshClient2.ConnectionInfo.AuthenticationMethods[0].Name))
			{
				continue;
			}
			ForwardedPortLocal forwardedPortLocal2 = ((sshClient2.ForwardedPorts.Count() > 0) ? ((ForwardedPortLocal)sshClient2.ForwardedPorts.First()) : null);
			if (forwardedPortLocal2 != null && forwardedPortLocal.Host == forwardedPortLocal2.Host && forwardedPortLocal.Port == forwardedPortLocal2.Port && forwardedPortLocal.BoundHost == forwardedPortLocal2.BoundHost && forwardedPortLocal.BoundPort == forwardedPortLocal2.BoundPort)
			{
				if (!sshClient2.IsConnected)
				{
					sshClient.Connect();
				}
				if (!forwardedPortLocal2.IsStarted)
				{
					forwardedPortLocal2.Start();
				}
				ValidateDeprecatedAlgorithms(sshClient);
				return sshClient2;
			}
		}
		sshClient.Connect();
		sshClient.AddForwardedPort(forwardedPortLocal);
		forwardedPortLocal.Start();
		_sshClientList.Add(sshClient);
		CurrentSshClient = sshClient;
		ValidateDeprecatedAlgorithms(sshClient);
		return sshClient;
	}

	internal static void ValidateDeprecatedAlgorithms(SshClient client)
	{
		if (client != null && client.IsConnected)
		{
			if (new string[1] { "3des-cbc" }.Any((string encryption) => client.ConnectionInfo.CurrentServerEncryption == encryption))
			{
				MySqlTrace.TraceEvent(TraceEventType.Information, MySqlTraceEventType.Warning, Resources.DeprecatedSshAlgorithm, "encryption", client.ConnectionInfo.CurrentServerEncryption);
			}
			if (new string[2] { "diffie-hellman-group14-sha1", "diffie-hellman-group-exchange-sha1" }.Any((string keyExchangeAlgorithm) => client.ConnectionInfo.CurrentKeyExchangeAlgorithm == keyExchangeAlgorithm))
			{
				MySqlTrace.TraceEvent(TraceEventType.Information, MySqlTraceEventType.Warning, Resources.DeprecatedSshAlgorithm, "key exchange", client.ConnectionInfo.CurrentKeyExchangeAlgorithm);
			}
			if (new string[3] { "hmac-sha1", "hmac-sha1-96", "hmac-ripemd160" }.Any((string mac) => client.ConnectionInfo.CurrentServerHmacAlgorithm == mac))
			{
				MySqlTrace.TraceEvent(TraceEventType.Information, MySqlTraceEventType.Warning, Resources.DeprecatedSshAlgorithm, "MAC", client.ConnectionInfo.CurrentServerHmacAlgorithm);
			}
		}
	}
}
