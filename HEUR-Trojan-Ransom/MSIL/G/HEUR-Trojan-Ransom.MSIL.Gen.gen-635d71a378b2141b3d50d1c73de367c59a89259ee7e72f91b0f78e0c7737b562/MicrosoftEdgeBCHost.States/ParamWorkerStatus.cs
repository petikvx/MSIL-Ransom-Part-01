using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ParamWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateLiteralInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateLiteralInfo()
	{
	}
}
