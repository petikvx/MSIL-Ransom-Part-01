using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AccountFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInterfaceConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInterfaceConfiguration()
	{
	}
}
