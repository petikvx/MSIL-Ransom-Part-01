using System.Runtime.InteropServices;

[ComVisible(false)]
public delegate void FontEvents_FontChangedEventHandler([In][MarshalAs(UnmanagedType.BStr)] string PropertyName);
