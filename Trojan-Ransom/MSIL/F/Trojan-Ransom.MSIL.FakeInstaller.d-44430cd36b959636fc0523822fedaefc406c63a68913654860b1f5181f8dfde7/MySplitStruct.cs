using Microsoft.VisualBasic.CompilerServices;

public struct MySplitStruct
{
	public string[] splity;

	public string[] texty;

	public int[] indexy;

	public MySplitStruct(string[] splits, string[] texts)
	{
		this = default(MySplitStruct);
		splity = splits;
		texty = texts;
	}

	public MySplitStruct(bool nennuzhnaya_peremennaya, params string[] texts)
	{
		this = default(MySplitStruct);
		texty = texts;
		indexy = new int[1];
		indexy[0] = 0;
	}

	public MySplitStruct(string[] splits, string[] texts, int[] indexs)
	{
		this = default(MySplitStruct);
		splity = splits;
		texty = texts;
		indexy = indexs;
	}

	public MySplitStruct(string texts)
	{
		this = default(MySplitStruct);
		splity = new string[1];
		splity[0] = Conversions.ToString(0);
		texty = new string[1];
		texty[0] = texts;
		indexy = new int[1];
		indexy[0] = 0;
	}
}
