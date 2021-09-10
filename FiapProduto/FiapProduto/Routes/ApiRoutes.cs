using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapProduto.Routes
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Controller = Root + "/" + "[controller]";
        public const string BaseId = "/{id}";

        public static class Marca
        {
            public const string resource = Controller;
            public const string ById = resource + BaseId;
        }
    }
}
