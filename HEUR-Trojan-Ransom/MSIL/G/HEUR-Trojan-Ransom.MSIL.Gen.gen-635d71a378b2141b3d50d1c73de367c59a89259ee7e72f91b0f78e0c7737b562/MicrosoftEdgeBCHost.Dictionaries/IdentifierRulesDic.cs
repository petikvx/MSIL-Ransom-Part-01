using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class IdentifierRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceContext()
	{
	}
}
