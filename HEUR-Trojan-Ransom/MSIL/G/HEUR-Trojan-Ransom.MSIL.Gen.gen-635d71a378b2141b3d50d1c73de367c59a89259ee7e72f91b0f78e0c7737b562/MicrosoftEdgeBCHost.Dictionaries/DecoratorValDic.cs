using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DecoratorValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorValDic()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralPolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralPolicy()
	{
	}
}
