using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

[StructLayout(LayoutKind.Explicit, Pack = 2)]
public sealed class WaveBuffer : IWaveBuffer
{
	[FieldOffset(0)]
	public int numberOfBytes;

	[FieldOffset(8)]
	private byte[] byteBuffer;

	[FieldOffset(8)]
	private float[] floatBuffer;

	[FieldOffset(8)]
	private short[] shortBuffer;

	[FieldOffset(8)]
	private int[] intBuffer;

	[NonSerialized]
	internal static GetString _009E;

	public byte[] ByteBuffer => byteBuffer;

	public float[] FloatBuffer => floatBuffer;

	public short[] ShortBuffer => shortBuffer;

	public int[] IntBuffer => intBuffer;

	public int MaxSize => byteBuffer.Length;

	public int ByteBufferCount
	{
		get
		{
			return numberOfBytes;
		}
		set
		{
			numberOfBytes = CheckValidityCount(_009E(107388146), value, 1);
		}
	}

	public int FloatBufferCount
	{
		get
		{
			return numberOfBytes / 4;
		}
		set
		{
			numberOfBytes = CheckValidityCount(_009E(107388157), value, 4);
		}
	}

	public int ShortBufferCount
	{
		get
		{
			return numberOfBytes / 2;
		}
		set
		{
			numberOfBytes = CheckValidityCount(_009E(107388132), value, 2);
		}
	}

	public int IntBufferCount
	{
		get
		{
			return numberOfBytes / 4;
		}
		set
		{
			numberOfBytes = CheckValidityCount(_009E(107388075), value, 4);
		}
	}

	public WaveBuffer(int sizeToAllocateInBytes)
	{
		int num = sizeToAllocateInBytes % 4;
		sizeToAllocateInBytes = ((num == 0) ? sizeToAllocateInBytes : (sizeToAllocateInBytes + 4 - num));
		byteBuffer = new byte[sizeToAllocateInBytes];
		numberOfBytes = 0;
	}

	public WaveBuffer(byte[] bufferToBoundTo)
	{
		BindTo(bufferToBoundTo);
	}

	public void BindTo(byte[] bufferToBoundTo)
	{
		byteBuffer = bufferToBoundTo;
		numberOfBytes = 0;
	}

	public static implicit operator byte[](WaveBuffer waveBuffer)
	{
		return waveBuffer.byteBuffer;
	}

	public static implicit operator float[](WaveBuffer waveBuffer)
	{
		return waveBuffer.floatBuffer;
	}

	public static implicit operator int[](WaveBuffer waveBuffer)
	{
		return waveBuffer.intBuffer;
	}

	public static implicit operator short[](WaveBuffer waveBuffer)
	{
		return waveBuffer.shortBuffer;
	}

	public void Clear()
	{
		Array.Clear(byteBuffer, 0, byteBuffer.Length);
	}

	public void Copy(Array destinationArray)
	{
		Array.Copy(byteBuffer, destinationArray, numberOfBytes);
	}

	private int CheckValidityCount(string argName, int value, int sizeOfValue)
	{
		int num = value * sizeOfValue;
		if (num % 4 != 0)
		{
			throw new ArgumentOutOfRangeException(argName, string.Format(_009E(107388054), argName, num));
		}
		if (value < 0 || value > byteBuffer.Length / sizeOfValue)
		{
			throw new ArgumentOutOfRangeException(argName, string.Format(_009E(107388009), argName, byteBuffer.Length / sizeOfValue));
		}
		return num;
	}

	static WaveBuffer()
	{
		Strings.CreateGetStringDelegate(typeof(WaveBuffer));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _009E(107398268), _009E(107398231)), _009E(107398226), _009E(107398221)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _009E(107398248)))
		{
			return;
		}
		throw new SecurityException(_009E(107398191));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
