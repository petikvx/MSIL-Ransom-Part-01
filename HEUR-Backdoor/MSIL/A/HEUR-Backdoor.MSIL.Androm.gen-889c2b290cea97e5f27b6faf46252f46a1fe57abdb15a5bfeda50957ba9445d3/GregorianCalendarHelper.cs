using System;

internal class GregorianCalendarHelper : Attribute
{
	internal readonly int InitialValue_isInitialized;

	internal GregorianCalendarHelper(int int_0)
	{
		InitialValue_isInitialized = ~(-((~(-(-(Convert.ToInt32(-1431212930.0) + Convert.ToInt32(-1987842435.0)))) - int_0) * Convert.ToInt32(432250077.5 + Math.Abs(432250077.5))) ^ ~Convert.ToInt32(1672679951.0));
	}

	public override int Get_IsFlagsValid()
	{
		return InitialValue_isInitialized;
	}
}
