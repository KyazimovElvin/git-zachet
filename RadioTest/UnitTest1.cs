using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zachet;
namespace RadioTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ChannelNextCorrect()
        {
            Radio temp = new Radio();
            temp.Channel = 3;
            temp.CH_Next();
            Assert.AreEqual(4, temp.Channel);
        }
        [TestMethod]
        public void ChannelPrivCorrect()
        {
            Radio temp = new Radio();
            temp.Channel = 5;
            temp.CH_Prriv();
            Assert.AreEqual(4, temp.Channel);
        }
        [TestMethod]
        public void Channel_9_to_0()
        {
            Radio temp = new Radio();
            temp.Channel = 9;
            temp.CH_Next();
            Assert.AreEqual(0, temp.Channel);
        }
        [TestMethod]
        public void Channel_0_TO_9()
        {
            Radio temp = new Radio();
            temp.Channel = 0;
            temp.CH_Prriv();
            Assert.AreEqual(9, temp.Channel);
        }
        [TestMethod]
        public void VolumeNextCorrect()
        {
            Radio temp = new Radio();
            temp.Volume = 3;
            temp.Vol_Next();
            Assert.AreEqual(4, temp.Volume);
        }
        public void VolumePrivCorrect()
        {
            Radio temp = new Radio();
            temp.Volume = 3;
            temp.Vol_Priv();
            Assert.AreEqual(2, temp.Volume);
        }
    }
}
