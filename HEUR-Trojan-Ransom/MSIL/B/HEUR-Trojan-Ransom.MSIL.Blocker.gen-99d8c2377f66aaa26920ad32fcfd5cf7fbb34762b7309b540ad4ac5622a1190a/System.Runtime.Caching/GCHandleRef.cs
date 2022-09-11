using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace System.Runtime.Caching;

internal class GCHandleRef<T> : IDisposable where T : class, IDisposable
{
	private GCHandle _handle;

	private T _t;

	public T Target
	{
		[SecuritySafeCritical]
		[PermissionSet(SecurityAction.Assert, Unrestricted = true)]
		get
		{
			try
			{
				T val = (T)_handle.Target;
				if (val != null)
				{
					return val;
				}
			}
			catch (InvalidOperationException)
			{
			}
			return _t;
		}
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Assert, Unrestricted = true)]
	public GCHandleRef(T t)
	{
		_handle = GCHandle.Alloc(t);
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Assert, Unrestricted = true)]
	public void Dispose()
	{
		Target.Dispose();
		if (_handle.IsAllocated)
		{
			_t = (T)_handle.Target;
			_handle.Free();
		}
	}
}
