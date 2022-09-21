using System;

internal class c810d2b3 : Attribute
{
	internal readonly int _26a67eb8;

	internal c810d2b3(int P_0)
	{
		while (true)
		{
			int num = -1936627660;
			while (true)
			{
				int num2;
				switch ((uint)(num2 = _003CModule_003E.ab80b691(num)) % 3u)
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
				_26a67eb8 = -((-P_0 - (0x673E393E ^ -795349267)) * -598506031 - (549412819 + -955163739));
				num = (num2 * 328788864) ^ -671464294;
			}
		}
	}

	public override int b864b2af()
	{
		return _26a67eb8;
	}
}
