using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ManagerAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralValue()
	{
	}
}
