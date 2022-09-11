using System.IO;
using Gherkin.Ast;

namespace Gherkin;

public class TokenScanner : ITokenScanner
{
	protected int lineNumber;

	protected readonly TextReader reader;

	public TokenScanner(TextReader reader)
	{
		this.reader = reader;
	}

	public virtual Token Read()
	{
		string text = reader.ReadLine();
		Location location = new Location(++lineNumber);
		return (text != null) ? new Token(new GherkinLine(text, lineNumber), location) : new Token(null, location);
	}
}
