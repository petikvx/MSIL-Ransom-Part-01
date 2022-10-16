using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MapRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeClient()
	{
	}
}
