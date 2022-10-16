using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InvocationRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceParser()
	{
	}
}
