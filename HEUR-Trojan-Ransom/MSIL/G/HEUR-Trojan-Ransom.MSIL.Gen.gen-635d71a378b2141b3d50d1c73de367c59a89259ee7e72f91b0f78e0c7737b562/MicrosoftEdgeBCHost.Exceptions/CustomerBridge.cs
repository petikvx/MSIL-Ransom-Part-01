using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CustomerBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerBridge()
	{
		WriterPropertyProducer.ResolveStub();
		InitException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitException()
	{
	}
}
