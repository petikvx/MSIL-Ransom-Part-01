using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class StubFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceReponse()
	{
	}
}
