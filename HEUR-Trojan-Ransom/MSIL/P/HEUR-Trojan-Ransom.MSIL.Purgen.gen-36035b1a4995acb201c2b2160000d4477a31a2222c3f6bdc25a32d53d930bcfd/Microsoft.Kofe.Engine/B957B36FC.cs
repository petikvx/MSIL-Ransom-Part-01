namespace Microsoft.Kofe.Engine;

internal class B957B36FC : BinaryOperatorEvaluator
{
	public DF0AD6554 CC532C6B0 => DF0AD6554.Plus;

	private static string A8F90FA59(Value F0BB45653)
	{
		if (F0BB45653.Kind == F18024EA9.String)
		{
			return ((F34C80160)F0BB45653).F3B7EC00B;
		}
		if (F0BB45653.Kind == F18024EA9.Simple)
		{
			return F0BB45653.DisplayValue;
		}
		if (F0BB45653 is CC18CEB1F)
		{
			return string.Empty;
		}
		throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
	}

	public Value D56895C59(Value F7215B617, Value F9C05409F)
	{
		if (F7215B617.Kind == F18024EA9.Simple && F9C05409F.Kind == F18024EA9.Simple)
		{
			return new F4D892E07().DA91744BD(F7215B617, F9C05409F);
		}
		if (F7215B617.Kind == F18024EA9.String || F9C05409F.Kind == F18024EA9.String)
		{
			string text = A8F90FA59(F7215B617);
			string text2 = A8F90FA59(F9C05409F);
			return new F34C80160(text + text2);
		}
		throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
	}
}
