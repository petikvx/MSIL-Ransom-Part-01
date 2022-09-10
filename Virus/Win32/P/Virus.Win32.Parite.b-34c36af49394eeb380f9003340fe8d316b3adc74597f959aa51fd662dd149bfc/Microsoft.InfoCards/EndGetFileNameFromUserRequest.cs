using System;
using System.IO;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class EndGetFileNameFromUserRequest : UIAgentAsyncEndRequest
{
	public EndGetFileNameFromUserRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnMarshalAsyncOutArgs(BinaryWriter writer)
	{
		GetFileNameResult getFileNameResult = (GetFileNameResult)base.Result;
		InfoCardTrace.Assert(null != getFileNameResult, "The get file result cannot be null.", new object[0]);
		Utility.SerializeString(writer, getFileNameResult.FileName);
		Utility.SerializeBytes(writer, getFileNameResult.FileContent);
		writer.Flush();
	}
}
