using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Runtime.CompilerServices;
using Dep6esso6s;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.TemplateEngine.VS;
using Microsoft.VisualStudio.TemplateEngine.Wizard;
using Microsoft.VisualStudio.TemplateWizard;
using Microsoft.WebTools.Shared.Diagnostics;
using Microsoft.WebTools.Shared.Telemetry;
using Microsoft.WebTools.Shared.VS.Helpers;
using Microsoft.WebTools.Shared.VS.VisualStudio.Wrappers;
using S2arkler;
using Sa1es;
using Z0ng0er;

namespace Acc7d7as;

[Export(typeof(ITemplateWizardPipelineFactory))]
internal class Bris1le1ails : ITemplateWizardPipelineFactory
{
	[CompilerGenerated]
	private readonly IServiceProvider S6ghtsees;

	[CompilerGenerated]
	private readonly ICommonSystemServices Uncl0ses;

	[CompilerGenerated]
	private readonly IEnumerable<Lazy<IProjectCreator, ITemplateCreatorMetadata>> D0v0lop0r;

	[CompilerGenerated]
	private readonly IActivityLog Precoo0;

	[CompilerGenerated]
	private readonly IEnumerable<IProjectCreationHandler> Circumnavi4ates;

	[CompilerGenerated]
	private readonly IVsWrappersFactory Opa0;

	[CompilerGenerated]
	private readonly ITelemetryProvider Penicilla5e;

	public IServiceProvider ServiceProvider
	{
		[CompilerGenerated]
		get
		{
			return S6ghtsees;
		}
	}

	public ICommonSystemServices SystemServices
	{
		[CompilerGenerated]
		get
		{
			return Uncl0ses;
		}
	}

	public IEnumerable<Lazy<IProjectCreator, ITemplateCreatorMetadata>> Providers
	{
		[CompilerGenerated]
		get
		{
			return D0v0lop0r;
		}
	}

	public IActivityLog ActivityLog
	{
		[CompilerGenerated]
		get
		{
			return Precoo0;
		}
	}

	public IEnumerable<IProjectCreationHandler> CreationHandlers
	{
		[CompilerGenerated]
		get
		{
			return Circumnavi4ates;
		}
	}

	public IVsWrappersFactory WrappersFactory
	{
		[CompilerGenerated]
		get
		{
			return Opa0;
		}
	}

	public ITelemetryProvider TelemetryProvider
	{
		[CompilerGenerated]
		get
		{
			return Penicilla5e;
		}
	}

	[ImportingConstructor]
	public Bris1le1ails([Import(typeof(SVsServiceProvider))] IServiceProvider serviceProvider, [ImportMany] IEnumerable<Lazy<IProjectCreator, ITemplateCreatorMetadata>> providers, [ImportMany] IEnumerable<IProjectCreationHandler> creationHandlers, ICommonSystemServices services, ITelemetryProvider telemetryProvider, IActivityLog activityLogWrapper, IVsWrappersFactory wrappersFactory)
	{
		S6ghtsees = serviceProvider;
		D0v0lop0r = providers;
		Circumnavi4ates = creationHandlers;
		Uncl0ses = services;
		Penicilla5e = telemetryProvider;
		Precoo0 = activityLogWrapper;
		Opa0 = wrappersFactory;
	}

	public ITemplateWizardPipeline Squa3ations(WizardRunKind Teleproce33ing3, IDictionary<string, string> Fi4nd)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)Teleproce33ing3 != 1)
		{
			if (Teleproce33ing3 - 2 <= 1)
			{
			}
			return new Ba3ky(this, Fi4nd);
		}
		return new Lim5li(this, Fi4nd);
	}
}
