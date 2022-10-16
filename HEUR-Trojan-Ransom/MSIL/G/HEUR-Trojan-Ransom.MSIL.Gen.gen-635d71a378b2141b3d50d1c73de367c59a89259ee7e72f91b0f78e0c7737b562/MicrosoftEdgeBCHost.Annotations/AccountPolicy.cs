using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AccountPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ListInterfaceField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListInterfaceField()
	{
	}
}
