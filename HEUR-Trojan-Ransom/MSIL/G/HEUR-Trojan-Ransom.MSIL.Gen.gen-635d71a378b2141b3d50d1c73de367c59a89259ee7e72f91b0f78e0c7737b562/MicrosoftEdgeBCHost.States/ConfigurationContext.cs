using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ConfigurationContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationContext()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceSingleton()
	{
	}
}
