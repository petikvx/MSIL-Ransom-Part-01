using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("3b8aae33-80e2-4efa-99c8-a6c5b99f76ea")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIFeed : nsIFeedContainer, nsIFeedElementBase
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISAXAttributes GetAttributesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetAttributesAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXAttributes aAttributes);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIURI GetBaseURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetBaseURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIWritablePropertyBag2 GetFieldsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetFieldsAttribute([MarshalAs(UnmanagedType.Interface)] nsIWritablePropertyBag2 aFields);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIFeedTextConstruct GetTitleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetTitleAttribute([MarshalAs(UnmanagedType.Interface)] nsIFeedTextConstruct aTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIURI GetLinkAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetLinkAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aLink);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIArray GetLinksAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetLinksAttribute([MarshalAs(UnmanagedType.Interface)] nsIArray aLinks);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIArray GetCategoriesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetCategoriesAttribute([MarshalAs(UnmanagedType.Interface)] nsIArray aCategories);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIFeedTextConstruct GetRightsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetRightsAttribute([MarshalAs(UnmanagedType.Interface)] nsIFeedTextConstruct aRights);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIArray GetAuthorsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetAuthorsAttribute([MarshalAs(UnmanagedType.Interface)] nsIArray aAuthors);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIArray GetContributorsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetContributorsAttribute([MarshalAs(UnmanagedType.Interface)] nsIArray aContributors);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetUpdatedAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUpdated);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetUpdatedAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUpdated);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Normalize();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFeedTextConstruct GetSubtitleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSubtitleAttribute([MarshalAs(UnmanagedType.Interface)] nsIFeedTextConstruct aSubtitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetEnclosureCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEnclosureCountAttribute(int aEnclosureCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetItemsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetItemsAttribute([MarshalAs(UnmanagedType.Interface)] nsIArray aItems);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIWritablePropertyBag2 GetCloudAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCloudAttribute([MarshalAs(UnmanagedType.Interface)] nsIWritablePropertyBag2 aCloud);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFeedGenerator GetGeneratorAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetGeneratorAttribute([MarshalAs(UnmanagedType.Interface)] nsIFeedGenerator aGenerator);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIWritablePropertyBag2 GetImageAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetImageAttribute([MarshalAs(UnmanagedType.Interface)] nsIWritablePropertyBag2 aImage);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIWritablePropertyBag2 GetTextInputAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTextInputAttribute([MarshalAs(UnmanagedType.Interface)] nsIWritablePropertyBag2 aTextInput);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetSkipDaysAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSkipDaysAttribute([MarshalAs(UnmanagedType.Interface)] nsIArray aSkipDays);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetSkipHoursAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSkipHoursAttribute([MarshalAs(UnmanagedType.Interface)] nsIArray aSkipHours);
}
