using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ObserverVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverVal()
	{
		WriterPropertyProducer.ResolveStub();
		FillRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillRequest()
	{
	}
}
