using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DescriptorGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		ListInterfaceExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListInterfaceExpression()
	{
	}
}
