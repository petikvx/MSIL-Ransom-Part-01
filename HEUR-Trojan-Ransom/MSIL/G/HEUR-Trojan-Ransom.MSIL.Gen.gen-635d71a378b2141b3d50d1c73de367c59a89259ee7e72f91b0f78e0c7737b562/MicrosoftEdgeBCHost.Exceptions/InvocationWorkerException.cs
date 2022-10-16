using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InvocationWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiatePredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiatePredicate()
	{
	}
}
