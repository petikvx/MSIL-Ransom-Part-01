using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InstanceAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		MoveInterfaceToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveInterfaceToken()
	{
	}
}
