using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RecordWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RevertInterfaceDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertInterfaceDefinition()
	{
	}
}
