using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InitializerWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		ViewDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewDefinition()
	{
	}
}
