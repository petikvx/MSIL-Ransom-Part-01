using System;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;
using e1t9ZoIMs7pU1MfVBaV;
using e2cH6FILktsbyFFI1uq;
using eC98jAqdnPLlDITmK6;
using eWKhPTIDxmZsqdLNArt;
using eZQK2xBlyBqnDmcNvU;
using eeByhaIKPr900aLxc7f;
using egnk0MIElNL8kAFlapv;
using ejM8dIIvmS9DlgyHhy5;
using en2xdaIAyYAR3V5SvTl;
using epkjfPIj6K54YkG3g46;
using etKNQTu9kgqwCqmIAv;
using eyy3tUI8TOjdQqicT9X;

namespace elcQckIkwD1ilZSE11w;

internal abstract class e8MHalImLVkLOnUn6dG
{
	private static readonly bool eb1x595Bx;

	private static readonly string ep2oBURlk;

	private static e8MHalImLVkLOnUn6dG eSmVD9nBi;

	private IWebProxy ePK4VF7eF;

	private EventHandler eirmvo2dG;

	private eCK5bGIBSHNlxdKcSIv e1EtMsxWy;

	[NonSerialized]
	internal static eDHHd4vO3FpvmheVMk eZF2o0o9A;

	[SpecialName]
	public void method_0(EventHandler eventHandler_0)
	{
		eFpAdFYyIUr9MUIZ05P();
		EventHandler eventHandler = default(EventHandler);
		if (!eeRporYMXveF4pbHq11())
		{
			eventHandler = eirmvo2dG;
		}
		else if (!eeRporYMXveF4pbHq11())
		{
			goto IL_001e;
		}
		goto IL_003f;
		IL_003f:
		EventHandler eventHandler2 = eventHandler;
		goto IL_001e;
		IL_001e:
		EventHandler value = (EventHandler)ej15gKYumm0uMcy35TF(eventHandler2, eventHandler_0);
		eventHandler = Interlocked.CompareExchange(ref eirmvo2dG, value, eventHandler2);
		if ((object)eventHandler == eventHandler2)
		{
			return;
		}
		goto IL_003f;
	}

	[SpecialName]
	public void method_1(eCK5bGIBSHNlxdKcSIv eCK5bGIBSHNlxdKcSIv_0)
	{
		eCK5bGIBSHNlxdKcSIv eCK5bGIBSHNlxdKcSIv = e1EtMsxWy;
		eCK5bGIBSHNlxdKcSIv eCK5bGIBSHNlxdKcSIv2 = default(eCK5bGIBSHNlxdKcSIv);
		do
		{
			eeRporYMXveF4pbHq11();
			if (eFpAdFYyIUr9MUIZ05P())
			{
				eCK5bGIBSHNlxdKcSIv2 = eCK5bGIBSHNlxdKcSIv;
			}
			eCK5bGIBSHNlxdKcSIv value = (eCK5bGIBSHNlxdKcSIv)ej15gKYumm0uMcy35TF(eCK5bGIBSHNlxdKcSIv2, eCK5bGIBSHNlxdKcSIv_0);
			eCK5bGIBSHNlxdKcSIv = Interlocked.CompareExchange(ref e1EtMsxWy, value, eCK5bGIBSHNlxdKcSIv2);
		}
		while ((object)eCK5bGIBSHNlxdKcSIv != eCK5bGIBSHNlxdKcSIv2);
	}

	protected abstract void ep20ZBURlk(eSKhENIYtua9ZT9uY47 eSKhENIYtua9ZT9uY47_0);

	protected abstract void ep20ZBURlk(ep0T6KI2Qw8SOuAhViY ep0T6KI2Qw8SOuAhViY_0);

