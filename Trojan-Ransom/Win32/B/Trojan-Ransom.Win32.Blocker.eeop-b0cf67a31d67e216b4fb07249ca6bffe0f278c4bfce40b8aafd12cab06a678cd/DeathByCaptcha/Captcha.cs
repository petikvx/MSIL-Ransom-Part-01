using System;
using System.Collections;
using e9a0jRW7WM0ZtAYBQW;

namespace DeathByCaptcha;

public class Captcha
{
	protected int _id;

	protected string _text;

	protected bool _correct;

	public int Id
	{
		get
		{
			return _id;
		}
		set
		{
			_id = Math.Max(0, value);
			_text = null;
			_correct = false;
		}
	}

	public bool Uploaded => 0 < _id;

	public string Text
	{
		get
		{
			return _text;
		}
		set
		{
			_text = ((value == null || value.Equals(string.Empty)) ? null : value);
		}
	}

	public bool Solved
	{
		get
		{
			if (Uploaded)
			{
				return null != _text;
			}
			return false;
		}
	}

	public bool Correct
	{
		get
		{
			if (Solved)
			{
				return _correct;
			}
			return false;
		}
	}

	public Captcha()
	{
		eZTsNS9ebAJySZpK7R.eLHe04W3E();
		base._002Ector();
		Id = 0;
	}

	public Captcha(Hashtable src)
	{
		eZTsNS9ebAJySZpK7R.eLHe04W3E();
		this._002Ector();
		if (src == null || !src.ContainsKey("captcha") || src["captcha"] == null)
		{
			return;
		}
		try
		{
			Id = Convert.ToInt32(src["captcha"]);
		}
		catch (System.Exception)
		{
		}
		if (!Uploaded)
		{
			return;
		}
		try
		{
			Text = (string)src["text"];
		}
		catch (System.Exception)
		{
		}
		if (Solved)
		{
			try
			{
				_correct = (bool)src["is_correct"];
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

	public override string ToString()
	{
		return _text;
	}

	public bool ToBoolean()
	{
		return Correct;
	}
}
