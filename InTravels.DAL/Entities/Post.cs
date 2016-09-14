﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTravels.DAL.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public int Likes { get; set; }

        public virtual UserProfile User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}