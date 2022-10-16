using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PrototypeWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		PushCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushCollection()
	{
	}
}
