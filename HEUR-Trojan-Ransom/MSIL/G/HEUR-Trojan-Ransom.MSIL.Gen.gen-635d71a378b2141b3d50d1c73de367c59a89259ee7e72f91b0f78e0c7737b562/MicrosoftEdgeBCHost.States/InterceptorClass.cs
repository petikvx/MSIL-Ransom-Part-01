using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InterceptorClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorClass()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfacePolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfacePolicy()
	{
	}
}
