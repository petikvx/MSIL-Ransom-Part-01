using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RoleOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotInterfaceItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotInterfaceItem()
	{
	}
}
