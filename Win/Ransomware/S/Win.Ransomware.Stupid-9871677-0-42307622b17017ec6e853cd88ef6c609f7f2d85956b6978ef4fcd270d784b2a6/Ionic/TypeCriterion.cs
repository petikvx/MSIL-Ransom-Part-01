using Ionic.Zip;

namespace Ionic;

internal class TypeCriterion : SelectionCriterion
{
	private char ObjectType;

	internal ComparisonOperator Operator;

	internal extern string AttributeString { get; set; }

	public override extern string ToString();

	internal override extern bool Evaluate(string filename);

	internal override extern bool Evaluate(ZipEntry entry);

	public extern TypeCriterion();
}
