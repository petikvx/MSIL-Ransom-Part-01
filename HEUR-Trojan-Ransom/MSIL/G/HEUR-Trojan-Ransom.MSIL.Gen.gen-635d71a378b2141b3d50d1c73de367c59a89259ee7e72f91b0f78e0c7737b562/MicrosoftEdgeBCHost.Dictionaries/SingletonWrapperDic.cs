using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SingletonWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeModel()
	{
	}
}
