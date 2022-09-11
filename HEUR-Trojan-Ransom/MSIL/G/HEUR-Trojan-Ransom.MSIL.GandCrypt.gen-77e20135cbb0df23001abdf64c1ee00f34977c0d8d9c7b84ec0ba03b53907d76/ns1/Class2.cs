using System;
using System.Windows.Forms;
using ns0;

namespace ns1;

internal sealed class Class2 : LinkLabel
{
	public static void smethod_0(AppDomain appDomain_0)
	{
		string fullName = typeof(cc).FullName;
		appDomain_0.CreateInstance(fullName, "");
	}
}
