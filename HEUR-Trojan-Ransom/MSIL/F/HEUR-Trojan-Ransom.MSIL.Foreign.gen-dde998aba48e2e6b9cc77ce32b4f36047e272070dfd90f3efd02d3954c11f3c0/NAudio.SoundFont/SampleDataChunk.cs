using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.SoundFont;

internal sealed class SampleDataChunk
{
	private byte[] sampleData;

	[NonSerialized]
	internal static GetString _0008;

	public byte[] SampleData => sampleData;

	public SampleDataChunk(RiffChunk chunk)
	{
		string text = chunk.ReadChunkID();
		if (text != _0008(107394001))
		{
			throw new InvalidDataException(string.Format(_0008(107393992), text));
		}
		sampleData = chunk.GetData();
	}

	static SampleDataChunk()
	{
		Strings.CreateGetStringDelegate(typeof(SampleDataChunk));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0008(107397428), _0008(107397391)), _0008(107397386), _0008(107397381)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0008(107397408)))
		{
			return;
		}
		throw new SecurityException(_0008(107397351));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
