using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CreatorWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		FindLiteralContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindLiteralContainer()
	{
	}
}
