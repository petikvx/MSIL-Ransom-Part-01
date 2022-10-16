using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SchemaWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaWorker()
	{
		WriterPropertyProducer.ResolveStub();
		FillCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillCreator()
	{
	}
}
