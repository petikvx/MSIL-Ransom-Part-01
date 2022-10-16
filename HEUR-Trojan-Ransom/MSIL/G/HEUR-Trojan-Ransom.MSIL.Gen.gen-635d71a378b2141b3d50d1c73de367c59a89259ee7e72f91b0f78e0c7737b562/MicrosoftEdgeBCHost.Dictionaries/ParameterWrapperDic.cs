using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParameterWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptStrategy()
	{
	}
}
