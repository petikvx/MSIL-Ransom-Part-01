using System.IO;
using Ionic.Zip;

namespace Ionic;

internal class AttributesCriterion : SelectionCriterion
{
	private FileAttributes _Attributes;

	internal ComparisonOperator Operator;

	internal extern string AttributeString { get; set; }

	public override extern string ToString();

	private extern bool _EvaluateOne(FileAttributes fileAttrs, FileAttributes criterionAttrs);

	internal override extern bool Evaluate(string filename);

	private bool _Evaluate(FileAttributes fileAttrs)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
		{
		}
		_ = /*Error near IL_0006: Stack underflow*/% /*Error near IL_0006: Stack underflow*/;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	internal override extern bool Evaluate(ZipEntry entry);

	public extern AttributesCriterion();
}
