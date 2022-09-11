using System;

internal class Control1 : Control0, Interface0
{
	private float float_0;

	private float float_1;

	private float float_2;

	private int int_0;

	private double double_0 = 2.0;

	public override float XLxxMXUdScRZLKVoesUWzfDpPlIj()
	{
		return float_0;
	}

	public override float unUGplMUvENKMrhpSucPiASyOwiV()
	{
		return float_1;
	}

	public void method_0(Class4 class4_0)
	{
		float_0 += class4_0.method_1((int)((double)int_0++ * double_0));
		while (true)
		{
			int num = 1645974278;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(-499458496 - (-((num2 ^ -1446230821) - 851593254) - 1054457786))) ^ 0x66167D42u) % 3u)
				{
				case 1u:
					goto IL_0030;
				case 2u:
					break;
				default:
					float_2 += class4_0.method_1((int)((double)int_0++ * double_0));
					return;
				}
				break;
				IL_0030:
				float_1 += class4_0.method_1((int)((double)int_0++ * double_0));
				num = (int)((num3 * 1110801057) ^ 0xF23D12F);
			}
		}
	}

	public override float xQnXvaDECdjzLlvuotATECydEEufA()
	{
		return (float)Math.Sqrt(float_0 * float_0 * float_0 + float_1 * float_1 * float_1);
	}
}
