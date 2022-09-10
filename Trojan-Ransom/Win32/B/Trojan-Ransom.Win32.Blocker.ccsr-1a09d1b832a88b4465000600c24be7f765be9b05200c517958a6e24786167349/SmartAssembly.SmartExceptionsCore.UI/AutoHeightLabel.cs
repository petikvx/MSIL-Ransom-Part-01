using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Security.Policy;
using System.Windows.Forms;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsCore.UI;

[DesignerCategory("Code")]
public class AutoHeightLabel : Label
{
	private void method_0()
	{
		try
		{
			Graphics val = Class32.smethod_0((Control)(object)this, 643, 675);
			try
			{
				int num = Win32.smethod_6(val, SendingReportFeedbackEventArgs1.smethod_0((Control)(object)this, 795, 772), Class25.smethod_1((Control)(object)this, 96, 35), ((Control)this).get_Width());
				if (num > 0)
				{
					((Control)this).set_Height(num);
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
		}
	}

	protected override void OnFontChanged(EventArgs e)
	{
		((Label)this).OnFontChanged(e);
		method_0();
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		method_0();
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Label)this).OnTextChanged(e);
		method_0();
	}

	public AutoHeightLabel()
	{
		Class30.smethod_1((Label)(object)this, (FlatStyle)3, 54, 22);
		((Label)this).set_UseMnemonic(false);
	}

	static AutoHeightLabel()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static string smethod_0(object object_0, object object_1, object object_2, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 75:
				return string.Concat(object_0, object_1, object_2);
			}
		}
	}

	internal static string smethod_1(Exception exception_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 121:
				return exception_0.Message;
			}
		}
	}

	internal static OperatingSystem smethod_2(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 111:
				return Environment.OSVersion;
			}
		}
	}

	internal static void smethod_3(Process process_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 83:
				process_0.Kill();
				return;
			}
		}
	}

	internal static object smethod_4(AppDomain appDomain_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 69:
				return appDomain_0.GetData(string_0);
			}
		}
	}

	internal static Assembly smethod_5(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 35:
				return Assembly.Load(byte_0, byte_1, evidence_0);
			}
		}
	}
}
