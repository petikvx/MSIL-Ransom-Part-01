using System;
using System.Runtime.CompilerServices;
using System.Security;

namespace eeByhaIKPr900aLxc7f;

internal class exgdQiIHW0NaSpp0mcE : EventArgs
{
	private SecurityException eulODlten;

	private string ecs0D1Zdd = string.Empty;

	private bool e9jslfSvk;

	private bool eeN1kpseb;

	private bool elN6Gg9Qb = true;

	[SpecialName]
	public SecurityException method_0()
	{
		return eulODlten;
	}

	[SpecialName]
	public string method_1()
	{
		return ecs0D1Zdd;
	}

	[SpecialName]
	public bool method_2()
	{
		return elN6Gg9Qb;
	}

	[SpecialName]
	public bool method_3()
	{
		return e9jslfSvk;
	}

	[SpecialName]
	public void method_4(bool bool_0)
	{
		e9jslfSvk = bool_0;
	}

	[SpecialName]
	public bool method_5()
	{
		return eeN1kpseb;
	}

	public exgdQiIHW0NaSpp0mcE(SecurityException securityException_0)
	{
		enSZLy2o9RVgWXeEhdI();
		if (!emJbHs2XIVdtHMAwYpI())
		{
			enZm1126mTsYwRrWmVQ(this);
		}
		eulODlten = securityException_0;
	}

	public exgdQiIHW0NaSpp0mcE(SecurityException securityException_0, bool bool_0)
		: this(securityException_0)
	{
		elN6Gg9Qb = bool_0;
	}

	public exgdQiIHW0NaSpp0mcE(string string_0, bool bool_0)
		: this(new SecurityException(string_0), bool_0)
	{
		ecs0D1Zdd = string_0;
	}

	internal static bool enSZLy2o9RVgWXeEhdI()
	{
		return true;
	}

	internal static bool emJbHs2XIVdtHMAwYpI()
	{
		return false;
	}

	internal static void enZm1126mTsYwRrWmVQ(object object_0)
	{
		((EventArgs)object_0)._002Ector();
	}
}
