using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using NCDRxx4R49CZy0gNBsi;
using Q0ObqKLEPKsj4AfDfmw;

namespace NTt8ZmzoU8FL0ZvuPp;

internal sealed class vhyRaKEngUZmrB24mE : IDisposable
{
	private readonly Type pVv2It60Th;

	private readonly object EQk2NyStPL;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public vhyRaKEngUZmrB24mE()
	{
		//Discarded unreachable code: IL_0019, IL_0089
		int num = 3;
		Assembly assembly = default(Assembly);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 1:
				case 2:
					base._002Ector();
					break;
				default:
					goto IL_003f;
				case 0:
				case 3:
					goto end_IL_0026;
				case 4:
					break;
				}
				try
				{
					assembly = Assembly.Load("mscorlib");
					int num3 = 2;
					while (true)
					{
						switch (num3)
						{
						case 0:
						case 2:
							pVv2It60Th = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
							break;
						default:
							num3 = 3;
							if (NhOnjns4r2oOE8gp8PY())
							{
							}
							continue;
						case 1:
						case 3:
							break;
						}
						break;
					}
					EQk2NyStPL = Activator.CreateInstance(pVv2It60Th);
					return;
				}
				catch (Exception ex)
				{
					pptnOHLG0SvOsuFuFDn.v3OTTS85dg(ex, assembly, this);
					throw;
				}
				IL_003f:
				num2 = 4;
				continue;
				end_IL_0026:
				break;
			}
			while (0 == 0);
			QA1I51451Fm9FyPCw1q.nLTn9WFXoXK9o();
			num = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ICryptoTransform lcT2yjfatu(byte[] _0020, byte[] _0020, bool _0020)
	{
		//Discarded unreachable code: IL_006d
		object[] array = default(object[]);
		MethodInfo method = default(MethodInfo);
		try
		{
			MethodInfo? setMethod = pVv2It60Th.GetProperty("Key")!.GetSetMethod();
			object eQk2NyStPL = EQk2NyStPL;
			array = new object[1] { _0020 };
			setMethod!.Invoke(eQk2NyStPL, array);
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 3:
				{
					MethodInfo? setMethod2 = pVv2It60Th.GetProperty("IV")!.GetSetMethod();
					object eQk2NyStPL2 = EQk2NyStPL;
					array = new object[1] { _0020 };
					setMethod2!.Invoke(eQk2NyStPL2, array);
					goto case 1;
				}
				default:
					num2 = 2;
					if (iKsAZ8sDdukktPApGv8())
					{
						continue;
					}
					goto case 1;
				case 1:
				case 2:
					method = pVv2It60Th.GetMethod(_0020 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
					num2 = 4;
					if (iKsAZ8sDdukktPApGv8())
					{
						continue;
					}
					break;
				case 4:
					break;
				}
				break;
			}
			return (ICryptoTransform)method.Invoke(EQk2NyStPL, new object[0]);
		}
		catch (Exception ex)
		{
			pptnOHLG0SvOsuFuFDn.aEyTuSifpr(ex, method, array, this, _0020, _0020, _0020);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void rKV2Y110cR()
	{
		try
		{
			pVv2It60Th.GetMethod("Clear")!.Invoke(EQk2NyStPL, new object[0]);
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
			rKV2Y110cR();
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

	internal static bool iKsAZ8sDdukktPApGv8()
	{
		return true;
	}

	internal static bool NhOnjns4r2oOE8gp8PY()
	{
		return false;
	}
}
