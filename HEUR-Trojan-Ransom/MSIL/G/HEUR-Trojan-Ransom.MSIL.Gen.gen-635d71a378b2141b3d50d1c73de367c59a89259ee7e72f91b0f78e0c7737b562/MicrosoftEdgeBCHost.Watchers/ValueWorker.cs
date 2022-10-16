using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ValueWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueWorker()
	{
		WriterPropertyProducer.ResolveStub();
		EnableField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableField()
	{
	}
}
