using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;

namespace ns0;

internal sealed class ConfirmFeatureUsageReportingForm : Form
{
	internal Label m_Label_Desc;

	internal Button m_SendUsageReportsBtn;

	internal Button m_DoNotSendFeatureUsageReportsBtn;

	internal IContainer icontainer_0;

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
			((Form)this).Dispose(disposing);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, disposing);
			throw;
		}
	}

	private void InitializeComponent()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = default(ComponentResourceManager);
		try
		{
			componentResourceManager = new ComponentResourceManager(DoNotEncodeStringsAttribute.smethod_0(typeof(ConfirmFeatureUsageReportingForm).TypeHandle, 214, 143));
			Label val = (m_Label_Desc = new Label());
			Button val2 = (m_SendUsageReportsBtn = new Button());
			Button val3 = (m_DoNotSendFeatureUsageReportsBtn = new Button());
			((Control)this).SuspendLayout();
			smethod_0((Control)(object)m_Label_Desc, bool_0: true, 843, 824);
			((Control)m_Label_Desc).set_Location(new Point(12, 16));
			((Control)m_Label_Desc).set_MaximumSize(new Size(480, 800));
			((Control)m_Label_Desc).set_Name("m_Label_Desc");
			((Control)m_Label_Desc).set_Padding(new Padding(0, 0, 0, 92));
			((Control)m_Label_Desc).set_Size(new Size(442, 159));
			UsageCounts.smethod_2((Control)(object)m_Label_Desc, 1, 440, 414);
			m_Label_Desc.set_TabStop(true);
			Class24.smethod_0((Control)(object)m_Label_Desc, componentResourceManager.GetString("m_Label_Desc.Text"), 497, 508);
			m_Label_Desc.set_UseCompatibleTextRendering(true);
			((Control)m_SendUsageReportsBtn).set_Anchor((AnchorStyles)2);
			m_SendUsageReportsBtn.set_DialogResult((DialogResult)6);
			((ButtonBase)m_SendUsageReportsBtn).set_ImageAlign((ContentAlignment)16);
			((Control)m_SendUsageReportsBtn).set_Location(new Point(97, 105));
			((Control)m_SendUsageReportsBtn).set_Name("m_SendUsageReportsBtn");
			((Control)m_SendUsageReportsBtn).set_Padding(new Padding(5, 0, 0, 0));
			((Control)m_SendUsageReportsBtn).set_Size(new Size(299, 33));
			UsageCounts.smethod_2((Control)(object)m_SendUsageReportsBtn, 2, 617, 591);
			Class24.smethod_0((Control)(object)m_SendUsageReportsBtn, "Join the quality improvement program", 825, 820);
			((ButtonBase)m_SendUsageReportsBtn).set_UseVisualStyleBackColor(true);
			((Control)m_DoNotSendFeatureUsageReportsBtn).set_Anchor((AnchorStyles)2);
			m_DoNotSendFeatureUsageReportsBtn.set_DialogResult((DialogResult)7);
			((ButtonBase)m_DoNotSendFeatureUsageReportsBtn).set_ImageAlign((ContentAlignment)16);
			((Control)m_DoNotSendFeatureUsageReportsBtn).set_Location(new Point(97, 144));
			((Control)m_DoNotSendFeatureUsageReportsBtn).set_Name("m_DoNotSendFeatureUsageReportsBtn");
			((Control)m_DoNotSendFeatureUsageReportsBtn).set_Padding(new Padding(5, 0, 0, 0));
			((Control)m_DoNotSendFeatureUsageReportsBtn).set_Size(new Size(299, 33));
			UsageCounts.smethod_2((Control)(object)m_DoNotSendFeatureUsageReportsBtn, 3, 462, 488);
			Class24.smethod_0((Control)(object)m_DoNotSendFeatureUsageReportsBtn, "Do not join the quality improvement program", 44, 33);
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
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, componentResourceManager, this);
			throw;
		}
	}

	public ConfirmFeatureUsageReportingForm()
	{
		Size size_ = default(Size);
		try
		{
			InitializeComponent();
			Button doNotSendFeatureUsageReportsBtn = m_DoNotSendFeatureUsageReportsBtn;
			size_ = ((Form)this).get_ClientSize();
			((Control)doNotSendFeatureUsageReportsBtn).set_Top(HeaderControl.smethod_1(ref size_, 399, 403) - 13 - ((Control)m_DoNotSendFeatureUsageReportsBtn).get_Height());
			((Control)m_SendUsageReportsBtn).set_Top(((Control)m_DoNotSendFeatureUsageReportsBtn).get_Top() - 6 - ((Control)m_SendUsageReportsBtn).get_Height());
			((ButtonBase)m_SendUsageReportsBtn).set_Image((Image)(object)Class37.smethod_0("ok"));
			((ButtonBase)m_DoNotSendFeatureUsageReportsBtn).set_Image((Image)(object)Class37.smethod_0("error"));
			((Control)m_Label_Desc).set_Text(string.Format(((Control)m_Label_Desc).get_Text(), Class35.string_0, Class35.string_1));
			((Control)this).set_Text(string.Format(((Control)this).get_Text(), Class35.string_0));
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, size_, this);
			throw;
		}
	}

	static ConfirmFeatureUsageReportingForm()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static void smethod_0(Control control_0, bool bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 115:
				control_0.set_AutoSize(bool_0);
				return;
			case 116:
				control_0.set_TabStop(bool_0);
				return;
			case 117:
				control_0.set_Enabled(bool_0);
				return;
			}
		}
	}

	internal static int smethod_1(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 51:
				return stream_0.ReadByte();
			}
		}
	}

	internal static ulong smethod_2(BinaryReader binaryReader_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 7:
				return binaryReader_0.ReadUInt64();
			}
		}
	}

	internal static int smethod_3(ref DateTime dateTime_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 46:
				return dateTime_0.Minute;
			}
		}
	}
}
