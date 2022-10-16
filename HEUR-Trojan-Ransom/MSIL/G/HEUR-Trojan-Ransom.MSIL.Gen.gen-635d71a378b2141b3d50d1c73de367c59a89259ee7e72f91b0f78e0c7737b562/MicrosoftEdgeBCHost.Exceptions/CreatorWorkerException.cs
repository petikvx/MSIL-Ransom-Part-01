using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CreatorWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		MapDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapDispatcher()
	{
	}
}
