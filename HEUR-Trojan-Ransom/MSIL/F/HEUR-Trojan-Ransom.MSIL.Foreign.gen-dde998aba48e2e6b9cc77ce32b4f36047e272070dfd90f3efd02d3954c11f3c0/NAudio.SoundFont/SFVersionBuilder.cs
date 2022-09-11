using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.SoundFont;

internal sealed class SFVersionBuilder : StructureBuilder<SFVersion>
{
	[NonSerialized]
	internal static GetString _0005;

	public override int Length => 4;

	public override SFVersion Read(BinaryReader br)
	{
		SFVersion sFVersion = new SFVersion();
		sFVersion.Major = br.ReadInt16();
		sFVersion.Minor = br.ReadInt16();
		data.Add(sFVersion);
		return sFVersion;
	}

	public override void Write(BinaryWriter bw, SFVersion v)
	{
		bw.Write(v.Major);
		bw.Write(v.Minor);
	}

	static SFVersionBuilder()
	{
		Strings.CreateGetStringDelegate(typeof(SFVersionBuilder));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0005(107397456), _0005(107397419)), _0005(107397414), _0005(107397409)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0005(107397436)))
		{
			return;
		}
		throw new SecurityException(_0005(107397379));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
