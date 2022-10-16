using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ClientWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeExpression()
	{
	}
}
