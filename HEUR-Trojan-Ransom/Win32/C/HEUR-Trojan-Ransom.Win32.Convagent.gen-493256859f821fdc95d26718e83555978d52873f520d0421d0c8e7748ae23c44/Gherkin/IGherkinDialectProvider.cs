using Gherkin.Ast;

namespace Gherkin;

public interface IGherkinDialectProvider
{
	GherkinDialect DefaultDialect { get; }

	GherkinDialect GetDialect(string language, Location location);
}
