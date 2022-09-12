using System;
using System.Collections;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.Zip;

public class ZipOutputStream : DeflaterOutputStream
{
	private Crc32 XggeanKkgjbXaSerhmRXCjwfRXMZA;

	private long dECsXUXJiEQxqapbtRcsGzMLSBOi;

	private ZipEntry LEfEUReiHVFpJQIomSqhwdeXCDqPA;

	private CompressionMethod LHIQlfLLOifrzTuPUkOBpvCRnEih;

	private int onBdAinrKzHUZIsWRHSBqXerLOzs;

	private ArrayList XSpnPswKsSTWTIaZZQfdueeoFuVK;

	private long tgJiTAKRvcmDbAhYbCUlPocYXOqH;

	private bool OBWatufkFQDMWPkHEhJEGSnlQsbV;

	private long nNIdigjNWtldYPhvYFfhBELJWnvSb;

	private long rbSYETqUBGzBtuUfIMXsurcKCnnJ;

	private UseZip64 bKsRPzWeosiiVJMdrYkiLDpYbLKcA;

	private byte[] mJzUGhxDGJSzGkpGYCklthmSMjvM;

	public bool IsFinished => XSpnPswKsSTWTIaZZQfdueeoFuVK == null;

	public UseZip64 UseZip64
	{
		get
		{
			return bKsRPzWeosiiVJMdrYkiLDpYbLKcA;
		}
		set
		{
			bKsRPzWeosiiVJMdrYkiLDpYbLKcA = value;
		}
	}

	public ZipOutputStream(Stream baseOutputStream)
		: base(baseOutputStream, new Deflater(-1, noZlibHeaderOrFooter: true))
	{
		XSpnPswKsSTWTIaZZQfdueeoFuVK = new ArrayList();
		XggeanKkgjbXaSerhmRXCjwfRXMZA = new Crc32();
		onBdAinrKzHUZIsWRHSBqXerLOzs = -1;
		LHIQlfLLOifrzTuPUkOBpvCRnEih = CompressionMethod.Deflated;
		mJzUGhxDGJSzGkpGYCklthmSMjvM = new byte[0];
		dECsXUXJiEQxqapbtRcsGzMLSBOi = -1L;
		rbSYETqUBGzBtuUfIMXsurcKCnnJ = -1L;
		bKsRPzWeosiiVJMdrYkiLDpYbLKcA = UseZip64.Dynamic;
	}

