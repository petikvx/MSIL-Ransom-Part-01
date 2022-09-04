using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

internal class Form0 : Form
{
	internal Timer timer_0;

	public IContainer icontainer_0;

	private TextBox textBox_0;

	private Button button_0;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private Label label_3;

	private Panel panel_0;

	private ProgressBar progressBar_0;

	public Form0()
	{
		method_0();
		Class22.smethod_44(this);
	}

	void Form.Dispose(bool disposing)
	{
		try
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
		catch (Exception exception_)
		{
			Class15.smethod_24(exception_, this, disposing);
			throw;
		}
	}

	public void method_0()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		Point point = default(Point);
		Size size = default(Size);
		SizeF sizeF = default(SizeF);
		try
		{
			((Control)this).set_Visible(false);
			((Form)this).set_ShowInTaskbar(false);
			((Form)this).set_Opacity(0.0);
			vmethod_1(new TextBox());
			vmethod_3(new Button());
			vmethod_5(new Label());
			vmethod_7(new Label());
			vmethod_9(new Label());
			vmethod_11(new Label());
			vmethod_13(new Panel());
			vmethod_15(new ProgressBar());
			((Control)this).SuspendLayout();
			TextBox obj = vmethod_0();
			point = new Point(12, 23);
			((Control)obj).set_Location(point);
			((Control)vmethod_0()).set_Name(Class6.smethod_0(22338));
			vmethod_0().set_Text(Class6.smethod_0(22351));
			TextBox obj2 = vmethod_0();
			size = new Size(100, 20);
			((Control)obj2).set_Size(size);
			((Control)vmethod_0()).set_TabIndex(0);
			Button obj3 = vmethod_2();
			point = new Point(12, 49);
			((Control)obj3).set_Location(point);
			((Control)vmethod_2()).set_Name(Class6.smethod_0(22352));
			Button obj4 = vmethod_2();
			size = new Size(75, 23);
			((Control)obj4).set_Size(size);
			((Control)vmethod_2()).set_TabIndex(1);
			((ButtonBase)vmethod_2()).set_Text(Class6.smethod_0(22352));
			((ButtonBase)vmethod_2()).set_UseVisualStyleBackColor(true);
			sizeF = new SizeF(6f, 13f);
			((ContainerControl)this).set_AutoScaleDimensions(sizeF);
			((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
			size = new Size(284, 262);
			((Form)this).set_ClientSize(size);
			((Control)this).get_Controls().Add((Control)(object)vmethod_14());
			((Control)this).get_Controls().Add((Control)(object)vmethod_12());
			((Control)this).get_Controls().Add((Control)(object)vmethod_10());
			((Control)this).get_Controls().Add((Control)(object)vmethod_8());
			((Control)this).get_Controls().Add((Control)(object)vmethod_6());
			((Control)this).get_Controls().Add((Control)(object)vmethod_4());
			((Control)this).get_Controls().Add((Control)(object)vmethod_2());
			((Control)this).get_Controls().Add((Control)(object)vmethod_0());
			((Control)this).set_Name(Class6.smethod_0(22365));
			((Form)this).set_Text(Class6.smethod_0(22365));
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
			((Form)this).set_Opacity(0.0);
			timer_0 = new Timer();
			((Form)this).set_ShowInTaskbar(false);
			timer_0.set_Interval(2000);
			timer_0.add_Tick((EventHandler)timer_0_Tick);
		}
		catch (Exception exception_)
		{
			Point point2 = default(Point);
			Size size2 = default(Size);
			SizeF sizeF2 = default(SizeF);
			Class15.smethod_29(exception_, this, point2, point, size2, size, sizeF2, sizeF);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void timer_0_Tick(object sender, EventArgs e)
	{
		Exception object_ = default(Exception);
		try
		{
			try
			{
				Class22.smethod_24();
				Class22.smethod_28();
				Class22.smethod_15();
				Class22.smethod_35();
				Class22.smethod_33();
				Class22.smethod_37();
				Class22.smethod_38();
				Class22.smethod_18();
				ProjectData.EndApp();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				object_ = ex;
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception exception_)
		{
			Class15.smethod_26(exception_, this, sender, e, object_);
			throw;
		}
	}

	[SpecialName]
	internal virtual TextBox vmethod_0()
	{
		try
		{
			return textBox_0;
		}
		catch (Exception exception_)
		{
			TextBox object_ = default(TextBox);
			Class15.smethod_24(exception_, this, object_);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_1(TextBox textBox_1)
	{
		try
		{
			textBox_0 = textBox_1;
		}
		catch (Exception exception_)
		{
			Class15.smethod_24(exception_, this, textBox_1);
			throw;
		}
	}

	[SpecialName]
	internal virtual Button vmethod_2()
	{
		try
		{
			return button_0;
		}
		catch (Exception exception_)
		{
			Button object_ = default(Button);
			Class15.smethod_24(exception_, this, object_);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_3(Button button_1)
	{
		try
		{
			button_0 = button_1;
		}
		catch (Exception exception_)
		{
			Class15.smethod_24(exception_, this, button_1);
			throw;
		}
	}

	[SpecialName]
	internal virtual Label vmethod_4()
	{
		try
		{
			return label_0;
		}
		catch (Exception exception_)
		{
			Label object_ = default(Label);
			Class15.smethod_24(exception_, this, object_);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_5(Label label_4)
	{
		try
		{
			label_0 = label_4;
		}
		catch (Exception exception_)
		{
			Class15.smethod_24(exception_, this, label_4);
			throw;
		}
	}

	[SpecialName]
	internal virtual Label vmethod_6()
	{
		try
		{
			return label_1;
		}
		catch (Exception exception_)
		{
			Label object_ = default(Label);
			Class15.smethod_24(exception_, this, object_);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_7(Label label_4)
	{
		try
		{
			label_1 = label_4;
		}
		catch (Exception exception_)
		{
			Class15.smethod_24(exception_, this, label_4);
			throw;
		}
	}

	[SpecialName]
	internal virtual Label vmethod_8()
	{
		try
		{
			return label_2;
		}
		catch (Exception exception_)
		{
			Label object_ = default(Label);
			Class15.smethod_24(exception_, this, object_);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_9(Label label_4)
	{
		try
		{
			label_2 = label_4;
		}
		catch (Exception exception_)
		{
			Class15.smethod_24(exception_, this, label_4);
			throw;
		}
	}

	[SpecialName]
	internal virtual Label vmethod_10()
	{
		try
		{
			return label_3;
		}
		catch (Exception exception_)
		{
			Label object_ = default(Label);
			Class15.smethod_24(exception_, this, object_);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_11(Label label_4)
	{
		try
		{
			label_3 = label_4;
		}
		catch (Exception exception_)
		{
			Class15.smethod_24(exception_, this, label_4);
			throw;
		}
	}

	[SpecialName]
	internal virtual Panel vmethod_12()
	{
		try
		{
			return panel_0;
		}
		catch (Exception exception_)
		{
			Panel object_ = default(Panel);
			Class15.smethod_24(exception_, this, object_);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_13(Panel panel_1)
	{
		try
		{
			panel_0 = panel_1;
		}
		catch (Exception exception_)
		{
			Class15.smethod_24(exception_, this, panel_1);
			throw;
		}
	}

	[SpecialName]
	internal virtual ProgressBar vmethod_14()
	{
		try
		{
			return progressBar_0;
		}
		catch (Exception exception_)
		{
			ProgressBar object_ = default(ProgressBar);
			Class15.smethod_24(exception_, this, object_);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_15(ProgressBar progressBar_1)
	{
		try
		{
			progressBar_0 = progressBar_1;
		}
		catch (Exception exception_)
		{
			Class15.smethod_24(exception_, this, progressBar_1);
			throw;
		}
	}
}
