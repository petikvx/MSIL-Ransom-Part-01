using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Ionic.Zip;

internal static class ZipOutput
{
	public static bool WriteCentralDirectoryStructure(Stream s, ICollection<ZipEntry> entries, uint numSegments, Zip64Option zip64, string comment, ZipContainer container)
	{
		ZipSegmentedStream zipSegmentedStream = s as ZipSegmentedStream;
		if (zipSegmentedStream != null)
		{
			zipSegmentedStream.ContiguousWrite = true;
		}
		long num = 0L;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			foreach (ZipEntry entry in entries)
			{
				if (entry.IncludedInMostRecentSave)
				{
					entry.WriteCentralDirectoryEntry(memoryStream);
				}
			}
			byte[] array = memoryStream.ToArray();
			s.Write(array, 0, array.Length);
			num = array.Length;
		}
		long num2 = ((s is CountingStream countingStream) ? countingStream.ComputedPosition : s.Position);
		long num3 = num2 - num;
		uint num4 = zipSegmentedStream?.CurrentSegment ?? 0;
		long num5 = num2 - num3;
		int num6 = CountEntries(entries);
		bool num7 = zip64 == Zip64Option.Always || num6 >= 65535 || num5 > 4294967295L || num3 > 4294967295L;
		byte[] array2 = null;
		if (num7)
		{
			if (zip64 == Zip64Option.Default)
			{
				if (new StackFrame(1).GetMethod()!.DeclaringType == typeof(ZipFile))
				{
					throw new ZipException("The archive requires a ZIP64 Central Directory. Consider setting the ZipFile.UseZip64WhenSaving property.");
				}
				throw new ZipException("The archive requires a ZIP64 Central Directory. Consider setting the ZipOutputStream.EnableZip64 property.");
			}
			byte[] array3 = GenZip64EndOfCentralDirectory(num3, num2, num6, numSegments);
			array2 = GenCentralDirectoryFooter(num3, num2, zip64, num6, comment, container);
			if (num4 != 0)
			{
				uint value = zipSegmentedStream.ComputeSegment(array3.Length + array2.Length);
				Array.Copy(BitConverter.GetBytes(value), 0, array3, 16, 4);
				Array.Copy(BitConverter.GetBytes(value), 0, array3, 20, 4);
				Array.Copy(BitConverter.GetBytes(value), 0, array3, 60, 4);
				Array.Copy(BitConverter.GetBytes(value), 0, array3, 72, 4);
			}
			s.Write(array3, 0, array3.Length);
		}
		else
		{
			array2 = GenCentralDirectoryFooter(num3, num2, zip64, num6, comment, container);
		}
		if (num4 != 0)
		{
			ushort value2 = (ushort)zipSegmentedStream.ComputeSegment(array2.Length);
			Array.Copy(BitConverter.GetBytes(value2), 0, array2, 4, 2);
			Array.Copy(BitConverter.GetBytes(value2), 0, array2, 6, 2);
		}
		s.Write(array2, 0, array2.Length);
		if (zipSegmentedStream != null)
		{
			zipSegmentedStream.ContiguousWrite = false;
		}
		return num7;
	}

	private static Encoding GetEncoding(ZipContainer container, string t)
	{
		switch (container.AlternateEncodingUsage)
		{
		case ZipOption.Always:
			return container.AlternateEncoding;
		default:
		{
			Encoding defaultEncoding = container.DefaultEncoding;
			if (t == null)
			{
				return defaultEncoding;
			}
			byte[] bytes = defaultEncoding.GetBytes(t);
			if (defaultEncoding.GetString(bytes, 0, bytes.Length).Equals(t))
			{
				return defaultEncoding;
			}
			return container.AlternateEncoding;
		}
		case ZipOption.Default:
			return container.DefaultEncoding;
		}
	}

	private static byte[] GenCentralDirectoryFooter(long StartOfCentralDirectory, long EndOfCentralDirectory, Zip64Option zip64, int entryCount, string comment, ZipContainer container)
	{
		Encoding encoding = GetEncoding(container, comment);
		int num = 0;
		byte[] array = null;
		short num2 = 0;
		if (comment != null && comment.Length != 0)
		{
			array = encoding.GetBytes(comment);
			num2 = (short)array.Length;
		}
		byte[] array2 = new byte[22 + num2];
		int num3 = 0;
		Array.Copy(BitConverter.GetBytes(101010256u), 0, array2, 0, 4);
		num3 = 4;
		num3 = 5;
		array2[4] = 0;
		num3 = 6;
		array2[5] = 0;
		num3 = 7;
		array2[6] = 0;
		num3 = 8;
		array2[7] = 0;
		if (entryCount < 65535 && zip64 != Zip64Option.Always)
		{
			array2[num3++] = (byte)((uint)entryCount & 0xFFu);
			array2[num3++] = (byte)((entryCount & 0xFF00) >> 8);
			array2[num3++] = (byte)((uint)entryCount & 0xFFu);
			array2[num3++] = (byte)((entryCount & 0xFF00) >> 8);
		}
		else
		{
			for (num = 0; num < 4; num++)
			{
				array2[num3++] = byte.MaxValue;
			}
		}
		long num4 = EndOfCentralDirectory - StartOfCentralDirectory;
		if (num4 < 4294967295L && StartOfCentralDirectory < 4294967295L)
		{
			array2[num3++] = (byte)((ulong)num4 & 0xFFuL);
			array2[num3++] = (byte)((num4 & 0xFF00L) >> 8);
			array2[num3++] = (byte)((num4 & 0xFF0000L) >> 16);
			array2[num3++] = (byte)((num4 & 0xFF000000L) >> 24);
			array2[num3++] = (byte)((ulong)StartOfCentralDirectory & 0xFFuL);
			array2[num3++] = (byte)((StartOfCentralDirectory & 0xFF00L) >> 8);
			array2[num3++] = (byte)((StartOfCentralDirectory & 0xFF0000L) >> 16);
			array2[num3++] = (byte)((StartOfCentralDirectory & 0xFF000000L) >> 24);
		}
		else
		{
			for (num = 0; num < 8; num++)
			{
				array2[num3++] = byte.MaxValue;
			}
		}
		if (comment != null && comment.Length != 0)
		{
			if (num2 + num3 + 2 > array2.Length)
			{
				num2 = (short)(array2.Length - num3 - 2);
			}
			array2[num3++] = (byte)((uint)num2 & 0xFFu);
			array2[num3++] = (byte)((num2 & 0xFF00) >> 8);
			if (num2 != 0)
			{
				for (num = 0; num < num2 && num3 + num < array2.Length; num++)
				{
					array2[num3 + num] = array[num];
				}
				num3 += num;
			}
		}
		else
		{
			array2[num3++] = 0;
			array2[num3++] = 0;
		}
		return array2;
	}

	private static byte[] GenZip64EndOfCentralDirectory(long StartOfCentralDirectory, long EndOfCentralDirectory, int entryCount, uint numSegments)
	{
		byte[] array = new byte[76];
		int num = 0;
		Array.Copy(BitConverter.GetBytes(101075792u), 0, array, 0, 4);
		num = 4;
		Array.Copy(BitConverter.GetBytes(44L), 0, array, 4, 8);
		num = 12;
		num = 13;
		array[12] = 45;
		num = 14;
		array[13] = 0;
		num = 15;
		array[14] = 45;
		num = 16;
		array[15] = 0;
		for (int i = 0; i < 8; i++)
		{
			array[num++] = 0;
		}
		long value = entryCount;
		Array.Copy(BitConverter.GetBytes(value), 0, array, num, 8);
		num += 8;
		Array.Copy(BitConverter.GetBytes(value), 0, array, num, 8);
		num += 8;
		Array.Copy(BitConverter.GetBytes(EndOfCentralDirectory - StartOfCentralDirectory), 0, array, num, 8);
		num += 8;
		Array.Copy(BitConverter.GetBytes(StartOfCentralDirectory), 0, array, num, 8);
		num += 8;
		Array.Copy(BitConverter.GetBytes(117853008u), 0, array, num, 4);
		num += 4;
		Array.Copy(BitConverter.GetBytes((numSegments != 0) ? (numSegments - 1) : 0u), 0, array, num, 4);
		num += 4;
		Array.Copy(BitConverter.GetBytes(EndOfCentralDirectory), 0, array, num, 8);
		num += 8;
		Array.Copy(BitConverter.GetBytes(numSegments), 0, array, num, 4);
		num += 4;
		return array;
	}

	private static int CountEntries(ICollection<ZipEntry> _entries)
	{
		int num = 0;
		foreach (ZipEntry _entry in _entries)
		{
			if (_entry.IncludedInMostRecentSave)
			{
				num++;
			}
		}
		return num;
	}
}
