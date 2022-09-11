using System.Reflection;

namespace ns0;

internal sealed class Class6
{
	public static MethodInfo methodInfo_0;

	public static bool smethod_0<T>(T[] gparam_0, T[] gparam_1)
	{
		if (gparam_0.Length != gparam_1.Length)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < gparam_0.Length)
			{
				if (!gparam_0[num].Equals(gparam_1[num]))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	static Class6()
	{
		methodInfo_0 = Class7.type_0.GetMethods()[0];
	}
}
