using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RegistryFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DisableInterfaceRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableInterfaceRepository()
	{
	}
}
