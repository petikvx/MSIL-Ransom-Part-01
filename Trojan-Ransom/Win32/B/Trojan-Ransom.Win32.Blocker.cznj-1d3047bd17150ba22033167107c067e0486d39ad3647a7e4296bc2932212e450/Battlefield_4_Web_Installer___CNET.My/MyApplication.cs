using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace Battlefield_4_Web_Installer___CNET.My;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class MyApplication : WindowsFormsApplicationBase
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerHidden]
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
		((WindowsFormsApplicationBase)MyProject.Application).Run(args);
	}

	[DebuggerStepThrough]
	public MyApplication()
		: base((AuthenticationMode)0)
	{
		__ENCAddToList(this);
		((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
		((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
		((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)MyProject.Forms.Form1);
	}
}
