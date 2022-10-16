using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DecoratorGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		PostInterfaceIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInterfaceIterator()
	{
	}
}
