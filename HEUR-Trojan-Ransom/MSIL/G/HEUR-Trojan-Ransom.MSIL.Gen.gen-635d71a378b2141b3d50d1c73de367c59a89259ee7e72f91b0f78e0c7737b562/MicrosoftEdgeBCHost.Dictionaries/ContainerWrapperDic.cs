using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ContainerWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		TestComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestComposer()
	{
	}
}
