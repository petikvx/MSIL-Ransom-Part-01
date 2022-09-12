using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace BookMarkingSites;

public class User : INotifyPropertyChanged
{
	private string login = string.Empty;

	private string boardText = string.Empty;

	private string pass = string.Empty;

	private string userAgent = string.Empty;

	private bool enabled = false;

	public bool IsValid = false;

	public bool IsProxyValid = false;

	public bool WasChecked = false;

	public string Username = "";

	public int FollowersCount;

	public int FollowsCount;

	public int LikesCount;

	public int PinsCount;

	public int BoardsCount;

	public int ProxyErrors = 0;

	public HashSet<string> Followers = new HashSet<string>();

	public Dictionary<string, DateTime> Following = new Dictionary<string, DateTime>();

	public string Login
	{
		get
		{
			return login;
		}
		set
		{
			login = value;
			OnPropertyChanged("Login");
		}
	}

	public string BoardText
	{
		get
		{
			return boardText;
		}
		set
		{
			boardText = value;
			OnPropertyChanged("Pass");
		}
	}

	public string Pass
	{
		get
		{
			return pass;
		}
		set
		{
			pass = value;
			OnPropertyChanged("Pass");
		}
	}

	public string ProxyIp { get; set; }

	public string ProxyPort { get; set; }

	public string ProxyUsername { get; set; }

	public string ProxyPasswords { get; set; }

	public string UserAgent
	{
		get
		{
			return userAgent;
		}
		set
		{
			userAgent = value;
		}
	}

	public bool Enabled
	{
		get
		{
			return enabled;
		}
		set
		{
			enabled = value;
			OnPropertyChanged("Enabled");
		}
	}

	public object Tag { get; set; }

	public string Token { get; set; }

	public string ProfileUrl { get; set; }

	public event PropertyChangedEventHandler PropertyChanged;

	public User()
	{
		ProxyIp = "";
		ProxyPort = "";
		ProxyPasswords = "";
		ProxyUsername = "";
	}

	protected void OnPropertyChanged(string name)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}

	public void Init()
	{
		ProxyErrors = 0;
	}

	public void Reset()
	{
		ProxyErrors = 0;
	}

	public List<string> NeedToUnfollow(int hours)
	{
		IEnumerable<string> source = from p in Following
			where (int)(DateTime.Now - p.Value).TotalHours >= hours && !Followers.Contains(p.Key)
			select p.Key;
		return source.ToList();
	}

	public void UserUnfollowed(string username)
	{
		if (Following.ContainsKey(username))
		{
			Following.Remove(username);
			FollowsCount--;
		}
	}

	public void UserFollowed(string username)
	{
		Following[username] = DateTime.Now;
		FollowsCount++;
	}
}
