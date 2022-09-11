using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Web;

namespace DevDefined.OAuth.Framework;

[Serializable]
public class OAuthProblemReport
{
	public string AcceptableVersionTo { get; set; }

	public string AcceptableVersionFrom { get; set; }

	public List<string> ParametersRejected { get; set; }

	public List<string> ParametersAbsent { get; set; }

	public string ProblemAdvice { get; set; }

	public string Problem { get; set; }

	public DateTime? AcceptableTimeStampsTo { get; set; }

	public DateTime? AcceptableTimeStampsFrom { get; set; }

	public OAuthProblemReport()
	{
		ParametersRejected = new List<string>();
		ParametersAbsent = new List<string>();
	}

	public OAuthProblemReport(NameValueCollection parameters)
	{
		Problem = parameters["oauth_problem"];
		ProblemAdvice = parameters["oauth_problem_advice"];
		ParametersAbsent = (parameters.AllKeys.Any((string key) => key == "oauth_parameters_absent") ? ParseFormattedParameters(parameters["oauth_parameters_absent"]) : new List<string>());
		ParametersRejected = (parameters.AllKeys.Any((string key) => key == "oauth_parameters_rejected") ? ParseFormattedParameters(parameters["oauth_parameters_rejected"]) : new List<string>());
		if (parameters.AllKeys.Any((string key) => key == "oauth_acceptable_timestamps"))
		{
			string[] array = parameters["oauth_acceptable_timestamps"]!.Split(new char[1] { '-' });
			AcceptableTimeStampsFrom = DateTimeUtility.FromEpoch(Convert.ToInt64(array[0]));
			AcceptableTimeStampsTo = DateTimeUtility.FromEpoch(Convert.ToInt64(array[1]));
		}
		if (parameters.AllKeys.Any((string key) => key == "oauth_acceptable_versions"))
		{
			string[] array2 = parameters["oauth_acceptable_versions"]!.Split(new char[1] { '-' });
			AcceptableVersionFrom = array2[0];
			AcceptableVersionTo = array2[1];
		}
	}

	public OAuthProblemReport(string formattedReport)
		: this(HttpUtility.ParseQueryString(formattedReport))
	{
	}

	public override string ToString()
	{
		if (string.IsNullOrEmpty(Problem))
		{
			throw Error.CantBuildProblemReportWhenProblemEmpty();
		}
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["oauth_problem"] = Problem;
		if (!string.IsNullOrEmpty(ProblemAdvice))
		{
			nameValueCollection["oauth_problem_advice"] = ProblemAdvice.Replace("\r\n", "\n").Replace("\r", "\n");
		}
		if (ParametersAbsent.Count > 0)
		{
			nameValueCollection["oauth_parameters_absent"] = FormatParameterNames(ParametersAbsent);
		}
		if (ParametersRejected.Count > 0)
		{
			nameValueCollection["oauth_parameters_rejected"] = FormatParameterNames(ParametersRejected);
		}
		if (AcceptableTimeStampsFrom.HasValue && AcceptableTimeStampsTo.HasValue)
		{
			nameValueCollection["oauth_acceptable_timestamps"] = $"{AcceptableTimeStampsFrom.Value.Epoch()}-{AcceptableTimeStampsTo.Value.Epoch()}";
		}
		if (!string.IsNullOrEmpty(AcceptableVersionFrom) && !string.IsNullOrEmpty(AcceptableVersionTo))
		{
			nameValueCollection["oauth_acceptable_versions"] = $"{AcceptableVersionFrom}-{AcceptableVersionTo}";
		}
		return UriUtility.FormatQueryString(nameValueCollection);
	}

	private static string FormatParameterNames(IEnumerable<string> names)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (string name in names)
		{
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append("&");
			}
			stringBuilder.Append(UriUtility.UrlEncode(name));
		}
		return stringBuilder.ToString();
	}

	private static List<string> ParseFormattedParameters(string formattedList)
	{
		return formattedList.Split(new char[1] { '&' }, StringSplitOptions.RemoveEmptyEntries).ToList();
	}
}
