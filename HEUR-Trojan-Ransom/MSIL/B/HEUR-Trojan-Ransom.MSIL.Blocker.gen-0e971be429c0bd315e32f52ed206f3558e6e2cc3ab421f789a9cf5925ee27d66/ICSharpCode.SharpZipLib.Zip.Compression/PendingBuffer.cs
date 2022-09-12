using System;

namespace ICSharpCode.SharpZipLib.Zip.Compression;

public class PendingBuffer
{
	private int MlHcdEjmGUvxmFZOIsKfeXQdlDiS;

	private uint UgSmHtfWpKAzsjinZYhiLssajjjH;

	private byte[] apDMpruwtLlJCAuUPtphtOimkoBl;

	private int MJKWhUrNwzNBdVNFDjpgJckseGKX;

	private int robbuRuvqKXArSbkVhznXiEqPMyy;

	public int BitCount => MlHcdEjmGUvxmFZOIsKfeXQdlDiS;

	public bool IsFlushed => MJKWhUrNwzNBdVNFDjpgJckseGKX == 0;

	public PendingBuffer()
		: this(4096)
	{
	}

	public PendingBuffer(int bufferSize)
	{
		apDMpruwtLlJCAuUPtphtOimkoBl = new byte[bufferSize];
	}

	public void AlignToByte()
	{
		if (MlHcdEjmGUvxmFZOIsKfeXQdlDiS > 0)
		{
			apDMpruwtLlJCAuUPtphtOimkoBl[MJKWhUrNwzNBdVNFDjpgJckseGKX++] = (byte)UgSmHtfWpKAzsjinZYhiLssajjjH;
			if (MlHcdEjmGUvxmFZOIsKfeXQdlDiS > 8)
			{
				apDMpruwtLlJCAuUPtphtOimkoBl[MJKWhUrNwzNBdVNFDjpgJckseGKX++] = (byte)(UgSmHtfWpKAzsjinZYhiLssajjjH >> 8);
			}
		}
		UgSmHtfWpKAzsjinZYhiLssajjjH = 0u;
		MlHcdEjmGUvxmFZOIsKfeXQdlDiS = 0;
	}

	public int Flush(byte[] output, int offset, int length)
	{
		if (MlHcdEjmGUvxmFZOIsKfeXQdlDiS >= 8)
		{
			apDMpruwtLlJCAuUPtphtOimkoBl[MJKWhUrNwzNBdVNFDjpgJckseGKX++] = (byte)UgSmHtfWpKAzsjinZYhiLssajjjH;
			UgSmHtfWpKAzsjinZYhiLssajjjH >>= 8;
			MlHcdEjmGUvxmFZOIsKfeXQdlDiS -= 8;
		}
		if (length <= MJKWhUrNwzNBdVNFDjpgJckseGKX - robbuRuvqKXArSbkVhznXiEqPMyy)
		{
			Array.Copy(apDMpruwtLlJCAuUPtphtOimkoBl, robbuRuvqKXArSbkVhznXiEqPMyy, output, offset, length);
			robbuRuvqKXArSbkVhznXiEqPMyy += length;
			return length;
		}
		length = MJKWhUrNwzNBdVNFDjpgJckseGKX - robbuRuvqKXArSbkVhznXiEqPMyy;
		Array.Copy(apDMpruwtLlJCAuUPtphtOimkoBl, robbuRuvqKXArSbkVhznXiEqPMyy, output, offset, length);
		robbuRuvqKXArSbkVhznXiEqPMyy = 0;
		MJKWhUrNwzNBdVNFDjpgJckseGKX = 0;
		return length;
	}

	public void Reset()
	{
		MlHcdEjmGUvxmFZOIsKfeXQdlDiS = 0;
		MJKWhUrNwzNBdVNFDjpgJckseGKX = 0;
		robbuRuvqKXArSbkVhznXiEqPMyy = 0;
	}

	public byte[] ToByteArray()
	{
		byte[] array = new byte[MJKWhUrNwzNBdVNFDjpgJckseGKX - robbuRuvqKXArSbkVhznXiEqPMyy];
		Array.Copy(apDMpruwtLlJCAuUPtphtOimkoBl, robbuRuvqKXArSbkVhznXiEqPMyy, array, 0, array.Length);
		robbuRuvqKXArSbkVhznXiEqPMyy = 0;
		MJKWhUrNwzNBdVNFDjpgJckseGKX = 0;
		return array;
	}

	public void WriteBits(int int_1, int count)
	{
		UgSmHtfWpKAzsjinZYhiLssajjjH |= (uint)(int_1 << MlHcdEjmGUvxmFZOIsKfeXQdlDiS);
		MlHcdEjmGUvxmFZOIsKfeXQdlDiS += count;
		if (MlHcdEjmGUvxmFZOIsKfeXQdlDiS >= 16)
		{
			apDMpruwtLlJCAuUPtphtOimkoBl[MJKWhUrNwzNBdVNFDjpgJckseGKX++] = (byte)UgSmHtfWpKAzsjinZYhiLssajjjH;
			apDMpruwtLlJCAuUPtphtOimkoBl[MJKWhUrNwzNBdVNFDjpgJckseGKX++] = (byte)(UgSmHtfWpKAzsjinZYhiLssajjjH >> 8);
			UgSmHtfWpKAzsjinZYhiLssajjjH >>= 16;
			MlHcdEjmGUvxmFZOIsKfeXQdlDiS -= 16;
		}
	}

	public void WriteBlock(byte[] block, int offset, int length)
	{
		Array.Copy(block, offset, apDMpruwtLlJCAuUPtphtOimkoBl, MJKWhUrNwzNBdVNFDjpgJckseGKX, length);
		MJKWhUrNwzNBdVNFDjpgJckseGKX += length;
	}

	public void WriteByte(int value)
	{
		apDMpruwtLlJCAuUPtphtOimkoBl[MJKWhUrNwzNBdVNFDjpgJckseGKX++] = (byte)value;
	}

	public void WriteInt(int value)
	{
		apDMpruwtLlJCAuUPtphtOimkoBl[MJKWhUrNwzNBdVNFDjpgJckseGKX++] = (byte)value;
		apDMpruwtLlJCAuUPtphtOimkoBl[MJKWhUrNwzNBdVNFDjpgJckseGKX++] = (byte)(value >> 8);
		apDMpruwtLlJCAuUPtphtOimkoBl[MJKWhUrNwzNBdVNFDjpgJckseGKX++] = (byte)(value >> 16);
		apDMpruwtLlJCAuUPtphtOimkoBl[MJKWhUrNwzNBdVNFDjpgJckseGKX++] = (byte)(value >> 24);
	}

	public void WriteShort(int value)
	{
		apDMpruwtLlJCAuUPtphtOimkoBl[MJKWhUrNwzNBdVNFDjpgJckseGKX++] = (byte)value;
		apDMpruwtLlJCAuUPtphtOimkoBl[MJKWhUrNwzNBdVNFDjpgJckseGKX++] = (byte)(value >> 8);
	}

	public void WriteShortMSB(int int_1)
	{
		apDMpruwtLlJCAuUPtphtOimkoBl[MJKWhUrNwzNBdVNFDjpgJckseGKX++] = (byte)(int_1 >> 8);
		apDMpruwtLlJCAuUPtphtOimkoBl[MJKWhUrNwzNBdVNFDjpgJckseGKX++] = (byte)int_1;
	}
}
