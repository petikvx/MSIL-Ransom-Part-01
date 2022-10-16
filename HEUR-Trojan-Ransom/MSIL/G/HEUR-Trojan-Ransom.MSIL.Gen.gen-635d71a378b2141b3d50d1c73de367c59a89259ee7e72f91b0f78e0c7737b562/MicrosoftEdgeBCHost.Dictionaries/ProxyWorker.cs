using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProxyWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyWorker()
	{
		WriterPropertyProducer.ResolveStub();
		LoginDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginDatabase()
	{
	}
}
