using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AttributeContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeContext()
	{
		WriterPropertyProducer.ResolveStub();
		SetupInterfaceAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupInterfaceAnnotation()
	{
	}
}
