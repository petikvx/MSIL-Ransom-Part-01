using System;
using System.Collections;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.Zip;

public class ZipOutputStream : DeflaterOutputStream
{
	private Crc32 SkeCOrQuISdaMVSOmQcRThNecFnb;

	private long exSOEntrerAeuJZQcQCZsOVQPlJp;

	private ZipEntry CJdgihQFVgTPtxDjjzQLZxYOuxLB;

	private CompressionMethod GVWugEjDZDjZfkAFZavaDwkYOWrN;

	private int hyDIyTRUIMkxRnXjSFFuWEtgrUkm;

	private ArrayList KGpfWNQIqpniJfTwGTOSUJtnskIf;

	private long oaNXCfsQFPpQxhohoJJQdDfBPubx;

	private bool ZmKhHHDhZvTyGypiXRCvuYiygTey;

	private long gOPGBDvMAQDMSIGaZoAfsWDPWdme;

	private long sTURsmGSXnFKtVgWBFJDILhLbrwU;

	private UseZip64 svuDrGoXqHoWNqaKclrVfIkLByFbA;

	private byte[] zVxkSCNETwPfQJvGXbNINrPXMqid;

	public bool IsFinished => KGpfWNQIqpniJfTwGTOSUJtnskIf == null;

	public UseZip64 UseZip64
	{
		get
		{
			return svuDrGoXqHoWNqaKclrVfIkLByFbA;
		}
		set
		{
			svuDrGoXqHoWNqaKclrVfIkLByFbA = value;
		}
	}

	public ZipOutputStream(Stream baseOutputStream)
		: base(baseOutputStream, new Deflater(-1, noZlibHeaderOrFooter: true))
	{
		KGpfWNQIqpniJfTwGTOSUJtnskIf = new ArrayList();
		SkeCOrQuISdaMVSOmQcRThNecFnb = new Crc32();
		hyDIyTRUIMkxRnXjSFFuWEtgrUkm = -1;
		GVWugEjDZDjZfkAFZavaDwkYOWrN = CompressionMethod.Deflated;
		zVxkSCNETwPfQJvGXbNINrPXMqid = new byte[0];
		exSOEntrerAeuJZQcQCZsOVQPlJp = -1L;
		sTURsmGSXnFKtVgWBFJDILhLbrwU = -1L;
		svuDrGoXqHoWNqaKclrVfIkLByFbA = UseZip64.Dynamic;
	}

