using Gherkin.Ast;

namespace Gherkin;

public class Token
{
	public bool IsEOF => Line == null;

	public IGherkinLine Line { get; set; }

	public TokenType MatchedType { get; set; }

	public string MatchedKeyword { get; set; }

	public string MatchedText { get; set; }

	public GherkinLineSpan[] MatchedItems { get; set; }

	public int MatchedIndent { get; set; }

	public GherkinDialect MatchedGherkinDialect { get; set; }

	public Location Location { get; set; }

	public Token(IGherkinLine line, Location location)
	{
		Line = line;
		Location = location;
	}

	public void Detach()
	{
		if (Line != null)
		{
			Line.Detach();
		}
	}

	public string GetTokenValue()
	{
		return (!IsEOF) ? Line.GetLineText(-1) : "EOF";
	}

	public override string ToString()
	{
		return $"{MatchedType}: {MatchedKeyword}/{MatchedText}";
	}
}
