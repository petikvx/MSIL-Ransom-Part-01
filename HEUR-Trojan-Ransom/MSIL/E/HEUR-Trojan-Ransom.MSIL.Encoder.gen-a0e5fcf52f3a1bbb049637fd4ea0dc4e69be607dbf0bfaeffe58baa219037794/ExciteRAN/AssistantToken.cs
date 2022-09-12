using System.Reflection;

namespace ExciteRAN;

internal sealed class AssistantToken
{
	internal static ConstructorInfo CleanAssistant(object windowPosition)
	{
		return windowPosition as ConstructorInfo;
	}
}
