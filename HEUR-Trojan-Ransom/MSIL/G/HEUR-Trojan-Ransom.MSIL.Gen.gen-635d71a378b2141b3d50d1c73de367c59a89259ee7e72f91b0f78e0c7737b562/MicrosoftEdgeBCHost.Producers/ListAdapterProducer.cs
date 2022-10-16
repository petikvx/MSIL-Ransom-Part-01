using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ListAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralProperty()
	{
	}
}
