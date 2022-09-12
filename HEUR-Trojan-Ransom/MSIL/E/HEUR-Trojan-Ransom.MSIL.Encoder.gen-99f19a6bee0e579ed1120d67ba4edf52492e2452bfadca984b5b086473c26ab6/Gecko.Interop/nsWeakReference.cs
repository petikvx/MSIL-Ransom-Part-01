using System;

namespace Gecko.Interop;

public class nsWeakReference : nsIWeakReference
{
	protected WeakReference _weakReference;

	public nsWeakReference(object obj)
	{
		_weakReference = new WeakReference(obj, trackResurrection: false);
	}

	IntPtr nsIWeakReference.QueryReferent(ref Guid uuid)
	{
		return _weakReference.IsAlive ? QueryReferentImplementation(_weakReference.Target, ref uuid) : IntPtr.Zero;
	}

	protected virtual IntPtr QueryReferentImplementation(object obj, ref Guid uuid)
	{
		return Xpcom.QueryReferent(obj, ref uuid);
	}
}
