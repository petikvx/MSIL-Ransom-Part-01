using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class IteratorOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		PostInterfaceAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInterfaceAttr()
	{
	}
}
