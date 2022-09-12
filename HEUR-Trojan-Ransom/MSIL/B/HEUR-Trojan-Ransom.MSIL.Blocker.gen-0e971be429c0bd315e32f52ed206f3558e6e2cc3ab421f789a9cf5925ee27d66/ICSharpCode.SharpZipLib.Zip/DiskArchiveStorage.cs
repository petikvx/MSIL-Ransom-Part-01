using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip;

public class DiskArchiveStorage : BaseArchiveStorage
{
	private string AQdrYhBdoxdXeDDoOKHlGrpWwbjfA;

	private string GVhwPOcomdQjNuMWqrnaWzngfnDS;

	private Stream dittwazhgNePIuLUjJFnRKMjeSheA;

	public DiskArchiveStorage(ZipFile file)
		: this(file, FileUpdateMode.Safe)
	{
	}

	public DiskArchiveStorage(ZipFile file, FileUpdateMode updateMode)
		: base(updateMode)
	{
		if (file.Name == null)
		{
			throw new ZipException("Cant handle non file archives");
		}
		AQdrYhBdoxdXeDDoOKHlGrpWwbjfA = file.Name;
	}

	public override Stream ConvertTemporaryToFinal()
	{
		if (dittwazhgNePIuLUjJFnRKMjeSheA == null)
		{
			throw new ZipException("No temporary stream has been created");
		}
		Stream stream = null;
		string text = iaIBXLABFJDFIFkUHVqLEHxRUqfwb(AQdrYhBdoxdXeDDoOKHlGrpWwbjfA, makeTempFile: false);
		bool flag = false;
		try
		{
			dittwazhgNePIuLUjJFnRKMjeSheA.Close();
			File.Move(AQdrYhBdoxdXeDDoOKHlGrpWwbjfA, text);
			File.Move(GVhwPOcomdQjNuMWqrnaWzngfnDS, AQdrYhBdoxdXeDDoOKHlGrpWwbjfA);
			flag = true;
			File.Delete(text);
			return File.OpenRead(AQdrYhBdoxdXeDDoOKHlGrpWwbjfA);
		}
		catch (Exception)
		{
			stream = null;
			if (!flag)
			{
				File.Move(text, AQdrYhBdoxdXeDDoOKHlGrpWwbjfA);
				File.Delete(GVhwPOcomdQjNuMWqrnaWzngfnDS);
			}
			throw;
		}
	}

	public override void Dispose()
	{
		if (dittwazhgNePIuLUjJFnRKMjeSheA != null)
		{
			dittwazhgNePIuLUjJFnRKMjeSheA.Close();
		}
	}

	private static string iaIBXLABFJDFIFkUHVqLEHxRUqfwb(string original, bool makeTempFile)
	{
		string text = null;
		if (original == null)
		{
			return Path.GetTempFileName();
		}
		int num = 0;
		int second = DateTime.Now.Second;
		while (text == null)
		{
			num++;
			string text2 = $"{original}.{second}{num}.tmp";
			if (File.Exists(text2))
			{
				continue;
			}
			if (makeTempFile)
			{
				try
				{
					using (File.Create(text2))
					{
					}
					text = text2;
				}
				catch
				{
					second = DateTime.Now.Second;
				}
			}
			else
			{
				text = text2;
			}
		}
		return text;
	}

	public override Stream GetTemporaryOutput()
	{
		if (GVhwPOcomdQjNuMWqrnaWzngfnDS == null)
		{
			GVhwPOcomdQjNuMWqrnaWzngfnDS = Path.GetTempFileName();
			dittwazhgNePIuLUjJFnRKMjeSheA = File.OpenWrite(GVhwPOcomdQjNuMWqrnaWzngfnDS);
		}
		else
		{
			GVhwPOcomdQjNuMWqrnaWzngfnDS = iaIBXLABFJDFIFkUHVqLEHxRUqfwb(GVhwPOcomdQjNuMWqrnaWzngfnDS, makeTempFile: true);
			dittwazhgNePIuLUjJFnRKMjeSheA = File.OpenWrite(GVhwPOcomdQjNuMWqrnaWzngfnDS);
		}
		return dittwazhgNePIuLUjJFnRKMjeSheA;
	}

	public override Stream MakeTemporaryCopy(Stream stream)
	{
		stream.Close();
		GVhwPOcomdQjNuMWqrnaWzngfnDS = iaIBXLABFJDFIFkUHVqLEHxRUqfwb(AQdrYhBdoxdXeDDoOKHlGrpWwbjfA, makeTempFile: true);
		File.Copy(AQdrYhBdoxdXeDDoOKHlGrpWwbjfA, GVhwPOcomdQjNuMWqrnaWzngfnDS, overwrite: true);
		dittwazhgNePIuLUjJFnRKMjeSheA = new FileStream(GVhwPOcomdQjNuMWqrnaWzngfnDS, FileMode.Open, FileAccess.ReadWrite);
		return dittwazhgNePIuLUjJFnRKMjeSheA;
	}

	public override Stream OpenForDirectUpdate(Stream stream)
	{
		if (stream != null && stream.CanWrite)
		{
			return stream;
		}
		stream?.Close();
		return new FileStream(AQdrYhBdoxdXeDDoOKHlGrpWwbjfA, FileMode.Open, FileAccess.ReadWrite);
	}
}
