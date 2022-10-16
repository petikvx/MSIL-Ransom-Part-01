using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TestAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceToken()
	{
	}
}
