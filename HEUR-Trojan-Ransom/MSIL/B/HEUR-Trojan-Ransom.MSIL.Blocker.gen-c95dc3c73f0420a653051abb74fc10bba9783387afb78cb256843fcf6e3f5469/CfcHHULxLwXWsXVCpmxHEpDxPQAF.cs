using System;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;

internal class CfcHHULxLwXWsXVCpmxHEpDxPQAF : Stream
{
	private bool DgiMWAyYXuMgrDjZVikwIqShKRng;

	private Stream NgkEqlfARpYpYNgLumApjMmDSHJhb;

	bool Stream.CanRead => NgkEqlfARpYpYNgLumApjMmDSHJhb.CanRead;

	bool Stream.CanSeek => NgkEqlfARpYpYNgLumApjMmDSHJhb.CanSeek;

	bool Stream.CanTimeout => NgkEqlfARpYpYNgLumApjMmDSHJhb.CanTimeout;

	bool Stream.CanWrite => NgkEqlfARpYpYNgLumApjMmDSHJhb.CanWrite;

	public bool HTFIeiABiJBGNjpOAGEOJylRFbQe
	{
		get
		{
			return DgiMWAyYXuMgrDjZVikwIqShKRng;
		}
		set
		{
			DgiMWAyYXuMgrDjZVikwIqShKRng = value;
		}
	}

	long Stream.Length => NgkEqlfARpYpYNgLumApjMmDSHJhb.Length;

	long Stream.Position
	{
		get
		{
			return NgkEqlfARpYpYNgLumApjMmDSHJhb.Position;
		}
		set
		{
			NgkEqlfARpYpYNgLumApjMmDSHJhb.Position = value;
		}
	}

	public CfcHHULxLwXWsXVCpmxHEpDxPQAF(Stream stream)
	{
		NgkEqlfARpYpYNgLumApjMmDSHJhb = stream;
	}

	public CfcHHULxLwXWsXVCpmxHEpDxPQAF(string name)
	{
		NgkEqlfARpYpYNgLumApjMmDSHJhb = new FileStream(name, FileMode.Open, FileAccess.ReadWrite);
		DgiMWAyYXuMgrDjZVikwIqShKRng = true;
	}

	public override void mpefNMoGvicOqKbIavuPRKrLTHIk()
	{
		Stream ngkEqlfARpYpYNgLumApjMmDSHJhb = NgkEqlfARpYpYNgLumApjMmDSHJhb;
		NgkEqlfARpYpYNgLumApjMmDSHJhb = null;
		if (DgiMWAyYXuMgrDjZVikwIqShKRng && ngkEqlfARpYpYNgLumApjMmDSHJhb != null)
		{
			DgiMWAyYXuMgrDjZVikwIqShKRng = false;
			ngkEqlfARpYpYNgLumApjMmDSHJhb.Close();
		}
	}

	public override void QxrfgOkbBVYEDNvGSgrzaNzdPFPLb()
	{
		NgkEqlfARpYpYNgLumApjMmDSHJhb.Flush();
	}

	public long RWJEtMzwFGAycwGfgDZhGGVDMqtQ(int signature, long endLocation, int minimumBlockSize, int maximumVariableData)
	{
		long num = endLocation - minimumBlockSize;
		if (num >= 0L)
		{
			long num2 = Math.Max(num - maximumVariableData, 0L);
			while (num >= num2)
			{
				num--;
				Seek(num, SeekOrigin.Begin);
				if (qCqCmGPNlORNVsCsMzEbsQnhcNgIA() == signature)
				{
					return Position;
				}
			}
		}
		return -1L;
	}

	public override int QuRHndxCozYYFKqaLJQIqSdmmaX(byte[] buffer, int offset, int count)
	{
		return NgkEqlfARpYpYNgLumApjMmDSHJhb.Read(buffer, offset, count);
	}

	public void VPNVkTYFRgWjVXjCBrNWSFxnHlgi(bool zip64, DescriptorData data)
	{
		if (qCqCmGPNlORNVsCsMzEbsQnhcNgIA() != 134695760)
		{
			throw new ZipException("Data descriptor signature not found");
		}
		data.Crc = qCqCmGPNlORNVsCsMzEbsQnhcNgIA();
		if (!zip64)
		{
			data.CompressedSize = qCqCmGPNlORNVsCsMzEbsQnhcNgIA();
			data.Size = qCqCmGPNlORNVsCsMzEbsQnhcNgIA();
		}
		else
		{
			data.CompressedSize = XBoMohwlbiIKOrBkHamgPzBMPWzo();
			data.Size = XBoMohwlbiIKOrBkHamgPzBMPWzo();
		}
	}

	public int qCqCmGPNlORNVsCsMzEbsQnhcNgIA()
	{
		return pemcXlQRWARdCRweuWeqNyeeMNBA() | (pemcXlQRWARdCRweuWeqNyeeMNBA() << 16);
	}

	public long XBoMohwlbiIKOrBkHamgPzBMPWzo()
	{
		return (long)qCqCmGPNlORNVsCsMzEbsQnhcNgIA() | (long)qCqCmGPNlORNVsCsMzEbsQnhcNgIA();
	}

