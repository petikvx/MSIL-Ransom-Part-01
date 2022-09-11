using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class WaveRecorder : IDisposable, IWaveProvider
{
	private WaveFileWriter writer;

	private IWaveProvider source;

	[NonSerialized]
	internal static GetString _0082;

	public WaveFormat WaveFormat => source.WaveFormat;

	public WaveRecorder(IWaveProvider source, string destination)
	{
		this.source = source;
		writer = new WaveFileWriter(destination, source.WaveFormat);
	}

	public int Read(byte[] buffer, int offset, int count)
	{
		int num = source.Read(buffer, offset, count);
		writer.Write(buffer, offset, num);
		return num;
	}

	public void Dispose()
	{
		if (writer != null)
		{
			writer.Dispose();
			writer = null;
		}
	}

	static WaveRecorder()
	{
		Strings.CreateGetStringDelegate(typeof(WaveRecorder));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0082(107398380), _0082(107398343)), _0082(107398338), _0082(107398333)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0082(107398360)))
		{
			return;
		}
		throw new SecurityException(_0082(107398303));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
