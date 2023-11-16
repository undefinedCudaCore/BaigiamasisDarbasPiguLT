using NUnit.Framework;
using SeleniumFramework.Pages.PiguLT;
using SeleniumFramework.Pages.PiguLTPage;
using SeleniumTests.BaseTests;

namespace SeleniumTests.PiguLT
{
    internal class OrderStatus : BaseTest
    {
        internal class OrderTestData
        {
            public static string OrderStatus = "Užsakymų nėra.";
        }

        [Test]
        public void OrderStatucCheck()
        {
            OrderPage.ClickInformationButton();
            OrderPage.ClickTrackOrderButton();
            OrderPage.ClickSelectOrderDropdown();
            OrderPage.ClickSelectOrderDropdownValue();

            Assert.That(OrderPage.GetOrderStatus(), Is.EqualTo(OrderTestData.OrderStatus));
        }
    }
}
