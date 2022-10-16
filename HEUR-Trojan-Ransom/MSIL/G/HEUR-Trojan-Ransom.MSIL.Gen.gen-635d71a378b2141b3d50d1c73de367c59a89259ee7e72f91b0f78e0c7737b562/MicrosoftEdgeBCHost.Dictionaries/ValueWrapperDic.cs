using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ValueWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludePrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludePrototype()
	{
	}
}
