using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PolicyWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		MoveAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveAlgo()
	{
	}
}
