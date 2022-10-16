using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ReponseWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralRules()
	{
	}
}
