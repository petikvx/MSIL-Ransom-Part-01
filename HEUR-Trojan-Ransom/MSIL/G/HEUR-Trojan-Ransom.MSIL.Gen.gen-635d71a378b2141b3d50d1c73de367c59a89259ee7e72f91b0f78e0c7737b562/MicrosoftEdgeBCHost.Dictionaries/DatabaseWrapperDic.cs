using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DatabaseWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		PostStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostStrategy()
	{
	}
}
