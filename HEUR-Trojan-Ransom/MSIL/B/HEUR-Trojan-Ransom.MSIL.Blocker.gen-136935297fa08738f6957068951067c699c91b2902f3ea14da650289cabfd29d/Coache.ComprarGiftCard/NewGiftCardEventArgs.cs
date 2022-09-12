using System;
using Coache.Common;

namespace Coache.ComprarGiftCard;

public class NewGiftCardEventArgs : EventArgs
{
	public GiftCard GiftCard { get; set; }
}
