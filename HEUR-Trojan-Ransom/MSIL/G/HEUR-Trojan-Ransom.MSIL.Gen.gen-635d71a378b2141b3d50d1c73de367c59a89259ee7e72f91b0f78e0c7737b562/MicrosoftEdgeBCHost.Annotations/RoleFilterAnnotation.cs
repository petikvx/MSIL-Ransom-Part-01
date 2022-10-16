using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RoleFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceOrder()
	{
	}
}
