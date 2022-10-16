using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TestContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestContext()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfacePredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfacePredicate()
	{
	}
}
