using System.Diagnostics;
using System.Runtime.CompilerServices;

public class GClass10
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string string_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string string_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private GEnum1 genum1_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string string_3;

	public string String_0
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid metadata token*/;
		}
		[CompilerGenerated]
		set;
	}

	public extern string String_1
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public unsafe string String_2
	{
		[CompilerGenerated]
		get
		{
			//Discarded unreachable code: IL_001c, IL_0025, IL_0030, IL_0035
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Incompatible stack heights: 0 vs 1
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			_003F val2;
			do
			{
				_003F val = /*Error near IL_0001: Stack underflow*// /*Error near IL_0001: Stack underflow*/;
				val2 = /*Error near IL_0002: Stack underflow*/% val;
			}
			while (/*Error near IL_0008: Stack underflow*/ <= val2 || /*Error near IL_000d: Stack underflow*/>= /*Error near IL_000d: Stack underflow*/);
			/*Error near IL_000d: stloc 0 (out-of-bounds)*/;
			_003F val3 = checked(/*Error near IL_0010: Stack underflow*/ + /*Error near IL_0010: Stack underflow*/);
			/*Error near IL_0015: stloc 0 (out-of-bounds)*/;
			_ = *(uint*)(nint)val3;
			/*Error near IL_0017: Invalid metadata token*/;
		}
		[CompilerGenerated]
		set;
	}

	public extern GEnum1 GEnum1_0
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public string String_3
	{
		[CompilerGenerated]
		get
		{
			//Discarded unreachable code: IL_0006, IL_000f, IL_0014, IL_001a
			//IL_0006: Ignored invalid 'volatile' prefix
			//IL_000a: Invalid comparison between Unknown and F8
			_ = ((byte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			/*Error near IL_0001: Invalid metadata token*/;
		}
		[CompilerGenerated]
		set;
	}

	public extern GClass10();
}
