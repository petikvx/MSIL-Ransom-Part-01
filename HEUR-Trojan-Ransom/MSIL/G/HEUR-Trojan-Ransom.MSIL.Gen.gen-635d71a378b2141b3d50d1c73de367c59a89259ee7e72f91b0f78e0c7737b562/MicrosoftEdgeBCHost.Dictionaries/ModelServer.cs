using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ModelServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelServer()
	{
		WriterPropertyProducer.ResolveStub();
		ViewLiteralPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewLiteralPredicate()
	{
	}
}
