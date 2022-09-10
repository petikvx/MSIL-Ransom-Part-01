using System;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class ImportRequest : ClientUIRequest
{
	private FileStream m_importFile;

	private string m_filename;

	public string ImportedFile => m_filename;

	public ImportRequest(Process callingProcess, WindowsIdentity callingIdentity, InfoCardUIAgent uiAgent, IntPtr rpcHandle, Stream inArgs, Stream outArgs)
		: base(callingProcess, callingIdentity, uiAgent, rpcHandle, inArgs, outArgs, InfoCardUIAgent.CallMode.Import, ExceptionList.AllNonFatal)
	{
	}

	protected override void OnMarshalInArgs()
	{
		BinaryReader reader = new InfoCardBinaryReader(base.InArgs, Encoding.Unicode);
		string text = Utility.DeserializeString(reader);
		if (!string.IsNullOrEmpty(text) && text.Length <= 259)
		{
			if (!Path.IsPathRooted(text))
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("InvalidImportFileName")));
			}
			try
			{
				m_filename = text;
				m_importFile = new FileStream(m_filename, FileMode.Open, FileAccess.Read, FileShare.Read);
				return;
			}
			catch (ArgumentException inner)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("CannotOpenImportFile"), inner));
			}
			catch (IOException inner2)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("CannotOpenImportFile"), inner2));
			}
			catch (NotSupportedException inner3)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("CannotOpenImportFile"), inner3));
			}
			catch (UnauthorizedAccessException inner4)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("CannotOpenImportFile"), inner4));
			}
		}
		throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("InvalidImportFileName")));
	}

	protected override void OnProcess()
	{
		StartAndWaitForUIAgent();
	}

	protected override void OnMarshalOutArgs()
	{
	}

	protected override void OnDisposeAsUser()
	{
		base.OnDisposeAsUser();
		if (m_importFile != null)
		{
			m_importFile.Dispose();
			m_importFile = null;
		}
	}

	protected override bool OnHandleException(Exception e, out int errorCode)
	{
		errorCode = 0;
		bool result = false;
		if (e is UserCancelledException)
		{
			errorCode = ((InfoCardBaseException)((e is UserCancelledException) ? e : null)).get_NativeHResult();
			result = true;
		}
		return result;
	}
}
