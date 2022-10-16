using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ListOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfacePrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfacePrototype()
	{
	}
}
