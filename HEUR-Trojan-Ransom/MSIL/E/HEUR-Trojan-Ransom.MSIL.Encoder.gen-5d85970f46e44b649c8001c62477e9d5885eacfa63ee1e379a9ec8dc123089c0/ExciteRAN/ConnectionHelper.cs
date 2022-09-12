using System.Reflection;

namespace ExciteRAN;

internal sealed class ConnectionHelper
{
	internal static ConstructorInfo ResolveFile(object P_0)
	{
		return P_0 as ConstructorInfo;
	}
}
