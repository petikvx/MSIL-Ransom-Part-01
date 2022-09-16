using System;

internal class M_padding : Attribute
{
	internal readonly int ISCIIMalayalam;

	internal M_padding(int int_0)
	{
		ISCIIMalayalam = ~(int_0 * Convert.ToInt32(-307630863.0) - Convert.ToInt32(1638588439.0)) + -Convert.ToInt32(440068203.0 + Math.Round(440068203.0)) + -1025150711;
	}

	public override int M_GSCookie()
	{
		return ISCIIMalayalam;
	}
}
