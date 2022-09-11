using System;
using ns8;

namespace ns5;

internal sealed class EventArgs4 : EventArgs
{
	private Enum3 enum3_0;

	private readonly bool bool_0;

	private readonly string string_0 = string.Empty;

	private readonly string string_1 = string.Empty;

	public Enum3 Step => enum3_0;

	public bool Failed => bool_0;

	public string ErrorMessage => string_0;

	public string ReportID => string_1;

	internal EventArgs4(Enum3 step)
		: this(step, string.Empty)
	{
	}

	internal EventArgs4(Enum3 step, string errorMessage)
		: this(step, errorMessage, string.Empty)
	{
	}

	internal EventArgs4(Enum3 step, string errorMessage, string reportId)
	{
		enum3_0 = step;
		bool_0 = errorMessage != null && errorMessage.Length > 0;
		string_0 = errorMessage;
		string_1 = reportId;
	}
}
