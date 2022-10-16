using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class IteratorWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		RunContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunContainer()
	{
	}
}
