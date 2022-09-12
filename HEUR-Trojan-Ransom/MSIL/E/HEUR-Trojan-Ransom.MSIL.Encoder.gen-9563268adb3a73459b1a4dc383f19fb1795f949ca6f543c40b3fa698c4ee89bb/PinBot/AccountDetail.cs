using System.Collections.ObjectModel;

namespace PinBot;

public class AccountDetail
{
	public uint id { get; set; }

	public bool Checked { get; set; }

	public bool AccsChecked { get; set; }

	public string GroupName { get; set; }

	public string TestAccountStatus { get; set; }

	public string UserNameTemp { get; set; }

	public string Password { get; set; }

	public string TumblrUrl { get; set; }

	public string PageAuth { get; set; }

	public string TrustFlow { get; set; }

	public string Notes { get; set; }

	public string ProxyIP { get; set; }

	public string ProxyPort { get; set; }

	public string ProxyUsername { get; set; }

	public string ProxyPassword { get; set; }

	public string UserAgent { get; set; }

	public string Cookies { get; set; }

	public bool FollowChecked { get; set; }

	public bool UnfollowChecked { get; set; }

	public bool RetweetChecked { get; set; }

	public bool LikeChecked { get; set; }

	public bool ShortenUrlChecked { get; set; }

	public string ShortenUrl { get; set; }

	public string OldStartTime { get; set; }

	public string StartTime { get; set; }

	public string EndTime { get; set; }

	public string DateAdded { get; set; }

	public string PostsCount { get; set; }

	public string LikesCount { get; set; }

	public string FollowingCount { get; set; }

	public string FollowersCount { get; set; }

	public string BoardText { get; set; }

	public string AutoBoardText { get; set; }

	public ObservableCollection<string> ItemCollection { get; set; }

	public AccountDetail()
	{
		ItemCollection = new ObservableCollection<string>();
	}
}
