namespace SimpleList
{
    public interface IList<T>
    {
        public void InsertStart(T? item);
        public void InsertEnd(T? item);
        public T? Get(int index);
        
    }
}
