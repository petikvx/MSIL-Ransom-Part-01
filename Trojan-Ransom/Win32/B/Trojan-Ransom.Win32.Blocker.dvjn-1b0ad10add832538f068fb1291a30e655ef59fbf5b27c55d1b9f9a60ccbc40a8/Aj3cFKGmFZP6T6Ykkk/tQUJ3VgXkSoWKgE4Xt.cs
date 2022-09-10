using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using NCDRxx4R49CZy0gNBsi;
using Q0ObqKLEPKsj4AfDfmw;

namespace Aj3cFKGmFZP6T6Ykkk;

internal sealed class tQUJ3VgXkSoWKgE4Xt : IDisposable
{
	private readonly Type md52K5U4Ik;

	private readonly object wMm2h8BmSD;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public tQUJ3VgXkSoWKgE4Xt()
	{
		//Discarded unreachable code: IL_001b
		int num = 3;
		if (OYViC9sfF46vy9vnBIc())
		{
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					break;
				default:
					num = 4;
					if (OYViC9sfF46vy9vnBIc())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 3:
					QA1I51451Fm9FyPCw1q.nLTn9WFXoXK9o();
					num = 2;
					if (0 == 0)
					{
						continue;
					}
					goto IL_0062;
				case 4:
					goto IL_0062;
				}
				break;
			}
		}
		base._002Ector();
		goto IL_0062;
		IL_0062:
		Assembly assembly = default(Assembly);
		try
		{
			try
			{
				assembly = Assembly.Load("System.Core, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e");
				md52K5U4Ik = assembly.GetType("System.Security.Cryptography.AesManaged");
			}
			catch (FileNotFoundException)
			{
				assembly = Assembly.Load("mscorlib");
				md52K5U4Ik = assembly.GetType("System.Security.Cryptography.RijndaelManaged");
			}
			wMm2h8BmSD = Activator.CreateInstance(md52K5U4Ik);
		}
		catch (Exception ex2)
		{
			pptnOHLG0SvOsuFuFDn.v3OTTS85dg(ex2, assembly, this);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ICryptoTransform WGK2qfd1ro(byte[] _0020, byte[] _0020, bool _0020)
	{
		//Discarded unreachable code: IL_006d
		object[] array = default(object[]);
		MethodInfo method = default(MethodInfo);
		try
		{
			MethodInfo? setMethod = md52K5U4Ik.GetProperty("Key")!.GetSetMethod();
			object obj = wMm2h8BmSD;
			array = new object[1] { _0020 };
			setMethod!.Invoke(obj, array);
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
				{
					MethodInfo? setMethod2 = md52K5U4Ik.GetProperty("IV")!.GetSetMethod();
					object obj2 = wMm2h8BmSD;
					array = new object[1] { _0020 };
					setMethod2!.Invoke(obj2, array);
					goto case 1;
				}
				default:
					num = 3;
					break;
				case 1:
				case 3:
					method = md52K5U4Ik.GetMethod(_0020 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
					num = 4;
					break;
				case 4:
					return (ICryptoTransform)method.Invoke(wMm2h8BmSD, new object[0]);
				}
			}
		}
		catch (Exception ex)
		{
			pptnOHLG0SvOsuFuFDn.aEyTuSifpr(ex, method, array, this, _0020, _0020, _0020);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void QXV2fL5RNo()
	{
		try
		{
			md52K5U4Ik.GetMethod("Clear")!.Invoke(wMm2h8BmSD, new object[0]);
		}
		catch (Exception ex)
		{
			pptnOHLG0SvOsuFuFDn.n3tTkGgocg(ex, this);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void _0002()
	{
		try
		{
			QXV2fL5RNo();
		}
		catch (Exception ex)
		{
			pptnOHLG0SvOsuFuFDn.n3tTkGgocg(ex, this);
			throw;
		}
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in 
		this._0002();
	}

	internal static bool OYViC9sfF46vy9vnBIc()
	{
		return true;
	}

	internal static bool dKYIPrscSaHDHnfrXbh()
	{
		return false;
	}
}