	protected abstract void ep20ZBURlk(exgdQiIHW0NaSpp0mcE exgdQiIHW0NaSpp0mcE_0);

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public static void eulODlten(e8MHalImLVkLOnUn6dG e8MHalImLVkLOnUn6dG_0)
	{
		int num = 6;
		while (true)
		{
			IL_006a:
			num = 7;
			if (eFpAdFYyIUr9MUIZ05P())
			{
				while (true)
				{
					if (e8MHalImLVkLOnUn6dG_0 == null)
					{
						return;
					}
					_ = 1;
					if (!eeRporYMXveF4pbHq11())
					{
						break;
					}
					num = 5;
					if (eeRporYMXveF4pbHq11())
					{
						goto end_IL_006a;
					}
					while (true)
					{
						switch (num)
						{
						default:
							num = 4;
							if (eFpAdFYyIUr9MUIZ05P())
							{
								continue;
							}
							break;
						case 7:
							break;
						case 6:
							goto IL_006a;
						case 1:
						case 2:
						case 3:
						case 5:
							goto end_IL_0065;
						case 4:
							goto IL_0083;
						case 0:
							goto end_IL_006a;
						case 8:
							return;
						}
						break;
					}
					continue;
					end_IL_0065:
					break;
				}
			}
			eSmVD9nBi = e8MHalImLVkLOnUn6dG_0;
			goto IL_0083;
			IL_0083:
			eXPKrVYS0Fb41mEyy01(eY5pLEYbPvOLoCObuki(), new UnhandledExceptionEventHandler(e8MHalImLVkLOnUn6dG_0.eeN1kpseb));
			break;
			continue;
			end_IL_006a:
			break;
		}
		e5DRWRYDkCgVNRbeFme(new ThreadExceptionEventHandler(e8MHalImLVkLOnUn6dG_0.e9jslfSvk));
	}

	[SpecialName]
	private static e8MHalImLVkLOnUn6dG smethod_0()
	{
		Type[] array = default(Type[]);
		int num = default(int);
		if (eSmVD9nBi == null)
		{
			if (eeRporYMXveF4pbHq11())
			{
				goto IL_001d;
			}
			array = (Type[])eEb92jY88bWTAopP7Js(eMRpKcYvnRbUOMrj0BG());
			num = 0;
			goto IL_0027;
		}
		goto IL_007e;
		IL_007e:
		return eSmVD9nBi;
		IL_0078:
		num++;
		goto IL_0027;
		IL_001d:
		Type type = default(Type);
		if ((object)type.BaseType != null && (object)type.BaseType == eDQbdnYwPkdgRfIveEc(typeof(e8MHalImLVkLOnUn6dG).TypeHandle))
		{
			try
			{
				eeRporYMXveF4pbHq11();
				if (eFpAdFYyIUr9MUIZ05P())
				{
					eSmVD9nBi = (e8MHalImLVkLOnUn6dG)e8CrIZY4VLa5LgIKNcG(type, bool_0: true);
				}
				if (eSmVD9nBi != null)
				{
					goto IL_007e;
				}
			}
			catch
			{
			}
		}
		goto IL_0078;
		IL_0027:
		if (num < array.Length)
		{
			type = array[num];
			if ((object)type != null)
			{
				goto IL_001d;
			}
			goto IL_0078;
		}
		goto IL_007e;
	}

	public static void ecs0D1Zdd(Exception exception_0, object[] object_0)
	{
		eFpAdFYyIUr9MUIZ05P();
		if (!eeRporYMXveF4pbHq11())
		{
			if (exception_0 == null || !(exception_0 is SecurityException))
			{
				goto IL_0050;
			}
		}
		else if (eeRporYMXveF4pbHq11())
		{
			return;
		}
		if (eGmlR5YpbcOa1vs9fjR(ep2oBURlk, eZF2o0o9A(23262)) && er6gM3YTtRFVmuoeFmt(egP1egYVxD78VMUm5iK(), (SecurityException)exception_0))
		{
			return;
		}
		goto IL_0050;
		IL_0050:
		eyFNLrYGdl0RaAZO4WQ(exception_0, object_0);
		e8kvXqYtQUGNNcjSbGs(egP1egYVxD78VMUm5iK(), exception_0, bool_0: false, bool_1: false);
	}

	private void e9jslfSvk(object sender, ThreadExceptionEventArgs e)
	{
		try
		{
			Exception ex = (Exception)efhmJEY1p2UHnB3esYr(e);
			Type type = eEfanXYRjPxmh7qLWk6(ex);
			if (eGmlR5YpbcOa1vs9fjR(eJmg47YqvCoQSuGLuGT(type), eZF2o0o9A(25192)) && eGmlR5YpbcOa1vs9fjR(type.Namespace, eZF2o0o9A(25217)))
			{
				ex = (Exception)eh4XhmYO45Fj1fQBd34(type.GetField(eZF2o0o9A(25262)), ex);
			}
			if (!(ex is SecurityException) || !eGmlR5YpbcOa1vs9fjR(ep2oBURlk, eZF2o0o9A(23262)) || !elN6Gg9Qb(ex as SecurityException))
			{
				eKyrTQhVp(ex, bool_0: true, bool_1: false);
			}
		}
		catch
		{
		}
	}

