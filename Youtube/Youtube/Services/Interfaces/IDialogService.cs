using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube.Services.Interfaces
{
    public interface IDialogService
    {
        Task ShowAlertAsync(string message, string title, string buttonLabel);
    }
}
