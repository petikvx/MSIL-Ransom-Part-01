using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("31bfd5b4-8ff5-4bfd-a8cb-b3dfbd4f0a5b")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIFeedEntry : nsIFeedContainer, nsIFeedElementBase
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
	nsIFeedTextConstruct GetSummaryAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSummaryAttribute([MarshalAs(UnmanagedType.Interface)] nsIFeedTextConstruct aSummary);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPublishedAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPublished);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPublishedAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPublished);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFeedTextConstruct GetContentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetContentAttribute([MarshalAs(UnmanagedType.Interface)] nsIFeedTextConstruct aContent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetEnclosuresAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEnclosuresAttribute([MarshalAs(UnmanagedType.Interface)] nsIArray aEnclosures);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetMediaContentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMediaContentAttribute([MarshalAs(UnmanagedType.Interface)] nsIArray aMediaContent);
}
