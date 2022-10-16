using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParserClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserClass()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfaceStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfaceStruct()
	{
	}
}
