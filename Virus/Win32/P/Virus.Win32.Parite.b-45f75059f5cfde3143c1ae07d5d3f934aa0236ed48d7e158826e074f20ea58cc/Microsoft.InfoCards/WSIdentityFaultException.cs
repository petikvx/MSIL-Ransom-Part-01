using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Xml;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class WSIdentityFaultException : InfoCardBaseException
{
	private const int HRESULT = -1073413871;

	public static void ThrowIfFaultMessage(Message message, CultureInfo displayCulture)
	{
		if (!message.get_IsFault())
		{
			return;
		}
		MessageFault val = MessageFault.CreateFault(message, 2000000);
		FaultException val2 = FaultException.CreateFault(val, new Type[0]);
		string message2 = ((Exception)(object)val2).Message;
		string extendedMessage = string.Empty;
		if (val.get_Reason() != null)
		{
			FaultReasonText matchingTranslation = val.get_Reason().GetMatchingTranslation(displayCulture);
			if (matchingTranslation != null)
			{
				extendedMessage = matchingTranslation.get_Text();
			}
		}
		if (val.get_HasDetail())
		{
			using XmlReader xmlReader = val.GetReaderAtDetailContents();
			if (xmlReader.Read())
			{
				message2 = string.Format(CultureInfo.CurrentUICulture, SR.GetString("FaultMessageFormat"), new object[2]
				{
					((Exception)(object)val2).Message,
					xmlReader.ReadOuterXml()
				});
			}
		}
		throw InfoCardTrace.ThrowHelperErrorWithNoLogging((Exception)(object)new WSIdentityFaultException(message2, extendedMessage, (Exception)(object)val2));
	}

	public WSIdentityFaultException()
		: base(-1073413871)
	{
	}

	public WSIdentityFaultException(string message)
		: base(-1073413871, message)
	{
	}

	public WSIdentityFaultException(string message, string extendedMessage, Exception inner)
		: base(-1073413871, message, extendedMessage)
	{
		if (inner is FaultException)
		{
			MapFaultException((FaultException)(object)((inner is FaultException) ? inner : null));
		}
	}

	protected WSIdentityFaultException(SerializationInfo si, StreamingContext sc)
		: base(-1073413871, si, sc)
	{
	}

	private void MapFaultException(FaultException fe)
	{
		if (fe != null && fe.get_Code() != null && fe.get_Code().get_SubCode() != null && fe.get_Code().get_SubCode().get_Namespace() == "http://schemas.xmlsoap.org/ws/2005/05/identity/fault")
		{
			switch (fe.get_Code().get_SubCode().get_Name())
			{
			case "FailedRequiredClaims":
				((Exception)this).HResult = -1073413756;
				break;
			case "UnknownInformationCardReference":
				((Exception)this).HResult = -1073413757;
				break;
			case "InvalidProofKey":
				((Exception)this).HResult = -1073413758;
				break;
			case "MissingAppliesTo":
				((Exception)this).HResult = -1073413759;
				break;
			case "InformationCardRefreshRequired":
				((Exception)this).HResult = -1073413760;
				break;
			}
		}
	}
}
