using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TestsOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceContext()
	{
	}
}
