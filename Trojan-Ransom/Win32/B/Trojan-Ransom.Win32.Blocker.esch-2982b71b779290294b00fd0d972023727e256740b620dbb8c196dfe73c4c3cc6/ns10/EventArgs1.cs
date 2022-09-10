using System;
using System.IO;
using ns1;

namespace ns10;

internal sealed class EventArgs1 : EventArgs
{
	private Class23 class23_0;

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

	internal void method_0(bool value)
	{
		bool_2 = value;
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
			class23_0.method_22();
		}
	}

	public bool method_4(string fileName)
	{
		if (File.Exists(fileName))
		{
			File.Delete(fileName);
		}
		return class23_0.method_23(fileName);
	}

	public byte[] method_5()
	{
		return class23_0.method_12();
	}

	public bool method_6()
	{
		if (!bool_1)
		{
			return false;
		}
		return class23_0.method_19();
	}

	public void method_7(string name, string value)
	{
		class23_0.method_17(name, value);
	}

	public void method_8(string name, string fileName)
	{
		class23_0.method_18(name, fileName);
	}

	internal EventArgs1(Class23 reportSender, Exception exception)
	{
		class23_0 = reportSender;
		exception_0 = exception;
	}
}
