using NUnit.Framework;
using SeleniumFramework.Pages.PiguLTPage;
using SeleniumTests.BaseTests;

namespace SeleniumTests.PiguLT
{
    internal class OrderPresence : BaseTestWithLogin
    {
        [Test]
        public void OrderStatucCheck()
        {
            OrderPage.ClickInformationButton();
            OrderPage.ClickTrackOrderButton();
            OrderPage.ClickSelectOrderDropdown();
            OrderPage.ClickSelectOrderDropdownValue();

            Assert.That(OrderPage.GetOrderStatus(), Is.EqualTo(TestData.Order.OrderStatus));
        }
    }
}
