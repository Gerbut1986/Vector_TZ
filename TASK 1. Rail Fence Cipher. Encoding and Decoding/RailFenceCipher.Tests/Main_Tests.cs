namespace RailFenceCipher.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Main_Tests
    {
        [TestMethod]
        public void Encode_Tests()
        {
            string[][] encodes =
            { 
                new[] { "WEAREDISCOVEREDFLEEATONCE", "WECRLTEERDSOEEFEAOCAIVDEN" }, 
                new[] { "Hello, World!", "Hoo!el,Wrdl l" },   
                new[] { "Hello, World!", "H !e,Wdloollr" },    
                new[] { "", "" }                             
            };

            int[] rails = { 3, 3, 4, 3 };

            for (int i = 0; i < encodes.Length; i++)
                Assert.AreEqual(encodes[i][1], RailFenceCipher.Encode(encodes[i][0], rails[i]));
        }

        [TestMethod]
        public void Decode_Tests()
        {
            string[][] decodes =
            {
               new[] { "WECRLTEERDSOEEFEAOCAIVDEN", "WEAREDISCOVEREDFLEEATONCE" },    
               new[] { "H !e,Wdloollr", "Hello, World!" },    
               new[] { "", "" }                            
            };

            int[] rails = { 3, 4, 3 };

            for (int i = 0; i < decodes.Length; i++)
                Assert.AreEqual(decodes[i][1], RailFenceCipher.Decode(decodes[i][0], rails[i]));
        }
    }
}
