using System;
using System.Diagnostics;

namespace w;

public class A
{
	[DebuggerNonUserCode]
	public A()
	{
	}

	[STAThread]
	public static void main()
	{
		OK.ko();
	}
}
