using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class WrapperUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CollectInterfaceMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectInterfaceMap()
	{
	}
}
