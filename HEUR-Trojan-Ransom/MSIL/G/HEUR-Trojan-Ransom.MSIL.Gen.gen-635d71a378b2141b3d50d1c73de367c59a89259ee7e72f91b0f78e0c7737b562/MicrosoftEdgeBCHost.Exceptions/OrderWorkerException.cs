using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class OrderWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		CloneResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneResolver()
	{
	}
}
