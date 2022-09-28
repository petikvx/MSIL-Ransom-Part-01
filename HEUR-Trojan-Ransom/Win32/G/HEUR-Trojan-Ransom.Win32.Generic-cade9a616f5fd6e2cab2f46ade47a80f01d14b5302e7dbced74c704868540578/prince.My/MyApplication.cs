using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using ns0;

namespace prince.My;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class MyApplication : WindowsFormsApplicationBase
{
	private static List<WeakReference> list_0;

	[SecuritySafeCritical]
	static MyApplication()
	{
		Class3.Class5.smethod_2();
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
				Class3.smethod_6((object)gparam_, ref bool_, 708, '\u02df');
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
						if (Class3.Class5.Class6.smethod_0(gparam_2, 'ϙ', 903))
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
				list_0.Add(new WeakReference(Class3.Class5.smethod_3(object_0, 435, 481)));
			}
			finally
			{
				if (bool_)
				{
					Class12.Class13.smethod_0((object)gparam_, (short)930, (short)996);
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	[SecuritySafeCritical]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static void Main(string[] args)
	{
		Class3.Class5.smethod_2();
		try
		{
			Class3.Class5.Class6.smethod_8(WindowsFormsApplicationBase.get_UseCompatibleTextRendering(), 578, 518);
		}
		finally
		{
		}
		Class3.smethod_17<WindowsFormsApplicationBase>((WindowsFormsApplicationBase)(object)MyProject.MyApplication_0, args, (short)1019, 953);
	}

	public MyApplication()
		: base((AuthenticationMode)0)
	{
		smethod_0(this);
		((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
		((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
		Class3.Class5.smethod_14<WindowsFormsApplicationBase>((WindowsFormsApplicationBase)(object)this, bool_1: true, 984, (short)974);
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
	}

	protected override void OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)MyProject.Class0_0.method_0());
	}
}
