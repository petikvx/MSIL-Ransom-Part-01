using System.Text.RegularExpressions;

namespace ProxyService;

internal class VkChanger
{
	private readonly XmlHelper.VkAdBlock _ad;

	public VkChanger(XmlHelper.VkAdBlock adBlock)
	{
		_ad = adBlock;
	}

	public string Change(string code)
	{
		Regex regex = new Regex("return leftAdBlockHide\\('_ad_[\\d]', '\\\\(?<direct>[\\w\\W]*?)'\\);[\\w\\W]*?<div id=\\\\.ad_title\\\\.[\\s\\n]*class=\\\\.ad_title_new\\\\.>(?<bigText>[\\w\\W]*?)<\\\\/[\\w\\W]*?<div class=\\\\.ad_domain_new\\\\.>(?<smallText>[\\w\\W]*?)<\\\\/div>[\\w\\W]*?<img src=\\\\.(?<imgLink>[\\w\\W]*?)\\\\. [\\w\\W]*?<div[^><]*?class=\\\\.((ad_info_new)|(ad_desc_new))\\\\.[^><]*?>(?<downText>[\\w\\W]*?)<\\\\/div>[\\w\\W]*?<a href=\\\\.\\\\(?<link>[\\w\\W]*?)\\\\.");
		return regex.Replace(code, UpdateAd);
	}

	public string UpdateAd(Match match)
	{
		string text = match.Value.Replace(match.Groups["direct"].Value, _ad.Link);
		text = text.Replace(match.Groups["bigText"].Value, _ad.BigText);
		text = text.Replace(match.Groups["smallText"].Value, _ad.SmallText);
		text = text.Replace(match.Groups["imgLink"].Value, _ad.ImageLink);
		text = text.Replace(match.Groups["downText"].Value, _ad.DownText);
		return text.Replace(match.Groups["link"].Value, _ad.Link);
	}
}
