using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InvocationPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PopInterfaceAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopInterfaceAccount()
	{
	}
}
