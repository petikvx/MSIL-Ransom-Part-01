using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IdentityModel.Tokens;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using System.Threading;
using System.Xml;
using Microsoft.InfoCards.Diagnostics;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.InfoCards;

internal static class Utility
{
	[Flags]
	public enum SubjectAtrributeHAFlags
	{
		NotEnabled = 0,
		Enabled = 1,
		OrganizationHA = 2,
		LocStateCountryHA = 4,
		LogoHA = 8
	}

	public static WindowsIdentity GetWindowsIdentity(IntPtr rpcBindingHandle)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional(IntPtr.Zero == rpcBindingHandle, "rpcBindingHandle");
		uint num = NativeMethods.RpcImpersonateClient(rpcBindingHandle);
		if (num != 0)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException(SR.GetString("ServiceInvalidCallerToken"), new Win32Exception((int)num)));
		}
		try
		{
			return WindowsIdentity.GetCurrent(ifImpersonating: true);
		}
		finally
		{
			num = NativeMethods.RpcRevertToSelfEx(rpcBindingHandle);
			InfoCardTrace.Assert(0 == num, "rpcIdentity", new object[0]);
		}
	}

	public static uint GetRpcClientPid(IntPtr rpcBindingHandle)
	{
		uint pid;
		uint num = NativeMethods.I_RpcBindingInqLocalClientPID(rpcBindingHandle, out pid);
		if (num != 0)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new Win32Exception((int)num));
		}
		return pid;
	}

	public static void ClearUnsafeMemory(IntPtr ptr, int count)
	{
		NativeMethods.RtlZeroMemory(ptr, count);
	}

	public static void ThrowIfProcessExited(SafeWaitHandle processHandle)
	{
		using AutoResetEvent autoResetEvent = new AutoResetEvent(initialState: false);
		autoResetEvent.SafeWaitHandle = processHandle;
		if (autoResetEvent.WaitOne(0, exitContext: false))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("ServiceProcessHasExited")));
		}
	}

	public static void SerializeString(BinaryWriter writer, string str)
	{
		int value = 0;
		if (string.IsNullOrEmpty(str))
		{
			writer.Write(value);
			return;
		}
		writer.Write(str.Length);
		writer.Write(str.ToCharArray());
	}

	public static void SerializeUri(BinaryWriter writer, Uri uri)
	{
		if (null == uri)
		{
			SerializeString(writer, null);
		}
		else
		{
			SerializeString(writer, uri.ToString());
		}
	}

	public static void SerializeBytes(BinaryWriter writer, byte[] bytes)
	{
		int count = 0;
		if (bytes != null)
		{
			count = bytes.Length;
		}
		SerializeBytes(writer, bytes, 0, count);
	}

	public static void SerializeBytes(BinaryWriter writer, byte[] bytes, int startOffset, int count)
	{
		int value = 0;
		if (bytes == null)
		{
			writer.Write(value);
			return;
		}
		writer.Write(count);
		writer.Write(bytes, startOffset, count);
	}

	public static string DeserializeString(BinaryReader reader)
	{
		return new string(reader.ReadChars(reader.ReadInt32()));
	}

	public static Uri DeserializeUri(BinaryReader reader)
	{
		return new Uri(DeserializeString(reader));
	}

	public static bool CompareUri(string first, string second)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		try
		{
			return CompareUri(new Uri(first), new Uri(second));
		}
		catch (UriFormatException ex)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new InfoCardArgumentException(SR.GetString("InvalidUriFormat"), (Exception)ex));
		}
	}

	public static bool CompareUri(Uri first, Uri second)
	{
		return first == second;
	}

	public static bool ArrayIsNullOrEmpty(Array inArray)
	{
		if (inArray != null && inArray.Length != 0)
		{
			return false;
		}
		return true;
	}

	public static SafeWaitHandle GetLocalHandleFromRemoteHandle(SafeWaitHandle hRemote, int remotePid)
	{
		using (new SystemIdentity(throwIfAlreadySystem: false))
		{
			using SafeNativeHandle safeNativeHandle = NativeMethods.OpenProcess(64, inheritHandle: false, remotePid);
			if (safeNativeHandle != null && !safeNativeHandle.IsInvalid)
			{
				if (!NativeMethods.DuplicateHandle(safeNativeHandle, hRemote, new SafeNativeHandle(NativeMethods.GetCurrentProcess(), ownsHandle: false), out var targetHandle, 2, inheritHandle: false, 0))
				{
					int lastWin32Error = Marshal.GetLastWin32Error();
					InfoCardTrace.CloseInvalidOutSafeHandle((SafeHandle)targetHandle);
					throw InfoCardTrace.ThrowHelperError((Exception)new Win32Exception(lastWin32Error));
				}
				return targetHandle;
			}
			throw InfoCardTrace.ThrowHelperError((Exception)new Win32Exception(Marshal.GetLastWin32Error()));
		}
	}

	public static SafeWaitHandle GetRemoteHandleFromLocalHandle(SafeWaitHandle hLocal, Process remoteProcess)
	{
		SafeWaitHandle targetHandle = null;
		using (new SystemIdentity(throwIfAlreadySystem: false))
		{
			try
			{
				if (!NativeMethods.DuplicateHandle(new SafeNativeHandle(NativeMethods.GetCurrentProcess(), ownsHandle: false), hLocal, new SafeNativeHandle(remoteProcess.Handle, ownsHandle: false), out targetHandle, 1048578, inheritHandle: false, 0))
				{
					throw InfoCardTrace.ThrowHelperError((Exception)new Win32Exception(Marshal.GetLastWin32Error()));
				}
				bool success = false;
				targetHandle.DangerousAddRef(ref success);
				return targetHandle;
			}
			catch (Exception ex)
			{
				if (InfoCardTrace.IsFatal(ex))
				{
					throw;
				}
				return targetHandle;
			}
		}
	}

	public static SafeJobHandle CreateJobObjectWithSdHelper(string trustedUserSid)
	{
		SafeJobHandle safeJobHandle = new SafeJobHandle();
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			IntPtr jobHandle = IntPtr.Zero;
			uint num = NativeMcppMethods.CreateJobObjectWithSD(ref jobHandle, trustedUserSid);
			if (num != 0)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new Win32Exception((int)num));
			}
			safeJobHandle.UpdateHandle(jobHandle);
		}
		return safeJobHandle;
	}

	public static IntPtr ReadHandle(BinaryReader br)
	{
		IntPtr zero = IntPtr.Zero;
		if (4 == IntPtr.Size)
		{
			return (IntPtr)br.ReadInt32();
		}
		return (IntPtr)br.ReadInt64();
	}

	public static byte[] CreateHash(byte[] firstArray, Uri cardId)
	{
		using SHA256 sHA = new SHA256Managed();
		byte[] array = sHA.ComputeHash(Encoding.Unicode.GetBytes(cardId.ToString()));
		byte[] array2 = new byte[firstArray.Length + array.Length];
		Array.Copy(firstArray, 0, array2, 0, firstArray.Length);
		Array.Copy(array, 0, array2, firstArray.Length, array.Length);
		return sHA.ComputeHash(array2);
	}

	public static byte[] CreateHash(byte[] firstArray, byte[] secondArray, byte[] thirdArray)
	{
		byte[] array = new byte[firstArray.Length + secondArray.Length + thirdArray.Length];
		Array.Copy(firstArray, 0, array, 0, firstArray.Length);
		Array.Copy(secondArray, 0, array, firstArray.Length, secondArray.Length);
		Array.Copy(thirdArray, 0, array, firstArray.Length + secondArray.Length, thirdArray.Length);
		using SHA256 sHA = SHA256.Create();
		return sHA.ComputeHash(array);
	}

	public static bool CompareByteArrays(byte[] arr1, byte[] arr2)
	{
		bool result = true;
		if (arr1 == null && arr2 == null)
		{
			return true;
		}
		if (arr1 != null && arr2 != null && arr1.Length == arr2.Length)
		{
			for (int i = 0; i < arr2.Length; i++)
			{
				if (arr1[i] != arr2[i])
				{
					result = false;
					break;
				}
			}
			return result;
		}
		return false;
	}

	public static string ResolvePPID(string input, byte[] issuerIdentiferAsBytes, StoreConnection connection)
	{
		string result = string.Empty;
		byte[] arr = Convert.FromBase64String(input);
		List<QueryParameter> list = new List<QueryParameter>();
		list.Add(new QueryParameter("ix_objecttype", 1));
		list.Add(new QueryParameter("ix_production_svc_uri", "http://schemas.xmlsoap.org/ws/2005/05/identity/issuer/self"));
		ICollection collection = (ICollection)connection.Query(QueryDetails.FullRow, list.ToArray());
		if (collection != null && collection.Count > 0)
		{
			foreach (DataRow item in collection)
			{
				byte[] dataField = item.GetDataField();
				try
				{
					using MemoryStream stream = new MemoryStream(dataField);
					InfoCard infoCard = new InfoCard(stream);
					byte[] arr2 = CreateHash(issuerIdentiferAsBytes, infoCard.Id);
					if (CompareByteArrays(arr2, arr))
					{
						result = infoCard.Id.ToString();
						return result;
					}
				}
				finally
				{
					Array.Clear(dataField, 0, dataField.Length);
				}
			}
			return result;
		}
		return result;
	}

	public static bool GetCertHAFlags(X509Certificate2 certificate, X509Certificate2Collection supportingCertificates, ref SubjectAtrributeHAFlags certFlags)
	{
		//IL_000f: Expected O, but got Unknown
		int haFlags = 0;
		X509Chain chain;
		try
		{
			InfoCardX509Validator.ValidateChain(certificate, supportingCertificates, out chain);
		}
		catch (SecurityTokenValidationException val)
		{
			SecurityTokenValidationException val2 = val;
			InfoCardTrace.TraceAndLogException((Exception)(object)val2);
			return false;
		}
		InfoCardTrace.Assert(null != chain, "Should have been populated by ValidateChain", new object[0]);
		bool highAssuranceFlags = NativeMcppMethods.GetHighAssuranceFlags(chain.ChainContext, ref haFlags);
		certFlags = (SubjectAtrributeHAFlags)haFlags;
		if (highAssuranceFlags && !IsSubjectAtrributeHAFlagsSet(certFlags, SubjectAtrributeHAFlags.Enabled))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new UntrustedRecipientException(SR.GetString("InvalidHACertificateStructure")));
		}
		return highAssuranceFlags;
	}

	public static bool IsSubjectAtrributeHAFlagsSet(SubjectAtrributeHAFlags currentValue, SubjectAtrributeHAFlags testFlag)
	{
		if ((testFlag & currentValue) == testFlag)
		{
			return true;
		}
		return false;
	}

	public static int CalculateIncreaseByPercent(int oldSize, int alignToByteBoundary, int percentIncrease)
	{
		uint num = Convert.ToUInt32(alignToByteBoundary);
		double num2 = 1.0 + (double)percentIncrease / 100.0;
		uint num3 = Convert.ToUInt32(num2 * (double)oldSize);
		if (num3 == 0)
		{
			num3 = num;
		}
		else if (num3 % num != 0)
		{
			num3 += num - num3 % num;
		}
		return Convert.ToInt32(num3);
	}

	public static string CreatePpid(byte[] certIdentifierAsBytes, Uri cardId)
	{
		byte[] inArray = CreateHash(certIdentifierAsBytes, cardId);
		return Convert.ToBase64String(inArray);
	}

	public static EndpointAddress DeriveMexAddress(EndpointAddress epr)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		EndpointAddress result = null;
		try
		{
			XmlReader readerAtMetadata = (XmlReader)(object)epr.GetReaderAtMetadata();
			if (readerAtMetadata != null)
			{
				MetadataSet val = MetadataSet.ReadFrom((XmlReader)(object)epr.GetReaderAtMetadata());
				{
					foreach (MetadataSection metadataSection in val.get_MetadataSections())
					{
						if (metadataSection.get_Metadata() is MetadataReference && (EndpointAddress)null != ((MetadataReference)metadataSection.get_Metadata()).get_Address() && string.Compare(((MetadataReference)metadataSection.get_Metadata()).get_Address().get_Uri().Scheme, "https", StringComparison.OrdinalIgnoreCase) == 0)
						{
							result = ((MetadataReference)metadataSection.get_Metadata()).get_Address();
							return result;
						}
					}
					return result;
				}
			}
			return result;
		}
		catch (Exception ex)
		{
			if (InfoCardTrace.IsFatal(ex))
			{
				throw;
			}
			return result;
		}
	}

	public static XmlDictionaryReader CreateReaderWithQuotas(string root)
	{
		UTF8Encoding uTF8Encoding = new UTF8Encoding();
		byte[] bytes = uTF8Encoding.GetBytes(root);
		return XmlDictionaryReader.CreateTextReader(bytes, 0, bytes.GetLength(0), (Encoding)null, InfoCardConstants.DefaultQuotas, (OnXmlDictionaryReaderClose)null);
	}

	public static XmlDictionaryReader CreateReaderWithQuotas(Stream input)
	{
		return XmlDictionaryReader.CreateTextReader(input, (Encoding)null, InfoCardConstants.DefaultQuotas, (OnXmlDictionaryReaderClose)null);
	}

	public static MemoryStream ReadByteStreamFromBase64(XmlReader reader)
	{
		MemoryStream memoryStream = new MemoryStream();
		if (!reader.IsEmptyElement && reader.Read() && reader.NodeType != XmlNodeType.EndElement)
		{
			byte[] array = new byte[1024];
			int num = 0;
			while ((num = reader.ReadContentAsBase64(array, 0, array.Length)) > 0)
			{
				memoryStream.Write(array, 0, num);
			}
			memoryStream.Flush();
			memoryStream.Seek(0L, SeekOrigin.Begin);
		}
		return memoryStream;
	}

	public static Binding BuildBindingWithMaxMessageSize(Binding source)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		BindingElementCollection val = source.CreateBindingElements();
		if (val != null)
		{
			TransportBindingElement val2 = val.Find<TransportBindingElement>();
			if (val2 != null)
			{
				val2.set_MaxReceivedMessageSize((long)InfoCardConstants.MaximumMessageSize);
			}
		}
		return (Binding)new CustomBinding((IEnumerable<BindingElement>)val);
	}

	public static bool KillHelper(Process p)
	{
		bool result = false;
		if (!p.HasExited)
		{
			try
			{
				p.Kill();
				result = true;
				return result;
			}
			catch (InvalidOperationException)
			{
				return result;
			}
			catch (Win32Exception ex2)
			{
				if (5 != ex2.NativeErrorCode)
				{
					throw ex2;
				}
				return result;
			}
		}
		return result;
	}
}
