using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ServerOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralResolver()
	{
	}
}
