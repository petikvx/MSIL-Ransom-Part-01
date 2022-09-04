using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using ns2;

namespace ns0;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Form0 : WindowsFormsApplicationBase
{
	private static List<WeakReference> list_0 = new List<WeakReference>();

	[DebuggerNonUserCode]
	private unsafe static void smethod_0(object object_0)
	{
		void* ptr = stackalloc byte[19];
		List<WeakReference> obj = list_0;
		((byte*)ptr)[16] = 0;
		try
		{
			Monitor.Enter(obj, ref *(bool*)((byte*)ptr + 16));
			((byte*)ptr)[17] = ((list_0.Count == list_0.Capacity) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[17] != 0)
			{
				*(int*)ptr = 0;
				byte* num = (byte*)ptr + 4;
				*(int*)((byte*)ptr + 8) = checked(list_0.Count - 1);
				*(int*)num = 0;
				while (true)
				{
					int num2 = *(int*)((byte*)ptr + 4);
					*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 8);
					if (num2 > *(int*)((byte*)ptr + 12))
					{
						break;
					}
					WeakReference weakReference = list_0[*(int*)((byte*)ptr + 4)];
					((byte*)ptr)[17] = (weakReference.IsAlive ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[17] != 0)
					{
						((byte*)ptr)[18] = ((*(int*)((byte*)ptr + 4) != *(int*)ptr) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[18] != 0)
						{
							list_0[*(int*)ptr] = list_0[*(int*)((byte*)ptr + 4)];
						}
						checked
						{
							(*unchecked((int*)ptr))++;
						}
					}
					checked
					{
						(*unchecked((int*)((byte*)ptr + 4)))++;
					}
				}
				list_0.RemoveRange(*(int*)ptr, checked(list_0.Count - *unchecked((int*)ptr)));
				list_0.Capacity = list_0.Count;
			}
			list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
		}
		finally
		{
			((byte*)ptr)[18] = ((byte*)ptr)[16];
			if (((byte*)ptr)[18] != 0)
			{
				Monitor.Exit(obj);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[STAThread]
	internal static void Main(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.get_UseCompatibleTextRendering());
		}
		finally
		{
		}
		((WindowsFormsApplicationBase)Class1.smethod_0()).Run(args);
	}

	public Form0()
		: base((AuthenticationMode)0)
	{
		smethod_0(this);
		((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
		((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
		((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
	}

	void WindowsFormsApplicationBase.OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)Class1.smethod_1().method_0());
	}
}
