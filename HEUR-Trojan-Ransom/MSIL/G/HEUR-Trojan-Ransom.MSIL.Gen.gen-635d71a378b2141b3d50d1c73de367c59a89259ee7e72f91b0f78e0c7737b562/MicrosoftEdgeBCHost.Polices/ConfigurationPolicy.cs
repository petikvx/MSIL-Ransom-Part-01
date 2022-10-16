using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ConfigurationPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceSystem()
	{
	}
}
