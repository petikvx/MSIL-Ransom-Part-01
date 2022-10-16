using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class IteratorUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorUtils()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfacePrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfacePrototype()
	{
	}
}
