using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MockPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		RevertLiteralTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertLiteralTask()
	{
	}
}
