using Microsoft.Win32;

namespace ns1;

internal class Class1
{
	private int int_0 = 23;

	public bool method_0()
	{
		Class5 @class = new Class5();
		return @class.method_2();
	}

	public int method_1(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5)
	{
		try
		{
			if (int_0 > 1)
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(string_0 + string_1 + string_2);
				if (string_3 != GClass0.smethod_0("+"))
				{
					registryKey.SetValue(string_4, string_5);
				}
				registryKey.Close();
			}
			return 2;
		}
		catch
		{
			return 1;
		}
	}
}
