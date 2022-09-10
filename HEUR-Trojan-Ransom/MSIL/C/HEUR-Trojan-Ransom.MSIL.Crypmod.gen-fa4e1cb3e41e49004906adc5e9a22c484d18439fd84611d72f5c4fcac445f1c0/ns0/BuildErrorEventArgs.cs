using System;

namespace ns0;

[Serializable]
public class BuildErrorEventArgs
{
	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	public string Subcategory => string_0;

	public string Code => string_1;

	public string File => string_2;

	public int LineNumber => int_0;

	public int ColumnNumber => int_1;

	public int EndLineNumber => int_2;

	public int EndColumnNumber => int_3;

	protected BuildErrorEventArgs(string string_3, string string_4, string string_5)
	{
	}

	public BuildErrorEventArgs(string string_3, string string_4, string string_5, int int_4, int int_5, int int_6, int int_7, string string_6, string string_7, string string_8)
	{
		string_0 = string_3;
		string_1 = string_4;
		string_2 = string_5;
		int_0 = int_4;
		int_1 = int_5;
		int_2 = int_6;
		int_3 = int_7;
	}
}
