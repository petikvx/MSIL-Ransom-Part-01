using System;
using System.Collections;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.Zip;

public class ZipOutputStream : DeflaterOutputStream
{
	private ArrayList entries = new ArrayList();

	private Crc32 crc = new Crc32();

	private ZipEntry curEntry;

	private int defaultCompressionLevel = -1;

	private CompressionMethod curMethod = CompressionMethod.Deflated;

	private long size;

	private long offset;

	private byte[] zipComment = new byte[0];

	private bool patchEntryHeader;

	private long crcPatchPos = -1L;

	private long sizePatchPos = -1L;

	private UseZip64 useZip64_ = UseZip64.Dynamic;

	public bool IsFinished => entries == null;

	public UseZip64 UseZip64
	{
		get
		{
			return useZip64_;
		}
		set
		{
			useZip64_ = value;
		}
	}

	public ZipOutputStream(Stream baseOutputStream)
		: base(baseOutputStream, new Deflater(-1, noZlibHeaderOrFooter: true))
	{
	}

	public ZipOutputStream(Stream baseOutputStream, int bufferSize)
		: base(baseOutputStream, new Deflater(-1, noZlibHeaderOrFooter: true), bufferSize)
	{
	}

	public void SetComment(string comment)
	{
		byte[] array = ZipConstants.ConvertToArray(comment);
		if (array.Length > 65535)
		{
			throw new ArgumentOutOfRangeException("comment");
		}
		zipComment = array;
	}

	public void SetLevel(int level)
	{
		deflater_.SetLevel(level);
		defaultCompressionLevel = level;
	}

	public int GetLevel()
	{
		return deflater_.GetLevel();
	}

	private void WriteLeShort(int value)
	{
		baseOutputStream_.WriteByte((byte)((uint)value & 0xFFu));
		baseOutputStream_.WriteByte((byte)((uint)(value >> 8) & 0xFFu));
	}

	private void WriteLeInt(int value)
	{
		WriteLeShort(value);
		WriteLeShort(value >> 16);
	}

	private void WriteLeLong(long value)
	{
		WriteLeInt((int)value);
		WriteLeInt((int)(value >> 32));
	}

