using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RegistryFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AssetPrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetPrototype()
	{
	}
}
