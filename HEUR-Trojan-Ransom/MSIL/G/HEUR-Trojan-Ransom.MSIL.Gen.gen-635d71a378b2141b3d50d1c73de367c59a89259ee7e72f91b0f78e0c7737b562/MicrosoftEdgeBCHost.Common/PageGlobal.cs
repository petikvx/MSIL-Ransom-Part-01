using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PageGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		RunInterfaceStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInterfaceStrategy()
	{
	}
}
