using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ClassOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralCollection()
	{
	}
}
