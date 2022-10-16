using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RepositoryValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		AssetInterfaceRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetInterfaceRegistry()
	{
	}
}
