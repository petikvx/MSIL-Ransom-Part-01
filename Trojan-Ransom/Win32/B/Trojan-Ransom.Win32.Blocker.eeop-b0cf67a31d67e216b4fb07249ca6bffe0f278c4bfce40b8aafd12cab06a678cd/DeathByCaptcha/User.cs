using System;
using System.Collections;
using e9a0jRW7WM0ZtAYBQW;

namespace DeathByCaptcha;

public class User
{
	protected double _balance;

	protected int _id;

	protected bool _banned;

	public int Id
	{
		get
		{
			return _id;
		}
		set
		{
			_id = Math.Max(0, value);
			_balance = 0.0;
			_banned = false;
		}
	}

	public bool LoggedIn => 0 < _id;

	public double Balance => _balance;

	public bool Banned
	{
		get
		{
			if (LoggedIn)
			{
				return _banned;
			}
			return false;
		}
	}

	public User()
	{
		eZTsNS9ebAJySZpK7R.eLHe04W3E();
		base._002Ector();
	}

	public User(Hashtable src)
	{
		eZTsNS9ebAJySZpK7R.eLHe04W3E();
		this._002Ector();
		if (src == null || !src.ContainsKey("user"))
		{
			return;
		}
		try
		{
			Id = Convert.ToInt32(src["user"]);
		}
		catch (System.Exception)
		{
		}
		if (LoggedIn)
		{
			try
			{
				_balance = Convert.ToDouble(src["balance"]);
			}
			catch (System.Exception)
			{
			}
			try
			{
				_banned = Convert.ToBoolean(src["is_banned"]);
			}
			catch (System.Exception)
			{
			}
		}
	}

	public int ToInt()
	{
		return _id;
	}

	public bool ToBoolean()
	{
		if (LoggedIn)
		{
			return !Banned;
		}
		return false;
	}
}
