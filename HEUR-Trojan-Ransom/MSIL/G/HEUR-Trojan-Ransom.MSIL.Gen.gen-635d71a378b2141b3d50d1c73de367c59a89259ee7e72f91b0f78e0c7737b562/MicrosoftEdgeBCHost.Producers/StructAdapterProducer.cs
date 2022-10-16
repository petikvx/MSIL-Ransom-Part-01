using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StructAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeLiteralDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeLiteralDefinition()
	{
	}
}
