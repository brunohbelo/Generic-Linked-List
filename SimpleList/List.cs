using SimpleList.Models;

namespace SimpleList
{
    public class List<T> : IList<T>
    {
        private Node<T?> _start = new Node<T?>(default);
        private Node<T?> _end = new Node<T?>(default);
        private bool initialized;

        public void InsertStart(T? item)
        {
            if (!initialized)
            {
                InsertFisrt(item);
            }
            else
            {
                var newItem = new Node<T?>(item);
                newItem.NextItem = _start;
                _start = newItem;
            }
        }

        public void InsertEnd(T? item)
        {
            if (!initialized)
            {
                InsertFisrt(item);
            }
            else
            {
                var newItem = new Node<T?>(item);
                _end.NextItem = newItem;
                _end = newItem;
            }
        }


        public T? Get(int index)
        {
            if (_start.Item == null || index < 0)
                return default;
            if (index == 0)
                return _start.Item;

            var currentItem = _start;
            for (int i = 0; i <= index; i++)
            {
                if (index == i && currentItem != null)
                    return currentItem.Item;
                if (currentItem?.NextItem == null)
                    return default;
                else 
                    currentItem = currentItem.NextItem;
            }

            return default;
        }

        private void InsertFisrt(T? item)
        {
            var newItem = new Node<T?>(item);
            _start = newItem;
            _end = newItem;
            initialized = true;
        }
    }
}
