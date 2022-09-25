using System;
using System.IO;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace NitroRansomware;

internal class Logs
{
	private string save;

	private string filename;

	private string config;

	private int type;

	public Logs(string configType, int outType)
	{
		hHEYokUTtehNq5ji0d.LQgF529zBT6Ox();
		base._002Ector();
		save = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
		filename = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3846);
		config = configType;
		type = outType;
	}

	private void Write(string append, string message)
	{
		if (type == 1)
		{
			using (StreamWriter streamWriter = File.AppendText(save + filename))
			{
				string text = string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3868), DateTime.Now.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3892)), append);
				streamWriter.Write(text + message);
				streamWriter.Write(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3916));
				return;
			}
		}
		if (type == 0)
		{
			string text2 = string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3868), DateTime.Now.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3892)), append);
			Console.Write(text2 + message);
			Console.Write(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3916));
			return;
		}
		using (StreamWriter streamWriter2 = File.AppendText(save + filename))
		{
			string text3 = string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3868), DateTime.Now.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3892)), append);
			streamWriter2.Write(text3 + message);
			streamWriter2.Write(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3916));
		}
		string text4 = string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3868), DateTime.Now.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3892)), append);
		Console.Write(text4 + message);
		Console.Write(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3916));
	}

	public void Debug(string message)
	{
		if (config == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(234))
		{
			Write(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(234), message);
		}
	}

	public void Info(string message)
	{
		if (config == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(234))
		{
			Write(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3922), message);
		}
		else if (config == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3922))
		{
			Write(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3922), message);
		}
	}

	public void Warning(string message)
	{
		if (config != WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3934))
		{
			Write(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3948), message);
		}
	}

	public void Error(string message)
	{
		Write(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3934), message);
	}

	static Logs()
	{
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
