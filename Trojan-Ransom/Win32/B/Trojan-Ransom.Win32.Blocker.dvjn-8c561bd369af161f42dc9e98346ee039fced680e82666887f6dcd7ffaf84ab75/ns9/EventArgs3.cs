using System;

namespace ns9;

internal class EventArgs3 : EventArgs
{
	internal Enum1 enum1_0;

	internal readonly bool bool_0;

	internal readonly string string_0 = string.Empty;

	private readonly string string_1 = string.Empty;

	public Enum1 Step => enum1_0;

	public bool Failed => bool_0;

	public string ErrorMessage => string_0;

	public string ReportID => string_1;

	internal EventArgs3(Enum1 step)
		: this(step, string.Empty)
	{
	}

	internal EventArgs3(Enum1 step, string errorMessage)
		: this(step, errorMessage, string.Empty)
	{
	}

	internal EventArgs3(Enum1 step, string errorMessage, string reportId)
	{
		enum1_0 = step;
		bool_0 = errorMessage != null && errorMessage.Length > 0;
		string_0 = errorMessage;
		string_1 = reportId;
	}

	internal static bool o86gyBr2olRGZf7YSvS()
	{
		return true;
	}

	internal static bool kJJIXQrmVLN7djkO5MJ()
	{
		return false;
	}
}
