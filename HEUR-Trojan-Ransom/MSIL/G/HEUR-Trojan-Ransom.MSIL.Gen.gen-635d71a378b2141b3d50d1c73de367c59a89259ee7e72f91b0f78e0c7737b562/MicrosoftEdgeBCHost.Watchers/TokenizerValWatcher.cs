using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TokenizerValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceRecord()
	{
	}
}
