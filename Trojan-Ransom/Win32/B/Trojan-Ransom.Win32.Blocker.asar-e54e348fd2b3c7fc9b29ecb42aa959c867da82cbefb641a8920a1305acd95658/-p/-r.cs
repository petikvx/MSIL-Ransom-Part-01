using System;
using System.Reflection;
using System.Security.Cryptography;

namespace _0023p;

internal sealed class _0023r : IDisposable
{
	private readonly Type _0023dE;

	private readonly object _0023eE;

	public _0023r()
	{
		Assembly assembly = Assembly.Load("mscorlib");
		_0023dE = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
		_0023eE = Activator.CreateInstance(_0023dE);
	}

	public ICryptoTransform _0023q(byte[] P_0, byte[] P_1, bool P_2)
	{
		MethodInfo? setMethod = _0023dE.GetProperty("Key")!.GetSetMethod();
		object obj = _0023eE;
		object[] array = new object[1];
		object[] array2;
		if (7u != 0)
		{
			array2 = array;
		}
		array2[0] = P_0;
		setMethod!.Invoke(obj, array2);
		MethodInfo? setMethod2 = _0023dE.GetProperty("IV")!.GetSetMethod();
		object obj2 = _0023eE;
		object[] array3 = new object[1];
		if (0 == 0)
		{
			array2 = array3;
		}
		array2[0] = P_1;
		setMethod2!.Invoke(obj2, array2);
		MethodInfo? method = _0023dE.GetMethod(P_2 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		MethodInfo methodInfo = default(MethodInfo);
		if (0 == 0)
		{
			methodInfo = method;
		}
		return (ICryptoTransform)methodInfo.Invoke(_0023eE, new object[0]);
	}

	public void _0023m()
	{
		do
		{
			if (true && 0 == 0)
			{
				_0023dE.GetMethod("Clear")!.Invoke(_0023eE, new object[0]);
			}
		}
		while (false);
	}

	public void _0023n()
	{
		if (6u != 0)
		{
			_0023m();
		}
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in #n
		this._0023n();
	}
}
