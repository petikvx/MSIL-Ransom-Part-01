using System;

namespace PinBot;

public interface IWebSite
{
	bool IsFollowMaxReached { get; }

	string UserAgent { get; set; }

	string CaptchaType { set; }

	string DBCUserName { set; }

	string DBCPassword { set; }

	string WebName { get; }

	string WebID { get; }

	string ProfileLike { get; }

	string FeedUrl { get; }

	DateTime NextPostTime { set; }

	ResponseType Login(string username, string password);

	ResponseType BookMark(string url, string title, string desc, string tags, ref string msg, string captchaUser, string captchaPass);
}
