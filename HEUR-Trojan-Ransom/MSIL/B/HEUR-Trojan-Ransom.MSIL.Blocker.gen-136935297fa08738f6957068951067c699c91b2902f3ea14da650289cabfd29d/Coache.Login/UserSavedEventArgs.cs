using System;
using Coache.Common;

namespace Coache.Login;

public class UserSavedEventArgs : EventArgs
{
	public string Username { get; set; }

	public string Password { get; set; }

	public User User { get; set; }
}
