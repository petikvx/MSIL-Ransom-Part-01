using System;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;
using B43f3cMmUbTdiovLVhZ;
using EmgrZOMzuhmebj5qWGU;
using HysSoEMDCgJHq4D3Uqj;
using N5n40dM8NkUQdRhLW59;
using ProwxkN4F4ab5Fc8FL;
using YnY18pMfTGmdb5ScMPb;
using lX2Q3LM2UyxwFwlqnc5;
using lv2XSA9wbXRLBeNaHA;
using ud8TtLMBLRJEqBNvVyQ;

namespace KMYuQwYr9ylKSf89qY4;

internal abstract class obNUo3YHqk3Q5hwqpRV
{
	private static readonly bool PDTAQ89vFM = Convert.ToBoolean(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681757));

	private static readonly string MFiApSnGao = DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(679624);

	private static obNUo3YHqk3Q5hwqpRV D8KAceAWKL;

	private IWebProxy mpDAttiFBQ;

	private EventHandler HuwAHxEnRf;

	private y6kykhMNsHk6dVNm3ju WdOArZB5AN;

	[SpecialName]
	public void method_0(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = HuwAHxEnRf;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref HuwAHxEnRf, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	public void method_1(y6kykhMNsHk6dVNm3ju y6kykhMNsHk6dVNm3ju_0)
	{
		y6kykhMNsHk6dVNm3ju value = default(y6kykhMNsHk6dVNm3ju);
		y6kykhMNsHk6dVNm3ju y6kykhMNsHk6dVNm3ju2 = default(y6kykhMNsHk6dVNm3ju);
		while (true)
		{
			y6kykhMNsHk6dVNm3ju y6kykhMNsHk6dVNm3ju = WdOArZB5AN;
			if (PtiCui4n7A7nqlgPBuL())
			{
				switch (6)
				{
				case 0:
				case 4:
					break;
				case 6:
					goto IL_003e;
				case 2:
				case 3:
					goto IL_0040;
				case 5:
					goto IL_004f;
				default:
					goto IL_0055;
				case 7:
					return;
				}
				continue;
			}
			goto IL_0055;
			IL_0040:
			value = (y6kykhMNsHk6dVNm3ju)Delegate.Combine(y6kykhMNsHk6dVNm3ju2, y6kykhMNsHk6dVNm3ju_0);
			goto IL_0055;
			IL_0055:
			y6kykhMNsHk6dVNm3ju = Interlocked.CompareExchange(ref WdOArZB5AN, value, y6kykhMNsHk6dVNm3ju2);
			goto IL_004f;
			IL_004f:
			if ((object)y6kykhMNsHk6dVNm3ju == y6kykhMNsHk6dVNm3ju2)
			{
				break;
			}
			goto IL_003e;
			IL_003e:
			y6kykhMNsHk6dVNm3ju2 = y6kykhMNsHk6dVNm3ju;
			goto IL_0040;
		}
	}

	protected abstract void vmethod_0(Iun4mxMs3HspeLXRTIp iun4mxMs3HspeLXRTIp_0);

	protected abstract void vmethod_1(eShMauMILksMTN7ckoh eShMauMILksMTN7ckoh_0);

	protected abstract void vmethod_2(LWbQMtMlFuKHH87WKxp lwbQMtMlFuKHH87WKxp_0);

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public static void wANAMjdaVR(obNUo3YHqk3Q5hwqpRV obNUo3YHqk3Q5hwqpRV_0)
	{
		if (obNUo3YHqk3Q5hwqpRV_0 != null)
		{
			D8KAceAWKL = obNUo3YHqk3Q5hwqpRV_0;
			AppDomain.CurrentDomain.UnhandledException += obNUo3YHqk3Q5hwqpRV_0.BhuAdt1h7d;
			Application.add_ThreadException((ThreadExceptionEventHandler)obNUo3YHqk3Q5hwqpRV_0.zSrAudWXTg);
		}
	}

	[SpecialName]
	private static obNUo3YHqk3Q5hwqpRV smethod_0()
	{
		Type type = default(Type);
		while (D8KAceAWKL == null)
		{
			while (true)
			{
				Type[] types = Assembly.GetExecutingAssembly().GetTypes();
				while (true)
				{
					int num = 0;
					if (PtiCui4n7A7nqlgPBuL())
					{
						switch (4)
						{
						case 0:
						case 2:
							break;
						case 1:
						case 6:
							goto end_IL_0003;
						case 3:
							goto end_IL_0048;
						case 10:
							goto IL_0061;
						case 4:
						case 8:
							goto IL_0068;
						case 5:
							goto IL_0074;
						case 9:
							goto IL_0087;
						default:
							goto IL_00a6;
						case 11:
							goto end_IL_0055;
						}
						continue;
					}
					goto IL_00a6;
					IL_0061:
					if ((object)type == null)
					{
						goto IL_0064;
					}
					goto IL_00a6;
					IL_00a6:
					if ((object)type.BaseType == null)
					{
						goto IL_0064;
					}
					goto IL_0074;
					IL_0074:
					if ((object)type.BaseType != typeof(obNUo3YHqk3Q5hwqpRV))
					{
						goto IL_0064;
					}
					goto IL_0087;
					IL_0087:
					try
					{
						D8KAceAWKL = (obNUo3YHqk3Q5hwqpRV)Activator.CreateInstance(type, nonPublic: true);
						if (D8KAceAWKL != null)
						{
							goto end_IL_0055;
						}
					}
					catch
					{
					}
					goto IL_0064;
					IL_0064:
					num++;
					goto IL_0068;
					IL_0068:
					if (num >= types.Length)
					{
						goto end_IL_0055;
					}
					type = types[num];
					goto IL_0061;
					continue;
					end_IL_0003:
					break;
				}
				continue;
				end_IL_0048:
				break;
			}
			continue;
			end_IL_0055:
			break;
		}
		return D8KAceAWKL;
	}

	public static void JICAYicCYQ(Exception exception_0, object[] object_0)
	{
		while (true)
		{
			if (exception_0 == null)
			{
				goto IL_0006;
			}
			goto IL_0052;
			IL_0006:
			kfwFslMyHgRgWfekSOO.Y33KiQyvn7(exception_0, object_0);
			int num = 3;
			if (!rEKaLT4BAxCZSVjbckI())
			{
				goto IL_0019;
			}
			goto IL_0052;
			IL_0052:
			if (!(exception_0 is SecurityException))
			{
				goto IL_0006;
			}
			num = 6;
			if (!PtiCui4n7A7nqlgPBuL())
			{
				break;
			}
			goto IL_0019;
			IL_0019:
			switch (num)
			{
			default:
				return;
			case 0:
			case 1:
				break;
			case 6:
				if (!(MFiApSnGao == DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(679624)))
				{
					goto IL_0006;
				}
				goto case 7;
			case 7:
				if (smethod_0().ikKA7pcE8u((SecurityException)exception_0))
				{
					return;
				}
				goto IL_0006;
			case 5:
				continue;
			case 3:
				smethod_0().zHwAJOQBQ9(exception_0, bool_0: false, bool_1: false);
				return;
			case 2:
			case 4:
				return;
			case 8:
				return;
			}
			goto IL_0052;
		}
	}

	private void zSrAudWXTg(object sender, ThreadExceptionEventArgs e)
	{
		try
		{
			Exception ex = e.Exception;
			while (true)
			{
				Type type = ex.GetType();
				while (true)
				{
					if (type.Name == DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681541))
					{
						if (PtiCui4n7A7nqlgPBuL())
						{
							switch (5)
							{
							case 0:
							case 1:
								break;
							case 6:
								goto end_IL_0044;
							case 2:
							case 5:
								if (type.Namespace == DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681566))
								{
									goto IL_0080;
								}
								goto IL_009c;
							case 7:
								goto IL_0080;
							default:
								goto IL_009c;
							case 8:
								goto IL_00a4;
							case 4:
								goto IL_00ba;
							case 9:
								return;
							}
							continue;
						}
						goto IL_0080;
					}
					goto IL_009c;
					IL_00ba:
					if (ikKA7pcE8u(ex as SecurityException))
					{
						return;
					}
					goto IL_00ca;
					IL_00ca:
					zHwAJOQBQ9(ex, bool_0: true, bool_1: false);
					return;
					IL_0080:
					ex = (Exception)type.GetField(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681611))!.GetValue(ex);
					goto IL_009c;
					IL_009c:
					if (ex is SecurityException)
					{
						goto IL_00a4;
					}
					goto IL_00ca;
					IL_00a4:
					if (MFiApSnGao == DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(679624))
					{
						goto IL_00ba;
					}
					goto IL_00ca;
					continue;
					end_IL_0044:
					break;
				}
			}
		}
		catch
		{
		}
	}

	private void BhuAdt1h7d(object sender, UnhandledExceptionEventArgs e)
	{
		try
		{
			if ((!(e.ExceptionObject is SecurityException) || !(MFiApSnGao == DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(679624)) || !ikKA7pcE8u(e.ExceptionObject as SecurityException)) && e.ExceptionObject is Exception)
			{
				zHwAJOQBQ9((Exception)e.ExceptionObject, !e.IsTerminating, bool_1: false);
			}
		}
		catch
		{
		}
	}

	protected virtual Guid vmethod_3()
	{
		return Guid.Empty;
	}

	private bool ikKA7pcE8u(SecurityException securityException_0)
	{
		while (true)
		{
			LWbQMtMlFuKHH87WKxp lWbQMtMlFuKHH87WKxp = new LWbQMtMlFuKHH87WKxp(securityException_0);
			while (true)
			{
				IL_0048:
				vmethod_2(lWbQMtMlFuKHH87WKxp);
				while (true)
				{
					if (!lWbQMtMlFuKHH87WKxp.method_5())
					{
						if (!lWbQMtMlFuKHH87WKxp.method_3())
						{
							if (rEKaLT4BAxCZSVjbckI())
							{
								break;
							}
							switch (5)
							{
							case 6:
								break;
							case 2:
								goto IL_0048;
							case 0:
							case 1:
								goto end_IL_003e;
							default:
								goto IL_005b;
							case 4:
							case 5:
								Application.Exit();
								goto IL_0062;
							case 7:
								goto IL_0062;
							}
							continue;
						}
						goto IL_0062;
					}
					goto IL_005b;
					IL_0062:
					return true;
					IL_005b:
					return false;
					continue;
					end_IL_003e:
					break;
				}
				break;
			}
		}
	}

	private void zHwAJOQBQ9(Exception exception_0, bool bool_0, bool bool_1)
	{
		Assembly assembly = default(Assembly);
		object obj3 = default(object);
		while (true)
		{
			Type type = exception_0.GetType();
			while (true)
			{
				if (!(type.Name == DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681541)))
				{
					goto IL_0022;
				}
				goto IL_0250;
				IL_0250:
				if (type.Namespace == DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681566))
				{
					exception_0 = (Exception)type.GetField(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681611))!.GetValue(exception_0);
				}
				goto IL_0022;
				IL_0022:
				bool flag = true;
				while (true)
				{
					IL_0025:
					if (exception_0 == null)
					{
						return;
					}
					while (true)
					{
						IL_002b:
						if (exception_0 is ThreadAbortException)
						{
							return;
						}
						try
						{
							mKe5RuMae4Za5ZVa4pS mKe5RuMae4Za5ZVa4pS = new mKe5RuMae4Za5ZVa4pS(vmethod_3(), exception_0, mpDAttiFBQ);
							mKe5RuMae4Za5ZVa4pS.method_0(uwuAUt8V5e);
							mKe5RuMae4Za5ZVa4pS.method_2(oXbAApqOHb);
							mKe5RuMae4Za5ZVa4pS.method_1(OgMAKLJ0TP);
							Iun4mxMs3HspeLXRTIp iun4mxMs3HspeLXRTIp = new Iun4mxMs3HspeLXRTIp(mKe5RuMae4Za5ZVa4pS, exception_0);
							if (F1rO0O2Fau5JKfB06U.UfpYTFZGmL() != null)
							{
								iun4mxMs3HspeLXRTIp.YbAJDipYCM();
							}
							if (!bool_0)
							{
								iun4mxMs3HspeLXRTIp.BTtJ5Nrw2k(bool_0: false);
								iun4mxMs3HspeLXRTIp.method_5(bool_0: false);
							}
							else if (bool_1 || PDTAQ89vFM)
							{
								iun4mxMs3HspeLXRTIp.BTtJ5Nrw2k(bool_0: false);
								iun4mxMs3HspeLXRTIp.method_5(bool_0: true);
							}
							vmethod_0(iun4mxMs3HspeLXRTIp);
							flag = !iun4mxMs3HspeLXRTIp.method_4();
						}
						catch (ThreadAbortException)
						{
						}
						catch (Exception exception_)
						{
							vmethod_1(new eShMauMILksMTN7ckoh(exception_));
						}
						if (!flag)
						{
							return;
						}
						while (true)
						{
							IL_00fd:
							Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
							while (true)
							{
								IL_0108:
								int num = 0;
								while (true)
								{
									IL_010a:
									int num2;
									if (num < assemblies.Length)
									{
										assembly = assemblies[num];
										num2 = 2;
										if (rEKaLT4BAxCZSVjbckI())
										{
											break;
										}
									}
									else
									{
										num2 = 13;
										if (rEKaLT4BAxCZSVjbckI())
										{
										}
									}
									while (true)
									{
										switch (num2)
										{
										case 0:
										case 10:
											break;
										case 6:
											goto end_IL_010a;
										case 8:
											goto IL_0025;
										case 9:
											goto IL_002b;
										default:
											goto IL_00fd;
										case 3:
										case 7:
											goto IL_0108;
										case 4:
										case 5:
											goto IL_010a;
										case 2:
											try
											{
												string fullName = assembly.FullName;
												int num3 = 4;
												if (rEKaLT4BAxCZSVjbckI())
												{
													goto IL_0140;
												}
												goto IL_0162;
												IL_0162:
												switch (num3)
												{
												case 4:
													break;
												case 0:
												case 1:
													if (fullName.StartsWith(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681661)))
													{
														goto IL_0197;
													}
													goto end_IL_012b;
												default:
													goto IL_0197;
												case 5:
													goto IL_01c4;
												}
												goto IL_0140;
												IL_0140:
												if (fullName.EndsWith(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681636)))
												{
													num3 = 0;
													if (PtiCui4n7A7nqlgPBuL())
													{
														goto IL_0162;
													}
													goto IL_0197;
												}
												goto end_IL_012b;
												IL_0197:
												obj3 = assembly.GetType(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681694))!.GetProperty(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681731))!.GetGetMethod()!.Invoke(null, null);
												goto IL_01c4;
												IL_01c4:
												obj3.GetType().GetMethod(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681744), new Type[0])!.Invoke(obj3, null);
												end_IL_012b:;
											}
											catch
											{
											}
											num++;
											num2 = 5;
											if (rEKaLT4BAxCZSVjbckI())
											{
											}
											continue;
										case 1:
											goto IL_0250;
										case 13:
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
										case 11:
											return;
										}
										break;
									}
									goto end_IL_0008;
									continue;
									end_IL_010a:
									break;
								}
								break;
							}
							break;
						}
						break;
					}
					break;
				}
				continue;
				end_IL_0008:
				break;
			}
		}
	}

	private void OgMAKLJ0TP(object object_0, eShMauMILksMTN7ckoh eShMauMILksMTN7ckoh_0)
	{
		vmethod_1(eShMauMILksMTN7ckoh_0);
	}

	private void oXbAApqOHb(object sender, EventArgs e)
	{
		HuwAHxEnRf?.Invoke(sender, e);
	}

	private void uwuAUt8V5e(object object_0, nGfTeOM5tOvy21AZS3N nGfTeOM5tOvy21AZS3N_0)
	{
		WdOArZB5AN?.Invoke(object_0, nGfTeOM5tOvy21AZS3N_0);
	}

	internal static bool PtiCui4n7A7nqlgPBuL()
	{
		return true;
	}

	internal static bool rEKaLT4BAxCZSVjbckI()
	{
		return false;
	}
}
