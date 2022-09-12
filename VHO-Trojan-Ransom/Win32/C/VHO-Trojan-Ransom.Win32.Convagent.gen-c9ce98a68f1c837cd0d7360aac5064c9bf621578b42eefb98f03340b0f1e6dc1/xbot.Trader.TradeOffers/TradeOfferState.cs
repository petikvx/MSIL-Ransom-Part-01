namespace xbot.Trader.TradeOffers;

public enum TradeOfferState
{
	TradeOfferStateInvalid = 1,
	TradeOfferStateActive,
	TradeOfferStateAccepted,
	TradeOfferStateCountered,
	TradeOfferStateExpired,
	TradeOfferStateCanceled,
	TradeOfferStateDeclined,
	TradeOfferStateInvalidItems,
	TradeOfferStateNeedsConfirmation,
	TradeOfferStateCanceledBySecondFactor,
	TradeOfferStateInEscrow,
	TradeOfferStateUnknown
}
