using System;
using System.Collections.Generic;
using System.Linq;

namespace Complex;

internal class Options
{
	public class Arguments
	{
		public bool help = false;

		public bool stealth = false;

		public bool validate = false;

		public bool verbose = false;

		public int threads = 25;

		public List<string> filter = new List<string> { "SYSVOL", "NETLOGON", "IPC$", "PRINT$" };

		public string dc = null;

		public string domain = null;

		public string ldap = null;

		public string ou = null;

		public string outfile = null;

		public string targets = null;
	}

	public static Dictionary<string, string[]> ParseArgs(string[] args)
	{
		Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>();
		string[] array = new string[3] { "/stealth", "/validate", "/verbose" };
		List<string> list = new List<string>();
		foreach (string text in args)
		{
			string[] array2 = text.Split(":".ToCharArray(), 2);
			list.Add(array2[0]);
			if (array2.Length == 1)
			{
				dictionary[array2[0]] = new string[1] { "true" };
			}
			if (array2.Length == 2)
			{
				dictionary[array2[0]] = new string[1] { array2[1] };
			}
		}
		return dictionary;
	}

	public static Arguments ArgumentValues(Dictionary<string, string[]> parsedArgs)
	{
		Arguments arguments = new Arguments();
		if (parsedArgs.ContainsKey("/dc"))
		{
			arguments.dc = parsedArgs["/dc"][0];
		}
		if (parsedArgs.ContainsKey("/domain"))
		{
			arguments.domain = parsedArgs["/domain"][0];
		}
		if (parsedArgs.ContainsKey("/filter"))
		{
			arguments.filter = parsedArgs["/filter"][0].ToUpper().Split(new char[1] { ',' }).ToList();
		}
		if (parsedArgs.ContainsKey("/ldap"))
		{
			arguments.ldap = parsedArgs["/ldap"][0];
		}
		if (parsedArgs.ContainsKey("/ou"))
		{
			arguments.ou = parsedArgs["/ou"][0];
		}
		if (parsedArgs.ContainsKey("/outfile"))
		{
			arguments.outfile = parsedArgs["/outfile"][0];
		}
		if (parsedArgs.ContainsKey("/stealth"))
		{
			arguments.stealth = Convert.ToBoolean(parsedArgs["/stealth"][0]);
		}
		if (parsedArgs.ContainsKey("/targets"))
		{
			arguments.targets = parsedArgs["/targets"][0];
		}
		if (parsedArgs.ContainsKey("/threads"))
		{
			arguments.threads = Convert.ToInt32(parsedArgs["/threads"][0]);
		}
		if (parsedArgs.ContainsKey("/validate"))
		{
			arguments.validate = Convert.ToBoolean(parsedArgs["/validate"][0]);
		}
		if (parsedArgs.ContainsKey("/verbose"))
		{
			arguments.verbose = Convert.ToBoolean(parsedArgs["/verbose"][0]);
		}
		if (parsedArgs.ContainsKey("help"))
		{
			Usage();
			arguments = null;
		}
		if (!parsedArgs.ContainsKey("/ldap") && !parsedArgs.ContainsKey("/ou"))
		{
			Console.WriteLine("[!] Must specify hosts using one of the following arguments: /ldap /ou");
			Usage();
			arguments = null;
		}
		return arguments;
	}

	public static bool PrintOptions(Arguments arguments)
	{
		return true;
	}

	public static void Usage()
	{
	}
}
