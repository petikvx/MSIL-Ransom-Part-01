using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SetterState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterState()
	{
		WriterPropertyProducer.ResolveStub();
		RevertInterfaceTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertInterfaceTag()
	{
	}
}
