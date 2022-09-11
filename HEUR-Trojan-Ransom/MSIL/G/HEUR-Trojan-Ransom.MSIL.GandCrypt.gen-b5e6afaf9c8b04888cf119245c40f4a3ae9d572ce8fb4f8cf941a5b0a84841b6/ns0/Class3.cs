using System;
using System.Windows.Forms;

namespace ns0;

internal sealed class Class3 : LinkLabel
{
	public static void smethod_0(AppDomain appDomain_0)
	{
		string fullName = typeof(Class0).FullName;
		appDomain_0.CreateInstance(fullName, "");
	}
}
