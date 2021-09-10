using FiapProduto.Routes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiapProduto.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        [HttpGet(ApiRoutes.Marca.resource)]
        public String Get()
        {
            return "Marca GET";
        }

        //[HttpGet("{id}")]
        //[Route("{id}")]
        [HttpGet(ApiRoutes.Marca.ById)]
        public String GetById(int id)
        {
            return $"Marca GetById {id}";
        }

    }
}
