using System;
using System.IO;

namespace ns7;

internal class Class21
{
	internal static void smethod_0(Stream stream_0, long long_0, int int_0)
	{
		switch (int_0 ^ 0x7C71)
		{
		}
		stream_0.Position = long_0;
	}

	internal static string smethod_1(BinaryReader binaryReader_0, int int_0)
	{
		return (int_0 ^ 0x300D) switch
		{
			_ => binaryReader_0.ReadString(), 
		};
	}

	internal static byte[] smethod_2(string string_0, int int_0)
	{
		return (int_0 ^ 0x18D9) switch
		{
			_ => Convert.FromBase64String(string_0), 
		};
	}
}
