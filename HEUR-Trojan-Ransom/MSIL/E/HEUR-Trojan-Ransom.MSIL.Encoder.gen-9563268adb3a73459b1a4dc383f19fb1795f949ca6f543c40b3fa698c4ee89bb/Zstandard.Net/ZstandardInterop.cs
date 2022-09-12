using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Zstandard.Net;

public static class ZstandardInterop
{
	[StructLayout(LayoutKind.Sequential)]
	public class Buffer
	{
		public IntPtr Data = IntPtr.Zero;

		public UIntPtr Size = UIntPtr.Zero;

		public UIntPtr Position = UIntPtr.Zero;
	}

	[Flags]
	private enum LoadLibraryFlags : uint
	{
		DONT_RESOLVE_DLL_REFERENCES = 1u,
		LOAD_IGNORE_CODE_AUTHZ_LEVEL = 0x10u,
		LOAD_LIBRARY_AS_DATAFILE = 2u,
		LOAD_LIBRARY_AS_DATAFILE_EXCLUSIVE = 0x40u,
		LOAD_LIBRARY_AS_IMAGE_RESOURCE = 0x20u,
		LOAD_LIBRARY_SEARCH_APPLICATION_DIR = 0x200u,
		LOAD_LIBRARY_SEARCH_DEFAULT_DIRS = 0x1000u,
		LOAD_LIBRARY_SEARCH_DLL_LOAD_DIR = 0x100u,
		LOAD_LIBRARY_SEARCH_SYSTEM32 = 0x800u,
		LOAD_LIBRARY_SEARCH_USER_DIRS = 0x400u,
		LOAD_WITH_ALTERED_SEARCH_PATH = 8u
	}

	public static void LoadLibzstdLibrary(string customPath)
	{
		if (Environment.OSVersion.Platform == PlatformID.Win32NT)
		{
			string text = null;
			if (string.IsNullOrEmpty(customPath))
			{
				string directoryName = Path.GetDirectoryName(typeof(ZstandardInterop).Assembly.Location);
				string path = (Environment.Is64BitProcess ? "x64" : "x86");
				text = Path.Combine(directoryName, path, "libzstd.dll");
			}
			else
			{
				text = Path.Combine(customPath, "libzstd.dll");
			}
			LoadLibraryEx(text, IntPtr.Zero, LoadLibraryFlags.LOAD_WITH_ALTERED_SEARCH_PATH);
		}
	}

	public static void ThrowIfError(UIntPtr code)
	{
		if (ZSTD_isError(code))
		{
			IntPtr ptr = ZSTD_getErrorName(code);
			string message = Marshal.PtrToStringAnsi(ptr);
			throw new IOException(message);
		}
	}

	[DllImport("kernel32", SetLastError = true)]
	private static extern IntPtr LoadLibraryEx(string lpFileName, IntPtr hReservedNull, LoadLibraryFlags dwFlags);

	[DllImport("libzstd", CallingConvention = CallingConvention.Cdecl)]
	public static extern uint ZSTD_versionNumber();

	[DllImport("libzstd", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ZSTD_maxCLevel();

	[DllImport("libzstd", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ZSTD_createCStream();

	[DllImport("libzstd", CallingConvention = CallingConvention.Cdecl)]
	public static extern UIntPtr ZSTD_initCStream(IntPtr zcs, int compressionLevel);

	[DllImport("libzstd", CallingConvention = CallingConvention.Cdecl)]
	public static extern UIntPtr ZSTD_freeCStream(IntPtr zcs);

	[DllImport("libzstd", CallingConvention = CallingConvention.Cdecl)]
	public static extern UIntPtr ZSTD_CStreamInSize();

	[DllImport("libzstd", CallingConvention = CallingConvention.Cdecl)]
	public static extern UIntPtr ZSTD_CStreamOutSize();

	[DllImport("libzstd", CallingConvention = CallingConvention.Cdecl)]
	public static extern UIntPtr ZSTD_compressStream(IntPtr zcs, [MarshalAs(UnmanagedType.LPStruct)] Buffer outputBuffer, [MarshalAs(UnmanagedType.LPStruct)] Buffer inputBuffer);

	[DllImport("libzstd", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ZSTD_createCDict(IntPtr dictBuffer, UIntPtr dictSize, int compressionLevel);

	[DllImport("libzstd", CallingConvention = CallingConvention.Cdecl)]
	public static extern UIntPtr ZSTD_freeCDict(IntPtr cdict);

	[DllImport("libzstd", CallingConvention = CallingConvention.Cdecl)]
	public static extern UIntPtr ZSTD_initCStream_usingCDict(IntPtr zcs, IntPtr cdict);

	[DllImport("libzstd", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ZSTD_createDStream();

	[DllImport("libzstd", CallingConvention = CallingConvention.Cdecl)]
	public static extern UIntPtr ZSTD_initDStream(IntPtr zds);

	[DllImport("libzstd", CallingConvention = CallingConvention.Cdecl)]
	public static extern UIntPtr ZSTD_freeDStream(IntPtr zds);

	[DllImport("libzstd", CallingConvention = CallingConvention.Cdecl)]
	public static extern UIntPtr ZSTD_DStreamInSize();

	[DllImport("libzstd", CallingConvention = CallingConvention.Cdecl)]
	public static extern UIntPtr ZSTD_DStreamOutSize();

	[DllImport("libzstd", CallingConvention = CallingConvention.Cdecl)]
	public static extern UIntPtr ZSTD_decompressStream(IntPtr zds, [MarshalAs(UnmanagedType.LPStruct)] Buffer outputBuffer, [MarshalAs(UnmanagedType.LPStruct)] Buffer inputBuffer);

	[DllImport("libzstd", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ZSTD_createDDict(IntPtr dictBuffer, UIntPtr dictSize);

	[DllImport("libzstd", CallingConvention = CallingConvention.Cdecl)]
	public static extern UIntPtr ZSTD_freeDDict(IntPtr ddict);

	[DllImport("libzstd", CallingConvention = CallingConvention.Cdecl)]
	public static extern UIntPtr ZSTD_initDStream_usingDDict(IntPtr zds, IntPtr ddict);

	[DllImport("libzstd", CallingConvention = CallingConvention.Cdecl)]
	public static extern UIntPtr ZSTD_flushStream(IntPtr zcs, [MarshalAs(UnmanagedType.LPStruct)] Buffer outputBuffer);

	[DllImport("libzstd", CallingConvention = CallingConvention.Cdecl)]
	public static extern UIntPtr ZSTD_endStream(IntPtr zcs, [MarshalAs(UnmanagedType.LPStruct)] Buffer outputBuffer);

	[DllImport("libzstd", CallingConvention = CallingConvention.Cdecl)]
	internal static extern bool ZSTD_isError(UIntPtr code);

	[DllImport("libzstd", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr ZSTD_getErrorName(UIntPtr code);
}
