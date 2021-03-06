using System;
using StockManagement.Utility.IntegrationEventPublisherSection;

namespace StockManagement.Business.StockSnapshotSection.IntegrationEvent
{
    public class StockCountDecreasedIntegrationEvent : IIntegrationEvent
    {
        public long ProductId { get; }
        public long StockActionId { get; }
        public int Count { get; }
        public int AvailableStock { get;  }
        public DateTime StockUpdatedOn { get; }

        public StockCountDecreasedIntegrationEvent(long productId, long stockActionId, int count, int availableStock, DateTime stockUpdatedOn)
        {
            ProductId = productId;
            StockActionId = stockActionId;
            Count = count;
            AvailableStock = availableStock;
            StockUpdatedOn = stockUpdatedOn;
        }
    }
}