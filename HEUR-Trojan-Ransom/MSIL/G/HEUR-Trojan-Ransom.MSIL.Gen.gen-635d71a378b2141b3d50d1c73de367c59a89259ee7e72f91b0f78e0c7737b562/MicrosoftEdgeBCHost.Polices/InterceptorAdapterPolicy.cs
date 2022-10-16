using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InterceptorAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ListLiteralInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListLiteralInterpreter()
	{
	}
}
