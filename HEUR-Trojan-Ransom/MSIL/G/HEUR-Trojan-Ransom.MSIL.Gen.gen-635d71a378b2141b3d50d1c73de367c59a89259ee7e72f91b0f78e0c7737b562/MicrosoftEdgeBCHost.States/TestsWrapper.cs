using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TestsWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		PublishRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishRef()
	{
	}
}
