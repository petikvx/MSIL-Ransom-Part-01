using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class GlobalWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralWatcher()
	{
	}
}
