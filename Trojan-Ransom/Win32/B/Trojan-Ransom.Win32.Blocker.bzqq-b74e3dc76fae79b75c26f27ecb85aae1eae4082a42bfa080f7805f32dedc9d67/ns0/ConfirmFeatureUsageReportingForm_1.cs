using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using System.Reflection;
using System.Windows.Forms;
using SmartAssembly.Attributes;
using SmartAssembly.License;
using SmartAssembly.Shared;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartExceptionsWithUI;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;

namespace ns0;

internal sealed class ConfirmFeatureUsageReportingForm_1 : Form
{
	internal Label label_0;

	internal Button button_0;

	internal Button button_1;

	internal IContainer icontainer_0;

	protected override void Dispose(bool disposing)
	{
		int num = default(int);
		try
		{
			try
			{
				num = 3;
				if (disposing)
				{
					num = 0;
					if (icontainer_0 != null)
					{
						num = 4;
						icontainer_0.Dispose();
					}
					else
					{
						num = 2;
					}
				}
				else
				{
					num = 2;
				}
				((Form)this).Dispose(disposing);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, disposing);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException3(exception2, num, this, disposing);
			throw;
		}
	}

	private void InitializeComponent()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		ComponentResourceManager componentResourceManager = default(ComponentResourceManager);
		Label o = default(Label);
		Button o2 = default(Button);
		Button o3 = default(Button);
		int num2 = default(int);
		try
		{
			try
			{
				num = 14;
				componentResourceManager = new ComponentResourceManager(SendingReportFeedbackEventArgs1.smethod_0(typeof(ConfirmFeatureUsageReportingForm_1).TypeHandle, 390, 509));
				o = (label_0 = new Label());
				num = 13;
				o2 = (button_0 = new Button());
				o3 = (button_1 = new Button());
				num = 9;
				UnhandledExceptionHandlerWithUI.smethod_2((Control)(object)this, 609, 626);
				DoNotEncodeStringsAttribute.smethod_1((Control)(object)label_0, bool_0: true, 877, 804);
				num = 0;
				Class21.smethod_1((Control)(object)label_0, new Point(12, 16), 762, 721);
				num = 16;
				Class35.smethod_0((Control)(object)label_0, new Size(480, 800), 39, 104);
				num = 28;
				DoNotPruneTypeAttribute.smethod_1((Control)(object)label_0, "m_Label_Desc", 479, 487);
				num = 22;
				SmartAssembly.License.License.smethod_3((Control)(object)label_0, new Padding(0, 0, 0, 92), 200, 164);
				num = 34;
				Class27.smethod_0((Control)(object)label_0, new Size(442, 159), 420, 402);
				num = 17;
				WaitSendingReportControl.smethod_0((Control)(object)label_0, 1, 315, 320);
				Class4.smethod_1(label_0, bool_0: true, 718, 764);
				num = 21;
				SmartAssembly.License.License.smethod_4((Control)(object)label_0, Class32.smethod_0(componentResourceManager, "m_Label_Desc.Text", 564, 637), 390, 465);
				num = 10;
				DoNotDistributeAttribute.smethod_0(label_0, bool_0: true, 349, 377);
				WaitSendingReportControl.smethod_1((Control)(object)button_0, (AnchorStyles)2, 141, 150);
				num = 15;
				DoNotPruneTypeAttribute.smethod_2(button_0, (DialogResult)6, 745, 643);
				UsageCounts.smethod_1((ButtonBase)(object)button_0, (ContentAlignment)16, 686, 704);
				num = 20;
				Class21.smethod_1((Control)(object)button_0, new Point(97, 105), 820, 799);
				num = 8;
				DoNotPruneTypeAttribute.smethod_1((Control)(object)button_0, "m_SendUsageReportsBtn", 166, 158);
				num = 31;
				SmartAssembly.License.License.smethod_3((Control)(object)button_0, new Padding(5, 0, 0, 0), 717, 673);
				num = 29;
				Class27.smethod_0((Control)(object)button_0, new Size(299, 33), 579, 629);
				num = 26;
				WaitSendingReportControl.smethod_0((Control)(object)button_0, 2, 513, 634);
				SmartAssembly.License.License.smethod_4((Control)(object)button_0, "Join the quality improvement program", 34, 117);
				num = 32;
				AppNameFinder.smethod_0((ButtonBase)(object)button_0, bool_0: true, 939, 912);
				WaitSendingReportControl.smethod_1((Control)(object)button_1, (AnchorStyles)2, 881, 874);
				num = 7;
				DoNotPruneTypeAttribute.smethod_2(button_1, (DialogResult)7, 377, 275);
				UsageCounts.smethod_1((ButtonBase)(object)button_1, (ContentAlignment)16, 849, 831);
				num = 19;
				Class21.smethod_1((Control)(object)button_1, new Point(97, 144), 910, 933);
				num = 12;
				DoNotPruneTypeAttribute.smethod_1((Control)(object)button_1, "m_DoNotSendFeatureUsageReportsBtn", 750, 726);
				num = 6;
				SmartAssembly.License.License.smethod_3((Control)(object)button_1, new Padding(5, 0, 0, 0), 486, 394);
				num = 2;
				Class27.smethod_0((Control)(object)button_1, new Size(299, 33), 417, 407);
				num = 25;
				WaitSendingReportControl.smethod_0((Control)(object)button_1, 3, 479, 420);
				SmartAssembly.License.License.smethod_4((Control)(object)button_1, "Do not join the quality improvement program", 552, 639);
				num = 3;
				((ButtonBase)button_1).set_UseVisualStyleBackColor(true);
				((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
				num = 33;
				((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
				((Control)this).set_AutoSize(true);
				((Form)this).set_AutoSizeMode((AutoSizeMode)0);
				((Control)this).set_BackColor(SystemColors.ControlLightLight);
				num = 11;
				((Form)this).set_ClientSize(new Size(504, 190));
				((Form)this).set_ControlBox(false);
				((Control)this).get_Controls().Add((Control)(object)button_1);
				num = 18;
				((Control)this).get_Controls().Add((Control)(object)button_0);
				((Control)this).get_Controls().Add((Control)(object)label_0);
				num = 4;
				((Form)this).set_FormBorderStyle((FormBorderStyle)1);
				((Form)this).set_MaximizeBox(false);
				((Form)this).set_MinimizeBox(false);
				((Control)this).set_Name("ConfirmFeatureUsageReportingForm");
				num = 24;
				((Form)this).set_ShowInTaskbar(false);
				((Form)this).set_SizeGripStyle((SizeGripStyle)2);
				((Form)this).set_StartPosition((FormStartPosition)1);
				((Control)this).set_Text("{0} Quality Improvement Program");
				num = 27;
				((Form)this).set_TopMost(true);
				((Control)this).ResumeLayout(false);
				((Control)this).PerformLayout();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, componentResourceManager, this);
				throw;
			}
			num2 = 4;
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException7(exception2, componentResourceManager, o, o2, o3, num, num2, this);
			throw;
		}
	}

	public ConfirmFeatureUsageReportingForm_1()
	{
		Size size_ = default(Size);
		try
		{
			try
			{
				InitializeComponent();
				Button control_ = button_1;
				size_ = ReportSender.smethod_0((Form)(object)this, 375, 380);
				UsageReportSender.smethod_11((Control)(object)control_, ReportSender.smethod_1(ref size_, 152, 242) - 13 - SimpleZip.Class14.smethod_0((Control)(object)button_1, 795, 846), 767, 651);
				UsageReportSender.smethod_11((Control)(object)button_0, SimpleZip.Class14.smethod_0((Control)(object)button_1, 383, 297) - 6 - SimpleZip.Class14.smethod_0((Control)(object)button_0, 117, 32), 900, 1008);
				SimpleZip.Class14.smethod_1((ButtonBase)(object)button_0, (Image)(object)Class40.smethod_0("ok"), 900, 916);
				SimpleZip.Class14.smethod_1((ButtonBase)(object)button_1, (Image)(object)Class40.smethod_0("error"), 129, 145);
				((Control)label_0).set_Text(string.Format(((Control)label_0).get_Text(), Class38.string_0, Class38.string_1));
				((Control)this).set_Text(string.Format(((Control)this).get_Text(), Class38.string_0));
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, size_, this);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException2(exception2, size_, this);
			throw;
		}
	}

	static ConfirmFeatureUsageReportingForm_1()
	{
		try
		{
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	internal static byte[] smethod_0(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 22:
					return memoryStream_0.ToArray();
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, memoryStream_0, int_0, int_1);
			throw;
		}
	}

	internal static string[] smethod_1(IsolatedStorageFile isolatedStorageFile_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 39:
					return isolatedStorageFile_0.GetFileNames(string_0);
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, isolatedStorageFile_0, string_0, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_2(MemberInfo memberInfo_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 6:
					return memberInfo_0.Name;
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, memberInfo_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_3(Form form_0, Size size_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 5;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 14:
					form_0.set_AutoScaleBaseSize(size_0);
					return;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, form_0, size_0, int_0, int_1);
			throw;
		}
	}
}
