using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalksAPI.Models.Domain;
using NZWalksAPI.Repositories;

namespace NZWalksAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WalksController : ControllerBase
    {
        private readonly IWalkRepository walkRepository;
        private readonly IMapper mapper;

        public WalksController(IWalkRepository walkRepository, IMapper mapper)
        {
            this.walkRepository = walkRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllWalk()
        {
            var walks = await walkRepository.GetAllAsync();
            var WalkDTO = mapper.Map<List<Models.DTO.Walk>>(walks);

            return Ok(WalkDTO);
        }
        //[HttpGet]
        //public async Task<IActionResult> GetWalkAsync(Guid id)
        //{
        //    var walk = await walkRepository.GetAsync(id);
        //    if (walk == null)
        //    {
        //        return NotFound();
        //    }
        //    var regionDTO = mapper.Map<Models.DTO.Walk>(walk);
        //    return Ok(regionDTO);
        //}
       // [HttpPost]
       
    }
}
