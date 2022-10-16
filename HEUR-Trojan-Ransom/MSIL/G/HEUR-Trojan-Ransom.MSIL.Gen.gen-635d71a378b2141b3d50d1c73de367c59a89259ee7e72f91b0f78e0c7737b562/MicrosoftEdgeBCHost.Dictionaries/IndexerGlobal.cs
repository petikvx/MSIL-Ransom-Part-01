using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class IndexerGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		CreateInterfaceAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateInterfaceAuthentication()
	{
	}
}
