using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RegistryAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceObject()
	{
	}
}
