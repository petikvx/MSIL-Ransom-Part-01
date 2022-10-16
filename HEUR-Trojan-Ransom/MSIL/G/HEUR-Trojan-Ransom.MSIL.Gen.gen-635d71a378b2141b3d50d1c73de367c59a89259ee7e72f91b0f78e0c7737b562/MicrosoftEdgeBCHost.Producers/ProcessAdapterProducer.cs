using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProcessAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CreateLiteralIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateLiteralIterator()
	{
	}
}
