using System;
using System.IO;

namespace NuGet.Common;

public class ngzjYCc1Bu
{
	public static readonly string Q8Run3PSBq = "project.json";

	public static readonly string jD3bMtlrXQ = ".project.json";

	public static readonly string RmjZp8QvsM = "project.lock.json";

	public static string JJI4MVvyoE(string rhC80tQVQ9, string EjWC3y8iJg)
	{
		if (string.IsNullOrEmpty(EjWC3y8iJg))
		{
			throw new ArgumentException("projectName");
		}
		string text = Path.Combine(rhC80tQVQ9, WNfb8edXzN(EjWC3y8iJg));
		if (!File.Exists(text))
		{
			text = Path.Combine(rhC80tQVQ9, Q8Run3PSBq);
		}
		return text;
	}

	public static string WNfb8edXzN(string qyuHcktVEW)
	{
		if (string.IsNullOrEmpty(qyuHcktVEW))
		{
			throw new ArgumentException("projectName");
		}
		return qyuHcktVEW + "." + Q8Run3PSBq;
	}

	public static string cWlEe0bxfP(string _3bW03kmwAl)
	{
		if (string.IsNullOrEmpty(_3bW03kmwAl))
		{
			throw new ArgumentException("projectName");
		}
		return _3bW03kmwAl + "." + RmjZp8QvsM;
	}

	public static string W0tEnNxRG7(string IRR9kL79Ul)
	{
		string text = null;
		string directoryName = Path.GetDirectoryName(IRR9kL79Ul);
		string text2 = CKF4fTHqKD(IRR9kL79Ul);
		if (text2 == null)
		{
			return Path.Combine(directoryName, RmjZp8QvsM);
		}
		string path = cWlEe0bxfP(text2);
		return Path.Combine(directoryName, path);
	}

	public static string CKF4fTHqKD(string b8dSPNKGFp)
	{
		if (b8dSPNKGFp == null)
		{
			throw new ArgumentNullException("configPath");
		}
		string fileName = Path.GetFileName(b8dSPNKGFp);
		string result = null;
		if (fileName != null && fileName.EndsWith(jD3bMtlrXQ, StringComparison.OrdinalIgnoreCase))
		{
			int length = fileName.Length - Q8Run3PSBq.Length - 1;
			result = fileName.Substring(0, length);
		}
		return result;
	}

	public static bool Qb2qWlpBIx(string _0toiB8C0qj)
	{
		if (_0toiB8C0qj == null)
		{
			throw new ArgumentNullException("configPath");
		}
		if (_0toiB8C0qj.EndsWith(Q8Run3PSBq, StringComparison.OrdinalIgnoreCase))
		{
			string text = null;
			try
			{
				text = Path.GetFileName(_0toiB8C0qj);
			}
			catch
			{
				return false;
			}
			if (!string.Equals(Q8Run3PSBq, text, StringComparison.OrdinalIgnoreCase))
			{
				return text.EndsWith(jD3bMtlrXQ, StringComparison.OrdinalIgnoreCase);
			}
			return true;
		}
		return false;
	}
}
