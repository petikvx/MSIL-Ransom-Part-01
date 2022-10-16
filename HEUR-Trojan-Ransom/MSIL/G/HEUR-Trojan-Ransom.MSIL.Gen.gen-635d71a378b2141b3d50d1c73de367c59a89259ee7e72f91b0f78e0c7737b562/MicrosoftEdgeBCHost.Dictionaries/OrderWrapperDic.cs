using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class OrderWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		PrintIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintIdentifier()
	{
	}
}
