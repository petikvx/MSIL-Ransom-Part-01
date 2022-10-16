using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AttrWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrWorker()
	{
		WriterPropertyProducer.ResolveStub();
		ListCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListCallback()
	{
	}
}
