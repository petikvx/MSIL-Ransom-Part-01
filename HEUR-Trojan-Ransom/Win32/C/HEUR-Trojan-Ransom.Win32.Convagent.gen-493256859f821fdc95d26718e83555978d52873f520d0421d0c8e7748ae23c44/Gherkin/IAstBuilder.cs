namespace Gherkin;

public interface IAstBuilder<T>
{
	void Build(Token token);

	void StartRule(RuleType ruleType);

	void EndRule(RuleType ruleType);

	T GetResult();

	void Reset();
}
