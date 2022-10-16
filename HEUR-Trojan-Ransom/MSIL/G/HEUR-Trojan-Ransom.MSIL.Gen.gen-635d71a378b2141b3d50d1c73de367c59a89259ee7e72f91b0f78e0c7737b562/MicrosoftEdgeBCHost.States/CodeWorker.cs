using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CodeWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeWorker()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInvocation()
	{
	}
}
