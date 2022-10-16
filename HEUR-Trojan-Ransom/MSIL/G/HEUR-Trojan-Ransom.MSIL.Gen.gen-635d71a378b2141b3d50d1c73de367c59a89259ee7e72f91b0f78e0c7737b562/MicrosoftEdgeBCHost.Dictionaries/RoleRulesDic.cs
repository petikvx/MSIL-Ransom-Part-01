using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RoleRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceAccount()
	{
	}
}
