using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Tar;

public class TarBuffer
{
	private int IIwBVINRWyDcGNiQtgFCkUNPiIzGA = 20;

	public const int BlockSize = 512;

	private int fbaKqlVXQhKvxAnAKrLZJKBFYFjD;

	private int ZmarDiJEkNWCBWwZRFdthpJeaopK;

	public const int DefaultBlockFactor = 20;

	public const int DefaultRecordSize = 10240;

	private Stream udLcDlexjlbgicZToEGmyCZFQFkYA;

	private Stream BHypYUFgTHSoukmlaCgkGlwVmhgd;

	private byte[] MJNNWehbwwKzUnysUEGwTvKLBShf;

	private int lfNnUdDHKpWbTfltFvZRnyqxqHye = 10240;

	public int BlockFactor => IIwBVINRWyDcGNiQtgFCkUNPiIzGA;

	public int CurrentBlock => fbaKqlVXQhKvxAnAKrLZJKBFYFjD;

	public int CurrentRecord => ZmarDiJEkNWCBWwZRFdthpJeaopK;

	public int RecordSize => lfNnUdDHKpWbTfltFvZRnyqxqHye;

	protected TarBuffer()
	{
	}

	public void Close()
	{
		if (BHypYUFgTHSoukmlaCgkGlwVmhgd != null)
		{
			THnSEfXDiaoRRUtYFkqYfqwEkNYD();
			BHypYUFgTHSoukmlaCgkGlwVmhgd.Close();
			BHypYUFgTHSoukmlaCgkGlwVmhgd = null;
		}
		else if (udLcDlexjlbgicZToEGmyCZFQFkYA != null)
		{
			udLcDlexjlbgicZToEGmyCZFQFkYA.Close();
			udLcDlexjlbgicZToEGmyCZFQFkYA = null;
		}
	}

	public static TarBuffer CreateInputTarBuffer(Stream inputStream)
	{
		if (inputStream == null)
		{
			throw new ArgumentNullException("inputStream");
		}
		return CreateInputTarBuffer(inputStream, 20);
	}

	public static TarBuffer CreateInputTarBuffer(Stream inputStream, int blockFactor)
	{
		if (inputStream == null)
		{
			throw new ArgumentNullException("inputStream");
		}
		if (blockFactor <= 0)
		{
			throw new ArgumentOutOfRangeException("blockFactor", "Factor cannot be negative");
		}
		TarBuffer tarBuffer = new TarBuffer
		{
			udLcDlexjlbgicZToEGmyCZFQFkYA = inputStream,
			BHypYUFgTHSoukmlaCgkGlwVmhgd = null
		};
		tarBuffer.EgsSbMJlpoeuwULFbWfLfdPUwSrN(blockFactor);
		return tarBuffer;
	}

	public static TarBuffer CreateOutputTarBuffer(Stream outputStream)
	{
		if (outputStream == null)
		{
			throw new ArgumentNullException("outputStream");
		}
		return CreateOutputTarBuffer(outputStream, 20);
	}

	public static TarBuffer CreateOutputTarBuffer(Stream outputStream, int blockFactor)
	{
		if (outputStream == null)
		{
			throw new ArgumentNullException("outputStream");
		}
		if (blockFactor <= 0)
		{
			throw new ArgumentOutOfRangeException("blockFactor", "Factor cannot be negative");
		}
		TarBuffer tarBuffer = new TarBuffer
		{
			udLcDlexjlbgicZToEGmyCZFQFkYA = null,
			BHypYUFgTHSoukmlaCgkGlwVmhgd = outputStream
		};
		tarBuffer.EgsSbMJlpoeuwULFbWfLfdPUwSrN(blockFactor);
		return tarBuffer;
	}

	private void THnSEfXDiaoRRUtYFkqYfqwEkNYD()
	{
		if (BHypYUFgTHSoukmlaCgkGlwVmhgd != null)
		{
			if (fbaKqlVXQhKvxAnAKrLZJKBFYFjD > 0)
			{
				int num = fbaKqlVXQhKvxAnAKrLZJKBFYFjD * 512;
				Array.Clear(MJNNWehbwwKzUnysUEGwTvKLBShf, num, RecordSize - num);
				IQZraHgPGiSXlGdaTmewHmQRaztn();
			}
			BHypYUFgTHSoukmlaCgkGlwVmhgd.Flush();
			return;
		}
		throw new TarException("TarBuffer.Flush no output stream defined");
	}

	[Obsolete("Use BlockFactor property instead")]
	public int GetBlockFactor()
	{
		return IIwBVINRWyDcGNiQtgFCkUNPiIzGA;
	}

	[Obsolete("Use CurrentBlock property instead")]
	public int GetCurrentBlockNum()
	{
		return fbaKqlVXQhKvxAnAKrLZJKBFYFjD;
	}

	[Obsolete("Use CurrentRecord property instead")]
	public int GetCurrentRecordNum()
	{
		return ZmarDiJEkNWCBWwZRFdthpJeaopK;
	}

	[Obsolete("Use RecordSize property instead")]
	public int GetRecordSize()
	{
		return lfNnUdDHKpWbTfltFvZRnyqxqHye;
	}

	private void EgsSbMJlpoeuwULFbWfLfdPUwSrN(int blockFactor)
	{
		IIwBVINRWyDcGNiQtgFCkUNPiIzGA = blockFactor;
		lfNnUdDHKpWbTfltFvZRnyqxqHye = blockFactor * 512;
		MJNNWehbwwKzUnysUEGwTvKLBShf = new byte[RecordSize];
		if (udLcDlexjlbgicZToEGmyCZFQFkYA == null)
		{
			ZmarDiJEkNWCBWwZRFdthpJeaopK = 0;
			fbaKqlVXQhKvxAnAKrLZJKBFYFjD = 0;
		}
		else
		{
			ZmarDiJEkNWCBWwZRFdthpJeaopK = -1;
			fbaKqlVXQhKvxAnAKrLZJKBFYFjD = BlockFactor;
		}
	}

