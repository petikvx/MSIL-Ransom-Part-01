using System.Text.RegularExpressions;

namespace ProxyService;

internal class YaChanger
{
	private readonly XmlHelper.YaAdBlock _adRight;

	private readonly XmlHelper.YaAdBlock _adBlockTop;

	private string BuildRightAd()
	{
		return $"<div class=\"b-adv__line\"><div class=\"b-adv__title\"><a href=\"{_adRight.Direct}\" target=_blank>{_adRight.Titile}</a></div>{_adRight.Text}<div class=\"b-serp-url\"><span class = \"b-serp-url__item\">{_adRight.Link}</span><i class=\"b-wbr\"></i></div></div>";
	}

	private string BuildMainAd()
	{
		return $"\r\n                <div class=\"b-spec-adv__item b-serp-item\"><h2 class=\"b-serp-item__title\"><a class=\"b-serp-item__title-link\" href=\"{_adBlockTop.Link}\" target=\"_blank\"><span>{_adBlockTop.Titile}</span></a></h2><div class=\"b-serp-item__text\">{_adBlockTop.Text}</div><div class=\"b-serp-item__links\"><div class=\"b-serp-url\"><span class=\"b-serp-url__item\"{_adBlockTop.Link}</span></div></div></div><div class=\"b-spec-adv__item b-serp-item\"><h2 class=\"b-serp-item__title\"></div>\r\n            ";
	}

	public YaChanger(XmlHelper.YaAdBlock adRight, XmlHelper.YaAdBlock adTop)
	{
		_adRight = adRight;
		_adBlockTop = adTop;
	}

	public string ChangeRight(string code)
	{
		Regex regex = new Regex("<div class=.b-adv.>[\\s\\n]*<div class=.b-adv__head.>[\\w\\W]*?</div>[\\s\\n]*(?<adBlock>(<div class=.b-adv__line.>[\\s\\n]*?<div class=.b-adv__title.>[\\w\\W]*?</div>[\\n\\s]*</div>[\\n\\s]*</div>[\\s\\n]*</div>[\\s\\n]*)+)");
		return regex.Replace(code, Evaluator);
	}

	public string ChangeTop(string code)
	{
		string text = "<div class=\"b-spec-adv g-gap-vertical g-gap-horizontal\"><div class=\"b-spec-adv__list b-serp-list\">";
		string value = "</div></div><a class=\"b-link b-spec-adv__direct b-sprite\"";
		int num = code.IndexOf(text);
		int num2 = code.IndexOf(value);
		string text2 = "";
		return code.Substring(0, num + text.Length) + BuildMainAd() + code.Substring(num2, code.Length - num2);
	}

	private string Changer(Match match)
	{
		return match.Value.Replace(match.Groups["ad"].Value, BuildMainAd());
	}

	private string Evaluator(Match match)
	{
		return match.Value.Replace(match.Groups["adBlock"].Value, BuildRightAd());
	}
}
