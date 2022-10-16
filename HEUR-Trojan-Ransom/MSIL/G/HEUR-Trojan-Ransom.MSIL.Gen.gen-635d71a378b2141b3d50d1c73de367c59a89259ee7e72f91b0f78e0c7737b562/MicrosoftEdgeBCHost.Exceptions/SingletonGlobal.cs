using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SingletonGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		RevertInterfaceConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertInterfaceConfig()
	{
	}
}
