using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DefinitionWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionWorker()
	{
		WriterPropertyProducer.ResolveStub();
		FlushField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushField()
	{
	}
}
