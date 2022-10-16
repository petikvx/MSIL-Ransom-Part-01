using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RepositoryAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		SelectInterfaceGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectInterfaceGetter()
	{
	}
}
