using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class RequestFactory
{
	private enum RequestName
	{
		CloseCryptoHandleRequest = 0,
		DecryptRequest = 1,
		EncryptRequest = 2,
		GenerateDerivedKeyRequest = 3,
		GetBrowserTokenRequest = 4,
		GetCryptoTransformRequest = 5,
		GetKeyedHashRequest = 6,
		GetTokenRequest = 7,
		HashCoreRequest = 8,
		HashFinalRequest = 9,
		ImportRequest = 10,
		ManageRequest = 11,
		SignHashRequest = 12,
		TransformBlockRequest = 13,
		TransformFinalBlockRequest = 14,
		VerifyHashRequest = 15,
		ClientRequestCount = 16,
		BeginCreateSecurityTokenRequest = 128,
		BeginSelectCardRequest = 129,
		CancelAsyncOperationRequest = 130,
		CreateCardRequest = 131,
		CheckStoreFileValidityRequest = 132,
		DeleteCardRequest = 133,
		DeleteStoreRequest = 134,
		EndCreateSecurityTokenRequest = 135,
		EndSelectCardRequest = 136,
		ExportFileRequest = 137,
		GetCertificateRequest = 138,
		GetImportedCardRequest = 139,
		GetImportFileNameRequest = 140,
		GetLedgerEntryForRecipientRequest = 141,
		GetLedgerRequest = 142,
		GetPolicyDetailsRequest = 143,
		GetRecipientListRequest = 144,
		GetRecipientRequest = 145,
		GetUserPreferenceRequest = 146,
		ImportFileRequest = 147,
		InfoCardListRequest = 148,
		ListCardsInFileRequest = 149,
		QueryStoreStatusRequest = 150,
		ResolvePPIDRequest = 151,
		SaveCardRequest = 152,
		SaveLedgerEntryRequest = 153,
		SaveRecipientRequest = 154,
		SendAgentStatusRequest = 155,
		SetUserPreferenceRequest = 156,
		UIEndRequest = 157,
		BeginGetFileNameFromUserRequest = 158,
		EndGetFileNameFromUserRequest = 159,
		ListDependantCardsRequest = 160,
		GetLastErrorDetailsRequest = 161,
		GetIsBrowserClientRequest = 162,
		SetUserLanguageRequest = 163,
		GetCardDetailsRequest = 164,
		UnlockCardRequest = 165,
		AgentRequestCount = 38
	}

	private const int MaxRequestBlobSize = 20971520;

	private static readonly RequestName[] s_uiClientRequests;

	private static object s_createRequestSync;

	private static Dictionary<string, RequestName> s_requestMap;

	private RequestFactory()
	{
	}

	static RequestFactory()
	{
		s_uiClientRequests = new RequestName[4]
		{
			RequestName.GetBrowserTokenRequest,
			RequestName.GetTokenRequest,
			RequestName.ImportRequest,
			RequestName.ManageRequest
		};
		s_createRequestSync = new object();
		s_requestMap = new Dictionary<string, RequestName>(54);
		s_requestMap["CloseCryptoHandleRequest"] = RequestName.CloseCryptoHandleRequest;
		s_requestMap["DecryptRequest"] = RequestName.DecryptRequest;
		s_requestMap["EncryptRequest"] = RequestName.EncryptRequest;
		s_requestMap["GenerateDerivedKeyRequest"] = RequestName.GenerateDerivedKeyRequest;
		s_requestMap["GetBrowserTokenRequest"] = RequestName.GetBrowserTokenRequest;
		s_requestMap["GetCryptoTransformRequest"] = RequestName.GetCryptoTransformRequest;
		s_requestMap["GetKeyedHashRequest"] = RequestName.GetKeyedHashRequest;
		s_requestMap["GetTokenRequest"] = RequestName.GetTokenRequest;
		s_requestMap["HashCoreRequest"] = RequestName.HashCoreRequest;
		s_requestMap["HashFinalRequest"] = RequestName.HashFinalRequest;
		s_requestMap["ImportRequest"] = RequestName.ImportRequest;
		s_requestMap["ManageRequest"] = RequestName.ManageRequest;
		s_requestMap["SignHashRequest"] = RequestName.SignHashRequest;
		s_requestMap["TransformBlockRequest"] = RequestName.TransformBlockRequest;
		s_requestMap["TransformFinalBlockRequest"] = RequestName.TransformFinalBlockRequest;
		s_requestMap["VerifyHashRequest"] = RequestName.VerifyHashRequest;
		s_requestMap["BeginCreateSecurityTokenRequest"] = RequestName.BeginCreateSecurityTokenRequest;
		s_requestMap["BeginSelectCardRequest"] = RequestName.BeginSelectCardRequest;
		s_requestMap["CancelAsyncOperationRequest"] = RequestName.CancelAsyncOperationRequest;
		s_requestMap["CheckStoreFileValidityRequest"] = RequestName.CheckStoreFileValidityRequest;
		s_requestMap["CreateCardRequest"] = RequestName.CreateCardRequest;
		s_requestMap["DeleteCardRequest"] = RequestName.DeleteCardRequest;
		s_requestMap["DeleteStoreRequest"] = RequestName.DeleteStoreRequest;
		s_requestMap["EndCreateSecurityTokenRequest"] = RequestName.EndCreateSecurityTokenRequest;
		s_requestMap["EndSelectCardRequest"] = RequestName.EndSelectCardRequest;
		s_requestMap["ExportFileRequest"] = RequestName.ExportFileRequest;
		s_requestMap["GetCertificateRequest"] = RequestName.GetCertificateRequest;
		s_requestMap["GetImportedCardRequest"] = RequestName.GetImportedCardRequest;
		s_requestMap["GetImportFileNameRequest"] = RequestName.GetImportFileNameRequest;
		s_requestMap["GetLedgerEntryForRecipientRequest"] = RequestName.GetLedgerEntryForRecipientRequest;
		s_requestMap["GetLedgerRequest"] = RequestName.GetLedgerRequest;
		s_requestMap["GetPolicyDetailsRequest"] = RequestName.GetPolicyDetailsRequest;
		s_requestMap["GetRecipientListRequest"] = RequestName.GetRecipientListRequest;
		s_requestMap["GetRecipientRequest"] = RequestName.GetRecipientRequest;
		s_requestMap["GetUserPreferenceRequest"] = RequestName.GetUserPreferenceRequest;
		s_requestMap["ImportFileRequest"] = RequestName.ImportFileRequest;
		s_requestMap["InfoCardListRequest"] = RequestName.InfoCardListRequest;
		s_requestMap["ListCardsInFileRequest"] = RequestName.ListCardsInFileRequest;
		s_requestMap["QueryStoreStatusRequest"] = RequestName.QueryStoreStatusRequest;
		s_requestMap["ResolvePPIDRequest"] = RequestName.ResolvePPIDRequest;
		s_requestMap["SaveCardRequest"] = RequestName.SaveCardRequest;
		s_requestMap["SaveLedgerEntryRequest"] = RequestName.SaveLedgerEntryRequest;
		s_requestMap["SaveRecipientRequest"] = RequestName.SaveRecipientRequest;
		s_requestMap["SendAgentStatusRequest"] = RequestName.SendAgentStatusRequest;
		s_requestMap["SetUserPreferenceRequest"] = RequestName.SetUserPreferenceRequest;
		s_requestMap["BeginGetFileNameFromUserRequest"] = RequestName.BeginGetFileNameFromUserRequest;
		s_requestMap["EndGetFileNameFromUserRequest"] = RequestName.EndGetFileNameFromUserRequest;
		s_requestMap["UIEndRequest"] = RequestName.UIEndRequest;
		s_requestMap["ListDependantCardsRequest"] = RequestName.ListDependantCardsRequest;
		s_requestMap["GetLastErrorDetailsRequest"] = RequestName.GetLastErrorDetailsRequest;
		s_requestMap["GetIsBrowserClientRequest"] = RequestName.GetIsBrowserClientRequest;
		s_requestMap["SetUserLanguageRequest"] = RequestName.SetUserLanguageRequest;
		s_requestMap["GetCardDetailsRequest"] = RequestName.GetCardDetailsRequest;
		s_requestMap["UnlockCardRequest"] = RequestName.UnlockCardRequest;
	}

	internal static int ProcessNewRequest(int parentRequestHandle, IntPtr rpcHandle, IntPtr inArgs, out IntPtr outArgs)
	{
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		InfoCardTrace.Assert(null == WindowsIdentity.GetCurrent(ifImpersonating: true), "unexpected user context on incoming thread", new object[0]);
		int num = 0;
		outArgs = IntPtr.Zero;
		if (IntPtr.Zero == inArgs)
		{
			return -1073413888;
		}
		if (IntPtr.Zero == rpcHandle)
		{
			return -1073413888;
		}
		try
		{
			RpcRequest rpcRequest = (RpcRequest)Marshal.PtrToStructure(inArgs, typeof(RpcRequest));
			if (rpcRequest.Length >= 0 && rpcRequest.Length <= 20971520 && rpcRequest.Type != null && (rpcRequest.Length <= 0 || !(IntPtr.Zero == rpcRequest.Data)))
			{
				Stream inStream;
				if (rpcRequest.Length != 0)
				{
					byte[] array = new byte[rpcRequest.Length];
					Marshal.Copy(rpcRequest.Data, array, 0, rpcRequest.Length);
					inStream = new MemoryStream(array, 0, array.Length, writable: false, publiclyVisible: false);
				}
				else
				{
					inStream = new MemoryStream();
				}
				MemoryStream memoryStream = new MemoryStream();
				string extendedMessage;
				RpcResponse outArgs2;
				if (parentRequestHandle == 0)
				{
					using (UIAgentMonitorHandle monitorHandle = new UIAgentMonitorHandle())
					{
						using ClientRequest clientRequest = CreateClientRequestInstance(monitorHandle, rpcRequest.Type, rpcHandle, inStream, memoryStream);
						num = clientRequest.DoProcessRequest(out extendedMessage);
						ConvertStreamToIntPtr(memoryStream, out outArgs2);
						outArgs = outArgs2.Marshal();
						return num;
					}
				}
				ClientUIRequest clientUIRequest = (ClientUIRequest)Request.FindRequestByHandle(parentRequestHandle);
				InfoCardTrace.Assert(null != clientUIRequest, "ParentRequest is null", new object[0]);
				using UIAgentRequest uIAgentRequest = CreateUIAgentRequestInstance(clientUIRequest, rpcRequest.Type, rpcHandle, inStream, memoryStream);
				num = uIAgentRequest.DoProcessRequest(out extendedMessage);
				if (num != 0)
				{
					BinaryWriter writer = new BinaryWriter(memoryStream, Encoding.Unicode);
					Utility.SerializeString(writer, extendedMessage);
				}
				ConvertStreamToIntPtr(memoryStream, out outArgs2);
				outArgs = outArgs2.Marshal();
				return num;
			}
			return -1073413888;
		}
		catch (TargetInvocationException ex)
		{
			if (ex.InnerException != null && ex.InnerException is InfoCardBaseException)
			{
				return ((InfoCardBaseException)ex.InnerException).get_NativeHResult();
			}
			InfoCardService.Crash(ex);
			return num;
		}
		catch (InfoCardBaseException val)
		{
			InfoCardBaseException val2 = val;
			return val2.get_NativeHResult();
		}
		catch (OutOfMemoryException)
		{
			return -2147024882;
		}
		catch (EndOfStreamException)
		{
			return -1073413863;
		}
		catch (Exception ex4)
		{
			InfoCardTrace.TraceAndLogException(ex4);
			InfoCardService.Crash(ex4);
			return num;
		}
	}

	private static void ConvertStreamToIntPtr(MemoryStream outStream, out RpcResponse outArgs)
	{
		byte[] buffer = outStream.GetBuffer();
		outArgs = default(RpcResponse);
		outArgs.Length = 0;
		outArgs.Data = IntPtr.Zero;
		if (buffer != null && buffer.Length != 0)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(buffer.Length);
			Marshal.Copy(buffer, 0, intPtr, buffer.Length);
			outArgs.Data = intPtr;
			outArgs.Length = buffer.Length;
		}
	}

	private static ClientRequest CreateClientRequestInstance(UIAgentMonitorHandle monitorHandle, string reqName, IntPtr rpcHandle, Stream inStream, Stream outStream)
	{
		ClientRequest clientRequest = null;
		lock (s_createRequestSync)
		{
			if (string.IsNullOrEmpty(reqName))
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException());
			}
			if (!s_requestMap.ContainsKey(reqName))
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException());
			}
			RequestName value = s_requestMap[reqName];
			if (-1 != Array.IndexOf(s_uiClientRequests, value))
			{
				Process contextMapping = ClientUIRequest.GetContextMapping(rpcHandle, clear: true);
				InfoCardTrace.ThrowInvalidArgumentConditional(null == contextMapping, "rpcHandle");
				int tSSession = 0;
				if (!NativeMethods.ProcessIdToSessionId(contextMapping.Id, out tSSession))
				{
					int lastWin32Error = Marshal.GetLastWin32Error();
					throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException(SR.GetString("ServiceErrorGettingClientTSSession"), new Win32Exception(lastWin32Error)));
				}
				WindowsIdentity windowsIdentity = NativeMcppMethods.CreateServiceExecutionIdentity(contextMapping);
				InfoCardUIAgent uiAgent = monitorHandle.CreateAgent(contextMapping.Id, windowsIdentity, tSSession);
				clientRequest = s_requestMap[reqName] switch
				{
					RequestName.GetTokenRequest => new GetTokenRequest(contextMapping, windowsIdentity, uiAgent, rpcHandle, inStream, outStream), 
					RequestName.ImportRequest => new ImportRequest(contextMapping, windowsIdentity, uiAgent, rpcHandle, inStream, outStream), 
					RequestName.ManageRequest => new ManageRequest(contextMapping, windowsIdentity, uiAgent, rpcHandle, inStream, outStream), 
					RequestName.GetBrowserTokenRequest => new GetBrowserTokenRequest(contextMapping, windowsIdentity, uiAgent, rpcHandle, inStream, outStream), 
					_ => throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException()), 
				};
			}
			else
			{
				Process callingProcessFromRpcHandle = ClientRequest.GetCallingProcessFromRpcHandle(rpcHandle);
				WindowsIdentity callingIdentity = NativeMcppMethods.CreateServiceExecutionIdentity(callingProcessFromRpcHandle);
				clientRequest = s_requestMap[reqName] switch
				{
					RequestName.CloseCryptoHandleRequest => new CloseCryptoHandleRequest(callingProcessFromRpcHandle, callingIdentity, rpcHandle, inStream, outStream), 
					RequestName.DecryptRequest => new DecryptRequest(callingProcessFromRpcHandle, callingIdentity, rpcHandle, inStream, outStream), 
					RequestName.EncryptRequest => new EncryptRequest(callingProcessFromRpcHandle, callingIdentity, rpcHandle, inStream, outStream), 
					RequestName.GenerateDerivedKeyRequest => new GenerateDerivedKeyRequest(callingProcessFromRpcHandle, callingIdentity, rpcHandle, inStream, outStream), 
					RequestName.GetCryptoTransformRequest => new GetCryptoTransformRequest(callingProcessFromRpcHandle, callingIdentity, rpcHandle, inStream, outStream), 
					RequestName.GetKeyedHashRequest => new GetKeyedHashRequest(callingProcessFromRpcHandle, callingIdentity, rpcHandle, inStream, outStream), 
					RequestName.HashCoreRequest => new HashCoreRequest(callingProcessFromRpcHandle, callingIdentity, rpcHandle, inStream, outStream), 
					RequestName.HashFinalRequest => new HashFinalRequest(callingProcessFromRpcHandle, callingIdentity, rpcHandle, inStream, outStream), 
					RequestName.SignHashRequest => new SignHashRequest(callingProcessFromRpcHandle, callingIdentity, rpcHandle, inStream, outStream), 
					RequestName.TransformBlockRequest => new TransformBlockRequest(callingProcessFromRpcHandle, callingIdentity, rpcHandle, inStream, outStream), 
					RequestName.TransformFinalBlockRequest => new TransformFinalBlockRequest(callingProcessFromRpcHandle, callingIdentity, rpcHandle, inStream, outStream), 
					RequestName.VerifyHashRequest => new VerifyHashRequest(callingProcessFromRpcHandle, callingIdentity, rpcHandle, inStream, outStream), 
					_ => throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException()), 
				};
			}
			clientRequest.Initialize();
			return clientRequest;
		}
	}

	private static UIAgentRequest CreateUIAgentRequestInstance(ClientUIRequest parentRequest, string reqName, IntPtr rpcHandle, Stream inStream, Stream outStream)
	{
		UIAgentRequest uIAgentRequest = null;
		lock (s_createRequestSync)
		{
			InfoCardTrace.Assert(!string.IsNullOrEmpty(reqName), "Null or empty request name", new object[0]);
			InfoCardTrace.Assert(s_requestMap.ContainsKey(reqName), "Request map does not contain " + reqName, new object[0]);
			uIAgentRequest = s_requestMap[reqName] switch
			{
				RequestName.BeginCreateSecurityTokenRequest => new BeginCreateSecurityTokenRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.BeginSelectCardRequest => new BeginSelectCardRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.CancelAsyncOperationRequest => new CancelAsyncOperationRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.CreateCardRequest => new CreateCardRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.CheckStoreFileValidityRequest => new CheckStoreFileValidityRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.DeleteCardRequest => new DeleteCardRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.DeleteStoreRequest => new DeleteStoreRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.EndCreateSecurityTokenRequest => new EndCreateSecurityTokenRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.EndSelectCardRequest => new EndSelectCardRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.ExportFileRequest => new ExportFileRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.GetCertificateRequest => new GetCertificateRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.GetImportedCardRequest => new GetImportedCardRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.GetImportFileNameRequest => new GetImportFileNameRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.GetLedgerEntryForRecipientRequest => new GetLedgerEntryForRecipientRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.GetLedgerRequest => new GetLedgerRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.GetPolicyDetailsRequest => new GetPolicyDetailsRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.GetRecipientListRequest => new GetRecipientListRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.GetRecipientRequest => new GetRecipientRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.GetUserPreferenceRequest => new GetUserPreferenceRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.ImportFileRequest => new ImportFileRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.InfoCardListRequest => new InfoCardListRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.ListCardsInFileRequest => new ListCardsInFileRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.QueryStoreStatusRequest => new QueryStoreStatusRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.ResolvePPIDRequest => new ResolvePPIDRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.SaveCardRequest => new SaveCardRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.SaveLedgerEntryRequest => new SaveLedgerEntryRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.SaveRecipientRequest => new SaveRecipientRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.SendAgentStatusRequest => new SendAgentStatusRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.SetUserPreferenceRequest => new SetUserPreferenceRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.UIEndRequest => new UIEndRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.BeginGetFileNameFromUserRequest => new BeginGetFileNameFromUserRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.EndGetFileNameFromUserRequest => new EndGetFileNameFromUserRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.ListDependantCardsRequest => new ListDependantCardsRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.GetLastErrorDetailsRequest => new GetLastErrorDetailsRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.GetIsBrowserClientRequest => new GetIsBrowserClientRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.SetUserLanguageRequest => new SetUserLanguageRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.GetCardDetailsRequest => new GetCardDetailsRequest(rpcHandle, inStream, outStream, parentRequest), 
				RequestName.UnlockCardRequest => new UnlockCardRequest(rpcHandle, inStream, outStream, parentRequest), 
				_ => throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException()), 
			};
			uIAgentRequest.Initialize();
			return uIAgentRequest;
		}
	}
}
