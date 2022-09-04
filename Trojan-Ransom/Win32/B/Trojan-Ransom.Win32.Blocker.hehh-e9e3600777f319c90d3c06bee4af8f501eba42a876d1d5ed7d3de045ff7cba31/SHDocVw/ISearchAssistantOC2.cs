using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[Guid("72423E8F-8011-11D2-BE79-00A0C9A83DA2")]
[TypeLibType(4176)]
public interface ISearchAssistantOC2 : ISearchAssistantOC
{
	[DispId(5)]
	new bool ShellFeaturesEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(5)]
		get;
	}

	[DispId(6)]
	new bool SearchAssistantDefault
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(6)]
		get;
	}

	[DispId(7)]
	new ISearches Searches
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(7)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(8)]
	new bool InWebFolder
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(8)]
		get;
	}

	[DispId(11)]
	new bool EventHandled
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(11)]
		[param: In]
		set;
	}

	[DispId(20)]
	new string ASProvider
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
	new int ASSetting
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
	new int Version
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(24)]
		get;
	}

	[DispId(26)]
	bool ShowFindPrinter
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(26)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1)]
	new void AddNextMenuItem([In][MarshalAs(UnmanagedType.BStr)] string bstrText, [In] int idItem);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2)]
	new void SetDefaultSearchUrl([In][MarshalAs(UnmanagedType.BStr)] string bstrUrl);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(3)]
	new void NavigateToDefaultSearch();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(4)]
	new bool IsRestricted([In][MarshalAs(UnmanagedType.BStr)] string bstrGuid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(9)]
	new void PutProperty([In] bool bPerLocale, [In][MarshalAs(UnmanagedType.BStr)] string bstrName, [In][MarshalAs(UnmanagedType.BStr)] string bstrValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10)]
	[return: MarshalAs(UnmanagedType.BStr)]
	new string GetProperty([In] bool bPerLocale, [In][MarshalAs(UnmanagedType.BStr)] string bstrName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(12)]
	new void ResetNextMenu();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(13)]
	new void FindOnWeb();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(14)]
	new void FindFilesOrFolders();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(15)]
	new void FindComputer();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(16)]
	new void FindPrinter();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(17)]
	new void FindPeople();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(18)]
	[return: MarshalAs(UnmanagedType.BStr)]
	new string GetSearchAssistantURL([In] bool bSubstitute, [In] bool bCustomize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(19)]
	new void NotifySearchSettingsChanged();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(22)]
	new void NETDetectNextNavigate();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(23)]
	new void PutFindText([In][MarshalAs(UnmanagedType.BStr)] string FindText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(25)]
	[return: MarshalAs(UnmanagedType.BStr)]
	new string EncodeString([In][MarshalAs(UnmanagedType.BStr)] string bstrValue, [In][MarshalAs(UnmanagedType.BStr)] string bstrCharSet, [In] bool bUseUTF8);
}
