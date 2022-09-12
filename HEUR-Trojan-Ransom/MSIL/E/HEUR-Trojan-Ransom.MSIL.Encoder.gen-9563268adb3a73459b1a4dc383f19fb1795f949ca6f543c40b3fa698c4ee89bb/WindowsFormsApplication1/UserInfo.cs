using System.Collections.Generic;

namespace WindowsFormsApplication1;

public class UserInfo
{
	public string dh { get; set; }

	public string uit { get; set; }

	public string uid { get; set; }

	public string em { get; set; }

	public string fn { get; set; }

	public List<object> roles { get; set; }

	public string ge { get; set; }

	public object inf_state { get; set; }

	public string id { get; set; }

	public string username { get; set; }

	public string full_name { get; set; }

	public string fb_user_id { get; set; }

	public CoverShot9 cover_shot { get; set; }

	public ProfileV2 profile_v2 { get; set; }

	public object ig_info { get; set; }

	public object yt_info { get; set; }

	public PnInfo pn_info { get; set; }

	public TmInfo tm_info { get; set; }

	public object tw_info { get; set; }

	public Settings settings { get; set; }
}
