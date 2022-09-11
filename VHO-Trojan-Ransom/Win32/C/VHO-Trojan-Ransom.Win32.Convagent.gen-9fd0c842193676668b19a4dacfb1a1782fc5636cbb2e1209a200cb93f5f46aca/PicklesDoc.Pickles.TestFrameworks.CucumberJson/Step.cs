namespace PicklesDoc.Pickles.TestFrameworks.CucumberJson;

public class Step
{
	public string keyword { get; set; }

	public string name { get; set; }

	public int line { get; set; }

	public Match match { get; set; }

	public Result result { get; set; }
}
