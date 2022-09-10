using System;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Policy;

namespace Microsoft.Tools.Caspol;

internal class CaspolAssembly : MarshalByRefObject
{
	private bool error;

	private Assembly asm;

	public bool Error => error;

	public Evidence Evidence
	{
		get
		{
			if ((object)asm == null)
			{
				return null;
			}
			return asm.get_Evidence();
		}
	}

	public CaspolAssembly(string fileName)
	{
		try
		{
			asm = Assembly.Load(fileName);
		}
		catch (Exception)
		{
		}
		if ((object)asm != null)
		{
			return;
		}
		try
		{
			asm = Assembly.LoadFrom(fileName);
		}
		catch (Exception)
		{
		}
		if ((object)asm == null)
		{
			try
			{
				asm = Assembly.LoadFrom(Environment.CurrentDirectory + "\\" + fileName);
			}
			catch (Exception)
			{
			}
			if ((object)asm == null)
			{
				error = true;
			}
		}
	}

	public byte[] GenerateHash(string hashAlg)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return new Hash(asm).GenerateHash(HashAlgorithm.Create(hashAlg));
	}
}
