using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.NetCore.Domain;
using AutoMapper;
using WebApp.NetCore.Application.ViewModels;

namespace WebApp.NetCore.Application.Controllers
{
    [Route("")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly INumeroExtensoService _numeroExtenso;

        IMapper _mapper;

        public ValuesController(INumeroExtensoService numeroExtenso, IMapper mapper)
        {
            _numeroExtenso = numeroExtenso;
            _mapper = mapper;
        }
        // GET api/values
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var numeroExtensoViewModel = _mapper.Map<NumeroExtenso>(_numeroExtenso.Validar(id));

            return new JsonResult(numeroExtensoViewModel);
        }
        
    }
}
