using System;
using System.Collections.Generic;
using System.Linq;

namespace Gherkin;

public class GherkinLine : IGherkinLine
{
	private readonly string lineText;

	private readonly string trimmedLineText;

	public int LineNumber { get; private set; }

	public int Indent => lineText.Length - trimmedLineText.Length;

	public GherkinLine(string line, int lineNumber)
	{
		LineNumber = lineNumber;
		lineText = line;
		trimmedLineText = lineText.TrimStart(new char[0]);
	}

	public void Detach()
	{
	}

	public bool IsEmpty()
	{
		return trimmedLineText.Length == 0;
	}

	public bool StartsWith(string text)
	{
		return trimmedLineText.StartsWith(text);
	}

	public bool StartsWithTitleKeyword(string text)
	{
		return StringUtils.StartsWith(trimmedLineText, text) && StartsWithFrom(trimmedLineText, text.Length, ":");
	}

	private static bool StartsWithFrom(string text, int textIndex, string value)
	{
		return string.CompareOrdinal(text, textIndex, value, 0, value.Length) == 0;
	}

	public string GetLineText(int indentToRemove)
	{
		if (indentToRemove >= 0 && indentToRemove <= Indent)
		{
			return lineText.Substring(indentToRemove);
		}
		return trimmedLineText;
	}

	public string GetRestTrimmed(int length)
	{
		return trimmedLineText.Substring(length).Trim();
	}

	public IEnumerable<GherkinLineSpan> GetTags()
	{
		int position = Indent;
		string[] array = trimmedLineText.Split();
		foreach (string item in array)
		{
			if (item.Length > 0)
			{
				yield return new GherkinLineSpan(position + 1, item);
				position += item.Length;
			}
			position++;
		}
	}

	public IEnumerable<GherkinLineSpan> GetTableCells()
	{
		List<Tuple<string, int>> items = SplitCells(trimmedLineText).ToList();
		bool isBeforeFirst = true;
		IEnumerator<Tuple<string, int>> enumerator = items.Take(items.Count - 1).GetEnumerator();
		/*Error near IL_0071: Could not find block for branch target IL_00a5*/;
		yield break;
	}

	private IEnumerable<Tuple<string, int>> SplitCells(string row)
	{
		CharEnumerator rowEnum = row.GetEnumerator();
		string cell = string.Empty;
		int pos = 0;
		int startPos = 0;
		while (rowEnum.MoveNext())
		{
			pos++;
			char c2 = rowEnum.Current;
			if (!(c2.ToString() == "|"))
			{
				if (c2 == '\\')
				{
					rowEnum.MoveNext();
					pos++;
					c2 = rowEnum.Current;
					if (c2 == 'n')
					{
						cell += "\n";
						continue;
					}
					if (c2.ToString() != "|" && c2 != '\\')
					{
						cell += '\\';
					}
					cell += c2;
				}
				else
				{
					cell += c2;
				}
			}
			else
			{
				yield return Tuple.Create(cell, startPos);
				cell = string.Empty;
				startPos = pos;
			}
		}
		yield return Tuple.Create(cell, startPos);
	}

	private string Trim(string s, out int trimmedStart)
	{
		trimmedStart = 0;
		while (trimmedStart < s.Length && char.IsWhiteSpace(s[trimmedStart]))
		{
			trimmedStart++;
		}
		return s.Trim();
	}
}
