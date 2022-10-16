using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ModelWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CloneLiteralBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneLiteralBase()
	{
	}
}
