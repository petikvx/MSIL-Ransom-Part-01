using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public abstract class TlsExtensionsUtilities
{
	public static IDictionary EnsureExtensionsInitialised(IDictionary extensions)
	{
		if (extensions != null)
		{
			return extensions;
		}
		return Platform.CreateHashtable();
	}

	public static void AddAlpnExtensionClient(IDictionary extensions, IList protocolNameList)
	{
		extensions[16] = CreateAlpnExtensionClient(protocolNameList);
	}

	public static void AddAlpnExtensionServer(IDictionary extensions, ProtocolName protocolName)
	{
		extensions[16] = CreateAlpnExtensionServer(protocolName);
	}

	public static void AddCertificateAuthoritiesExtension(IDictionary extensions, IList authorities)
	{
		extensions[47] = CreateCertificateAuthoritiesExtension(authorities);
	}

	public static void AddClientCertificateTypeExtensionClient(IDictionary extensions, short[] certificateTypes)
	{
		extensions[19] = CreateCertificateTypeExtensionClient(certificateTypes);
	}

	public static void AddClientCertificateTypeExtensionServer(IDictionary extensions, short certificateType)
	{
		extensions[19] = CreateCertificateTypeExtensionServer(certificateType);
	}

	public static void AddClientCertificateUrlExtension(IDictionary extensions)
	{
		extensions[2] = CreateClientCertificateUrlExtension();
	}

	public static void AddCookieExtension(IDictionary extensions, byte[] cookie)
	{
		extensions[44] = CreateCookieExtension(cookie);
	}

	public static void AddEarlyDataIndication(IDictionary extensions)
	{
		extensions[42] = CreateEarlyDataIndication();
	}

	public static void AddEarlyDataMaxSize(IDictionary extensions, long maxSize)
	{
		extensions[42] = CreateEarlyDataMaxSize(maxSize);
	}

	public static void AddEmptyExtensionData(IDictionary extensions, int extType)
	{
		extensions[extType] = CreateEmptyExtensionData();
	}

	public static void AddEncryptThenMacExtension(IDictionary extensions)
	{
		extensions[22] = CreateEncryptThenMacExtension();
	}

	public static void AddExtendedMasterSecretExtension(IDictionary extensions)
	{
		extensions[23] = CreateExtendedMasterSecretExtension();
	}

	public static void AddHeartbeatExtension(IDictionary extensions, HeartbeatExtension heartbeatExtension)
	{
		extensions[15] = CreateHeartbeatExtension(heartbeatExtension);
	}

	public static void AddKeyShareClientHello(IDictionary extensions, IList clientShares)
	{
		extensions[51] = CreateKeyShareClientHello(clientShares);
	}

	public static void AddKeyShareHelloRetryRequest(IDictionary extensions, int namedGroup)
	{
		extensions[51] = CreateKeyShareHelloRetryRequest(namedGroup);
	}

	public static void AddKeyShareServerHello(IDictionary extensions, KeyShareEntry serverShare)
	{
		extensions[51] = CreateKeyShareServerHello(serverShare);
	}

	public static void AddMaxFragmentLengthExtension(IDictionary extensions, short maxFragmentLength)
	{
		extensions[1] = CreateMaxFragmentLengthExtension(maxFragmentLength);
	}

	public static void AddOidFiltersExtension(IDictionary extensions, IDictionary filters)
	{
		extensions[48] = CreateOidFiltersExtension(filters);
	}

	public static void AddPaddingExtension(IDictionary extensions, int dataLength)
	{
		extensions[21] = CreatePaddingExtension(dataLength);
	}

	public static void AddPostHandshakeAuthExtension(IDictionary extensions)
	{
		extensions[49] = CreatePostHandshakeAuthExtension();
	}

	public static void AddPreSharedKeyClientHello(IDictionary extensions, OfferedPsks offeredPsks)
	{
		extensions[41] = CreatePreSharedKeyClientHello(offeredPsks);
	}

	public static void AddPreSharedKeyServerHello(IDictionary extensions, int selectedIdentity)
	{
		extensions[41] = CreatePreSharedKeyServerHello(selectedIdentity);
	}

	public static void AddPskKeyExchangeModesExtension(IDictionary extensions, short[] modes)
	{
		extensions[45] = CreatePskKeyExchangeModesExtension(modes);
	}

	public static void AddRecordSizeLimitExtension(IDictionary extensions, int recordSizeLimit)
	{
		extensions[28] = CreateRecordSizeLimitExtension(recordSizeLimit);
	}

	public static void AddServerCertificateTypeExtensionClient(IDictionary extensions, short[] certificateTypes)
	{
		extensions[20] = CreateCertificateTypeExtensionClient(certificateTypes);
	}

	public static void AddServerCertificateTypeExtensionServer(IDictionary extensions, short certificateType)
	{
		extensions[20] = CreateCertificateTypeExtensionServer(certificateType);
	}

	public static void AddServerNameExtensionClient(IDictionary extensions, IList serverNameList)
	{
		extensions[0] = CreateServerNameExtensionClient(serverNameList);
	}

	public static void AddServerNameExtensionServer(IDictionary extensions)
	{
		extensions[0] = CreateServerNameExtensionServer();
	}

	public static void AddSignatureAlgorithmsExtension(IDictionary extensions, IList supportedSignatureAlgorithms)
	{
		extensions[13] = CreateSignatureAlgorithmsExtension(supportedSignatureAlgorithms);
	}

	public static void AddSignatureAlgorithmsCertExtension(IDictionary extensions, IList supportedSignatureAlgorithms)
	{
		extensions[50] = CreateSignatureAlgorithmsCertExtension(supportedSignatureAlgorithms);
	}

	public static void AddStatusRequestExtension(IDictionary extensions, CertificateStatusRequest statusRequest)
	{
		extensions[5] = CreateStatusRequestExtension(statusRequest);
	}

	public static void AddStatusRequestV2Extension(IDictionary extensions, IList statusRequestV2)
	{
		extensions[17] = CreateStatusRequestV2Extension(statusRequestV2);
	}

	public static void AddSupportedGroupsExtension(IDictionary extensions, IList namedGroups)
	{
		extensions[10] = CreateSupportedGroupsExtension(namedGroups);
	}

	public static void AddSupportedPointFormatsExtension(IDictionary extensions, short[] ecPointFormats)
	{
		extensions[11] = CreateSupportedPointFormatsExtension(ecPointFormats);
	}

	public static void AddSupportedVersionsExtensionClient(IDictionary extensions, ProtocolVersion[] versions)
	{
		extensions[43] = CreateSupportedVersionsExtensionClient(versions);
	}

	public static void AddSupportedVersionsExtensionServer(IDictionary extensions, ProtocolVersion selectedVersion)
	{
		extensions[43] = CreateSupportedVersionsExtensionServer(selectedVersion);
	}

	public static void AddTruncatedHmacExtension(IDictionary extensions)
	{
		extensions[4] = CreateTruncatedHmacExtension();
	}

	public static void AddTrustedCAKeysExtensionClient(IDictionary extensions, IList trustedAuthoritiesList)
	{
		extensions[3] = CreateTrustedCAKeysExtensionClient(trustedAuthoritiesList);
	}

	public static void AddTrustedCAKeysExtensionServer(IDictionary extensions)
	{
		extensions[3] = CreateTrustedCAKeysExtensionServer();
	}

	public static IList GetAlpnExtensionClient(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 16);
		if (extensionData != null)
		{
			return ReadAlpnExtensionClient(extensionData);
		}
		return null;
	}

	public static ProtocolName GetAlpnExtensionServer(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 16);
		if (extensionData != null)
		{
			return ReadAlpnExtensionServer(extensionData);
		}
		return null;
	}

	public static IList GetCertificateAuthoritiesExtension(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 47);
		if (extensionData != null)
		{
			return ReadCertificateAuthoritiesExtension(extensionData);
		}
		return null;
	}

	public static short[] GetClientCertificateTypeExtensionClient(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 19);
		if (extensionData != null)
		{
			return ReadCertificateTypeExtensionClient(extensionData);
		}
		return null;
	}

	public static short GetClientCertificateTypeExtensionServer(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 19);
		if (extensionData != null)
		{
			return ReadCertificateTypeExtensionServer(extensionData);
		}
		return -1;
	}

	public static byte[] GetCookieExtension(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 44);
		if (extensionData != null)
		{
			return ReadCookieExtension(extensionData);
		}
		return null;
	}

	public static long GetEarlyDataMaxSize(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 42);
		if (extensionData != null)
		{
			return ReadEarlyDataMaxSize(extensionData);
		}
		return -1L;
	}

	public static HeartbeatExtension GetHeartbeatExtension(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 15);
		if (extensionData != null)
		{
			return ReadHeartbeatExtension(extensionData);
		}
		return null;
	}

	public static IList GetKeyShareClientHello(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 51);
		if (extensionData != null)
		{
			return ReadKeyShareClientHello(extensionData);
		}
		return null;
	}

	public static int GetKeyShareHelloRetryRequest(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 51);
		if (extensionData != null)
		{
			return ReadKeyShareHelloRetryRequest(extensionData);
		}
		return -1;
	}

	public static KeyShareEntry GetKeyShareServerHello(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 51);
		if (extensionData != null)
		{
			return ReadKeyShareServerHello(extensionData);
		}
		return null;
	}

	public static short GetMaxFragmentLengthExtension(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 1);
		if (extensionData != null)
		{
			return ReadMaxFragmentLengthExtension(extensionData);
		}
		return -1;
	}

	public static IDictionary GetOidFiltersExtension(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 48);
		if (extensionData != null)
		{
			return ReadOidFiltersExtension(extensionData);
		}
		return null;
	}

	public static int GetPaddingExtension(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 21);
		if (extensionData != null)
		{
			return ReadPaddingExtension(extensionData);
		}
		return -1;
	}

	public static OfferedPsks GetPreSharedKeyClientHello(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 41);
		if (extensionData != null)
		{
			return ReadPreSharedKeyClientHello(extensionData);
		}
		return null;
	}

	public static int GetPreSharedKeyServerHello(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 41);
		if (extensionData != null)
		{
			return ReadPreSharedKeyServerHello(extensionData);
		}
		return -1;
	}

	public static short[] GetPskKeyExchangeModesExtension(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 45);
		if (extensionData != null)
		{
			return ReadPskKeyExchangeModesExtension(extensionData);
		}
		return null;
	}

	public static int GetRecordSizeLimitExtension(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 28);
		if (extensionData != null)
		{
			return ReadRecordSizeLimitExtension(extensionData);
		}
		return -1;
	}

	public static short[] GetServerCertificateTypeExtensionClient(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 20);
		if (extensionData != null)
		{
			return ReadCertificateTypeExtensionClient(extensionData);
		}
		return null;
	}

	public static short GetServerCertificateTypeExtensionServer(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 20);
		if (extensionData != null)
		{
			return ReadCertificateTypeExtensionServer(extensionData);
		}
		return -1;
	}

	public static IList GetServerNameExtensionClient(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 0);
		if (extensionData != null)
		{
			return ReadServerNameExtensionClient(extensionData);
		}
		return null;
	}

	public static IList GetSignatureAlgorithmsExtension(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 13);
		if (extensionData != null)
		{
			return ReadSignatureAlgorithmsExtension(extensionData);
		}
		return null;
	}

	public static IList GetSignatureAlgorithmsCertExtension(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 50);
		if (extensionData != null)
		{
			return ReadSignatureAlgorithmsCertExtension(extensionData);
		}
		return null;
	}

	public static CertificateStatusRequest GetStatusRequestExtension(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 5);
		if (extensionData != null)
		{
			return ReadStatusRequestExtension(extensionData);
		}
		return null;
	}

	public static IList GetStatusRequestV2Extension(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 17);
		if (extensionData != null)
		{
			return ReadStatusRequestV2Extension(extensionData);
		}
		return null;
	}

	public static int[] GetSupportedGroupsExtension(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 10);
		if (extensionData != null)
		{
			return ReadSupportedGroupsExtension(extensionData);
		}
		return null;
	}

	public static short[] GetSupportedPointFormatsExtension(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 11);
		if (extensionData != null)
		{
			return ReadSupportedPointFormatsExtension(extensionData);
		}
		return null;
	}

	public static ProtocolVersion[] GetSupportedVersionsExtensionClient(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 43);
		if (extensionData != null)
		{
			return ReadSupportedVersionsExtensionClient(extensionData);
		}
		return null;
	}

	public static ProtocolVersion GetSupportedVersionsExtensionServer(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 43);
		if (extensionData != null)
		{
			return ReadSupportedVersionsExtensionServer(extensionData);
		}
		return null;
	}

	public static IList GetTrustedCAKeysExtensionClient(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 3);
		if (extensionData != null)
		{
			return ReadTrustedCAKeysExtensionClient(extensionData);
		}
		return null;
	}

	public static bool HasClientCertificateUrlExtension(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 2);
		if (extensionData != null)
		{
			return ReadClientCertificateUrlExtension(extensionData);
		}
		return false;
	}

	public static bool HasEarlyDataIndication(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 42);
		if (extensionData != null)
		{
			return ReadEarlyDataIndication(extensionData);
		}
		return false;
	}

	public static bool HasEncryptThenMacExtension(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 22);
		if (extensionData != null)
		{
			return ReadEncryptThenMacExtension(extensionData);
		}
		return false;
	}

	public static bool HasExtendedMasterSecretExtension(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 23);
		if (extensionData != null)
		{
			return ReadExtendedMasterSecretExtension(extensionData);
		}
		return false;
	}

	public static bool HasServerNameExtensionServer(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 0);
		if (extensionData != null)
		{
			return ReadServerNameExtensionServer(extensionData);
		}
		return false;
	}

	public static bool HasPostHandshakeAuthExtension(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 49);
		if (extensionData != null)
		{
			return ReadPostHandshakeAuthExtension(extensionData);
		}
		return false;
	}

	public static bool HasTruncatedHmacExtension(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 4);
		if (extensionData != null)
		{
			return ReadTruncatedHmacExtension(extensionData);
		}
		return false;
	}

	public static bool HasTrustedCAKeysExtensionServer(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 3);
		if (extensionData != null)
		{
			return ReadTrustedCAKeysExtensionServer(extensionData);
		}
		return false;
	}

	public static byte[] CreateAlpnExtensionClient(IList protocolNameList)
	{
		if (protocolNameList != null && protocolNameList.Count >= 1)
		{
			MemoryStream memoryStream = new MemoryStream();
			TlsUtilities.WriteUint16(0, memoryStream);
			foreach (ProtocolName protocolName in protocolNameList)
			{
				protocolName.Encode(memoryStream);
			}
			return PatchOpaque16(memoryStream);
		}
		throw new TlsFatalAlert(80);
	}

	public static byte[] CreateAlpnExtensionServer(ProtocolName protocolName)
	{
		IList list = Platform.CreateArrayList();
		list.Add(protocolName);
		return CreateAlpnExtensionClient(list);
	}

	public static byte[] CreateCertificateAuthoritiesExtension(IList authorities)
	{
		if (authorities != null && authorities.Count >= 1)
		{
			MemoryStream memoryStream = new MemoryStream();
			TlsUtilities.WriteUint16(0, memoryStream);
			foreach (X509Name authority in authorities)
			{
				TlsUtilities.WriteOpaque16(authority.GetEncoded("DER"), memoryStream);
			}
			return PatchOpaque16(memoryStream);
		}
		throw new TlsFatalAlert(80);
	}

	public static byte[] CreateCertificateTypeExtensionClient(short[] certificateTypes)
	{
		if (TlsUtilities.IsNullOrEmpty(certificateTypes) || certificateTypes.Length > 255)
		{
			throw new TlsFatalAlert(80);
		}
		return TlsUtilities.EncodeUint8ArrayWithUint8Length(certificateTypes);
	}

	public static byte[] CreateCertificateTypeExtensionServer(short certificateType)
	{
		return TlsUtilities.EncodeUint8(certificateType);
	}

	public static byte[] CreateClientCertificateUrlExtension()
	{
		return CreateEmptyExtensionData();
	}

	public static byte[] CreateCookieExtension(byte[] cookie)
	{
		if (TlsUtilities.IsNullOrEmpty(cookie) || cookie.Length >= 65536)
		{
			throw new TlsFatalAlert(80);
		}
		return TlsUtilities.EncodeOpaque16(cookie);
	}

	public static byte[] CreateEarlyDataIndication()
	{
		return CreateEmptyExtensionData();
	}

	public static byte[] CreateEarlyDataMaxSize(long maxSize)
	{
		return TlsUtilities.EncodeUint32(maxSize);
	}

	public static byte[] CreateEmptyExtensionData()
	{
		return TlsUtilities.EmptyBytes;
	}

	public static byte[] CreateEncryptThenMacExtension()
	{
		return CreateEmptyExtensionData();
	}

	public static byte[] CreateExtendedMasterSecretExtension()
	{
		return CreateEmptyExtensionData();
	}

	public static byte[] CreateHeartbeatExtension(HeartbeatExtension heartbeatExtension)
	{
		if (heartbeatExtension == null)
		{
			throw new TlsFatalAlert(80);
		}
		MemoryStream memoryStream = new MemoryStream();
		heartbeatExtension.Encode(memoryStream);
		return memoryStream.ToArray();
	}

	public static byte[] CreateKeyShareClientHello(IList clientShares)
	{
		if (clientShares != null && clientShares.Count >= 1)
		{
			MemoryStream memoryStream = new MemoryStream();
			TlsUtilities.WriteUint16(0, memoryStream);
			foreach (KeyShareEntry clientShare in clientShares)
			{
				clientShare.Encode(memoryStream);
			}
			return PatchOpaque16(memoryStream);
		}
		return TlsUtilities.EncodeUint16(0);
	}

	public static byte[] CreateKeyShareHelloRetryRequest(int namedGroup)
	{
		return TlsUtilities.EncodeUint16(namedGroup);
	}

	public static byte[] CreateKeyShareServerHello(KeyShareEntry serverShare)
	{
		if (serverShare == null)
		{
			throw new TlsFatalAlert(80);
		}
		MemoryStream memoryStream = new MemoryStream();
		serverShare.Encode(memoryStream);
		return memoryStream.ToArray();
	}

	public static byte[] CreateMaxFragmentLengthExtension(short maxFragmentLength)
	{
		return TlsUtilities.EncodeUint8(maxFragmentLength);
	}

	public static byte[] CreateOidFiltersExtension(IDictionary filters)
	{
		MemoryStream memoryStream = new MemoryStream();
		TlsUtilities.WriteUint16(0, memoryStream);
		if (filters != null)
		{
			foreach (DerObjectIdentifier key in filters.Keys)
			{
				byte[] array = (byte[])filters[key];
				if (key != null && array != null)
				{
					TlsUtilities.WriteOpaque8(key.GetEncoded("DER"), memoryStream);
					TlsUtilities.WriteOpaque16(array, memoryStream);
					continue;
				}
				throw new TlsFatalAlert(80);
			}
		}
		return PatchOpaque16(memoryStream);
	}

	public static byte[] CreatePaddingExtension(int dataLength)
	{
		TlsUtilities.CheckUint16(dataLength);
		return new byte[dataLength];
	}

	public static byte[] CreatePostHandshakeAuthExtension()
	{
		return CreateEmptyExtensionData();
	}

	public static byte[] CreatePreSharedKeyClientHello(OfferedPsks offeredPsks)
	{
		if (offeredPsks == null)
		{
			throw new TlsFatalAlert(80);
		}
		MemoryStream memoryStream = new MemoryStream();
		offeredPsks.Encode(memoryStream);
		return memoryStream.ToArray();
	}

	public static byte[] CreatePreSharedKeyServerHello(int selectedIdentity)
	{
		return TlsUtilities.EncodeUint16(selectedIdentity);
	}

	public static byte[] CreatePskKeyExchangeModesExtension(short[] modes)
	{
		if (TlsUtilities.IsNullOrEmpty(modes) || modes.Length > 255)
		{
			throw new TlsFatalAlert(80);
		}
		return TlsUtilities.EncodeUint8ArrayWithUint8Length(modes);
	}

	public static byte[] CreateRecordSizeLimitExtension(int recordSizeLimit)
	{
		if (recordSizeLimit < 64)
		{
			throw new TlsFatalAlert(80);
		}
		return TlsUtilities.EncodeUint16(recordSizeLimit);
	}

	public static byte[] CreateServerNameExtensionClient(IList serverNameList)
	{
		if (serverNameList == null)
		{
			throw new TlsFatalAlert(80);
		}
		MemoryStream memoryStream = new MemoryStream();
		new ServerNameList(serverNameList).Encode(memoryStream);
		return memoryStream.ToArray();
	}

	public static byte[] CreateServerNameExtensionServer()
	{
		return CreateEmptyExtensionData();
	}

	public static byte[] CreateSignatureAlgorithmsExtension(IList supportedSignatureAlgorithms)
	{
		MemoryStream memoryStream = new MemoryStream();
		TlsUtilities.EncodeSupportedSignatureAlgorithms(supportedSignatureAlgorithms, memoryStream);
		return memoryStream.ToArray();
	}

	public static byte[] CreateSignatureAlgorithmsCertExtension(IList supportedSignatureAlgorithms)
	{
		return CreateSignatureAlgorithmsExtension(supportedSignatureAlgorithms);
	}

	public static byte[] CreateStatusRequestExtension(CertificateStatusRequest statusRequest)
	{
		if (statusRequest == null)
		{
			throw new TlsFatalAlert(80);
		}
		MemoryStream memoryStream = new MemoryStream();
		statusRequest.Encode(memoryStream);
		return memoryStream.ToArray();
	}

	public static byte[] CreateStatusRequestV2Extension(IList statusRequestV2)
	{
		if (statusRequestV2 != null && statusRequestV2.Count >= 1)
		{
			MemoryStream memoryStream = new MemoryStream();
			TlsUtilities.WriteUint16(0, memoryStream);
			foreach (CertificateStatusRequestItemV2 item in statusRequestV2)
			{
				item.Encode(memoryStream);
			}
			return PatchOpaque16(memoryStream);
		}
		throw new TlsFatalAlert(80);
	}

	public static byte[] CreateSupportedGroupsExtension(IList namedGroups)
	{
		if (namedGroups != null && namedGroups.Count >= 1)
		{
			int count = namedGroups.Count;
			int[] array = new int[count];
			for (int i = 0; i < count; i++)
			{
				array[i] = (int)namedGroups[i];
			}
			return TlsUtilities.EncodeUint16ArrayWithUint16Length(array);
		}
		throw new TlsFatalAlert(80);
	}

	public static byte[] CreateSupportedPointFormatsExtension(short[] ecPointFormats)
	{
		if (ecPointFormats == null || !Arrays.Contains(ecPointFormats, 0))
		{
			ecPointFormats = Arrays.Prepend(ecPointFormats, 0);
		}
		return TlsUtilities.EncodeUint8ArrayWithUint8Length(ecPointFormats);
	}

	public static byte[] CreateSupportedVersionsExtensionClient(ProtocolVersion[] versions)
	{
		if (!TlsUtilities.IsNullOrEmpty(versions) && versions.Length <= 127)
		{
			int num = versions.Length;
			byte[] array = new byte[1 + num * 2];
			TlsUtilities.WriteUint8(num * 2, array, 0);
			for (int i = 0; i < num; i++)
			{
				TlsUtilities.WriteVersion(versions[i], array, 1 + i * 2);
			}
			return array;
		}
		throw new TlsFatalAlert(80);
	}

	public static byte[] CreateSupportedVersionsExtensionServer(ProtocolVersion selectedVersion)
	{
		return TlsUtilities.EncodeVersion(selectedVersion);
	}

	public static byte[] CreateTruncatedHmacExtension()
	{
		return CreateEmptyExtensionData();
	}

	public static byte[] CreateTrustedCAKeysExtensionClient(IList trustedAuthoritiesList)
	{
		MemoryStream memoryStream = new MemoryStream();
		TlsUtilities.WriteUint16(0, memoryStream);
		if (trustedAuthoritiesList != null)
		{
			foreach (TrustedAuthority trustedAuthorities in trustedAuthoritiesList)
			{
				trustedAuthorities.Encode(memoryStream);
			}
		}
		return PatchOpaque16(memoryStream);
	}

	public static byte[] CreateTrustedCAKeysExtensionServer()
	{
		return CreateEmptyExtensionData();
	}

	private static bool ReadEmptyExtensionData(byte[] extensionData)
	{
		if (extensionData == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		if (extensionData.Length != 0)
		{
			throw new TlsFatalAlert(47);
		}
		return true;
	}

	public static IList ReadAlpnExtensionClient(byte[] extensionData)
	{
		if (extensionData == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		MemoryStream memoryStream = new MemoryStream(extensionData);
		if (TlsUtilities.ReadUint16(memoryStream) != extensionData.Length - 2)
		{
			throw new TlsFatalAlert(50);
		}
		IList list = Platform.CreateArrayList();
		while (memoryStream.Position < memoryStream.Length)
		{
			ProtocolName value = ProtocolName.Parse(memoryStream);
			list.Add(value);
		}
		return list;
	}

	public static ProtocolName ReadAlpnExtensionServer(byte[] extensionData)
	{
		IList list = ReadAlpnExtensionClient(extensionData);
		if (list.Count != 1)
		{
			throw new TlsFatalAlert(50);
		}
		return (ProtocolName)list[0];
	}

	public static IList ReadCertificateAuthoritiesExtension(byte[] extensionData)
	{
		if (extensionData == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		if (extensionData.Length < 5)
		{
			throw new TlsFatalAlert(50);
		}
		MemoryStream memoryStream = new MemoryStream(extensionData);
		if (TlsUtilities.ReadUint16(memoryStream) != extensionData.Length - 2)
		{
			throw new TlsFatalAlert(50);
		}
		IList list = Platform.CreateArrayList();
		while (memoryStream.Position < memoryStream.Length)
		{
			Asn1Object obj = TlsUtilities.ReadDerObject(TlsUtilities.ReadOpaque16(memoryStream, 1));
			list.Add(X509Name.GetInstance(obj));
		}
		return list;
	}

	public static short[] ReadCertificateTypeExtensionClient(byte[] extensionData)
	{
		short[] array = TlsUtilities.DecodeUint8ArrayWithUint8Length(extensionData);
		if (array.Length < 1)
		{
			throw new TlsFatalAlert(50);
		}
		return array;
	}

	public static short ReadCertificateTypeExtensionServer(byte[] extensionData)
	{
		return TlsUtilities.DecodeUint8(extensionData);
	}

	public static bool ReadClientCertificateUrlExtension(byte[] extensionData)
	{
		return ReadEmptyExtensionData(extensionData);
	}

	public static byte[] ReadCookieExtension(byte[] extensionData)
	{
		return TlsUtilities.DecodeOpaque16(extensionData, 1);
	}

	public static bool ReadEarlyDataIndication(byte[] extensionData)
	{
		return ReadEmptyExtensionData(extensionData);
	}

	public static long ReadEarlyDataMaxSize(byte[] extensionData)
	{
		return TlsUtilities.DecodeUint32(extensionData);
	}

	public static bool ReadEncryptThenMacExtension(byte[] extensionData)
	{
		return ReadEmptyExtensionData(extensionData);
	}

	public static bool ReadExtendedMasterSecretExtension(byte[] extensionData)
	{
		return ReadEmptyExtensionData(extensionData);
	}

	public static HeartbeatExtension ReadHeartbeatExtension(byte[] extensionData)
	{
		if (extensionData == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		MemoryStream memoryStream = new MemoryStream(extensionData, writable: false);
		HeartbeatExtension result = HeartbeatExtension.Parse(memoryStream);
		TlsProtocol.AssertEmpty(memoryStream);
		return result;
	}

	public static IList ReadKeyShareClientHello(byte[] extensionData)
	{
		if (extensionData == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		MemoryStream memoryStream = new MemoryStream(extensionData, writable: false);
		if (TlsUtilities.ReadUint16(memoryStream) != extensionData.Length - 2)
		{
			throw new TlsFatalAlert(50);
		}
		IList list = Platform.CreateArrayList();
		while (memoryStream.Position < memoryStream.Length)
		{
			KeyShareEntry value = KeyShareEntry.Parse(memoryStream);
			list.Add(value);
		}
		return list;
	}

	public static int ReadKeyShareHelloRetryRequest(byte[] extensionData)
	{
		return TlsUtilities.DecodeUint16(extensionData);
	}

	public static KeyShareEntry ReadKeyShareServerHello(byte[] extensionData)
	{
		if (extensionData == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		MemoryStream memoryStream = new MemoryStream(extensionData, writable: false);
		KeyShareEntry result = KeyShareEntry.Parse(memoryStream);
		TlsProtocol.AssertEmpty(memoryStream);
		return result;
	}

	public static short ReadMaxFragmentLengthExtension(byte[] extensionData)
	{
		return TlsUtilities.DecodeUint8(extensionData);
	}

	public static IDictionary ReadOidFiltersExtension(byte[] extensionData)
	{
		if (extensionData == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		if (extensionData.Length < 2)
		{
			throw new TlsFatalAlert(50);
		}
		MemoryStream memoryStream = new MemoryStream(extensionData, writable: false);
		if (TlsUtilities.ReadUint16(memoryStream) != extensionData.Length - 2)
		{
			throw new TlsFatalAlert(50);
		}
		IDictionary dictionary = Platform.CreateHashtable();
		while (memoryStream.Position < memoryStream.Length)
		{
			DerObjectIdentifier instance = DerObjectIdentifier.GetInstance(TlsUtilities.ReadDerObject(TlsUtilities.ReadOpaque8(memoryStream, 1)));
			if (dictionary.Contains(instance))
			{
				throw new TlsFatalAlert(47);
			}
			byte[] array2 = (byte[])(dictionary[instance] = TlsUtilities.ReadOpaque16(memoryStream));
		}
		return dictionary;
	}

	public static int ReadPaddingExtension(byte[] extensionData)
	{
		if (extensionData == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		if (!Arrays.AreAllZeroes(extensionData, 0, extensionData.Length))
		{
			throw new TlsFatalAlert(47);
		}
		return extensionData.Length;
	}

	public static bool ReadPostHandshakeAuthExtension(byte[] extensionData)
	{
		return ReadEmptyExtensionData(extensionData);
	}

	public static OfferedPsks ReadPreSharedKeyClientHello(byte[] extensionData)
	{
		if (extensionData == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		MemoryStream memoryStream = new MemoryStream(extensionData, writable: false);
		OfferedPsks result = OfferedPsks.Parse(memoryStream);
		TlsProtocol.AssertEmpty(memoryStream);
		return result;
	}

	public static int ReadPreSharedKeyServerHello(byte[] extensionData)
	{
		return TlsUtilities.DecodeUint16(extensionData);
	}

	public static short[] ReadPskKeyExchangeModesExtension(byte[] extensionData)
	{
		short[] array = TlsUtilities.DecodeUint8ArrayWithUint8Length(extensionData);
		if (array.Length < 1)
		{
			throw new TlsFatalAlert(50);
		}
		return array;
	}

	public static int ReadRecordSizeLimitExtension(byte[] extensionData)
	{
		int num = TlsUtilities.DecodeUint16(extensionData);
		if (num < 64)
		{
			throw new TlsFatalAlert(47);
		}
		return num;
	}

	public static IList ReadServerNameExtensionClient(byte[] extensionData)
	{
		if (extensionData == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		MemoryStream memoryStream = new MemoryStream(extensionData, writable: false);
		ServerNameList serverNameList = ServerNameList.Parse(memoryStream);
		TlsProtocol.AssertEmpty(memoryStream);
		return serverNameList.ServerNames;
	}

	public static bool ReadServerNameExtensionServer(byte[] extensionData)
	{
		return ReadEmptyExtensionData(extensionData);
	}

	public static IList ReadSignatureAlgorithmsExtension(byte[] extensionData)
	{
		if (extensionData == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		MemoryStream memoryStream = new MemoryStream(extensionData, writable: false);
		IList result = TlsUtilities.ParseSupportedSignatureAlgorithms(memoryStream);
		TlsProtocol.AssertEmpty(memoryStream);
		return result;
	}

	public static IList ReadSignatureAlgorithmsCertExtension(byte[] extensionData)
	{
		return ReadSignatureAlgorithmsExtension(extensionData);
	}

	public static CertificateStatusRequest ReadStatusRequestExtension(byte[] extensionData)
	{
		if (extensionData == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		MemoryStream memoryStream = new MemoryStream(extensionData, writable: false);
		CertificateStatusRequest result = CertificateStatusRequest.Parse(memoryStream);
		TlsProtocol.AssertEmpty(memoryStream);
		return result;
	}

	public static IList ReadStatusRequestV2Extension(byte[] extensionData)
	{
		if (extensionData == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		if (extensionData.Length < 3)
		{
			throw new TlsFatalAlert(50);
		}
		MemoryStream memoryStream = new MemoryStream(extensionData, writable: false);
		if (TlsUtilities.ReadUint16(memoryStream) != extensionData.Length - 2)
		{
			throw new TlsFatalAlert(50);
		}
		IList list = Platform.CreateArrayList();
		while (memoryStream.Position < memoryStream.Length)
		{
			CertificateStatusRequestItemV2 value = CertificateStatusRequestItemV2.Parse(memoryStream);
			list.Add(value);
		}
		return list;
	}

	public static int[] ReadSupportedGroupsExtension(byte[] extensionData)
	{
		if (extensionData == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		MemoryStream memoryStream = new MemoryStream(extensionData, writable: false);
		int num = TlsUtilities.ReadUint16(memoryStream);
		if (num < 2 || ((uint)num & (true ? 1u : 0u)) != 0)
		{
			throw new TlsFatalAlert(50);
		}
		int[] result = TlsUtilities.ReadUint16Array(num / 2, memoryStream);
		TlsProtocol.AssertEmpty(memoryStream);
		return result;
	}

	public static short[] ReadSupportedPointFormatsExtension(byte[] extensionData)
	{
		short[] array = TlsUtilities.DecodeUint8ArrayWithUint8Length(extensionData);
		if (!Arrays.Contains(array, 0))
		{
			throw new TlsFatalAlert(47);
		}
		return array;
	}

	public static ProtocolVersion[] ReadSupportedVersionsExtensionClient(byte[] extensionData)
	{
		if (extensionData == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		if (extensionData.Length >= 3 && extensionData.Length <= 255 && ((uint)extensionData.Length & (true ? 1u : 0u)) != 0)
		{
			short num = TlsUtilities.ReadUint8(extensionData, 0);
			if (num != extensionData.Length - 1)
			{
				throw new TlsFatalAlert(50);
			}
			int num2 = num / 2;
			ProtocolVersion[] array = new ProtocolVersion[num2];
			for (int i = 0; i < num2; i++)
			{
				array[i] = TlsUtilities.ReadVersion(extensionData, 1 + i * 2);
			}
			return array;
		}
		throw new TlsFatalAlert(50);
	}

	public static ProtocolVersion ReadSupportedVersionsExtensionServer(byte[] extensionData)
	{
		if (extensionData == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		if (extensionData.Length != 2)
		{
			throw new TlsFatalAlert(50);
		}
		return TlsUtilities.ReadVersion(extensionData, 0);
	}

	public static bool ReadTruncatedHmacExtension(byte[] extensionData)
	{
		return ReadEmptyExtensionData(extensionData);
	}

	public static IList ReadTrustedCAKeysExtensionClient(byte[] extensionData)
	{
		if (extensionData == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		if (extensionData.Length < 2)
		{
			throw new TlsFatalAlert(50);
		}
		MemoryStream memoryStream = new MemoryStream(extensionData, writable: false);
		if (TlsUtilities.ReadUint16(memoryStream) != extensionData.Length - 2)
		{
			throw new TlsFatalAlert(50);
		}
		IList list = Platform.CreateArrayList();
		while (memoryStream.Position < memoryStream.Length)
		{
			TrustedAuthority value = TrustedAuthority.Parse(memoryStream);
			list.Add(value);
		}
		return list;
	}

	public static bool ReadTrustedCAKeysExtensionServer(byte[] extensionData)
	{
		return ReadEmptyExtensionData(extensionData);
	}

	private static byte[] PatchOpaque16(MemoryStream buf)
	{
		int i = (int)buf.Length - 2;
		TlsUtilities.CheckUint16(i);
		byte[] array = buf.ToArray();
		TlsUtilities.WriteUint16(i, array, 0);
		return array;
	}
}
