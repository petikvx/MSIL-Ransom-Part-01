using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Gecko.Interop;

public class ComPtr<T> : IEquatable<ComPtr<T>>, IEquatable<T>, IDisposable where T : class
{
	protected T _instance;

	private readonly bool _releaseRCW;

	public T Instance => _instance;

	public ComPtr(T instance, bool releaseRCW = true)
	{
		_instance = instance;
		_releaseRCW = releaseRCW;
	}

	~ComPtr()
	{
		Free();
	}

	public void Dispose()
	{
		Free();
		GC.SuppressFinalize(this);
	}

	private void Free()
	{
		if (_instance != null && _releaseRCW)
		{
			Xpcom.FreeComObject(ref _instance);
		}
		_instance = null;
	}

	public void FinalRelease()
	{
		if (_instance != null)
		{
			Xpcom.FinalFreeComObject(ref _instance);
		}
		_instance = null;
	}

	public bool Equals(ComPtr<T> other)
	{
		if (this == other)
		{
			return true;
		}
		if (other == null)
		{
			return false;
		}
		return _instance.GetHashCode() == other._instance.GetHashCode();
	}

	public bool Equals(T other)
	{
		if (other == null)
		{
			return false;
		}
		return _instance.GetHashCode() == other.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		if (this == obj)
		{
			return true;
		}
		if (obj == null)
		{
			return false;
		}
		if (!(obj is ComPtr<T>))
		{
			return false;
		}
		return _instance.GetHashCode() == ((ComPtr<T>)obj)._instance.GetHashCode();
	}

	public override int GetHashCode()
	{
		return _instance.GetHashCode();
	}

	public ComPtr<TInterface> QueryInterface<TInterface>() where TInterface : class
	{
		TInterface val = Xpcom.QueryInterface<TInterface>(_instance);
		return (val == null) ? null : new ComPtr<TInterface>(val);
	}

	public ClassInfo GetClassInfo()
	{
		nsIClassInfo nsIClassInfo = Xpcom.QueryInterface<nsIClassInfo>(_instance);
		return (nsIClassInfo == null) ? null : new ClassInfo(nsIClassInfo);
	}

	public bool GetComMethod<U>(int slot, out Delegate method) where U : class
	{
		IntPtr comInterfaceForObject = Marshal.GetComInterfaceForObject(_instance, typeof(T));
		if (comInterfaceForObject == IntPtr.Zero)
		{
			method = null;
			return false;
		}
		bool result = false;
		try
		{
			IntPtr ptr = Marshal.ReadIntPtr(Marshal.ReadIntPtr(comInterfaceForObject, 0), slot * IntPtr.Size);
			method = Marshal.GetDelegateForFunctionPointer(ptr, typeof(U));
			result = true;
		}
		finally
		{
			Marshal.Release(comInterfaceForObject);
		}
		return result;
	}

	public int GetSlotOfComMethod(Delegate method)
	{
		if (method.Method.DeclaringType != typeof(T))
		{
			throw new ArgumentOutOfRangeException("method");
		}
		return Marshal.GetComSlotForMethodInfo((MemberInfo)method.Method);
	}

	public U GetComMethod<U>(int slot) where U : class
	{
		if (!GetComMethod<U>(slot, out var method))
		{
			throw new MethodAccessException();
		}
		return (U)(object)method;
	}
}
