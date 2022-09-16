using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _0xH4ssimilates;
using _0xH5ieseling;
using _0xHInti4adehs;
using _0xHOu6s6ared;
using _0xHPro3ody;
using _0xHTaxite6;

namespace _0xHParge0s;

[ComImport]
[TypeIdentifier]
[Guid("728AB343-217D-11DA-B2A4-000E7BBB2B09")]
[CompilerGenerated]
public interface IX509CertificateRequestCertificate : IX509CertificateRequestPkcs10
{
	[DispId(1610743828)]
	CObjectId HashAlgorithm
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743828)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743828)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Interface)]
		set;
	}

	[DispId(1610743832)]
	string RawData
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743832)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610809353)]
	CX509PrivateKey PrivateKey
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610809353)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(1610809357)]
	CX500DistinguishedName Subject
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610809357)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610809357)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Interface)]
		set;
	}

	[DispId(1610809366)]
	CX509Extensions X509Extensions
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610809366)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(1610874885)]
	DateTime NotAfter
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610874885)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610874885)]
		[param: In]
		set;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743808)]
	void Initialize([In] X509CertificateEnrollmentContext Context);

	void _VtblGap1_19();

	void _VtblGap2_2();

	void _VtblGap3_9();

	void _VtblGap4_3();

	void _VtblGap5_7();

	void _VtblGap6_10();
}
