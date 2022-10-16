using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SingletonOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InitLiteralInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitLiteralInterpreter()
	{
	}
}
