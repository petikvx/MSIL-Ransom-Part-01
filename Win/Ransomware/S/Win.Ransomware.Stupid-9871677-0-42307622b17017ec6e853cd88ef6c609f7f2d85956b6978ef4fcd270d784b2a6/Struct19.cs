internal struct Struct19
{
	private readonly Struct18[] struct18_0;

	private readonly int int_0;

	public Struct19(int int_1)
	{
		//Discarded unreachable code: IL_000b, IL_0017, IL_001c, IL_0021, IL_0029
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and F8
		while (true)
		{
			_003F val;
			checked
			{
				short num = (short)unchecked((uint)/*Error near IL_0001: Stack underflow*/);
				val = /*Error near IL_0005: Stack underflow*/* num;
			}
			_ = /*Error near IL_0006: Stack underflow*/<< (int)val;
		}
	}

	public unsafe void method_0()
	{
		//IL_0002: Expected I4, but got Unknown
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and F8
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected F8, but got I4
		while (true)
		{
			_003F val = /*Error: ldarg 3 (out-of-bounds)*/;
			((sbyte[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (sbyte)(int)val;
			*(_003F*)(nint)/*Error near IL_0003: Stack underflow*/ = /*Error near IL_0003: Stack underflow*/;
			ushort num = (ushort)/*Error near IL_0006: Stack underflow*/;
			if ((int)/*Error near IL_000b: Stack underflow*/ >= (int)num)
			{
				continue;
			}
			double num2 = ((double[])(/*Error near IL_000c: Stack underflow*/ << (int)/*Error near IL_000c: Stack underflow*/))[/*Error near IL_000c: ldarg 3 (out-of-bounds)*/];
			if ((double)/*Error near IL_0014: Stack underflow*/ != num2)
			{
				ushort num3;
				checked
				{
					num3 = (ushort)(/*Error near IL_0015: Stack underflow*/ << unchecked((int)/*Error near IL_0015: Stack underflow*/));
				}
				if ((int)/*Error near IL_001b: Stack underflow*/ > (int)num3)
				{
					break;
				}
			}
		}
		_003F val2 = checked(/*Error near IL_001c: Stack underflow*/ - /*Error near IL_001c: Stack underflow*/);
		uint num4 = 0u;
		((double[])/*Error near IL_0026: Stack underflow*/)[val2] = (int)num4;
		/*Error: Unexpected end of block*/;
	}

	public uint method_1(Class40 class40_0)
	{
		//Discarded unreachable code: IL_0003
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected I, but got Unknown
		/*Error near IL_0002: Unknown opcode: 0xFB*/;
	}

	public uint method_2(Class40 class40_0)
	{
		/*Error near IL_0001: stloc 0 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	public static extern uint smethod_0(Struct18[] struct18_1, uint uint_0, Class40 class40_0, int int_1);
}
