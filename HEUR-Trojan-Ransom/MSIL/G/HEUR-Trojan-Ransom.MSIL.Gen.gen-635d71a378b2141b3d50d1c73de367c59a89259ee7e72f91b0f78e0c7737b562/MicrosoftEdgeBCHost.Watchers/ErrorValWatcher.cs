using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ErrorValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RunInterfaceDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInterfaceDic()
	{
	}
}
