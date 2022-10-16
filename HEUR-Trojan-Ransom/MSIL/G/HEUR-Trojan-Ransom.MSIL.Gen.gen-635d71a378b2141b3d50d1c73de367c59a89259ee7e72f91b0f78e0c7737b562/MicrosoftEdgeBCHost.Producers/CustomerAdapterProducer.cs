using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CustomerAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralIterator()
	{
	}
}
