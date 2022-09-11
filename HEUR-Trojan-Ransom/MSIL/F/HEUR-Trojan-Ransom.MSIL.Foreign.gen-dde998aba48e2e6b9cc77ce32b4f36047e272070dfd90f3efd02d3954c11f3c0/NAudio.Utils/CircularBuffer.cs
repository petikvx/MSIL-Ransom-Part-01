using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Utils;

public sealed class CircularBuffer
{
	private readonly byte[] buffer;

	private readonly object lockObject;

	private int writePosition;

	private int readPosition;

	private int byteCount;

	[NonSerialized]
	internal static GetString _0083;

	public int MaxLength => buffer.Length;

	public int Count
	{
		get
		{
			lock (lockObject)
			{
				return byteCount;
			}
		}
	}

	public CircularBuffer(int size)
	{
		buffer = new byte[size];
		lockObject = new object();
	}

	public int Write(byte[] data, int offset, int count)
	{
		lock (lockObject)
		{
			int num = 0;
			if (count > buffer.Length - byteCount)
			{
				count = buffer.Length - byteCount;
			}
			int num2 = Math.Min(buffer.Length - writePosition, count);
			Array.Copy(data, offset, buffer, writePosition, num2);
			writePosition += num2;
			writePosition %= buffer.Length;
			num += num2;
			if (num < count)
			{
				Array.Copy(data, offset + num, buffer, writePosition, count - num);
				writePosition += count - num;
				num = count;
			}
			byteCount += num;
			return num;
		}
	}

	public int Read(byte[] data, int offset, int count)
	{
		lock (lockObject)
		{
			if (count > byteCount)
			{
				count = byteCount;
			}
			int num = 0;
			int num2 = Math.Min(buffer.Length - readPosition, count);
			Array.Copy(buffer, readPosition, data, offset, num2);
			num += num2;
			readPosition += num2;
			readPosition %= buffer.Length;
			if (num < count)
			{
				Array.Copy(buffer, readPosition, data, offset + num, count - num);
				readPosition += count - num;
				num = count;
			}
			byteCount -= num;
			return num;
		}
	}

	public void Reset()
	{
		lock (lockObject)
		{
			ResetInner();
		}
	}

	private void ResetInner()
	{
		byteCount = 0;
		readPosition = 0;
		writePosition = 0;
	}

	public void Advance(int count)
	{
		lock (lockObject)
		{
			if (count >= byteCount)
			{
				ResetInner();
				return;
			}
			byteCount -= count;
			readPosition += count;
			readPosition %= MaxLength;
		}
	}

	static CircularBuffer()
	{
		Strings.CreateGetStringDelegate(typeof(CircularBuffer));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0083(107399066), _0083(107399029)), _0083(107399024), _0083(107399019)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0083(107399046)))
		{
			return;
		}
		throw new SecurityException(_0083(107398989));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
