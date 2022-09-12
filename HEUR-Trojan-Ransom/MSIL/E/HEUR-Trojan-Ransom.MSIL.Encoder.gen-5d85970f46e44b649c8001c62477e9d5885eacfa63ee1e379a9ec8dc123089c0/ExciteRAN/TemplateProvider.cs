using System.Reflection;

namespace ExciteRAN;

internal sealed class TemplateProvider
{
	internal static FieldInfo ResolveFile(object P_0)
	{
		return P_0 as FieldInfo;
	}
}
