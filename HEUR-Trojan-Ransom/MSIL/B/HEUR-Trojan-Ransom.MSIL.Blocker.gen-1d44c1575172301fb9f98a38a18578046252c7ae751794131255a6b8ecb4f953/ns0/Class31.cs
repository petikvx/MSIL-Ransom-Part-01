using System;
using System.Runtime.InteropServices;
using System.Xml;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

internal sealed class Class31 : IDisposable
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1992)]
	private struct Struct17
	{
	}

	private static readonly Array array_0;

	private static readonly Array array_1 = new char[996];

	private static readonly Array array_2;

	internal static byte byte_0/* Not supported: data(00) */;

	internal XmlWriter xmlWriter_0;

	public Class31(XmlWriter xmlWriter_1, string string_0)
	{
		try
		{
			XmlWriter xmlWriter = (xmlWriter_0 = xmlWriter_1);
			xmlWriter_0.WriteStartElement(string_0);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, this, xmlWriter_1, string_0);
			throw;
		}
	}

	public void Dispose()
	{
		try
		{
			xmlWriter_0.WriteEndElement();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	static Class31()
	{
		char[] array = new char[8];
		array[3] = '㼓';
		array[6] = 'Ạ';
		array[5] = '㘹';
		array[7] = 'ᇂ';
		array[4] = 'ℌ';
		array[1] = '⎕';
		array[2] = '⼛';
		array[0] = '\u05ac';
		array_2 = new string[53];
		array_0 = array;
	}
}
