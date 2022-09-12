using System;
using MySql.Data.MySqlClient;

namespace MySql.Data.Common;

internal class SharedMemory : IDisposable
{
	private const uint FILE_MAP_WRITE = 2u;

	private IntPtr fileMapping;

	private IntPtr view;

	public IntPtr View => view;

	public SharedMemory(string name, IntPtr size)
	{
		fileMapping = NativeMethods.OpenFileMapping(2u, bInheritHandle: false, name);
		if (fileMapping == IntPtr.Zero)
		{
			throw new MySqlException("Cannot open file mapping " + name);
		}
		view = NativeMethods.MapViewOfFile(fileMapping, 2u, 0u, 0u, size);
	}

	~SharedMemory()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (view != IntPtr.Zero)
			{
				NativeMethods.UnmapViewOfFile(view);
				view = IntPtr.Zero;
			}
			if (fileMapping != IntPtr.Zero)
			{
				NativeMethods.CloseHandle(fileMapping);
				fileMapping = IntPtr.Zero;
			}
		}
	}
}
