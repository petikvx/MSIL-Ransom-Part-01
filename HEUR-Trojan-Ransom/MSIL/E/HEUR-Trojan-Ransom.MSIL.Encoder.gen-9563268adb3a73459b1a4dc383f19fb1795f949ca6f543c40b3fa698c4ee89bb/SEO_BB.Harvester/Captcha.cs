using System.Collections;
using System.Drawing;

namespace SEO_BB.Harvester;

public class Captcha
{
	public Image captchaImage { get; set; }

	public string captchaID { get; set; }

	public string captchaLang { get; set; }

	public string captchaCdata { get; set; }

	public string captchaClassInfo { get; set; }

	public string captchaClassicCaptchaId { get; set; }

	public string captchaVisualCaptchaId { get; set; }

	public string captchaAudioCaptchaId { get; set; }

	public string captchaView { get; set; }

	public Hashtable hash { get; set; }
}
