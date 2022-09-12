using System;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams;

public class StreamManipulator
{
	private int XNHZfPAZottdnGdsgnoJdYNYLfwd;

	private uint apDMpruwtLlJCAuUPtphtOimkoBl;

	private byte[] oYkGXtciPACegbIxdMJCWAdnYybr;

	private int vTJJOTbZgctLezWEhIMOSlcEAulgA;

	private int QxNxWPJIyrvMBCMaJCpFJQMAiOIl;

	public int AvailableBits => XNHZfPAZottdnGdsgnoJdYNYLfwd;

	public int AvailableBytes => vTJJOTbZgctLezWEhIMOSlcEAulgA - QxNxWPJIyrvMBCMaJCpFJQMAiOIl + (XNHZfPAZottdnGdsgnoJdYNYLfwd >> 3);

	public bool IsNeedingInput => QxNxWPJIyrvMBCMaJCpFJQMAiOIl == vTJJOTbZgctLezWEhIMOSlcEAulgA;

	public int CopyBytes(byte[] output, int offset, int length)
	{
		if (length >= 0)
		{
			if ((XNHZfPAZottdnGdsgnoJdYNYLfwd & 7) == 0)
			{
				int num = 0;
				while (XNHZfPAZottdnGdsgnoJdYNYLfwd > 0 && length > 0)
				{
					output[offset++] = (byte)apDMpruwtLlJCAuUPtphtOimkoBl;
					apDMpruwtLlJCAuUPtphtOimkoBl >>= 8;
					XNHZfPAZottdnGdsgnoJdYNYLfwd -= 8;
					length--;
					num++;
				}
				if (length == 0)
				{
					return num;
				}
				int num2 = vTJJOTbZgctLezWEhIMOSlcEAulgA - QxNxWPJIyrvMBCMaJCpFJQMAiOIl;
				if (length > num2)
				{
					length = num2;
				}
				Array.Copy(oYkGXtciPACegbIxdMJCWAdnYybr, QxNxWPJIyrvMBCMaJCpFJQMAiOIl, output, offset, length);
				QxNxWPJIyrvMBCMaJCpFJQMAiOIl += length;
				if (((uint)(QxNxWPJIyrvMBCMaJCpFJQMAiOIl - vTJJOTbZgctLezWEhIMOSlcEAulgA) & (true ? 1u : 0u)) != 0)
				{
					apDMpruwtLlJCAuUPtphtOimkoBl = oYkGXtciPACegbIxdMJCWAdnYybr[QxNxWPJIyrvMBCMaJCpFJQMAiOIl++] & 0xFFu;
					XNHZfPAZottdnGdsgnoJdYNYLfwd = 8;
				}
				return num + length;
			}
			throw new InvalidOperationException("Bit buffer is not byte aligned!");
		}
		throw new ArgumentOutOfRangeException("length");
	}

	public void DropBits(int bitCount)
	{
		apDMpruwtLlJCAuUPtphtOimkoBl >>= bitCount;
		XNHZfPAZottdnGdsgnoJdYNYLfwd -= bitCount;
	}

	public int GetBits(int bitCount)
	{
		int num = PeekBits(bitCount);
		if (num >= 0)
		{
			DropBits(bitCount);
		}
		return num;
	}

	public int PeekBits(int bitCount)
	{
		if (XNHZfPAZottdnGdsgnoJdYNYLfwd < bitCount)
		{
			if (QxNxWPJIyrvMBCMaJCpFJQMAiOIl == vTJJOTbZgctLezWEhIMOSlcEAulgA)
			{
				return -1;
			}
			apDMpruwtLlJCAuUPtphtOimkoBl |= (uint)(((oYkGXtciPACegbIxdMJCWAdnYybr[QxNxWPJIyrvMBCMaJCpFJQMAiOIl++] & 0xFF) | ((oYkGXtciPACegbIxdMJCWAdnYybr[QxNxWPJIyrvMBCMaJCpFJQMAiOIl++] & 0xFF) << 8)) << XNHZfPAZottdnGdsgnoJdYNYLfwd);
			XNHZfPAZottdnGdsgnoJdYNYLfwd += 16;
		}
		return (int)apDMpruwtLlJCAuUPtphtOimkoBl & ((1 << bitCount) - 1);
	}

	public void Reset()
	{
		apDMpruwtLlJCAuUPtphtOimkoBl = 0u;
		XNHZfPAZottdnGdsgnoJdYNYLfwd = 0;
		vTJJOTbZgctLezWEhIMOSlcEAulgA = 0;
		QxNxWPJIyrvMBCMaJCpFJQMAiOIl = 0;
	}

	public void SetInput(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset >= 0)
		{
			if (count >= 0)
			{
				if (QxNxWPJIyrvMBCMaJCpFJQMAiOIl >= vTJJOTbZgctLezWEhIMOSlcEAulgA)
				{
					int num = offset + count;
					if (offset <= num && num <= buffer.Length)
					{
						if (((uint)count & (true ? 1u : 0u)) != 0)
						{
							apDMpruwtLlJCAuUPtphtOimkoBl |= (uint)((buffer[offset++] & 0xFF) << XNHZfPAZottdnGdsgnoJdYNYLfwd);
							XNHZfPAZottdnGdsgnoJdYNYLfwd += 8;
						}
						oYkGXtciPACegbIxdMJCWAdnYybr = buffer;
						QxNxWPJIyrvMBCMaJCpFJQMAiOIl = offset;
						vTJJOTbZgctLezWEhIMOSlcEAulgA = num;
						return;
					}
					throw new ArgumentOutOfRangeException("count");
				}
				throw new InvalidOperationException("Old input was not completely processed");
			}
			throw new ArgumentOutOfRangeException("count", "Cannot be negative");
		}
		throw new ArgumentOutOfRangeException("offset", "Cannot be negative");
	}

	public void SkipToByteBoundary()
	{
		apDMpruwtLlJCAuUPtphtOimkoBl >>= XNHZfPAZottdnGdsgnoJdYNYLfwd & 7;
		XNHZfPAZottdnGdsgnoJdYNYLfwd &= -8;
	}
}
