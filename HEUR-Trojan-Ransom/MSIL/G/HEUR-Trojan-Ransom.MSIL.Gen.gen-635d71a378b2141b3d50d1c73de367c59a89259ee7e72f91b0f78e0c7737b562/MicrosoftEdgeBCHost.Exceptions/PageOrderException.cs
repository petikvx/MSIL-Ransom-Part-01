using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PageOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceMessage()
	{
	}
}
