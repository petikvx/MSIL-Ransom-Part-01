using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RecordWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		FindLiteralToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindLiteralToken()
	{
	}
}
