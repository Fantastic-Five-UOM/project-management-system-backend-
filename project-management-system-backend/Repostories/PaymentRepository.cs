﻿using project_management_system_backend.Data;
using project_management_system_backend.Models;

namespace project_management_system_backend.Repostories
{
    public class PaymentRepository:IPaymentRepository
    {
        private readonly ApiDbContext _context;

        public PaymentRepository(ApiDbContext context)
        {
            _context = context;
        }
        public async Task<List<Payment>> GetAllPaymentsDetails()
        {
            var paymentList = _context.payment.ToList();
            return paymentList;
        }
        public async Task<Payment> GetPaymentById(string Id)
        {
            var payment = _context.payment.Where(x => x.Id == Id).FirstOrDefault();
            return payment;
        }
        public async Task<Payment> CreatePayment(Payment payment)
        {
            _context.payment.Add(payment);
            _context.SaveChanges();
            return payment;
        }
        public async Task<Payment> Updatepayment(Payment payment)
        {
            var paymentToUpdate = GetPaymentById(payment.Id).Result;
            paymentToUpdate.Paidby = payment.Paidby;
            paymentToUpdate.PaymentType = payment.PaymentType;
            paymentToUpdate.amount = payment.amount;
            paymentToUpdate.attachment = payment.attachment;
            paymentToUpdate.Created = payment.Created;
            paymentToUpdate.Updated = payment.Updated;
            paymentToUpdate.IsDeleted = payment.IsDeleted;
            paymentToUpdate.Deleted = payment.Deleted;
            _context.payment.Update(paymentToUpdate );
            _context.SaveChanges();
            return payment;
        }
    }
}
