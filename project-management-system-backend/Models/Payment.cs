﻿namespace project_management_system_backend.Models
{
    public class Payment:BaseModel
    {
        public string Id { get; set; }
        public string Paidby { get; set; }
        public string PaymentType { get; set; }
        public int amount{ get; set; }
        public string attachment { get; set; }



    }
}
