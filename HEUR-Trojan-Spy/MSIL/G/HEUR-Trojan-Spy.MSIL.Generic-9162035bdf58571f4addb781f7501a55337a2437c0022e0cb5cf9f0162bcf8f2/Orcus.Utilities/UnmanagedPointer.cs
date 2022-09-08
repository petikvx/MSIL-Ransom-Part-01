using System;
using System.Runtime.InteropServices;

namespace Orcus.Utilities;

internal sealed class UnmanagedPointer : IDisposable
{
	private AllocMethod m_meth;

	private IntPtr m_ptr;

	internal UnmanagedPointer(IntPtr ptr, AllocMethod method)
	{
		m_meth = method;
		m_ptr = ptr;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
	}

	~UnmanagedPointer()
	{
		Dispose(disposing: false);
	}

	private void Dispose(bool disposing)
	{
		if (m_ptr != IntPtr.Zero)
		{
			if (m_meth == AllocMethod.HGlobal)
			{
				Marshal.FreeHGlobal(m_ptr);
			}
			else if (m_meth == AllocMethod.CoTaskMem)
			{
				Marshal.FreeCoTaskMem(m_ptr);
			}
			m_ptr = IntPtr.Zero;
		}
		if (disposing)
		{
			GC.SuppressFinalize(this);
		}
	}

	public static implicit operator IntPtr(UnmanagedPointer ptr)
	{
		return ptr.m_ptr;
	}
}
