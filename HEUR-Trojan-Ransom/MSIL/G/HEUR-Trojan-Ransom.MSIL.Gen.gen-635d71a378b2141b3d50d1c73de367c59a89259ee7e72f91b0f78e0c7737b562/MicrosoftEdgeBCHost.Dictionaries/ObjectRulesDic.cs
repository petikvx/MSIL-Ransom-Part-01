using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ObjectRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceConfiguration()
	{
	}
}
