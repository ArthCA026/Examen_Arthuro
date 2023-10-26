using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Json;
using System.Web.Mvc;
using ExamenWEB.Entitites;

namespace ExamenWEB.Models
{
    public class ModelEstudiante
    {
        public string urlApi = ConfigurationManager.AppSettings["urlApi"];

        public string AgregarMatricula(EstudianteEnt entidad)
        {
            try { 
            using (var client = new HttpClient())
            {
                string url = urlApi + "Agregar matricula";
                JsonContent contenido = JsonContent.Create(entidad);
                var resp = client.PostAsync(url, contenido).Result;
                return resp.Content.ReadFromJsonAsync<string>().Result;
            }
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}