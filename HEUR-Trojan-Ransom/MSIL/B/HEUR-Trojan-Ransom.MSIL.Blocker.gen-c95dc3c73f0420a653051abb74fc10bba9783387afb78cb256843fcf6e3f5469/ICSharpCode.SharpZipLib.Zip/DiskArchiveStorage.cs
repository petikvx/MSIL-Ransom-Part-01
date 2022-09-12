using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip;

public class DiskArchiveStorage : BaseArchiveStorage
{
	private string FYbiDSnWyUrJyqHBLSLSTgeHMMch;

	private string FbdloxEduGRVLTGvlqiTusijGDOm;

	private Stream uYjeBJTxcoKdAVrxiAYCfuBeufuu;

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
		FYbiDSnWyUrJyqHBLSLSTgeHMMch = file.Name;
	}

	public override Stream ConvertTemporaryToFinal()
	{
		if (uYjeBJTxcoKdAVrxiAYCfuBeufuu == null)
		{
			throw new ZipException("No temporary stream has been created");
		}
		Stream stream = null;
		string text = vmWxHerFRupvORruQnTkncVBJiRc(FYbiDSnWyUrJyqHBLSLSTgeHMMch, makeTempFile: false);
		bool flag = false;
		try
		{
			uYjeBJTxcoKdAVrxiAYCfuBeufuu.Close();
			File.Move(FYbiDSnWyUrJyqHBLSLSTgeHMMch, text);
			File.Move(FbdloxEduGRVLTGvlqiTusijGDOm, FYbiDSnWyUrJyqHBLSLSTgeHMMch);
			flag = true;
			File.Delete(text);
			return File.OpenRead(FYbiDSnWyUrJyqHBLSLSTgeHMMch);
		}
		catch (Exception)
		{
			stream = null;
			if (!flag)
			{
				File.Move(text, FYbiDSnWyUrJyqHBLSLSTgeHMMch);
				File.Delete(FbdloxEduGRVLTGvlqiTusijGDOm);
			}
			throw;
		}
	}

	public override void Dispose()
	{
		if (uYjeBJTxcoKdAVrxiAYCfuBeufuu != null)
		{
			uYjeBJTxcoKdAVrxiAYCfuBeufuu.Close();
		}
	}

	private static string vmWxHerFRupvORruQnTkncVBJiRc(string original, bool makeTempFile)
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
		if (FbdloxEduGRVLTGvlqiTusijGDOm != null)
		{
			FbdloxEduGRVLTGvlqiTusijGDOm = vmWxHerFRupvORruQnTkncVBJiRc(FbdloxEduGRVLTGvlqiTusijGDOm, makeTempFile: true);
			uYjeBJTxcoKdAVrxiAYCfuBeufuu = File.OpenWrite(FbdloxEduGRVLTGvlqiTusijGDOm);
		}
		else
		{
			FbdloxEduGRVLTGvlqiTusijGDOm = Path.GetTempFileName();
			uYjeBJTxcoKdAVrxiAYCfuBeufuu = File.OpenWrite(FbdloxEduGRVLTGvlqiTusijGDOm);
		}
		return uYjeBJTxcoKdAVrxiAYCfuBeufuu;
	}

	public override Stream MakeTemporaryCopy(Stream stream)
	{
		stream.Close();
		FbdloxEduGRVLTGvlqiTusijGDOm = vmWxHerFRupvORruQnTkncVBJiRc(FYbiDSnWyUrJyqHBLSLSTgeHMMch, makeTempFile: true);
		File.Copy(FYbiDSnWyUrJyqHBLSLSTgeHMMch, FbdloxEduGRVLTGvlqiTusijGDOm, overwrite: true);
		uYjeBJTxcoKdAVrxiAYCfuBeufuu = new FileStream(FbdloxEduGRVLTGvlqiTusijGDOm, FileMode.Open, FileAccess.ReadWrite);
		return uYjeBJTxcoKdAVrxiAYCfuBeufuu;
	}

	public override Stream OpenForDirectUpdate(Stream stream)
	{
		if (stream != null && stream.CanWrite)
		{
			return stream;
		}
		stream?.Close();
		return new FileStream(FYbiDSnWyUrJyqHBLSLSTgeHMMch, FileMode.Open, FileAccess.ReadWrite);
	}
}
