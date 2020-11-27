using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public interface ICrud<T>
    {
        List<T> ItemList();

        void CreateEntity(T Item);

        void UpdateItem(T Item);

    }
}
