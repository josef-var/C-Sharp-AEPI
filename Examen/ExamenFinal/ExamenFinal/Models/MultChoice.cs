using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Models
{
    public class MultChoice
    {
        public int Id { get; set; }
        [Required]
        public string Question { get; set; }
        [Required]
        public string AnswerA { get; set; }
        [Required]
        public bool HasTickA { get; set; }

        public string AnswerB { get; set; }
        public bool HasTickB { get; set; }

        public string AnswerC { get; set; }
        public bool HasTickC { get; set; }

        public string AnswerD { get; set; }
        public bool HasTickD { get; set; }
    }
}