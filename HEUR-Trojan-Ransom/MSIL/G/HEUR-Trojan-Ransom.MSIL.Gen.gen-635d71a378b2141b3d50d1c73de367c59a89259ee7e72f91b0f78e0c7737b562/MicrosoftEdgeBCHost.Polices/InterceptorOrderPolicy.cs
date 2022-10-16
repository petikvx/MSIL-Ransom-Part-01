using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InterceptorOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralDecorator()
	{
	}
}
