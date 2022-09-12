using System;
using System.Text.RegularExpressions;

namespace Renci.SshNet;

public class ExpectAction
{
	public Regex Expect { get; private set; }

	public Action<string> Action { get; private set; }

	public ExpectAction(Regex expect, Action<string> action)
	{
		if (expect == null)
		{
			throw new ArgumentNullException("expect");
		}
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		Expect = expect;
		Action = action;
	}

	public ExpectAction(string expect, Action<string> action)
	{
		if (expect == null)
		{
			throw new ArgumentNullException("expect");
		}
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		Expect = new Regex(Regex.Escape(expect));
		Action = action;
	}
}
