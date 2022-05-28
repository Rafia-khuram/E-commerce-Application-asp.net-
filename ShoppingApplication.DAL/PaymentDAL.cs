using ShoppingApplication.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.DAL
{
    public class PaymentDAL
    {
        private readonly ShoppingContext db = new ShoppingContext();
        public List<Payment> GetPayments()
        {
            return db.Payments.ToList();
        }
        public void AddPaymentStatus(PaymentStatus PaymentStatus)
        {
            db.PaymentStatuses.Add(PaymentStatus);
            db.SaveChanges();
        }
        public PaymentStatus GetPaymentStatus(int Id)
        {
            return db.PaymentStatuses.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditPaymentStatus(PaymentStatus paymentStatus)
        {
            var DbPaymentStatus = db.PaymentStatuses.Where(x => x.Id == paymentStatus.Id).FirstOrDefault();
            if (DbPaymentStatus != null)
            {
                if (!String.IsNullOrEmpty(paymentStatus.Name))
                {
                    DbPaymentStatus.Name = paymentStatus.Name;
                }
            }
            db.SaveChanges();
        }
        public void DeletePaymentStatus(int Id)
        {
            db.PaymentStatuses.Remove(db.PaymentStatuses.Find(Id));
            db.SaveChanges();
        }
        public List<PaymentStatus> GetPaymentStatuses()
        {
            return db.PaymentStatuses.ToList();
        }
        public void AddPayment(Payment payment)
        {
            db.Payments.Add(payment);
            db.SaveChanges();
        }
        public Payment GetPayment(int Id)
        {
            return db.Payments.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditPayment(Payment payment)
        {
            var DbPayment = db.Payments.Where(x => x.Id == payment.Id).FirstOrDefault();
            if (DbPayment != null)
            {
                if (!String.IsNullOrEmpty(payment.OrderId.ToString()))
                {
                    DbPayment.OrderId = payment.OrderId;
                }
                if (!String.IsNullOrEmpty(payment.PaymentStatusId.ToString()))
                {
                    DbPayment.PaymentStatusId = payment.PaymentStatusId;
                }
            }
            db.SaveChanges();
        }
        public void DeletePayment(int Id)
        {
            db.Payments.Remove(db.Payments.Find(Id));
            db.SaveChanges();
        }
    }
}
