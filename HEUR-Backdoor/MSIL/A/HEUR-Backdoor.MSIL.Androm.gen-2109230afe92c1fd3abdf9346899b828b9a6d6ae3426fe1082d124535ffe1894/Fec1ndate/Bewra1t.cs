using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.TemplateEngine.Shared;
using Microsoft.VisualStudio.TemplateEngine.VS;
using Quai7ter;
using Re5w5ke;
using Rosino7s;

namespace Fec1ndate;

internal class Bewra1t : ITelemetryModel
{
	private readonly IProjectCreationMetadata Aston5es;

	[CompilerGenerated]
	private readonly IVsHierarchy Eno8ogica8;

	[CompilerGenerated]
	private readonly IAuthenticationTelemetryModel A1u1a;

	public IVsHierarchy CreatedProjectHierarchy
	{
		[CompilerGenerated]
		get
		{
			return Eno8ogica8;
		}
	}

	public string ProjectLangauge => P5nkas(Aston5es.get_Language());

	public string LegacyTemplateIdentity => Polygon2m("LegacyTemplateIdentity");

	public bool AddUnitTestProject
	{
		get
		{
			if (!bool.TryParse(Polygon2m("AddUnitTestProject"), out var result))
			{
				return false;
			}
			return result;
		}
	}

	public string TargetFrameworkVersion => Subseque2tly("TargetFrameworkOverride") ?? Polygon2m("$targetframeworkversion$");

	public bool IncludeApplicationInsights
	{
		get
		{
			if (!bool.TryParse(Subseque2tly("IncludeApplicationInsights"), out var result))
			{
				return false;
			}
			return result;
		}
	}

	public bool AddDocker
	{
		get
		{
			if (!bool.TryParse(Subseque2tly("AddDocker"), out var result))
			{
				return false;
			}
			return result;
		}
	}

	public string SelectedDockerType => Subseque2tly("SelectedDockerType");

	public string ProjectContext
	{
		get
		{
			if (!Aston5es.get_CreationParameters().ContainsKey("TargetFrameworkOverride"))
			{
				return "WebCore";
			}
			return "WebCoreFullFramework";
		}
	}

	public string PlatformVersion
	{
		get
		{
			FrameworkName frameworkName = NetCoreMonikerHelper.ConvertTemplateTfmToFrameworkName(Subseque2tly("Framework") ?? string.Empty);
			object obj;
			if ((object)frameworkName == null)
			{
				obj = null;
			}
			else
			{
				Version version = frameworkName.Version;
				if ((object)version == null)
				{
					obj = null;
				}
				else
				{
					obj = version.ToString();
					if (obj != null)
					{
						goto IL_003a;
					}
				}
			}
			obj = string.Empty;
			goto IL_003a;
			IL_003a:
			return (string)obj;
		}
	}

	public IDictionary<string, string> ReplacementsDictionary => Aston5es.get_WizardParameters();

	public string TemplateGroupIdentity
	{
		get
		{
			if (!IsMicrosoftTemplate)
			{
				return Atl6s(Aston5es.get_GroupIdentity());
			}
			return Aston5es.get_GroupIdentity();
		}
	}

	public string TemplateIdentity
	{
		get
		{
			if (!IsMicrosoftTemplate)
			{
				return Atl6s(Aston5es.get_TemplateIdentity());
			}
			return Aston5es.get_TemplateIdentity();
		}
	}

	public string UIStyle => Aston5es.get_UIStyle();

	public string UIHost => Aston5es.get_UIHost();

	public bool IsMicrosoftTemplate
	{
		get
		{
			if (Aston5es.get_WizardParameters().TryGetValue("TemplateAuthor", out var value) && !string.IsNullOrEmpty(value))
			{
				return string.Equals(value, "Microsoft", StringComparison.OrdinalIgnoreCase);
			}
			return false;
		}
	}

	public string TemplateSource
	{
		get
		{
			if (!Aston5es.get_WizardParameters().TryGetValue("TemplateSource", out var value))
			{
				return null;
			}
			if (!IsMicrosoftTemplate)
			{
				return Atl6s(value);
			}
			return value;
		}
	}

	public IAuthenticationTelemetryModel AuthenticationModel
	{
		[CompilerGenerated]
		get
		{
			return A1u1a;
		}
	}

	public bool? EnableHttps
	{
		get
		{
			bool? result = null;
			if (bool.TryParse(Polygon2m("EnableHttps"), out var result2))
			{
				result = result2;
			}
			return result;
		}
	}

	public bool IsDotNet
	{
		get
		{
			if (!bool.TryParse(Polygon2m("IsDotNet"), out var result))
			{
				return false;
			}
			return result;
		}
	}

	public Bewra1t(IProjectCreationMetadata creationMetadata, IVsHierarchy projectHier)
	{
		Aston5es = creationMetadata;
		Eno8ogica8 = projectHier;
		A1u1a = new Se1terce1(Aston5es);
	}

	private string P5nkas(string Reweldin4)
	{
		return Reweldin4.ToUpperInvariant() switch
		{
			"VB" => "VisualBasic", 
			"C#" => "CSharp", 
			_ => Reweldin4, 
		};
	}

	private string Polygon2m([CallerMemberName] string Sympath5lytics = null)
	{
		if (!Aston5es.get_WizardParameters().TryGetValue(Sympath5lytics, out var value))
		{
			return null;
		}
		return value;
	}

	private string Subseque2tly([CallerMemberName] string string_0 = null)
	{
		if (!Aston5es.get_CreationParameters().TryGetValue(string_0, out var value))
		{
			return null;
		}
		return value;
	}

	internal static string Atl6s(string Equalise3)
	{
		return Up3raids(SHA256.Create(), Equalise3);
	}

	private static string Up3raids(SHA256 Al2yls, string Mosslik6)
	{
		if (Mosslik6 == null)
		{
			return null;
		}
		byte[] bytes = Encoding.UTF8.GetBytes(Mosslik6);
		byte[] array = Al2yls.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.AppendFormat("{0:x2}", b);
		}
		return stringBuilder.ToString();
	}
}
