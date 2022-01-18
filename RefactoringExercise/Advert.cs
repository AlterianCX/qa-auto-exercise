using System.Collections.Generic;

namespace RefactoringExercise {
    public class AdvertMessage {
        public int customerId;
        public string contentId;
        public double percentOffNextPurchase;

        public AdvertMessage(int customerId, string contentId, double percentOffNextPurchase) {
            this.customerId = customerId;
            this.contentId = contentId;
            this.percentOffNextPurchase = percentOffNextPurchase;
        }

        public override bool Equals(object? obj)
        {
            var advert = obj as AdvertMessage;

            if (advert == null) {
                return false;
            }

            return advert.customerId == this.customerId 
            && advert.contentId == this.contentId 
            && advert.percentOffNextPurchase == this.percentOffNextPurchase;
        }

        public override int GetHashCode()
        {
            return this.customerId;
        }
    }

    public class Advert {
        public List<Person>? _customers;
        public Offer[] _offers;

        public Advert() {
            this._offers = new Offer[] { new Offer("low-value-customer", "low-value-customer-banner", "low-value-customer-mail-id"),
                new Offer("typical-customer", "typical-customer-banner", "typical-customer-mail-id"),
                new Offer("gold-customer", "gold-customer-banner", "gold-customer-mail-id"),
                new Offer("platinum-customer", "platinum-customer-banner", "platinum-customer-mail-id")
            };
        }

        public void addCustomer(Person person) {
            if (this._customers == null) {
                this._customers = new List<Person>{ person };
            } else {
                this._customers.Add(person);
            }
        }

        public List<AdvertMessage> mail() {
            List<AdvertMessage> mailInstructions = new List<AdvertMessage>();

            for (int i = 0; i < this._customers.Count; i++) {
                if (this._customers[i].purchaseHistory < Person.OneThousand) {
                    if (this._customers[i].numberOfOrders > 10) {
                        mailInstructions.Add(new AdvertMessage(
                            this._customers[i].id,
                            this._offers[0].mailContentId,
                            percentOffNextPurchase: 0.15
                        ));
                    } else {
                        mailInstructions.Add(new AdvertMessage(
                            this._customers[i].id,
                            this._offers[0].mailContentId,
                            0.05
                        ));
                    }
                } else if (this._customers[i].purchaseHistory < Person.FiveThousand) {
                    if (this._customers[i].numberOfOrders > 7) {
                        mailInstructions.Add(new AdvertMessage(
                            this._customers[i].id,
                            this._offers[1].mailContentId,
                            0.175
                        ));
                    } else {
                        mailInstructions.Add(new AdvertMessage(
                            this._customers[i].id,
                            this._offers[1].mailContentId,
                            0.07
                        ));
                    }
                } else if (this._customers[i].purchaseHistory < Person.TenThousand) {
                    if (this._customers[i].numberOfOrders > 4) {
                        mailInstructions.Add(new AdvertMessage(
                            this._customers[i].id,
                        this._offers[2].mailContentId,
                            0.20
                        ));
                    } else {
                        mailInstructions.Add(new AdvertMessage(
                            this._customers[i].id,
                            this._offers[2].mailContentId,
                            0.08
                        ));
                    }
                } else {
                    if (this._customers[i].numberOfOrders > 2) {
                        mailInstructions.Add(new AdvertMessage(
                            this._customers[i].id,
                            this._offers[3].mailContentId,
                            0.25
                        ));
                    } else {
                        mailInstructions.Add(new AdvertMessage(
                            this._customers[i].id,
                            this._offers[3].mailContentId,
                            0.10
                        ));
                    }
                }
            }

            return mailInstructions;
        }

        public List<AdvertMessage> htmlBanner() {
            var htmlInstructions = new List<AdvertMessage>();;
            var amountToDiscountMap = new Dictionary<double, double[]>();
            amountToDiscountMap.Add(Person.OneThousand, new double[] { 0.25, .1 });
            amountToDiscountMap.Add(Person.FiveThousand, new double[] { 0.2, .12 });
            amountToDiscountMap.Add(Person.TenThousand, new double[] { 0.15, .14 });
            amountToDiscountMap.Add(-1, new double[] { 0.1, .16 });

            for (var i = 0; i < this._customers.Count; i++) {
                if (this._customers[i].purchaseHistory < Person.OneThousand) {
                    if (this._customers[i].numberOfOrders > 10) {
                        htmlInstructions.Add(new AdvertMessage(
                            this._customers[i].id,
                            this._offers[0].htmlCONTENTID,
                            amountToDiscountMap[Person.OneThousand][1]
                        ));
                    } else {
                        htmlInstructions.Add(new AdvertMessage(
                            customerId: this._customers[i].id,
                            contentId: this._offers[0].htmlCONTENTID,
                            amountToDiscountMap[Person.OneThousand][0]
                        ));
                    }
                } else if (this._customers[i].purchaseHistory < Person.FiveThousand) {
                    if (this._customers[i].numberOfOrders > 7) {
                        htmlInstructions.Add(new AdvertMessage(
                            customerId: this._customers[i].id,
                            contentId: this._offers[1].htmlCONTENTID,
                            amountToDiscountMap[Person.FiveThousand][1]
                        ));
                    } else {
                        htmlInstructions.Add(new AdvertMessage(
                            customerId: this._customers[i].id,
                            contentId: this._offers[1].htmlCONTENTID,
                            amountToDiscountMap[Person.FiveThousand][0]
                        ));
                    }
                } else if (this._customers[i].purchaseHistory < Person.TenThousand) {
                    if (this._customers[i].numberOfOrders > 4) {
                        htmlInstructions.Add(new AdvertMessage(
                            customerId: this._customers[i].id,
                            contentId: this._offers[2].htmlCONTENTID,
                            amountToDiscountMap[Person.TenThousand][1]
                        ));
                    } else {
                        htmlInstructions.Add(new AdvertMessage(
                            customerId: this._customers[i].id,
                            contentId: this._offers[2].htmlCONTENTID,
                            amountToDiscountMap[Person.TenThousand][0]
                        ));
                    }
                } else {
                    if (this._customers[i].numberOfOrders > 2) {
                        htmlInstructions.Add(new AdvertMessage(
                            customerId: this._customers[i].id,
                            contentId: this._offers[3].htmlCONTENTID,
                            amountToDiscountMap[-1][1]
                        ));
                    } else {
                        htmlInstructions.Add(new AdvertMessage(
                            customerId: this._customers[i].id,
                            contentId: this._offers[3].htmlCONTENTID,
                            amountToDiscountMap[-1][0]
                        ));
                    }
                }
            }

            return htmlInstructions;
        }
    }

}
