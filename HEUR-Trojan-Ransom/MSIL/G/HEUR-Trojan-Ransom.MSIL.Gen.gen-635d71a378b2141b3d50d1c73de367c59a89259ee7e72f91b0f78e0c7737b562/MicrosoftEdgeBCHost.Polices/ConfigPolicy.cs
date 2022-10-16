using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ConfigPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PostInterfaceStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInterfaceStub()
	{
	}
}
