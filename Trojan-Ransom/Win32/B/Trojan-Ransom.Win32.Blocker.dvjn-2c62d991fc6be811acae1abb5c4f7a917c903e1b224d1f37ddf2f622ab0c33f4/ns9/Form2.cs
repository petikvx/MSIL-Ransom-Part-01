using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns10;
using ns3;

namespace ns9;

internal sealed class Form2 : Form
{
	private Label label_0;

	private Button button_0;

	private Button button_1;

	private IContainer icontainer_0;

	void Form.Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
			((Form)this).Dispose(disposing);
		}
		catch (Exception exception_)
		{
			Class38.smethod_2(exception_, this, disposing);
			throw;
		}
	}

	private void method_0()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = default(ComponentResourceManager);
		try
		{
			componentResourceManager = new ComponentResourceManager(typeof(Form2));
			label_0 = new Label();
			button_0 = new Button();
			button_1 = new Button();
			((Control)this).SuspendLayout();
			((Control)label_0).set_AutoSize(true);
			((Control)label_0).set_Location(new Point(12, 16));
			((Control)label_0).set_MaximumSize(new Size(480, 800));
			((Control)label_0).set_Name(Class15.smethod_0(955641));
			((Control)label_0).set_Padding(new Padding(0, 0, 0, 92));
			((Control)label_0).set_Size(new Size(442, 159));
			((Control)label_0).set_TabIndex(1);
			label_0.set_TabStop(true);
			((Control)label_0).set_Text(componentResourceManager.GetString(Class15.smethod_0(955658)));
			label_0.set_UseCompatibleTextRendering(true);
			((Control)button_0).set_Anchor((AnchorStyles)2);
			button_0.set_DialogResult((DialogResult)6);
			((ButtonBase)button_0).set_ImageAlign((ContentAlignment)16);
			((Control)button_0).set_Location(new Point(97, 105));
			((Control)button_0).set_Name(Class15.smethod_0(955683));
			((Control)button_0).set_Padding(new Padding(5, 0, 0, 0));
			((Control)button_0).set_Size(new Size(299, 33));
			((Control)button_0).set_TabIndex(2);
			((Control)button_0).set_Text(Class15.smethod_0(955712));
			((ButtonBase)button_0).set_UseVisualStyleBackColor(true);
			((Control)button_1).set_Anchor((AnchorStyles)2);
			button_1.set_DialogResult((DialogResult)7);
			((ButtonBase)button_1).set_ImageAlign((ContentAlignment)16);
			((Control)button_1).set_Location(new Point(97, 144));
			((Control)button_1).set_Name(Class15.smethod_0(955761));
			((Control)button_1).set_Padding(new Padding(5, 0, 0, 0));
			((Control)button_1).set_Size(new Size(299, 33));
			((Control)button_1).set_TabIndex(3);
			((Control)button_1).set_Text(Class15.smethod_0(955806));
			((ButtonBase)button_1).set_UseVisualStyleBackColor(true);
			((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
			((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
			((Control)this).set_AutoSize(true);
			((Form)this).set_AutoSizeMode((AutoSizeMode)0);
			((Control)this).set_BackColor(SystemColors.ControlLightLight);
			((Form)this).set_ClientSize(new Size(504, 190));
			((Form)this).set_ControlBox(false);
			((Control)this).get_Controls().Add((Control)(object)button_1);
			((Control)this).get_Controls().Add((Control)(object)button_0);
			((Control)this).get_Controls().Add((Control)(object)label_0);
			((Form)this).set_FormBorderStyle((FormBorderStyle)1);
			((Form)this).set_MaximizeBox(false);
			((Form)this).set_MinimizeBox(false);
			((Control)this).set_Name(Class15.smethod_0(955867));
			((Form)this).set_ShowInTaskbar(false);
			((Form)this).set_SizeGripStyle((SizeGripStyle)2);
			((Form)this).set_StartPosition((FormStartPosition)1);
			((Control)this).set_Text(Class15.smethod_0(955912));
			((Form)this).set_TopMost(true);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
		catch (Exception exception_)
		{
			Class38.smethod_2(exception_, componentResourceManager, this);
			throw;
		}
	}

	public Form2()
	{
		Size clientSize = default(Size);
		try
		{
			method_0();
			Button obj = button_1;
			clientSize = ((Form)this).get_ClientSize();
			((Control)obj).set_Top(clientSize.Height - 13 - ((Control)button_1).get_Height());
			((Control)button_0).set_Top(((Control)button_1).get_Top() - 6 - ((Control)button_0).get_Height());
			((ButtonBase)button_0).set_Image((Image)(object)Class61.smethod_0(Class15.smethod_0(951758)));
			((ButtonBase)button_1).set_Image((Image)(object)Class61.smethod_0(Class15.smethod_0(951763)));
			((Control)label_0).set_Text(string.Format(((Control)label_0).get_Text(), Class59.string_0, Class59.string_1));
			((Control)this).set_Text(string.Format(((Control)this).get_Text(), Class59.string_0));
		}
		catch (Exception exception_)
		{
			Class38.smethod_2(exception_, clientSize, this);
			throw;
		}
	}
}
