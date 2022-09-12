using System.IO;

namespace ExciteRAN;

internal sealed class SolutionResolver
{
	internal static Stream CleanAssistant(object windowPosition)
	{
		return windowPosition as Stream;
	}
}
