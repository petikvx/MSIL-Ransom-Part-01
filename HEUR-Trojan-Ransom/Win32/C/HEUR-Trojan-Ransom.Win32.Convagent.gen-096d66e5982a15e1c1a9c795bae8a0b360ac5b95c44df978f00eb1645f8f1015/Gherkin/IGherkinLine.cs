using System.Collections.Generic;

namespace Gherkin;

public interface IGherkinLine
{
	int LineNumber { get; }

	int Indent { get; }

	void Detach();

	bool IsEmpty();

	bool StartsWith(string text);

	bool StartsWithTitleKeyword(string keyword);

	string GetLineText(int indentToRemove = 0);

	string GetRestTrimmed(int length);

	IEnumerable<GherkinLineSpan> GetTags();

	IEnumerable<GherkinLineSpan> GetTableCells();
}
