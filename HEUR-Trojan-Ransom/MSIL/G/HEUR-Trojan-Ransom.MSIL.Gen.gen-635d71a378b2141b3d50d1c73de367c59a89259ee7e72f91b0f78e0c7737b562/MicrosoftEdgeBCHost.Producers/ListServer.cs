using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ListServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListServer()
	{
		WriterPropertyProducer.ResolveStub();
		RevertLiteralPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertLiteralPredicate()
	{
	}
}
