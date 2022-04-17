﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CleanArchMvc.Application.DTOs
{
    public class KeysDTO
    {
        
        
        public KeysDTO(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "The Key is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("Key")]
        public string Key { get; set; }

        [Required(ErrorMessage = "The Key is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("Value")]
        public string Value { get; set; }
    }
}