	private void eeN1kpseb(object sender, UnhandledExceptionEventArgs e)
	{
		try
		{
			eeRporYMXveF4pbHq11();
			if (eFpAdFYyIUr9MUIZ05P())
			{
				if (!(eCujZfY35pgQ8yULplx(e) is SecurityException))
				{
					goto IL_0055;
				}
			}
			else if (eeRporYMXveF4pbHq11())
			{
			}
			if (eGmlR5YpbcOa1vs9fjR(ep2oBURlk, eZF2o0o9A(23262)) && elN6Gg9Qb(eCujZfY35pgQ8yULplx(e) as SecurityException))
			{
				return;
			}
			goto IL_0055;
			IL_0055:
			if (eCujZfY35pgQ8yULplx(e) is Exception)
			{
				eKyrTQhVp((Exception)eCujZfY35pgQ8yULplx(e), !e8ws8SYFmGYvJfg1L7O(e), bool_1: false);
			}
		}
		catch
		{
		}
	}

	protected virtual Guid ep20ZBURlk()
	{
		return Guid.Empty;
	}

	private bool elN6Gg9Qb(SecurityException securityException_0)
	{
		exgdQiIHW0NaSpp0mcE exgdQiIHW0NaSpp0mcE = default(exgdQiIHW0NaSpp0mcE);
		if (eFpAdFYyIUr9MUIZ05P())
		{
			exgdQiIHW0NaSpp0mcE = new exgdQiIHW0NaSpp0mcE(securityException_0);
			emYKgEYsyZBgs5jZr0D(this, exgdQiIHW0NaSpp0mcE);
		}
		if (ejtytvYewXwRwN9Y7yX(exgdQiIHW0NaSpp0mcE))
		{
			return false;
		}
		eFpAdFYyIUr9MUIZ05P();
		if (!eeRporYMXveF4pbHq11() && !e9H1wdYKuaFMU6p2Bg8(exgdQiIHW0NaSpp0mcE))
		{
			ewt0VaYIpgeYc1wyPFA();
		}
		return true;
	}