	public void PutNextEntry(ZipEntry entry)
	{
		if (entry == null)
		{
			throw new ArgumentNullException("entry");
		}
		if (entries == null)
		{
			throw new InvalidOperationException("ZipOutputStream was finished");
		}
		if (curEntry != null)
		{
			CloseEntry();
		}
		if (entries.Count == int.MaxValue)
		{
			throw new ZipException("Too many entries for Zip file");
		}
		CompressionMethod compressionMethod = entry.CompressionMethod;
		int level = defaultCompressionLevel;
		entry.Flags &= 2048;
		patchEntryHeader = false;
		bool flag;
		if (entry.Size == 0L)
		{
			entry.CompressedSize = entry.Size;
			entry.Crc = 0L;
			compressionMethod = CompressionMethod.Stored;
			flag = true;
		}
		else
		{
			flag = entry.Size >= 0L && entry.HasCrc;
			if (compressionMethod == CompressionMethod.Stored)
			{
				if (!flag)
				{
					if (!base.CanPatchEntries)
					{
						compressionMethod = CompressionMethod.Deflated;
						level = 0;
					}
				}
				else
				{
					entry.CompressedSize = entry.Size;
					flag = entry.HasCrc;
				}
			}
		}
		if (!flag)
		{
			if (!base.CanPatchEntries)
			{
				entry.Flags |= 8;
			}
			else
			{
				patchEntryHeader = true;
			}
		}
		if (base.Password != null)
		{
			entry.IsCrypted = true;
			if (entry.Crc < 0L)
			{
				entry.Flags |= 8;
			}
		}
		entry.Offset = offset;
		entry.CompressionMethod = compressionMethod;
		curMethod = compressionMethod;
		sizePatchPos = -1L;
		if (useZip64_ == UseZip64.On || (entry.Size < 0L && useZip64_ == UseZip64.Dynamic))
		{
			entry.ForceZip64();
		}
		WriteLeInt(67324752);
		WriteLeShort(entry.Version);
		WriteLeShort(entry.Flags);
		WriteLeShort((byte)entry.CompressionMethodForHeader);
		WriteLeInt((int)entry.DosTime);
		if (flag)
		{
			WriteLeInt((int)entry.Crc);
			if (entry.LocalHeaderRequiresZip64)
			{
				WriteLeInt(-1);
				WriteLeInt(-1);
			}
			else
			{
				WriteLeInt((int)(entry.IsCrypted ? ((int)entry.CompressedSize + 12) : entry.CompressedSize));
				WriteLeInt((int)entry.Size);
			}
		}
		else
		{
			if (patchEntryHeader)
			{
				crcPatchPos = baseOutputStream_.Position;
			}
			WriteLeInt(0);
			if (patchEntryHeader)
			{
				sizePatchPos = baseOutputStream_.Position;
			}
			if (!entry.LocalHeaderRequiresZip64 && !patchEntryHeader)
			{
				WriteLeInt(0);
				WriteLeInt(0);
			}
			else
			{
				WriteLeInt(-1);
				WriteLeInt(-1);
			}
		}
		byte[] array = ZipConstants.ConvertToArray(entry.Flags, entry.Name);
		if (array.Length > 65535)
		{
			throw new ZipException("Entry name too long.");
		}
		ZipExtraData zipExtraData = new ZipExtraData(entry.ExtraData);
		if (entry.LocalHeaderRequiresZip64)
		{
			zipExtraData.StartNewEntry();
			if (flag)
			{
				zipExtraData.AddLeLong(entry.Size);
				zipExtraData.AddLeLong(entry.CompressedSize);
			}
			else
			{
				zipExtraData.AddLeLong(-1L);
				zipExtraData.AddLeLong(-1L);
			}
			zipExtraData.AddNewEntry(1);
			if (!zipExtraData.Find(1))
			{
				throw new ZipException("Internal error cant find extra data");
			}
			if (patchEntryHeader)
			{
				sizePatchPos = zipExtraData.CurrentReadIndex;
			}
		}
		else
		{
			zipExtraData.Delete(1);
		}
		if (entry.AESKeySize > 0)
		{
			AddExtraDataAES(entry, zipExtraData);
		}
		byte[] entryData = zipExtraData.GetEntryData();
		WriteLeShort(array.Length);
		WriteLeShort(entryData.Length);
		if (array.Length > 0)
		{
			baseOutputStream_.Write(array, 0, array.Length);
		}
		if (entry.LocalHeaderRequiresZip64 && patchEntryHeader)
		{
			sizePatchPos += baseOutputStream_.Position;
		}
		if (entryData.Length > 0)
		{
			baseOutputStream_.Write(entryData, 0, entryData.Length);
		}
		offset += 30 + array.Length + entryData.Length;
		if (entry.AESKeySize > 0)
		{
			offset += entry.AESOverheadSize;
		}
		curEntry = entry;
		crc.Reset();
		if (compressionMethod == CompressionMethod.Deflated)
		{
			deflater_.Reset();
			deflater_.SetLevel(level);
		}
		size = 0L;
		if (entry.IsCrypted)
		{
			if (entry.AESKeySize > 0)
			{
				WriteAESHeader(entry);
			}
			else if (entry.Crc < 0L)
			{
				WriteEncryptionHeader(entry.DosTime << 16);
			}
			else
			{
				WriteEncryptionHeader(entry.Crc);
			}
		}
	}

