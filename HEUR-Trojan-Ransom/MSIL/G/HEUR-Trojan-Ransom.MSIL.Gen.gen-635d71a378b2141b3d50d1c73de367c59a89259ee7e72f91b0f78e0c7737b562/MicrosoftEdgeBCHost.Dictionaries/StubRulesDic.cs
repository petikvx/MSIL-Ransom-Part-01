using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class StubRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		GetInterfaceRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetInterfaceRef()
	{
	}
}
