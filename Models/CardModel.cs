using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CardAccept.Models
{
    public class CardModel
    {
        public int ID { get; set; }
        public string cardNumber { get; set; }
        
        public DateTime expiry { get; set; }
        
        public string cardName {get;set;}
        
        public string cvv { get; set; }


    }
}
