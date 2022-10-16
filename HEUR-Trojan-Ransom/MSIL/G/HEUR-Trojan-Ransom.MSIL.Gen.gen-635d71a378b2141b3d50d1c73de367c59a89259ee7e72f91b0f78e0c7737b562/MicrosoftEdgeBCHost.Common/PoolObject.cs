using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PoolObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolObject()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralCandidate()
	{
	}
}
