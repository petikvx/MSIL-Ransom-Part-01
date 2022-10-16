using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TestAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		RevertLiteralException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertLiteralException()
	{
	}
}
