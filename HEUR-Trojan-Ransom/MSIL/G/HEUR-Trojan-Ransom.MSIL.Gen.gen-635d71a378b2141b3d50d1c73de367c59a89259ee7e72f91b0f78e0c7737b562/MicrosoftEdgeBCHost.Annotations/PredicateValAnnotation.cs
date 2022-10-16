using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PredicateValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralError()
	{
	}
}
