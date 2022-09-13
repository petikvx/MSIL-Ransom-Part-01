using System;

namespace Ionic;

internal sealed class EnumUtil
{
	private extern EnumUtil();

	internal static extern string GetDescription(Enum value);

	internal static extern object Parse(Type enumType, string stringRepresentation);

	internal static extern object Parse(Type enumType, string stringRepresentation, bool ignoreCase);
}
