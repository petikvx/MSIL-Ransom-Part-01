using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InitializerVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerVal()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutSingleton()
	{
	}
}
