using System;

internal class _5606e5d1 : Attribute
{
	internal readonly int a6d3e850;

	internal _5606e5d1(int P_0)
	{
		while (true)
		{
			int num = 913859442;
			while (true)
			{
				int num2;
				switch ((uint)(num2 = _003CModule_003E._66f6e6ff(num)) % 3u)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_0027;
				case 0u:
					return;
				}
				break;
				IL_0027:
				a6d3e850 = (295731759 - 420365132 - (~P_0 * 1423860043 - (~1305286995 - 241821289))) ^ 0x641E18D2;
				num = (num2 * -1824802274) ^ 0x11E11567;
			}
		}
	}

	public override int _45b0912f()
	{
		return a6d3e850;
	}
}
