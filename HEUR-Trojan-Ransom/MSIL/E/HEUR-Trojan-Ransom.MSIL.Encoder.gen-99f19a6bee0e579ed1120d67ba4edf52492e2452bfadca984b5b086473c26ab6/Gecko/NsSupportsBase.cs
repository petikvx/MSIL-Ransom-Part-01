using System;
using System.Runtime.InteropServices;

namespace Gecko;

public abstract class NsSupportsBase : nsISupports
{
	public virtual IntPtr QueryInterface(ref Guid uuid)
	{
		IntPtr iUnknownForObject = Marshal.GetIUnknownForObject(this);
		IntPtr ppv;
		try
		{
			int num = Marshal.QueryInterface(iUnknownForObject, ref uuid, out ppv);
			if (num != 0)
			{
				Marshal.ThrowExceptionForHR(num);
			}
		}
		finally
		{
			Marshal.Release(iUnknownForObject);
		}
		return ppv;
	}

	public virtual int AddRef()
	{
		IntPtr iUnknownForObject = Marshal.GetIUnknownForObject(this);
		Marshal.AddRef(iUnknownForObject);
		return Marshal.Release(iUnknownForObject);
	}

	public virtual int Release()
	{
		IntPtr iUnknownForObject = Marshal.GetIUnknownForObject(this);
		Marshal.Release(iUnknownForObject);
		return Marshal.Release(iUnknownForObject);
	}
}
