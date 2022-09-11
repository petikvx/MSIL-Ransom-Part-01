using System;
using System.Xml.Linq;

namespace PicklesDoc.Pickles.TestFrameworks.NUnit;

internal static class NUnitXElementExtensions
{
	internal static bool IsAttributeSetToValue(this XElement element, string attributeName, string expectedValue)
	{
		if (element.Attribute(XName.op_Implicit(attributeName)) == null)
		{
			return false;
		}
		return string.Equals(element.Attribute(XName.op_Implicit(attributeName)).get_Value(), expectedValue, StringComparison.InvariantCultureIgnoreCase);
	}
}
