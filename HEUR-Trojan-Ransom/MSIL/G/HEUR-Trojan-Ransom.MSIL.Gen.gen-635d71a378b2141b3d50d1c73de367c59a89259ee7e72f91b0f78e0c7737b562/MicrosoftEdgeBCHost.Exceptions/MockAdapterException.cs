using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MockAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralConnection()
	{
	}
}