	private void eKyrTQhVp(Exception exception_0, bool bool_0, bool bool_1)
	{
		Type type = eEfanXYRjPxmh7qLWk6(exception_0);
		if (eGmlR5YpbcOa1vs9fjR(eJmg47YqvCoQSuGLuGT(type), eZF2o0o9A(25192)) && eFpAdFYyIUr9MUIZ05P() && eGmlR5YpbcOa1vs9fjR(type.Namespace, eZF2o0o9A(25217)))
		{
			_ = 1;
			if (eeRporYMXveF4pbHq11())
			{
				goto IL_007f;
			}
			exception_0 = (Exception)eh4XhmYO45Fj1fQBd34(type.GetField(eZF2o0o9A(25262)), exception_0);
		}
		bool flag = true;
		if (exception_0 == null)
		{
			return;
		}
		goto IL_007f;
		IL_007f:
		if (exception_0 is ThreadAbortException)
		{
			return;
		}
		try
		{
			ehlurTITCIsVDna2cPM ehlurTITCIsVDna2cPM = new ehlurTITCIsVDna2cPM(eqi8JOY08QPvjNSR9kf(this), exception_0, ePK4VF7eF);
			enN05oYlc6ZACVZBnpV(ehlurTITCIsVDna2cPM, new eCK5bGIBSHNlxdKcSIv(e8AuvEGCG));
			eIn3alYNHYUmXmhofMF(ehlurTITCIsVDna2cPM, new EventHandler(eo2Gig6Qf));
			eqpc4vYhtlyq0xPEKwL(ehlurTITCIsVDna2cPM, new e0PjuKI5UdQoJ3avxe1(euXHswL8F));
			eSKhENIYtua9ZT9uY47 eSKhENIYtua9ZT9uY = new eSKhENIYtua9ZT9uY47(ehlurTITCIsVDna2cPM, exception_0);
			if (eYosmWYAFTcy2f8asir() != null)
			{
				eXaP6JYB5giVIQwf2pb(eSKhENIYtua9ZT9uY);
			}
			if (!bool_0)
			{
				exyx5fYHdDcmOm1t4ql(eSKhENIYtua9ZT9uY, bool_0: false);
				eRPRAqYWrpZxpQajiTC(eSKhENIYtua9ZT9uY, bool_0: false);
			}
			else if (bool_1 || eb1x595Bx)
			{
				exyx5fYHdDcmOm1t4ql(eSKhENIYtua9ZT9uY, bool_0: false);
				eRPRAqYWrpZxpQajiTC(eSKhENIYtua9ZT9uY, bool_0: true);
			}
			e3KQkBYcZkuV1i5iOOE(this, eSKhENIYtua9ZT9uY);
			flag = !eFwohdYUtX4USj4oI2S(eSKhENIYtua9ZT9uY);
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception exception_)
		{
			eoocAhYro06ZE4u2Sw1(this, new ep0T6KI2Qw8SOuAhViY(exception_));
		}
		if (!flag)
		{
			return;
		}
		Assembly[] array = (Assembly[])e6TVVmYnShUa91eBPUC(eY5pLEYbPvOLoCObuki());
		object obj = default(object);
		foreach (Assembly object_ in array)
		{
			try
			{
				string object_2 = (string)eCSlmAYP6U6hwlbC2h2(object_);
				eFpAdFYyIUr9MUIZ05P();
				if (!eeRporYMXveF4pbHq11())
				{
					if (ehuY9UYmyFatPJyQKSN(object_2, eZF2o0o9A(25287)))
					{
						goto IL_01a4;
					}
					continue;
				}
				if (eFpAdFYyIUr9MUIZ05P())
				{
					goto IL_01a4;
				}
				goto IL_01f1;
				IL_01a4:
				if (eEGh12YxeFXl018SRL2(object_2, eZF2o0o9A(25312)))
				{
					obj = e2AZjyf9cwUYDj5ED92(eZsxDuf7bPRh3oXA2bO(eJ2CVIYz9VNnAFYuD8i(object_, eZF2o0o9A(25345)).GetProperty(eZF2o0o9A(25382))), null, null);
					goto IL_01f1;
				}
				goto end_IL_016f;
				IL_01f1:
				e2AZjyf9cwUYDj5ED92(obj.GetType().GetMethod(eZF2o0o9A(25395), new Type[0]), obj, null);
				end_IL_016f:;
			}
			catch
			{
			}
		}
		try
		{
			ewt0VaYIpgeYc1wyPFA();
		}
		catch
		{
			try
			{
				ew0yK6fk3LSU308xo35(0);
			}
			catch
			{
			}
		}
	}

	private void euXHswL8F(object object_0, ep0T6KI2Qw8SOuAhViY ep0T6KI2Qw8SOuAhViY_0)
	{
		eoocAhYro06ZE4u2Sw1(this, ep0T6KI2Qw8SOuAhViY_0);
	}

	private void eo2Gig6Qf(object sender, EventArgs e)
	{
		eFpAdFYyIUr9MUIZ05P();
		EventHandler eventHandler = default(EventHandler);
		if (!eeRporYMXveF4pbHq11())
		{
			eventHandler = eirmvo2dG;
			if (eventHandler == null)
			{
				return;
			}
		}
		eTniynfQMNqfSQf1KAC(eventHandler, sender, e);
	}

	private void e8AuvEGCG(object object_0, e5QKijIZd7liuYOwuT0 e5QKijIZd7liuYOwuT0_0)
	{
		eeRporYMXveF4pbHq11();
		eCK5bGIBSHNlxdKcSIv eCK5bGIBSHNlxdKcSIv = default(eCK5bGIBSHNlxdKcSIv);
		if (eFpAdFYyIUr9MUIZ05P())
		{
			eCK5bGIBSHNlxdKcSIv = e1EtMsxWy;
		}
		if (eCK5bGIBSHNlxdKcSIv != null)
		{
			em09y6fLmBJ8YAuqFug(eCK5bGIBSHNlxdKcSIv, object_0, e5QKijIZd7liuYOwuT0_0);
		}
	}

	protected e8MHalImLVkLOnUn6dG()
	{
		eH4uLOfJtBkQSOkUECk(this);
	}

