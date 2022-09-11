using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public abstract class WaveStream : Stream, IWaveProvider
{
	[NonSerialized]
	internal static GetString _0016;

	public abstract WaveFormat WaveFormat { get; }

	public override bool CanRead => true;

	public override bool CanSeek => true;

	public override bool CanWrite => false;

	public virtual int BlockAlign => WaveFormat.BlockAlign;

	public virtual TimeSpan CurrentTime
	{
		get
		{
			return TimeSpan.FromSeconds((double)Position / (double)WaveFormat.AverageBytesPerSecond);
		}
		set
		{
			Position = (long)(value.TotalSeconds * (double)WaveFormat.AverageBytesPerSecond);
		}
	}

	public virtual TimeSpan TotalTime => TimeSpan.FromSeconds((double)Length / (double)WaveFormat.AverageBytesPerSecond);

	public override void Flush()
	{
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		switch (origin)
		{
		case SeekOrigin.Begin:
			Position = offset;
			break;
		case SeekOrigin.Current:
			Position += offset;
			break;
		default:
			Position = Length + offset;
			break;
		}
		return Position;
	}

	public override void SetLength(long length)
	{
		throw new NotSupportedException(_0016(107384086));
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException(_0016(107384065));
	}

	public void Skip(int seconds)
	{
		long num = Position + WaveFormat.AverageBytesPerSecond * seconds;
		if (num > Length)
		{
			Position = Length;
		}
		else if (num < 0)
		{
			Position = 0L;
		}
		else
		{
			Position = num;
		}
	}

	public virtual bool HasData(int count)
	{
		return Position < Length;
	}

	static WaveStream()
	{
		Strings.CreateGetStringDelegate(typeof(WaveStream));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0016(107398392), _0016(107398355)), _0016(107398350), _0016(107398345)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0016(107398372)))
		{
			return;
		}
		throw new SecurityException(_0016(107398315));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
