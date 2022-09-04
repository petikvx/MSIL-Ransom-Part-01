using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using m6lLYQjWFtDlHcqEYv;

namespace OvKuilgtOADYpdVrWF;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class Ryv8qU0ocgjO8PKwtb : WindowsFormsApplicationBase
{
	private static List<WeakReference> kUanv3GVF = new List<WeakReference>();

	[DebuggerNonUserCode]
	private static void kkZGGIavc(object object_0)
	{
		_ = 1;
		List<WeakReference> list = default(List<WeakReference>);
		if (!BZ948FOuhntFQ6onhw())
		{
			list = kUanv3GVF;
		}
		Monitor.Enter(list);
		checked
		{
			try
			{
				bool flag = kUanv3GVF.Count == kUanv3GVF.Capacity;
				while (flag)
				{
					int num = 0;
					while (true)
					{
						int num2 = aS3HUijoWLOceQFp5S(kUanv3GVF) - 1;
						int num3 = 0;
						while (true)
						{
							IL_00ee:
							int num4 = num3;
							int num5 = num2;
							if (num4 <= num5)
							{
								WeakReference weakReference = kUanv3GVF[num3];
								flag = weakReference.IsAlive;
								BZ948FOuhntFQ6onhw();
								if (a34fkaG5bbtvKPjadu())
								{
									goto IL_00d7;
								}
								goto IL_00db;
							}
							m4csJ7KWrxCQ1O0VOQ(kUanv3GVF, num, aS3HUijoWLOceQFp5S(kUanv3GVF) - num);
							goto IL_0134;
							IL_00d7:
							if (flag)
							{
								goto IL_00db;
							}
							goto IL_00ea;
							IL_00ea:
							num3++;
							continue;
							IL_00db:
							while (true)
							{
								IL_00db_2:
								bool flag2 = num3 != num;
								while (flag2)
								{
									int num6 = 1;
									if (!a34fkaG5bbtvKPjadu())
									{
										goto end_IL_00ee;
									}
									while (true)
									{
										switch (num6)
										{
										case 1:
											kUanv3GVF[num] = kUanv3GVF[num3];
											num6 = 9;
											if (!BZ948FOuhntFQ6onhw())
											{
												continue;
											}
											return;
										case 3:
										case 10:
											goto IL_00d7;
										case 4:
										case 8:
											goto IL_00db_2;
										case 9:
											goto end_IL_00d1;
										case 0:
											goto IL_00ee;
										case 6:
											goto end_IL_00ee;
										case 5:
											goto end_IL_00fd;
										case 7:
											goto IL_0134;
										case 2:
											goto end_IL_010f;
										case 12:
											return;
										}
										break;
									}
									continue;
									end_IL_00d1:
									break;
								}
								break;
							}
							num++;
							goto IL_00ea;
							IL_0134:
							cmIyXtUCVS0P8vv9NU(kUanv3GVF, kUanv3GVF.Count);
							goto end_IL_010f;
							continue;
							end_IL_00ee:
							break;
						}
						continue;
						end_IL_00fd:
						break;
					}
					continue;
					end_IL_010f:
					break;
				}
				kUanv3GVF.Add(new WeakReference(eKy72JJw3ueW1MMGrq(object_0)));
			}
			finally
			{
				XC4tdaRPPVrbcEN8mF(list);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[DebuggerHidden]
	[STAThread]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static void j8KSVfp9F(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.get_UseCompatibleTextRendering());
		}
		finally
		{
		}
		((WindowsFormsApplicationBase)n1LId7KWCl2k85cPuQ.ifnDTyv8q).Run(args);
	}

	[DebuggerStepThrough]
	public Ryv8qU0ocgjO8PKwtb()
	{
		BZ948FOuhntFQ6onhw();
		int num;
		if (a34fkaG5bbtvKPjadu())
		{
			num = 5;
			if (!a34fkaG5bbtvKPjadu())
			{
				goto IL_0054;
			}
		}
		else
		{
			num = 3;
			if (!BZ948FOuhntFQ6onhw())
			{
			}
		}
		switch (num)
		{
		case 0:
		case 5:
			break;
		case 2:
			goto IL_005b;
		case 6:
			goto IL_0061;
		case 1:
			goto IL_0068;
		default:
			goto IL_006f;
		case 7:
			goto IL_0076;
		case 8:
			return;
		}
		goto IL_0054;
		IL_006f:
		r5FjG5QdLXo8AgtkGG(this, bool_0: true);
		goto IL_0076;
		IL_0076:
		mLwNTp7Onv1CvjYbTO(this, (ShutdownMode)0);
		return;
		IL_0068:
		pCtRR3hF8lOcKxItIg(this, bool_0: true);
		goto IL_006f;
		IL_0054:
		DtZBRkkQKbw42wNkUJ(this, (AuthenticationMode)0);
		goto IL_005b;
		IL_005b:
		YSH832CVyOhHfg5diK(this);
		goto IL_0061;
		IL_0061:
		JsvZS0o4HuNlPoc8xx(this, bool_0: false);
		goto IL_0068;
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)JtiN2PDo8pGRHgwZE2(FdmaWDxD9C4UpjVLM2()));
	}

	internal static bool a34fkaG5bbtvKPjadu()
	{
		return true;
	}

	internal static bool BZ948FOuhntFQ6onhw()
	{
		return false;
	}

	internal static int aS3HUijoWLOceQFp5S(object object_0)
	{
		return ((List<WeakReference>)object_0).Count;
	}

	internal static void m4csJ7KWrxCQ1O0VOQ(object object_0, int int_0, int int_1)
	{
		((List<WeakReference>)object_0).RemoveRange(int_0, int_1);
	}

	internal static void cmIyXtUCVS0P8vv9NU(object object_0, int int_0)
	{
		((List<WeakReference>)object_0).Capacity = int_0;
	}

	internal static object eKy72JJw3ueW1MMGrq(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	internal static void XC4tdaRPPVrbcEN8mF(object object_0)
	{
		Monitor.Exit(object_0);
	}

	internal static void DtZBRkkQKbw42wNkUJ(object object_0, AuthenticationMode authenticationMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((WindowsFormsApplicationBase)object_0)._002Ector(authenticationMode_0);
	}

	internal static void YSH832CVyOhHfg5diK(object object_0)
	{
		kkZGGIavc(object_0);
	}

	internal static void JsvZS0o4HuNlPoc8xx(object object_0, bool bool_0)
	{
		((WindowsFormsApplicationBase)object_0).set_IsSingleInstance(bool_0);
	}

	internal static void pCtRR3hF8lOcKxItIg(object object_0, bool bool_0)
	{
		((WindowsFormsApplicationBase)object_0).set_EnableVisualStyles(bool_0);
	}

	internal static void r5FjG5QdLXo8AgtkGG(object object_0, bool bool_0)
	{
		((WindowsFormsApplicationBase)object_0).set_SaveMySettingsOnExit(bool_0);
	}

	internal static void mLwNTp7Onv1CvjYbTO(object object_0, ShutdownMode shutdownMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((WindowsFormsApplicationBase)object_0).set_ShutdownStyle(shutdownMode_0);
	}

	internal static object FdmaWDxD9C4UpjVLM2()
	{
		return n1LId7KWCl2k85cPuQ.VVrvWFEIx;
	}

	internal static object JtiN2PDo8pGRHgwZE2(object object_0)
	{
		return ((n1LId7KWCl2k85cPuQ.j9FRA7w61bFaJkXjgD)object_0).Min;
	}
}
