using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TestPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AddInterfaceReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddInterfaceReader()
	{
	}
}
