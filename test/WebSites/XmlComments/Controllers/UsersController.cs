using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using XmlComments.Models;

namespace XmlComments.Controllers
{
    /// <summary>
    /// Manage users
    /// </summary>
    /// <response code="default">Unexpected error</response>
    [ApiController]
    [Route("[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class UsersController : ControllerBase
    {
        /// <summary>
        /// Create a user
        /// </summary>
        /// <remarks>
        /// Creates a new user in the system with the provided `username`  
        /// </remarks>
        /// <param name="user">The user details</param>
        /// <response code="200">User created</response>
        /// <response code="400">Invalid request</response>
        [HttpPost]
        public int CreateUser([FromBody, Required]User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieve all users
        /// </summary>
        /// <remarks>
        /// Lists all users in the system
        /// </remarks>
        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Search users by keywords
        /// </summary>
        /// <remarks>
        /// Supports pagination through the `PageNo` and `PageSize` parameters
        /// </remarks>
        /// <param name="keywords" example="foobar">The search keywords</param>
        [HttpGet("search")]
        public IEnumerable<User> SearchUsers([FromQuery]string keywords, [FromQuery]PagingParams pagingParams)
        {
            throw new NotImplementedException();
        }
    }
}
