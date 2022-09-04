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
internal sealed class Form0 : WindowsFormsApplicationBase
{
	private static List<WeakReference> list_0 = new List<WeakReference>();

	[DebuggerNonUserCode]
	private unsafe static void smethod_0(object object_0)
	{
		void* ptr = stackalloc byte[18];
		lock (list_0)
		{
			((byte*)ptr)[16] = ((list_0.Count == list_0.Capacity) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[16] != 0)
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
					((byte*)ptr)[16] = (weakReference.IsAlive ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[16] != 0)
					{
						((byte*)ptr)[17] = ((*(int*)((byte*)ptr + 4) != *(int*)ptr) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[17] != 0)
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
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static void Main(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.get_UseCompatibleTextRendering());
		}
		finally
		{
		}
		((WindowsFormsApplicationBase)Class1.smethod_1()).Run(args);
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
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)Class1.smethod_2().method_0());
	}
}
