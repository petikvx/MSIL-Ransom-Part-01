using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ItemValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ManageReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageReader()
	{
	}
}
