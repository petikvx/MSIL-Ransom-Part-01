using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Security.Cryptography;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsWithUI;
using SmartAssembly.SmartUsageCore;
using ns0;

namespace SmartAssembly.SmartExceptionsCore.UI;

[DesignerCategory("Code")]
public class AutoHeightLabel : Label
{
	private void method_0()
	{
		int num = default(int);
		Graphics val = default(Graphics);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		try
		{
			try
			{
				num = 1;
				val = UsageCounts.smethod_3((Control)(object)this, 869, 787);
				try
				{
					num2 = 4;
					num3 = Win32.smethod_6(val, Class35.smethod_2((Control)(object)this, 719, 720), UnhandledExceptionHandlerWithUI.smethod_5((Control)(object)this, 737, 655), Class33.smethod_3((Control)(object)this, 58, 96));
					num2 = 0;
					if (num3 > 0)
					{
						((Control)this).set_Height(num3);
					}
				}
				finally
				{
					num4 = 2;
					((IDisposable)val)?.Dispose();
				}
				num5 = 4;
			}
			catch
			{
			}
			num6 = 1;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException8(exception, val, num3, num, num2, num4, num5, num6, this);
			throw;
		}
	}

	protected override void OnFontChanged(EventArgs e)
	{
		try
		{
			((Label)this).OnFontChanged(e);
			method_0();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, e);
			throw;
		}
	}

	protected override void OnResize(EventArgs e)
	{
		try
		{
			((Control)this).OnResize(e);
			method_0();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, e);
			throw;
		}
	}

	protected override void OnTextChanged(EventArgs e)
	{
		try
		{
			((Label)this).OnTextChanged(e);
			method_0();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, e);
			throw;
		}
	}

	public AutoHeightLabel()
	{
		try
		{
			SendingReportFeedbackEventArgs1.smethod_4((Label)(object)this, (FlatStyle)3, 25, 8);
			((Label)this).set_UseMnemonic(false);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	static AutoHeightLabel()
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

	internal static Process[] smethod_0(string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 3:
					return Process.GetProcessesByName(string_0);
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, string_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_1(SymmetricAlgorithm symmetricAlgorithm_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 5;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 126:
					symmetricAlgorithm_0.GenerateIV();
					return;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException5(exception, num, num2, symmetricAlgorithm_0, int_0, int_1);
			throw;
		}
	}

	internal static Delegate smethod_2(Delegate delegate_0, Delegate delegate_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 82:
					return Delegate.Remove(delegate_0, delegate_1);
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, delegate_0, delegate_1, int_0, int_1);
			throw;
		}
	}

	internal static int smethod_3(double double_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 66:
					return Convert.ToInt32(double_0);
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, double_0, int_0, int_1);
			throw;
		}
	}

	internal static object[] smethod_4(MemberInfo memberInfo_0, bool bool_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 62:
					return memberInfo_0.GetCustomAttributes(bool_0);
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, memberInfo_0, bool_0, int_0, int_1);
			throw;
		}
	}
}
