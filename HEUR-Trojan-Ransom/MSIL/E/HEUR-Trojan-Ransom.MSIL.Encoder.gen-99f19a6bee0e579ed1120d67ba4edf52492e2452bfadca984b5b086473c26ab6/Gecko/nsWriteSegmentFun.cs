using System;

namespace Gecko;

public delegate int nsWriteSegmentFun(nsIInputStream aInStream, IntPtr aClosure, IntPtr aFromSegment, int aToOffset, int aCount, out int aWriteCount);
