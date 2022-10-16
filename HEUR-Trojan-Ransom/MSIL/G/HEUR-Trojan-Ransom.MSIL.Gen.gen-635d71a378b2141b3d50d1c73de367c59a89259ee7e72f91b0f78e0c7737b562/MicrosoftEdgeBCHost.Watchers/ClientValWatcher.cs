using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ClientValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ReadInterfaceProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadInterfaceProduct()
	{
	}
}
