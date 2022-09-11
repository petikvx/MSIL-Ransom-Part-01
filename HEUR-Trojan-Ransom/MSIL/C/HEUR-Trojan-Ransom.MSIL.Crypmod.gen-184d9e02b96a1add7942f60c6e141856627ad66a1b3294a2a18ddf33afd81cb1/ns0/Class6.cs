using System;
using System.Security;
using Fm;

namespace ns0;

internal sealed class Class6
{
	private int int_0;

	static Class6()
	{
		Class4.smethod_2();
	}

	public void method_0()
	{
		Class8.codeAccessPermission_0.Assert();
		try
		{
			Class9.MessageBeep(int_0);
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
	}

	[STAThread]
	public static int Main()
	{
		Program.Main();
		return 0;
	}
}
