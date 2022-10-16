using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AttributeWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		PrintObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintObserver()
	{
	}
}
