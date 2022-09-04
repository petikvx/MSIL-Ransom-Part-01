using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using eJnHnFFEpEmlCQmkVB;

namespace Eddy.My;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class MyApplication : WindowsFormsApplicationBase
{
	[AccessedThroughProperty("maene")]
	private AppDomain _maene;

	private virtual AppDomain maene
	{
		get
		{
			return _maene;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			while (true)
			{
				ResolveEventHandler object_ = semblyResolve;
				ysIrXCbMd02TT04EBe();
				if (RJWe1MTMuI7rcMwcnG())
				{
					if (RJWe1MTMuI7rcMwcnG())
					{
					}
					switch (7)
					{
					case 6:
						break;
					case 1:
					case 5:
						goto IL_0054;
					case 0:
						goto IL_005c;
					case 3:
					case 7:
						goto IL_0068;
					default:
						goto IL_006f;
					case 2:
						goto IL_0077;
					case 8:
						return;
					}
					continue;
				}
				goto IL_0054;
				IL_006f:
				if (_maene == null)
				{
					break;
				}
				goto IL_0077;
				IL_0077:
				L5B0N2Bo2fwFOVOaG4(_maene, object_);
				break;
				IL_0054:
				if (_maene != null)
				{
					goto IL_005c;
				}
				goto IL_0068;
				IL_005c:
				vxqqXTPwU0SUdM2M6F(_maene, object_);
				goto IL_0068;
				IL_0068:
				_maene = value;
				goto IL_006f;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[DebuggerHidden]
	[STAThread]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static void Main(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.get_UseCompatibleTextRendering());
			eWK97ZHZd8El3E8K9m.FwXDxNafX7Lru();
		}
		finally
		{
		}
		((WindowsFormsApplicationBase)MyProject.Application).Run(args);
	}

	private Assembly semblyResolve(object sender, ResolveEventArgs args)
	{
		if (zhrC3pSumiWZjTLk1Q(LWSyysawVBPs54R2DS(args), "x"))
		{
			return (Assembly)w8.PC;
		}
		Assembly result = default(Assembly);
		return result;
	}

	[DebuggerStepThrough]
	public MyApplication()
	{
		if (ysIrXCbMd02TT04EBe())
		{
			switch (7)
			{
			case 7:
				y19lrdk4JVOUVX7C1Y(this, (AuthenticationMode)0);
				ysIrXCbMd02TT04EBe();
				if (!RJWe1MTMuI7rcMwcnG())
				{
					goto case 1;
				}
				goto IL_0063;
			case 1:
			case 6:
				SAiiSd5XhYdpkcTh1H(this, a01DqV7JDK6GbSBVnB());
				break;
			case 5:
				break;
			case 0:
			case 3:
				goto IL_0063;
			default:
				goto IL_006a;
			case 4:
				goto IL_0071;
			case 8:
				return;
			}
		}
		qaZHTXutveNd3IWeyg(this, bool_0: false);
		goto IL_0063;
		IL_0063:
		Ytswo701RPxMKiFKkQ(this, bool_0: true);
		goto IL_006a;
		IL_0071:
		fEh4Itv4Niaq7QcYmD(this, (ShutdownMode)0);
		return;
		IL_006a:
		m3jDi8eErIlh3w5UKl(this, bool_0: true);
		goto IL_0071;
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		oR8Hqlds9HRUmw6khl(this, RIxGjkZltisFxibQRG(nQfp3XOSRL1PvLJeSA()));
	}

	internal static bool ysIrXCbMd02TT04EBe()
	{
		return true;
	}

	internal static bool RJWe1MTMuI7rcMwcnG()
	{
		return false;
	}

	internal static void vxqqXTPwU0SUdM2M6F(object object_0, object object_1)
	{
		((AppDomain)object_0).AssemblyResolve -= (ResolveEventHandler?)object_1;
	}

	internal static void L5B0N2Bo2fwFOVOaG4(object object_0, object object_1)
	{
		((AppDomain)object_0).AssemblyResolve += (ResolveEventHandler?)object_1;
	}

	internal static object LWSyysawVBPs54R2DS(object object_0)
	{
		return ((ResolveEventArgs)object_0).Name;
	}

	internal static bool zhrC3pSumiWZjTLk1Q(object object_0, object object_1)
	{
		return ((string)object_0).Contains((string)object_1);
	}

	internal static void y19lrdk4JVOUVX7C1Y(object object_0, AuthenticationMode authenticationMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((WindowsFormsApplicationBase)object_0)._002Ector(authenticationMode_0);
	}

	internal static object a01DqV7JDK6GbSBVnB()
	{
		return AppDomain.CurrentDomain;
	}

	internal static void SAiiSd5XhYdpkcTh1H(object object_0, object object_1)
	{
		((MyApplication)object_0).maene = (AppDomain)object_1;
	}

	internal static void qaZHTXutveNd3IWeyg(object object_0, bool bool_0)
	{
		((WindowsFormsApplicationBase)object_0).set_IsSingleInstance(bool_0);
	}

	internal static void Ytswo701RPxMKiFKkQ(object object_0, bool bool_0)
	{
		((WindowsFormsApplicationBase)object_0).set_EnableVisualStyles(bool_0);
	}

	internal static void m3jDi8eErIlh3w5UKl(object object_0, bool bool_0)
	{
		((WindowsFormsApplicationBase)object_0).set_SaveMySettingsOnExit(bool_0);
	}

	internal static void fEh4Itv4Niaq7QcYmD(object object_0, ShutdownMode shutdownMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((WindowsFormsApplicationBase)object_0).set_ShutdownStyle(shutdownMode_0);
	}

	internal static object nQfp3XOSRL1PvLJeSA()
	{
		return MyProject.Forms;
	}

	internal static object RIxGjkZltisFxibQRG(object object_0)
	{
		return ((MyProject.MyForms)object_0).Form1;
	}

	internal static void oR8Hqlds9HRUmw6khl(object object_0, object object_1)
	{
		((WindowsFormsApplicationBase)object_0).set_MainForm((Form)object_1);
	}
}
