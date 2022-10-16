using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TemplatePolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplatePolicy()
	{
		WriterPropertyProducer.ResolveStub();
		WriteInterfaceHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteInterfaceHelper()
	{
	}
}
