using Microsoft.VisualStudio.TestTools.UnitTesting;
using RefactoringExercise;
using System.Collections.Generic;

namespace Tests;

[TestClass]
public class AdvertTests
{
    public static Person lowValueLowRepeatPurchaseCustomer = new Person(1, "John Smith", 100, 10);
    public static Person lowValueMultiplePurchaseCustomer = new Person(2, "Helena Gerardo", 999, 11);
    public static Person mediumValueLowRepeatPurchaseCustomer = new Person(3, "Ursule Agatka", 1000, 7);
    public static Person mediumValueMultiplePurchaseCustomer = new Person(4, "Adalwin Hadubert", 4999, 8);
    public static Person highValueLowRepeatPurchaseCustomer = new Person(5, "Dileep Xhemal", 5000, 4);
    public static Person highValueMultiplePurchaseCustomer = new Person(6, "Kike Brynhildr", 9999, 5);
    public static Person executiveValueLowRepeatPurchaseCustomer = new Person(7, "Adenike Xquenda", 10000, 2);
    public static Person executiveValueMultiplePurchaseCustomer = new Person(8, "Dinesh Malak", 25000, 3);

    [TestClass]
    public class MailOffers
    {
        [TestClass]
        public class ForLowRepeatOrderCustomers
        {

            [TestMethod]
            public void ShouldOffer5PercentOffForALowValueCustomer()
            {
                var expectedOutcome = new List<AdvertMessage>();
                expectedOutcome.Add(new AdvertMessage(AdvertTests.lowValueLowRepeatPurchaseCustomer.id, "low-value-customer-mail-id", 0.05));
                var advert = new Advert();
                advert.addCustomer(AdvertTests.lowValueLowRepeatPurchaseCustomer);
                Assert.AreEqual(expectedOutcome.First(), advert.mail().First());
            }

            [TestMethod]
            public void ShouldOffer7PercentOffForAMediumValueCustomer()
            {
                var expectedOutcome = new List<AdvertMessage>();
                expectedOutcome.Add(new AdvertMessage(AdvertTests.mediumValueLowRepeatPurchaseCustomer.id, "typical-customer-mail-id", 0.07));
                var advert = new Advert();
                advert.addCustomer(AdvertTests.mediumValueLowRepeatPurchaseCustomer);
                Assert.AreEqual(expectedOutcome.First(), advert.mail().First());
            }

            [TestMethod]
            public void ShouldOffer8PercentOffForAHighValueCustomer()
            {
                var expectedOutcome = new List<AdvertMessage>();
                expectedOutcome.Add(new AdvertMessage(AdvertTests.highValueLowRepeatPurchaseCustomer.id, "gold-customer-mail-id", 0.08));
                var advert = new Advert();
                advert.addCustomer(AdvertTests.highValueLowRepeatPurchaseCustomer);
                Assert.AreEqual(expectedOutcome.First(), advert.mail().First());
            }

            [TestMethod]
            public void ShouldOffer10PercentOffForAExecutiveValueCustomer()
            {
                var expectedOutcome = new List<AdvertMessage>();
                expectedOutcome.Add(new AdvertMessage(AdvertTests.executiveValueLowRepeatPurchaseCustomer.id, "platinum-customer-mail-id", 0.10));
                var advert = new Advert();
                advert.addCustomer(AdvertTests.executiveValueLowRepeatPurchaseCustomer);
                Assert.AreEqual(expectedOutcome.First(), advert.mail().First());
            }

        }

        [TestClass]
        public class ForHighRepeatOrderCustomers
        {

            [TestMethod]
            public void ShouldOffer15PercentOffForALowValueCustomer()
            {
                var expectedOutcome = new List<AdvertMessage>();
                expectedOutcome.Add(new AdvertMessage(AdvertTests.lowValueMultiplePurchaseCustomer.id, "low-value-customer-mail-id", 0.15));
                var advert = new Advert();
                advert.addCustomer(AdvertTests.lowValueMultiplePurchaseCustomer);
                Assert.AreEqual(expectedOutcome.First(), advert.mail().First());
            }

            [TestMethod]
            public void ShouldOffer17andHalfPercentOffForAMediumValueCustomer()
            {
                var expectedOutcome = new List<AdvertMessage>();
                expectedOutcome.Add(new AdvertMessage(AdvertTests.mediumValueMultiplePurchaseCustomer.id, "typical-customer-mail-id", 0.175));
                var advert = new Advert();
                advert.addCustomer(AdvertTests.mediumValueMultiplePurchaseCustomer);
                Assert.AreEqual(expectedOutcome.First(), advert.mail().First());
            }

            [TestMethod]
            public void ShouldOffer20PercentOffForAHighValueCustomer()
            {
                var expectedOutcome = new List<AdvertMessage>();
                expectedOutcome.Add(new AdvertMessage(AdvertTests.highValueMultiplePurchaseCustomer.id, "gold-customer-mail-id", 0.20));
                var advert = new Advert();
                advert.addCustomer(AdvertTests.highValueMultiplePurchaseCustomer);
                Assert.AreEqual(expectedOutcome.First(), advert.mail().First());
            }

