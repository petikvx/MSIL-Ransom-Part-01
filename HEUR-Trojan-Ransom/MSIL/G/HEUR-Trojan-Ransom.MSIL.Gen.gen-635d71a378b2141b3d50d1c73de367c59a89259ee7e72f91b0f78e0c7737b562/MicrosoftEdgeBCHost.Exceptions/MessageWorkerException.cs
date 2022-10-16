using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MessageWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		TestInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInitializer()
	{
	}
}
