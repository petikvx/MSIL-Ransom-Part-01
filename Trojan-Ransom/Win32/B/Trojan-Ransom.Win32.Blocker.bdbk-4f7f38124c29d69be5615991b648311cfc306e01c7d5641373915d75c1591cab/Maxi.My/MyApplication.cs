using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace Maxi.My;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal class MyApplication : WindowsFormsApplicationBase
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		_ = 0;
		List<WeakReference> _ENCList = default(List<WeakReference>);
		if (nH4EAFNsrQjNNwnWUW())
		{
			_ENCList = __ENCList;
		}
		M3sWHcc27bwKfuVAKW(_ENCList);
		checked
		{
			try
			{
				bool flag = gCLd0ytFusU7kNMmAr(__ENCList) == rAkC3ope1mpdVPKPKm(__ENCList);
				WeakReference object_ = default(WeakReference);
				bool flag2 = default(bool);
				while (flag)
				{
					while (true)
					{
						IL_0155:
						int num = 0;
						while (true)
						{
							int num2 = gCLd0ytFusU7kNMmAr(__ENCList) - 1;
							int num3 = 0;
							lmkhwoRdX14ep9TNNB();
							if (!nH4EAFNsrQjNNwnWUW())
							{
								break;
							}
							while (true)
							{
								IL_0147:
								int num4 = num3;
								int num5 = num2;
								int num6;
								if (num4 <= num5)
								{
									object_ = __ENCList[num3];
									num6 = 1;
									if (nH4EAFNsrQjNNwnWUW())
									{
										goto IL_0078;
									}
								}
								goto IL_0104;
								IL_00c3:
								__ENCList[num] = __ENCList[num3];
								num6 = 9;
								if (lmkhwoRdX14ep9TNNB())
								{
								}
								goto IL_0078;
								IL_0078:
								while (true)
								{
									switch (num6)
									{
									case 4:
										break;
									case 15:
										goto IL_00c3;
									case 7:
										if (flag)
										{
											flag2 = num3 != num;
											goto IL_00f4;
										}
										goto IL_0143;
									case 2:
										goto IL_00f4;
									case 1:
										flag = YhXGiVT99HjTSYPTrl(object_);
										goto case 7;
									case 0:
										goto IL_0104;
									default:
										num6 = 15;
										if (nH4EAFNsrQjNNwnWUW())
										{
											continue;
										}
										goto case 7;
									case 9:
										goto IL_013f;
									case 6:
										goto IL_0143;
									case 3:
									case 8:
									case 11:
										goto IL_0147;
									case 12:
										goto IL_0155;
									case 10:
										goto end_IL_0155;
									case 5:
										__ENCList.Capacity = gCLd0ytFusU7kNMmAr(__ENCList);
										goto end_IL_015c;
									case 13:
									case 14:
										goto end_IL_015c;
									case 16:
										return;
									}
									break;
								}
								break;
								IL_0104:
								ncKw9uXX08WIPhL7iU(__ENCList, num, gCLd0ytFusU7kNMmAr(__ENCList) - num);
								num6 = 5;
								if (nH4EAFNsrQjNNwnWUW())
								{
									goto IL_0078;
								}
								goto IL_00f4;
								IL_00f4:
								if (flag2)
								{
									goto IL_00c3;
								}
								goto IL_013f;
								IL_013f:
								num++;
								goto IL_0143;
								IL_0143:
								num3++;
							}
						}
						goto end_IL_015c;
						continue;
						end_IL_0155:
						break;
					}
					continue;
					end_IL_015c:
					break;
				}
				__ENCList.Add(new WeakReference(qP6HnglxIEAXRb5Nit(value)));
			}
			finally
			{
				o2Q9FhQUdIpm5ZUncO(_ENCList);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[STAThread]
	[DebuggerHidden]
	internal static void Main(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.get_UseCompatibleTextRendering());
		}
		finally
		{
		}
		((WindowsFormsApplicationBase)MyProject.Application).Run(args);
	}

	[DebuggerStepThrough]
	public MyApplication()
	{
		while (true)
		{
			ePCtwq0GMKNIVEbN1s(this, (AuthenticationMode)0);
			while (true)
			{
				IxuH7uM9cCPaCwyVgS(this);
				_ = 0;
				int num;
				if (nH4EAFNsrQjNNwnWUW())
				{
					num = 5;
					if (!lmkhwoRdX14ep9TNNB())
					{
						goto IL_0021;
					}
				}
				goto IL_006f;
				IL_0021:
				switch (num)
				{
				case 0:
					break;
				case 7:
					goto IL_004c;
				case 2:
				case 5:
					LuNqXonoNGdPLYohX3(this, bool_0: false);
					goto case 3;
				case 3:
					VUBim5gi7VVeima9IW(this, bool_0: true);
					goto IL_006f;
				default:
					goto IL_006f;
				case 6:
					goto end_IL_0003;
				case 8:
					return;
				}
				continue;
				IL_006f:
				EBkO1l2otcWgvFyuyp(this, bool_0: true);
				goto IL_004c;
				IL_004c:
				dUQmMcPn93QBOQ6jMV(this, (ShutdownMode)0);
				num = 8;
				if (!nH4EAFNsrQjNNwnWUW())
				{
					break;
				}
				goto IL_0021;
				continue;
				end_IL_0003:
				break;
			}
		}
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		Kq0mgee35sP60YqP88(this, D7Bha5CLSJGWDRRPLG(cOZoFIbmOFMPOrwZBk()));
	}

	internal static bool nH4EAFNsrQjNNwnWUW()
	{
		return true;
	}

	internal static bool lmkhwoRdX14ep9TNNB()
	{
		return false;
	}

	internal static void M3sWHcc27bwKfuVAKW(object object_0)
	{
		Monitor.Enter(object_0);
	}

	internal static int gCLd0ytFusU7kNMmAr(object object_0)
	{
		return ((List<WeakReference>)object_0).Count;
	}

	internal static int rAkC3ope1mpdVPKPKm(object object_0)
	{
		return ((List<WeakReference>)object_0).Capacity;
	}

	internal static bool YhXGiVT99HjTSYPTrl(object object_0)
	{
		return ((WeakReference)object_0).IsAlive;
	}

	internal static void ncKw9uXX08WIPhL7iU(object object_0, int int_0, int int_1)
	{
		((List<WeakReference>)object_0).RemoveRange(int_0, int_1);
	}

	internal static object qP6HnglxIEAXRb5Nit(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	internal static void o2Q9FhQUdIpm5ZUncO(object object_0)
	{
		Monitor.Exit(object_0);
	}

	internal static void ePCtwq0GMKNIVEbN1s(object object_0, AuthenticationMode authenticationMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((WindowsFormsApplicationBase)object_0)._002Ector(authenticationMode_0);
	}

	internal static void IxuH7uM9cCPaCwyVgS(object object_0)
	{
		__ENCAddToList(object_0);
	}

	internal static void LuNqXonoNGdPLYohX3(object object_0, bool bool_0)
	{
		((WindowsFormsApplicationBase)object_0).set_IsSingleInstance(bool_0);
	}

	internal static void VUBim5gi7VVeima9IW(object object_0, bool bool_0)
	{
		((WindowsFormsApplicationBase)object_0).set_EnableVisualStyles(bool_0);
	}

	internal static void EBkO1l2otcWgvFyuyp(object object_0, bool bool_0)
	{
		((WindowsFormsApplicationBase)object_0).set_SaveMySettingsOnExit(bool_0);
	}

	internal static void dUQmMcPn93QBOQ6jMV(object object_0, ShutdownMode shutdownMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((WindowsFormsApplicationBase)object_0).set_ShutdownStyle(shutdownMode_0);
	}

	internal static object cOZoFIbmOFMPOrwZBk()
	{
		return MyProject.Forms;
	}

	internal static object D7Bha5CLSJGWDRRPLG(object object_0)
	{
		return ((MyProject.MyForms)object_0).Max;
	}

	internal static void Kq0mgee35sP60YqP88(object object_0, object object_1)
	{
		((WindowsFormsApplicationBase)object_0).set_MainForm((Form)object_1);
	}
}
