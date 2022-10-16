using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CodeOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeOrder()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectClass()
	{
	}
}
