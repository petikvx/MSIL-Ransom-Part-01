using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ConfigurationValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DisableInterfaceObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableInterfaceObject()
	{
	}
}
