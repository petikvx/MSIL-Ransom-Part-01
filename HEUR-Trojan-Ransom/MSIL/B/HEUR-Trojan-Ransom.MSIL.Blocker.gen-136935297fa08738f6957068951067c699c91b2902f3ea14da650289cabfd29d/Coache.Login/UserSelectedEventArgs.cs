using System;
using Coache.Common;

namespace Coache.Login;

public class UserSelectedEventArgs : EventArgs
{
	public User User { get; set; }
}