            [TestMethod]
            public void ShouldOffer25PercentOffForALowValueCustomer()
            {
                var expectedOutcome = new List<AdvertMessage>();
                expectedOutcome.Add(new AdvertMessage(AdvertTests.executiveValueMultiplePurchaseCustomer.id, "platinum-customer-mail-id", 0.25));
                var advert = new Advert();
                advert.addCustomer(AdvertTests.executiveValueMultiplePurchaseCustomer);
                Assert.AreEqual(expectedOutcome.First(), advert.mail().First());
            }

        }
    }

        [TestClass]
    public class HtmlOffers
    {
        [TestClass]
        public class ForLowRepeatOrderCustomers
        {

            [TestMethod]
            public void ShouldOffer25PercentOffForALowValueCustomer()
            {
                var expectedOutcome = new List<AdvertMessage>();
                expectedOutcome.Add(new AdvertMessage(AdvertTests.lowValueLowRepeatPurchaseCustomer.id, "low-value-customer-banner", 0.25));
                var advert = new Advert();
                advert.addCustomer(AdvertTests.lowValueLowRepeatPurchaseCustomer);
                Assert.AreEqual(expectedOutcome.First(), advert.htmlBanner().First());
            }

            [TestMethod]
            public void ShouldOffer20PercentOffForAMediumValueCustomer()
            {
                var expectedOutcome = new List<AdvertMessage>();
                expectedOutcome.Add(new AdvertMessage(AdvertTests.mediumValueLowRepeatPurchaseCustomer.id, "typical-customer-banner", 0.20));
                var advert = new Advert();
                advert.addCustomer(AdvertTests.mediumValueLowRepeatPurchaseCustomer);
                Assert.AreEqual(expectedOutcome.First(), advert.htmlBanner().First());
            }

            [TestMethod]
            public void ShouldOffer15PercentOffForAHighValueCustomer()
            {
                var expectedOutcome = new List<AdvertMessage>();
                expectedOutcome.Add(new AdvertMessage(AdvertTests.highValueLowRepeatPurchaseCustomer.id, "gold-customer-banner", 0.15));
                var advert = new Advert();
                advert.addCustomer(AdvertTests.highValueLowRepeatPurchaseCustomer);
                Assert.AreEqual(expectedOutcome.First(), advert.htmlBanner().First());
            }

            [TestMethod]
            public void ShouldOffer10PercentOffForAExecutiveValueCustomer()
            {
                var expectedOutcome = new List<AdvertMessage>();
                expectedOutcome.Add(new AdvertMessage(AdvertTests.executiveValueLowRepeatPurchaseCustomer.id, "platinum-customer-banner", 0.10));
                var advert = new Advert();
                advert.addCustomer(AdvertTests.executiveValueLowRepeatPurchaseCustomer);
                Assert.AreEqual(expectedOutcome.First(), advert.htmlBanner().First());
            }

        }

        [TestClass]
        public class ForHighRepeatOrderCustomers
        {

            [TestMethod]
            public void ShouldOffer10PercentOffForALowValueCustomer()
            {
                var expectedOutcome = new List<AdvertMessage>();
                expectedOutcome.Add(new AdvertMessage(AdvertTests.lowValueMultiplePurchaseCustomer.id, "low-value-customer-banner", 0.10));
                var advert = new Advert();
                advert.addCustomer(AdvertTests.lowValueMultiplePurchaseCustomer);
                Assert.AreEqual(expectedOutcome.First(), advert.htmlBanner().First());
            }

            [TestMethod]
            public void ShouldOffer12PercentOffForAMediumValueCustomer()
            {
                var expectedOutcome = new List<AdvertMessage>();
                expectedOutcome.Add(new AdvertMessage(AdvertTests.mediumValueMultiplePurchaseCustomer.id, "typical-customer-banner", 0.12));
                var advert = new Advert();
                advert.addCustomer(AdvertTests.mediumValueMultiplePurchaseCustomer);
                Assert.AreEqual(expectedOutcome.First(), advert.htmlBanner().First());
            }

            [TestMethod]
            public void ShouldOffer14PercentOffForAHighValueCustomer()
            {
                var expectedOutcome = new List<AdvertMessage>();
                expectedOutcome.Add(new AdvertMessage(AdvertTests.highValueMultiplePurchaseCustomer.id, "gold-customer-banner", 0.14));
                var advert = new Advert();
                advert.addCustomer(AdvertTests.highValueMultiplePurchaseCustomer);
                Assert.AreEqual(expectedOutcome.First(), advert.htmlBanner().First());
            }

            [TestMethod]
            public void ShouldOffer16PercentOffForAExecutiveValueCustomer()
            {
                var expectedOutcome = new List<AdvertMessage>();
                expectedOutcome.Add(new AdvertMessage(AdvertTests.executiveValueMultiplePurchaseCustomer.id, "platinum-customer-banner", 0.16));
                var advert = new Advert();
                advert.addCustomer(AdvertTests.executiveValueMultiplePurchaseCustomer);
                Assert.AreEqual(expectedOutcome.First(), advert.htmlBanner().First());
            }

        }
    }

}