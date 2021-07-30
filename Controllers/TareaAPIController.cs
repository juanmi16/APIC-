using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareaAPI.Models;

namespace TareaAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[Controller]")]
    public class TareaAPIController : Controller
    {
        List<Modelo> listaModelos = new List<Modelo>();
        List<Vehiculo> listaVehiculo = new List<Vehiculo>();

        [HttpPost("crearModelo")]
        [Route("crearModelo")]
        public ActionResult CrearModelo([FromBody] Modelo modelo)
        {
            try
            {
                guardarModelo(modelo);

                return CreatedAtAction(nameof(CrearModelo), new { id = modelo.IdModelo }, listaModelos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("crearVehiculo")]
        [Route("crearVehiculo")]
        public ActionResult CrearVehiculo([FromBody] Vehiculo vehiculo)
        {
            try
            {
                if(listaVehiculo.Count != 0)
                {
                    for (int i = 0; i > listaModelos.Count; i++)
                    {
                        if (listaModelos[i].IdModelo == vehiculo.IdModelo)
                        {
                            guardarVehiculo(vehiculo);
                        }
                    }
                }
                else
                {

                    guardarVehiculo(vehiculo);

                }

                //if (existe == false)
                //{
                //    return null;
                //}

                return CreatedAtAction(nameof(CrearModelo), new { id = vehiculo.PlacaVehiculo }, vehiculo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public void guardarModelo(Modelo modelo)
        {
            listaModelos.Add(modelo);
        }
        
        public void guardarVehiculo(Vehiculo vehiculo)
        {
            listaVehiculo.Add(vehiculo);
        }
    }
}
