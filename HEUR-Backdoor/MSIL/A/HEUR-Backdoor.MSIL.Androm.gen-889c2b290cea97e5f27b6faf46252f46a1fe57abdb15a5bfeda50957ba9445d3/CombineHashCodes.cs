using System;

internal class CombineHashCodes : Attribute
{
	internal readonly int S400_X00;

	internal CombineHashCodes(int int_0)
	{
		S400_X00 = (int_0 ^ (Convert.ToInt32(-1250566879.0) + ((690873892 + (Convert.ToInt32(-920853645.0) + Convert.ToInt32(1645340367.0))) ^ -(Convert.ToInt32(-1678239837.0) ^ Convert.ToInt32(-1310326078.0))))) * Convert.ToInt32(446725473.4250863 + Math.Sqrt(223370209.5));
	}

	public override int Semantics()
	{
		return S400_X00;
	}
}
