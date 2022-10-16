using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SingletonOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonOrder()
	{
		WriterPropertyProducer.ResolveStub();
		DefineItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineItem()
	{
	}
}
