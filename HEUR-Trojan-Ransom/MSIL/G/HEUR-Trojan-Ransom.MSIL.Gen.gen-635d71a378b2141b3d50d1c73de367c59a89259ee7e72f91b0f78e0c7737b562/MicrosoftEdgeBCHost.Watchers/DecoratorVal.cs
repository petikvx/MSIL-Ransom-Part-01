using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DecoratorVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorVal()
	{
		WriterPropertyProducer.ResolveStub();
		DefineInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineInfo()
	{
	}
}
