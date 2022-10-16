using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ServiceOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ViewLiteralParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewLiteralParser()
	{
	}
}
