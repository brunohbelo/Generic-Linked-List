using Xunit;

namespace SimpleList.Tests
{
    public class IListTest
    {
        [Fact]
        public void GetShouldReturnRightValueByGivenIndexAfterInsert()
        {
            List<int> list = new List<int>();
            list.InsertStart(0);
            list.InsertStart(1);
            list.InsertStart(2);

            Assert.Equal(0, list.Get(index: 2));
            Assert.Equal(1, list.Get(index: 1));
            Assert.Equal(2, list.Get(index: 0));
        }
        
        [Theory]
        [InlineData(-10)]
        [InlineData(30)]
        public void GetShouldReturnFirstValueGivenWrongIndex(int index)
        {
            List<int> list = new List<int>();
            list.InsertStart(15);
            list.InsertStart(18);
            list.InsertStart(20);

            Assert.Equal(default, list.Get(index));
        }

        [Fact]
        public void InsertEndShouldInsertLastItem()
        {
            List<int> list = new List<int>();
            list.InsertEnd(3);
            list.InsertStart(2);
            list.InsertStart(7);
            list.InsertEnd(15);

            Assert.Equal(15, list.Get(3));
        }
    }
}