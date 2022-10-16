using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CreatorWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		StopState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopState()
	{
	}
}
