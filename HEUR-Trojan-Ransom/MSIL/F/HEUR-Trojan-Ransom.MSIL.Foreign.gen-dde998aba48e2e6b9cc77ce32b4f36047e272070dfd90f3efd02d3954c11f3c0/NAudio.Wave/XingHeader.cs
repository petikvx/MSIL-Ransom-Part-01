using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class XingHeader
{
	[Flags]
	private enum XingHeaderOptions
	{
		Frames = 1,
		Bytes = 2,
		Toc = 4,
		VbrScale = 8
	}

	private static int[] sr_table;

	private int vbrScale = -1;

	private int startOffset;

	private int endOffset;

	private int tocOffset = -1;

	private int framesOffset = -1;

	private int bytesOffset = -1;

	private Mp3Frame frame;

	[NonSerialized]
	internal static GetString _0094;

	public int Frames
	{
		get
		{
			if (framesOffset == -1)
			{
				return -1;
			}
			return ReadBigEndian(frame.RawData, framesOffset);
		}
		set
		{
			if (framesOffset == -1)
			{
				throw new InvalidOperationException(_0094(107390087));
			}
			WriteBigEndian(frame.RawData, framesOffset, value);
		}
	}

	public int Bytes
	{
		get
		{
			if (bytesOffset == -1)
			{
				return -1;
			}
			return ReadBigEndian(frame.RawData, bytesOffset);
		}
		set
		{
			if (framesOffset == -1)
			{
				throw new InvalidOperationException(_0094(107390054));
			}
			WriteBigEndian(frame.RawData, bytesOffset, value);
		}
	}

	public int VbrScale => vbrScale;

	public Mp3Frame Mp3Frame => frame;

	private static int ReadBigEndian(byte[] buffer, int offset)
	{
		return (((((buffer[offset] << 8) | buffer[offset + 1]) << 8) | buffer[offset + 2]) << 8) | buffer[offset + 3];
	}

	private void WriteBigEndian(byte[] buffer, int offset, int value)
	{
		byte[] bytes = BitConverter.GetBytes(value);
		for (int i = 0; i < 4; i++)
		{
			buffer[offset + 3 - i] = bytes[i];
		}
	}

	public static XingHeader LoadXingHeader(Mp3Frame frame)
	{
		XingHeader xingHeader = new XingHeader();
		xingHeader.frame = frame;
		int num = 0;
		if (frame.MpegVersion == MpegVersion.Version1)
		{
			num = ((frame.ChannelMode == ChannelMode.Mono) ? 21 : 36);
		}
		else
		{
			if (frame.MpegVersion != MpegVersion.Version2)
			{
				return null;
			}
			num = ((frame.ChannelMode == ChannelMode.Mono) ? 13 : 21);
		}
		if (frame.RawData[num] == 88 && frame.RawData[num + 1] == 105 && frame.RawData[num + 2] == 110 && frame.RawData[num + 3] == 103)
		{
			xingHeader.startOffset = num;
			num += 4;
			int num2 = ReadBigEndian(frame.RawData, num);
			num += 4;
			if (((uint)num2 & (true ? 1u : 0u)) != 0)
			{
				xingHeader.framesOffset = num;
				num += 4;
			}
			if (((uint)num2 & 2u) != 0)
			{
				xingHeader.bytesOffset = num;
				num += 4;
			}
			if (((uint)num2 & 4u) != 0)
			{
				xingHeader.tocOffset = num;
				num += 100;
			}
			if (((uint)num2 & 8u) != 0)
			{
				xingHeader.vbrScale = ReadBigEndian(frame.RawData, num);
				num += 4;
			}
			xingHeader.endOffset = num;
			return xingHeader;
		}
		return null;
	}

	private XingHeader()
	{
	}

	static XingHeader()
	{
		Strings.CreateGetStringDelegate(typeof(XingHeader));
		bool flag = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(_0094(107397716), _0094(107397679)).Replace(_0094(107397674), _0094(107397669)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, true, out flag) || !flag || !executingAssembly.FullName!.EndsWith(_0094(107397696)))
		{
			throw new SecurityException(_0094(107397639));
		}
		sr_table = new int[4] { 44100, 48000, 32000, 99999 };
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
