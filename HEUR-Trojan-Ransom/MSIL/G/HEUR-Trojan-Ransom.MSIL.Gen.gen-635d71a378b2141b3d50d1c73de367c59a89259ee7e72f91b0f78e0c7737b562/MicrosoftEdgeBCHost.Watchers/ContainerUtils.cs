using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ContainerUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerUtils()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceTests()
	{
	}
}
