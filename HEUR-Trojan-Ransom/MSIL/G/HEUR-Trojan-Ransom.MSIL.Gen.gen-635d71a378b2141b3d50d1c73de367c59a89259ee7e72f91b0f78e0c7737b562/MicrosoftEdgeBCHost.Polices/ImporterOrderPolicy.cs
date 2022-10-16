using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ImporterOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralImporter()
	{
	}
}
