using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ConfigGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		RestartInterfaceAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartInterfaceAuthentication()
	{
	}
}
