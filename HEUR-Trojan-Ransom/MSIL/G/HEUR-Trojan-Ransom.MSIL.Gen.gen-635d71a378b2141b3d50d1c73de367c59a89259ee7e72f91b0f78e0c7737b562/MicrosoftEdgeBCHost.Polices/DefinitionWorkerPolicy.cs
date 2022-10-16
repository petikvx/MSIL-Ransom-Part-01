using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DefinitionWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RunInterfaceModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInterfaceModel()
	{
	}
}
