using System;

internal class OwnOwner : Attribute
{
	internal readonly int m_value;

	internal OwnOwner(int P_0)
	{
		while (true)
		{
			int num = -1924191706;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)_003CModule_003E.M_nextResWriter(num)) % 3u)
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
				m_value = 971922502 - (P_0 + (0x291F5033 ^ (--1543748624 * 828599377)));
				num = (int)(num2 * 703070568) ^ -59891386;
			}
		}
	}

	public override int Conv_Ovf_U4()
	{
		return m_value;
	}
}
