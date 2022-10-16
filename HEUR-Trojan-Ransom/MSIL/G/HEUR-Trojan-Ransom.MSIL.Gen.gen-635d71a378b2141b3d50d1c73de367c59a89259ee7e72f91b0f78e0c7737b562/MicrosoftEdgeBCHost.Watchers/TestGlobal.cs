using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TestGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceTemplate()
	{
	}
}
