using System.Text.Json;
using TrayectoriaEducativaGraficas.Models;

namespace TrayectoriaEducativaGraficas.Services
{
    public class ObtenerEvaluacionRIMAService : IObtenerEvaluacionRIMAService
    {
        public async Task<RimaEvaluacion> ObtenerEvaluacionRIMA()
        {
            await Task.Delay(1000);

            string jsonString = GetSampleJson();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            RimaEvaluacion evaluacion = JsonSerializer.Deserialize<RimaEvaluacion>(jsonString, options);

            return evaluacion;
        }

        private string GetSampleJson()
        {
			return @"
            {
              ""camposFormativos"": [
                {
                  ""nombre"": ""Hab.Socioemocionales"",
                  ""resultado"": ""Alto"",
                  ""unidadesAnalisis"": [
                    {
                      ""nombre"": ""Comprensión lectora"",
                      ""nivelDesempeno"": ""Competente""
                    },
                    {
                      ""nombre"": ""Producción de textos"",
                      ""nivelDesempeno"": ""En desarrollo""
                    }
                  ]
                },
                {
                  ""nombre"": ""Intereses"",
                  ""resultado"": ""En desarrollo"",
                  ""unidadesAnalisis"": [
                    {
                      ""nombre"": ""Sentido numérico y pensamiento algebraico"",
                      ""nivelDesempeno"": ""Requiere apoyo""
                    },
                    {
                      ""nombre"": ""Forma, espacio y medida"",
                      ""nivelDesempeno"": ""En desarrollo""
                    },
                    {
                      ""nombre"": ""Manejo de la información"",
                      ""nivelDesempeno"": ""Competente""
                    }
                  ]
                },
                {
                  ""nombre"": ""Ciencias"",
                  ""resultado"": ""Desarrollo esperado"",
                  ""unidadesAnalisis"": [
                    {
                      ""nombre"": ""Comprensión del medio natural"",
                      ""nivelDesempeno"": ""Competente""
                    },
                    {
                      ""nombre"": ""Aplicación del método científico"",
                      ""nivelDesempeno"": ""En desarrollo""
                    }
                  ]
                },
                {
                  ""nombre"": ""Matemáticas"",
                  ""dimensiones"": [
                    {
                      ""nombre"": ""Autoconocimiento"",
                      ""nivel"": ""Alto"",
                      ""descripcion"": ""Reconoce y comprende sus propias emociones y pensamientos."",
                      ""recomendaciones"": ""Fomentar actividades de reflexión y autoevaluación.""
                    },
                    {
                      ""nombre"": ""Autonomía"",
                      ""nivel"": ""Medio"",
                      ""descripcion"": ""Demuestra capacidad para tomar decisiones independientes."",
                      ""recomendaciones"": ""Incentivar la responsabilidad en tareas cotidianas.""
                    },
                    {
                      ""nombre"": ""Empatía"",
                      ""nivel"": ""Alto"",
                      ""descripcion"": ""Muestra sensibilidad hacia los sentimientos de los demás."",
                      ""recomendaciones"": ""Promover la participación en actividades de voluntariado.""
                    },
                    {
                      ""nombre"": ""Colaboración"",
                      ""nivel"": ""Bajo"",
                      ""descripcion"": ""Tiene dificultades para trabajar en equipo."",
                      ""recomendaciones"": ""Integrar en proyectos grupales que requieran cooperación.""
                    },
                    {
                      ""nombre"": ""Autorregulación"",
                      ""nivel"": ""Medio"",
                      ""descripcion"": ""Controla sus emociones en situaciones habituales."",
                      ""recomendaciones"": ""Practicar técnicas de manejo del estrés.""
                    }
                  ]
                },
                {
                  ""nombre"": ""Lenguajes"",
                  ""areasInteres"": [
                    {
                      ""nombre"": ""Artista"",
                      ""descripcion"": ""Interés por la expresión creativa y las artes."",
                      ""recomendaciones"": ""Participar en clases de música o pintura.""
                    },
                    {
                      ""nombre"": ""Emprendedor"",
                      ""descripcion"": ""Aptitud para liderar y gestionar proyectos."",
                      ""recomendaciones"": ""Fomentar la participación en clubes de emprendimiento.""
                    },
                    {
                      ""nombre"": ""Social"",
                      ""descripcion"": ""Deseo de ayudar y trabajar con otras personas."",
                      ""recomendaciones"": ""Involucrarse en actividades comunitarias.""
                    }
                  ]
                },
                {
                  ""nombre"": ""Cuestionario de contexto"",
                  ""preguntas"": [
                    {
                      ""texto"": ""¿Cuántas horas al día dedicas al estudio?"",
                      ""respuesta"": ""Entre 2 y 3 horas.""
                    },
                    {
                      ""texto"": ""¿Tienes acceso a internet en tu hogar?"",
                      ""respuesta"": ""Sí.""
                    },
                    {
                      ""texto"": ""¿Participas en actividades extracurriculares?"",
                      ""respuesta"": ""Sí, en el equipo de fútbol.""
                    }
                  ]
                }
              ]
            }";
		}
    }
}
