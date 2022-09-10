using System;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;
using BCYa8HL2abfqj4agEfg;
using EZ0J3PLZ3QIRM9ia6bB;
using EkIJjm7vjs8xMISmTn;
using G5FAcMLb6QN2YUdye0m;
using GuEGrrLPOVFlhi9WZw0;
using NCDRxx4R49CZy0gNBsi;
using Q0ObqKLEPKsj4AfDfmw;
using g4pCthJAI7lShClxyE;
using nsb0bbLhGu42jFo73VA;
using p0eCyYLB4vIGakynHjy;

namespace uHZYbJ4C5TIOCqGMlDX;

internal abstract class h8HG9e4whTrndSAd48i
{
	private static readonly bool jTkHi1X7Ua;

	private static readonly string z8UHdu5dTB;

	private static h8HG9e4whTrndSAd48i psXHw6rYHA;

	private IWebProxy E4JH27CfgA;

	private EventHandler pnNHaZa47y;

	private SaYlOoL7Bj9oMOKT5E5 aSNHGDkJCK;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public void _0001(EventHandler _0020)
	{
		//Discarded unreachable code: IL_0031
		int num = 1;
		EventHandler eventHandler = default(EventHandler);
		EventHandler eventHandler2 = default(EventHandler);
		EventHandler value = default(EventHandler);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if ((object)eventHandler == eventHandler2)
					{
						goto IL_0015;
					}
					goto case 4;
				case 2:
				case 5:
					value = (EventHandler)Delegate.Combine(eventHandler2, _0020);
					goto case 3;
				default:
					num = 3;
					break;
				case 3:
					eventHandler = Interlocked.CompareExchange(ref pnNHaZa47y, value, eventHandler2);
					num = 6;
					break;
				case 0:
				case 1:
					eventHandler = pnNHaZa47y;
					num = 4;
					break;
				case 4:
					eventHandler2 = eventHandler;
					num = 5;
					break;
				case 7:
					return;
				}
				break;
				IL_0015:
				num2 = 7;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public void _0001(SaYlOoL7Bj9oMOKT5E5 _0020)
	{
		//Discarded unreachable code: IL_006e
		int num = 3;
		SaYlOoL7Bj9oMOKT5E5 saYlOoL7Bj9oMOKT5E2 = default(SaYlOoL7Bj9oMOKT5E5);
		SaYlOoL7Bj9oMOKT5E5 saYlOoL7Bj9oMOKT5E = default(SaYlOoL7Bj9oMOKT5E5);
		SaYlOoL7Bj9oMOKT5E5 value = default(SaYlOoL7Bj9oMOKT5E5);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if ((object)saYlOoL7Bj9oMOKT5E2 == saYlOoL7Bj9oMOKT5E)
					{
						num2 = 7;
						continue;
					}
					goto case 1;
				case 1:
					saYlOoL7Bj9oMOKT5E = saYlOoL7Bj9oMOKT5E2;
					num2 = 5;
					continue;
				case 4:
					saYlOoL7Bj9oMOKT5E2 = Interlocked.CompareExchange(ref aSNHGDkJCK, value, saYlOoL7Bj9oMOKT5E);
					num = 6;
					break;
				case 0:
				case 3:
					saYlOoL7Bj9oMOKT5E2 = aSNHGDkJCK;
					num = 1;
					break;
				case 2:
				case 5:
					value = (SaYlOoL7Bj9oMOKT5E5)Delegate.Combine(saYlOoL7Bj9oMOKT5E, _0020);
					goto case 4;
				default:
					num = 4;
					break;
				case 7:
					return;
				}
				break;
			}
		}
	}

	protected abstract void _0001(ufav8DLFhsTMXQxrShP _0020);

	protected abstract void _0001(S81X5LL3ncWCRE1fEEL _0020);

	protected abstract void _0001(XHNlccLKkdARJAPCaJE _0020);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public static void L5rTyeYb6d(object _0020)
	{
		//Discarded unreachable code: IL_0029
		int num = 5;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					AppDomain.CurrentDomain.UnhandledException += YPQTNUkKar;
					goto case 2;
				default:
					goto IL_0057;
				case 0:
				case 5:
					if (_0020 != null)
					{
						num = 4;
						break;
					}
					return;
				case 1:
				case 4:
					psXHw6rYHA = (h8HG9e4whTrndSAd48i)_0020;
					num = 3;
					break;
				case 2:
					Application.add_ThreadException((ThreadExceptionEventHandler)WDpTI1OTD2);
					num = 6;
					break;
				case 6:
					return;
				}
				break;
				IL_0057:
				num2 = 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private static h8HG9e4whTrndSAd48i _0001()
	{
		//Discarded unreachable code: IL_0036, IL_00fe
		int num = 5;
		if (1 == 0)
		{
			goto IL_000c;
		}
		goto IL_010b;
		IL_010b:
		int num2 = default(int);
		Type type = default(Type);
		Type[] types = default(Type[]);
		while (true)
		{
			int num3;
			switch (num)
			{
			case 9:
				break;
			case 0:
				num2 = 0;
				num = 3;
				continue;
			case 1:
				if ((object)type.BaseType == null)
				{
					goto IL_0072;
				}
				num = 7;
				if (true)
				{
					continue;
				}
				goto case 8;
			case 8:
				types = Assembly.GetExecutingAssembly().GetTypes();
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				if (psXHw6rYHA == null)
				{
					num = 8;
					continue;
				}
				goto IL_017c;
			case 6:
			case 7:
				if ((object)type.BaseType != typeof(h8HG9e4whTrndSAd48i))
				{
					goto IL_0072;
				}
				num = 9;
				if (!IogydigKO5JyDefyl9Z())
				{
					continue;
				}
				goto case 4;
			case 4:
			case 10:
				if ((object)type == null)
				{
					goto IL_0072;
				}
				goto case 1;
			default:
				num3 = 1;
				goto IL_0107;
			case 2:
			case 3:
				if (num2 < types.Length)
				{
					type = types[num2];
					num3 = 10;
				}
				else
				{
					num3 = 11;
				}
				goto IL_0107;
			case 11:
				goto IL_017c;
				IL_0107:
				num = num3;
				continue;
			}
			break;
		}
		goto IL_000c;
		IL_017c:
		return psXHw6rYHA;
		IL_000c:
		try
		{
			psXHw6rYHA = (h8HG9e4whTrndSAd48i)Activator.CreateInstance(type, nonPublic: true);
			int num4 = 2;
			while (true)
			{
				switch (num4)
				{
				case 0:
				case 2:
					if (psXHw6rYHA != null)
					{
						goto end_IL_0043;
					}
					goto IL_0072;
				case 1:
				case 3:
					goto end_IL_0043;
				}
				num4 = 3;
				continue;
				end_IL_0043:
				break;
			}
		}
		catch
		{
			goto IL_0072;
		}
		goto IL_017c;
		IL_0072:
		num2++;
		num = 2;
		goto IL_010b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ACeTYFZ9xa(object _0020, object _0020)
	{
		//Discarded unreachable code: IL_0097
		int num = 4;
		if (!pepRqWg1q5Jn0RGq3sq())
		{
			goto IL_0010;
		}
		goto IL_00a4;
		IL_00a4:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				break;
			case 6:
				return;
			case 5:
				goto IL_003d;
			case 7:
				goto IL_0066;
			case 2:
				goto IL_007d;
			default:
				goto IL_00cd;
			case 0:
			case 4:
				goto IL_00db;
			case 8:
				return;
			}
			break;
			IL_00db:
			if (_0020 != null)
			{
				num = 3;
				if (!pepRqWg1q5Jn0RGq3sq())
				{
					return;
				}
				continue;
			}
			goto IL_002a;
			IL_007d:
			if (h8HG9e4whTrndSAd48i._0001().vGJTtFwfh5((SecurityException)_0020))
			{
				return;
			}
			goto IL_002a;
		}
		goto IL_0010;
		IL_00cd:
		int num2 = 6;
		goto IL_00a0;
		IL_003d:
		if (!(z8UHdu5dTB == teuVAA2ghHDQmtOkUp.dYB2ebULO8(46550)))
		{
			goto IL_002a;
		}
		num = 2;
		if (!pepRqWg1q5Jn0RGq3sq())
		{
			goto IL_0066;
		}
		goto IL_00a4;
		IL_0010:
		if (!(_0020 is SecurityException))
		{
			goto IL_002a;
		}
		num2 = 5;
		goto IL_00a0;
		IL_002a:
		pptnOHLG0SvOsuFuFDn.a2lT3DCOgr(_0020, _0020);
		num = 7;
		if (false)
		{
			goto IL_003d;
		}
		goto IL_00a4;
		IL_00a0:
		num = num2;
		goto IL_00a4;
		IL_0066:
		h8HG9e4whTrndSAd48i._0001().aJHTX3py9E((Exception)_0020, _0020: false, _0020: false);
		num = 8;
		goto IL_00a4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WDpTI1OTD2(object _0020, ThreadExceptionEventArgs _0020)
	{
		//Discarded unreachable code: IL_00f8
		try
		{
			Exception ex = _0020.Exception;
			int num = 0;
			Type type = default(Type);
			while (true)
			{
				int num2;
				switch (num)
				{
				case 6:
					if (!vGJTtFwfh5(ex as SecurityException))
					{
						break;
					}
					num = 9;
					if (!IogydigKO5JyDefyl9Z())
					{
						continue;
					}
					goto case 1;
				case 1:
					if (!(z8UHdu5dTB == teuVAA2ghHDQmtOkUp.dYB2ebULO8(46550)))
					{
						break;
					}
					num2 = 6;
					goto IL_0101;
				case 0:
					type = ex.GetType();
					num2 = 2;
					goto IL_0101;
				case 7:
					if (!(type.Namespace == teuVAA2ghHDQmtOkUp.dYB2ebULO8(48487)))
					{
						goto case 4;
					}
					num2 = 8;
					goto IL_0101;
				case 4:
				case 5:
					if (!(ex is SecurityException))
					{
						break;
					}
					num2 = 1;
					goto IL_0101;
				case 2:
					if (!(type.Name == teuVAA2ghHDQmtOkUp.dYB2ebULO8(48462)))
					{
						goto case 4;
					}
					num2 = 7;
					goto IL_0101;
				case 3:
				case 8:
					ex = (Exception)type.GetField(teuVAA2ghHDQmtOkUp.dYB2ebULO8(48532))!.GetValue(ex);
					goto case 4;
				default:
					num2 = 5;
					goto IL_0101;
				case 9:
					return;
					IL_0101:
					num = num2;
					continue;
				}
				break;
			}
			aJHTX3py9E(ex, _0020: true, _0020: false);
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void YPQTNUkKar(object _0020, UnhandledExceptionEventArgs _0020)
	{
		//Discarded unreachable code: IL_005c
		try
		{
			if (!(_0020.ExceptionObject is SecurityException))
			{
				goto IL_0023;
			}
			int num = 0;
			goto IL_0065;
			IL_0065:
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
					case 3:
						return;
					case 1:
					case 4:
						if (vGJTtFwfh5(_0020.ExceptionObject as SecurityException))
						{
							return;
						}
						break;
					default:
						num2 = 3;
						if (0 == 0)
						{
							continue;
						}
						goto case 0;
					case 0:
						if (!(z8UHdu5dTB == teuVAA2ghHDQmtOkUp.dYB2ebULO8(46550)))
						{
							break;
						}
						goto end_IL_0069;
					case 5:
						aJHTX3py9E((Exception)_0020.ExceptionObject, !_0020.IsTerminating, _0020: false);
						return;
					}
					goto end_IL_0065;
					continue;
					end_IL_0069:
					break;
				}
				num = 4;
				continue;
				end_IL_0065:
				break;
			}
			goto IL_0023;
			IL_0023:
			if (_0020.ExceptionObject is Exception)
			{
				num = 5;
				goto IL_0065;
			}
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual Guid _0001()
	{
		return Guid.Empty;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool vGJTtFwfh5(SecurityException _0020)
	{
		//Discarded unreachable code: IL_001e
		int num = 2;
		XHNlccLKkdARJAPCaJE xHNlccLKkdARJAPCaJE = default(XHNlccLKkdARJAPCaJE);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (xHNlccLKkdARJAPCaJE._0003())
					{
						goto case 3;
					}
					if (!xHNlccLKkdARJAPCaJE._0002())
					{
						num2 = 1;
						continue;
					}
					break;
				default:
					num2 = 6;
					continue;
				case 1:
					Application.Exit();
					num2 = 7;
					continue;
				case 0:
				case 2:
					goto end_IL_002b;
				case 4:
					_0001(xHNlccLKkdARJAPCaJE);
					num2 = 5;
					if (true)
					{
						continue;
					}
					goto case 3;
				case 3:
				case 6:
					return false;
				case 7:
					break;
				}
				return true;
				continue;
				end_IL_002b:
				break;
			}
			xHNlccLKkdARJAPCaJE = new XHNlccLKkdARJAPCaJE(_0020);
			num = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void aJHTX3py9E(Exception _0020, bool _0020, bool _0020)
	{
		//Discarded unreachable code: IL_0180, IL_028e
		int num = 1;
		Assembly[] assemblies = default(Assembly[]);
		bool flag = default(bool);
		Type type = default(Type);
		Assembly assembly = default(Assembly);
		object obj3 = default(object);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					return;
				case 9:
					assemblies = AppDomain.CurrentDomain.GetAssemblies();
					num = 3;
					break;
				case 8:
					flag = true;
					num = 14;
					break;
				case 1:
					type = _0020.GetType();
					num2 = 13;
					if (pepRqWg1q5Jn0RGq3sq())
					{
						continue;
					}
					goto case 11;
				case 11:
					try
					{
						string fullName = assembly.FullName;
						int num4 = 4;
						while (true)
						{
							switch (num4)
							{
							case 0:
							case 4:
								if (fullName.EndsWith(teuVAA2ghHDQmtOkUp.dYB2ebULO8(48557)))
								{
									num4 = 1;
									if (!IogydigKO5JyDefyl9Z())
									{
										continue;
									}
									goto case 1;
								}
								break;
							case 1:
								if (fullName.StartsWith(teuVAA2ghHDQmtOkUp.dYB2ebULO8(48582)))
								{
									goto case 2;
								}
								break;
							default:
								num4 = 3;
								continue;
							case 2:
							case 3:
								obj3 = assembly.GetType(teuVAA2ghHDQmtOkUp.dYB2ebULO8(48615))!.GetProperty(teuVAA2ghHDQmtOkUp.dYB2ebULO8(48652))!.GetGetMethod()!.Invoke(null, null);
								num4 = 5;
								continue;
							case 5:
								obj3.GetType().GetMethod(teuVAA2ghHDQmtOkUp.dYB2ebULO8(48665), new Type[0])!.Invoke(obj3, null);
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3++;
					num2 = 4;
					if (true)
					{
						continue;
					}
					goto case 4;
				case 4:
				case 10:
				case 12:
					if (num3 >= assemblies.Length)
					{
						num = 15;
						break;
					}
					assembly = assemblies[num3];
					num = 11;
					break;
				case 3:
					num3 = 0;
					num = 10;
					break;
				case 2:
				case 6:
					if (!(type.Namespace == teuVAA2ghHDQmtOkUp.dYB2ebULO8(48487)))
					{
						goto case 8;
					}
					num2 = 0;
					if (0 == 0)
					{
						continue;
					}
					goto case 5;
				case 5:
					if (_0020 is ThreadAbortException)
					{
						return;
					}
					try
					{
						hthXNZLToLKoPYC9UNI hthXNZLToLKoPYC9UNI = new hthXNZLToLKoPYC9UNI(this._0001(), _0020, E4JH27CfgA);
						hthXNZLToLKoPYC9UNI._0001(rSjTzp7BVT);
						hthXNZLToLKoPYC9UNI._0001((EventHandler)eHFTg2iaeR);
						hthXNZLToLKoPYC9UNI._0001(eE4TRu6kBr);
						ufav8DLFhsTMXQxrShP ufav8DLFhsTMXQxrShP = new ufav8DLFhsTMXQxrShP(hthXNZLToLKoPYC9UNI, _0020);
						if (wV82w1bQF7p1eI0i9A.p1E214wQcv() != null)
						{
							ufav8DLFhsTMXQxrShP.WOUk6OjDgm();
						}
						if (!_0020)
						{
							ufav8DLFhsTMXQxrShP.EOBk9TXaVb(_0020: false);
							ufav8DLFhsTMXQxrShP._0002(_0020: false);
						}
						else if (_0020 || jTkHi1X7Ua)
						{
							ufav8DLFhsTMXQxrShP.EOBk9TXaVb(_0020: false);
							ufav8DLFhsTMXQxrShP._0002(_0020: true);
						}
						_0001(ufav8DLFhsTMXQxrShP);
						flag = !ufav8DLFhsTMXQxrShP._0004();
					}
					catch (ThreadAbortException)
					{
					}
					catch (Exception ex2)
					{
						_0001(new S81X5LL3ncWCRE1fEEL(ex2));
					}
					if (flag)
					{
						num = 9;
						break;
					}
					return;
				default:
					num = 7;
					break;
				case 14:
					if (_0020 == null)
					{
						return;
					}
					num2 = 5;
					if (true)
					{
						continue;
					}
					goto case 0;
				case 0:
					_0020 = (Exception)type.GetField(teuVAA2ghHDQmtOkUp.dYB2ebULO8(48532))!.GetValue(_0020);
					num2 = 8;
					continue;
				case 13:
					if (!(type.Name == teuVAA2ghHDQmtOkUp.dYB2ebULO8(48462)))
					{
						goto case 8;
					}
					num2 = 6;
					if (pepRqWg1q5Jn0RGq3sq())
					{
						continue;
					}
					goto case 15;
				case 15:
					try
					{
						Application.Exit();
						return;
					}
					catch
					{
						try
						{
							Environment.Exit(0);
							return;
						}
						catch
						{
							return;
						}
					}
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void eE4TRu6kBr(object _0020, S81X5LL3ncWCRE1fEEL _0020)
	{
		_0001(_0020);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void eHFTg2iaeR(object _0020, EventArgs _0020)
	{
		//Discarded unreachable code: IL_0015
		int num = 2;
		EventHandler eventHandler = default(EventHandler);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				if (eventHandler != null)
				{
					goto case 3;
				}
				return;
			default:
			{
				int num2 = 3;
				num = num2;
				break;
			}
			case 0:
			case 2:
				eventHandler = pnNHaZa47y;
				num = 4;
				break;
			case 3:
				eventHandler(_0020, _0020);
				num = 5;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rSjTzp7BVT(object _0020, TAp6tRL899wehtNORw3 _0020)
	{
		//Discarded unreachable code: IL_002f
		int num = 2;
		SaYlOoL7Bj9oMOKT5E5 saYlOoL7Bj9oMOKT5E = default(SaYlOoL7Bj9oMOKT5E5);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					saYlOoL7Bj9oMOKT5E(_0020, _0020);
					num = 5;
					break;
				case 1:
				case 4:
					if (saYlOoL7Bj9oMOKT5E != null)
					{
						goto case 3;
					}
					return;
				default:
					num2 = 3;
					if (pepRqWg1q5Jn0RGq3sq())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 2:
					saYlOoL7Bj9oMOKT5E = aSNHGDkJCK;
					num = 4;
					break;
				case 5:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected h8HG9e4whTrndSAd48i()
	{
		QA1I51451Fm9FyPCw1q.nLTn9WFXoXK9o();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static h8HG9e4whTrndSAd48i()
	{
		//Discarded unreachable code: IL_003c
		int num = 1;
		if (!IogydigKO5JyDefyl9Z())
		{
		}
		do
		{
			IL_0049:
			switch (num)
			{
			case 0:
			case 1:
				QA1I51451Fm9FyPCw1q.nLTn9WFXoXK9o();
				num = 3;
				goto IL_0049;
			case 3:
				jTkHi1X7Ua = Convert.ToBoolean(teuVAA2ghHDQmtOkUp.dYB2ebULO8(48678));
				break;
			default:
			{
				int num2 = 4;
				num = num2;
				goto IL_0049;
			}
			case 2:
			case 4:
				break;
			case 5:
				return;
			}
			z8UHdu5dTB = teuVAA2ghHDQmtOkUp.dYB2ebULO8(46550);
			num = 5;
		}
		while (true);
	}

	internal static bool pepRqWg1q5Jn0RGq3sq()
	{
		return true;
	}

	internal static bool IogydigKO5JyDefyl9Z()
	{
		return false;
	}
}
