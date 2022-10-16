using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CreatorAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectInterfaceWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectInterfaceWorker()
	{
	}
}
