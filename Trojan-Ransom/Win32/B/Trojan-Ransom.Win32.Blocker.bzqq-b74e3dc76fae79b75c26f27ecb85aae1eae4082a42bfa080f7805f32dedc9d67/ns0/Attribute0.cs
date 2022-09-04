using System;
using System.Windows.Forms;
using System.Xml;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;

namespace ns0;

[AttributeUsage(AttributeTargets.Parameter)]
internal sealed class Attribute0 : Attribute
{
	public Attribute0()
	{
		try
		{
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	static Attribute0()
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

	internal static void smethod_0(XmlWriter xmlWriter_0, string string_0, string string_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 2;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 48:
					xmlWriter_0.WriteAttributeString(string_0, string_1);
					return;
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException7(exception, num, num2, xmlWriter_0, string_0, string_1, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_1(FileDialog fileDialog_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 5;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 53:
					fileDialog_0.set_DefaultExt(string_0);
					return;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, fileDialog_0, string_0, int_0, int_1);
			throw;
		}
	}

	internal static DialogResult smethod_2(CommonDialog commonDialog_0, int int_0, int int_1)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 37:
					return commonDialog_0.ShowDialog();
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, commonDialog_0, int_0, int_1);
			throw;
		}
	}
}
