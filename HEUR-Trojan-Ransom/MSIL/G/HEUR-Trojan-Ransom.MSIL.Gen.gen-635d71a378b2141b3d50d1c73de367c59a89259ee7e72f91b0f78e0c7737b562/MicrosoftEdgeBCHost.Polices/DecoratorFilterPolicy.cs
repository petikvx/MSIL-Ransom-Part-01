using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DecoratorFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutWatcher()
	{
	}
}
