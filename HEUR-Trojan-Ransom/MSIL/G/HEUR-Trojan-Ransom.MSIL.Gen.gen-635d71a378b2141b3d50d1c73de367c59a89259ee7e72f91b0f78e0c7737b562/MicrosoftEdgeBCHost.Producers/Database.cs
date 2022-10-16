using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class Database
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Database()
	{
		WriterPropertyProducer.ResolveStub();
		AssetEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetEvent()
	{
	}
}
