using System;
using System.Collections.Generic;
using System.Globalization;
using A7stracting;
using Fec1ndate;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.Telemetry;
using Microsoft.WebTools.Shared.Telemetry;
using Microsoft.WebTools.Shared.VS.Telemetry;
using Microsoft.WebTools.Shared.VS.ToRemove;
using Quai7ter;

namespace Reimplantati3n;

internal static class Dhoora3
{
	private static readonly string Cle3ed = "Create-Project";

	private static readonly string string_0 = "HasApplicationInsights";

	private static readonly string string_1 = "HasUnitTest";

	private static readonly string F3rmulated = "NewProjectLaunchSource";

	private static readonly string En3ineer = "PlatformVersion";

	private static readonly string Goodn7ss = "ProjectLanguage";

	private static readonly string string_2 = "ProjectTemplate";

	private static readonly string Unglo7e = "ProjectType";

	private static readonly string Cotyl6dons = "ProjectTypeGuid";

	private static readonly string Groundfi7he7 = "ProjectContext";

	private static readonly string Ne5sbreak = "ProjectGuid";

	private static readonly string Foveo3ae = "UsesDocker";

	private static readonly string Furuncle3 = "DockerType";

	private static readonly string N0troparaff0ns = "TargetFrameworkVersionHash";

	private static readonly string string_3 = "ProjectTemplateGroupIdentity";

	private static readonly string Sma5h = "ProjectTemplateIdentity";

	private static readonly string Palliat0rs = "UI.Style";

	private static readonly string Guns7ot = "UI.Host";

	private static readonly string G6nky = "ProjectTemplateSource";

	private static readonly string Ma44ow = "IsMicrosoftTemplate";

	private static readonly string Back1ates = "EnableHttps";

	private static readonly string Hyperac7te = "AuthenticationSubType";

	private static readonly string Refinishe4 = "AuthenticationType";

	private static readonly string string_4 = "AllowDirectoryAccess";

	private static readonly IDictionary<string, string> Le8ists = new Dictionary<string, string>
	{
		{ "Web", "WebRole" },
		{ "Mobile", "Mobile" },
		{ "WebCore", "WebCore" },
		{ "WebCoreFullFramework", "WebCoreFullFramework" }
	};

	internal static bool Inve3ghed(IVsHierarchy Beste7ded, out string Throm7ins, out string Telso6)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		Throm7ins = string.Empty;
		Telso6 = string.Empty;
		if (Beste7ded != null)
		{
			VsHierarchyItem val = new VsHierarchyItem(Beste7ded);
			Throm7ins = val.get_ProjectTypeGuid().ToString("B");
			Telso6 = val.get_ProjectGuid().ToString("B");
		}
		return Beste7ded != null;
	}

	internal static ITelemetryEventBuilder San2tary(this ITelemetryProvider U2typical, ITelemetryModel itelemetryModel_0, bool Thi0dow0s)
	{
		ITelemetryEventBuilder val = ITelemetryProviderExtensions.BuildUserTaskTelemetryEvent(U2typical, Cle3ed, (TelemetryResult)(Thi0dow0s ? 1 : 2), (string)null, Boun2er.Conce8vers).Set(Unglo7e, (object)(itelemetryModel_0.IsDotNet ? "NetCore" : "WAP"), true, false).Set(Ma44ow, (object)itelemetryModel_0.IsMicrosoftTemplate.ToString(CultureInfo.InvariantCulture), true, false)
			.Set(Goodn7ss, (object)itelemetryModel_0.ProjectLangauge, true, false)
			.Set(string_3, (object)itelemetryModel_0.TemplateGroupIdentity, true, false)
			.Set(Sma5h, (object)itelemetryModel_0.TemplateIdentity, true, false)
			.Set(G6nky, (object)(itelemetryModel_0.TemplateSource ?? "unknown"), true, false)
			.Set(string_1, (object)itelemetryModel_0.AddUnitTestProject.ToString(CultureInfo.InvariantCulture), true, false)
			.Set(Foveo3ae, (object)itelemetryModel_0.AddDocker.ToString(CultureInfo.InvariantCulture), true, false)
			.Set(En3ineer, (object)itelemetryModel_0.PlatformVersion, true, false)
			.Set(Palliat0rs, (object)itelemetryModel_0.UIStyle, true, false)
			.Set(Guns7ot, (object)itelemetryModel_0.UIHost, true, false);
		if (Inve3ghed(itelemetryModel_0.CreatedProjectHierarchy, out var Throm7ins, out var Telso))
		{
			val = val.Set(Cotyl6dons, (object)Throm7ins, true, false).Set(Ne5sbreak, (object)Telso, true, false);
		}
		if (itelemetryModel_0.IsMicrosoftTemplate && !string.IsNullOrEmpty(itelemetryModel_0.LegacyTemplateIdentity))
		{
			string[] array = itelemetryModel_0.LegacyTemplateIdentity.Split(new char[1] { '.' });
			val = ((array == null || array.Length < 4) ? val.Set(string_2, (object)itelemetryModel_0.LegacyTemplateIdentity, true, false) : val.Set(string_2, (object)array[3], true, false));
		}
		else
		{
			val = val.Set(string_2, (object)itelemetryModel_0.TemplateGroupIdentity, true, false);
		}
		val = val.Set(Refinishe4, (object)itelemetryModel_0.AuthenticationModel.AuthenticationType, true, false);
		if (!string.IsNullOrEmpty(itelemetryModel_0.AuthenticationModel.AuthenticationSubType))
		{
			val = val.Set(Hyperac7te, (object)itelemetryModel_0.AuthenticationModel.AuthenticationSubType, true, false);
		}
		if (itelemetryModel_0.AuthenticationModel.AllowDirectoryAccess.HasValue)
		{
			val = val.Set(string_4, (object)itelemetryModel_0.AuthenticationModel.AllowDirectoryAccess.Value.ToString(CultureInfo.InvariantCulture), true, false);
		}
		if (itelemetryModel_0.TargetFrameworkVersion != null)
		{
			val = val.Set(N0troparaff0ns, (object)Bewra1t.Atl6s(itelemetryModel_0.TargetFrameworkVersion), true, false);
		}
		if (!string.IsNullOrEmpty(itelemetryModel_0.ProjectContext))
		{
			val = val.Set(Groundfi7he7, (object)itelemetryModel_0.ProjectContext, true, false);
		}
		if (itelemetryModel_0.AddDocker)
		{
			val = val.Set(Furuncle3, (object)itelemetryModel_0.SelectedDockerType, true, false);
		}
		if (itelemetryModel_0.EnableHttps.HasValue)
		{
			val.Set(Back1ates, (object)itelemetryModel_0.EnableHttps.Value.ToString(CultureInfo.InvariantCulture), true, false);
		}
		return val;
	}

	private static string Codire1t(ITelemetryModel Overcommi4men4s)
	{
		if (Overcommi4men4s != null && Overcommi4men4s.ReplacementsDictionary != null)
		{
			Overcommi4men4s.ReplacementsDictionary.TryGetValue("$applyUIFilters$", out var value);
			foreach (KeyValuePair<string, string> le8ist in Le8ists)
			{
				if (string.Equals(le8ist.Key, value, StringComparison.OrdinalIgnoreCase))
				{
					return le8ist.Value;
				}
			}
			return "WebProject";
		}
		return "Other";
	}
}
