using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PrototypeRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectDecorator()
	{
	}
}
