using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ContainerDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerDic()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralCallback()
	{
	}
}
