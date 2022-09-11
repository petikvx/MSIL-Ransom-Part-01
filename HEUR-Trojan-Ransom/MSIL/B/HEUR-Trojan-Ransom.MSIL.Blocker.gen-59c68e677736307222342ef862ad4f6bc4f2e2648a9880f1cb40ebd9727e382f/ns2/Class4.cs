using System;
using System.IO;
using System.Security.Cryptography;
using ns3;

namespace ns2;

internal abstract class Class4
{
	internal static bool smethod_0(Type type_0, char char_0)
	{
		return type_0.Name.Contains(char_0.ToString());
	}

	internal static byte[] smethod_1(byte[] byte_0, ICryptoTransform icryptoTransform_0)
	{
		using MemoryStream memoryStream = new MemoryStream();
		Class5.smethod_0(byte_0, icryptoTransform_0, memoryStream);
		return memoryStream.ToArray();
	}
}
