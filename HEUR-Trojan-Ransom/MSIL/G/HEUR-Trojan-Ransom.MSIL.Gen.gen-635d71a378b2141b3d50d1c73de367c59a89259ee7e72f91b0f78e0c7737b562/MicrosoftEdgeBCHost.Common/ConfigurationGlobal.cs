using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConfigurationGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		AddInterfaceCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddInterfaceCandidate()
	{
	}
}
