using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RuleWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		PublishWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishWrapper()
	{
	}
}
