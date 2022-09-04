using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.ServiceProcess;

namespace ns0;

internal sealed class Class1 : ServiceBase
{
	internal delegate Assembly Delegate0(byte[] byte_0);

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 898)]
	private struct Struct0
	{
	}

	private static readonly object object_0;

	private static readonly object object_1 = new char[449];

	private static readonly Array array_0;

	internal static byte byte_0/* Not supported: data(00) */;

	internal IContainer icontainer_0;

	public Class1()
	{
		method_0();
	}

	protected override void OnStart(string[] args)
	{
	}

	protected override void OnStop()
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((ServiceBase)this).Dispose(disposing);
	}

	private void method_0()
	{
		IContainer container = (icontainer_0 = new Container());
		((ServiceBase)this).set_ServiceName("Service1");
	}

	static Class1()
	{
		char[] array = new char[8];
		array[2] = '\u20ff';
		array[1] = '\u0f84';
		array[0] = '\u0af3';
		array[5] = '㩄';
		array[4] = '\u1a7c';
		array[6] = 'ޣ';
		array[3] = '㕳';
		array[7] = 'ᘆ';
		array_0 = new string[37];
		object_0 = array;
	}
}
