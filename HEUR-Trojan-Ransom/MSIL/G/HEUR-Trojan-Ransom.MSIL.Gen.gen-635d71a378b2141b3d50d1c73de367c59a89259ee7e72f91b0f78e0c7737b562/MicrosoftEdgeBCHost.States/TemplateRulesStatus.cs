using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TemplateRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DefineInterfaceModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineInterfaceModel()
	{
	}
}
