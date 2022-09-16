using System.Collections.Generic;
using DynamicExpresso;

namespace _0xHConjug8tion8l.ExpressionParsers;

public interface IExpressionParser
{
	Lambda Parse(string expressionText, params Parameter[] parameters);

	void SetReference(IEnumerable<ReferenceType> referencedTypes);
}
