using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ServiceOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceOrder()
	{
		WriterPropertyProducer.ResolveStub();
		GetInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetInterceptor()
	{
	}
}
