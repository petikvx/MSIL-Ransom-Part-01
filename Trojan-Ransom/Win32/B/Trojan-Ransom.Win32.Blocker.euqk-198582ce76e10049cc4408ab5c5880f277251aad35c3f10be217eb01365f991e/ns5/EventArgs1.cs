using System;
using System.IO;
using ns6;

namespace ns5;

internal class EventArgs1 : EventArgs
{
	private Class26 class26_0;

	private Exception exception_0;

	private bool bool_0;

	private bool bool_1 = true;

	private bool bool_2 = true;

	private bool bool_3;

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
			bool_3 = value;
		}
	}

	internal void method_0(bool bool_4)
	{
		bool_2 = bool_4;
	}

	internal void method_1()
	{
		bool_0 = true;
	}

	internal void method_2()
	{
		bool_1 = false;
	}

	public void method_3()
	{
		if (bool_0)
		{
			class26_0.method_22();
		}
	}

	public bool method_4(string string_0)
	{
		if (File.Exists(string_0))
		{
			File.Delete(string_0);
		}
		return class26_0.method_23(string_0);
	}

	public byte[] method_5()
	{
		return class26_0.method_12();
	}

	public bool method_6()
	{
		if (!bool_1)
		{
			return false;
		}
		return class26_0.method_19();
	}

	public void method_7(string string_0, string string_1)
	{
		class26_0.method_17(string_0, string_1);
	}

	public void method_8(string string_0, string string_1)
	{
		class26_0.method_18(string_0, string_1);
	}

	internal EventArgs1(Class26 reportSender, Exception exception)
	{
		class26_0 = reportSender;
		exception_0 = exception;
	}
}
