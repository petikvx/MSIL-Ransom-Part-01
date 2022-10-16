using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RepositoryOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeLiteralExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeLiteralExporter()
	{
	}
}
