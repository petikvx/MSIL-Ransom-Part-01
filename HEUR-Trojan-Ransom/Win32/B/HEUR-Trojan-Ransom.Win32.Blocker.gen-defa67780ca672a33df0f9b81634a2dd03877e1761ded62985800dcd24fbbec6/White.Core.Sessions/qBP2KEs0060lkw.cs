using System.Threading;

namespace White.Core.Sessions;

internal class qBP2KEs0060lkw
{
	private static int int_0;

	public static void RGC258FNG2d5i9()
	{
		_ = 0;
		if (OGXM8CsR8QswHM6BDN())
		{
			goto IL_001a;
		}
		int num = 2;
		if (qA8j8pdjIOdvHx68t7())
		{
		}
		goto IL_004f;
		IL_001a:
		bool flag = Interlocked.CompareExchange(ref int_0, 1, 0) != 0;
		goto IL_003e;
		IL_004f:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			case 1:
			case 2:
				goto IL_003e;
			default:
				num = 3;
				if (!qA8j8pdjIOdvHx68t7())
				{
					continue;
				}
				return;
			case 3:
			case 5:
				return;
			}
			break;
		}
		goto IL_001a;
		IL_003e:
		do
		{
			if (!flag)
			{
				IwgGNu87tg7qCiPfnJ();
				num = 5;
				continue;
			}
			return;
		}
		while (!OGXM8CsR8QswHM6BDN());
		goto IL_004f;
	}

	private static void H9a86XT626ijYx()
	{
		hqNu3ffJs86aC63MPF();
	}

	public qBP2KEs0060lkw()
	{
		cWHxiROm4ZmmvomoEt(this);
	}

	internal static void IwgGNu87tg7qCiPfnJ()
	{
		H9a86XT626ijYx();
	}

	internal static bool OGXM8CsR8QswHM6BDN()
	{
		return true;
	}

	internal static bool qA8j8pdjIOdvHx68t7()
	{
		return false;
	}

	internal static void hqNu3ffJs86aC63MPF()
	{
		Class0.ij16y1lLZG7KJ5wy();
	}

	internal static void cWHxiROm4ZmmvomoEt(object object_0)
	{
		object_0._002Ector();
	}
}
