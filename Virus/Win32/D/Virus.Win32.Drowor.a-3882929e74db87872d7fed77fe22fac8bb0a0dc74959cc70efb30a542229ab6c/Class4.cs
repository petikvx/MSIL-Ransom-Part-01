using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

internal static class Class4
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new CropFinder2());
	}

	private static void smethod_0()
	{
		string input = "<div id=\"lmid1\"><div id=\"lmid2\"><div class=\"dname\"><h1><div class=\"ddb\">The First /;-))+([]</div><div class=\"ddb\">&nbsp;(4|-33)&nbsp;</div></h1>";
		string input2 = "<img src=\"diller\" id=\"gmm\"></table></div><div id=\"lmid1\"><div id=\"lmid2\"><h1>verlassenes Tal (129|-36)</h1><img src=\"img/un/m/w7.jpg\" id=\"resfeld\"><div id=\"pr\" class=\"map_details_right\"><p><div class=\"f10 b\">&nbsp;Einheiten:</div><table class=\"f10\"><img id=\"whatever\"";
		string input3 = "<div id=\"lmid1\"><div id=\"lmid2\"><div class=\"dname\"><h1><div class=\"ddb\">A&w%@.</div><div class=\"ddb\">&nbsp;(-3|0)&nbsp;</div></h1>";
		Regex regex = new Regex("<div class=\"ddb\">([\\w]*|[\\|]*|[\\s]*|[&#%@£$!-\\.\\)\\(\\/;:\\[\\]\\+]*)*</div>");
		Regex regex2 = new Regex("<div class=\"ddb\">([\\w]*|[\\|]*|[\\s]*|[\\s\\S]*)*\\</div>");
		Regex regex3 = new Regex("\\<div class=\"ddb\"\\>(\\w*|\\|*|\\s*)*");
		Regex regex4 = new Regex("<img src=[^>\\s\\S]*id=\"resfeld\">");
		Regex regex5 = new Regex("src=[\\s\\S]*[.jpg|.JPG]");
		regex.Match(input);
		Match match = regex2.Match(input);
		Match match2 = regex.Match(input3);
		regex3.Match(input3);
		Match match3 = regex4.Match(input2);
		_ = match2.Groups[0].Value;
		_ = match.Value;
		string value = match3.Value;
		regex5.Match(value);
	}
}
