using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public sealed class GControl0 : UserControl
{
	private IContainer icontainer_0;

	private static string string_0;

	private static string string_1;

	public GControl0()
	{
		method_0();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_Name(Class16.smethod_0(-561791303));
		((Control)this).ResumeLayout(false);
	}

	public static string smethod_0()
	{
		return Class16.smethod_0(-561791290);
	}

	public static void smethod_1(string string_2)
	{
		string_0 = string_2;
	}

	public static string smethod_2()
	{
		return Class16.smethod_0(-561791276);
	}

	public static void smethod_3(string string_2)
	{
		string_1 = string_2;
	}
}
