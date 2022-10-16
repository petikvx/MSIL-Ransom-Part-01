using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class EventOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventOrder()
	{
		WriterPropertyProducer.ResolveStub();
		CancelStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelStruct()
	{
	}
}
