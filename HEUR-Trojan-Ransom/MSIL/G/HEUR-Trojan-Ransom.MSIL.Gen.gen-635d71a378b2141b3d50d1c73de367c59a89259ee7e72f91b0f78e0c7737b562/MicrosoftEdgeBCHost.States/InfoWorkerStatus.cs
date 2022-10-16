using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InfoWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		StartLiteralTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartLiteralTokenizer()
	{
	}
}
