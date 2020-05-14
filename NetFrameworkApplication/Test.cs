using ConsumingClassLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NetFrameworkApplication
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void CanUseNetStandardLib()
        {
            new AvaTaxWrapper();
        }
    }
}
