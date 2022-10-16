using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ContainerValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PopInterfaceParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopInterfaceParameter()
	{
	}
}
