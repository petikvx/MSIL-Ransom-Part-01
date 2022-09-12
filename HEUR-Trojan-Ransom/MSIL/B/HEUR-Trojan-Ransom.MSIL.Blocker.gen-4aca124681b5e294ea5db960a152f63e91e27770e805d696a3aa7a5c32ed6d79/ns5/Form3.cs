using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns10;
using ns6;

namespace ns5;

internal sealed class Form3 : Form
{
	private Label label_0;

	private Button button_0;

	private Button button_1;

	private IContainer icontainer_0 = null;

	[NonSerialized]
	internal static GetString getString_0;

	void Form.Dispose(bool disposing)
	{
		bool flag;
		if (flag = disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_0()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form3));
		label_0 = new Label();
		button_0 = new Button();
		button_1 = new Button();
		((Control)this).SuspendLayout();
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Location(new Point(12, 16));
		((Control)label_0).set_MaximumSize(new Size(480, 800));
		((Control)label_0).set_Name(getString_0(107383948));
		((Control)label_0).set_Padding(new Padding(0, 0, 0, 92));
		((Control)label_0).set_Size(new Size(442, 159));
		((Control)label_0).set_TabIndex(1);
		label_0.set_TabStop(true);
		((Control)label_0).set_Text(componentResourceManager.GetString(getString_0(107383899)));
		label_0.set_UseCompatibleTextRendering(true);
		((Control)button_0).set_Anchor((AnchorStyles)2);
		button_0.set_DialogResult((DialogResult)6);
		((ButtonBase)button_0).set_ImageAlign((ContentAlignment)16);
		((Control)button_0).set_Location(new Point(97, 105));
		((Control)button_0).set_Name(getString_0(107383906));
		((Control)button_0).set_Padding(new Padding(5, 0, 0, 0));
		((Control)button_0).set_Size(new Size(299, 33));
		((Control)button_0).set_TabIndex(2);
		((Control)button_0).set_Text(getString_0(107383877));
		((ButtonBase)button_0).set_UseVisualStyleBackColor(true);
		((Control)button_1).set_Anchor((AnchorStyles)2);
		button_1.set_DialogResult((DialogResult)7);
		((ButtonBase)button_1).set_ImageAlign((ContentAlignment)16);
		((Control)button_1).set_Location(new Point(97, 144));
		((Control)button_1).set_Name(getString_0(107383796));
		((Control)button_1).set_Padding(new Padding(5, 0, 0, 0));
		((Control)button_1).set_Size(new Size(299, 33));
		((Control)button_1).set_TabIndex(3);
		((Control)button_1).set_Text(getString_0(107383783));
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
		((Control)this).set_Name(getString_0(107384234));
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text(getString_0(107384157));
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public Form3()
	{
		method_0();
		((Control)button_1).set_Top(((Form)this).get_ClientSize().Height - 13 - ((Control)button_1).get_Height());
		((Control)button_0).set_Top(((Control)button_1).get_Top() - 6 - ((Control)button_0).get_Height());
		((ButtonBase)button_0).set_Image((Image)(object)Class57.smethod_0(getString_0(107387516)));
		((ButtonBase)button_1).set_Image((Image)(object)Class57.smethod_0(getString_0(107387511)));
		((Control)label_0).set_Text(string.Format(((Control)label_0).get_Text(), Class46.string_0, Class46.string_1));
		((Control)this).set_Text(string.Format(((Control)this).get_Text(), Class46.string_0));
	}

	static Form3()
	{
		Strings.CreateGetStringDelegate(typeof(Form3));
	}
}
