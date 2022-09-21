using System;

internal class _3cf40b40 : Attribute
{
	internal readonly int _313ed895;

	internal _3cf40b40(int P_0)
	{
		while (true)
		{
			int num = -66902354;
			while (true)
			{
				int num2;
				switch ((uint)(num2 = _003CModule_003E.ed4b4a71(num)) % 3u)
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
				_313ed895 = ((0x3956EDBA ^ 0x69AF347B) - -(P_0 - -221550473 * -(1782825963 * 178020264 - -324469234)) * 1724169757) * -1091861773;
				num = (num2 * -1602303926) ^ 0x3A891A77;
			}
		}
	}

	public override int _4facdddc()
	{
		return _313ed895;
	}
}