	public void CloseEntry()
	{
		if (curEntry == null)
		{
			throw new InvalidOperationException("No open entry");
		}
		long totalOut = size;
		if (curMethod == CompressionMethod.Deflated)
		{
			if (size >= 0L)
			{
				base.Finish();
				totalOut = deflater_.TotalOut;
			}
			else
			{
				deflater_.Reset();
			}
		}
		if (curEntry.AESKeySize > 0)
		{
			baseOutputStream_.Write(AESAuthCode, 0, 10);
		}
		if (curEntry.Size < 0L)
		{
			curEntry.Size = size;
		}
		else if (curEntry.Size != size)
		{
			throw new ZipException("size was " + size + ", but I expected " + curEntry.Size);
		}
		if (curEntry.CompressedSize < 0L)
		{
			curEntry.CompressedSize = totalOut;
		}
		else if (curEntry.CompressedSize != totalOut)
		{
			throw new ZipException("compressed size was " + totalOut + ", but I expected " + curEntry.CompressedSize);
		}
		if (curEntry.Crc < 0L)
		{
			curEntry.Crc = crc.Value;
		}
		else if (curEntry.Crc != crc.Value)
		{
			throw new ZipException("crc was " + crc.Value + ", but I expected " + curEntry.Crc);
		}
		offset += totalOut;
		if (curEntry.IsCrypted)
		{
			if (curEntry.AESKeySize > 0)
			{
				curEntry.CompressedSize += curEntry.AESOverheadSize;
			}
			else
			{
				curEntry.CompressedSize += 12L;
			}
		}
		if (patchEntryHeader)
		{
			patchEntryHeader = false;
			long position = baseOutputStream_.Position;
			baseOutputStream_.Seek(crcPatchPos, SeekOrigin.Begin);
			WriteLeInt((int)curEntry.Crc);
			if (curEntry.LocalHeaderRequiresZip64)
			{
				if (sizePatchPos == -1L)
				{
					throw new ZipException("Entry requires zip64 but this has been turned off");
				}
				baseOutputStream_.Seek(sizePatchPos, SeekOrigin.Begin);
				WriteLeLong(curEntry.Size);
				WriteLeLong(curEntry.CompressedSize);
			}
			else
			{
				WriteLeInt((int)curEntry.CompressedSize);
				WriteLeInt((int)curEntry.Size);
			}
			baseOutputStream_.Seek(position, SeekOrigin.Begin);
		}
		if (((uint)curEntry.Flags & 8u) != 0)
		{
			WriteLeInt(134695760);
			WriteLeInt((int)curEntry.Crc);
			if (curEntry.LocalHeaderRequiresZip64)
			{
				WriteLeLong(curEntry.CompressedSize);
				WriteLeLong(curEntry.Size);
				offset += 24L;
			}
			else
			{
				WriteLeInt((int)curEntry.CompressedSize);
				WriteLeInt((int)curEntry.Size);
				offset += 16L;
			}
		}
		entries.Add(curEntry);
		curEntry = null;
	}

	private void WriteEncryptionHeader(long crcValue)
	{
		offset += 12L;
		InitializePassword(base.Password);
		byte[] array = new byte[12];
		Random random = new Random();
		random.NextBytes(array);
		array[11] = (byte)(crcValue >> 24);
		EncryptBlock(array, 0, array.Length);
		baseOutputStream_.Write(array, 0, array.Length);
	}

	private static void AddExtraDataAES(ZipEntry entry, ZipExtraData extraData)
	{
		extraData.StartNewEntry();
		extraData.AddLeShort(2);
		extraData.AddLeShort(17729);
		extraData.AddData(entry.AESEncryptionStrength);
		extraData.AddLeShort((int)entry.CompressionMethod);
		extraData.AddNewEntry(39169);
	}

