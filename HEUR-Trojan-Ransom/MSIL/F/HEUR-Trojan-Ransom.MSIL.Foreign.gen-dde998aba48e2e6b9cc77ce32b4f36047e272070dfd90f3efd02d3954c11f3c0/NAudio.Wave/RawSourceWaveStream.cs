using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class RawSourceWaveStream : WaveStream
{
	private readonly Stream sourceStream;

	private readonly WaveFormat waveFormat;

	[NonSerialized]
	internal static GetString _000E;

	public override WaveFormat WaveFormat => waveFormat;

	public override long Length => sourceStream.Length;

	public override long Position
	{
		get
		{
			return sourceStream.Position;
		}
		set
		{
			sourceStream.Position = value - value % waveFormat.BlockAlign;
		}
	}

	public RawSourceWaveStream(Stream sourceStream, WaveFormat waveFormat)
	{
		this.sourceStream = sourceStream;
		this.waveFormat = waveFormat;
	}

	public RawSourceWaveStream(byte[] byteStream, int offset, int count, WaveFormat waveFormat)
	{
		sourceStream = new MemoryStream(byteStream, offset, count);
		this.waveFormat = waveFormat;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		try
		{
			return sourceStream.Read(buffer, offset, count);
		}
		catch (EndOfStreamException)
		{
			return 0;
		}
	}

	static RawSourceWaveStream()
	{
		Strings.CreateGetStringDelegate(typeof(RawSourceWaveStream));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _000E(107398471), _000E(107398434)), _000E(107398429), _000E(107398424)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _000E(107398451)))
		{
			return;
		}
		throw new SecurityException(_000E(107398394));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
