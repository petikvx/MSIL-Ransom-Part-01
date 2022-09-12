namespace Microsoft.Kofe.Engine;

internal interface BinaryOperatorEvaluator
{
	DF0AD6554 Operator { get; }

	Value DoOp(Value l, Value r);
}
