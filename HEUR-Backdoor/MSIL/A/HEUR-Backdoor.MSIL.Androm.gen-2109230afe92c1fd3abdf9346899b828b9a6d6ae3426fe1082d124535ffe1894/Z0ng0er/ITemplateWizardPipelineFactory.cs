using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TemplateEngine.VS;
using Microsoft.VisualStudio.TemplateWizard;
using Microsoft.WebTools.Shared.Diagnostics;
using Microsoft.WebTools.Shared.Telemetry;
using Microsoft.WebTools.Shared.VS.Helpers;
using Microsoft.WebTools.Shared.VS.VisualStudio.Wrappers;
using Sa1es;

namespace Z0ng0er;

internal interface ITemplateWizardPipelineFactory
{
	IServiceProvider ServiceProvider { get; }

	ICommonSystemServices SystemServices { get; }

	IEnumerable<Lazy<IProjectCreator, ITemplateCreatorMetadata>> Providers { get; }

	IActivityLog ActivityLog { get; }

	IVsWrappersFactory WrappersFactory { get; }

	IEnumerable<IProjectCreationHandler> CreationHandlers { get; }

	ITelemetryProvider TelemetryProvider { get; }

	ITemplateWizardPipeline Create(WizardRunKind kind, IDictionary<string, string> replacementDictionary);
}
