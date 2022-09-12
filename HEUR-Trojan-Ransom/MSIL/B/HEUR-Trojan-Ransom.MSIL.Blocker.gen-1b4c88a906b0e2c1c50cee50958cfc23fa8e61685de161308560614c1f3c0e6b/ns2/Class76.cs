using System.Linq.Expressions;

namespace ns2;

internal class Class76 : ExpressionVisitor
{
	internal static readonly object object_0 = new object();

	Expression ExpressionVisitor.VisitConditional(ConditionalExpression node)
	{
		if (node.IfFalse.NodeType == ExpressionType.Throw)
		{
			return Expression.Condition(node.Test, node.IfTrue, Expression.Constant(object_0));
		}
		return base.VisitConditional(node);
	}
}
