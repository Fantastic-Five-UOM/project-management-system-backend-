﻿namespace project_management_system_backend.Models
{
    public class DocumentDetailsDto
    {
        public int DocumentId { get; set; }
        public string Name { get; set; }
        public string ActualFileName { get; set; }
        public string Type { get; set; }
        public string ClientName { get; set; }
        public string Company { get; set; }
        public DateTime Date { get; set; }
        public string ProjectName { get; set; }
    }
}