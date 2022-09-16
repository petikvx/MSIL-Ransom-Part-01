namespace Traffic_Simulation;

internal class CarInfo
{
	public int id { get; private set; }

	public WhereIsNow iAmHere { get; set; }

	public int countMove { get; set; }

	public CarInfo(int id)
	{
		while (true)
		{
			int num = -640217180;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA97EB71Cu) % 6u)
				{
				case 5u:
					iAmHere = WhereIsNow.Beginning;
					num = ((int)num2 * -205266909) ^ -991014330;
					continue;
				case 4u:
					this.id = id;
					num = (int)(num2 * 2115616837) ^ -1781309237;
					continue;
				case 3u:
					countMove = -1;
					num = (int)((num2 * 31519964) ^ 0x65A70C58);
					continue;
				case 1u:
					num = ((int)num2 * -608779668) ^ -1808823949;
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}
}
