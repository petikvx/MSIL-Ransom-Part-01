using System;
using System.Runtime.InteropServices;

namespace ModuleNameSpace;

public class Console_Info
{
	private enum FileType : uint
	{
		FILE_TYPE_UNKNOWN = 0u,
		FILE_TYPE_DISK = 1u,
		FILE_TYPE_CHAR = 2u,
		FILE_TYPE_PIPE = 3u,
		FILE_TYPE_REMOTE = 32768u
	}

	private enum STDHandle : uint
	{
		STD_INPUT_HANDLE = 4294967286u,
		STD_OUTPUT_HANDLE = 4294967285u,
		STD_ERROR_HANDLE = 4294967284u
	}

	[DllImport("Kernel32.dll")]
	private static extern UIntPtr GetStdHandle(STDHandle stdHandle);

	[DllImport("Kernel32.dll")]
	private static extern FileType GetFileType(UIntPtr hFile);

	public static bool IsInputRedirected()
	{
		UIntPtr stdHandle = GetStdHandle(STDHandle.STD_INPUT_HANDLE);
		FileType fileType = GetFileType(stdHandle);
		if (fileType == FileType.FILE_TYPE_CHAR || fileType == FileType.FILE_TYPE_UNKNOWN)
		{
			return false;
		}
		return true;
	}

	public static bool IsOutputRedirected()
	{
		UIntPtr stdHandle = GetStdHandle(STDHandle.STD_OUTPUT_HANDLE);
		FileType fileType = GetFileType(stdHandle);
		if (fileType == FileType.FILE_TYPE_CHAR || fileType == FileType.FILE_TYPE_UNKNOWN)
		{
			return false;
		}
		return true;
	}

	public static bool IsErrorRedirected()
	{
		UIntPtr stdHandle = GetStdHandle(STDHandle.STD_ERROR_HANDLE);
		FileType fileType = GetFileType(stdHandle);
		if (fileType == FileType.FILE_TYPE_CHAR || fileType == FileType.FILE_TYPE_UNKNOWN)
		{
			return false;
		}
		return true;
	}
}
