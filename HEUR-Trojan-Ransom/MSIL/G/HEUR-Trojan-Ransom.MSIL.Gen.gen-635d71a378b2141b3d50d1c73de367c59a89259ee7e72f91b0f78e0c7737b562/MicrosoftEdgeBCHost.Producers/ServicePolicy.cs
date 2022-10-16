using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ServicePolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServicePolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceSystem()
	{
	}
}
