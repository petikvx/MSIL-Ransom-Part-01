using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AccountContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountContext()
	{
		WriterPropertyProducer.ResolveStub();
		RevertInterfaceContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertInterfaceContainer()
	{
	}
}
