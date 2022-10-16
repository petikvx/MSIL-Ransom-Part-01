using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class StateOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		PushBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushBase()
	{
	}
}
