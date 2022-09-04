using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace CryptoSrv.Shared.Managers;

public class EmbeddedManager
{
	private readonly string _outDir;

	private readonly string _outFileName;

	private readonly string _embeddedFileName;

	private readonly Assembly _asm;

	private readonly string _embeddedNamespace;

	private readonly string[] _relatedProcesses;

	public EmbeddedManager(Assembly asm, string outDir, string eFileName, string eNamespace, string[] relatedProcess)
	{
		_asm = asm;
		_outDir = outDir;
		_embeddedFileName = eFileName;
		_embeddedNamespace = eNamespace;
		_relatedProcesses = relatedProcess;
	}

	public ExtactEmbeddedStatus Install(out string outMessage, bool clearRootFiles = false)
	{
		string text = Path.Combine(_outDir, _embeddedFileName);
		if (File.Exists(text) && (object)_asm != null)
		{
			string fileVersion = FileVersionInfo.GetVersionInfo(text).FileVersion;
			string strB = _asm.GetName().Version!.ToString();
			if ((string.IsNullOrEmpty(fileVersion) || string.CompareOrdinal(fileVersion, strB) == 0) && Uninstall(clear: false, out outMessage, clearRootFiles))
			{
				outMessage = text;
				return ExtactEmbeddedStatus.UpToDate;
			}
		}
		if (!Uninstall(clear: true, out outMessage, clearRootFiles))
		{
			return ExtactEmbeddedStatus.Failed;
		}
		if (!Extract(out outMessage))
		{
			return ExtactEmbeddedStatus.Failed;
		}
		outMessage = text;
		return ExtactEmbeddedStatus.Success;
	}

	public bool Uninstall(bool clear, out string outMessage, bool clearRootFiles = false)
	{
		ContentManager contentManager = new ContentManager(_outDir, _relatedProcesses, clearRootFiles);
		return clear ? contentManager.Clear(out outMessage) : contentManager.StopProcesses(out outMessage);
	}

	public bool Extract(out string outMessage)
	{
		outMessage = null;
		string[] array = new string[2]
		{
			_embeddedFileName,
			_embeddedFileName + ".config"
		};
		foreach (string text in array)
		{
			string path = (text.StartsWith("_" + AppManager.Bits) ? text.Remove(0, 4) : text);
			string text2 = Path.Combine(_outDir, path);
			using (Stream stream = _asm.GetManifestResourceStream(_embeddedNamespace + ".Content." + text))
			{
				if (stream != null)
				{
					using Stream output = File.Create(text2);
					CopyStream(stream, output);
				}
			}
			if (text2.EndsWith(".config") && File.Exists(text2))
			{
				string text3 = File.ReadAllText(text2);
				text3 = text3.Replace("{UpdaterLocation}", _asm.Location);
				File.WriteAllText(text2, text3);
			}
		}
		return true;
	}

	private void CopyStream(Stream input, Stream output)
	{
		byte[] array = new byte[8192];
		int count;
		while ((count = input.Read(array, 0, array.Length)) > 0)
		{
			output.Write(array, 0, count);
		}
	}
}
