using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class EventWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeRules()
	{
	}
}
