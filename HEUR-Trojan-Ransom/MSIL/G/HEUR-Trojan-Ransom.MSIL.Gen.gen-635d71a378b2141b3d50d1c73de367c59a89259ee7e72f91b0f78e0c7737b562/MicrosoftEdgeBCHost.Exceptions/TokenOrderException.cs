using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TokenOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		AddInterfaceProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddInterfaceProccesor()
	{
	}
}
