using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DefinitionWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PatchLiteralSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchLiteralSystem()
	{
	}
}
