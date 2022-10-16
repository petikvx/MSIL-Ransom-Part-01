using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RepositoryAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveLiteralParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveLiteralParams()
	{
	}
}
