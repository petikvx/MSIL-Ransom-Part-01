using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace ns0;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class Form0 : WindowsFormsApplicationBase
{
	private static List<WeakReference> list_0 = Delegate53.smethod_0();

	[DebuggerStepThrough]
	public Form0()
		: base((AuthenticationMode)0)
	{
		smethod_0(this);
		Delegate32.smethod_0(this, bool_0: false);
		Delegate6.smethod_0(this, bool_0: true);
		Delegate20.smethod_0(this, bool_0: true);
		Delegate113.smethod_0(this, (ShutdownMode)0);
	}

	[DebuggerNonUserCode]
	private static void smethod_0(object object_0)
	{
		checked
		{
			List<WeakReference> list = default(List<WeakReference>);
			bool flag = default(bool);
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num5 = default(int);
			WeakReference weakReference = default(WeakReference);
			bool flag2 = default(bool);
			try
			{
				list = list_0;
				Delegate101.smethod_0(list);
				try
				{
					if (flag = Delegate24.smethod_0(list_0) == Delegate129.smethod_0(list_0))
					{
						num = 0;
						num2 = Delegate24.smethod_0(list_0) - 1;
						num3 = 0;
						while (true)
						{
							int num4 = num3;
							num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							weakReference = Delegate76.smethod_0(list_0, num3);
							if (flag = Delegate52.smethod_0(weakReference))
							{
								if (flag2 = num3 != num)
								{
									Delegate43.smethod_0(list_0, num, Delegate76.smethod_0(list_0, num3));
								}
								num++;
							}
							num3++;
						}
						Delegate119.smethod_0(list_0, num, Delegate24.smethod_0(list_0) - num);
						Delegate65.smethod_0(list_0, Delegate24.smethod_0(list_0));
					}
					Delegate87.smethod_0(list_0, Delegate15.smethod_0(Delegate26.smethod_0(object_0)));
				}
				finally
				{
					Delegate96.smethod_0(list);
				}
			}
			catch (Exception exception_)
			{
				Class9.smethod_33(exception_, object_0, num, num3, weakReference, list, num2, flag, flag2, num5);
				throw;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	[DebuggerHidden]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static void Main(string[] args)
	{
		try
		{
			Class9.smethod_13();
			try
			{
				Delegate99.smethod_0(Delegate131.smethod_0());
			}
			finally
			{
			}
			Delegate35.smethod_0(Class2.Form0_0, args);
		}
		catch (Exception exception_)
		{
			Class9.smethod_25(exception_, args);
			throw;
		}
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		try
		{
			Delegate74.smethod_0(this, (Form)(object)Class2.Class3_0.Form1_0);
		}
		catch (Exception exception_)
		{
			Class9.smethod_25(exception_, this);
			throw;
		}
	}
}
