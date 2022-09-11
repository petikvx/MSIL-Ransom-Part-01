using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace MetroLoader;

public class Form2 : MetroForm
{
	private IContainer components = null;

	private Label label1;

	private Timer timer1;

	private Timer timer2;

	public Form2()
	{
		InitializeComponent();
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		((Control)label1).set_Text("Uygulama Ediniliyor...");
		Thread.Sleep(200);
	}

	private void metroButton1_Click(object sender, EventArgs e)
	{
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		((Control)label1).set_Text("'patbobrcs.exe' bekleniyor...");
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		Application.Exit();
		timer2.Stop();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((MetroForm)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		components = new Container();
		label1 = new Label();
		timer1 = new Timer(components);
		timer2 = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)label1).set_Location(new Point(23, 60));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(85, 13));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Kontrol Ediliyor...");
		timer1.set_Enabled(true);
		timer1.set_Interval(1000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		timer2.set_Enabled(true);
		timer2.set_Interval(2000);
		timer2.add_Tick((EventHandler)timer2_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 91));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("Form2");
		((MetroForm)this).set_Resizable(false);
		((MetroForm)this).set_Style((MetroColorStyle)13);
		((Control)this).set_Text("Yazılım Açılıyor");
		((MetroForm)this).set_TextAlign((MetroFormTextAlign)1);
		((Form)this).add_Load((EventHandler)Form2_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
