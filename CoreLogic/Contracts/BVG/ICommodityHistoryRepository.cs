using CoreLogic.Models;

namespace CoreLogic.Contracts.BVG;

public interface ICommodityHistoryRepository
{
    void Insert(List<CommodityData> commodityData);
}
