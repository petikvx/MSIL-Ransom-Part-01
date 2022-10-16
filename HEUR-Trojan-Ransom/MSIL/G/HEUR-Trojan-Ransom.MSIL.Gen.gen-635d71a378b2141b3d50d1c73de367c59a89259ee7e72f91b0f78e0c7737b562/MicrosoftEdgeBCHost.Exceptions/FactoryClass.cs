using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class FactoryClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryClass()
	{
		WriterPropertyProducer.ResolveStub();
		AssetInterfacePool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetInterfacePool()
	{
	}
}
