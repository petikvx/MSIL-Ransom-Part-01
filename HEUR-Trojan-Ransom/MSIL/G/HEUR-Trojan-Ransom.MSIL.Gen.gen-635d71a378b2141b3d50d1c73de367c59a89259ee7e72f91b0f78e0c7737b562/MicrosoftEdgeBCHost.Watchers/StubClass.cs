using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StubClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubClass()
	{
		WriterPropertyProducer.ResolveStub();
		RunInterfaceList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInterfaceList()
	{
	}
}
