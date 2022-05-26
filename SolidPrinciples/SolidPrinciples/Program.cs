using System;
namespace SolidPrinciples
{
    public interface Paymentscounter
    {
        public void RecivedPayments(long money);
        public void PaidPayments(long money);
        public void GetStratchCards();
    }
    public interface GetCashBack
    {
        public void CashBack();
    }
    public class PhonePay : Paymentscounter
    {
        public void GetStratchCards()
        {
            Console.WriteLine("You Won Some Sratch Cards in phone pay");
        }

        public void RecivedPayments(long money)
        {
            Console.WriteLine("You Have Recived  Payment from phone pay"+money);
        }
        public void PaidPayments(long money)
        {
            Console.WriteLine("You Have Paid Payment from phone pay" + money);
        }
    }
    public class Paytm : Paymentscounter
    {
        public void GetStratchCards()
        {
            Console.WriteLine("You Won Some Sratch Cards in paytm");
        }

        public void RecivedPayments(long money)
        {
            Console.WriteLine("You Have Recived Some Payment from paytm"+money);
        }
        public void PaidPayments(long money)
        {
            Console.WriteLine("You Have Paid some Payment from paytm" + money);
        }
    }
    public class Gpay : Paymentscounter, GetCashBack
    {
        public void GetStratchCards()
        {
            Console.WriteLine("You Won Some Sratch Cards in Gpay");
        }

        public void RecivedPayments(long money)
        {
            Console.WriteLine("You Have Recived Some Payment to Gpay" + money);
        }
        public void PaidPayments(long money)
        {
            Console.WriteLine("You Have Paid Some Payment from Gpay" + money);
        }
        public void CashBack()
        {
            Console.WriteLine("You won Some money");
        }
    }
    internal class program
    {
        static void Main(String[] args)
        {
            Paymentscounter paytm = new Paytm();
            paytm.GetStratchCards();
            paytm.RecivedPayments(5000);
            paytm.PaidPayments(10000);

            PhonePay phonePay = new PhonePay();
            phonePay.GetStratchCards();
            phonePay.PaidPayments(1000);
            phonePay.RecivedPayments(20000);
            phonePay.GetStratchCards();

            Gpay gpay = new Gpay();
            gpay.GetStratchCards();
            gpay.PaidPayments(300);
            gpay.RecivedPayments(2000);



        }
    }
    
}