	public void CloseEntry()
	{
		if (LEfEUReiHVFpJQIomSqhwdeXCDqPA == null)
		{
			throw new InvalidOperationException("No open entry");
		}
		long totalOut = nNIdigjNWtldYPhvYFfhBELJWnvSb;
		if (LHIQlfLLOifrzTuPUkOBpvCRnEih == CompressionMethod.Deflated)
		{
			if (nNIdigjNWtldYPhvYFfhBELJWnvSb <= 0L)
			{
				deflater_.Reset();
			}
			else
			{
				base.Finish();
				totalOut = deflater_.TotalOut;
			}
		}
		if (LEfEUReiHVFpJQIomSqhwdeXCDqPA.Size >= 0L)
		{
			if (LEfEUReiHVFpJQIomSqhwdeXCDqPA.Size != nNIdigjNWtldYPhvYFfhBELJWnvSb)
			{
				throw new ZipException("size was " + nNIdigjNWtldYPhvYFfhBELJWnvSb + ", but I expected " + LEfEUReiHVFpJQIomSqhwdeXCDqPA.Size);
			}
		}
		else
		{
			LEfEUReiHVFpJQIomSqhwdeXCDqPA.Size = nNIdigjNWtldYPhvYFfhBELJWnvSb;
		}
		if (LEfEUReiHVFpJQIomSqhwdeXCDqPA.CompressedSize < 0L)
		{
			LEfEUReiHVFpJQIomSqhwdeXCDqPA.CompressedSize = totalOut;
		}
		else if (LEfEUReiHVFpJQIomSqhwdeXCDqPA.CompressedSize != totalOut)
		{
			throw new ZipException("compressed size was " + totalOut + ", but I expected " + LEfEUReiHVFpJQIomSqhwdeXCDqPA.CompressedSize);
		}
		if (LEfEUReiHVFpJQIomSqhwdeXCDqPA.Crc >= 0L)
		{
			if (LEfEUReiHVFpJQIomSqhwdeXCDqPA.Crc != XggeanKkgjbXaSerhmRXCjwfRXMZA.Value)
			{
				throw new ZipException("crc was " + XggeanKkgjbXaSerhmRXCjwfRXMZA.Value + ", but I expected " + LEfEUReiHVFpJQIomSqhwdeXCDqPA.Crc);
			}
		}
		else
		{
			LEfEUReiHVFpJQIomSqhwdeXCDqPA.Crc = XggeanKkgjbXaSerhmRXCjwfRXMZA.Value;
		}
		tgJiTAKRvcmDbAhYbCUlPocYXOqH += totalOut;
		if (LEfEUReiHVFpJQIomSqhwdeXCDqPA.IsCrypted)
		{
			LEfEUReiHVFpJQIomSqhwdeXCDqPA.CompressedSize += 12L;
		}
		if (OBWatufkFQDMWPkHEhJEGSnlQsbV)
		{
			OBWatufkFQDMWPkHEhJEGSnlQsbV = false;
			long position = baseOutputStream_.Position;
			baseOutputStream_.Seek(dECsXUXJiEQxqapbtRcsGzMLSBOi, SeekOrigin.Begin);
			wktvIyDZeWgPNuWOdcHlwvTarQQh((int)LEfEUReiHVFpJQIomSqhwdeXCDqPA.Crc);
			if (!LEfEUReiHVFpJQIomSqhwdeXCDqPA.LocalHeaderRequiresZip64)
			{
				wktvIyDZeWgPNuWOdcHlwvTarQQh((int)LEfEUReiHVFpJQIomSqhwdeXCDqPA.CompressedSize);
				wktvIyDZeWgPNuWOdcHlwvTarQQh((int)LEfEUReiHVFpJQIomSqhwdeXCDqPA.Size);
			}
			else
			{
				if (rbSYETqUBGzBtuUfIMXsurcKCnnJ == -1L)
				{
					throw new ZipException("Entry requires zip64 but this has been turned off");
				}
				baseOutputStream_.Seek(rbSYETqUBGzBtuUfIMXsurcKCnnJ, SeekOrigin.Begin);
				OyynbzvBPJeXFNnanDZTiCPtrfILA(LEfEUReiHVFpJQIomSqhwdeXCDqPA.Size);
				OyynbzvBPJeXFNnanDZTiCPtrfILA(LEfEUReiHVFpJQIomSqhwdeXCDqPA.CompressedSize);
			}
			baseOutputStream_.Seek(position, SeekOrigin.Begin);
		}
		if (((uint)LEfEUReiHVFpJQIomSqhwdeXCDqPA.Flags & 8u) != 0)
		{
			wktvIyDZeWgPNuWOdcHlwvTarQQh(134695760);
			wktvIyDZeWgPNuWOdcHlwvTarQQh((int)LEfEUReiHVFpJQIomSqhwdeXCDqPA.Crc);
			if (LEfEUReiHVFpJQIomSqhwdeXCDqPA.LocalHeaderRequiresZip64)
			{
				OyynbzvBPJeXFNnanDZTiCPtrfILA(LEfEUReiHVFpJQIomSqhwdeXCDqPA.CompressedSize);
				OyynbzvBPJeXFNnanDZTiCPtrfILA(LEfEUReiHVFpJQIomSqhwdeXCDqPA.Size);
				tgJiTAKRvcmDbAhYbCUlPocYXOqH += 24L;
			}
			else
			{
				wktvIyDZeWgPNuWOdcHlwvTarQQh((int)LEfEUReiHVFpJQIomSqhwdeXCDqPA.CompressedSize);
				wktvIyDZeWgPNuWOdcHlwvTarQQh((int)LEfEUReiHVFpJQIomSqhwdeXCDqPA.Size);
				tgJiTAKRvcmDbAhYbCUlPocYXOqH += 16L;
			}
		}
		XSpnPswKsSTWTIaZZQfdueeoFuVK.Add(LEfEUReiHVFpJQIomSqhwdeXCDqPA);
		LEfEUReiHVFpJQIomSqhwdeXCDqPA = null;
	}

