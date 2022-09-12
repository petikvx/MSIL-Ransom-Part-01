using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("577a1b4c-b3d4-4c76-9cf8-753e6606114f")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIFeedContainer : nsIFeedElementBase
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
	void GetIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIWritablePropertyBag2 GetFieldsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFieldsAttribute([MarshalAs(UnmanagedType.Interface)] nsIWritablePropertyBag2 aFields);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFeedTextConstruct GetTitleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTitleAttribute([MarshalAs(UnmanagedType.Interface)] nsIFeedTextConstruct aTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetLinkAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLinkAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aLink);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetLinksAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLinksAttribute([MarshalAs(UnmanagedType.Interface)] nsIArray aLinks);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetCategoriesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCategoriesAttribute([MarshalAs(UnmanagedType.Interface)] nsIArray aCategories);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFeedTextConstruct GetRightsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRightsAttribute([MarshalAs(UnmanagedType.Interface)] nsIFeedTextConstruct aRights);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetAuthorsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAuthorsAttribute([MarshalAs(UnmanagedType.Interface)] nsIArray aAuthors);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetContributorsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetContributorsAttribute([MarshalAs(UnmanagedType.Interface)] nsIArray aContributors);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetUpdatedAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUpdated);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUpdatedAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUpdated);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Normalize();
}
