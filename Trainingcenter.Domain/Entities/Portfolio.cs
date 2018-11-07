﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Trainingcenter.Domain.Entities
{
    public class Portfolio
    {
        public int PortfolioId { get; set; }
        public int UserId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Goal { get; set; }

        public ICollection<Note> Notes { get; set; }

        public User User { get; set }
    }
}
