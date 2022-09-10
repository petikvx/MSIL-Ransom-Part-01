using System;

namespace ns5;

internal sealed class EventArgs3 : EventArgs
{
	private Enum2 enum2_0;

	private readonly bool bool_0;

	private readonly string string_0 = string.Empty;

	private readonly string string_1 = string.Empty;

	public Enum2 Step => enum2_0;

	public bool Failed => bool_0;

	public string ErrorMessage => string_0;

	public string ReportID => string_1;

	internal EventArgs3(Enum2 step)
		: this(step, string.Empty)
	{
	}

	internal EventArgs3(Enum2 step, string errorMessage)
		: this(step, errorMessage, string.Empty)
	{
	}

	internal EventArgs3(Enum2 step, string errorMessage, string reportId)
	{
		enum2_0 = step;
		bool_0 = errorMessage != null && errorMessage.Length > 0;
		string_0 = errorMessage;
		string_1 = reportId;
	}
}
