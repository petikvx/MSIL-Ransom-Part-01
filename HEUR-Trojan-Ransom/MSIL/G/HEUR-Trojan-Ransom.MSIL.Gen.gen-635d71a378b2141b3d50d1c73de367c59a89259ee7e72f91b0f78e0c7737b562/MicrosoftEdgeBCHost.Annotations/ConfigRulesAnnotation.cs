using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ConfigRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CompareUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareUtils()
	{
	}
}
