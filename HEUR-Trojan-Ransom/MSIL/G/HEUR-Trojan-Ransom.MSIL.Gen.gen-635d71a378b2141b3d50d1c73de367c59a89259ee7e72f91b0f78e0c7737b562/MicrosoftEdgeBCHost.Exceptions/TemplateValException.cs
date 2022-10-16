using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TemplateValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateValException()
	{
		WriterPropertyProducer.ResolveStub();
		CompareParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareParser()
	{
	}
}
