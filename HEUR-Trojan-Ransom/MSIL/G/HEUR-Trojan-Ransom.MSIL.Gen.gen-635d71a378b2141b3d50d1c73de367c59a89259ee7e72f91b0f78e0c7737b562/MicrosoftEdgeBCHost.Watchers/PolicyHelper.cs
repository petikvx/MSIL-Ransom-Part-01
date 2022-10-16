using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PolicyHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyHelper()
	{
		WriterPropertyProducer.ResolveStub();
		QueryLiteralInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryLiteralInvocation()
	{
	}
}
