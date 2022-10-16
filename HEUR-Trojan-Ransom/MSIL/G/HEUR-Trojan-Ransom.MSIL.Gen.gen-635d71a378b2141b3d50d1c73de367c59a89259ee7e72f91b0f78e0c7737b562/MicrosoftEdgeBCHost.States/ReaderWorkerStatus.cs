using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ReaderWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralRepository()
	{
	}
}
