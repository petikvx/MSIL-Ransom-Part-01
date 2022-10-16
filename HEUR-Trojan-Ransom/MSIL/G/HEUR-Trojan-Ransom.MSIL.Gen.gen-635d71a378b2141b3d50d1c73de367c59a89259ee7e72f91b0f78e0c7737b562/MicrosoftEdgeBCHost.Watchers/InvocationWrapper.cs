using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InvocationWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		SelectDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectDic()
	{
	}
}
