using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ContainerRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceStub()
	{
	}
}
