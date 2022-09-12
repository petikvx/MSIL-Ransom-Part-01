using System.Collections.Generic;
using System.Threading.Tasks;
using xbot_wpf.Models;
using xbot_wpf.Responses;

namespace xbot_wpf.Services;

public interface GInterface2
{
	int Timeout { get; set; }

	string ApiKey { get; set; }

	SettingDota2 setting { get; set; }

	Task<BestBuyOfferResponse> BestBuyOffer(long classid, long instanceidy);

	Task<BestSellOfferResponse> BestSellOffer(long classid, long instanceid);

	Task<BuyOffersResponse> BuyOffers(long classid, long instanceid);

	Task<DeleteOrdersResponse> DeleteOrders();

	Task<GetInvResponse> GetInv();

	Task<GetMySellOffersResponse> GetMySellOffers();

	Task<GetOrdersResponse> GetOrders();

	Task<InventoryItemsResponse> InventoryItems();

	Task<ItemHistoryResponse> ItemHistory(long classid, long instanceid);

	Task<ItemInfoResponse> ItemInfo(long classid, long instanceid);

	Task<ProcessOrderResponse> ProcessOrder(float price, long classid, long instanceid);

	Task<InsertOrderResponse> InsertOrder(long classid, long instanceid, float price);

	Task<UpdateOrderResponse> UpdateOrder(long classid, long instanceid, float price);

	Task<MassInfoResponse> MassInfo(long SELL, long BUY, long HISTORY, long INFO, string list);

	Task<MassInfoStringResponse> MassInfoString(long SELL, long BUY, long HISTORY, long INFO, string list);

	Task<MassSetPriceByIdResponse> MassSetPriceById(List<long> pricesForChange, List<long> uiIdForChange);

	Task<MassSetPriceResponse> MassSetPrice(string name, float price);

	Task<OrderLogResponse> GetOrdersLog();

	Task<SellResponse> SellItem(long classid, long instanceid, float price);

	Task<SetPriceResponse> SetPrice(long ui_id, long price);

	Task<List<TradesResponse>> Trades();

	Task<GetDiscountsResponse> GetDiscounts();

	Task<OperationHistoryResponse> OperationHistory(long start_time, long end_time);

	Task<UpdateInventoryResponse> UpdateInventory();

	Task<PingPongResponse> PingPong();

	Task<ItemRequestOutResponse> ItemRequest(string type, long botid);
}
