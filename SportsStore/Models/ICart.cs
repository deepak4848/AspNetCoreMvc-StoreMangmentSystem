using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public interface ICart
    {
        IEnumerable<CartLine> Lines { get; }
        void AddItem(Product product, int quantity);
        void RemoveLine(Product product);
        decimal ComputeTotalValue();
        void Clear();

    }
}
