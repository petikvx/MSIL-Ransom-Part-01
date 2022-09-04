using System;

namespace ns0;

internal sealed class EventArgs0 : EventArgs
{
	internal bool bool_0;

	internal bool bool_1;

	internal bool bool_2;

	internal Exception exception_0;

	internal static bool bool_3 = true;

	internal static bool bool_4 = true;

	public string string_0;

	public string string_1;

	public string string_2;

	public bool Boolean_0 => bool_0;

	public bool Boolean_1
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
		}
	}

	public bool Boolean_2
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
		}
	}

	public Exception Exception_0 => exception_0;

	public bool Boolean_3
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

	public bool Boolean_4
	{
		get
		{
			return bool_4;
		}
		set
		{
			bool_4 = value;
		}
	}
}
