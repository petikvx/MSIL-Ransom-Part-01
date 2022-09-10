using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class caz : MarshalByRefObject, dca
{
	public unsafe edz* a;

	public unsafe caz()
	{
		a = null;
	}

	public unsafe virtual string cc()
	{
		edz* ptr = a;
		if (ptr != null)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ecz ecz2);
			ecz* pD4t_ = _003CModule_003E.d(ptr, &ecz2);
			string result;
			try
			{
				result = new string(_003CModule_003E.c((d4t*)pD4t_));
			}
			catch
			{
				//try-fault
				_003CModule_003E.b((delegate*<void*, void>)(delegate*<ecz*, void>)(&_003CModule_003E.b), &ecz2);
				throw;
			}
			_003CModule_003E.b(&ecz2);
			return result;
		}
		return "";
	}

	public unsafe virtual string cd()
	{
		edz* ptr = a;
		if (ptr != null)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ecz ecz2);
			ecz* pD4t_ = _003CModule_003E.c(ptr, &ecz2);
			string result;
			try
			{
				result = new string(_003CModule_003E.c((d4t*)pD4t_));
			}
			catch
			{
				//try-fault
				_003CModule_003E.b((delegate*<void*, void>)(delegate*<ecz*, void>)(&_003CModule_003E.b), &ecz2);
				throw;
			}
			_003CModule_003E.b(&ecz2);
			return result;
		}
		return "";
	}

	public virtual ama cz()
	{
		return null;
	}

	public unsafe virtual string ce()
	{
		edz* ptr = a;
		if (ptr != null)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ecz ecz2);
			ecz* pD4t_ = _003CModule_003E.a(ptr, &ecz2);
			string result;
			try
			{
				result = new string(_003CModule_003E.c((d4t*)pD4t_));
			}
			catch
			{
				//try-fault
				_003CModule_003E.b((delegate*<void*, void>)(delegate*<ecz*, void>)(&_003CModule_003E.b), &ecz2);
				throw;
			}
			_003CModule_003E.b(&ecz2);
			return result;
		}
		return "";
	}

	public unsafe virtual of cf()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		of val = new of();
		edz* ptr = a;
		if (ptr != null)
		{
			_003CModule_003E.a(ptr, val);
		}
		return val;
	}

	public unsafe virtual int cg()
	{
		edz* ptr = a;
		if (ptr != null)
		{
			return _003CModule_003E.n(ptr);
		}
		return -1;
	}

	public unsafe virtual string ch()
	{
		edz* ptr = a;
		if (ptr != null)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ecz ecz2);
			ecz* pD4t_ = _003CModule_003E.b(ptr, &ecz2);
			string result;
			try
			{
				result = new string(_003CModule_003E.c((d4t*)pD4t_));
			}
			catch
			{
				//try-fault
				_003CModule_003E.b((delegate*<void*, void>)(delegate*<ecz*, void>)(&_003CModule_003E.b), &ecz2);
				throw;
			}
			_003CModule_003E.b(&ecz2);
			return result;
		}
		return "";
	}

	public virtual int c0()
	{
		return 0;
	}

	public unsafe virtual int ci()
	{
		edz* ptr = a;
		if (ptr != null)
		{
			return _003CModule_003E.m(ptr);
		}
		return 0;
	}

	public unsafe virtual int cj()
	{
		edz* ptr = a;
		if (ptr != null)
		{
			return _003CModule_003E.l(ptr);
		}
		return 0;
	}

	public unsafe virtual void ck(int int_0)
	{
		edz* ptr = a;
		if (ptr != null)
		{
			_003CModule_003E.c(ptr, int_0);
		}
	}

	public unsafe virtual void cl(int int_0)
	{
		edz* ptr = a;
		if (ptr != null)
		{
			_003CModule_003E.b(ptr, int_0);
		}
	}

	public unsafe virtual zl cm()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		edz* ptr = a;
		if (ptr != null)
		{
			IntPtr intPtr = new IntPtr((void*)(int)(*(uint*)((byte*)ptr + 92)));
			return (zl)((GCHandle)intPtr).Target;
		}
		return new zl();
	}

	public unsafe virtual void cn(zl zl_0)
	{
		edz* ptr = a;
		if (ptr != null)
		{
			_003CModule_003E.a(ptr, zl_0);
		}
	}

	public unsafe virtual void co()
	{
		edz* ptr = a;
		if (ptr != null)
		{
			_003CModule_003E.i(ptr);
		}
	}

	public unsafe virtual void cp()
	{
		edz* ptr = a;
		if (ptr != null)
		{
			_003CModule_003E.h(ptr);
		}
	}

	public unsafe virtual void cq()
	{
		edz* ptr = a;
		if (ptr != null)
		{
			_003CModule_003E.g(ptr);
		}
	}

	public unsafe virtual void cr(int int_0)
	{
		edz* ptr = a;
		if (ptr != null)
		{
			_003CModule_003E.a(ptr, int_0);
		}
	}

	public unsafe virtual void cs(int int_0, int int_1)
	{
		edz* ptr = a;
		if (ptr != null)
		{
			_003CModule_003E.a(ptr, int_0, int_1);
		}
	}

	public unsafe virtual ulong ct()
	{
		edz* ptr = a;
		if (ptr != null)
		{
			return _003CModule_003E.f(ptr);
		}
		return 0uL;
	}

	public unsafe virtual void cu(string[] string_0)
	{
		edz* ptr = a;
		if (ptr != null)
		{
			_003CModule_003E.a(ptr, string_0);
		}
	}

	public unsafe virtual string[] cv()
	{
		edz* ptr = a;
		if (ptr != null)
		{
			IntPtr intPtr = new IntPtr((void*)(int)(*(uint*)((byte*)ptr + 100)));
			return (string[])((GCHandle)intPtr).Target;
		}
		return null;
	}

	public virtual int c1()
	{
		return 0;
	}

	public unsafe virtual int cw()
	{
		edz* ptr = a;
		if (ptr != null)
		{
			return _003CModule_003E.e(ptr);
		}
		return 0;
	}

	public unsafe virtual int cx(ArrayList arrayList_0, ArrayList arrayList_1)
	{
		edz* ptr = a;
		if (ptr != null)
		{
			return _003CModule_003E.a(ptr, arrayList_0, arrayList_1);
		}
		return 0;
	}

	public unsafe virtual int cy()
	{
		edz* ptr = a;
		if (ptr != null)
		{
			return _003CModule_003E.d(ptr);
		}
		return 0;
	}
}
