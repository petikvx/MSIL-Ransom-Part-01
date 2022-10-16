using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TestsContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsContext()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceToken()
	{
	}
}
