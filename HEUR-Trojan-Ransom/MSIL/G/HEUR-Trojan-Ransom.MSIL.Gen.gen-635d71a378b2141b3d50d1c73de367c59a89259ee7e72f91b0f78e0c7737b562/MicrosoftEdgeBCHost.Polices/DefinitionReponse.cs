using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DefinitionReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionReponse()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralWorker()
	{
	}
}
