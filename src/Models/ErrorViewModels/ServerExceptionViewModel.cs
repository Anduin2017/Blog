using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aiursoft.Blog.Models.ErrorViewModels
{
    public class ServerExceptionViewModel : ErrorViewModel
    {
        public ServerExceptionViewModel()
        {
            Title = "500 Server Error";
            Description = "This operation caused an error on our server.";
        }
    }
}
