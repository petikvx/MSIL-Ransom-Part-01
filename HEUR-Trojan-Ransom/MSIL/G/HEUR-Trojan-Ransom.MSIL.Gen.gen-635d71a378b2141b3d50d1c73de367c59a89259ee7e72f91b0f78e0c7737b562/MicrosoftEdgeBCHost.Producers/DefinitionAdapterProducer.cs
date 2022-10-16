using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DefinitionAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralAttr()
	{
	}
}
