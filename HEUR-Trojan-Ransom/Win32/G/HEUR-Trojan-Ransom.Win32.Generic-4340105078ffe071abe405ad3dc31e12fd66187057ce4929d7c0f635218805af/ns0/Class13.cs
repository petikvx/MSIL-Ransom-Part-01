using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.ServiceProcess;

namespace ns0;

internal sealed class Class13 : ServiceBase
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 240)]
	private struct Struct1
	{
	}

	private static readonly object object_0;

	private static readonly object object_1 = new char[120];

	private static readonly Array array_0;

	internal static byte byte_0/* Not supported: data(00) */;

	internal IContainer icontainer_0;

	public Class13()
	{
		method_0();
	}

	protected override void OnStart(string[] args)
	{
	}

	protected override void OnStop()
	{
	}

	[SpecialName]
	internal static int smethod_0()
	{
		return Class36.smethod_0() & 0xFF;
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
		((ServiceBase)this).set_ServiceName("Service20");
	}

	static Class13()
	{
		char[] array = new char[8];
		array[6] = 'ޣ';
		array[1] = '\u0f84';
		array[2] = '\u20ff';
		array[3] = '㕳';
		array[5] = '㩄';
		array[0] = '\u0af3';
		array[7] = 'ᘆ';
		array[4] = '\u1a7c';
		array_0 = new string[11];
		object_0 = array;
	}
}
