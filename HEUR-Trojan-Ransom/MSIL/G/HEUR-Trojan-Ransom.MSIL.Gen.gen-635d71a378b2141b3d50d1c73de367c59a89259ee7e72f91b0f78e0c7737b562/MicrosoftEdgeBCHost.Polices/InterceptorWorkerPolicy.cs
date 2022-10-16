using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InterceptorWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DefineInterfaceConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineInterfaceConfig()
	{
	}
}
