using System;
using System.Collections;
using System.Runtime.CompilerServices;

internal class n5 : MarshalByRefObject, eqr
{
	public unsafe static apf* a;

	private static ArrayList m_b;

	public unsafe virtual string a()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ecz ecz2);
		ecz* pD4t_ = _003CModule_003E.c(&ecz2);
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

	public virtual void b()
	{
		_003CModule_003E.vz();
	}

	public unsafe virtual string c()
	{
		if (*(int*)(*(int*)((byte*)_003CModule_003E.ag() + 4) + 204) != 0)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ecz ecz2);
			ecz* pD4t_ = _003CModule_003E.a(&ecz2);
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
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ecz ecz3);
		ecz* pD4t_2 = _003CModule_003E.b(&ecz3);
		string result2;
		try
		{
			result2 = new string(_003CModule_003E.c((d4t*)pD4t_2));
		}
		catch
		{
			//try-fault
			_003CModule_003E.b((delegate*<void*, void>)(delegate*<ecz*, void>)(&_003CModule_003E.b), &ecz3);
			throw;
		}
		_003CModule_003E.b(&ecz3);
		return result2;
	}

	public virtual void d()
	{
		_003CModule_003E.on();
	}

	public unsafe virtual void e(string string_0)
	{
		fp8* pFp8_ = _003CModule_003E.ae();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ecz ecz2);
		_003CModule_003E.a((d4t*)(&ecz2), pFp8_);
		try
		{
			ref byte reference = ref *(byte*)string_0;
			if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) != null)
			{
				reference = ref *(byte*)((ref *(_003F*)RuntimeHelpers.OffsetToStringData) + (ref System.Runtime.CompilerServices.Unsafe.As<byte, _003F>(ref reference)));
			}
			fixed (char* pChar_ = &System.Runtime.CompilerServices.Unsafe.As<byte, char>(ref reference))
			{
				_003CModule_003E.c(&ecz2, pChar_);
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.b((delegate*<void*, void>)(delegate*<d4t*, void>)(&_003CModule_003E.b), &ecz2);
			throw;
		}
		try
		{
			_003CModule_003E.k((char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.acf), __arglist(ecz2));
		}
		catch
		{
			//try-fault
			_003CModule_003E.b((delegate*<void*, void>)(delegate*<ecz*, void>)(&_003CModule_003E.b), &ecz2);
			throw;
		}
		_003CModule_003E.b(&ecz2);
		ecz* ptr = (ecz*)_003CModule_003E.e(4u);
		ecz* ptr2;
		try
		{
			if (ptr != null)
			{
				fp8* pFp8_2 = _003CModule_003E.ae();
				_003CModule_003E.a((d4t*)ptr, pFp8_2);
				try
				{
					ref byte reference2 = ref *(byte*)string_0;
					if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) != null)
					{
						reference2 = ref *(byte*)((ref *(_003F*)RuntimeHelpers.OffsetToStringData) + (ref System.Runtime.CompilerServices.Unsafe.As<byte, _003F>(ref reference2)));
					}
					fixed (char* pChar_2 = &System.Runtime.CompilerServices.Unsafe.As<byte, char>(ref reference2))
					{
						_003CModule_003E.c(ptr, pChar_2);
					}
				}
				catch
				{
					//try-fault
					_003CModule_003E.b((delegate*<void*, void>)(delegate*<d4t*, void>)(&_003CModule_003E.b), ptr);
					throw;
				}
				ptr2 = ptr;
			}
			else
			{
				ptr2 = null;
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.w(ptr);
			throw;
		}
		_003CModule_003E.b((cuc*)(int)(*(uint*)((byte*)n5.a + 32)), 33793u, 0u, (int)ptr2);
	}

	public unsafe virtual int f(string string_0)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ecz ecz2);
		ecz* pVoid_ = &ecz2;
		fp8* pFp8_ = _003CModule_003E.ae();
		_003CModule_003E.a((d4t*)(&ecz2), pFp8_);
		try
		{
			ref byte reference = ref *(byte*)string_0;
			if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) != null)
			{
				reference = ref *(byte*)((ref *(_003F*)RuntimeHelpers.OffsetToStringData) + (ref System.Runtime.CompilerServices.Unsafe.As<byte, _003F>(ref reference)));
			}
			fixed (char* pChar_ = &System.Runtime.CompilerServices.Unsafe.As<byte, char>(ref reference))
			{
				_003CModule_003E.c(&ecz2, pChar_);
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.b((delegate*<void*, void>)(delegate*<d4t*, void>)(&_003CModule_003E.b), pVoid_);
			throw;
		}
		return _003CModule_003E.a(n5.a, &ecz2);
	}

	public virtual ArrayList g()
	{
		return n5.m_b;
	}

	public unsafe virtual int h()
	{
		return *(int*)((byte*)n5.a + 272);
	}

	public unsafe virtual int i()
	{
		return *(int*)((byte*)n5.a + 276);
	}

	public unsafe virtual void j(int int_0)
	{
		_003CModule_003E.b((cuc*)(int)(*(uint*)((byte*)n5.a + 32)), 33805u, 0u, int_0);
	}

	public unsafe virtual int k()
	{
		return _003CModule_003E.g(n5.a);
	}

	public unsafe virtual int l(int int_0)
	{
		return _003CModule_003E.d(n5.a, int_0);
	}

	public unsafe virtual e39 m()
	{
		return _003CModule_003E.e(n5.a);
	}

	public unsafe virtual void n(e39 e39_0)
	{
		_003CModule_003E.a(n5.a, e39_0);
	}

	public unsafe virtual int o(string string_0, ArrayList arrayList_0)
	{
		if (n5.a != null)
		{
			ecz* ptr = (ecz*)_003CModule_003E.e(4u);
			ecz* pEcz_;
			try
			{
				pEcz_ = ((ptr == null) ? null : _003CModule_003E.a(ptr, string_0));
			}
			catch
			{
				//try-fault
				_003CModule_003E.w(ptr);
				throw;
			}
			return _003CModule_003E.a(n5.a, pEcz_, arrayList_0);
		}
		return 0;
	}

	public unsafe virtual int p(string string_0)
	{
		fp8* pFp8_ = _003CModule_003E.ae();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ecz ecz2);
		_003CModule_003E.a((d4t*)(&ecz2), pFp8_);
		try
		{
			ref byte reference = ref *(byte*)string_0;
			if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) != null)
			{
				reference = ref *(byte*)((ref *(_003F*)RuntimeHelpers.OffsetToStringData) + (ref System.Runtime.CompilerServices.Unsafe.As<byte, _003F>(ref reference)));
			}
			fixed (char* pChar_ = &System.Runtime.CompilerServices.Unsafe.As<byte, char>(ref reference))
			{
				_003CModule_003E.c(&ecz2, pChar_);
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.b((delegate*<void*, void>)(delegate*<d4t*, void>)(&_003CModule_003E.b), &ecz2);
			throw;
		}
		int result;
		try
		{
			_003CModule_003E.k((char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.acg), __arglist(ecz2));
			result = _003CModule_003E.g(_003CModule_003E.a((d4t*)(&ecz2)));
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

	public unsafe virtual void q(int int_0)
	{
		if (n5.a != null)
		{
			_003CModule_003E.a(n5.a, int_0);
		}
	}

	public static void f()
	{
		n5.m_b = new ArrayList();
	}

	public unsafe static void b(edz* pEdz_0)
	{
		switch (_003CModule_003E.n(pEdz_0))
		{
		case 2:
		{
			enl enl2 = new enl();
			enl2.a = (bh4*)_003CModule_003E.a(pEdz_0, 0, System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.hp), System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.xf), 0);
			((caz)enl2).a = pEdz_0;
			n5.m_b.Add(enl2);
			break;
		}
		case 4:
		{
			afo afo2 = new afo();
			afo2.a = (al6*)_003CModule_003E.a(pEdz_0, 0, System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.hp), System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.xa), 0);
			((caz)afo2).a = pEdz_0;
			n5.m_b.Add(afo2);
			break;
		}
		case 5:
		{
			bji bji2 = new bji();
			bji2.a = (cwr*)_003CModule_003E.a(pEdz_0, 0, System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.hp), System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.zi), 0);
			((caz)bji2).a = pEdz_0;
			n5.m_b.Add(bji2);
			break;
		}
		default:
			_003CModule_003E.k((char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.ace), __arglist());
			break;
		case 8:
		{
			ah7 ah8 = new ah7();
			ah8.a = (z2*)_003CModule_003E.a(pEdz_0, 0, System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.hp), System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.u2), 0);
			((caz)ah8).a = pEdz_0;
			n5.m_b.Add(ah8);
			break;
		}
		}
	}

	public unsafe static void a(edz* pEdz_0)
	{
		int num = 0;
		if (0 >= n5.m_b.Count)
		{
			return;
		}
		do
		{
			caz caz2 = (caz)n5.m_b[num];
			if (caz2.a != pEdz_0)
			{
				num++;
				continue;
			}
			caz2.a = null;
			switch (_003CModule_003E.n(pEdz_0))
			{
			case 2:
				(caz2 as enl).a = null;
				break;
			case 4:
				(caz2 as afo).a = null;
				break;
			case 5:
				(caz2 as bji).a = null;
				break;
			case 8:
				(caz2 as ah7).a = null;
				break;
			}
			n5.m_b.RemoveAt(num);
			break;
		}
		while (num < n5.m_b.Count);
	}

	public static void e()
	{
		if (n5.m_b.Count > 0)
		{
			n5.m_b.RemoveRange(0, n5.m_b.Count);
		}
	}
}
