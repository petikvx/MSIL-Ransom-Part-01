using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using ns0;

namespace cleanrrs.My;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class MyApplication : WindowsFormsApplicationBase
{
	private static List<WeakReference> list_0;

	[SecuritySafeCritical]
	static MyApplication()
	{
		Class3.Class5.Class6.smethod_0();
		list_0 = new List<WeakReference>();
	}

	private static void smethod_0(object object_0)
	{
		List<WeakReference> gparam_ = list_0;
		bool bool_ = false;
		checked
		{
			try
			{
				Class7.smethod_3((object)gparam_, ref bool_, 'ņ', 'Ĳ');
				if (list_0.Count == list_0.Capacity)
				{
					int num = 0;
					int num2 = list_0.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference gparam_2 = list_0[num3];
						if (Class3.smethod_12(gparam_2, 207, 152))
						{
							if (num3 != num)
							{
								list_0[num] = list_0[num3];
							}
							num++;
						}
						num3++;
					}
					list_0.RemoveRange(num, list_0.Count - num);
					list_0.Capacity = list_0.Count;
				}
				list_0.Add(new WeakReference(Class3.smethod_5(object_0, 914, 'υ')));
			}
			finally
			{
				if (bool_)
				{
					Class10.Class11.smethod_0((object)gparam_, 'Ȱ', 576);
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[STAThread]
	[SecuritySafeCritical]
	internal static void Main(string[] args)
	{
		Class3.Class5.Class6.smethod_0();
		try
		{
			Class7.Class8.smethod_13(WindowsFormsApplicationBase.get_UseCompatibleTextRendering(), 376, 326);
		}
		finally
		{
		}
		Class3.Class5.smethod_14<WindowsFormsApplicationBase>((WindowsFormsApplicationBase)(object)MyProject.MyApplication_0, args, 356, 305);
	}

	public MyApplication()
		: base((AuthenticationMode)0)
	{
		smethod_0(this);
		((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
		((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
		Class3.Class5.smethod_15<WindowsFormsApplicationBase>((WindowsFormsApplicationBase)(object)this, bool_0: true, (short)726, '\u02d6');
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
	}

	protected override void OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)MyProject.Class0_0.method_0());
	}
}
