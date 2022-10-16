using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ExpressionRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceDefinition()
	{
	}
}
