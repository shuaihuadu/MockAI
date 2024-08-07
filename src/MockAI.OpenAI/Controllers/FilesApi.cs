/*
 * OpenAI API
 *
 * The OpenAI REST API. Please see https://platform.openai.com/docs/api-reference for more details.
 *
 * OpenAPI spec version: 2.1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class FilesApiController : ControllerBase
    { 

        /// <summary>
        /// Delete a file.
        /// </summary>
        /// <param name="fileId">The ID of the file to use for this request.</param>
        /// <response code="200">OK</response>
        [HttpDelete]
        [Route("/v1/files/{file_id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("DeleteFile")]
        [SwaggerResponse(statusCode: 200, type: typeof(DeleteFileResponse), description: "OK")]
        public virtual IActionResult DeleteFile([FromRoute][Required]string fileId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(DeleteFileResponse));
            string exampleJson = null;
            exampleJson = "{\n  \"deleted\" : true,\n  \"id\" : \"id\",\n  \"object\" : \"file\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<DeleteFileResponse>(exampleJson)
                        : default(DeleteFileResponse);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Returns the contents of the specified file.
        /// </summary>
        /// <param name="fileId">The ID of the file to use for this request.</param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v1/files/{file_id}/content")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("DownloadFile")]
        [SwaggerResponse(statusCode: 200, type: typeof(string), description: "OK")]
        public virtual IActionResult DownloadFile([FromRoute][Required]string fileId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(string));
            string exampleJson = null;
            exampleJson = "\"\"";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<string>(exampleJson)
                        : default(string);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Returns a list of files that belong to the user&#x27;s organization.
        /// </summary>
        /// <param name="purpose">Only return files with the given purpose.</param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v1/files")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ListFiles")]
        [SwaggerResponse(statusCode: 200, type: typeof(ListFilesResponse), description: "OK")]
        public virtual IActionResult ListFiles([FromQuery]string purpose)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ListFilesResponse));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : [ {\n    \"filename\" : \"filename\",\n    \"purpose\" : \"assistants\",\n    \"bytes\" : 0,\n    \"created_at\" : 6,\n    \"id\" : \"id\",\n    \"status_details\" : \"status_details\",\n    \"object\" : \"file\",\n    \"status\" : \"uploaded\"\n  }, {\n    \"filename\" : \"filename\",\n    \"purpose\" : \"assistants\",\n    \"bytes\" : 0,\n    \"created_at\" : 6,\n    \"id\" : \"id\",\n    \"status_details\" : \"status_details\",\n    \"object\" : \"file\",\n    \"status\" : \"uploaded\"\n  } ],\n  \"object\" : \"list\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ListFilesResponse>(exampleJson)
                        : default(ListFilesResponse);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Returns information about a specific file.
        /// </summary>
        /// <param name="fileId">The ID of the file to use for this request.</param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v1/files/{file_id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("RetrieveFile")]
        [SwaggerResponse(statusCode: 200, type: typeof(OpenAIFile), description: "OK")]
        public virtual IActionResult RetrieveFile([FromRoute][Required]string fileId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(OpenAIFile));
            string exampleJson = null;
            exampleJson = "{\n  \"filename\" : \"filename\",\n  \"purpose\" : \"assistants\",\n  \"bytes\" : 0,\n  \"created_at\" : 6,\n  \"id\" : \"id\",\n  \"status_details\" : \"status_details\",\n  \"object\" : \"file\",\n  \"status\" : \"uploaded\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<OpenAIFile>(exampleJson)
                        : default(OpenAIFile);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
