using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bowd4erizing;
using Car1ass;
using Microsoft.VisualStudio.TemplateEngine.VS;
using Microsoft.WebTools.Shared.Telemetry;
using Microsoft.WebTools.Shared.VS.VisualStudio.Wrappers;
using Quai7ter;
using Reimplantati3n;
using Stamp3d3rs;
using Z0ng0er;

namespace S2arkler;

internal class Ba3ky : Gr8uter
{
	protected const string HealthFeatureString = "CreateProject";

	public Ba3ky(ITemplateWizardPipelineFactory pipelineFactory, IDictionary<string, string> dictionary)
		: base(pipelineFactory, dictionary)
	{
	}

	protected override async Task<bool> TrySelectTemplateCore(IProjectCreationMetadata metadata)
	{
		bool result = false;
		if (Butt6ng(metadata.get_TargetName()))
		{
			base.Condu6ts = Enum0.ShowUI;
			bool backedOut = false;
			try
			{
				if (TryGetProjectCreator(metadata.get_UIStyle(), metadata.get_TemplateType(), out var creator))
				{
					result = await creator.SelectTemplateAsync(metadata, (IReadOnlyDictionary<string, string>)base.Dictionary_0);
				}
				if (!result && string.IsNullOrEmpty(base.String_0))
				{
					base.String_0 = metadata.get_TelemetryErrorDetail();
				}
			}
			catch (OperationCanceledException)
			{
				backedOut = true;
			}
			catch (Exception ex2)
			{
				Exception ex4 = (base.Juri0ic = ex2);
				base.Eldes4.TryLogException(ex4, "TemplateEngineWizard");
				throw;
			}
			finally
			{
				if (!result && !backedOut)
				{
					(string type, string subType) healthProjectType = GetHealthProjectType();
					string item = healthProjectType.type;
					string item2 = healthProjectType.subType;
					HealthEvent val = new HealthEvent(base.Limpingl7, Guid.Empty, item, "CreateProject", "unknown", item2);
					try
					{
						val.set_Outcome(false);
						if (base.Juri0ic == null)
						{
							val.set_FailureMessage((!string.IsNullOrEmpty(base.String_0)) ? base.String_0 : $"Failed during stage: {base.Condu6ts}");
						}
						else
						{
							val.set_Failure(base.Juri0ic);
						}
						val.set_FailureBucket(string.Format("{0}-{1}", "TemplateWizardProjectPipeline", base.Condu6ts));
					}
					finally
					{
						((IDisposable)val)?.Dispose();
					}
				}
			}
		}
		return result;
	}

	protected override IProjectCreationMetadata PrepareMetadata()
	{
		IProjectCreationMetadata val = base.PrepareMetadata();
		val.set_TemplateType("project");
		val.set_TargetName(GetString(Counte7acts.Le2d));
		val.set_ApplyAuth(GetString(Counte7acts.Roughdrie8));
		val.set_PlatformVersion(GetString(Counte7acts.Thro1boe1bolis1));
		if (string.IsNullOrEmpty(val.get_TemplateIdentity()))
		{
			val.set_TemplateIdentity(GetString(Counte7acts.Ter6iversate));
		}
		return val;
	}

	protected override void PostTelemetryEvent(ITelemetryModel model, bool success)
	{
		base.PostTelemetryEvent(model, success);
		Gran5ee(model, success);
	}

	private bool Butt6ng(string Up8tarted)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (VsSolutionWrapper.get_Instance().GetProjectByName(Up8tarted) != null)
		{
			VsShellWrapper.get_Instance().ShowMessageBox(string.Format(CultureInfo.CurrentCulture, Strings.DuplicateProjectName, Up8tarted), (MessageBoxButtons)0, (MessageBoxIcon)48);
			return false;
		}
		return true;
	}

	private void Gran5ee(ITelemetryModel Su5erheaters, bool bool_0)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		if (!Dhoora3.Inve3ghed(Su5erheaters.CreatedProjectHierarchy, out var _, out var Telso) || !Guid.TryParse(Telso, out var result))
		{
			result = Guid.Empty;
		}
		(string type, string subType) healthProjectType = GetHealthProjectType();
		string item = healthProjectType.type;
		string item2 = healthProjectType.subType;
		HealthEvent val = new HealthEvent(base.Safa8i.TelemetryProvider, result, item, "CreateProject", Su5erheaters.TemplateIdentity, item2);
		try
		{
			val.set_Outcome(bool_0);
			if (!bool_0)
			{
				if (base.Juri0ic == null)
				{
					val.set_FailureMessage((!string.IsNullOrEmpty(base.String_0)) ? base.String_0 : $"Failed during stage: {base.Condu6ts}");
				}
				else
				{
					val.set_Failure(base.Juri0ic);
				}
				val.set_FailureBucket(string.Format("{0}-{1}", "PostHealthEventFromTelemetryModel", base.Condu6ts));
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
