using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class FilterValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		LoginBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginBroadcaster()
	{
	}
}
