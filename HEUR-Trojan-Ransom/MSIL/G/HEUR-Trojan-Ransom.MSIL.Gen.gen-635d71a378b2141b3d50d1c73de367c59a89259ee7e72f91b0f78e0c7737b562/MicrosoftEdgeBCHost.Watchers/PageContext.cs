using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PageContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageContext()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceSpecification()
	{
	}
}
