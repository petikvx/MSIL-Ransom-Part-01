using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RulesRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ManageIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageIndexer()
	{
	}
}
