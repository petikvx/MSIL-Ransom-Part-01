using System;

internal class LOCKBYTES : Attribute
{
	internal readonly int MDAllocateMemberDefRids3;

	internal LOCKBYTES(int P_0)
	{
		while (true)
		{
			int num = -1630820598;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)_003CModule_003E.M_UsedSizeFileStream(num)) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0027;
				case 1u:
					return;
				}
				break;
				IL_0027:
				MDAllocateMemberDefRids3 = (-(-1788606803 * 1027484351) - (0x613949C ^ -1521629512) - ~P_0 - (844200691 * 495396763 - 1995829181 * -1006344282)) ^ -1534279055;
				num = (int)(num2 * 1410535037) ^ -229125966;
			}
		}
	}

	int Attribute.get_Current()
	{
		return MDAllocateMemberDefRids3;
	}
}
