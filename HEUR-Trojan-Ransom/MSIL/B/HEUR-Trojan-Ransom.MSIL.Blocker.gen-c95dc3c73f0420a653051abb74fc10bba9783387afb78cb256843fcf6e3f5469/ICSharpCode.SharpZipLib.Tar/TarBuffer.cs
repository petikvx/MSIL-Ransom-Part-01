using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Tar;

public class TarBuffer
{
	private int LzyhftdVABCQWiDpcvMxQCMASpur = 20;

	public const int BlockSize = 512;

	private int kOcuiYjWVUmUfbhSRhmctOJGIroT;

	private int KGcWRVrwievuVhTqIbIUPDYdhVkgA;

	public const int DefaultBlockFactor = 20;

	public const int DefaultRecordSize = 10240;

	private Stream viTxStDvqASejgqgxHTMyORUexkB;

	private Stream UBawXfdXyqKieHsHpcFDdqcWxNzgA;

	private byte[] LxZqdBPOwBPQGUWXVDbJpCNOawis;

	private int otRsTUxHTAnyNIUYQAosBdhcWLrS = 10240;

	public int BlockFactor => LzyhftdVABCQWiDpcvMxQCMASpur;

	public int CurrentBlock => kOcuiYjWVUmUfbhSRhmctOJGIroT;

	public int CurrentRecord => KGcWRVrwievuVhTqIbIUPDYdhVkgA;

	public int RecordSize => otRsTUxHTAnyNIUYQAosBdhcWLrS;

	protected TarBuffer()
	{
	}

