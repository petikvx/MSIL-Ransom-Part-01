using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MockPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceAdvisor()
	{
	}
}
