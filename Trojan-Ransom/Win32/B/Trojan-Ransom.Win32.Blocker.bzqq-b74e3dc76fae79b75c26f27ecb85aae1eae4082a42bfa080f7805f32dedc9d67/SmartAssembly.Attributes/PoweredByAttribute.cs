using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;

namespace SmartAssembly.Attributes;

public sealed class PoweredByAttribute : Attribute
{
	public PoweredByAttribute(string s)
	{
		try
		{
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, s);
			throw;
		}
	}

	static PoweredByAttribute()
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

	internal static void smethod_0(RegistryKey registryKey_0, string string_0, object object_0, RegistryValueKind registryValueKind_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 4;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 78:
					registryKey_0.SetValue(string_0, object_0, registryValueKind_0);
					return;
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException8(exception, num, num2, registryKey_0, string_0, object_0, registryValueKind_0, int_0, int_1);
			throw;
		}
	}

	internal static Color smethod_1(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_5 ^ int_4)
				{
				case 36:
					return Color.FromArgb(int_0, int_1, int_2, int_3);
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException7(exception, num, int_0, int_1, int_2, int_3, int_4, int_5);
			throw;
		}
	}

	internal static void smethod_2(PictureBox pictureBox_0, Image image_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 4;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 102:
					pictureBox_0.set_Image(image_0);
					return;
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, pictureBox_0, image_0, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_3(string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 109:
					return string_0.Trim();
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, string_0, int_0, int_1);
			throw;
		}
	}
}
