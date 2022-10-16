using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InitializerRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceVisitor()
	{
	}
}
