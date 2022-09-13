using System.Runtime.CompilerServices;

namespace youknowcaliber;

internal struct CreditCard
{
	public string sNumber
	{
		[CompilerGenerated]
		get;
		set
		{
			//Discarded unreachable code: IL_0005, IL_000d, IL_0028, IL_0030, IL_0035, IL_003b, IL_0041
			//IL_0019: Expected I8, but got I4
			/*Error: Invalid metadata token*/;
		}
	}

	public extern string sExpYear { get; set; }

	public unsafe string sExpMonth
	{
		get
		{
			//Discarded unreachable code: IL_001b, IL_0021, IL_0025, IL_0028, IL_002e
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				this = ref *(CreditCard*)/*Error near IL_0002: Stack underflow*/;
				_003F val = /*Error near IL_0002: ldarg 1 (out-of-bounds)*/;
				if (/*Error near IL_0008: Stack underflow*/ <= val)
				{
					/*Error near IL_0009: stloc 0 (out-of-bounds)*/;
					if (/*Error near IL_0010: Stack underflow*/ < /*Error near IL_0010: Stack underflow*/&& (int)/*Error near IL_0015: Stack underflow*/ == 0)
					{
					}
				}
			}
		}
		set; }

	public string sName
	{
		get; set
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0009, IL_000f, IL_0019, IL_001e, IL_0025
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			/*Error: stloc 0 (out-of-bounds)*/;
			/*Error near IL_0001: Unknown opcode: 0xF8*/;
		}
	}
}
