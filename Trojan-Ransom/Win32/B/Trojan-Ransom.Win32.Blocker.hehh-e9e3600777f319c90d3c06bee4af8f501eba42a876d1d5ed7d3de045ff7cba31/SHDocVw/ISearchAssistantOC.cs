using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[Guid("72423E8F-8011-11D2-BE79-00A0C9A83DA1")]
[TypeLibType(4176)]
public interface ISearchAssistantOC
{
	[DispId(5)]
	bool ShellFeaturesEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(5)]
		get;
	}

	[DispId(6)]
	bool SearchAssistantDefault
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(6)]
		get;
	}

	[DispId(7)]
	ISearches Searches
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(7)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(8)]
	bool InWebFolder
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(8)]
		get;
	}

	[DispId(11)]
	bool EventHandled
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(11)]
		[param: In]
		set;
	}

	[DispId(20)]
	string ASProvider
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(20)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(20)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(21)]
	int ASSetting
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(21)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(21)]
		[param: In]
		set;
	}

	[DispId(24)]
	int Version
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(24)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1)]
	void AddNextMenuItem([In][MarshalAs(UnmanagedType.BStr)] string bstrText, [In] int idItem);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2)]
	void SetDefaultSearchUrl([In][MarshalAs(UnmanagedType.BStr)] string bstrUrl);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(3)]
	void NavigateToDefaultSearch();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(4)]
	bool IsRestricted([In][MarshalAs(UnmanagedType.BStr)] string bstrGuid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(9)]
	void PutProperty([In] bool bPerLocale, [In][MarshalAs(UnmanagedType.BStr)] string bstrName, [In][MarshalAs(UnmanagedType.BStr)] string bstrValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetProperty([In] bool bPerLocale, [In][MarshalAs(UnmanagedType.BStr)] string bstrName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(12)]
	void ResetNextMenu();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(13)]
	void FindOnWeb();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(14)]
	void FindFilesOrFolders();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(15)]
	void FindComputer();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(16)]
	void FindPrinter();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(17)]
	void FindPeople();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(18)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetSearchAssistantURL([In] bool bSubstitute, [In] bool bCustomize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(19)]
	void NotifySearchSettingsChanged();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(22)]
	void NETDetectNextNavigate();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(23)]
	void PutFindText([In][MarshalAs(UnmanagedType.BStr)] string FindText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(25)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string EncodeString([In][MarshalAs(UnmanagedType.BStr)] string bstrValue, [In][MarshalAs(UnmanagedType.BStr)] string bstrCharSet, [In] bool bUseUTF8);
}
