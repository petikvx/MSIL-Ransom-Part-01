using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParserBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		RunInterfaceValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInterfaceValue()
	{
	}
}
