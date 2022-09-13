using System.Runtime.CompilerServices;

namespace youknowcaliber;

internal struct Cookie
{
	public extern string sHostKey
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public string sName
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set
		{
			//Discarded unreachable code: IL_0003, IL_000b, IL_0011
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0002: Stack underflow*/^ /*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Unknown opcode: 0xFF*/;
		}
	}

	public extern string sPath
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern string sExpiresUtc
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public string sKey
	{
		[CompilerGenerated]
		get
		{
			//Discarded unreachable code: IL_0007
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
			}
		}
		[CompilerGenerated]
		set;
	}

	public extern string sValue
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public unsafe string sIsSecure
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set
		{
			//Discarded unreachable code: IL_0010, IL_0016, IL_001e
			//IL_0000: Unsupported input type for neg.
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Expected F8, but got Unknown
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				_003F val = 0 - /*Error near IL_0001: Stack underflow*/;
				((double[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (double)val;
				long num = *(long*)(nint)/*Error near IL_0003: Stack underflow*/;
				_003F val2 = checked(/*Error near IL_0004: Stack underflow*/ + num);
				_003F val3 = /*Error near IL_0005: Stack underflow*/& val2;
				_ = /*Error near IL_0007: Stack underflow*// val3;
				/*Error near IL_0007: stloc 2 (out-of-bounds)*/;
				this = ref *(Cookie*)/*Error near IL_000a: Stack underflow*/;
			}
		}
	}
}