	public void CloseEntry()
	{
		if (CJdgihQFVgTPtxDjjzQLZxYOuxLB == null)
		{
			throw new InvalidOperationException("No open entry");
		}
		long totalOut = gOPGBDvMAQDMSIGaZoAfsWDPWdme;
		if (GVWugEjDZDjZfkAFZavaDwkYOWrN == CompressionMethod.Deflated)
		{
			if (gOPGBDvMAQDMSIGaZoAfsWDPWdme > 0L)
			{
				base.Finish();
				totalOut = deflater_.TotalOut;
			}
			else
			{
				deflater_.Reset();
			}
		}
		if (CJdgihQFVgTPtxDjjzQLZxYOuxLB.Size >= 0L)
		{
			if (CJdgihQFVgTPtxDjjzQLZxYOuxLB.Size != gOPGBDvMAQDMSIGaZoAfsWDPWdme)
			{
				throw new ZipException("size was " + gOPGBDvMAQDMSIGaZoAfsWDPWdme + ", but I expected " + CJdgihQFVgTPtxDjjzQLZxYOuxLB.Size);
			}
		}
		else
		{
			CJdgihQFVgTPtxDjjzQLZxYOuxLB.Size = gOPGBDvMAQDMSIGaZoAfsWDPWdme;
		}
		if (CJdgihQFVgTPtxDjjzQLZxYOuxLB.CompressedSize < 0L)
		{
			CJdgihQFVgTPtxDjjzQLZxYOuxLB.CompressedSize = totalOut;
		}
		else if (CJdgihQFVgTPtxDjjzQLZxYOuxLB.CompressedSize != totalOut)
		{
			throw new ZipException("compressed size was " + totalOut + ", but I expected " + CJdgihQFVgTPtxDjjzQLZxYOuxLB.CompressedSize);
		}
		if (CJdgihQFVgTPtxDjjzQLZxYOuxLB.Crc < 0L)
		{
			CJdgihQFVgTPtxDjjzQLZxYOuxLB.Crc = SkeCOrQuISdaMVSOmQcRThNecFnb.Value;
		}
		else if (CJdgihQFVgTPtxDjjzQLZxYOuxLB.Crc != SkeCOrQuISdaMVSOmQcRThNecFnb.Value)
		{
			throw new ZipException("crc was " + SkeCOrQuISdaMVSOmQcRThNecFnb.Value + ", but I expected " + CJdgihQFVgTPtxDjjzQLZxYOuxLB.Crc);
		}
		oaNXCfsQFPpQxhohoJJQdDfBPubx += totalOut;
		if (CJdgihQFVgTPtxDjjzQLZxYOuxLB.IsCrypted)
		{
			CJdgihQFVgTPtxDjjzQLZxYOuxLB.CompressedSize += 12L;
		}
		if (ZmKhHHDhZvTyGypiXRCvuYiygTey)
		{
			ZmKhHHDhZvTyGypiXRCvuYiygTey = false;
			long position = baseOutputStream_.Position;
			baseOutputStream_.Seek(exSOEntrerAeuJZQcQCZsOVQPlJp, SeekOrigin.Begin);
			xvtEJBdaubFMVDZlyYjGEAWfTSThA((int)CJdgihQFVgTPtxDjjzQLZxYOuxLB.Crc);
			if (!CJdgihQFVgTPtxDjjzQLZxYOuxLB.LocalHeaderRequiresZip64)
			{
				xvtEJBdaubFMVDZlyYjGEAWfTSThA((int)CJdgihQFVgTPtxDjjzQLZxYOuxLB.CompressedSize);
				xvtEJBdaubFMVDZlyYjGEAWfTSThA((int)CJdgihQFVgTPtxDjjzQLZxYOuxLB.Size);
			}
			else
			{
				if (sTURsmGSXnFKtVgWBFJDILhLbrwU == -1L)
				{
					throw new ZipException("Entry requires zip64 but this has been turned off");
				}
				baseOutputStream_.Seek(sTURsmGSXnFKtVgWBFJDILhLbrwU, SeekOrigin.Begin);
				VFgRDKXYZqnnFobLuQUciDMkCOVk(CJdgihQFVgTPtxDjjzQLZxYOuxLB.Size);
				VFgRDKXYZqnnFobLuQUciDMkCOVk(CJdgihQFVgTPtxDjjzQLZxYOuxLB.CompressedSize);
			}
			baseOutputStream_.Seek(position, SeekOrigin.Begin);
		}
		if (((uint)CJdgihQFVgTPtxDjjzQLZxYOuxLB.Flags & 8u) != 0)
		{
			xvtEJBdaubFMVDZlyYjGEAWfTSThA(134695760);
			xvtEJBdaubFMVDZlyYjGEAWfTSThA((int)CJdgihQFVgTPtxDjjzQLZxYOuxLB.Crc);
			if (!CJdgihQFVgTPtxDjjzQLZxYOuxLB.LocalHeaderRequiresZip64)
			{
				xvtEJBdaubFMVDZlyYjGEAWfTSThA((int)CJdgihQFVgTPtxDjjzQLZxYOuxLB.CompressedSize);
				xvtEJBdaubFMVDZlyYjGEAWfTSThA((int)CJdgihQFVgTPtxDjjzQLZxYOuxLB.Size);
				oaNXCfsQFPpQxhohoJJQdDfBPubx += 16L;
			}
			else
			{
				VFgRDKXYZqnnFobLuQUciDMkCOVk(CJdgihQFVgTPtxDjjzQLZxYOuxLB.CompressedSize);
				VFgRDKXYZqnnFobLuQUciDMkCOVk(CJdgihQFVgTPtxDjjzQLZxYOuxLB.Size);
				oaNXCfsQFPpQxhohoJJQdDfBPubx += 24L;
			}
		}
		KGpfWNQIqpniJfTwGTOSUJtnskIf.Add(CJdgihQFVgTPtxDjjzQLZxYOuxLB);
		CJdgihQFVgTPtxDjjzQLZxYOuxLB = null;
	}

