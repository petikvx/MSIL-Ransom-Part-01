using System;

namespace ns11;

internal class EventArgs3 : EventArgs
{
	internal Enum4 enum4_0;

	internal readonly bool bool_0;

	internal readonly string string_0 = string.Empty;

	private readonly string string_1 = string.Empty;

	public Enum4 Step => enum4_0;

	public bool Failed => bool_0;

	public string ErrorMessage => string_0;

	public string ReportID => string_1;

	internal EventArgs3(Enum4 step)
		: this(step, string.Empty)
	{
	}

	internal EventArgs3(Enum4 step, string errorMessage)
		: this(step, errorMessage, string.Empty)
	{
	}

	internal EventArgs3(Enum4 step, string errorMessage, string reportId)
	{
		enum4_0 = step;
		bool_0 = errorMessage != null && errorMessage.Length > 0;
		string_0 = errorMessage;
		string_1 = reportId;
	}

	internal static bool x1qunJZz3tLLmjEQiIo()
	{
		return true;
	}

	internal static bool OaA2mrvKVmETRTyp565()
	{
		return false;
	}
}
