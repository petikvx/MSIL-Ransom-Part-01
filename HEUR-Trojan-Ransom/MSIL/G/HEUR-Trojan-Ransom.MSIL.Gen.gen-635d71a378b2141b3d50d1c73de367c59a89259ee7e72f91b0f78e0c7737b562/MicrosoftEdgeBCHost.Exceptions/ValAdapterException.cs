using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ValAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceComparator()
	{
	}
}
