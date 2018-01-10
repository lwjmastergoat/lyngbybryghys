using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LyngbyBrygRepo.Models;
using LyngbyBrygRepo;

namespace lyngbybryghys
{
    public class ForsideOptions
    {
        public List<Nyhedstabel> Nyheder { get; set; }
        public List<OmTabel> Omos { get; set; }

    }
}