using CoreLogic.Contracts.BVG;
using CoreLogic.Services.Commands;
using MediatR;

namespace CoreLogic.Services.Handlers;

public class CommodityHandler : IRequestHandler<CommodityPriceFeedCommand, Task>
{
    private readonly ICommodityHistoryRepository CommodityHistoryRepository;
    public CommodityHandler(ICommodityHistoryRepository commodityHistoryRepository)
    {
        CommodityHistoryRepository = commodityHistoryRepository;
    }
    //public async Task<Task> Handle(CommodityPriceFeedCommand request, CancellationToken cancellationToken)
    //{
    //    var commodities = CommodityRepository.SelectAll();
    //    var filteredCommodityData = request.Commodities.commodityData.Where(f => commodities.Select(c => c.Label).Contains(f.Instrument)).ToList();

    //    foreach (var item in filteredCommodityData)
    //    {
    //        item.CommodityId = commodities.Where(f => f.Label == item.Instrument).Select(s => s.Id).FirstOrDefault();
    //    }

    //    CommodityHistoryRepository.Insert(filteredCommodityData);
    //    return Task.CompletedTask;
    //}

    public async Task<Task> Handle(CommodityPriceFeedCommand request, CancellationToken cancellationToken)
    {
        CommodityHistoryRepository.Insert(request.Commodities.commodityData);
        return Task.CompletedTask;
    }
}
