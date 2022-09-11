using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks.XUnit;

public class XUnitExampleSignatureBuilder
{
	private const int MaxExampleValueLength = 50;

	public Regex Build(ScenarioOutline scenarioOutline, string[] row)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string value = SpecFlowNameMapping.Build(((ScenarioBase)scenarioOutline).get_Name());
		stringBuilder.Append(value).Append("\\(");
		foreach (var item in row.Select((string v) => (v.Length <= 50) ? new
		{
			Value = v,
			Ellipsis = ""
		} : new
		{
			Value = v.Substring(0, 50),
			Ellipsis = "..."
		}))
		{
			stringBuilder.AppendFormat("(.*): \"{0}\"{1}, ", Regex.Escape(item.Value), item.Ellipsis);
		}
		stringBuilder.Remove(stringBuilder.Length - 2, 2);
		return new Regex(stringBuilder.ToString(), RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
	}
}