	public int pemcXlQRWARdCRweuWeqNyeeMNBA()
	{
		int num = NgkEqlfARpYpYNgLumApjMmDSHJhb.ReadByte();
		if (num < 0)
		{
			throw new EndOfStreamException();
		}
		int num2 = NgkEqlfARpYpYNgLumApjMmDSHJhb.ReadByte();
		if (num2 < 0)
		{
			throw new EndOfStreamException();
		}
		return num | (num2 << 8);
	}

	public override long zpGkAbiwMvQDGqsanjJTcNBnkbRT(long offset, SeekOrigin origin)
	{
		return NgkEqlfARpYpYNgLumApjMmDSHJhb.Seek(offset, origin);
	}

	public override void DEQgxThAMIInuHZVBpCNdnAgqOAxd(long value)
	{
		NgkEqlfARpYpYNgLumApjMmDSHJhb.SetLength(value);
	}

	public override void xEaWPnfzdCnOUoczuyEkOiRfgpXjA(byte[] buffer, int offset, int count)
	{
		NgkEqlfARpYpYNgLumApjMmDSHJhb.Write(buffer, offset, count);
	}

	public int fJlqenbXfahrYgkwnpXdDTXpIEJK(ZipEntry entry)
	{
		if (entry == null)
		{
			throw new ArgumentNullException("entry");
		}
		int num = 0;
		if (((uint)entry.Flags & 8u) != 0)
		{
			lJPoAtXdrFCOCsGHnNwvsEhvMLQc(134695760);
			lJPoAtXdrFCOCsGHnNwvsEhvMLQc((int)entry.Crc);
			num += 8;
			if (entry.LocalHeaderRequiresZip64)
			{
				zrvRjCepzmFfdmryVYArtolNkSHy(entry.CompressedSize);
				zrvRjCepzmFfdmryVYArtolNkSHy(entry.Size);
				return num + 16;
			}
			lJPoAtXdrFCOCsGHnNwvsEhvMLQc((int)entry.CompressedSize);
			lJPoAtXdrFCOCsGHnNwvsEhvMLQc((int)entry.Size);
			return num + 8;
		}
		return num;
	}

	public void EVwkUZBieQSmujkYuEOuEMdWuXmM(long noOfEntries, long sizeEntries, long startOfCentralDirectory, byte[] comment)
	{
		if (noOfEntries >= 65535L || startOfCentralDirectory >= 4294967295L || sizeEntries >= 4294967295L)
		{
			lMycaowDCDvJjvowYgwSFHKJbHAPA(noOfEntries, sizeEntries, startOfCentralDirectory);
		}
		lJPoAtXdrFCOCsGHnNwvsEhvMLQc(101010256);
		NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(0);
		NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(0);
		if (noOfEntries < 65535L)
		{
			NfkIrBJfWhAdtBUKBIQbCGiMHmIPb((short)noOfEntries);
			NfkIrBJfWhAdtBUKBIQbCGiMHmIPb((short)noOfEntries);
		}
		else
		{
			VbcVJHaBgkLmhhXLkDgVYnnXgsXI(ushort.MaxValue);
			VbcVJHaBgkLmhhXLkDgVYnnXgsXI(ushort.MaxValue);
		}
		if (sizeEntries >= 4294967295L)
		{
			LxtgiUATyLxFFbAziYtScNzmdFLBA(uint.MaxValue);
		}
		else
		{
			lJPoAtXdrFCOCsGHnNwvsEhvMLQc((int)sizeEntries);
		}
		if (startOfCentralDirectory >= 4294967295L)
		{
			LxtgiUATyLxFFbAziYtScNzmdFLBA(uint.MaxValue);
		}
		else
		{
			lJPoAtXdrFCOCsGHnNwvsEhvMLQc((int)startOfCentralDirectory);
		}
		int num = ((comment != null) ? comment.Length : 0);
		if (num <= 65535)
		{
			NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(num);
			if (num > 0)
			{
				Write(comment, 0, comment.Length);
			}
			return;
		}
		throw new ZipException($"Comment length({num}) is too long can only be 64K");
	}

	public void lJPoAtXdrFCOCsGHnNwvsEhvMLQc(int value)
	{
		NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(value);
		NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(value >> 16);
	}

	public void zrvRjCepzmFfdmryVYArtolNkSHy(long value)
	{
		lJPoAtXdrFCOCsGHnNwvsEhvMLQc((int)value);
		lJPoAtXdrFCOCsGHnNwvsEhvMLQc((int)(value >> 32));
	}

	public void NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(int value)
	{
		NgkEqlfARpYpYNgLumApjMmDSHJhb.WriteByte((byte)((uint)value & 0xFFu));
		NgkEqlfARpYpYNgLumApjMmDSHJhb.WriteByte((byte)((uint)(value >> 8) & 0xFFu));
	}

	public void LxtgiUATyLxFFbAziYtScNzmdFLBA(uint value)
	{
		VbcVJHaBgkLmhhXLkDgVYnnXgsXI((ushort)(value & 0xFFFFu));
		VbcVJHaBgkLmhhXLkDgVYnnXgsXI((ushort)(value >> 16));
	}

