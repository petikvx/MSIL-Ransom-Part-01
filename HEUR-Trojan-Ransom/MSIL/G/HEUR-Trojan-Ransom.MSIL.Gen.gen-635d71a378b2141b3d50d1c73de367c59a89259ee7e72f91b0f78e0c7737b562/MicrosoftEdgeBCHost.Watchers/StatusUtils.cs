using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StatusUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusUtils()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceAttr()
	{
	}
}
