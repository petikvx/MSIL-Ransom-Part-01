using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AdapterFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterFilter()
	{
		WriterPropertyProducer.ResolveStub();
		AssetPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetPage()
	{
	}
}
