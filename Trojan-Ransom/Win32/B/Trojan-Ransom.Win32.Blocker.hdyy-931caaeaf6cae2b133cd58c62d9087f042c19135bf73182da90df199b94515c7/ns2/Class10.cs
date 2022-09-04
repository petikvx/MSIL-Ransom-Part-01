using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace ns2;

internal sealed class Class10
{
	public static byte[] smethod_0(string InputString)
	{
		return Encoding.Unicode.GetBytes(InputString);
	}

	public static string smethod_1(byte[] InputBuffer)
	{
		return BitConverter.ToString(InputBuffer, 0);
	}

	public static string smethod_2(byte[] Data)
	{
		string text = "";
		foreach (byte b in Data)
		{
			char c = (char)b;
			if (c.ToString() != "\0")
			{
				string text2 = text;
				c = (char)b;
				text = text2 + c;
			}
		}
		return text;
	}

	public static void smethod_3(NetworkStream NS, string CMD)
	{
		byte[] array = smethod_0(CMD + ":0!");
		NS.Write(array, 0, array.Length);
		NS.Flush();
	}

	public static void smethod_4(NetworkStream NS, string CMD, byte[] Data)
	{
		byte[] array = ((!(CMD != "RECIFB")) ? smethod_0(CMD + ":" + (Data.Length + 1) + "!") : smethod_0(CMD + ":" + Data.Length + "!"));
		List<byte> list = new List<byte>();
		byte[] array2 = array;
		foreach (byte item in array2)
		{
			list.Add(item);
		}
		array2 = Data;
		foreach (byte item2 in array2)
		{
			list.Add(item2);
		}
		byte[] array3 = new byte[list.Count];
		for (int j = 0; j < list.Count; j++)
		{
			array3[j] = list[j];
		}
		NS.Write(array3, 0, array3.Length);
		NS.Flush();
	}

	public static void smethod_5(NetworkStream NS, string CMD, string StringAsData)
	{
		byte[] array = smethod_0(StringAsData);
		byte[] array2 = smethod_0(CMD + ":" + array.Length + "!");
		List<byte> list = new List<byte>();
		byte[] array3 = array2;
		foreach (byte item in array3)
		{
			list.Add(item);
		}
		array3 = array;
		foreach (byte item2 in array3)
		{
			list.Add(item2);
		}
		byte[] array4 = new byte[list.Count];
		for (int j = 0; j < list.Count; j++)
		{
			array4[j] = list[j];
		}
		NS.Write(array4, 0, array4.Length);
		NS.Flush();
	}
}
