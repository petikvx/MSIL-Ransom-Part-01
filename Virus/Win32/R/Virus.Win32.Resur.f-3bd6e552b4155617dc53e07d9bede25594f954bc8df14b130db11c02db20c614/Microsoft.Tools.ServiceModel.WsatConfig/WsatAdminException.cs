using System;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal class WsatAdminException : Exception
{
	private WsatAdminErrorCode errCode;

	internal WsatAdminErrorCode ErrorCode => errCode;

	internal WsatAdminException(WsatAdminErrorCode errCode, string errMessage)
		: base(errMessage)
	{
		this.errCode = errCode;
	}

	internal WsatAdminException(WsatAdminErrorCode errCode, string errMessage, Exception innerException)
		: base(errMessage, innerException)
	{
		this.errCode = errCode;
	}
}
