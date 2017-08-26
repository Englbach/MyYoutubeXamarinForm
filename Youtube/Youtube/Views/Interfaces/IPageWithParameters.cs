using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube.Views.Interfaces
{
    public interface IPageWithParameters
    {
        void InitializeWith(object parameter);
    }
}
