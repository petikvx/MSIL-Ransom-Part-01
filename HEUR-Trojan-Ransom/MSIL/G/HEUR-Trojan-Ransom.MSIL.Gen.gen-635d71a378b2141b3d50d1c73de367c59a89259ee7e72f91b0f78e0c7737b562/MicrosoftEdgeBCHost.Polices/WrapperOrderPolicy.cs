using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class WrapperOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RateInterfaceHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateInterfaceHelper()
	{
	}
}
