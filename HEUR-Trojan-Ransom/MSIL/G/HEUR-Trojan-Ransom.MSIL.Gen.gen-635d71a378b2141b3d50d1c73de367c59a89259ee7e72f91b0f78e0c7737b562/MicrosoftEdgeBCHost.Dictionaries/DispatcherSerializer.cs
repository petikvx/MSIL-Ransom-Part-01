using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DispatcherSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		ListLiteralAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListLiteralAlgo()
	{
	}
}
