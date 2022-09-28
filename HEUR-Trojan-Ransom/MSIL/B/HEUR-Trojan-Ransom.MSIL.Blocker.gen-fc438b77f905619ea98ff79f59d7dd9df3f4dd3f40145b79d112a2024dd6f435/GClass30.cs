using System.Collections.Generic;

public class GClass30<T>
{
	private readonly Queue<T> queue_0;

	public extern int Int32_0 { get; }

	public extern void method_0(T gparam_0);

	public extern bool method_1(out T gparam_0);

	public extern bool method_2(out T[] gparam_0);

	public extern void method_3();

	public extern GClass30();

	unsafe static void smethod_0(object object_0, ref bool bool_0)
	{
		//Discarded unreachable code: IL_001f, IL_0023, IL_0028, IL_002f
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_000a: Expected F4, but got I4
		//IL_0013: Expected O, but got I4
		//IL_0014: Invalid comparison between Unknown and F4
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		while (true)
		{
			ushort num = *(ushort*)(nint)/*Error near IL_0003: Stack underflow*/;
			if ((int)/*Error near IL_0008: Stack underflow*/ >= (int)num)
			{
				sbyte num2 = checked((sbyte)/*Error near IL_0009: Stack underflow*/);
				*(float*)(nint)/*Error near IL_000a: Stack underflow*/ = num2;
				((object[])/*Error near IL_0013: Stack underflow*/)[7] = 1191010843;
				float num3 = (float)/*Error near IL_0014: Stack underflow*/;
				if (!((float)/*Error near IL_0019: Stack underflow*/ <= num3))
				{
					break;
				}
			}
		}
		_ = *(double*)(nint)/*Error near IL_001a: Stack underflow*/;
		/*Error near IL_001a: Invalid metadata token*/;
	}

	unsafe static void smethod_1(object object_0)
	{
		//IL_0002: Expected I4, but got I8
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			long num = ((long[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			*(sbyte*)(nint)/*Error near IL_0002: Stack underflow*/ = (sbyte)num;
		}
		while (/*Error near IL_0007: Stack underflow*/ != /*Error near IL_0007: Stack underflow*/);
		checked
		{
			_ = /*Error near IL_0009: Stack underflow*/+ /*Error near IL_0009: Stack underflow*/;
			/*Error near IL_0009: Invalid metadata token*/;
		}
	}
}
