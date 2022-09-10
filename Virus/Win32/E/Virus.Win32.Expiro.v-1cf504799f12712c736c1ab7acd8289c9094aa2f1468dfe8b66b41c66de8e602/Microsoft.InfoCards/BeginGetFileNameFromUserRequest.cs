using System;
using System.IO;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class BeginGetFileNameFromUserRequest : UIAgentAsyncBeginRequest
{
	private bool m_getContent;

	private string m_arguments;

	public BeginGetFileNameFromUserRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnMarshalAsyncInArgs(BinaryReader reader)
	{
		m_getContent = reader.ReadBoolean();
		m_arguments = Utility.DeserializeString(reader);
	}

	protected override object AsyncExecute(AsyncParams asyncParams)
	{
		uint num = 0u;
		string fileName = string.Empty;
		GetFileNameResult getFileNameResult = new GetFileNameResult();
		using (new SystemIdentity(throwIfAlreadySystem: true))
		{
			num = NativeMcppMethods.CreateAndWaitForFileOpenDialogWrapper(m_arguments, RequestorIdentity, base.ParentRequest.CallerPid, ref fileName);
		}
		if (num == 0)
		{
			try
			{
				getFileNameResult.FileName = fileName;
				if (!m_getContent)
				{
					return getFileNameResult;
				}
				if (!string.IsNullOrEmpty(fileName))
				{
					FileInfo fileInfo = new FileInfo(fileName);
					using FileStream stream = File.OpenRead(fileName);
					BinaryReader binaryReader = new InfoCardBinaryReader(stream);
					getFileNameResult.FileContent = binaryReader.ReadBytes((int)fileInfo.Length);
					return getFileNameResult;
				}
				return getFileNameResult;
			}
			catch (Exception ex)
			{
				if (InfoCardTrace.IsFatal(ex))
				{
					throw;
				}
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new FileAccessException(SR.GetString("ServiceInaccessibleFile"), ex));
			}
		}
		return getFileNameResult;
	}

	protected override void AsyncCancel()
	{
	}
}
