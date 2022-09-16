using System;

internal class LOCALE_SYEARMONTH : Attribute
{
	internal readonly int _isCompleted;

	internal LOCALE_SYEARMONTH(int int_0)
	{
		_isCompleted = Convert.ToInt32(1437618652.0 - Math.Floor(479206217.5)) * Convert.ToInt32(388267261.0 + Math.Truncate(388267261.0)) - (Convert.ToInt32(1999687736.0000677 + Math.Log10(999843872.5)) - (int_0 - (~(-Convert.ToInt32(-2065117267.0) + (Convert.ToInt32(-994315222.0) ^ Convert.ToInt32(1191689134.775133 - Math.Log10(595844563.0)))) - (-1245249625 ^ (Convert.ToInt32(2404699884.0 - Math.Ceiling(801566628.0)) + Convert.ToInt32(-718018368.0)) ^ Convert.ToInt32(-1388577822.0)))) * Convert.ToInt32(2145446275.0));
	}

	public override int HasLayoutInfo()
	{
		return _isCompleted;
	}
}
