using System;
using System.Runtime.InteropServices;

namespace Gecko;

public class GenericOneClassNsFactory<TFactory, TType> : BaseNsFactory<TFactory>, nsIFactory where TFactory : nsIFactory, new()where TType : new()
{
	protected virtual IntPtr Create(nsISupports aOuter, ref Guid iid)
	{
		IntPtr ppv = IntPtr.Zero;
		IntPtr iUnknownForObject = Marshal.GetIUnknownForObject(new TType());
		Marshal.QueryInterface(iUnknownForObject, ref iid, out ppv);
		Marshal.Release(iUnknownForObject);
		return ppv;
	}

	public IntPtr CreateInstance(nsISupports aOuter, ref Guid iid)
	{
		return Create(aOuter, ref iid);
	}

	public void LockFactory(bool @lock)
	{
	}
}
