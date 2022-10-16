using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TemplateState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateState()
	{
		WriterPropertyProducer.ResolveStub();
		SetupInterfaceModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupInterfaceModel()
	{
	}
}
