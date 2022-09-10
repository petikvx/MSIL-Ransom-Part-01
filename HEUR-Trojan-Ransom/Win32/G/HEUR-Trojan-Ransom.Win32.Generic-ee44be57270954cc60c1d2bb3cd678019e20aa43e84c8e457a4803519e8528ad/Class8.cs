using System.IO;
using System.Text;

internal class Class8 : GClass0
{
	public Class8(GClass24 gclass24_1)
		: base(gclass24_1)
	{
	}

	public override void imethod_0(ref MemoryStream memoryStream_0)
	{
		StringBuilder stringBuilder = new StringBuilder(base.GClass24_0.Int16_0);
		byte[] array = new byte[1];
		int num = 0;
		while (true)
		{
			int num2;
			int num3;
			if (num < base.GClass24_0.Int16_0)
			{
				num2 = 1193386425;
				num3 = 1193386425;
			}
			else
			{
				num2 = 511281635;
				num3 = 511281635;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0x41A85F7Eu) % 11u)
				{
				case 10u:
					num++;
					num2 = 1071881693;
					continue;
				case 9u:
					string_0 = stringBuilder.ToString();
					num2 = ((int)num4 * -737209172) ^ 0xD5FD095;
					continue;
				case 8u:
					num2 = ((int)num4 * -707401398) ^ -1288150;
					continue;
				case 7u:
				{
					int num6;
					int num7;
					if (array[0] < 126)
					{
						num6 = 992751996;
						num7 = 992751996;
					}
					else
					{
						num6 = 933985436;
						num7 = 933985436;
					}
					num2 = num6 ^ ((int)num4 * -985192229);
					continue;
				}
				case 6u:
					stringBuilder.Append(Encoding.ASCII.GetString(array));
					num2 = (int)((num4 * 1981242970) ^ 0xF3E0E3C);
					continue;
				case 5u:
					string_1 = string.Concat("Type ", base.GClass24_0.GEnum2_0, " not implemented.");
					num2 = (int)(num4 * 1076193950) ^ -1014456082;
					continue;
				case 3u:
					num2 = 1193386425;
					continue;
				case 2u:
				{
					memoryStream_0.Read(array, 0, 1);
					int num5;
					if (array[0] <= 32)
					{
						num2 = 1757044383;
						num5 = 1757044383;
					}
					else
					{
						num2 = 728096903;
						num5 = 728096903;
					}
					continue;
				}
				case 1u:
					stringBuilder.Append('.');
					num2 = 1250507994;
					continue;
				default:
					return;
				case 4u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}
}
