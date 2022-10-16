using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class FacadePropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadePropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		ListLiteralStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListLiteralStatus()
	{
	}
}
