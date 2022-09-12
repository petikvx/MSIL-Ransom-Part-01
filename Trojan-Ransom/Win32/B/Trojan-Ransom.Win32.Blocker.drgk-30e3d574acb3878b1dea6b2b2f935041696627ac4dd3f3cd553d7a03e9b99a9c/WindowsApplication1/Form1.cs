using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace WindowsApplication1;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> list_0 = new List<WeakReference>();

	private IContainer icontainer_0;

	[DebuggerNonUserCode]
	public Form1()
	{
		smethod_0(this);
		method_0();
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
				Monitor.Enter(list);
				try
				{
					if (flag = list_0.Count == list_0.Capacity)
					{
						num = 0;
						num2 = list_0.Count - 1;
						num3 = 0;
						while (true)
						{
							int num4 = num3;
							num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							weakReference = list_0[num3];
							if (flag = weakReference.IsAlive)
							{
								if (flag2 = num3 != num)
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
				finally
				{
					Monitor.Exit(list);
				}
			}
			catch (Exception exception_)
			{
				Class11.smethod_30(exception_, object_0, num, num3, weakReference, list, num2, flag, flag2, num5);
				throw;
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		bool flag = default(bool);
		try
		{
			try
			{
				if (flag = ((disposing && icontainer_0 != null) ? true : false))
				{
					icontainer_0.Dispose();
				}
			}
			finally
			{
				((Form)this).Dispose(disposing);
			}
		}
		catch (Exception exception_)
		{
			Class11.smethod_24(exception_, this, disposing, flag);
			throw;
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		try
		{
			icontainer_0 = new Container();
			((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
			((Form)this).set_Text("Form1");
		}
		catch (Exception exception_)
		{
			Class11.smethod_22(exception_, this);
			throw;
		}
	}
}
