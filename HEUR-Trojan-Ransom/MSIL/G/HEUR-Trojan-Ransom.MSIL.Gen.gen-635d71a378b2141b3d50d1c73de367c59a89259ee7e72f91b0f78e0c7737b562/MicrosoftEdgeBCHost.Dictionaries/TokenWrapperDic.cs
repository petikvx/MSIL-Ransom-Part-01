using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TokenWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		RevertGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertGlobal()
	{
	}
}
