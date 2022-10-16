using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ValFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		TestParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestParam()
	{
	}
}
