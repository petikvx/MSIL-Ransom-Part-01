using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DecoratorFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceMethod()
	{
	}
}
