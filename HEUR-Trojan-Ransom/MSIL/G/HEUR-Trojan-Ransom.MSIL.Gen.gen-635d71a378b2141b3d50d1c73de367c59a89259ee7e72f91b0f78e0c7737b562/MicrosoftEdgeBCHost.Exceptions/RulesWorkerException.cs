using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RulesWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveVal()
	{
	}
}
