using System;
using System.Windows.Forms;
using Microsoft.Win32;
using ns10;
using ns3;
using ns7;

namespace ns9;

internal sealed class Class59 : Class58
{
	internal static readonly string string_0;

	internal static readonly string string_1;

	private static bool? nullable_0;

	public static void smethod_0(uint uint_0)
	{
		Class59 @class = default(Class59);
		try
		{
			@class = new Class59();
			@class.method_0(uint_0);
		}
		catch (Exception exception_)
		{
			Class38.smethod_2(exception_, @class, uint_0);
			throw;
		}
	}

	public static void smethod_1(string string_2)
	{
		Class59 @class = default(Class59);
		try
		{
			@class = new Class59();
			@class.method_1(string_2);
		}
		catch (Exception exception_)
		{
			Class38.smethod_2(exception_, @class, string_2);
			throw;
		}
	}

	protected override void vmethod_0(Class48 class48_0)
	{
		try
		{
			class48_0.method_6();
		}
		catch (Exception exception_)
		{
			Class38.smethod_2(exception_, this, class48_0);
			throw;
		}
	}

	protected override bool vmethod_1()
	{
		try
		{
			return smethod_2();
		}
		catch (Exception exception_)
		{
			Class38.smethod_1(exception_, this);
			throw;
		}
	}

	private static bool smethod_2()
	{
		try
		{
			if (!nullable_0.HasValue)
			{
				smethod_3();
			}
			return nullable_0.Value;
		}
		catch (Exception exception_)
		{
			Class38.smethod_0(exception_);
			throw;
		}
	}

	private static void smethod_3()
	{
		RegistryKey registryKey = default(RegistryKey);
		string text = default(string);
		object value = default(object);
		bool flag = default(bool);
		try
		{
			registryKey = null;
			try
			{
				text = Class15.smethod_0(956014) + string_1 + Class15.smethod_0(72) + string_0;
				registryKey = Registry.CurrentUser.CreateSubKey(text);
				value = registryKey.GetValue(Class15.smethod_0(956027));
				if (value == null)
				{
					registryKey.SetValue(Class15.smethod_0(956027), bool.FalseString);
					flag = smethod_4();
					registryKey.SetValue(Class15.smethod_0(956027), flag.ToString(), RegistryValueKind.String);
					nullable_0 = flag;
				}
				else
				{
					nullable_0 = Convert.ToBoolean(value);
				}
			}
			catch
			{
				nullable_0 = false;
			}
			finally
			{
				registryKey?.Close();
			}
		}
		catch (Exception exception_)
		{
			Class38.smethod_4(exception_, registryKey, text, value, flag);
			throw;
		}
	}

	private static bool smethod_4()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		Form2 form = default(Form2);
		bool flag = default(bool);
		try
		{
			form = new Form2();
			try
			{
				((Form)form).ShowDialog();
				flag = (int)((Form)form).get_DialogResult() == 6;
				return flag;
			}
			finally
			{
				((IDisposable)(object)form)?.Dispose();
			}
		}
		catch (Exception exception_)
		{
			Class38.smethod_2(exception_, form, flag);
			throw;
		}
	}

	static Class59()
	{
		try
		{
			string_0 = Class15.smethod_0(953027);
			string_1 = Class15.smethod_0(952713);
		}
		catch (Exception exception_)
		{
			Class38.smethod_0(exception_);
			throw;
		}
	}
}
