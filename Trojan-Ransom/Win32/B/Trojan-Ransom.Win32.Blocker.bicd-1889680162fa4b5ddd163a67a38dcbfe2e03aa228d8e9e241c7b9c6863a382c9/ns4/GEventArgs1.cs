using System;
using System.IO;
using ns1;

namespace ns4;

public class GEventArgs1 : EventArgs
{
	internal Class18 class18_0;

	internal Exception exception_0;

	internal bool bool_0;

	internal bool bool_1 = true;

	internal bool bool_2 = true;

	internal bool bool_3;

	public Exception Exception => exception_0;

	public bool CanDebug => bool_0;

	public bool CanSendReport => bool_1;

	public bool ShowContinueCheckbox => bool_2;

	[Obsolete("Use ShowContinueCheckbox instead, as this is now also false when the builder has chosen not to show the checkbox.")]
	public bool CanContinue => bool_2;

	public bool TryToContinue
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool flag = (bool_3 = value);
		}
	}

	internal void method_0(bool bool_4)
	{
		bool flag = (bool_2 = bool_4);
	}

	internal void method_1()
	{
		bool_0 = true;
	}

	public void method_2()
	{
		if (bool_0)
		{
			class18_0.method_23();
		}
	}

	public bool method_3(string string_0)
	{
		if (File.Exists(string_0))
		{
			File.Delete(string_0);
		}
		return class18_0.method_24(string_0);
	}

	public byte[] method_4()
	{
		return class18_0.method_12();
	}

	public bool method_5()
	{
		if (!bool_1)
		{
			return false;
		}
		return class18_0.method_19();
	}

	public void method_6(string string_0, string string_1)
	{
		class18_0.method_17(string_0, string_1);
	}

	public void method_7(string string_0, string string_1)
	{
		class18_0.method_18(string_0, string_1);
	}

	internal GEventArgs1(Class18 class18_1, Exception exception_1)
	{
		Class18 @class = (class18_0 = class18_1);
		Exception ex = (exception_0 = exception_1);
	}

	static GEventArgs1()
	{
		GClass11.smethod_0();
	}
}
