using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ContextOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		ManageConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageConsumer()
	{
	}
}
