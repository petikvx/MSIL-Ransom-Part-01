using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RegistryContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryContext()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceInterpreter()
	{
	}
}
