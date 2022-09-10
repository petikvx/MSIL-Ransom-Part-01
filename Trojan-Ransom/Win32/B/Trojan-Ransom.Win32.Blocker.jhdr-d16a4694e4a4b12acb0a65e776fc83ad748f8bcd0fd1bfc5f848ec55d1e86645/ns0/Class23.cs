using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml;

namespace ns0;

internal sealed class Class23 : IDisposable
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 68)]
	private struct Struct22
	{
	}

	private readonly XmlWriter xmlWriter_0;

	private static readonly object object_0;

	private static readonly Array array_0 = new char[34];

	private static readonly Array array_1;

	internal static byte byte_0/* Not supported: data(00) */;

	public Class23(XmlWriter xmlWriter_1, string string_0)
	{
		xmlWriter_0 = xmlWriter_1;
		xmlWriter_0.WriteStartElement(string_0);
	}

	public void Dispose()
	{
		xmlWriter_0.WriteEndElement();
	}

	static Class23()
	{
		byte[] publicKeyToken;
		int num = (publicKeyToken = Assembly.GetExecutingAssembly().GetName().GetPublicKeyToken()).Length;
		char[] array = new char[num];
		for (int i = 0; i < num; i++)
		{
			int num2 = i;
			int num3 = publicKeyToken[i] & 0xFF;
			array[num2] = (char)(num3 ^ (num3 << 8));
		}
		object_0 = array;
		array_1 = new string[2];
	}
}
