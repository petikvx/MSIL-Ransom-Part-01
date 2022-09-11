using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Codecs;

public sealed class ALawDecoder
{
	private static readonly short[] ALawDecompressTable;

	[NonSerialized]
	internal static GetString _0098;

	public static short ALawToLinearSample(byte aLaw)
	{
		return ALawDecompressTable[aLaw];
	}

	static ALawDecoder()
	{
		Strings.CreateGetStringDelegate(typeof(ALawDecoder));
		bool flag = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(_0098(107400297), _0098(107400260)).Replace(_0098(107400255), _0098(107400250)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, true, out flag) || !flag || !executingAssembly.FullName!.EndsWith(_0098(107400277)))
		{
			throw new SecurityException(_0098(107400220));
		}
		ALawDecompressTable = new short[256]
		{
			-5504, -5248, -6016, -5760, -4480, -4224, -4992, -4736, -7552, -7296,
			-8064, -7808, -6528, -6272, -7040, -6784, -2752, -2624, -3008, -2880,
			-2240, -2112, -2496, -2368, -3776, -3648, -4032, -3904, -3264, -3136,
			-3520, -3392, -22016, -20992, -24064, -23040, -17920, -16896, -19968, -18944,
			-30208, -29184, -32256, -31232, -26112, -25088, -28160, -27136, -11008, -10496,
			-12032, -11520, -8960, -8448, -9984, -9472, -15104, -14592, -16128, -15616,
			-13056, -12544, -14080, -13568, -344, -328, -376, -360, -280, -264,
			-312, -296, -472, -456, -504, -488, -408, -392, -440, -424,
			-88, -72, -120, -104, -24, -8, -56, -40, -216, -200,
			-248, -232, -152, -136, -184, -168, -1376, -1312, -1504, -1440,
			-1120, -1056, -1248, -1184, -1888, -1824, -2016, -1952, -1632, -1568,
			-1760, -1696, -688, -656, -752, -720, -560, -528, -624, -592,
			-944, -912, -1008, -976, -816, -784, -880, -848, 5504, 5248,
			6016, 5760, 4480, 4224, 4992, 4736, 7552, 7296, 8064, 7808,
			6528, 6272, 7040, 6784, 2752, 2624, 3008, 2880, 2240, 2112,
			2496, 2368, 3776, 3648, 4032, 3904, 3264, 3136, 3520, 3392,
			22016, 20992, 24064, 23040, 17920, 16896, 19968, 18944, 30208, 29184,
			32256, 31232, 26112, 25088, 28160, 27136, 11008, 10496, 12032, 11520,
			8960, 8448, 9984, 9472, 15104, 14592, 16128, 15616, 13056, 12544,
			14080, 13568, 344, 328, 376, 360, 280, 264, 312, 296,
			472, 456, 504, 488, 408, 392, 440, 424, 88, 72,
			120, 104, 24, 8, 56, 40, 216, 200, 248, 232,
			152, 136, 184, 168, 1376, 1312, 1504, 1440, 1120, 1056,
			1248, 1184, 1888, 1824, 2016, 1952, 1632, 1568, 1760, 1696,
			688, 656, 752, 720, 560, 528, 624, 592, 944, 912,
			1008, 976, 816, 784, 880, 848
		};
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
