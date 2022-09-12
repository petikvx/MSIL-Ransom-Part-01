using System.Globalization;
using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class E48D53BC7 : ADB5C0658
{
	private int EEA618CC4;

	private long B92144AF2;

	public override string BB8314840 => base.FC3E9C6DA.DisplayType();

	public E48D53BC7(int index, long objectId, ADB5C0658 context)
		: base("[" + index + "]", string.Format(CultureInfo.CurrentCulture, "({0})[{1}]", new object[2] { context.E5CC7F130, index }), context)
	{
		EEA618CC4 = index;
		B92144AF2 = objectId;
	}

	public override void B705E8184(IJDbg F46484E9F)
	{
		IJdwpValue[] arrayValues = F46484E9F.GetArrayValues(B92144AF2, EEA618CC4, 1);
		if (arrayValues.Length != 0)
		{
			base.FC3E9C6DA = A002C58D2.A17FDB047(F46484E9F, arrayValues[0]);
		}
	}
}
