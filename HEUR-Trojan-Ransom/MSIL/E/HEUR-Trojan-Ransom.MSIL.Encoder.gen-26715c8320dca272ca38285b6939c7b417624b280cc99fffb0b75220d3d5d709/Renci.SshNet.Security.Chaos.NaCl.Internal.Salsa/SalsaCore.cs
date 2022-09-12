namespace Renci.SshNet.Security.Chaos.NaCl.Internal.Salsa;

internal static class SalsaCore
{
	internal static void HSalsa(out Array16<uint> output, ref Array16<uint> input, int rounds)
	{
		InternalAssert.Assert(rounds % 2 == 0, "Number of salsa rounds must be even");
		int num = rounds / 2;
		uint num2 = input.x0;
		uint num3 = input.x1;
		uint num4 = input.x2;
		uint num5 = input.x3;
		uint num6 = input.x4;
		uint num7 = input.x5;
		uint num8 = input.x6;
		uint num9 = input.x7;
		uint num10 = input.x8;
		uint num11 = input.x9;
		uint num12 = input.x10;
		uint num13 = input.x11;
		uint num14 = input.x12;
		uint num15 = input.x13;
		uint num16 = input.x14;
		uint num17 = input.x15;
		for (int i = 0; i < num; i++)
		{
			uint num18 = num2 + num14;
			num6 ^= (num18 << 7) | (num18 >> 25);
			num18 = num6 + num2;
			num10 ^= (num18 << 9) | (num18 >> 23);
			num18 = num10 + num6;
			num14 ^= (num18 << 13) | (num18 >> 19);
			num18 = num14 + num10;
			num2 ^= (num18 << 18) | (num18 >> 14);
			num18 = num7 + num3;
			num11 ^= (num18 << 7) | (num18 >> 25);
			num18 = num11 + num7;
			num15 ^= (num18 << 9) | (num18 >> 23);
			num18 = num15 + num11;
			num3 ^= (num18 << 13) | (num18 >> 19);
			num18 = num3 + num15;
			num7 ^= (num18 << 18) | (num18 >> 14);
			num18 = num12 + num8;
			num16 ^= (num18 << 7) | (num18 >> 25);
			num18 = num16 + num12;
			num4 ^= (num18 << 9) | (num18 >> 23);
			num18 = num4 + num16;
			num8 ^= (num18 << 13) | (num18 >> 19);
			num18 = num8 + num4;
			num12 ^= (num18 << 18) | (num18 >> 14);
			num18 = num17 + num13;
			num5 ^= (num18 << 7) | (num18 >> 25);
			num18 = num5 + num17;
			num9 ^= (num18 << 9) | (num18 >> 23);
			num18 = num9 + num5;
			num13 ^= (num18 << 13) | (num18 >> 19);
			num18 = num13 + num9;
			num17 ^= (num18 << 18) | (num18 >> 14);
			num18 = num2 + num5;
			num3 ^= (num18 << 7) | (num18 >> 25);
			num18 = num3 + num2;
			num4 ^= (num18 << 9) | (num18 >> 23);
			num18 = num4 + num3;
			num5 ^= (num18 << 13) | (num18 >> 19);
			num18 = num5 + num4;
			num2 ^= (num18 << 18) | (num18 >> 14);
			num18 = num7 + num6;
			num8 ^= (num18 << 7) | (num18 >> 25);
			num18 = num8 + num7;
			num9 ^= (num18 << 9) | (num18 >> 23);
			num18 = num9 + num8;
			num6 ^= (num18 << 13) | (num18 >> 19);
			num18 = num6 + num9;
			num7 ^= (num18 << 18) | (num18 >> 14);
			num18 = num12 + num11;
			num13 ^= (num18 << 7) | (num18 >> 25);
			num18 = num13 + num12;
			num10 ^= (num18 << 9) | (num18 >> 23);
			num18 = num10 + num13;
			num11 ^= (num18 << 13) | (num18 >> 19);
			num18 = num11 + num10;
			num12 ^= (num18 << 18) | (num18 >> 14);
			num18 = num17 + num16;
			num14 ^= (num18 << 7) | (num18 >> 25);
			num18 = num14 + num17;
			num15 ^= (num18 << 9) | (num18 >> 23);
			num18 = num15 + num14;
			num16 ^= (num18 << 13) | (num18 >> 19);
			num18 = num16 + num15;
			num17 ^= (num18 << 18) | (num18 >> 14);
		}
		output.x0 = num2;
		output.x1 = num3;
		output.x2 = num4;
		output.x3 = num5;
		output.x4 = num6;
		output.x5 = num7;
		output.x6 = num8;
		output.x7 = num9;
		output.x8 = num10;
		output.x9 = num11;
		output.x10 = num12;
		output.x11 = num13;
		output.x12 = num14;
		output.x13 = num15;
		output.x14 = num16;
		output.x15 = num17;
	}

	internal static void Salsa(out Array16<uint> output, ref Array16<uint> input, int rounds)
	{
		HSalsa(out var output2, ref input, rounds);
		output.x0 = output2.x0 + input.x0;
		output.x1 = output2.x1 + input.x1;
		output.x2 = output2.x2 + input.x2;
		output.x3 = output2.x3 + input.x3;
		output.x4 = output2.x4 + input.x4;
		output.x5 = output2.x5 + input.x5;
		output.x6 = output2.x6 + input.x6;
		output.x7 = output2.x7 + input.x7;
		output.x8 = output2.x8 + input.x8;
		output.x9 = output2.x9 + input.x9;
		output.x10 = output2.x10 + input.x10;
		output.x11 = output2.x11 + input.x11;
		output.x12 = output2.x12 + input.x12;
		output.x13 = output2.x13 + input.x13;
		output.x14 = output2.x14 + input.x14;
		output.x15 = output2.x15 + input.x15;
	}
}