	public void HWfatnBCChKeqehTOxGjBKRyozwO(ulong value)
	{
		LxtgiUATyLxFFbAziYtScNzmdFLBA((uint)(value & 0xFFFFFFFFuL));
		LxtgiUATyLxFFbAziYtScNzmdFLBA((uint)(value >> 32));
	}

	public void VbcVJHaBgkLmhhXLkDgVYnnXgsXI(ushort value)
	{
		NgkEqlfARpYpYNgLumApjMmDSHJhb.WriteByte((byte)(value & 0xFFu));
		NgkEqlfARpYpYNgLumApjMmDSHJhb.WriteByte((byte)(value >> 8));
	}

	private void isJJMTAfoihIwhngdkVTefiFDrjIB(ZipEntry entry, VQqltHkgXjjeLkwyWbapnxQcUaWO patchData)
	{
		CompressionMethod compressionMethod = entry.CompressionMethod;
		bool flag = true;
		bool flag2 = false;
		lJPoAtXdrFCOCsGHnNwvsEhvMLQc(67324752);
		NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(entry.Version);
		NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(entry.Flags);
		NfkIrBJfWhAdtBUKBIQbCGiMHmIPb((byte)compressionMethod);
		lJPoAtXdrFCOCsGHnNwvsEhvMLQc((int)entry.DosTime);
		lJPoAtXdrFCOCsGHnNwvsEhvMLQc((int)entry.Crc);
		if (!entry.LocalHeaderRequiresZip64)
		{
			lJPoAtXdrFCOCsGHnNwvsEhvMLQc((int)(entry.IsCrypted ? ((int)entry.CompressedSize + 12) : entry.CompressedSize));
			lJPoAtXdrFCOCsGHnNwvsEhvMLQc((int)entry.Size);
		}
		else
		{
			lJPoAtXdrFCOCsGHnNwvsEhvMLQc(-1);
			lJPoAtXdrFCOCsGHnNwvsEhvMLQc(-1);
		}
		byte[] array = ZipConstants.ConvertToArray(entry.Flags, entry.Name);
		if (array.Length <= 65535)
		{
			ZipExtraData zipExtraData = new ZipExtraData(entry.ExtraData);
			if (entry.LocalHeaderRequiresZip64 && (flag || flag2))
			{
				zipExtraData.StartNewEntry();
				if (!flag)
				{
					zipExtraData.AddLeLong(-1L);
					zipExtraData.AddLeLong(-1L);
				}
				else
				{
					zipExtraData.AddLeLong(entry.Size);
					zipExtraData.AddLeLong(entry.CompressedSize);
				}
				zipExtraData.AddNewEntry(1);
				if (!zipExtraData.Find(1))
				{
					throw new ZipException("Internal error cant find extra data");
				}
				if (patchData != null)
				{
					patchData.vnLjtACtQCkQLFooYjuTVYxDgGcI = zipExtraData.CurrentReadIndex;
				}
			}
			else
			{
				zipExtraData.Delete(1);
			}
			byte[] entryData = zipExtraData.GetEntryData();
			NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(array.Length);
			NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(entryData.Length);
			if (array.Length != 0)
			{
				NgkEqlfARpYpYNgLumApjMmDSHJhb.Write(array, 0, array.Length);
			}
			if (entry.LocalHeaderRequiresZip64 && flag2)
			{
				patchData.vnLjtACtQCkQLFooYjuTVYxDgGcI += NgkEqlfARpYpYNgLumApjMmDSHJhb.Position;
			}
			if (entryData.Length != 0)
			{
				NgkEqlfARpYpYNgLumApjMmDSHJhb.Write(entryData, 0, entryData.Length);
			}
			return;
		}
		throw new ZipException("Entry name too long.");
	}

	public void lMycaowDCDvJjvowYgwSFHKJbHAPA(long noOfEntries, long sizeEntries, long centralDirOffset)
	{
		long position = NgkEqlfARpYpYNgLumApjMmDSHJhb.Position;
		lJPoAtXdrFCOCsGHnNwvsEhvMLQc(101075792);
		zrvRjCepzmFfdmryVYArtolNkSHy(44L);
		NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(45);
		NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(45);
		lJPoAtXdrFCOCsGHnNwvsEhvMLQc(0);
		lJPoAtXdrFCOCsGHnNwvsEhvMLQc(0);
		zrvRjCepzmFfdmryVYArtolNkSHy(noOfEntries);
		zrvRjCepzmFfdmryVYArtolNkSHy(noOfEntries);
		zrvRjCepzmFfdmryVYArtolNkSHy(sizeEntries);
		zrvRjCepzmFfdmryVYArtolNkSHy(centralDirOffset);
		lJPoAtXdrFCOCsGHnNwvsEhvMLQc(117853008);
		lJPoAtXdrFCOCsGHnNwvsEhvMLQc(0);
		zrvRjCepzmFfdmryVYArtolNkSHy(position);
		lJPoAtXdrFCOCsGHnNwvsEhvMLQc(1);
	}
}
