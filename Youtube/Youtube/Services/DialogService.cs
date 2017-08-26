using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Youtube.Services.Interfaces;

namespace Youtube.Services
{
    public class DialogService : IDialogService
    {
        public Task ShowAlertAsync(string message, string title, string buttonLabel)
        {

            return UserDialogs.Instance.AlertAsync(message, title, buttonLabel);
        }
    }
}
