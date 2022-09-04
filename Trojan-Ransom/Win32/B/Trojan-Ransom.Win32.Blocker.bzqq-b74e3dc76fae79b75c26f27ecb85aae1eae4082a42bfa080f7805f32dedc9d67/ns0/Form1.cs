using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using SmartAssembly.License;
using SmartAssembly.Shared;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartExceptionsWithUI;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;

namespace ns0;

[DesignerCategory("Code")]
internal sealed class Form1 : Form
{
	internal SecurityExceptionEventArgs securityExceptionEventArgs_0;

	internal PoweredBy poweredBy_0;

	internal Button button_0;

	internal Button button_1;

	internal HeaderControl headerControl_0;

	internal AutoHeightLabel autoHeightLabel_0;

	private void method_0()
	{
		int num = default(int);
		Control[] array = default(Control[]);
		try
		{
			num = 16;
			UnhandledExceptionHandlerWithUI.smethod_2((Control)(object)this, 253, 238);
			WaitSendingReportControl.smethod_1((Control)(object)button_1, (AnchorStyles)10, 318, 293);
			num = 20;
			SimpleZip.Class14.smethod_2((ButtonBase)(object)button_1, (FlatStyle)3, 868, 839);
			Class27.smethod_0((Control)(object)button_1, new Size(100, 24), 623, 601);
			num = 18;
			Class21.smethod_1((Control)(object)button_1, new Point(408 - Class33.smethod_5((Control)(object)button_1, 326, 374), 188), 364, 327);
			num = 4;
			WaitSendingReportControl.smethod_0((Control)(object)button_1, 0, 859, 800);
			SmartAssembly.License.License.smethod_4((Control)(object)button_1, "&Quit", 359, 304);
			num = 2;
			DESCryptoIndirector.smethod_2((Control)(object)button_1, method_2, 512, 622);
			num = 11;
			WaitSendingReportControl.smethod_1((Control)(object)button_0, (AnchorStyles)10, 540, 519);
			SimpleZip.Class14.smethod_2((ButtonBase)(object)button_0, (FlatStyle)3, 810, 777);
			num = 14;
			Class27.smethod_0((Control)(object)button_0, new Size(100, 24), 157, 171);
			num = 13;
			Class21.smethod_1((Control)(object)button_0, new Point(Class27.smethod_1((Control)(object)button_1, 664, 735) - Class33.smethod_5((Control)(object)button_0, 501, 453) - 6, 188), 417, 394);
			num = 0;
			WaitSendingReportControl.smethod_0((Control)(object)button_0, 1, 649, 754);
			SmartAssembly.License.License.smethod_4((Control)(object)button_0, "&Continue", 205, 154);
			num = 9;
			DESCryptoIndirector.smethod_2((Control)(object)button_0, method_1, 659, 765);
			num = 19;
			WaitSendingReportControl.smethod_1((Control)(object)poweredBy_0, (AnchorStyles)6, 26, 1);
			SecurityExceptionEventArgs.smethod_4((Control)(object)poweredBy_0, 6, 186, 120, 32, 822, 807);
			num = 8;
			headerControl_0.IconState = IconState.Warning;
			WaitSendingReportControl.smethod_1((Control)(object)autoHeightLabel_0, (AnchorStyles)13, 182, 173);
			num = 6;
			Class21.smethod_1((Control)(object)autoHeightLabel_0, new Point(20, 72), 942, 901);
			num = 3;
			Class27.smethod_0((Control)(object)autoHeightLabel_0, new Size(382, 13), 334, 376);
			num = 15;
			ConfirmFeatureUsageReportingForm_1.smethod_3((Form)(object)this, new Size(5, 13), 273, 287);
			((Form)this).set_ClientSize(new Size(418, 224));
			num = 1;
			((Form)this).set_ControlBox(false);
			ControlCollection controls = ((Control)this).get_Controls();
			array = (Control[])(object)new Control[5]
			{
				poweredBy_0,
				(Control)button_0,
				(Control)button_1,
				headerControl_0,
				(Control)autoHeightLabel_0
			};
			controls.AddRange(array);
			num = 10;
			((Form)this).set_FormBorderStyle((FormBorderStyle)1);
			((Form)this).set_MaximizeBox(false);
			((Form)this).set_MinimizeBox(false);
			((Form)this).set_ShowInTaskbar(false);
			num = 7;
			((Form)this).set_StartPosition((FormStartPosition)1);
			((Control)this).ResumeLayout(false);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, array, num, this);
			throw;
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		try
		{
			securityExceptionEventArgs_0.TryToContinue = true;
			WaitSendingReportControl.smethod_5((Form)(object)this, 408, 429);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, this, sender, e);
			throw;
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		try
		{
			securityExceptionEventArgs_0.TryToContinue = false;
			WaitSendingReportControl.smethod_5((Form)(object)this, 670, 683);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, this, sender, e);
			throw;
		}
	}

	public Form1(SecurityExceptionEventArgs securityExceptionEventArgs_1)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		SecurityExceptionEventArgs securityExceptionEventArgs = (securityExceptionEventArgs_0 = null);
		PoweredBy poweredBy = (poweredBy_0 = new PoweredBy());
		Button val = (button_0 = new Button());
		Button val2 = (button_1 = new Button());
		HeaderControl headerControl = (headerControl_0 = new HeaderControl(SmartAssembly.SmartExceptionsCore.DoNotPruneAttribute.smethod_0("{0} attempted to perform an operation not allowed by the security policy.", "server1", 27, 73)));
		AutoHeightLabel autoHeightLabel = (autoHeightLabel_0 = new AutoHeightLabel());
		((Form)this)._002Ector();
		SecurityExceptionEventArgs securityExceptionEventArgs2 = default(SecurityExceptionEventArgs);
		StringBuilder stringBuilder = default(StringBuilder);
		int num = default(int);
		Size clientSize = default(Size);
		try
		{
			method_0();
			Class16.smethod_2((Form)(object)this, Win32.GetApplicationIcon(), 230, 166);
			SmartAssembly.License.License.smethod_4((Control)(object)this, "server1", 266, 349);
			if (AppPathFinder.smethod_1(Class35.smethod_2((Control)(object)this, 227, 252), 739, 724) == 0)
			{
				SmartAssembly.License.License.smethod_4((Control)(object)this, "Security error", 143, 216);
			}
			securityExceptionEventArgs2 = (securityExceptionEventArgs_0 = securityExceptionEventArgs_1);
			if (!securityExceptionEventArgs_1.CanContinue)
			{
				DoNotPruneTypeAttribute.smethod_5((Control)(object)button_0, bool_0: false, 816, 844);
			}
			if (AppPathFinder.smethod_1(securityExceptionEventArgs_1.SecurityMessage, 928, 919) > 0)
			{
				SmartAssembly.License.License.smethod_4((Control)(object)autoHeightLabel_0, securityExceptionEventArgs_1.SecurityMessage, 132, 211);
			}
			else
			{
				stringBuilder = new StringBuilder();
				Class21.smethod_4(stringBuilder, SmartAssembly.SmartExceptionsCore.DoNotPruneAttribute.smethod_0("{0} attempted to perform an operation not allowed by the security policy. To grant this application the required permission, contact your system administrator, or use the Microsoft .NET Framework Configuration tool.\n\n", "server1", 324, 278), 278, 325);
				if (securityExceptionEventArgs_1.CanContinue)
				{
					Class21.smethod_4(stringBuilder, "If you click Continue, the application will ignore this error and attempt to continue. If you click Quit, the application will close immediately.\n\n", 810, 889);
				}
				stringBuilder.Append(securityExceptionEventArgs_1.SecurityException.Message);
				((Control)autoHeightLabel_0).set_Text(stringBuilder.ToString());
			}
			num = ((Control)autoHeightLabel_0).get_Bottom() + 60;
			int num2 = num;
			clientSize = ((Form)this).get_ClientSize();
			if (num2 > clientSize.Height)
			{
				clientSize = ((Form)this).get_ClientSize();
				((Form)this).set_ClientSize(new Size(clientSize.Width, num));
			}
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[12]
			{
				stringBuilder, num, clientSize, securityExceptionEventArgs, poweredBy, val, val2, headerControl, autoHeightLabel, securityExceptionEventArgs2,
				this, securityExceptionEventArgs_1
			});
			throw;
		}
	}

	static Form1()
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

	internal static Type smethod_0(Assembly assembly_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 32:
					return assembly_0.GetType(string_0);
				}
				num = 6;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, assembly_0, string_0, int_0, int_1);
			throw;
		}
	}

	internal static object smethod_1(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 30:
					return methodBase_0.Invoke(object_0, object_1);
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num, methodBase_0, object_0, object_1, int_0, int_1);
			throw;
		}
	}

	internal static CultureInfo smethod_2(string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 8:
					return CultureInfo.GetCultureInfo(string_0);
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, string_0, int_0, int_1);
			throw;
		}
	}

	internal static Color smethod_3(int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 36:
					return SystemColors.Window;
				}
				num = 6;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, int_0, int_1);
			throw;
		}
	}
}
