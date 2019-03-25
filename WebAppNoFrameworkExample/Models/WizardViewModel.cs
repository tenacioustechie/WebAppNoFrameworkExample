using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppNoFrameworkExample.Models
{
    public class WizardViewModel
    {
        public const string Step1 = "Step1";
        public const string Step2 = "Step2";
        public String Step { get; set; }

        public String PartialView => Step == Step2 ? "_WizardStep2.cshtml" : "_WizardStep1.cshtml";
    }
}
