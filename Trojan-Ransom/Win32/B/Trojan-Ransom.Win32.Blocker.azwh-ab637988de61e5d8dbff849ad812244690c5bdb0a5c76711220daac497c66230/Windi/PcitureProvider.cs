using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace Windi;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class PcitureProvider : WindowsFormsApplicationBase
{
	private static List<WeakReference> logLength = new List<WeakReference>();

	[DebuggerStepThrough]
	public PcitureProvider()
		: base((AuthenticationMode)0)
	{
		NavigateClient(this);
		((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
		((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
		((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
	}

	[DebuggerNonUserCode]
	private static void NavigateClient(object logLength)
	{
		checked
		{
			lock (PcitureProvider.logLength)
			{
				if (PcitureProvider.logLength.Count == PcitureProvider.logLength.Capacity)
				{
					int num = 0;
					int num2 = PcitureProvider.logLength.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = PcitureProvider.logLength[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								PcitureProvider.logLength[num] = PcitureProvider.logLength[num3];
							}
							num++;
						}
						num3++;
					}
					PcitureProvider.logLength.RemoveRange(num, PcitureProvider.logLength.Count - num);
					PcitureProvider.logLength.Capacity = PcitureProvider.logLength.Count;
				}
				PcitureProvider.logLength.Add(new WeakReference(RuntimeHelpers.GetObjectValue(logLength)));
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerHidden]
	[STAThread]
	internal static void ResolveDatabase(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.get_UseCompatibleTextRendering());
		}
		finally
		{
		}
		((WindowsFormsApplicationBase)MenuItemConverter.ProcessBuilder).Run(args);
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)MenuItemConverter.SearchContext.ResolveDatabase);
	}
}
