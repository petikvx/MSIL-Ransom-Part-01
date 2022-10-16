using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MockRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceStub()
	{
	}
}
