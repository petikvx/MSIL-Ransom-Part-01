using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InitializerWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		SearchRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchRules()
	{
	}
}
