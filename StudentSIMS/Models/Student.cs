﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace StudentSIMS.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int studentId { get; set; }
        [Required, MaxLength(100)]
        public string firstName { get; set; }
        public string middleName { get; set; }
        [Required]
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public int phoneNumber { get; set; }
        public DateTime timeCreated { get; set; }

        [JsonIgnore]
        public List<Address> addresses { get; set; }
    }
}