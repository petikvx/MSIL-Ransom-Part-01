using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ReponseRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyInterceptor()
	{
	}
}
