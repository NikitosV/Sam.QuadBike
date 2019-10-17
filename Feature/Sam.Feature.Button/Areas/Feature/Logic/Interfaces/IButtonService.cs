using Sam.Feature.Button.Areas.Feature.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sam.Feature.Button.Areas.Feature.Logic.Interfaces
{
    public interface IButtonService
    {
        ButtonViewModel Get(IMvcContext mvcContext);
    }
}
