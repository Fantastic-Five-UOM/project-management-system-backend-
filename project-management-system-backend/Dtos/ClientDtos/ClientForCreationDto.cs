﻿namespace project_management_system_backend.Dtos.ClientDtos
{
    public class ClientForCreationDto
    {
        public string ClientName { get; set; }
        public int ClientType { get; set; }
        public string Company { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
    }
}