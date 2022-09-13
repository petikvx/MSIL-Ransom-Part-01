using System.Collections.Generic;

public class GClass26
{
	private enum Enum6
	{
		const_0,
		const_1,
		const_2,
		const_3
	}

	private const int int_0 = 8;

	private const int int_1 = 24;

	private const uint uint_0 = 3u;

	private readonly int int_2;

	private readonly List<uint> list_0;

	public unsafe GClass26()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_000e: Unsupported input type for neg.
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected F4, but got I8
		while (true)
		{
			nuint num = checked((nuint)/*Error near IL_0001: Stack underflow*/);
			_003F val = /*Error near IL_0002: Stack underflow*/| num;
			if ((int)/*Error near IL_0008: Stack underflow*/ != (sbyte)val)
			{
				byte num2 = *(byte*)(nint)/*Error near IL_0009: Stack underflow*/;
				if ((int)/*Error near IL_000e: Stack underflow*/ >= (int)num2)
				{
					break;
				}
			}
		}
		*(float*)(nint)(0 - /*Error near IL_000f: Stack underflow*/) = -4.1551097E+18f;
	}

	public override extern string ToString();
}