	static e8MHalImLVkLOnUn6dG()
	{
		eeePmbf5j8RQLVVURma(eDQbdnYwPkdgRfIveEc(typeof(e8MHalImLVkLOnUn6dG).TypeHandle));
		eb1x595Bx = efV5infjY8lkdOxWpTk(eZF2o0o9A(25408));
		ep2oBURlk = eZF2o0o9A(23262);
	}

	internal static object ej15gKYumm0uMcy35TF(object object_0, object object_1)
	{
		return Delegate.Combine((Delegate?)object_0, (Delegate?)object_1);
	}

	internal static bool eFpAdFYyIUr9MUIZ05P()
	{
		return true;
	}

	internal static bool eeRporYMXveF4pbHq11()
	{
		return false;
	}

	internal static object eY5pLEYbPvOLoCObuki()
	{
		return AppDomain.CurrentDomain;
	}

	internal static void eXPKrVYS0Fb41mEyy01(object object_0, object object_1)
	{
		((AppDomain)object_0).UnhandledException += (UnhandledExceptionEventHandler?)object_1;
	}

	internal static void e5DRWRYDkCgVNRbeFme(object object_0)
	{
		Application.add_ThreadException((ThreadExceptionEventHandler)object_0);
	}

	internal static object eMRpKcYvnRbUOMrj0BG()
	{
		return Assembly.GetExecutingAssembly();
	}

	internal static object eEb92jY88bWTAopP7Js(object object_0)
	{
		return ((Assembly)object_0).GetTypes();
	}

