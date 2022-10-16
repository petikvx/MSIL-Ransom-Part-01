using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DispatcherUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherUtils()
	{
		WriterPropertyProducer.ResolveStub();
		GetInterfaceMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetInterfaceMapper()
	{
	}
}
