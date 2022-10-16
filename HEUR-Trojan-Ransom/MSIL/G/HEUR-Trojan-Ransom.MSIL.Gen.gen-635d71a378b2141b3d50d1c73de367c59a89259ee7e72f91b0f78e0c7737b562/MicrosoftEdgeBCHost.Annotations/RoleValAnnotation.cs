using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RoleValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceMerchant()
	{
	}
}
