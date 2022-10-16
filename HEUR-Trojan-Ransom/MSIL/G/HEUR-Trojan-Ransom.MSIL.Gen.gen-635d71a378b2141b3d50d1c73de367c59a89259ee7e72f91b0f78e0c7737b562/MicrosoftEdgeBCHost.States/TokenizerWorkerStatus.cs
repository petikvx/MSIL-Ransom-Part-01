using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TokenizerWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralList()
	{
	}
}
