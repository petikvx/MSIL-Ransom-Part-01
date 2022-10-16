using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class IteratorWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterModel()
	{
	}
}
