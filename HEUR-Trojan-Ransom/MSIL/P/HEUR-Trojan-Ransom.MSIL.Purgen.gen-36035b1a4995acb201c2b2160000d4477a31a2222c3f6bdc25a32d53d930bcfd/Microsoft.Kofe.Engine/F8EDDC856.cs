using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class F8EDDC856 : ADB5C0658
{
	private long C7A8A602D;

	[CompilerGenerated]
	private readonly IJdwpTypeField AA7150F22;

	private static Regex D8DCE8C99 = new Regex("^[a-zA-Z_\\$][a-zA-Z_\\$0-9]*(\\.[a-zA-Z_\\$][a-zA-Z_\\$0-9]*)*$");

	public override string FA8140115 => CCC12947E.get_DisplaySignature();

	public IJdwpTypeField CCC12947E
	{
		[CompilerGenerated]
		get
		{
			return AA7150F22;
		}
	}

	public F8EDDC856(IJdwpTypeField field, long objectId, ADB5C0658 context)
		: base(field.get_Name(), null, context)
	{
		AA7150F22 = field;
		C7A8A602D = objectId;
		if (((uint)CCC12947E.get_Modifiers() & 8u) != 0)
		{
			base.E5CC7F130 = context.F32AC590E + "." + field.get_Name();
		}
		else if (D8DCE8C99.IsMatch(context.E5CC7F130))
		{
			base.E5CC7F130 = context.E5CC7F130 + "." + field.get_Name();
		}
		else
		{
			base.E5CC7F130 = "(" + context.E5CC7F130 + ")." + field.get_Name();
		}
	}

	public override void EF9DA57B2(IJDbg BFCC20B28)
	{
		if (C7A8A602D != 0L)
		{
			IJdwpValue[] array = (((CCC12947E.get_Modifiers() & 8) == 0) ? BFCC20B28.GetInstanceValues(C7A8A602D, new long[1] { CCC12947E.get_ID() }) : BFCC20B28.GetReferenceType(C7A8A602D).GetValues((IJdwpTypeField[])(object)new IJdwpTypeField[1] { CCC12947E }));
			if (array.Length != 0)
			{
				base.FC3E9C6DA = A002C58D2.A17FDB047(BFCC20B28, array[0]);
			}
		}
	}
}
