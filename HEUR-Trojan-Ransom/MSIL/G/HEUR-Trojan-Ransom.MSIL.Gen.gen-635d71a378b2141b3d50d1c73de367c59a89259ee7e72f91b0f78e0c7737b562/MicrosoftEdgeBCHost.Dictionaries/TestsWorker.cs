using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TestsWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsWorker()
	{
		WriterPropertyProducer.ResolveStub();
		SetupSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupSerializer()
	{
	}
}
