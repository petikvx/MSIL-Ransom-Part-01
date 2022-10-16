using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DatabaseAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralVisitor()
	{
	}
}
