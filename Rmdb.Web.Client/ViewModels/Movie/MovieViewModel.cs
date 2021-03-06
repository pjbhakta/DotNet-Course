﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rmdb.Web.Client.ViewModels.Movie
{
    public class MovieViewModel
    {
        public Guid Id { get; set; }

        [DisplayName("Titel")]
        public string Title { get; set; }

        [DisplayName("Score")]
        public double Score { get; set; }

       
        [DisplayName("Premiere")]
        public string ReleaseDate { get; set; }

    }
}
