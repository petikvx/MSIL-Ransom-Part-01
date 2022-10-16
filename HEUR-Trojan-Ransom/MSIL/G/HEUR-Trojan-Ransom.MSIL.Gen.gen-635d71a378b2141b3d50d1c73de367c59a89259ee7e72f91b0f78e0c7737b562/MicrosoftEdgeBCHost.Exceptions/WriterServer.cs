using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class WriterServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterServer()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralRules()
	{
	}
}
