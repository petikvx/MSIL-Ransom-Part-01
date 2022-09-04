using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[ClassInterface(0)]
[ComSourceInterfaces("SHDocVw._SearchAssistantEvents\0")]
[Guid("2E71FD0F-AAB1-42C0-9146-6D2C4EDCF07D")]
[TypeLibType(18)]
public class ShellSearchAssistantOCClass : ISearchAssistantOC3, _SearchAssistantEvents_Event, ShellSearchAssistantOC
{
	[DispId(5)]
	public virtual extern bool ShellFeaturesEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(5)]
		get;
	}

	[DispId(6)]
	public virtual extern bool SearchAssistantDefault
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(6)]
		get;
	}

	[DispId(7)]
	public virtual extern ISearches Searches
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(7)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(8)]
	public virtual extern bool InWebFolder
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(8)]
		get;
	}

	[DispId(11)]
	public virtual extern bool EventHandled
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(11)]
		[param: In]
		set;
	}

	[DispId(20)]
	public virtual extern string ASProvider
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
	public virtual extern int ASSetting
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
	public virtual extern int Version
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(24)]
		get;
	}

	[DispId(26)]
	public virtual extern bool ShowFindPrinter
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(26)]
		get;
	}

	[DispId(27)]
	public virtual extern bool SearchCompanionAvailable
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(27)]
		get;
	}

	[DispId(28)]
	public virtual extern bool UseSearchCompanion
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(28)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(28)]
		[param: In]
		set;
	}

	public virtual extern event _SearchAssistantEvents_OnNextMenuSelectEventHandler OnNextMenuSelect;

	public virtual extern event _SearchAssistantEvents_OnNewSearchEventHandler OnNewSearch;

	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern ShellSearchAssistantOCClass();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1)]
	public virtual extern void AddNextMenuItem([In][MarshalAs(UnmanagedType.BStr)] string bstrText, [In] int idItem);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2)]
	public virtual extern void SetDefaultSearchUrl([In][MarshalAs(UnmanagedType.BStr)] string bstrUrl);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(3)]
	public virtual extern void NavigateToDefaultSearch();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(4)]
	public virtual extern bool IsRestricted([In][MarshalAs(UnmanagedType.BStr)] string bstrGuid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(9)]
	public virtual extern void PutProperty([In] bool bPerLocale, [In][MarshalAs(UnmanagedType.BStr)] string bstrName, [In][MarshalAs(UnmanagedType.BStr)] string bstrValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10)]
	[return: MarshalAs(UnmanagedType.BStr)]
	public virtual extern string GetProperty([In] bool bPerLocale, [In][MarshalAs(UnmanagedType.BStr)] string bstrName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(12)]
	public virtual extern void ResetNextMenu();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(13)]
	public virtual extern void FindOnWeb();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(14)]
	public virtual extern void FindFilesOrFolders();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(15)]
	public virtual extern void FindComputer();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(16)]
	public virtual extern void FindPrinter();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(17)]
	public virtual extern void FindPeople();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(18)]
	[return: MarshalAs(UnmanagedType.BStr)]
	public virtual extern string GetSearchAssistantURL([In] bool bSubstitute, [In] bool bCustomize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(19)]
	public virtual extern void NotifySearchSettingsChanged();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(22)]
	public virtual extern void NETDetectNextNavigate();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(23)]
	public virtual extern void PutFindText([In][MarshalAs(UnmanagedType.BStr)] string FindText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(25)]
	[return: MarshalAs(UnmanagedType.BStr)]
	public virtual extern string EncodeString([In][MarshalAs(UnmanagedType.BStr)] string bstrValue, [In][MarshalAs(UnmanagedType.BStr)] string bstrCharSet, [In] bool bUseUTF8);
}
