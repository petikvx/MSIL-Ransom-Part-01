namespace Gherkin;

public interface ITokenMatcher
{
	bool Match_EOF(Token token);

	bool Match_Empty(Token token);

	bool Match_Comment(Token token);

	bool Match_TagLine(Token token);

	bool Match_FeatureLine(Token token);

	bool Match_BackgroundLine(Token token);

	bool Match_ScenarioLine(Token token);

	bool Match_ScenarioOutlineLine(Token token);

	bool Match_ExamplesLine(Token token);

	bool Match_StepLine(Token token);

	bool Match_DocStringSeparator(Token token);

	bool Match_TableRow(Token token);

	bool Match_Language(Token token);

	bool Match_Other(Token token);

	void Reset();
}
