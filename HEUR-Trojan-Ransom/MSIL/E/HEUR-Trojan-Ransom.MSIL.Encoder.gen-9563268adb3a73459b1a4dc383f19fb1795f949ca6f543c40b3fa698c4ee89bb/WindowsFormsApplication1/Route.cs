namespace WindowsFormsApplication1;

public class Route
{
	public string name { get; set; }

	public string path { get; set; }

	public string hash { get; set; }

	public Query query { get; set; }

	public Params @params { get; set; }

	public string fullPath { get; set; }

	public Meta meta { get; set; }

	public From from { get; set; }
}
