using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Utils;

public sealed class ChunkIdentifier
{
	[NonSerialized]
	internal static GetString _008C;

	public static int ChunkIdentifierToInt32(string s)
	{
		if (s.Length != 4)
		{
			throw new ArgumentException(_008C(107414550));
		}
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		if (bytes.Length != 4)
		{
			throw new ArgumentException(_008C(107414473));
		}
		return BitConverter.ToInt32(bytes, 0);
	}

	static ChunkIdentifier()
	{
		Strings.CreateGetStringDelegate(typeof(ChunkIdentifier));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _008C(107399054), _008C(107399017)), _008C(107399012), _008C(107399007)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _008C(107399034)))
		{
			return;
		}
		throw new SecurityException(_008C(107398977));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
