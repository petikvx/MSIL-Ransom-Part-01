using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TemplateServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateServer()
	{
		WriterPropertyProducer.ResolveStub();
		CreateLiteralContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateLiteralContainer()
	{
	}
}
