using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace MySql.Data.X.common;

internal static class UnmanagedLibraryLoader
{
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

	internal static bool LoadUnmanagedLibraryFromEmbeddedResources(string applicationName, string libraryName)
	{
		try
		{
			byte[] array = null;
			string name = applicationName + "." + libraryName;
			using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name))
			{
				array = new byte[(int)stream.Length];
				stream.Read(array, 0, (int)stream.Length);
			}
			string text = Path.GetTempPath() + libraryName;
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			File.WriteAllBytes(text, array);
			LoadLibraryEx(text, IntPtr.Zero, LoadLibraryFlags.LOAD_WITH_ALTERED_SEARCH_PATH);
			return true;
		}
		catch
		{
			return false;
		}
	}

	[DllImport("kernel32", SetLastError = true)]
	private static extern IntPtr LoadLibraryEx(string lpFileName, IntPtr hReservedNull, LoadLibraryFlags dwFlags);
}
