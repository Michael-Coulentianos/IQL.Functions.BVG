using CoreLogic.Models;

namespace CoreLogic.Contracts.BVG;

public interface ICurrencyHistoryRepository
{
    void Insert(List<CurrencyPrice> currencyPrice);
}
