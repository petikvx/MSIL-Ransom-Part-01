namespace Alphaleonis.Win32.Filesystem;

public delegate CopyMoveProgressResult CopyMoveProgressRoutine(long totalFileSize, long totalBytesTransferred, long streamSize, long streamBytesTransferred, int streamNumber, CopyMoveProgressCallbackReason callbackReason, object userData);
