using System;
using ns2;

namespace ns8;

internal class EventArgs3 : EventArgs
{
	private Enum1 enum1_0;

	private readonly bool bool_0;

	private readonly string string_0 = string.Empty;

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
}
