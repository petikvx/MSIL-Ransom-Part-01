using System.Collections.Generic;
using System.Text;

namespace Ubiety.Dns.Core.Records;

public class RecordTxt : Record
{
	public List<string> Text { get; }

	public RecordTxt(RecordReader rr, int length)
	{
		int position = rr.Position;
		Text = new List<string>();
		while (rr.Position - position < length)
		{
			Text.Add(rr.ReadString());
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (string item in Text)
		{
			stringBuilder.Append(item);
		}
		return stringBuilder.ToString().TrimEnd(new char[0]);
	}
}
