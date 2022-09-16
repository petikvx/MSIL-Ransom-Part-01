using System.Collections.Generic;
using Microsoft.VisualStudio.TemplateEngine.VS;
using Re5w5ke;

namespace Rosino7s;

internal class Se1terce1 : IAuthenticationTelemetryModel
{
	private readonly IProjectCreationMetadata L2sente;

	private static readonly IDictionary<string, string> C1mprad1rs = new Dictionary<string, string>
	{
		{ "None", "NoAuth" },
		{ "Individual", "IndividualAuth" },
		{ "SingleOrg", "OrgAuth" },
		{ "MultiOrg", "OrgAuth" },
		{ "Windows", "Windows" }
	};

	private static readonly IDictionary<string, string> Approbatio1 = new Dictionary<string, string>
	{
		{ "SingleOrg", "Single" },
		{ "MultiOrg", "Multiple" }
	};

	public string AuthenticationType
	{
		get
		{
			if (!L2sente.get_CreationParameters().TryGetValue("auth", out var value))
			{
				return C1mprad1rs["None"];
			}
			if (!C1mprad1rs.TryGetValue(value, out var value2))
			{
				return value;
			}
			return value2;
		}
	}

	public string AuthenticationSubType
	{
		get
		{
			if (L2sente.get_CreationParameters().TryGetValue("auth", out var value) && Approbatio1.TryGetValue(value, out var value2))
			{
				return value2;
			}
			return string.Empty;
		}
	}

	public bool? AllowDirectoryAccess
	{
		get
		{
			if (L2sente.get_CreationParameters().TryGetValue("OrgReadAccess", out var value) && bool.TryParse(value, out var result))
			{
				return result;
			}
			return null;
		}
	}

	public Se1terce1(IProjectCreationMetadata creationMetadata)
	{
		L2sente = creationMetadata;
	}
}
