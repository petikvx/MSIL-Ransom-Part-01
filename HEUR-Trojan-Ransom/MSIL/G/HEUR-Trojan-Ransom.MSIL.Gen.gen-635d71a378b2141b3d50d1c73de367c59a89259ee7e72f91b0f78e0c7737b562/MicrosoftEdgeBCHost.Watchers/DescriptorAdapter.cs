using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DescriptorAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceGetter()
	{
	}
}
