using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ComparatorBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorBridge()
	{
		WriterPropertyProducer.ResolveStub();
		LoginGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginGlobal()
	{
	}
}
