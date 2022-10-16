using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InitializerObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerObject()
	{
		WriterPropertyProducer.ResolveStub();
		CreateLiteralTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateLiteralTemplate()
	{
	}
}
