/* Copyright 2016 Bouvet ASA 

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License. */

using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Sesam.Templates.CustomDataSource.Controllers
{    
    [Route("api/[controller]")]
    public class EntitiesController : Controller
    {
        private readonly ILogger<EntitiesController> _logger;
        
        // Use dependency injected repository and logger as configured
        // in Startup.cs
        public EntitiesController(ILogger<EntitiesController> logger){
            _logger = logger;
        }
        
        // GET: api/entities
        [HttpPost]
        public void ReceiveEntities()
        {    
            using (StreamReader sr = new StreamReader(Request.Body))
            using (JsonTextReader reader = new JsonTextReader(sr))
            {
                while (reader.Read())
                {
                    if (reader.TokenType == JsonToken.StartObject)
                    {
                        // Load each object from the stream and parse it into dynamic
                        var obj = JsonSerializer.Create().Deserialize<dynamic>(reader);

                        // YOUR CODE GOES HERE
                    }
                }
            }
        }
    }
}
