using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AttributeWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutLiteralDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutLiteralDatabase()
	{
	}
}
