using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ValOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		TestRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestRegistry()
	{
	}
}