	public void Close()
	{
		if (UBawXfdXyqKieHsHpcFDdqcWxNzgA != null)
		{
			QxrfgOkbBVYEDNvGSgrzaNzdPFPLb();
			UBawXfdXyqKieHsHpcFDdqcWxNzgA.Close();
			UBawXfdXyqKieHsHpcFDdqcWxNzgA = null;
		}
		else if (viTxStDvqASejgqgxHTMyORUexkB != null)
		{
			viTxStDvqASejgqgxHTMyORUexkB.Close();
			viTxStDvqASejgqgxHTMyORUexkB = null;
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
		TarBuffer tarBuffer = new TarBuffer();
		tarBuffer.viTxStDvqASejgqgxHTMyORUexkB = inputStream;
		tarBuffer.UBawXfdXyqKieHsHpcFDdqcWxNzgA = null;
		tarBuffer.JmoPVjxnELOhezgyyasePmQDdcem(blockFactor);
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
		TarBuffer tarBuffer = new TarBuffer();
		tarBuffer.viTxStDvqASejgqgxHTMyORUexkB = null;
		tarBuffer.UBawXfdXyqKieHsHpcFDdqcWxNzgA = outputStream;
		tarBuffer.JmoPVjxnELOhezgyyasePmQDdcem(blockFactor);
		return tarBuffer;
	}

	private void QxrfgOkbBVYEDNvGSgrzaNzdPFPLb()
	{
		if (UBawXfdXyqKieHsHpcFDdqcWxNzgA == null)
		{
			throw new TarException("TarBuffer.Flush no output stream defined");
		}
		if (kOcuiYjWVUmUfbhSRhmctOJGIroT > 0)
		{
			int num = kOcuiYjWVUmUfbhSRhmctOJGIroT * 512;
			Array.Clear(LxZqdBPOwBPQGUWXVDbJpCNOawis, num, RecordSize - num);
			XyLWWaMMIRjQflBBSfWPdJHUArif();
		}
		UBawXfdXyqKieHsHpcFDdqcWxNzgA.Flush();
	}

	[Obsolete("Use BlockFactor property instead")]
	public int GetBlockFactor()
	{
		return LzyhftdVABCQWiDpcvMxQCMASpur;
	}

	[Obsolete("Use CurrentBlock property instead")]
	public int GetCurrentBlockNum()
	{
		return kOcuiYjWVUmUfbhSRhmctOJGIroT;
	}

	[Obsolete("Use CurrentRecord property instead")]
	public int GetCurrentRecordNum()
	{
		return KGcWRVrwievuVhTqIbIUPDYdhVkgA;
	}

	[Obsolete("Use RecordSize property instead")]
	public int GetRecordSize()
	{
		return otRsTUxHTAnyNIUYQAosBdhcWLrS;
	}

	private void JmoPVjxnELOhezgyyasePmQDdcem(int blockFactor)
	{
		LzyhftdVABCQWiDpcvMxQCMASpur = blockFactor;
		otRsTUxHTAnyNIUYQAosBdhcWLrS = blockFactor * 512;
		LxZqdBPOwBPQGUWXVDbJpCNOawis = new byte[RecordSize];
		if (viTxStDvqASejgqgxHTMyORUexkB != null)
		{
			KGcWRVrwievuVhTqIbIUPDYdhVkgA = -1;
			kOcuiYjWVUmUfbhSRhmctOJGIroT = BlockFactor;
		}
		else
		{
			KGcWRVrwievuVhTqIbIUPDYdhVkgA = 0;
			kOcuiYjWVUmUfbhSRhmctOJGIroT = 0;
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

	public byte[] ReadBlock()
	{
		if (viTxStDvqASejgqgxHTMyORUexkB == null)
		{
			throw new TarException("TarBuffer.ReadBlock - no input stream defined");
		}
		if (kOcuiYjWVUmUfbhSRhmctOJGIroT >= BlockFactor && !ycMdFzBXxChxbigMpYKyTiWYVeDkA())
		{
			throw new TarException("Failed to read a record");
		}
		byte[] array = new byte[512];
		Array.Copy(LxZqdBPOwBPQGUWXVDbJpCNOawis, kOcuiYjWVUmUfbhSRhmctOJGIroT * 512, array, 0, 512);
		kOcuiYjWVUmUfbhSRhmctOJGIroT++;
		return array;
	}

	private bool ycMdFzBXxChxbigMpYKyTiWYVeDkA()
	{
		if (viTxStDvqASejgqgxHTMyORUexkB == null)
		{
			throw new TarException("no input stream stream defined");
		}
		kOcuiYjWVUmUfbhSRhmctOJGIroT = 0;
		int num = 0;
		int num2 = RecordSize;
		while (num2 > 0)
		{
			long num3 = viTxStDvqASejgqgxHTMyORUexkB.Read(LxZqdBPOwBPQGUWXVDbJpCNOawis, num, num2);
			if (num3 <= 0L)
			{
				break;
			}
			num += (int)num3;
			num2 -= (int)num3;
		}
		KGcWRVrwievuVhTqIbIUPDYdhVkgA++;
		return true;
	}

	public void SkipBlock()
	{
		if (viTxStDvqASejgqgxHTMyORUexkB == null)
		{
			throw new TarException("no input stream defined");
		}
		if (kOcuiYjWVUmUfbhSRhmctOJGIroT >= BlockFactor && !ycMdFzBXxChxbigMpYKyTiWYVeDkA())
		{
			throw new TarException("Failed to read a record");
		}
		kOcuiYjWVUmUfbhSRhmctOJGIroT++;
	}

	public void WriteBlock(byte[] block)
	{
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		if (UBawXfdXyqKieHsHpcFDdqcWxNzgA != null)
		{
			if (block.Length == 512)
			{
				if (kOcuiYjWVUmUfbhSRhmctOJGIroT >= BlockFactor)
				{
					XyLWWaMMIRjQflBBSfWPdJHUArif();
				}
				Array.Copy(block, 0, LxZqdBPOwBPQGUWXVDbJpCNOawis, kOcuiYjWVUmUfbhSRhmctOJGIroT * 512, 512);
				kOcuiYjWVUmUfbhSRhmctOJGIroT++;
				return;
			}
			throw new TarException($"TarBuffer.WriteBlock - block to write has length '{block.Length}' which is not the block size of '{512}'");
		}
		throw new TarException("TarBuffer.WriteBlock - no output stream defined");
	}

	public void WriteBlock(byte[] buffer, int offset)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (UBawXfdXyqKieHsHpcFDdqcWxNzgA != null)
		{
			if (offset >= 0 && offset < buffer.Length)
			{
				if (offset + 512 > buffer.Length)
				{
					throw new TarException($"TarBuffer.WriteBlock - record has length '{buffer.Length}' with offset '{offset}' which is less than the record size of '{otRsTUxHTAnyNIUYQAosBdhcWLrS}'");
				}
				if (kOcuiYjWVUmUfbhSRhmctOJGIroT >= BlockFactor)
				{
					XyLWWaMMIRjQflBBSfWPdJHUArif();
				}
				Array.Copy(buffer, offset, LxZqdBPOwBPQGUWXVDbJpCNOawis, kOcuiYjWVUmUfbhSRhmctOJGIroT * 512, 512);
				kOcuiYjWVUmUfbhSRhmctOJGIroT++;
				return;
			}
			throw new ArgumentOutOfRangeException("offset");
		}
		throw new TarException("TarBuffer.WriteBlock - no output stream stream defined");
	}

	private void XyLWWaMMIRjQflBBSfWPdJHUArif()
	{
		if (UBawXfdXyqKieHsHpcFDdqcWxNzgA == null)
		{
			throw new TarException("TarBuffer.WriteRecord no output stream defined");
		}
		UBawXfdXyqKieHsHpcFDdqcWxNzgA.Write(LxZqdBPOwBPQGUWXVDbJpCNOawis, 0, RecordSize);
		UBawXfdXyqKieHsHpcFDdqcWxNzgA.Flush();
		kOcuiYjWVUmUfbhSRhmctOJGIroT = 0;
		KGcWRVrwievuVhTqIbIUPDYdhVkgA++;
	}
}