	private void WriteAESHeader(ZipEntry entry)
	{
		InitializeAESPassword(entry, base.Password, out var salt, out var pwdVerifier);
		baseOutputStream_.Write(salt, 0, salt.Length);
		baseOutputStream_.Write(pwdVerifier, 0, pwdVerifier.Length);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (curEntry == null)
		{
			throw new InvalidOperationException("No open entry.");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", "Cannot be negative");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", "Cannot be negative");
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException("Invalid offset/count combination");
		}
		crc.Update(buffer, offset, count);
		size += count;
		switch (curMethod)
		{
		case CompressionMethod.Deflated:
			base.Write(buffer, offset, count);
			break;
		case CompressionMethod.Stored:
			if (base.Password != null)
			{
				CopyAndEncrypt(buffer, offset, count);
			}
			else
			{
				baseOutputStream_.Write(buffer, offset, count);
			}
			break;
		}
	}

	private void CopyAndEncrypt(byte[] buffer, int offset, int count)
	{
		byte[] array = new byte[4096];
		while (count > 0)
		{
			int num = ((count < 4096) ? count : 4096);
			Array.Copy(buffer, offset, array, 0, num);
			EncryptBlock(array, 0, num);
			baseOutputStream_.Write(array, 0, num);
			count -= num;
			offset += num;
		}
	}

	public override void Finish()
	{
		if (entries == null)
		{
			return;
		}
		if (curEntry != null)
		{
			CloseEntry();
		}
		long noOfEntries = entries.Count;
		long num = 0L;
		foreach (ZipEntry entry in entries)
		{
			WriteLeInt(33639248);
			WriteLeShort(51);
			WriteLeShort(entry.Version);
			WriteLeShort(entry.Flags);
			WriteLeShort((short)entry.CompressionMethodForHeader);
			WriteLeInt((int)entry.DosTime);
			WriteLeInt((int)entry.Crc);
			if (!entry.IsZip64Forced() && entry.CompressedSize < 4294967295L)
			{
				WriteLeInt((int)entry.CompressedSize);
			}
			else
			{
				WriteLeInt(-1);
			}
			if (!entry.IsZip64Forced() && entry.Size < 4294967295L)
			{
				WriteLeInt((int)entry.Size);
			}
			else
			{
				WriteLeInt(-1);
			}
			byte[] array = ZipConstants.ConvertToArray(entry.Flags, entry.Name);
			if (array.Length <= 65535)
			{
				ZipExtraData zipExtraData = new ZipExtraData(entry.ExtraData);
				if (entry.CentralHeaderRequiresZip64)
				{
					zipExtraData.StartNewEntry();
					if (entry.IsZip64Forced() || entry.Size >= 4294967295L)
					{
						zipExtraData.AddLeLong(entry.Size);
					}
					if (entry.IsZip64Forced() || entry.CompressedSize >= 4294967295L)
					{
						zipExtraData.AddLeLong(entry.CompressedSize);
					}
					if (entry.Offset >= 4294967295L)
					{
						zipExtraData.AddLeLong(entry.Offset);
					}
					zipExtraData.AddNewEntry(1);
				}
				else
				{
					zipExtraData.Delete(1);
				}
				if (entry.AESKeySize > 0)
				{
					AddExtraDataAES(entry, zipExtraData);
				}
				byte[] entryData = zipExtraData.GetEntryData();
				byte[] array2 = ((entry.Comment != null) ? ZipConstants.ConvertToArray(entry.Flags, entry.Comment) : new byte[0]);
				if (array2.Length <= 65535)
				{
					WriteLeShort(array.Length);
					WriteLeShort(entryData.Length);
					WriteLeShort(array2.Length);
					WriteLeShort(0);
					WriteLeShort(0);
					if (entry.ExternalFileAttributes != -1)
					{
						WriteLeInt(entry.ExternalFileAttributes);
					}
					else if (entry.IsDirectory)
					{
						WriteLeInt(16);
					}
					else
					{
						WriteLeInt(0);
					}
					if (entry.Offset >= 4294967295L)
					{
						WriteLeInt(-1);
					}
					else
					{
						WriteLeInt((int)entry.Offset);
					}
					if (array.Length > 0)
					{
						baseOutputStream_.Write(array, 0, array.Length);
					}
					if (entryData.Length > 0)
					{
						baseOutputStream_.Write(entryData, 0, entryData.Length);
					}
					if (array2.Length > 0)
					{
						baseOutputStream_.Write(array2, 0, array2.Length);
					}
					num += 46 + array.Length + entryData.Length + array2.Length;
					continue;
				}
				throw new ZipException("Comment too long.");
			}
			throw new ZipException("Name too long.");
		}
		using (ZipHelperStream zipHelperStream = new ZipHelperStream(baseOutputStream_))
		{
			zipHelperStream.WriteEndOfCentralDirectory(noOfEntries, num, offset, zipComment);
		}
		entries = null;
	}
}
