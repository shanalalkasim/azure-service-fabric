using RVSInventoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RVSSalesActorModel
{
    [DataContract]
    public sealed class RVSSalesActorItem
    {
        public RVSSalesActorItem(InventoryItemId itemId, int quantity)
        {
            this.ItemId = itemId;
            this.Quantity = quantity;
            this.FulfillmentRemaining = quantity;
        }

        [DataMember]
        public InventoryItemId ItemId { get; set; }

        [DataMember]
        public int Quantity { get; set; }

        [DataMember]
        public int FulfillmentRemaining { get; set; }

        public override string ToString()
        {
            return String.Format("ID: {0}, Quantity: {1}, Fulfillment Remaing: {2}", this.ItemId, this.Quantity, this.FulfillmentRemaining);
        }
    }
}
