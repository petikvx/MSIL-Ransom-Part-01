using System.Collections.Generic;
using Microsoft.VisualStudio.Shell.Interop;
using Re5w5ke;

namespace Quai7ter;

internal interface ITelemetryModel
{
	IVsHierarchy CreatedProjectHierarchy { get; }

	bool IsDotNet { get; }

	string ProjectLangauge { get; }

	string LegacyTemplateIdentity { get; }

	bool AddUnitTestProject { get; }

	string TargetFrameworkVersion { get; }

	bool IncludeApplicationInsights { get; }

	bool AddDocker { get; }

	string SelectedDockerType { get; }

	string ProjectContext { get; }

	string PlatformVersion { get; }

	IDictionary<string, string> ReplacementsDictionary { get; }

	string TemplateGroupIdentity { get; }

	string TemplateIdentity { get; }

	string UIStyle { get; }

	string UIHost { get; }

	IAuthenticationTelemetryModel AuthenticationModel { get; }

	string TemplateSource { get; }

	bool IsMicrosoftTemplate { get; }

	bool? EnableHttps { get; }
}
