using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ImporterFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterFilter()
	{
		WriterPropertyProducer.ResolveStub();
		AssetExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetExpression()
	{
	}
}
