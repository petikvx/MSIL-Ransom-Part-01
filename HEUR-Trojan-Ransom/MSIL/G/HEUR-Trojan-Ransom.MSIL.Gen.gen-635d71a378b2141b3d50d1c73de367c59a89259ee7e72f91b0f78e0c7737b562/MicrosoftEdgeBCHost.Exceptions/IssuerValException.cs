using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class IssuerValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerValException()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectDescriptor()
	{
	}
}
