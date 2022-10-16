using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProcessRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessRules()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeListener()
	{
	}
}
