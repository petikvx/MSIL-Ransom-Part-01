using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RegistryValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizePolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizePolicy()
	{
	}
}
