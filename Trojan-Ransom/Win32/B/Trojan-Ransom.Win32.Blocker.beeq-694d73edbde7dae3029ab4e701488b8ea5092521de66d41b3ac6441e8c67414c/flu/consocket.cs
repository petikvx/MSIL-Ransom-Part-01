using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;
using Starksoft.Net.Proxy;

namespace flu;

internal class consocket
{
	internal class proxy
	{
		public struct conn
		{
			internal TcpClient http;

			internal IProxyClient Proxy;

			public ProxyType proxy_type;

			public string proxy_host;

			public int proxy_port;

			public string target_host;

			public int target_port;

			public string recv_packet;

			public void proxy_config(string target_host, int target_port, string proxy_host, int proxy_port, ProxyType type)
			{
				//IL_001e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0020: Unknown result type (might be due to invalid IL or missing references)
				this.target_host = target_host;
				this.target_port = target_port;
				this.proxy_host = proxy_host;
				this.proxy_port = proxy_port;
				proxy_type = type;
			}
		}

		public conn proxy_conn;

		internal proxy(string target_host, int target_port, string proxy_host, int proxy_port, ProxyType type)
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			Console.WriteLine("Socket allocated.");
			proxy_conn = default(conn);
			proxy_conn.proxy_config(target_host, target_port, proxy_host, proxy_port, type);
			ProxyClientFactory val = new ProxyClientFactory();
			proxy_conn.Proxy = val.CreateProxyClient(type, proxy_host, proxy_port);
			proxy_conn.Proxy.add_CreateConnectionAsyncCompleted((EventHandler<CreateConnectionAsyncCompletedEventArgs>)proxy_connected);
		}

		internal void connect()
		{
			proxy_conn.Proxy.CreateConnectionAsync(proxy_conn.target_host, proxy_conn.target_port);
		}

		private void proxy_connected(object sender, CreateConnectionAsyncCompletedEventArgs e)
		{
			if (((AsyncCompletedEventArgs)(object)e).Error != null)
			{
				Console.WriteLine("Connection Error!");
				Console.WriteLine(((AsyncCompletedEventArgs)(object)e).Error!.Message);
			}
			else if (((AsyncCompletedEventArgs)(object)e).Error == null)
			{
				Console.WriteLine("Connected to Tor!");
				proxy_conn.http = e.get_ProxyConnection();
				Console.WriteLine("Proxy referenced.");
			}
		}

		public void send(string data)
		{
			proxy_conn.http.Client.Send(Encoding.ASCII.GetBytes(data));
		}

		public string recv()
		{
			byte[] array = new byte[1024];
			int count = proxy_conn.http.Client.Receive(array, 1024, SocketFlags.None);
			proxy_conn.recv_packet += Encoding.ASCII.GetString(array, 0, count);
			return proxy_conn.recv_packet;
		}
	}

	internal class Tor
	{
		private static Tor instance;

		private Process tor;

		internal static Tor Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new Tor();
				}
				return instance;
			}
		}

		private Tor()
		{
		}

		internal void tor_start()
		{
			if (tor == null)
			{
				Console.WriteLine("Tor init...");
				tor = new Process();
				tor.StartInfo.FileName = "tor.exe";
				tor.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
				Console.WriteLine(Directory.GetCurrentDirectory());
				tor.StartInfo.CreateNoWindow = false;
				tor.StartInfo.UseShellExecute = false;
				tor.StartInfo.RedirectStandardOutput = true;
				tor.StartInfo.RedirectStandardInput = true;
				tor.StartInfo.RedirectStandardError = true;
				tor.OutputDataReceived += delegate(object sender, DataReceivedEventArgs e)
				{
					stdout__tor(sender, e);
				};
				tor.ErrorDataReceived += delegate(object sender, DataReceivedEventArgs e)
				{
					stderr__tor(sender, e);
				};
				tor.Start();
				Console.WriteLine("Strapping input...");
				tor.BeginOutputReadLine();
				tor.BeginErrorReadLine();
			}
			else
			{
				Console.WriteLine("A Tor process already exists.");
			}
		}

		internal void tor_stop()
		{
			tor.StandardOutput.Close();
			tor.StandardInput.Close();
			tor.StandardError.Close();
			tor.Kill();
			tor.Dispose();
			tor = null;
		}

		internal void tor_restart()
		{
			tor_stop();
			tor_start();
		}

		private void stdout__tor(object sender, DataReceivedEventArgs e)
		{
			if (e.Data!.Contains("Bootstrapped 100%: Done."))
			{
				Console.WriteLine("Tor has been initialized.");
			}
			Console.WriteLine(e.Data);
		}

		private void stderr__tor(object sender, DataReceivedEventArgs e)
		{
			Console.WriteLine("[ERROR]: " + e.Data);
		}
	}
}
