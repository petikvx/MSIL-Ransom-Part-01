using System;

public class GEventArgs0 : EventArgs
{
	private GEnum1 genum1_0;

	private readonly bool bool_0;

	private readonly string string_0 = string.Empty;

	private readonly string string_1 = string.Empty;

	public GEnum1 Step => genum1_0;

	public bool Failed => bool_0;

	public string ErrorMessage => string_0;

	public string ReportID => string_1;

	internal GEventArgs0(GEnum1 genum1_1, string string_2)
		: this(genum1_1, string_2, string.Empty)
	{
	}

	internal GEventArgs0(GEnum1 genum1_1, string string_2, string string_3)
	{
		genum1_0 = genum1_1;
		bool_0 = string_2 != null && string_2.Length > 0;
		string_0 = string_2;
		string_1 = string_3;
	}
}
