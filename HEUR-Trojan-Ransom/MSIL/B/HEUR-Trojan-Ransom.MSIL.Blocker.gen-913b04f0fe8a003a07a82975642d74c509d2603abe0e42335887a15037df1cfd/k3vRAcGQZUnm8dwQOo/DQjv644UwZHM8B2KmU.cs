using System;
using System.Reflection;
using jJAiRVyvJB7OUx0Uri;

namespace k3vRAcGQZUnm8dwQOo;

internal class DQjv644UwZHM8B2KmU
{
	internal delegate void b1A6flmD4YwpXrKkrY(object o);

	internal static Module oYBdm5b6x;

	private static DQjv644UwZHM8B2KmU RJybfcwvZEaCGL27wqk;

	internal static void NTZbJnTq2c(int typemdt)
	{
		Type type;
		while (true)
		{
			type = oYBdm5b6x.ResolveType(33554432 + typemdt);
			if (pLestXw6AaDrTUx6Qjd() == null)
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			break;
		}
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)oYBdm5b6x.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public DQjv644UwZHM8B2KmU()
	{
		JR4duLHaUHjOwL2k4G.r9IbO7Yymm();
		base._002Ector();
	}

	static DQjv644UwZHM8B2KmU()
	{
		JR4duLHaUHjOwL2k4G.r9IbO7Yymm();
		oYBdm5b6x = typeof(DQjv644UwZHM8B2KmU).Assembly.ManifestModule;
	}

	internal static bool tIFdFswrJ6foLuDcxHJ()
	{
		return RJybfcwvZEaCGL27wqk == null;
	}

	internal static DQjv644UwZHM8B2KmU pLestXw6AaDrTUx6Qjd()
	{
		return RJybfcwvZEaCGL27wqk;
	}
}
