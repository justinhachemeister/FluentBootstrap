﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FluentBootstrap.Forms
{
    public class Input : FormControl, IHasValueAttribute
    {
        internal Input(BootstrapHelper helper, FormInputType inputType) : base(helper, "input", "form-control")
        {
            MergeAttribute("type", inputType.GetDescription());
        }

        public interface ICreate : ICreateComponent
        {
        }
    }
}