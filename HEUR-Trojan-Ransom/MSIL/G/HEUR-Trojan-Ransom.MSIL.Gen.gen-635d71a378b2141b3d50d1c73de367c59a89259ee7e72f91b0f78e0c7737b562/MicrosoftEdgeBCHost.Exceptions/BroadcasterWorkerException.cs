using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class BroadcasterWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		CreateComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateComposer()
	{
	}
}
