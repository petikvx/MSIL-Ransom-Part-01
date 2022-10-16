using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ThreadPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfaceAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfaceAccount()
	{
	}
}