	private void rZBWnsBzAUejTFDJOSwrmlDwcYbQ(byte[] buffer, int offset, int count)
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
		if (KGpfWNQIqpniJfTwGTOSUJtnskIf == null)
		{
			return;
		}
		if (CJdgihQFVgTPtxDjjzQLZxYOuxLB != null)
		{
			CloseEntry();
		}
		long noOfEntries = KGpfWNQIqpniJfTwGTOSUJtnskIf.Count;
		long num = 0L;
		foreach (ZipEntry item in KGpfWNQIqpniJfTwGTOSUJtnskIf)
		{
			xvtEJBdaubFMVDZlyYjGEAWfTSThA(33639248);
			ohnFnudFcZvwMQVntLiAhTdFwqEM(45);
			ohnFnudFcZvwMQVntLiAhTdFwqEM(item.Version);
			ohnFnudFcZvwMQVntLiAhTdFwqEM(item.Flags);
			ohnFnudFcZvwMQVntLiAhTdFwqEM((short)item.CompressionMethod);
			xvtEJBdaubFMVDZlyYjGEAWfTSThA((int)item.DosTime);
			xvtEJBdaubFMVDZlyYjGEAWfTSThA((int)item.Crc);
			if (!item.IsZip64Forced() && item.CompressedSize < 4294967295L)
			{
				xvtEJBdaubFMVDZlyYjGEAWfTSThA((int)item.CompressedSize);
			}
			else
			{
				xvtEJBdaubFMVDZlyYjGEAWfTSThA(-1);
			}
			if (!item.IsZip64Forced() && item.Size < 4294967295L)
			{
				xvtEJBdaubFMVDZlyYjGEAWfTSThA((int)item.Size);
			}
			else
			{
				xvtEJBdaubFMVDZlyYjGEAWfTSThA(-1);
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
					ohnFnudFcZvwMQVntLiAhTdFwqEM(array.Length);
					ohnFnudFcZvwMQVntLiAhTdFwqEM(entryData.Length);
					ohnFnudFcZvwMQVntLiAhTdFwqEM(array2.Length);
					ohnFnudFcZvwMQVntLiAhTdFwqEM(0);
					ohnFnudFcZvwMQVntLiAhTdFwqEM(0);
					if (item.ExternalFileAttributes == -1)
					{
						if (!item.IsDirectory)
						{
							xvtEJBdaubFMVDZlyYjGEAWfTSThA(0);
						}
						else
						{
							xvtEJBdaubFMVDZlyYjGEAWfTSThA(16);
						}
					}
					else
					{
						xvtEJBdaubFMVDZlyYjGEAWfTSThA(item.ExternalFileAttributes);
					}
					if (item.Offset >= 4294967295L)
					{
						xvtEJBdaubFMVDZlyYjGEAWfTSThA(-1);
					}
					else
					{
						xvtEJBdaubFMVDZlyYjGEAWfTSThA((int)item.Offset);
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
		using (CfcHHULxLwXWsXVCpmxHEpDxPQAF cfcHHULxLwXWsXVCpmxHEpDxPQAF = new CfcHHULxLwXWsXVCpmxHEpDxPQAF(baseOutputStream_))
		{
			cfcHHULxLwXWsXVCpmxHEpDxPQAF.EVwkUZBieQSmujkYuEOuEMdWuXmM(noOfEntries, num, oaNXCfsQFPpQxhohoJJQdDfBPubx, zVxkSCNETwPfQJvGXbNINrPXMqid);
		}
		KGpfWNQIqpniJfTwGTOSUJtnskIf = null;
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
		if (KGpfWNQIqpniJfTwGTOSUJtnskIf != null)
		{
			if (CJdgihQFVgTPtxDjjzQLZxYOuxLB != null)
			{
				CloseEntry();
			}
			if (KGpfWNQIqpniJfTwGTOSUJtnskIf.Count == int.MaxValue)
			{
				throw new ZipException("Too many entries for Zip file");
			}
			CompressionMethod compressionMethod = entry.CompressionMethod;
			int level = hyDIyTRUIMkxRnXjSFFuWEtgrUkm;
			entry.Flags &= 2048;
			ZmKhHHDhZvTyGypiXRCvuYiygTey = false;
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
					if (flag)
					{
						entry.CompressedSize = entry.Size;
						flag = entry.HasCrc;
					}
					else if (!CanSeek)
					{
						compressionMethod = CompressionMethod.Deflated;
						level = 0;
					}
				}
			}
			if (!flag)
			{
				if (CanSeek)
				{
					ZmKhHHDhZvTyGypiXRCvuYiygTey = true;
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
			entry.Offset = oaNXCfsQFPpQxhohoJJQdDfBPubx;
			entry.CompressionMethod = compressionMethod;
			GVWugEjDZDjZfkAFZavaDwkYOWrN = compressionMethod;
			sTURsmGSXnFKtVgWBFJDILhLbrwU = -1L;
			if (svuDrGoXqHoWNqaKclrVfIkLByFbA == UseZip64.On || (entry.Size < 0L && svuDrGoXqHoWNqaKclrVfIkLByFbA == UseZip64.Dynamic))
			{
				entry.ForceZip64();
			}
			xvtEJBdaubFMVDZlyYjGEAWfTSThA(67324752);
			ohnFnudFcZvwMQVntLiAhTdFwqEM(entry.Version);
			ohnFnudFcZvwMQVntLiAhTdFwqEM(entry.Flags);
			ohnFnudFcZvwMQVntLiAhTdFwqEM((byte)compressionMethod);
			xvtEJBdaubFMVDZlyYjGEAWfTSThA((int)entry.DosTime);
			if (!flag)
			{
				if (ZmKhHHDhZvTyGypiXRCvuYiygTey)
				{
					exSOEntrerAeuJZQcQCZsOVQPlJp = baseOutputStream_.Position;
				}
				xvtEJBdaubFMVDZlyYjGEAWfTSThA(0);
				if (ZmKhHHDhZvTyGypiXRCvuYiygTey)
				{
					sTURsmGSXnFKtVgWBFJDILhLbrwU = baseOutputStream_.Position;
				}
				if (!entry.LocalHeaderRequiresZip64 && !ZmKhHHDhZvTyGypiXRCvuYiygTey)
				{
					xvtEJBdaubFMVDZlyYjGEAWfTSThA(0);
					xvtEJBdaubFMVDZlyYjGEAWfTSThA(0);
				}
				else
				{
					xvtEJBdaubFMVDZlyYjGEAWfTSThA(-1);
					xvtEJBdaubFMVDZlyYjGEAWfTSThA(-1);
				}
			}
			else
			{
				xvtEJBdaubFMVDZlyYjGEAWfTSThA((int)entry.Crc);
				if (entry.LocalHeaderRequiresZip64)
				{
					xvtEJBdaubFMVDZlyYjGEAWfTSThA(-1);
					xvtEJBdaubFMVDZlyYjGEAWfTSThA(-1);
				}
				else
				{
					xvtEJBdaubFMVDZlyYjGEAWfTSThA((int)(entry.IsCrypted ? ((int)entry.CompressedSize + 12) : entry.CompressedSize));
					xvtEJBdaubFMVDZlyYjGEAWfTSThA((int)entry.Size);
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
				if (ZmKhHHDhZvTyGypiXRCvuYiygTey)
				{
					sTURsmGSXnFKtVgWBFJDILhLbrwU = zipExtraData.CurrentReadIndex;
				}
			}
			else
			{
				zipExtraData.Delete(1);
			}
			byte[] entryData = zipExtraData.GetEntryData();
			ohnFnudFcZvwMQVntLiAhTdFwqEM(array.Length);
			ohnFnudFcZvwMQVntLiAhTdFwqEM(entryData.Length);
			if (array.Length != 0)
			{
				baseOutputStream_.Write(array, 0, array.Length);
			}
			if (entry.LocalHeaderRequiresZip64 && ZmKhHHDhZvTyGypiXRCvuYiygTey)
			{
				sTURsmGSXnFKtVgWBFJDILhLbrwU += baseOutputStream_.Position;
			}
			if (entryData.Length != 0)
			{
				baseOutputStream_.Write(entryData, 0, entryData.Length);
			}
			oaNXCfsQFPpQxhohoJJQdDfBPubx += 30 + array.Length + entryData.Length;
			CJdgihQFVgTPtxDjjzQLZxYOuxLB = entry;
			SkeCOrQuISdaMVSOmQcRThNecFnb.Reset();
			if (compressionMethod == CompressionMethod.Deflated)
			{
				deflater_.Reset();
				deflater_.SetLevel(level);
			}
			gOPGBDvMAQDMSIGaZoAfsWDPWdme = 0L;
			if (entry.IsCrypted)
			{
				if (entry.Crc >= 0L)
				{
					kajZHFBujrfZRwJQCDBjLWRBRCMT(entry.Crc);
				}
				else
				{
					kajZHFBujrfZRwJQCDBjLWRBRCMT(entry.DosTime << 16);
				}
			}
			return;
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
		zVxkSCNETwPfQJvGXbNINrPXMqid = array;
	}

	public void SetLevel(int level)
	{
		deflater_.SetLevel(level);
		hyDIyTRUIMkxRnXjSFFuWEtgrUkm = level;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (CJdgihQFVgTPtxDjjzQLZxYOuxLB == null)
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
				SkeCOrQuISdaMVSOmQcRThNecFnb.Update(buffer, offset, count);
				gOPGBDvMAQDMSIGaZoAfsWDPWdme += count;
				switch (GVWugEjDZDjZfkAFZavaDwkYOWrN)
				{
				case CompressionMethod.Deflated:
					base.Write(buffer, offset, count);
					break;
				case CompressionMethod.Stored:
					if (base.Password != null)
					{
						rZBWnsBzAUejTFDJOSwrmlDwcYbQ(buffer, offset, count);
					}
					else
					{
						baseOutputStream_.Write(buffer, offset, count);
					}
					break;
				}
				return;
			}
			throw new ArgumentException("Invalid offset/count combination");
		}
		throw new ArgumentOutOfRangeException("offset", "Cannot be negative");
	}

	private void kajZHFBujrfZRwJQCDBjLWRBRCMT(long crcValue)
	{
		oaNXCfsQFPpQxhohoJJQdDfBPubx += 12L;
		InitializePassword(base.Password);
		byte[] array = new byte[12];
		new Random().NextBytes(array);
		array[11] = (byte)(crcValue >> 24);
		EncryptBlock(array, 0, array.Length);
		baseOutputStream_.Write(array, 0, array.Length);
	}

	private void xvtEJBdaubFMVDZlyYjGEAWfTSThA(int value)
	{
		ohnFnudFcZvwMQVntLiAhTdFwqEM(value);
		ohnFnudFcZvwMQVntLiAhTdFwqEM(value >> 16);
	}

	private void VFgRDKXYZqnnFobLuQUciDMkCOVk(long value)
	{
		xvtEJBdaubFMVDZlyYjGEAWfTSThA((int)value);
		xvtEJBdaubFMVDZlyYjGEAWfTSThA((int)(value >> 32));
	}

	private void ohnFnudFcZvwMQVntLiAhTdFwqEM(int value)
	{
		baseOutputStream_.WriteByte((byte)((uint)value & 0xFFu));
		baseOutputStream_.WriteByte((byte)((uint)(value >> 8) & 0xFFu));
	}
}
