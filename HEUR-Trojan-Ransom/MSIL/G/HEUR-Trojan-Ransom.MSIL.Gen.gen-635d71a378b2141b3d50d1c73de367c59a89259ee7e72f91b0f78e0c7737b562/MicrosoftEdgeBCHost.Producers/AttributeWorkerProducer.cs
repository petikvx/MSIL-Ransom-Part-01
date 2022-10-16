using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AttributeWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceException()
	{
	}
}
