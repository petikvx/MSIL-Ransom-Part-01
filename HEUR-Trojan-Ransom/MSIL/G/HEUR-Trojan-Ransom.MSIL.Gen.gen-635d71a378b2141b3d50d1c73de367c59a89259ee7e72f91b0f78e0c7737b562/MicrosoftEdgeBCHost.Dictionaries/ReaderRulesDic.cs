using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ReaderRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceSchema()
	{
	}
}
