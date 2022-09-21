using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class GClass2
{
	[CompilerGenerated]
	private string HelloSkid;

	[CompilerGenerated]
	private int HelloSkid;

	[CompilerGenerated]
	private object HelloSkid;

	[CompilerGenerated]
	private List<AE3FB35B> HelloSkid;

	public string id
	{
		[CompilerGenerated]
		get
		{
			_ = 1488450811637744376L;
			/*Error: Unexpected end of block*/;
		}
		[CompilerGenerated]
		set;
	}

	public extern int type
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern object last_message_id
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public unsafe List<AE3FB35B> recipients
	{
		[CompilerGenerated]
		get
		{
			//IL_0006: Expected O, but got I4
			//IL_001c: Expected I8, but got O
			do
			{
				this = (GClass2)(*(short*)(nint)/*Error near IL_0003: Stack underflow*/);
			}
			while (/*Error near IL_000b: Stack underflow*/ == /*Error near IL_000b: Stack underflow*/);
			_003F val = /*Error near IL_000b: ldloc 0 (out-of-bounds)*/;
			short num = *(short*)((sbyte[])/*Error near IL_000f: Stack underflow*/)[val];
			*(long*)1496894923497423571uL = (long)this;
			*(sbyte*)(nint)/*Error near IL_001d: Stack underflow*/ = (sbyte)num;
			return (List<AE3FB35B>)/*Error near IL_001e: Stack underflow*/;
		}
		[CompilerGenerated]
		set;
	}

	public GClass2()
	{
		//Discarded unreachable code: IL_0007, IL_000c
		//IL_0000: Unsupported input type for neg.
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = (double)(0 - /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Invalid metadata token*/;
	}
}
