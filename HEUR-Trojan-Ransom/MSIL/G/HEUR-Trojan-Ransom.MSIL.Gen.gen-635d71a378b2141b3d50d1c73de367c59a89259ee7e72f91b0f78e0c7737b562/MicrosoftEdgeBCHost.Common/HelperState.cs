using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class HelperState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperState()
	{
		WriterPropertyProducer.ResolveStub();
		CreateInterfaceException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateInterfaceException()
	{
	}
}