	public static bool IsEndOfArchiveBlock(byte[] block)
	{
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		if (block.Length == 512)
		{
			int num = 0;
			while (true)
			{
				if (num < 512)
				{
					if (block[num] != 0)
					{
						break;
					}
					num++;
					continue;
				}
				return true;
			}
			return false;
		}
		throw new ArgumentException("block length is invalid");
	}

	[Obsolete("Use IsEndOfArchiveBlock instead")]
	public bool IsEOFBlock(byte[] block)
	{
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		if (block.Length != 512)
		{
			throw new ArgumentException("block length is invalid");
		}
		for (int i = 0; i < 512; i++)
		{
			if (block[i] != 0)
			{
				return false;
			}
		}
		return true;
	}

	public byte[] ReadBlock()
	{
		if (udLcDlexjlbgicZToEGmyCZFQFkYA != null)
		{
			if (fbaKqlVXQhKvxAnAKrLZJKBFYFjD >= BlockFactor && !tGIvEXdbrhDryJzeuPBHWRBWZGGb())
			{
				throw new TarException("Failed to read a record");
			}
			byte[] array = new byte[512];
			Array.Copy(MJNNWehbwwKzUnysUEGwTvKLBShf, fbaKqlVXQhKvxAnAKrLZJKBFYFjD * 512, array, 0, 512);
			fbaKqlVXQhKvxAnAKrLZJKBFYFjD++;
			return array;
		}
		throw new TarException("TarBuffer.ReadBlock - no input stream defined");
	}

	private bool tGIvEXdbrhDryJzeuPBHWRBWZGGb()
	{
		if (udLcDlexjlbgicZToEGmyCZFQFkYA == null)
		{
			throw new TarException("no input stream stream defined");
		}
		fbaKqlVXQhKvxAnAKrLZJKBFYFjD = 0;
		int num = 0;
		int num2 = RecordSize;
		while (num2 > 0)
		{
			long num3 = udLcDlexjlbgicZToEGmyCZFQFkYA.Read(MJNNWehbwwKzUnysUEGwTvKLBShf, num, num2);
			if (num3 <= 0L)
			{
				break;
			}
			num += (int)num3;
			num2 -= (int)num3;
		}
		ZmarDiJEkNWCBWwZRFdthpJeaopK++;
		return true;
	}

	public void SkipBlock()
	{
		if (udLcDlexjlbgicZToEGmyCZFQFkYA != null)
		{
			if (fbaKqlVXQhKvxAnAKrLZJKBFYFjD >= BlockFactor && !tGIvEXdbrhDryJzeuPBHWRBWZGGb())
			{
				throw new TarException("Failed to read a record");
			}
			fbaKqlVXQhKvxAnAKrLZJKBFYFjD++;
			return;
		}
		throw new TarException("no input stream defined");
	}

	public void WriteBlock(byte[] block)
	{
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		if (BHypYUFgTHSoukmlaCgkGlwVmhgd != null)
		{
			if (block.Length != 512)
			{
				throw new TarException($"TarBuffer.WriteBlock - block to write has length '{block.Length}' which is not the block size of '{512}'");
			}
			if (fbaKqlVXQhKvxAnAKrLZJKBFYFjD >= BlockFactor)
			{
				IQZraHgPGiSXlGdaTmewHmQRaztn();
			}
			Array.Copy(block, 0, MJNNWehbwwKzUnysUEGwTvKLBShf, fbaKqlVXQhKvxAnAKrLZJKBFYFjD * 512, 512);
			fbaKqlVXQhKvxAnAKrLZJKBFYFjD++;
			return;
		}
		throw new TarException("TarBuffer.WriteBlock - no output stream defined");
	}

	public void WriteBlock(byte[] buffer, int offset)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (BHypYUFgTHSoukmlaCgkGlwVmhgd == null)
		{
			throw new TarException("TarBuffer.WriteBlock - no output stream stream defined");
		}
		if (offset >= 0 && offset < buffer.Length)
		{
			if (offset + 512 <= buffer.Length)
			{
				if (fbaKqlVXQhKvxAnAKrLZJKBFYFjD >= BlockFactor)
				{
					IQZraHgPGiSXlGdaTmewHmQRaztn();
				}
				Array.Copy(buffer, offset, MJNNWehbwwKzUnysUEGwTvKLBShf, fbaKqlVXQhKvxAnAKrLZJKBFYFjD * 512, 512);
				fbaKqlVXQhKvxAnAKrLZJKBFYFjD++;
				return;
			}
			throw new TarException($"TarBuffer.WriteBlock - record has length '{buffer.Length}' with offset '{offset}' which is less than the record size of '{lfNnUdDHKpWbTfltFvZRnyqxqHye}'");
		}
		throw new ArgumentOutOfRangeException("offset");
	}

	private void IQZraHgPGiSXlGdaTmewHmQRaztn()
	{
		if (BHypYUFgTHSoukmlaCgkGlwVmhgd == null)
		{
			throw new TarException("TarBuffer.WriteRecord no output stream defined");
		}
		BHypYUFgTHSoukmlaCgkGlwVmhgd.Write(MJNNWehbwwKzUnysUEGwTvKLBShf, 0, RecordSize);
		BHypYUFgTHSoukmlaCgkGlwVmhgd.Flush();
		fbaKqlVXQhKvxAnAKrLZJKBFYFjD = 0;
		ZmarDiJEkNWCBWwZRFdthpJeaopK++;
	}
}
