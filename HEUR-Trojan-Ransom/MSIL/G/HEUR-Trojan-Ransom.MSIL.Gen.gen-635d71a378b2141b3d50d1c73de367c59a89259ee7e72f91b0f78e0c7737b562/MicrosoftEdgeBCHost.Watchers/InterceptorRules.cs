using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InterceptorRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorRules()
	{
		WriterPropertyProducer.ResolveStub();
		CancelParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelParam()
	{
	}
}
