using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InvocationWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterTag()
	{
	}
}
