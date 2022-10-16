using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CodeOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceState()
	{
	}
}
