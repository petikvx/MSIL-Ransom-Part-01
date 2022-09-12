using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using QRCoder;
using fuck_rats_antivirus.My;

namespace fuck_rats_antivirus;

[DesignerGenerated]
public class Form2 : Form
{
	private IContainer components;

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button1_Click;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button2_Click;
			Button button = _Button2;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	public Form2()
	{
		((Form)this).add_Load((EventHandler)Form2_Load);
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		Button1 = new Button();
		TextBox1 = new TextBox();
		PictureBox1 = new PictureBox();
		Button2 = new Button();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)Button1).set_BackColor(Color.FromArgb(192, 192, 0));
		((ButtonBase)Button1).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button1).set_ForeColor(Color.Red);
		((Control)Button1).set_Location(new Point(13, 351));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(339, 51));
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("COP&Y");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((TextBoxBase)TextBox1).set_BackColor(SystemColors.WindowFrame);
		((Control)TextBox1).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)TextBox1).set_ForeColor(Color.FromArgb(255, 128, 0));
		((Control)TextBox1).set_Location(new Point(12, 321));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(339, 24));
		((Control)TextBox1).set_TabIndex(2);
		TextBox1.set_Text("1vDXoYoRRwvYLqhm5y5GFvtjwVD2FwRKg");
		((Control)PictureBox1).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)PictureBox1).set_Location(new Point(12, 12));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(339, 303));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(1);
		PictureBox1.set_TabStop(false);
		((ButtonBase)Button2).set_BackColor(Color.FromArgb(192, 192, 0));
		((ButtonBase)Button2).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button2).set_FlatStyle((FlatStyle)0);
		((Control)Button2).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button2).set_ForeColor(Color.Red);
		((Control)Button2).set_Location(new Point(13, 407));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(339, 51));
		((Control)Button2).set_TabIndex(3);
		((ButtonBase)Button2).set_Text("&CLOSE");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(64, 64, 64));
		((Form)this).set_ClientSize(new Size(360, 470));
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).set_Name("Form2");
		((Form)this).set_Text("Form2");
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		((Computer)MyProject.Computer).get_Clipboard().SetText(TextBox1.get_Text());
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		QRCodeData val = new QRCodeGenerator().CreateQrCode(TextBox1.get_Text(), (ECCLevel)2, false, false, (EciMode)0, -1);
		QRCode val2 = new QRCode(val);
		PictureBox1.set_Image((Image)(object)val2.GetGraphic(6));
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