	private void eFXFMLxiYtPDXiwqLjoGOuGxtqmj(byte[] buffer, int offset, int count)
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
		if (XSpnPswKsSTWTIaZZQfdueeoFuVK == null)
		{
			return;
		}
		if (LEfEUReiHVFpJQIomSqhwdeXCDqPA != null)
		{
			CloseEntry();
		}
		long noOfEntries = XSpnPswKsSTWTIaZZQfdueeoFuVK.Count;
		long num = 0L;
		foreach (ZipEntry item in XSpnPswKsSTWTIaZZQfdueeoFuVK)
		{
			wktvIyDZeWgPNuWOdcHlwvTarQQh(33639248);
			zPbThDVXeeWgGrvGmbRzHdcQVoTK(45);
			zPbThDVXeeWgGrvGmbRzHdcQVoTK(item.Version);
			zPbThDVXeeWgGrvGmbRzHdcQVoTK(item.Flags);
			zPbThDVXeeWgGrvGmbRzHdcQVoTK((short)item.CompressionMethod);
			wktvIyDZeWgPNuWOdcHlwvTarQQh((int)item.DosTime);
			wktvIyDZeWgPNuWOdcHlwvTarQQh((int)item.Crc);
			if (!item.IsZip64Forced() && item.CompressedSize < 4294967295L)
			{
				wktvIyDZeWgPNuWOdcHlwvTarQQh((int)item.CompressedSize);
			}
			else
			{
				wktvIyDZeWgPNuWOdcHlwvTarQQh(-1);
			}
			if (item.IsZip64Forced() || item.Size >= 4294967295L)
			{
				wktvIyDZeWgPNuWOdcHlwvTarQQh(-1);
			}
			else
			{
				wktvIyDZeWgPNuWOdcHlwvTarQQh((int)item.Size);
			}
			byte[] array = ZipConstants.ConvertToArray(item.Flags, item.Name);
			if (array.Length <= 65535)
			{
				ZipExtraData zipExtraData = new ZipExtraData(item.ExtraData);
				if (!item.CentralHeaderRequiresZip64)
				{
					zipExtraData.Delete(1);
				}
				else
				{
					zipExtraData.StartNewEntry();
					if (item.IsZip64Forced() || item.Size >= 4294967295L)
					{
						zipExtraData.AddLeLong(item.Size);
					}
					if (item.IsZip64Forced() || item.CompressedSize >= 4294967295L)
					{
						zipExtraData.AddLeLong(item.CompressedSize);
					}
					if (item.Offset >= 4294967295L)
					{
						zipExtraData.AddLeLong(item.Offset);
					}
					zipExtraData.AddNewEntry(1);
				}
				byte[] entryData = zipExtraData.GetEntryData();
				byte[] array2 = ((item.Comment != null) ? ZipConstants.ConvertToArray(item.Flags, item.Comment) : new byte[0]);
				if (array2.Length <= 65535)
				{
					zPbThDVXeeWgGrvGmbRzHdcQVoTK(array.Length);
					zPbThDVXeeWgGrvGmbRzHdcQVoTK(entryData.Length);
					zPbThDVXeeWgGrvGmbRzHdcQVoTK(array2.Length);
					zPbThDVXeeWgGrvGmbRzHdcQVoTK(0);
					zPbThDVXeeWgGrvGmbRzHdcQVoTK(0);
					if (item.ExternalFileAttributes == -1)
					{
						if (!item.IsDirectory)
						{
							wktvIyDZeWgPNuWOdcHlwvTarQQh(0);
						}
						else
						{
							wktvIyDZeWgPNuWOdcHlwvTarQQh(16);
						}
					}
					else
					{
						wktvIyDZeWgPNuWOdcHlwvTarQQh(item.ExternalFileAttributes);
					}
					if (item.Offset >= 4294967295L)
					{
						wktvIyDZeWgPNuWOdcHlwvTarQQh(-1);
					}
					else
					{
						wktvIyDZeWgPNuWOdcHlwvTarQQh((int)item.Offset);
					}
					if (array.Length != 0)
					{
						baseOutputStream_.Write(array, 0, array.Length);
					}
					if (entryData.Length != 0)
					{
						baseOutputStream_.Write(entryData, 0, entryData.Length);
					}
					if (array2.Length != 0)
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
		using (LocxVjlCNZghquSrgFvmkfSoMwVu locxVjlCNZghquSrgFvmkfSoMwVu = new LocxVjlCNZghquSrgFvmkfSoMwVu(baseOutputStream_))
		{
			locxVjlCNZghquSrgFvmkfSoMwVu.VKkbsirOafYYaSurlqVFagoVDczz(noOfEntries, num, tgJiTAKRvcmDbAhYbCUlPocYXOqH, mJzUGhxDGJSzGkpGYCklthmSMjvM);
		}
		XSpnPswKsSTWTIaZZQfdueeoFuVK = null;
	}

	public int GetLevel()
	{
		return deflater_.GetLevel();
	}

	public void PutNextEntry(ZipEntry entry)
	{
		if (entry == null)
		{
			throw new ArgumentNullException("entry");
		}
		if (XSpnPswKsSTWTIaZZQfdueeoFuVK != null)
		{
			if (LEfEUReiHVFpJQIomSqhwdeXCDqPA != null)
			{
				CloseEntry();
			}
			if (XSpnPswKsSTWTIaZZQfdueeoFuVK.Count != int.MaxValue)
			{
				CompressionMethod compressionMethod = entry.CompressionMethod;
				int level = onBdAinrKzHUZIsWRHSBqXerLOzs;
				entry.Flags &= 2048;
				OBWatufkFQDMWPkHEhJEGSnlQsbV = false;
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
					if (base.CanPatchEntries)
					{
						OBWatufkFQDMWPkHEhJEGSnlQsbV = true;
					}
					else
					{
						entry.Flags |= 8;
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
				entry.Offset = tgJiTAKRvcmDbAhYbCUlPocYXOqH;
				entry.CompressionMethod = compressionMethod;
				LHIQlfLLOifrzTuPUkOBpvCRnEih = compressionMethod;
				rbSYETqUBGzBtuUfIMXsurcKCnnJ = -1L;
				if (bKsRPzWeosiiVJMdrYkiLDpYbLKcA == UseZip64.On || (entry.Size < 0L && bKsRPzWeosiiVJMdrYkiLDpYbLKcA == UseZip64.Dynamic))
				{
					entry.ForceZip64();
				}
				wktvIyDZeWgPNuWOdcHlwvTarQQh(67324752);
				zPbThDVXeeWgGrvGmbRzHdcQVoTK(entry.Version);
				zPbThDVXeeWgGrvGmbRzHdcQVoTK(entry.Flags);
				zPbThDVXeeWgGrvGmbRzHdcQVoTK((byte)compressionMethod);
				wktvIyDZeWgPNuWOdcHlwvTarQQh((int)entry.DosTime);
				if (flag)
				{
					wktvIyDZeWgPNuWOdcHlwvTarQQh((int)entry.Crc);
					if (!entry.LocalHeaderRequiresZip64)
					{
						wktvIyDZeWgPNuWOdcHlwvTarQQh((int)(entry.IsCrypted ? ((int)entry.CompressedSize + 12) : entry.CompressedSize));
						wktvIyDZeWgPNuWOdcHlwvTarQQh((int)entry.Size);
					}
					else
					{
						wktvIyDZeWgPNuWOdcHlwvTarQQh(-1);
						wktvIyDZeWgPNuWOdcHlwvTarQQh(-1);
					}
				}
				else
				{
					if (OBWatufkFQDMWPkHEhJEGSnlQsbV)
					{
						dECsXUXJiEQxqapbtRcsGzMLSBOi = baseOutputStream_.Position;
					}
					wktvIyDZeWgPNuWOdcHlwvTarQQh(0);
					if (OBWatufkFQDMWPkHEhJEGSnlQsbV)
					{
						rbSYETqUBGzBtuUfIMXsurcKCnnJ = baseOutputStream_.Position;
					}
					if (entry.LocalHeaderRequiresZip64 || OBWatufkFQDMWPkHEhJEGSnlQsbV)
					{
						wktvIyDZeWgPNuWOdcHlwvTarQQh(-1);
						wktvIyDZeWgPNuWOdcHlwvTarQQh(-1);
					}
					else
					{
						wktvIyDZeWgPNuWOdcHlwvTarQQh(0);
						wktvIyDZeWgPNuWOdcHlwvTarQQh(0);
					}
				}
				byte[] array = ZipConstants.ConvertToArray(entry.Flags, entry.Name);
				if (array.Length > 65535)
				{
					throw new ZipException("Entry name too long.");
				}
				ZipExtraData zipExtraData = new ZipExtraData(entry.ExtraData);
				if (!entry.LocalHeaderRequiresZip64)
				{
					zipExtraData.Delete(1);
				}
				else
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
					if (OBWatufkFQDMWPkHEhJEGSnlQsbV)
					{
						rbSYETqUBGzBtuUfIMXsurcKCnnJ = zipExtraData.CurrentReadIndex;
					}
				}
				byte[] entryData = zipExtraData.GetEntryData();
				zPbThDVXeeWgGrvGmbRzHdcQVoTK(array.Length);
				zPbThDVXeeWgGrvGmbRzHdcQVoTK(entryData.Length);
				if (array.Length != 0)
				{
					baseOutputStream_.Write(array, 0, array.Length);
				}
				if (entry.LocalHeaderRequiresZip64 && OBWatufkFQDMWPkHEhJEGSnlQsbV)
				{
					rbSYETqUBGzBtuUfIMXsurcKCnnJ += baseOutputStream_.Position;
				}
				if (entryData.Length != 0)
				{
					baseOutputStream_.Write(entryData, 0, entryData.Length);
				}
				tgJiTAKRvcmDbAhYbCUlPocYXOqH += 30 + array.Length + entryData.Length;
				LEfEUReiHVFpJQIomSqhwdeXCDqPA = entry;
				XggeanKkgjbXaSerhmRXCjwfRXMZA.Reset();
				if (compressionMethod == CompressionMethod.Deflated)
				{
					deflater_.Reset();
					deflater_.SetLevel(level);
				}
				nNIdigjNWtldYPhvYFfhBELJWnvSb = 0L;
				if (entry.IsCrypted)
				{
					if (entry.Crc >= 0L)
					{
						xgvnKozApQrIHZJdRCBCdgEUHxRs(entry.Crc);
					}
					else
					{
						xgvnKozApQrIHZJdRCBCdgEUHxRs(entry.DosTime << 16);
					}
				}
				return;
			}
			throw new ZipException("Too many entries for Zip file");
		}
		throw new InvalidOperationException("ZipOutputStream was finished");
	}

	public void SetComment(string comment)
	{
		byte[] array = ZipConstants.ConvertToArray(comment);
		if (array.Length > 65535)
		{
			throw new ArgumentOutOfRangeException("comment");
		}
		mJzUGhxDGJSzGkpGYCklthmSMjvM = array;
	}

	public void SetLevel(int level)
	{
		deflater_.SetLevel(level);
		onBdAinrKzHUZIsWRHSBqXerLOzs = level;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (LEfEUReiHVFpJQIomSqhwdeXCDqPA == null)
		{
			throw new InvalidOperationException("No open entry.");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset >= 0)
		{
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Cannot be negative");
			}
			if (buffer.Length - offset >= count)
			{
				XggeanKkgjbXaSerhmRXCjwfRXMZA.Update(buffer, offset, count);
				nNIdigjNWtldYPhvYFfhBELJWnvSb += count;
				switch (LHIQlfLLOifrzTuPUkOBpvCRnEih)
				{
				case CompressionMethod.Stored:
					if (base.Password != null)
					{
						eFXFMLxiYtPDXiwqLjoGOuGxtqmj(buffer, offset, count);
					}
					else
					{
						baseOutputStream_.Write(buffer, offset, count);
					}
					break;
				case CompressionMethod.Deflated:
					base.Write(buffer, offset, count);
					break;
				}
				return;
			}
			throw new ArgumentException("Invalid offset/count combination");
		}
		throw new ArgumentOutOfRangeException("offset", "Cannot be negative");
	}

	private void xgvnKozApQrIHZJdRCBCdgEUHxRs(long crcValue)
	{
		tgJiTAKRvcmDbAhYbCUlPocYXOqH += 12L;
		InitializePassword(base.Password);
		byte[] array = new byte[12];
		new Random().NextBytes(array);
		array[11] = (byte)(crcValue >> 24);
		EncryptBlock(array, 0, array.Length);
		baseOutputStream_.Write(array, 0, array.Length);
	}

	private void wktvIyDZeWgPNuWOdcHlwvTarQQh(int value)
	{
		zPbThDVXeeWgGrvGmbRzHdcQVoTK(value);
		zPbThDVXeeWgGrvGmbRzHdcQVoTK(value >> 16);
	}

	private void OyynbzvBPJeXFNnanDZTiCPtrfILA(long value)
	{
		wktvIyDZeWgPNuWOdcHlwvTarQQh((int)value);
		wktvIyDZeWgPNuWOdcHlwvTarQQh((int)(value >> 32));
	}

	private void zPbThDVXeeWgGrvGmbRzHdcQVoTK(int value)
	{
		baseOutputStream_.WriteByte((byte)((uint)value & 0xFFu));
		baseOutputStream_.WriteByte((byte)((uint)(value >> 8) & 0xFFu));
	}
}
