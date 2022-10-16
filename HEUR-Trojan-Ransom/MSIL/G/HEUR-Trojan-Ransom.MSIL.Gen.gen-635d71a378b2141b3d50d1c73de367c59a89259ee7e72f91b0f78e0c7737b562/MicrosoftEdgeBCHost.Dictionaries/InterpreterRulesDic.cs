using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InterpreterRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		SetupInterfaceWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupInterfaceWriter()
	{
	}
}
