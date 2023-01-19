//using ApsNetCore6.Models;
//using ApsNetCore6.Repositories;
//using Microsoft.AspNetCore.Mvc;
//using System.Net;
//namespace ApsNetCore6
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CategoriesController : Controller
//    {
//        private ILogger _loger;
//        private readonly ICategoriesRepository _exampleRepository;
//        private readonly IConfiguration _configuration;
//        public CategoriesController(ICategoriesRepository exampleRepository)
//        {
//            _exampleRepository = exampleRepository;
//        }
      
       
//        // GET: api/mymodel
//        [HttpGet("", Name = "GetAll")]
//        //[HttpGet]
//        public IActionResult Get()
//        {
//            try
//            {
//                return Ok(_exampleRepository.GetAll());
//            }
//            catch (Exception exception)
//            {
//                //logg exception or do anything with it
//                return StatusCode((int)HttpStatusCode.InternalServerError);
//            }
//        }

//        // GET api/values/5
//        [HttpGet("{id}", Name = "GetSingle")]
//        public IActionResult Get(int id)
//        {
//            try
//            {
//                if (id<=0)
//                {
//                    return BadRequest();
//                }
//                CategoriesSampleModels myModel = _exampleRepository.GetSingle(id);

//                if (myModel == null)
//                {
//                    return NotFound();
//                }

//                return Ok(myModel);
//            }
//            catch (Exception exception)
//            {
//                //Do something with the exception
//                return StatusCode((int)HttpStatusCode.InternalServerError);
//            }
//        }

//    }
//}
