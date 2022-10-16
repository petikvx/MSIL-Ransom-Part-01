using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SchemaAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PopLiteralPrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopLiteralPrinter()
	{
	}
}
