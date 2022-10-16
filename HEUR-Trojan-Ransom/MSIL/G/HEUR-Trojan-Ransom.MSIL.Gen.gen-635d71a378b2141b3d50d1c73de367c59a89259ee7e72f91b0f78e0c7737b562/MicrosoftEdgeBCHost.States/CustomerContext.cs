using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CustomerContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerContext()
	{
		WriterPropertyProducer.ResolveStub();
		SetupInterfaceSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupInterfaceSpecification()
	{
	}
}
