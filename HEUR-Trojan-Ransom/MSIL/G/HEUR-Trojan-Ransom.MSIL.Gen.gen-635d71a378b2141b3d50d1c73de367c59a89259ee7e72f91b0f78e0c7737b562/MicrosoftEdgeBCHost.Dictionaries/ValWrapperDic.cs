using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ValWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteValue()
	{
	}
}
