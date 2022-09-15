using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class Form4 : Form
{
	private IContainer icontainer_0;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	public Form4()
	{
		Form4.smethod_0((Form)(object)this, (EventHandler)method_0);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				Form4.smethod_1((IDisposable)icontainer_0);
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
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = Form4.smethod_3(Form4.smethod_2(typeof(Form4).TypeHandle));
		Label1 = Form4.smethod_4();
		Label2 = Form4.smethod_4();
		Form4.smethod_5((Control)(object)this);
		Form4.smethod_6(Label1, bool_0: true);
		Form4.smethod_7((Control)(object)Label1, Color.Transparent);
		Form4.smethod_9((Control)(object)Label1, Form4.smethod_8("Comic Sans MS", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Form4.smethod_10((Control)(object)Label1, Color.DarkOrange);
		((Control)Label1).set_Location(new Point(212, 9));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(229, 45));
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("Annabelle.exe");
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.Transparent);
		((Control)Label2).set_Font(new Font("Comic Sans MS", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.DarkOrange);
		((Control)Label2).set_Location(new Point(118, 481));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(387, 23));
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("Creator: iCoreX0812 - Discord: iCoreX0812#1337");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_ClientSize(new Size(632, 513));
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form4");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Credits");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	static void smethod_0(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_1(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Type smethod_2(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static ComponentResourceManager smethod_3(Type type_0)
	{
		return new ComponentResourceManager(type_0);
	}

	static Label smethod_4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static void smethod_5(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_6(Label label_0, bool bool_0)
	{
		label_0.set_AutoSize(bool_0);
	}

	static void smethod_7(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static Font smethod_8(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_9(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_10(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}
}
