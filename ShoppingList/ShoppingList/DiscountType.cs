using System;

namespace Shopping
{
    public partial class Discount
    {
        public enum DiscountType
        {
            None,
            Quantity,
            TenPack,
            PriceOff,
            Free
        }

        public bool IsQuantity(Discount discount) => discount.type == DiscountType.Quantity;

        public bool IsTenPack(Discount discount) => discount.type == DiscountType.TenPack;

        public bool IsPriceOff(Discount discount) => discount.type == DiscountType.PriceOff;

        public bool IsFree(Discount discount) => discount.type == DiscountType.Free;
    }
}