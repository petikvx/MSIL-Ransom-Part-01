using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SystemWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		RunMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunMessage()
	{
	}
}
