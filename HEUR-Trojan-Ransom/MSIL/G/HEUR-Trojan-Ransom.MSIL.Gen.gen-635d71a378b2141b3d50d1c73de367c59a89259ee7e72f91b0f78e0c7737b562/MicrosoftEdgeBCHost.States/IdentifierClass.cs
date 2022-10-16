using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class IdentifierClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierClass()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceTokenizer()
	{
	}
}
