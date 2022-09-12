using System;
using System.IO;

namespace ns0;

internal class Class16
{
	private readonly Class15 class15_0;

	private string string_0;

	private readonly Class3 class3_0;

	public Class16()
	{
		class15_0 = new Class15();
		class3_0 = new Class3();
	}

	public void method_0(string string_1)
	{
		string_0 = string_1;
	}

	public void method_1()
	{
		try
		{
			Delegate48.smethod_0(string_0);
		}
		catch (Exception)
		{
		}
	}

	public void method_2()
	{
		try
		{
			Delegate130.smethod_0(Delegate209.smethod_0(string_0, Class15.string_2), string_0);
		}
		catch (Exception)
		{
		}
	}

	public void method_3()
	{
		class15_0.method_0();
		class15_0.method_5();
	}

	public void method_4()
	{
		try
		{
			class3_0.method_6(Class3.string_0, string_0);
		}
		catch (ArgumentException)
		{
		}
	}

	public bool method_5()
	{
		bool result = (byte)Class9.smethod_0(848) != 0;
		if (Delegate94.smethod_0(string_0) && !smethod_0(string_0) && Delegate156.smethod_0(class3_0.method_11(Class3.string_0, string_0), Class10.smethod_0(49)))
		{
			result = (byte)Class9.smethod_0(852) != 0;
			class15_0.method_4(string_0);
			class15_0.method_7();
			method_4();
		}
		return result;
	}

	public bool method_6()
	{
		bool result = (byte)Class9.smethod_0(856) != 0;
		string object_ = Delegate71.smethod_0(string_0);
		if (!smethod_0(string_0) && Delegate22.smethod_0(class3_0.method_11(Class3.string_0, string_0), Class10.smethod_0(49)) && Delegate155.smethod_0(Class15.list_0, Delegate26.smethod_0(object_)))
		{
			class15_0.method_4(string_0);
			class15_0.method_6();
			class3_0.method_5(Class3.string_0, string_0, (byte)Class9.smethod_0(860) != 0);
		}
		else
		{
			result = (byte)Class9.smethod_0(864) != 0;
		}
		return result;
	}

	public static bool smethod_0(string string_1)
	{
		FileStream fileStream = null;
		FileInfo object_ = Delegate226.smethod_0(string_1);
		try
		{
			fileStream = Delegate202.smethod_0(object_, (FileMode)Class9.smethod_0(868), (FileAccess)Class9.smethod_0(872), (FileShare)Class9.smethod_0(876));
		}
		catch (Exception)
		{
			return (byte)Class9.smethod_0(880) != 0;
		}
		finally
		{
			if (fileStream != null)
			{
				Delegate190.smethod_0(fileStream);
			}
		}
		return (byte)Class9.smethod_0(884) != 0;
	}
}
