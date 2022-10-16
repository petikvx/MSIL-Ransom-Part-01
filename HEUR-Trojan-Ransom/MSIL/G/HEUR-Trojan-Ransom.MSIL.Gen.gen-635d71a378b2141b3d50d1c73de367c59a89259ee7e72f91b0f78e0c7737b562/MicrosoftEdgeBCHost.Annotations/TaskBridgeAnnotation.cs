using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TaskBridgeAnnotation : Attribute, _003CModule_003E, TaskBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectIssuer()
	{
	}
}
