using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TagGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfaceCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfaceCandidate()
	{
	}
}
