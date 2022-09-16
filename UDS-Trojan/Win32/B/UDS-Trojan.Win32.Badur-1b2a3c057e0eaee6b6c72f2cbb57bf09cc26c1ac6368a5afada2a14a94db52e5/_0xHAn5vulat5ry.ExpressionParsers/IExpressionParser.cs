using System.Collections.Generic;
using DynamicExpresso;

namespace _0xHAn5vulat5ry.ExpressionParsers;

public interface IExpressionParser
{
	Lambda Parse(string expressionText, params Parameter[] parameters);

	void SetReference(IEnumerable<ReferenceType> referencedTypes);
}
