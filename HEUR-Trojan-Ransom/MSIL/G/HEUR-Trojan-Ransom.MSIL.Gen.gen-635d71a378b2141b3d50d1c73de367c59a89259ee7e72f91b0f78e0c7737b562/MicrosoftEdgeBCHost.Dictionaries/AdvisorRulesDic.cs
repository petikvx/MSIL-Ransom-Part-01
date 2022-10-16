using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AdvisorRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceDatabase()
	{
	}
}
