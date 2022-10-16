using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AccountAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		CreateInterfaceValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateInterfaceValue()
	{
	}
}
