using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Sockets;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace AlimentosSantiagoDesktop.Utilidades
{
    public class HttpManager
    {
        public static readonly HttpClient client = new HttpClient();
        public const string restUrl = "http://localhost:8084/AlimentosSantiagoREST/rest/";
        public const string testUrl = "https://webhook.site/c903c53a-2608-4264-8548-f7427960b657";

        public static Task<string> PeticionGetSimple(string url)
        {
            var respuesta = client.GetAsync(restUrl + url).Result;
            if (respuesta.IsSuccessStatusCode)
                return respuesta.Content.ReadAsStringAsync();

            return null;
        }

        public static Task<String> SimplePost<T>(string url, T t)
        {
            var respuesta = client.PostAsJsonAsync<T>(restUrl + url, t);
            try
            {
                var mensaje = respuesta.Result;
                if (mensaje.IsSuccessStatusCode)
                    return mensaje.Content.ReadAsStringAsync();

                Debug.WriteLine("Codigo: " + mensaje.RequestMessage + "\n" + mensaje.StatusCode);
            }
            catch (SocketException)
            {
                Debug.WriteLine("Conexión denegada");
            }
            catch (NullReferenceException)
            {
                Debug.WriteLine("No se pudo establecer la conexión");
            }

            return null;
        }

        public static bool PostDescerializar<T>(string url, ref T t)
        {
            try
            {
                string respuesta = SimplePost<T>(url, t).Result;
                t = JsonConvert.DeserializeObject<T>(respuesta);
                return true;
            }
            catch (SocketException)
            {
                MessageBox.Show("Error para conectarse");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error para cargar nuevamente el objeto");
            }
            return false;
        }

        public static List<T> GetListar<T>(string path)
        {
            List<T> lista = new List<T>();
            var respuesta = client.GetAsync(restUrl + path);

            try
            {
                if (!respuesta.Result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Problemas de conexión");
                    return new List<T>();
                }
            } catch (Exception exc)
            {
                if (exc is System.Net.WebException | exc is SocketException)
                {
                    MessageBox.Show("El servidor está apagado, contacte el administrador.");
                    Application.Exit();
                }
                return new List<T>();
            }
            Debug.WriteLine(restUrl + path);
            var contenido = respuesta.Result.Content;
            Debug.WriteLine(contenido.ReadAsStringAsync().Result);
            lista = JsonConvert.DeserializeObject<List<T>>(contenido.ReadAsStringAsync().Result);
            return lista;
        }

        public static void ListarDataGrid<T>(string url, ref DataGridView tabla, out List<T> lista)
        {
            lista = new List<T>();
            lista = GetListar<T>(url);
            if (lista.Count == 0)
                MessageBox.Show("No se pudieron encontrar datos para la entidad");
            else
                tabla.DataSource = lista;
        }

        public static bool SimplePut<T>(string url, T t)
        {
            var resultado = client.PutAsJsonAsync<T>(restUrl + url, t).Result;
            if (resultado.IsSuccessStatusCode)
            {
                Debug.WriteLine("Solicitud PUT exitosa");
                string result = resultado.Content.ReadAsStringAsync().Result;
                Debug.WriteLine(result);
                return result == "true";
            }
            return false;
        }

        public static void SimplePut<T>(string url, string id, T t)
        {
            string putUrl = restUrl + url + "/{" + id + "}";
            HttpResponseMessage respuesta = client.PutAsJsonAsync<T>(testUrl, t).Result;
            if (respuesta.IsSuccessStatusCode)
            {
                MessageBox.Show("Actualización de " + t.GetType().Name);
            }
        }

        public static bool SimpleDelete(string url, string id)
        {
            string deleteUrl = restUrl + url + "/" + id;
            HttpResponseMessage respuesta = client.DeleteAsync(deleteUrl).Result;
            if (respuesta.IsSuccessStatusCode)
            {
                return Convert.ToBoolean(respuesta.Content.ReadAsStringAsync().Result);
            }
            //loli
            return false;
        }
    }
}
