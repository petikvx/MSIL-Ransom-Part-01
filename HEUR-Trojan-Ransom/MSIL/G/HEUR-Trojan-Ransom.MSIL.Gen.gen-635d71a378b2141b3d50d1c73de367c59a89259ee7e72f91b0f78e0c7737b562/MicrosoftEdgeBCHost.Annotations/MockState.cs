using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MockState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockState()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotInterfaceInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotInterfaceInitializer()
	{
	}
}
