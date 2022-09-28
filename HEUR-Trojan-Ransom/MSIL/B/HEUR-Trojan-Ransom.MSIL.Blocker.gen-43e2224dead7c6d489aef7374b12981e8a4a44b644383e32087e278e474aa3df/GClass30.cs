using System.Collections.Generic;

public class GClass30<T>
{
	private readonly Queue<T> queue_0;

	public extern int Int32_0 { get; }

	public void method_0(T gparam_0)
	{
		//Discarded unreachable code: IL_0006, IL_000b
		/*Error near IL_0001: Invalid metadata token*/;
	}

	public extern bool method_1(out T gparam_0);

	public bool method_2(out T[] gparam_0)
	{
		//Discarded unreachable code: IL_0008, IL_0011, IL_0017, IL_001c, IL_0022
		//IL_0003: Incompatible stack heights: 0 vs 2
		//IL_000c: Invalid comparison between Unknown and I
		while (true)
		{
			/*Error: ldloc 0 (out-of-bounds)*/;
			_ = -1;
		}
	}

	public extern void method_3();

	public extern GClass30();

	static void smethod_0(object object_0, ref bool bool_0)
	{
		//Discarded unreachable code: IL_0005, IL_000e, IL_0016, IL_002e
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected I8, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got I4
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_1(object object_0);
}
