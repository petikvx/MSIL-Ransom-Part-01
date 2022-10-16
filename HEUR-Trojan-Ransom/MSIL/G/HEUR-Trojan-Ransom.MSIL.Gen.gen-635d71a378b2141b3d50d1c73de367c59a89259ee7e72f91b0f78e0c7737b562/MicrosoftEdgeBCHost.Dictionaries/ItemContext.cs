using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ItemContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemContext()
	{
		WriterPropertyProducer.ResolveStub();
		AssetInterfaceToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetInterfaceToken()
	{
	}
}
