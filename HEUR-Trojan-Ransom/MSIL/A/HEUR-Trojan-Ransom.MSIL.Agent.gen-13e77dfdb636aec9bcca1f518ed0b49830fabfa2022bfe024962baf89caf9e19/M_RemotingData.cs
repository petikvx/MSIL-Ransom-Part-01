using System;

internal class M_RemotingData : Attribute
{
	internal readonly int Stelem_I8;

	internal M_RemotingData(int P_0)
	{
		while (true)
		{
			int num = -1839437066;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)_003CModule_003E._64Bit(num)) % 3u)
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
				Stelem_I8 = (((P_0 + -(-(-740709356 + -275035678 - -882897635))) ^ -(-777075852 * 1789770185 * 411753305)) - -(542615745 * 1428374463)) * -199542243;
				num = ((int)num2 * -1610323387) ^ -669063832;
			}
		}
	}

	public override int Get_SequencePointCount()
	{
		return Stelem_I8;
	}
}
