using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RulesWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralCode()
	{
	}
}
