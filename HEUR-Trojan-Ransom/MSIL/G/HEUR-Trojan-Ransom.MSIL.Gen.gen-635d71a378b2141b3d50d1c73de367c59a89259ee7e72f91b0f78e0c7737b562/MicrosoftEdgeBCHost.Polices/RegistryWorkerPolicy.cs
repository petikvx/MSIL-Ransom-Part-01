using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RegistryWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceListener()
	{
	}
}