	internal static Type eDQbdnYwPkdgRfIveEc(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object e8CrIZY4VLa5LgIKNcG(Type type_0, bool bool_0)
	{
		return Activator.CreateInstance(type_0, bool_0);
	}

	internal static bool eGmlR5YpbcOa1vs9fjR(object object_0, object object_1)
	{
		return (string?)object_0 == (string?)object_1;
	}

	internal static object egP1egYVxD78VMUm5iK()
	{
		return smethod_0();
	}

	internal static bool er6gM3YTtRFVmuoeFmt(object object_0, object object_1)
	{
		return ((e8MHalImLVkLOnUn6dG)object_0).elN6Gg9Qb((SecurityException)object_1);
	}

	internal static void eyFNLrYGdl0RaAZO4WQ(object object_0, object object_1)
	{
		eEJNauItTVW1j8pluTb.ep2oBURlk((Exception)object_0, (object[])object_1);
	}

	internal static void e8kvXqYtQUGNNcjSbGs(object object_0, object object_1, bool bool_0, bool bool_1)
	{
		((e8MHalImLVkLOnUn6dG)object_0).eKyrTQhVp((Exception)object_1, bool_0, bool_1);
	}

	internal static object efhmJEY1p2UHnB3esYr(object object_0)
	{
		return ((ThreadExceptionEventArgs)object_0).Exception;
	}

	internal static Type eEfanXYRjPxmh7qLWk6(object object_0)
	{
		return ((Exception)object_0).GetType();
	}

	internal static object eJmg47YqvCoQSuGLuGT(object object_0)
	{
		return ((MemberInfo)object_0).Name;
	}

	internal static object eh4XhmYO45Fj1fQBd34(object object_0, object object_1)
	{
		return ((FieldInfo)object_0).GetValue(object_1);
	}

	internal static object eCujZfY35pgQ8yULplx(object object_0)
	{
		return ((UnhandledExceptionEventArgs)object_0).ExceptionObject;
	}

	internal static bool e8ws8SYFmGYvJfg1L7O(object object_0)
	{
		return ((UnhandledExceptionEventArgs)object_0).IsTerminating;
	}

	internal static bool ejtytvYewXwRwN9Y7yX(object object_0)
	{
		return ((exgdQiIHW0NaSpp0mcE)object_0).method_5();
	}

	internal static bool e9H1wdYKuaFMU6p2Bg8(object object_0)
	{
		return ((exgdQiIHW0NaSpp0mcE)object_0).method_3();
	}

	internal static void emYKgEYsyZBgs5jZr0D(object object_0, object object_1)
	{
		((e8MHalImLVkLOnUn6dG)object_0).ep20ZBURlk((exgdQiIHW0NaSpp0mcE)object_1);
	}

	internal static void ewt0VaYIpgeYc1wyPFA()
	{
		Application.Exit();
	}

	internal static Guid eqi8JOY08QPvjNSR9kf(object object_0)
	{
		return ((e8MHalImLVkLOnUn6dG)object_0).ep20ZBURlk();
	}

	internal static void eqpc4vYhtlyq0xPEKwL(object object_0, object object_1)
	{
		((ehlurTITCIsVDna2cPM)object_0).method_1((e0PjuKI5UdQoJ3avxe1)object_1);
	}

	internal static object eYosmWYAFTcy2f8asir()
	{
		return etLkbiKQmtC8HcUdXI.e4ZIbpnTa();
	}

	internal static void eXaP6JYB5giVIQwf2pb(object object_0)
	{
		((eSKhENIYtua9ZT9uY47)object_0).ecs0D1Zdd();
	}

	internal static void exyx5fYHdDcmOm1t4ql(object object_0, bool bool_0)
	{
		((eSKhENIYtua9ZT9uY47)object_0).eulODlten(bool_0);
	}

	internal static void eRPRAqYWrpZxpQajiTC(object object_0, bool bool_0)
	{
		((eSKhENIYtua9ZT9uY47)object_0).method_5(bool_0);
	}

	internal static void e3KQkBYcZkuV1i5iOOE(object object_0, object object_1)
	{
		((e8MHalImLVkLOnUn6dG)object_0).ep20ZBURlk((eSKhENIYtua9ZT9uY47)object_1);
	}

	internal static bool eFwohdYUtX4USj4oI2S(object object_0)
	{
		return ((eSKhENIYtua9ZT9uY47)object_0).method_4();
	}

	internal static void enN05oYlc6ZACVZBnpV(object object_0, object object_1)
	{
		((eqhUlYIlZPIm7SfeQtd)object_0).method_0((eCK5bGIBSHNlxdKcSIv)object_1);
	}

	internal static void eIn3alYNHYUmXmhofMF(object object_0, object object_1)
	{
		((ehlurTITCIsVDna2cPM)object_0).method_2((EventHandler)object_1);
	}

	internal static void eoocAhYro06ZE4u2Sw1(object object_0, object object_1)
	{
		((e8MHalImLVkLOnUn6dG)object_0).ep20ZBURlk((ep0T6KI2Qw8SOuAhViY)object_1);
	}

	internal static object e6TVVmYnShUa91eBPUC(object object_0)
	{
		return ((AppDomain)object_0).GetAssemblies();
	}

	internal static object eCSlmAYP6U6hwlbC2h2(object object_0)
	{
		return ((Assembly)object_0).FullName;
	}

	internal static bool ehuY9UYmyFatPJyQKSN(object object_0, object object_1)
	{
		return ((string)object_0).EndsWith((string)object_1);
	}

	internal static bool eEGh12YxeFXl018SRL2(object object_0, object object_1)
	{
		return ((string)object_0).StartsWith((string)object_1);
	}

	internal static Type eJ2CVIYz9VNnAFYuD8i(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetType((string)object_1);
	}

	internal static object eZsxDuf7bPRh3oXA2bO(object object_0)
	{
		return ((PropertyInfo)object_0).GetGetMethod();
	}

	internal static object e2AZjyf9cwUYDj5ED92(object object_0, object object_1, object object_2)
	{
		return ((MethodBase)object_0).Invoke(object_1, (object?[]?)object_2);
	}

	internal static void ew0yK6fk3LSU308xo35(int int_0)
	{
		Environment.Exit(int_0);
	}

	internal static void eTniynfQMNqfSQf1KAC(object object_0, object object_1, object object_2)
	{
		object_0(object_1, (EventArgs)object_2);
	}

	internal static void em09y6fLmBJ8YAuqFug(object object_0, object object_1, object object_2)
	{
		object_0(object_1, (e5QKijIZd7liuYOwuT0)object_2);
	}

	internal static void eH4uLOfJtBkQSOkUECk(object object_0)
	{
		object_0._002Ector();
	}

	internal static bool efV5infjY8lkdOxWpTk(object object_0)
	{
		return Convert.ToBoolean((string?)object_0);
	}

	internal static void eeePmbf5j8RQLVVURma(Type type_0)
	{
		eMbooerndU5ci2DHIZ.e4ZIbpnTa(type_0);
	}
}
