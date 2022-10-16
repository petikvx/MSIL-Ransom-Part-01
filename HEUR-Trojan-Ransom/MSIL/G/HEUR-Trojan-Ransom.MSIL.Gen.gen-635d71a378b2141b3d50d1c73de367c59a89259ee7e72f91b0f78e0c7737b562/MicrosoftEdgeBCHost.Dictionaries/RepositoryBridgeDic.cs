using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RepositoryBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfaceValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfaceValue()
	{
	}
}
