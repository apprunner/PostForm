using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PostForm.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Comments { get; set; }
    }
}