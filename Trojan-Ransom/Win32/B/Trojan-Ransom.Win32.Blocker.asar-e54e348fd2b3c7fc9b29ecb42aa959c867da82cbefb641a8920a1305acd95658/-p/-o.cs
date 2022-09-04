using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace _0023p;

internal sealed class _0023o : IDisposable
{
	private readonly Type _0023bE;

	private readonly object _0023cE;

	public _0023o()
	{
		try
		{
			Assembly assembly = Assembly.Load("System.Core, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e");
			_0023bE = assembly.GetType("System.Security.Cryptography.AesManaged");
		}
		catch (FileNotFoundException)
		{
			Assembly assembly = Assembly.Load("mscorlib");
			_0023bE = assembly.GetType("System.Security.Cryptography.RijndaelManaged");
		}
		_0023cE = Activator.CreateInstance(_0023bE);
	}

	public ICryptoTransform _0023l(byte[] P_0, byte[] P_1, bool P_2)
	{
		MethodInfo? setMethod = _0023bE.GetProperty("Key")!.GetSetMethod();
		object obj = _0023cE;
		object[] array = new object[1];
		object[] array2;
		if (7u != 0)
		{
			array2 = array;
		}
		array2[0] = P_0;
		setMethod!.Invoke(obj, array2);
		MethodInfo? setMethod2 = _0023bE.GetProperty("IV")!.GetSetMethod();
		object obj2 = _0023cE;
		object[] array3 = new object[1];
		if (0 == 0)
		{
			array2 = array3;
		}
		array2[0] = P_1;
		setMethod2!.Invoke(obj2, array2);
		MethodInfo? method = _0023bE.GetMethod(P_2 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		MethodInfo methodInfo = default(MethodInfo);
		if (0 == 0)
		{
			methodInfo = method;
		}
		return (ICryptoTransform)methodInfo.Invoke(_0023cE, new object[0]);
	}

	public void _0023m()
	{
		do
		{
			if (true && 0 == 0)
			{
				_0023bE.GetMethod("Clear")!.Invoke(_0023cE, new object[0]);
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
