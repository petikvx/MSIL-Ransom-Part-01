using System;
using System.Drawing;
using Loki.Messaging.Interfaces;
using Loki.Utilities.Interfaces;

namespace Loki.Utilities.Implementation;

internal class ZZZZo : ZZZR
{
	private static readonly Lazy<ZZZZo> ZZZZr;

	public unsafe static ZZZZo ZZZZs
	{
		get
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected I8, but got Unknown
			//IL_0022: Expected O, but got Unknown
			do
			{
				_ = -78;
				/*Error near IL_0002: stloc 0 (out-of-bounds)*/;
				*(_003F*)(nint)/*Error near IL_0004: Stack underflow*/ = /*Error near IL_0004: Stack underflow*/;
				/*Error near IL_0004: starg 0 (out-of-bounds)*/;
				sbyte num2;
				checked
				{
					nint num = (nint)unchecked((long)((ushort[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/]) * 4;
					num2 = ((sbyte[])/*Error near IL_000f: Stack underflow*/)[num];
				}
				_003F val = /*Error near IL_0013: Stack underflow*/>> (int)(double)(uint)num2;
				((long[])/*Error near IL_0015: Stack underflow*/)[/*Error near IL_0015: Stack underflow*/] = (long)val;
			}
			while (/*Error near IL_001a: Stack underflow*/ > /*Error near IL_001a: Stack underflow*/);
			/*Error near IL_001b: ldarg 2 (out-of-bounds)*/;
			/*Error near IL_001e: stloc 1 (out-of-bounds)*/;
			return (ZZZZo)/*Error near IL_001f: ldloca 0 (out-of-bounds)*/;
		}
	}

	private extern string ZZZZt { get; }

	private extern Bitmap ZZZZu { get; }

	private extern ZZZZo();

	private extern ZZZZZZw ZZZZp();

	public extern void ZZZZq();

	void ZZZR.ZZZS()
	{
		//ILSpy generated this explicit interface implementation from .override directive in ZZZZq
		this.ZZZZq();
	}
}
