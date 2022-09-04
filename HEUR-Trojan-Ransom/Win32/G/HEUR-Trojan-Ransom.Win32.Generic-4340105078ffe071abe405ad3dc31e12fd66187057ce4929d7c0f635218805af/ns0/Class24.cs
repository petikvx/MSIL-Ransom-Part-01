using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.ServiceProcess;

namespace ns0;

internal sealed class Class24 : ServiceBase
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 414)]
	private struct Struct3
	{
	}

	private static readonly object object_0;

	private static readonly object object_1 = new char[207];

	private static readonly object object_2;

	internal static byte byte_0/* Not supported: data(00) */;

	internal IContainer icontainer_0;

	public Class24()
	{
		method_0();
	}

	protected override void OnStart(string[] args)
	{
	}

	protected override void OnStop()
	{
	}

	internal static Type smethod_0()
	{
		return Class50.smethod_0();
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
		((ServiceBase)this).set_ServiceName("Service30");
	}

	static Class24()
	{
		char[] array = new char[8];
		array[5] = '㩄';
		array[4] = '\u1a7c';
		array[6] = 'ޣ';
		array[0] = '\u0af3';
		array[2] = '\u20ff';
		array[1] = '\u0f84';
		array[7] = 'ᘆ';
		array[3] = '㕳';
		object_2 = new string[15];
		object_0 = array;
	}
}
