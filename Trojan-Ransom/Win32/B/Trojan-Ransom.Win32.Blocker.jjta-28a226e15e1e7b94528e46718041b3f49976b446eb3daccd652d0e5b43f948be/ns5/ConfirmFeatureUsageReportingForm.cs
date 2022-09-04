using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns7;
using ns9;

namespace ns5;

internal sealed class ConfirmFeatureUsageReportingForm : Form
{
	private Label m_Label_Desc;

	private Button m_SendUsageReportsBtn;

	private Button m_DoNotSendFeatureUsageReportsBtn;

	private IContainer icontainer_0;

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ConfirmFeatureUsageReportingForm));
		m_Label_Desc = new Label();
		m_SendUsageReportsBtn = new Button();
		m_DoNotSendFeatureUsageReportsBtn = new Button();
		((Control)this).SuspendLayout();
		((Control)m_Label_Desc).set_AutoSize(true);
		((Control)m_Label_Desc).set_Location(new Point(12, 16));
		((Control)m_Label_Desc).set_MaximumSize(new Size(480, 800));
		((Control)m_Label_Desc).set_Name("m_Label_Desc");
		((Control)m_Label_Desc).set_Padding(new Padding(0, 0, 0, 92));
		((Control)m_Label_Desc).set_Size(new Size(442, 159));
		((Control)m_Label_Desc).set_TabIndex(1);
		m_Label_Desc.set_TabStop(true);
		((Control)m_Label_Desc).set_Text(componentResourceManager.GetString("m_Label_Desc.Text"));
		m_Label_Desc.set_UseCompatibleTextRendering(true);
		((Control)m_SendUsageReportsBtn).set_Anchor((AnchorStyles)2);
		m_SendUsageReportsBtn.set_DialogResult((DialogResult)6);
		((ButtonBase)m_SendUsageReportsBtn).set_ImageAlign((ContentAlignment)16);
		((Control)m_SendUsageReportsBtn).set_Location(new Point(97, 105));
		((Control)m_SendUsageReportsBtn).set_Name("m_SendUsageReportsBtn");
		((Control)m_SendUsageReportsBtn).set_Padding(new Padding(5, 0, 0, 0));
		((Control)m_SendUsageReportsBtn).set_Size(new Size(299, 33));
		((Control)m_SendUsageReportsBtn).set_TabIndex(2);
		((Control)m_SendUsageReportsBtn).set_Text("Join the quality improvement program");
		((ButtonBase)m_SendUsageReportsBtn).set_UseVisualStyleBackColor(true);
		((Control)m_DoNotSendFeatureUsageReportsBtn).set_Anchor((AnchorStyles)2);
		m_DoNotSendFeatureUsageReportsBtn.set_DialogResult((DialogResult)7);
		((ButtonBase)m_DoNotSendFeatureUsageReportsBtn).set_ImageAlign((ContentAlignment)16);
		((Control)m_DoNotSendFeatureUsageReportsBtn).set_Location(new Point(97, 144));
		((Control)m_DoNotSendFeatureUsageReportsBtn).set_Name("m_DoNotSendFeatureUsageReportsBtn");
		((Control)m_DoNotSendFeatureUsageReportsBtn).set_Padding(new Padding(5, 0, 0, 0));
		((Control)m_DoNotSendFeatureUsageReportsBtn).set_Size(new Size(299, 33));
		((Control)m_DoNotSendFeatureUsageReportsBtn).set_TabIndex(3);
		((Control)m_DoNotSendFeatureUsageReportsBtn).set_Text("Do not join the quality improvement program");
		((ButtonBase)m_DoNotSendFeatureUsageReportsBtn).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_AutoSize(true);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Control)this).set_BackColor(SystemColors.ControlLightLight);
		((Form)this).set_ClientSize(new Size(504, 190));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)m_DoNotSendFeatureUsageReportsBtn);
		((Control)this).get_Controls().Add((Control)(object)m_SendUsageReportsBtn);
		((Control)this).get_Controls().Add((Control)(object)m_Label_Desc);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ConfirmFeatureUsageReportingForm");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("{0} Quality Improvement Program");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public ConfirmFeatureUsageReportingForm()
	{
		InitializeComponent();
		((Control)m_DoNotSendFeatureUsageReportsBtn).set_Top(((Form)this).get_ClientSize().Height - 13 - ((Control)m_DoNotSendFeatureUsageReportsBtn).get_Height());
		((Control)m_SendUsageReportsBtn).set_Top(((Control)m_DoNotSendFeatureUsageReportsBtn).get_Top() - 6 - ((Control)m_SendUsageReportsBtn).get_Height());
		((ButtonBase)m_SendUsageReportsBtn).set_Image((Image)(object)Class50.smethod_0("ok"));
		((ButtonBase)m_DoNotSendFeatureUsageReportsBtn).set_Image((Image)(object)Class50.smethod_0("error"));
		((Control)m_Label_Desc).set_Text(string.Format(((Control)m_Label_Desc).get_Text(), Class48.string_0, Class48.string_1));
		((Control)this).set_Text(string.Format(((Control)this).get_Text(), Class48.string_0));
	}
}
