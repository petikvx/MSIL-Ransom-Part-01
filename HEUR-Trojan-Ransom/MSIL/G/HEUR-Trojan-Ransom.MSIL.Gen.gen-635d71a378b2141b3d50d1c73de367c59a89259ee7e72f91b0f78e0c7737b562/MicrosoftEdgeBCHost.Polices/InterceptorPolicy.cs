using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InterceptorPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeInterfaceAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeInterfaceAccount()
	{
	}
}
