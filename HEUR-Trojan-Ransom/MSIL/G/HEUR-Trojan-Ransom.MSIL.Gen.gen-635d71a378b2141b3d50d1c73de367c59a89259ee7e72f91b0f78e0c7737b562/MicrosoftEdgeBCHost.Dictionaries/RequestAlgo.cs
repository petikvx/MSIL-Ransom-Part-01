using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RequestAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralDefinition()
	{
	}
}
